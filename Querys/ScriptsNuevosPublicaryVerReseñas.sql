
--procedimiento para obtener los reportes de descargas
USE Db_VirtualBook;
GO

CREATE OR ALTER PROCEDURE sp_ObtenerReporteDescargas
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        l.IdLibro,
        l.Titulo,
        c.NombreCategoria AS Categoria,
        l.Descargas AS TotalDescargas,
        l.FechaPublicacion,

        (SELECT STRING_AGG(a.NombreAutor, ', ') 
         FROM Autor a 
         INNER JOIN Libro_Autor la ON a.IdAutor = la.IdAutor 
         WHERE la.IdLibro = l.IdLibro) AS Autores
    FROM Libro l
    INNER JOIN Categoria c ON l.IdCategoria = c.IdCategoria
    ORDER BY l.Descargas DESC;
END;
GO

GRANT EXECUTE ON sp_ObtenerReporteDescargas TO virtualbooksystemUser;
GO



--procedimiento para publicar reseñas, recordar que un usuario solo puede publicar una reseña

USE Db_VirtualBook;
GO
CREATE OR ALTER PROCEDURE sp_PublicarReseña
    @IdUsuario INT,
    @IdLibro INT,
    @Comentario NVARCHAR(MAX),
    @Calificacion INT = 5
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO Reseña (IdUsuario, IdLibro, Comentario, Calificacion, FechaReseña)
    VALUES (@IdUsuario, @IdLibro, @Comentario, @Calificacion, GETDATE());
END;
GO

GRANT EXECUTE ON sp_PublicarReseña TO virtualbooksystemUser;
GO




--procedimiento para obtener las resenas, lo puse con n porque daba conflicto no se pq


USE Db_VirtualBook;
GO


CREATE OR ALTER PROCEDURE sp_ObtenerResenasPorLibro
    @IdLibro INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        u.Nombres + ' ' + u.Apellidos AS NombreUsuario,
        u.FotoPerfil,
        r.Comentario,
        r.FechaReseña 
    FROM Reseña r
    INNER JOIN Usuario u ON r.IdUsuario = u.IdUsuario
    WHERE r.IdLibro = @IdLibro
    ORDER BY r.FechaReseña DESC;
END;
GO


GRANT EXECUTE ON sp_ObtenerResenasPorLibro TO virtualbooksystemUser;
GO