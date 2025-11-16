USE Db_VirtualBook;
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

-- No olvides dar permisos al usuario de la aplicación
GRANT EXECUTE ON sp_ObtenerLibros TO virtualbooksystemUser;
GO