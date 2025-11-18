USE Db_VirtualBook;
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
        -- Datos del Publicador
        p.Nombres + ' ' + p.Apellidos AS PublicadorNombre,
        p.FotoPerfil AS PublicadorFotoPerfil, -- Ruta de la foto
        p.IdUsuario AS PublicadorId,
        -- Concatenamos todos los autores
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

GRANT EXECUTE ON sp_ObtenerDetallesLibro TO virtualbooksystemUser;
GO

