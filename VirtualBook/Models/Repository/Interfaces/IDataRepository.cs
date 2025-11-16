using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBook.Models.DTO;

namespace VirtualBook.Models.Repository.Interfaces
{
    public interface IDataRepository
    {
        Task<List<DataDto>> GetAutoresAsync();
        Task<List<DataDto>> GetCategoriasAsync();
        Task<List<DataDto>> GetFormatosAsync();
        Task<List<DataDto>> GetIdiomasAsync();
    }
}
