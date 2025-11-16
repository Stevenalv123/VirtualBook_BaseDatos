USE Db_VirtualBook;
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

GRANT EXECUTE ON sp_InsertarLibro TO virtualbooksystemUser;
GO

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

GRANT EXECUTE ON sp_ObtenerIdUsuarioPorCorreo TO virtualbooksystemUser;
GO