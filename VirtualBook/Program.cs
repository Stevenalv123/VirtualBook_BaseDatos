using VirtualBook.Controller;
using VirtualBook.Views;

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
                bool esValido = ValidarTokenApi();

                if(esValido)
                {
                    Application.Run(new MainForm());
                    return;
                }
            }

            Application.Run(new LoginForm());
        }

        private static bool ValidarTokenApi()
        {
            try
            {
                var perfil = ApiClient.Instance.LoginUsers.GetMyProfileAsync().GetAwaiter().GetResult();
                return perfil != null;
            }
            catch
            {
                return false;
            }
        }
    }
}
