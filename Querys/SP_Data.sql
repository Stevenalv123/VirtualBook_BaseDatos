USE Db_VirtualBook;
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

-- Dar permisos
GRANT EXECUTE ON sp_ObtenerAutores TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerCategorias TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerFormatos TO virtualbooksystemUser;
GRANT EXECUTE ON sp_ObtenerIdiomas TO virtualbooksystemUser;
GO