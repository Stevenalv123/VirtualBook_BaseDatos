use master
go

if not exists (select * from sys.server_principals
	where name = 'virtualbooksystem')
	create login virtualbooksystem with password = 'vb1234';

use Db_VirtualBook
go

SELECT name, sid
FROM sys.database_principals
WHERE sid IN (SELECT sid FROM sys.server_principals WHERE name = 'virtualbooksystem');

create user virtualbooksystemUser for login virtualbooksystem;
go

--Procedimiento almacenado para validar las credenciales del usuario
create procedure sp_ValidarUsuario
	@CorreoUsuario varchar(100),
	@Contrasena nvarchar(64)
as
begin
	set nocount on;

	declare @Hash varbinary(32) = HASHBYTES('SHA2_256', cast(@Contrasena as nvarchar(256)));
	select u.IdUsuario, 
        u.Nombres, 
        u.Apellidos, 
        u.Correo_Electronico, 
        u.FotoPerfil, 
        u.IdRol,
        r.NombreRol,
        u.FechaNacimiento,
        u.Genero 
	from Usuario u
	inner join Rol r on u.IdRol = r.IdRol
	where u.Correo_Electronico = @CorreoUsuario
	and u.Contrasena = @Hash;
end;
go

--Procedimiento almacenado para registrar al usuario
create procedure sp_RegistrarUsuario
	@Nombres varchar(50),
	@Apellidos varchar(50),
	@Correo_Electronico varchar(100),
	@Contrasena nvarchar(64),
	@FotoPerfil nvarchar(max) = null,
	@IdRol int,
	@FechaNacimiento datetime,
	@Genero varchar(10)
as
begin
	set nocount on;
	
	declare @Hash varbinary(32) = Hashbytes('SHA2_256', Cast(@Contrasena as nvarchar(256)));
	insert into Usuario (Nombres, Apellidos, Correo_Electronico, Contrasena, FotoPerfil, IdRol, FechaNacimiento, Genero)
	values (@Nombres, @Apellidos, @Correo_Electronico, @Hash, @FotoPerfil, @IdRol, @FechaNacimiento, @Genero);
end;
go

--Procedimiento almacenado para encontrar al usuario por email y cargar su informacion
create procedure sp_ObtenerUsuarioPorCorreo
	@CorreoUsuario nvarchar(100)
as
begin
	set nocount on;
	
	select u.IdUsuario,
			u.Nombres,
			u.Apellidos,
			u.Correo_Electronico,
			u.FotoPerfil,
			u.IdRol,
			r.NombreRol,
			u.FechaNacimiento,
			u.Genero
	from Usuario u
	inner join Rol r on u.IdRol=r.IdRol
	where u.Correo_Electronico = @CorreoUsuario
end;
go

-- SP para obtener el IdUsuario a partir del email
CREATE PROCEDURE sp_ObtenerIdUsuarioPorCorreo
    @CorreoUsuario VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdUsuario 
    FROM Usuario
    WHERE Correo_Electronico = @CorreoUsuario;
END;
GO

CREATE PROCEDURE sp_ObtenerRoles
AS
BEGIN
	SET NOCOUNT ON;
	Select IdRol, NombreRol FROM Rol
END;
GO

CREATE PROCEDURE sp_VerificarCorreoExiste
	@CorreoVerificar NVARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;
	IF EXISTS (Select 1 from Usuario where Correo_Electronico = @CorreoVerificar)
	BEGIN
        SELECT CAST(1 AS BIT) AS Existe;
    END
    ELSE
    BEGIN
        SELECT CAST(0 AS BIT) AS Existe;
    END
END;
GO

CREATE PROCEDURE sp_InsertarLibro
    @Titulo VARCHAR(100),
    @IdPublicador INT,
    @IdCategoria INT,
    @IdFormato INT,
    @IdIdioma INT,
    @ArchivoPDF_Path NVARCHAR(300),
    @Portada_Path NVARCHAR(300),
    @Descripcion NVARCHAR(MAX) = NULL,
    @NumeroPaginas INT = NULL,
    @IdsAutoresCSV VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    DECLARE @IdLibroNuevo INT;

    BEGIN TRY
        INSERT INTO Libro (
            Titulo, IdPublicador, IdCategoria, IdFormato,
            ArchivoPDF, Portada, IdIdioma, NumeroPaginas,
            FechaPublicacion, Descripcion, Descargas
        )
        VALUES (
            @Titulo, @IdPublicador, @IdCategoria, @IdFormato,
            @ArchivoPDF_Path, @Portada_Path, @IdIdioma, @NumeroPaginas,
            GETDATE(), @Descripcion, 1
        );

        SET @IdLibroNuevo = SCOPE_IDENTITY();

        INSERT INTO Libro_Autor (IdLibro, IdAutor)
        SELECT @IdLibroNuevo, CAST(value AS INT)
        FROM STRING_SPLIT(@IdsAutoresCSV, ',');

        COMMIT TRANSACTION;

        SELECT @IdLibroNuevo AS NuevoIdLibro;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE sp_ObtenerLibros
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        l.IdLibro,
        l.Titulo,
        l.Portada,
        l.Descripcion,
        l.NumeroPaginas,
        l.FechaPublicacion,
        l.Descargas,
        c.NombreCategoria,
        f.NombreFormato,
        i.NombreIdioma,
        -- Obtenemos el nombre del publicador (Usuario)
        p.Nombres + ' ' + p.Apellidos AS Publicador,
        -- Concatenamos todos los autores de este libro
        (SELECT STRING_AGG(a.NombreAutor, ', ')
         FROM Autor a
         INNER JOIN Libro_Autor la ON a.IdAutor = la.IdAutor
         WHERE la.IdLibro = l.IdLibro) AS Autores
    FROM
        Libro l
    -- Usamos LEFT JOIN para no excluir libros si falta algún dato relacionado
    LEFT JOIN
        Categoria c ON l.IdCategoria = c.IdCategoria
    LEFT JOIN
        Formato f ON l.IdFormato = f.IdFormato
    LEFT JOIN
        Idioma i ON l.IdIdioma = i.IdIdioma
    LEFT JOIN
        Usuario p ON l.IdPublicador = p.IdUsuario
    ORDER BY
        l.FechaPublicacion DESC;
END;
GO

-- Obtener Autores
CREATE PROCEDURE sp_ObtenerAutores
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdAutor, NombreAutor FROM Autor ORDER BY NombreAutor;
END
GO

-- Obtener Categorías
CREATE PROCEDURE sp_ObtenerCategorias
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdCategoria, NombreCategoria FROM Categoria ORDER BY NombreCategoria;
END
GO

-- Obtener Formatos
CREATE PROCEDURE sp_ObtenerFormatos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdFormato, NombreFormato FROM Formato ORDER BY NombreFormato;
END
GO

-- Obtener Idiomas
CREATE PROCEDURE sp_ObtenerIdiomas
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdIdioma, NombreIdioma FROM Idioma ORDER BY NombreIdioma;
END
GO

grant execute on sp_ValidarUsuario to virtualbooksystemUser;
grant execute on sp_RegistrarUsuario to virtualbooksystemUser;
grant execute on sp_ObtenerUsuarioPorCorreo to virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerIdUsuarioPorCorreo TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerRoles TO virtualbooksystemUser;
GRANT EXECUTE ON sp_VerificarCorreoExiste TO virtualbooksystemUser;
GRANT EXECUTE ON sp_InsertarLibro TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerLibros TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerAutores TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerCategorias TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerFormatos TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerIdiomas TO virtualbooksystemUser;
go;