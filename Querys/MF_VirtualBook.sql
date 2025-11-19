USE master;
GO

CREATE DATABASE Db_VirtualBook;
GO

USE Db_VirtualBook;
GO

CREATE TABLE Rol (
    IdRol INT IDENTITY(1,1),
    NombreRol NVARCHAR(30) NOT NULL,

    CONSTRAINT PK_Rol PRIMARY KEY (IdRol)
);

INSERT INTO Rol (NombreRol) VALUES ('Administrador'),
                                   ('Docente'),
                                   ('Estudiante');

CREATE TABLE Usuario (
    IdUsuario INT IDENTITY(1,1),
    Nombres VARCHAR(50) NOT NULL,
    Apellidos VARCHAR(50) NOT NULL,
    Correo_Electronico VARCHAR(100) NOT NULL,
	Contrasena VARBINARY(32) NOT NULL,
    FotoPerfil NVARCHAR(MAX) NULL,
    IdRol INT NOT NULL FOREIGN KEY REFERENCES Rol(IdRol),
    FechaNacimiento DATETIME,
    Genero VARCHAR(10) CHECK (Genero IN ('Masculino', 'Femenino')),
	Estado BIT NOT NULL DEFAULT 1,
	CONSTRAINT UQ_Correo_Usuario UNIQUE (Correo_Electronico),
    CONSTRAINT PK_Usuario PRIMARY KEY (IdUsuario)
);

CREATE TABLE Autor (
    IdAutor INT IDENTITY(1,1),
    NombreAutor VARCHAR(50) NOT NULL,
	Biografia VARCHAR(200),
	FechaNacimiento Date,
	Nacionalidad VARCHAR(30)

    CONSTRAINT PK_Autor PRIMARY KEY (IdAutor)
);

CREATE TABLE Categoria (
    IdCategoria INT IDENTITY(1,1),
    NombreCategoria VARCHAR(50) NOT NULL,

    CONSTRAINT PK_Categoria PRIMARY KEY (IdCategoria)
);

INSERT INTO Categoria (NombreCategoria)
VALUES 
('Matemáticas'),
('Física'),
('Química'),
('Biología'),
('Historia'),
('Literatura'),
('Informática'),
('Economía'),
('Psicología'),
('Filosofía'),
('Arte'),
('Ingeniería'),
('Medicina'),
('Derecho'),
('Idiomas');

CREATE TABLE Formato (
    IdFormato INT IDENTITY(1,1) PRIMARY KEY,
    NombreFormato VARCHAR(20) UNIQUE NOT NULL
);

CREATE TABLE Idioma (
	IdIdioma INT IDENTITY(1,1) PRIMARY KEY,
	NombreIdioma VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE Libro (
    IdLibro INT IDENTITY(1,1),
    Titulo VARCHAR(100) NOT NULL,
    IdPublicador INT NOT NULL,
    IdCategoria INT NOT NULL,
    IdFormato INT NOT NULL,
    ArchivoPDF NVARCHAR(300) NOT NULL,
    Portada NVARCHAR(300) NOT NULL,
    IdIdioma INT,
    NumeroPaginas INT CHECK (NumeroPaginas > 0),
    FechaPublicacion DATETIME DEFAULT GETDATE() NOT NULL,
    Descripcion NVARCHAR(MAX),
	Descargas INT NOT NULL CHECK (Descargas > 0),

    CONSTRAINT PK_Libro PRIMARY KEY (IdLibro),
    CONSTRAINT FK_Publicador_Libro FOREIGN KEY (IdPublicador) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FK_Categoria_Libro FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria),
	CONSTRAINT FK_Formato_Libro FOREIGN KEY (IdFormato) REFERENCES Formato(IdFormato),
	CONSTRAINT FK_Idioma_Libro FOREIGN KEY (IdIdioma) REFERENCES Idioma(IdIdioma)
);

CREATE TABLE Libro_Autor (
    IdAutor INT NOT NULL,
    IdLibro INT NOT NULL,

    CONSTRAINT PK_LibroAutor PRIMARY KEY (IdAutor, IdLibro),
    CONSTRAINT FK_Autor FOREIGN KEY (IdAutor) REFERENCES Autor(IdAutor),
    CONSTRAINT FK_Libro FOREIGN KEY (IdLibro) REFERENCES Libro(IdLibro)
);

CREATE TABLE Favoritos (
    IdUsuario INT NOT NULL,
    IdLibro INT NOT NULL,

    CONSTRAINT PK_Favorito PRIMARY KEY (IdUsuario, IdLibro),
    CONSTRAINT FK_Usuario_Favorito FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FK_Libro_Favorito FOREIGN KEY (IdLibro) REFERENCES Libro(IdLibro),
    CONSTRAINT UQ_Favoritos UNIQUE (IdUsuario, IdLibro)
);

CREATE TABLE Reseña (
    IdUsuario INT NOT NULL,
    IdLibro INT NOT NULL,
    Calificacion INT CHECK (Calificacion BETWEEN 1 AND 5) NOT NULL,
    Comentario NVARCHAR(MAX),
    FechaReseña DATETIME DEFAULT GETDATE() NOT NULL,

    CONSTRAINT PK_Reseña PRIMARY KEY (IdUsuario, IdLibro),
    CONSTRAINT FK_Usuario_Reseña FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FK_Libro_Reseña FOREIGN KEY (IdLibro) REFERENCES Libro(IdLibro),
    CONSTRAINT UQ_Reseña UNIQUE (IdUsuario, IdLibro)
);

CREATE TABLE Seguimiento (
    IdSeguimiento INT IDENTITY(1,1),
    IdSeguidor INT NOT NULL,
    IdSeguido INT NOT NULL,
    FechaSeguimiento DATETIME DEFAULT GETDATE() NOT NULL,
    
    CONSTRAINT PK_Seguimiento PRIMARY KEY (IdSeguimiento),
    CONSTRAINT FK_Seguidor FOREIGN KEY (IdSeguidor) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FK_Seguido FOREIGN KEY (IdSeguido) REFERENCES Usuario(IdUsuario),
    CONSTRAINT UQ_Seguimiento UNIQUE (IdSeguidor, IdSeguido)
);

CREATE TABLE Notificacion (
    IdNotificacion INT IDENTITY(1,1),
    IdUsuario INT NOT NULL,
    IdLibro INT,
    FechaNotificacion DATETIME DEFAULT GETDATE() NOT NULL,
    Leido BIT DEFAULT 0 NOT NULL,
	Mensaje NVARCHAR(255),
    TipoNotificacion VARCHAR(50) CHECK (TipoNotificacion IN ('NuevoLibro', 'ReseñaRecibida', 'SeguidorNuevo', 'Comentario')),

    CONSTRAINT PK_Notificacion PRIMARY KEY (IdNotificacion),
    CONSTRAINT FK_Notificacion_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FK_Notificacion_Libro FOREIGN KEY (IdLibro) REFERENCES Libro(IdLibro)
);

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
CREATE PROCEDURE sp_ValidarUsuario
	@CorreoUsuario varchar(100),
	@Contrasena nvarchar(64)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Hash varbinary(32) = HASHBYTES('SHA2_256', CAST(@Contrasena AS nvarchar(256)));

	SELECT u.IdUsuario, 
        u.Nombres, 
        u.Apellidos, 
        u.Correo_Electronico, 
        u.FotoPerfil, 
        u.IdRol,
        r.NombreRol,
        u.FechaNacimiento,
        u.Genero 
	FROM Usuario u
	INNER JOIN Rol r ON u.IdRol = r.IdRol
	WHERE u.Correo_Electronico = @CorreoUsuario
	AND u.Contrasena = @Hash
    AND u.Estado = 1;
END;
GO

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

--Actualizar usuario
CREATE PROCEDURE sp_ActualizarUsuario
    @IdUsuario INT,
    @Nombres NVARCHAR(100),
    @Apellidos NVARCHAR(100),
    @FechaNacimiento DATE,
    @Genero NVARCHAR(20),
    @FotoPerfil NVARCHAR(MAX) = NULL -- Opcional
AS
BEGIN
    UPDATE Usuario
    SET 
        Nombres = @Nombres,
        Apellidos = @Apellidos,
        FechaNacimiento = @FechaNacimiento,
        Genero = @Genero,
        FotoPerfil = ISNULL(@FotoPerfil, FotoPerfil) 
    WHERE IdUsuario = @IdUsuario;
END;
GO

CREATE PROCEDURE sp_Actualizar_Descargas
	@IdLibro INT
AS
BEGIN
	UPDATE Libro
	SET
		Descargas = Descargas + 1
	WHERE IdLibro = @IdLibro
END;
GO

CREATE PROCEDURE sp_ObtenerDetallesLibro
    @IdLibro INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        l.IdLibro,
        l.Titulo,
        l.Portada,
        l.ArchivoPDF,
        l.Descripcion,
        l.NumeroPaginas,
        l.FechaPublicacion,
        c.NombreCategoria,
        f.NombreFormato,
        i.NombreIdioma,
		l.Descargas,
        p.Nombres + ' ' + p.Apellidos AS PublicadorNombre,
        p.FotoPerfil AS PublicadorFotoPerfil, 
        p.IdUsuario AS PublicadorId,
        (SELECT STRING_AGG(a.NombreAutor, ', ')
         FROM Autor a
         INNER JOIN Libro_Autor la ON a.IdAutor = la.IdAutor
         WHERE la.IdLibro = l.IdLibro) AS Autores
    FROM
        Libro l
    LEFT JOIN Categoria c ON l.IdCategoria = c.IdCategoria
    LEFT JOIN Formato f ON l.IdFormato = f.IdFormato
    LEFT JOIN Idioma i ON l.IdIdioma = i.IdIdioma
    LEFT JOIN Usuario p ON l.IdPublicador = p.IdUsuario
    WHERE
        l.IdLibro = @IdLibro;
END;
GO

CREATE PROCEDURE sp_RegistrarAutor
    @NombreAutor VARCHAR(50),
    @Biografia VARCHAR(200) = NULL,
    @FechaNacimiento DATE = NULL,
    @Nacionalidad VARCHAR(30) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Autor (NombreAutor, Biografia, FechaNacimiento, Nacionalidad)
    VALUES (@NombreAutor, @Biografia, @FechaNacimiento, @Nacionalidad);

    SELECT CAST(SCOPE_IDENTITY() AS INT) as IdAutor;
END
GO

CREATE OR ALTER PROCEDURE sp_ObtenerFavoritosPorUsuario
    @IdUsuario INT
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
        u.Nombres + ' ' + u.Apellidos AS Publicador,
        STRING_AGG(a.NombreAutor, ', ') AS Autores
    FROM Libro l
    INNER JOIN Favoritos fav ON l.IdLibro = fav.IdLibro
    INNER JOIN Categoria c ON l.IdCategoria = c.IdCategoria
    INNER JOIN Formato f ON l.IdFormato = f.IdFormato
    INNER JOIN Idioma i ON l.IdIdioma = i.IdIdioma
    INNER JOIN Usuario u ON l.IdPublicador = u.IdUsuario
    LEFT JOIN Libro_Autor la ON l.IdLibro = la.IdLibro
    LEFT JOIN Autor a ON la.IdAutor = a.IdAutor
    WHERE fav.IdUsuario = @IdUsuario
    GROUP BY l.IdLibro, l.Titulo, l.Portada, l.Descripcion, l.NumeroPaginas,
             l.FechaPublicacion, l.Descargas, c.NombreCategoria, f.NombreFormato,
             i.NombreIdioma, u.Nombres, u.Apellidos;
END;
GO

CREATE OR ALTER PROCEDURE sp_ObtenerUsuarios
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        u.IdUsuario,
        u.Nombres,
        u.Apellidos,
        u.Correo_Electronico,
        r.NombreRol,
        u.FotoPerfil,
        u.Estado 
    FROM Usuario u
    INNER JOIN Rol r ON u.IdRol = r.IdRol;
END;
GO

CREATE OR ALTER PROCEDURE sp_CambiarEstadoUsuario
    @IdUsuario INT,
    @NuevoEstado BIT
AS
BEGIN
    UPDATE Usuario
    SET Estado = @NuevoEstado
    WHERE IdUsuario = @IdUsuario;
END;
GO

CREATE PROCEDURE SP_BuscarLibros
    @Termino NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        l.IdLibro,
        l.Titulo,
        l.Portada,
        l.Descripcion,
        l.FechaPublicacion,
        l.NumeroPaginas,
        l.Descargas,
        c.NombreCategoria,
        f.NombreFormato,
        i.NombreIdioma,
        u.Nombres + ' ' + u.Apellidos AS Publicador,
        STRING_AGG(a.NombreAutor, ', ') AS Autores
    FROM Libro l
    INNER JOIN Categoria c ON l.IdCategoria = c.IdCategoria
    INNER JOIN Formato f ON l.IdFormato = f.IdFormato
    INNER JOIN Idioma i ON l.IdIdioma = i.IdIdioma
    INNER JOIN Usuario u ON l.IdPublicador = u.IdUsuario
    LEFT JOIN Libro_Autor la ON l.IdLibro = la.IdLibro
    LEFT JOIN Autor a ON la.IdAutor = a.IdAutor
    WHERE 
        l.Titulo LIKE '%' + @Termino + '%' OR 
        a.NombreAutor LIKE '%' + @Termino + '%' OR
        c.NombreCategoria LIKE '%' + @Termino + '%'
    GROUP BY 
        l.IdLibro, l.Titulo, l.Portada, l.Descripcion, l.FechaPublicacion, 
        l.NumeroPaginas, l.Descargas, c.NombreCategoria, f.NombreFormato, 
        i.NombreIdioma, u.Nombres, u.Apellidos;
END;
GO

CREATE PROCEDURE sp_AgregarFavorito
    @IdUsuario INT,
    @IdLibro INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Favoritos WHERE IdUsuario = @IdUsuario AND IdLibro = @IdLibro)
    BEGIN
        INSERT INTO Favoritos (IdUsuario, IdLibro) VALUES (@IdUsuario, @IdLibro);
    END
END;
GO

CREATE PROCEDURE sp_EliminarFavorito
    @IdUsuario INT,
    @IdLibro INT
AS
BEGIN
    DELETE FROM Favoritos WHERE IdUsuario = @IdUsuario AND IdLibro = @IdLibro;
END;
GO

CREATE PROCEDURE sp_VerificarFavorito
    @IdUsuario INT,
    @IdLibro INT
AS
BEGIN
    SELECT CAST(CASE WHEN EXISTS (SELECT 1 FROM Favoritos WHERE IdUsuario = @IdUsuario AND IdLibro = @IdLibro) 
           THEN 1 ELSE 0 END AS BIT);
END;
GO

CREATE PROCEDURE sp_ObtenerReporteDescargas
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        l.IdLibro,
        l.Titulo,
        c.NombreCategoria AS Categoria,
        l.Descargas AS TotalDescargas,
        l.FechaPublicacion,

        (SELECT STRING_AGG(a.NombreAutor, ', ') 
         FROM Autor a 
         INNER JOIN Libro_Autor la ON a.IdAutor = la.IdAutor 
         WHERE la.IdLibro = l.IdLibro) AS Autores
    FROM Libro l
    INNER JOIN Categoria c ON l.IdCategoria = c.IdCategoria
    ORDER BY l.Descargas DESC;
END;
GO

CREATE OR ALTER PROCEDURE sp_PublicarReseña
    @IdUsuario INT,
    @IdLibro INT,
    @Comentario NVARCHAR(MAX),
    @Calificacion INT = 5
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO Reseña (IdUsuario, IdLibro, Comentario, Calificacion, FechaReseña)
    VALUES (@IdUsuario, @IdLibro, @Comentario, @Calificacion, GETDATE());
END;
GO

CREATE OR ALTER PROCEDURE sp_ObtenerResenasPorLibro
    @IdLibro INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        u.Nombres + ' ' + u.Apellidos AS NombreUsuario,
        u.FotoPerfil,
        r.Comentario,
        r.FechaReseña 
    FROM Reseña r
    INNER JOIN Usuario u ON r.IdUsuario = u.IdUsuario
    WHERE r.IdLibro = @IdLibro
    ORDER BY r.FechaReseña DESC;
END;
GO

CREATE PROCEDURE sp_ObtenerLibrosPorUsuario
    @IdPublicador INT
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
        p.Nombres + ' ' + p.Apellidos AS Publicador,
        (SELECT STRING_AGG(a.NombreAutor, ', ')
         FROM Autor a
         INNER JOIN Libro_Autor la ON a.IdAutor = la.IdAutor
         WHERE la.IdLibro = l.IdLibro) AS Autores
    FROM
        Libro l
    LEFT JOIN Categoria c ON l.IdCategoria = c.IdCategoria
    LEFT JOIN Formato f ON l.IdFormato = f.IdFormato
    LEFT JOIN Idioma i ON l.IdIdioma = i.IdIdioma
    LEFT JOIN Usuario p ON l.IdPublicador = p.IdUsuario
    WHERE
        l.IdPublicador = @IdPublicador
    ORDER BY
        l.FechaPublicacion DESC;
END;
GO

CREATE PROCEDURE SP_ToggleSeguimiento
    @IdSeguidor INT,
    @IdSeguido INT
AS
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (SELECT 1 FROM Seguimiento WHERE IdSeguidor = @IdSeguidor AND IdSeguido = @IdSeguido)
    BEGIN
        DELETE FROM Seguimiento WHERE IdSeguidor = @IdSeguidor AND IdSeguido = @IdSeguido;
        SELECT 0 AS Resultado;
    END
    ELSE
    BEGIN
        INSERT INTO Seguimiento (IdSeguidor, IdSeguido) VALUES (@IdSeguidor, @IdSeguido);
        SELECT 1 AS Resultado;
    END
END
GO

CREATE PROCEDURE SP_VerificarSeguimiento
    @IdSeguidor INT,
    @IdSeguido INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM Seguimiento WHERE IdSeguidor = @IdSeguidor AND IdSeguido = @IdSeguido)
        SELECT CAST(1 AS BIT) AS EsSeguidor;
    ELSE
        SELECT CAST(0 AS BIT) AS EsSeguidor;
END;
GO

CREATE TRIGGER TR_NotificarNuevoLibro
ON Libro
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Notificacion (IdUsuario, IdLibro, TipoNotificacion, Mensaje, FechaNotificacion, Leido)
    SELECT 
        S.IdSeguidor,                
        I.IdLibro,                   
        'NuevoLibro',                
        'El docente ' + U.Nombres + ' ha publicado: ' + I.Titulo, 
        GETDATE(),
        0                     
    FROM inserted I
    INNER JOIN Usuario U ON I.IdPublicador = U.IdUsuario
    INNER JOIN Seguimiento S ON I.IdPublicador = S.IdSeguido
END;
GO

CREATE TRIGGER TR_NotificarNuevoSeguidor
ON Seguimiento
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Notificacion (IdUsuario, IdLibro, TipoNotificacion, Mensaje, FechaNotificacion, Leido)
    SELECT 
        I.IdSeguido,                 
        NULL,                        
        'SeguidorNuevo',
        'El usuario ' + U.Nombres + ' ha comenzado a seguirte.',
        GETDATE(),
        0
    FROM inserted I
    INNER JOIN Usuario U ON I.IdSeguidor = U.IdUsuario 
END;
GO

CREATE PROCEDURE SP_ContarNotificacionesNoLeidas
    @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Notificacion 
    WHERE IdUsuario = @IdUsuario AND Leido = 0;
END
GO

CREATE PROCEDURE SP_ObtenerMisNotificaciones
    @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Notificacion 
    WHERE IdUsuario = @IdUsuario 
    ORDER BY FechaNotificacion DESC;
END
GO

CREATE PROCEDURE SP_MarcarNotificacionLeida
    @IdNotificacion INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Notificacion SET Leido = 1 WHERE IdNotificacion = @IdNotificacion;
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
GRANT EXECUTE ON sp_ActualizarUsuario TO virtualbooksystemUser;
GRANT EXECUTE ON sp_Actualizar_Descargas TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerDetallesLibro TO virtualbooksystemUser;
GRANT EXECUTE ON sp_RegistrarAutor TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerFavoritosPorUsuario TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerUsuarios TO virtualbooksystemUser;
GRANT EXECUTE ON sp_CambiarEstadoUsuario TO virtualbooksystemUser;
GRANT EXECUTE ON SP_BuscarLibros TO virtualbooksystemUser;
GRANT EXECUTE ON sp_AgregarFavorito TO virtualbooksystemUser;
GRANT EXECUTE ON sp_EliminarFavorito TO virtualbooksystemUser;
GRANT EXECUTE ON sp_VerificarFavorito TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerReporteDescargas TO virtualbooksystemUser;
GRANT EXECUTE ON sp_PublicarReseña TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerResenasPorLibro TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerLibrosPorUsuario TO virtualbooksystemUser;
GRANT EXECUTE ON SP_ToggleSeguimiento TO virtualbooksystemUser;
GRANT EXECUTE ON SP_VerificarSeguimiento TO virtualbooksystemUser;
GRANT EXECUTE ON SP_ContarNotificacionesNoLeidas TO virtualbooksystemUser;
GRANT EXECUTE ON SP_ObtenerMisNotificaciones TO virtualbooksystemUser;
GRANT EXECUTE ON SP_MarcarNotificacionLeida TO virtualbooksystemUser;
