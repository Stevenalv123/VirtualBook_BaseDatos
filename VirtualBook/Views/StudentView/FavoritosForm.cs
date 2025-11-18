namespace VirtualBook.Views
{
    public partial class FavoritosForm : Form
    {
        private string baseUrl = "https://localhost:7014/api/favoritos/";
        private HttpClient cliente = new();
        private IMainForm mainform;
        public FavoritosForm(IMainForm mf)
        {
            InitializeComponent();
            mainform = mf;
            /*GetFavoritos();*/
        }

        //private async void GetFavoritos()
        //{
        //    var response = await cliente.GetAsync($"{baseUrl}{Cookies.GetId()}");
        //    response.EnsureSuccessStatusCode();
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var json=await response.Content.ReadAsStringAsync();
          
        //    }
        //    else
        //    {
        //        var errorMessage = await response.Content.ReadAsStringAsync();
        //        MessageBox.Show($"Error al cargar los libros favoritos. {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //} 
    }
}
