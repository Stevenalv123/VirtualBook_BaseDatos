USE Db_VirtualBook;
GO
-- =============================================
--procedimiento de obtener usuarios
-- =============================================
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
        u.FotoPerfil
    FROM Usuario u
    INNER JOIN Rol r ON u.IdRol = r.IdRol;
END;
GO

GRANT EXECUTE ON sp_ObtenerUsuarios TO virtualbooksystemUser;


--query para implementar estado de usuario
USE Db_VirtualBook;
GO

-- 1. Agregar la columna Estado a la tabla Usuario (Por defecto 1 = Activo)
ALTER TABLE Usuario
ADD Estado BIT NOT NULL DEFAULT 1;
GO

-- 2. Actualizar el SP de Obtener Usuarios (Para que devuelva el Estado)
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
        u.Estado -- Nueva columna
    FROM Usuario u
    INNER JOIN Rol r ON u.IdRol = r.IdRol;
END;
GO

-- 3. Actualizar el SP de Login (IMPORTANTE: Para que NO deje entrar a inactivos)
CREATE OR ALTER PROCEDURE sp_ValidarUsuario
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
    AND u.Estado = 1; -- Solo permite login si está Activo
END;
GO

-- 4. NUEVO SP: Para cambiar el estado (Activar/Desactivar)
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

-- 5. Dar permisos al nuevo SP
GRANT EXECUTE ON OBJECT::dbo.sp_CambiarEstadoUsuario TO virtualbooksystemUser;
GO

select * from Libro

update Libro set Descargas = 3 where IdLibro = 104