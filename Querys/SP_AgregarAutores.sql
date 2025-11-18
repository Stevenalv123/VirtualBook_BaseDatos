USE Db_VirtualBook;
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

GRANT EXECUTE ON sp_RegistrarAutor TO virtualbooksystemUser;
GO