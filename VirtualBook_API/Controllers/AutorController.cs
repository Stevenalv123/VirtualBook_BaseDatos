using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using VirtualBook_API.Data;
using VirtualBook_API.DTO;

namespace VirtualBook_API.Controllers
{
    public class AutorController : Controller
    {
        private readonly DbContext _dbContext;
        public AutorController(DbContext dbContext)
        {
            _dbContext= dbContext;
        }

        //[HttpPost]
        //[Authorize(Roles = "Administrador, Docente")]
        //public async Task<IActionResult> AgregarAutores(AutorDTO autor)
        //{
        //    try
        //    {
        //        await using var connection = _dbContext.GetConnection();
        //        var command = new SqlCommand(Procedimientos.SP_CrearAutor, connection)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };
        //        await command.ExecuteNonQueryAsync();

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
    }
}
