using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBook.Models.DTO;

namespace VirtualBook.Models.Repository.Interfaces
{
    public interface ILibroRepository
    {
        Task<List<LibroDto>> GetLibrosAsync();
        Task<bool> SubirLibroAsync(LibroUploadModel model);
        Task<LibroDetalleDTO?> GetLibroDetalleAsync(int idLibro);
        Task<bool> AgregarFavoritoAsync(int idLibro);
        Task<bool> EliminarFavoritoAsync(int idLibro);
        Task<bool> VerificarFavoritoAsync(int idLibro);
    }
}
