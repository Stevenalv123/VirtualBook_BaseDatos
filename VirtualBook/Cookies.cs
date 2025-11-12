using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook
{
    public class CookieUsuario
    {
        public int Id { get; set; }
        public int Rol { get; set; }
    }

    public class Cookies
    {
        public static string _path = Path.Combine(Directory.GetCurrentDirectory(), "cookie.json");
        public static void GuardarCookie(int id, int rol)
        {
            var usuario = new CookieUsuario
            {
                Id = id,
                Rol = rol
            };
            string json= JsonConvert.SerializeObject(usuario,Formatting.Indented);
            File.WriteAllText(_path, json);
        }

        public static int GetId()
        {
            try
            {
                if (!File.Exists(_path))
                    return 0;

                string contenido = File.ReadAllText(_path);
                var usuario = JsonConvert.DeserializeObject<CookieUsuario>(contenido);
                return usuario?.Id ?? 0;
            }
            catch
            {
                return 0;
            }
        }

        public static int GetRol()
        {
            try
            {
                if (!File.Exists(_path))
                    return 0;

                string contenido = File.ReadAllText(_path);
                var usuario = JsonConvert.DeserializeObject<CookieUsuario>(contenido);
                return usuario?.Rol ?? 0;
            }
            catch
            {
                return 0;
            }
        }

        public static void EliminarCookie()
        {
            File.Delete(_path);
        }
    }
}
