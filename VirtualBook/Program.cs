using VirtualBook.Controller;
using VirtualBook.Views;
using VirtualBook.Views.AdminViews;
using VirtualBook.Views.DocentesViews;

namespace VirtualBook
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            string tokenGuardado = VirtualBook.Properties.Settings.Default.UserToken;

            if (!string.IsNullOrEmpty(tokenGuardado))
            {
                ApiClient.Instance.SetAuthToken(tokenGuardado);

                int? idRol = ObtenerRolDesdeApi();

                if (idRol.HasValue)
                {
                    switch (idRol.Value)
                    {
                        case 1:
                            Application.Run(new AdministradorMainForm()); 
                            return;

                        case 2: 
                            Application.Run(new DocentesMainForm());
                            return;

                        case 3: 
                            Application.Run(new MainForm());
                            return;

                        default:
                            break;
                    }
                }
            }

            Application.Run(new LoginForm());
        }

        private static int? ObtenerRolDesdeApi()
        {
            try
            {
                var perfil = ApiClient.Instance.LoginUsers.GetMyProfileAsync().GetAwaiter().GetResult();

                if (perfil != null)
                {
                    return perfil.IdRol; 
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
