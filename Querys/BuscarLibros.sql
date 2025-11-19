CREATE PROCEDURE SP_BuscarLibros
    @Termino NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    -- Seleccionamos las mismas columnas que en SP_ObtenerLibros para reutilizar el DTO
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
        -- Concatenamos autores si hay varios
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
END


select * from Libro