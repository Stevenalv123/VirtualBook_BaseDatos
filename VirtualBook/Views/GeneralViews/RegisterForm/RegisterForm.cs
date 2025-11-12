namespace VirtualBook.Views
{
    public partial class RegisterForm : Form
    {
        bool visible = false;
        private HttpClient cliente=new();
        public RegisterForm()
        {
            InitializeComponent();
        }
    }
}
