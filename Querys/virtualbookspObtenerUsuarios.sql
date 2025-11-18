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
