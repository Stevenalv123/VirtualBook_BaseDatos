USE Db_VirtualBook;
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
        -- Concatenamos autores si hay varios
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

GRANT EXECUTE ON OBJECT::dbo.sp_ObtenerFavoritosPorUsuario TO virtualbooksystemUser;
GO


