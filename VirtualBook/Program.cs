using Newtonsoft.Json;
using VirtualBook.DTOs;
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
            int id = Cookies.GetId();
            int rol = Cookies.GetRol();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            switch (rol)
            {
                case 1:
                    Application.Run(new AdministradorMainForm(id));
                    break;
                case 2:
                    Application.Run(new DocentesMainForm(id));
                    break;
                case 3:
                    Application.Run(new MainForm(id));
                    break;
                default:
                    Application.Run(new LoginForm()); 
                    break;
            }
        }
    }
}
