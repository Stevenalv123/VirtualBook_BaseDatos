using VirtualBook.Controller;

namespace VirtualBook.Views
{
    public partial class RegisterForm : Form
    {
        bool visible = false;
        private readonly ApiClient _apiClient;
        public RegisterForm()
        {
            InitializeComponent();
            _apiClient = ApiClient.Instance;
        }
    }
}
