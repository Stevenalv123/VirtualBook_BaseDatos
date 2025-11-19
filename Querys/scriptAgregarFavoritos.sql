USE Db_VirtualBook;
GO

-- 1. Agregar a Favoritos
CREATE OR ALTER PROCEDURE sp_AgregarFavorito
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

-- 2. Eliminar de Favoritos
CREATE OR ALTER PROCEDURE sp_EliminarFavorito
    @IdUsuario INT,
    @IdLibro INT
AS
BEGIN
    DELETE FROM Favoritos WHERE IdUsuario = @IdUsuario AND IdLibro = @IdLibro;
END;
GO

-- 3. Verificar si es Favorito (devuelve true/false)
CREATE OR ALTER PROCEDURE sp_VerificarFavorito
    @IdUsuario INT,
    @IdLibro INT
AS
BEGIN
    SELECT CAST(CASE WHEN EXISTS (SELECT 1 FROM Favoritos WHERE IdUsuario = @IdUsuario AND IdLibro = @IdLibro) 
           THEN 1 ELSE 0 END AS BIT);
END;
GO

-- Dar permisos a la API
GRANT EXECUTE ON sp_AgregarFavorito TO virtualbooksystemUser;
GRANT EXECUTE ON sp_EliminarFavorito TO virtualbooksystemUser;
GRANT EXECUTE ON sp_VerificarFavorito TO virtualbooksystemUser;
GO