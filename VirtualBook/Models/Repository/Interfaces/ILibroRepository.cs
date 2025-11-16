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
    }
}
