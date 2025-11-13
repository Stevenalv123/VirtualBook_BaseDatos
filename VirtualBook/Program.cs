using Newtonsoft.Json;
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
            Application.Run(new LoginForm());
        }
    }
}
