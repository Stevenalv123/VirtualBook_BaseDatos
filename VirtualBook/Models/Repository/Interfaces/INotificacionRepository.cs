using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBook.Models.DTO;

namespace VirtualBook.Models.Repository.Interfaces
{
    public interface INotificacionRepository
    {
        Task<int> ObtenerConteoNoLeidasAsync();
        Task<List<NotificacionDTO>> ObtenerMisNotificacionesAsync();
        Task MarcarComoLeidaAsync(int idNotificacion);
    }
}
