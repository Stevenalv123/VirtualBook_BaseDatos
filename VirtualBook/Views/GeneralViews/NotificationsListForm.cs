using VirtualBook.Controller;

namespace VirtualBook.Views.GeneralViews
{
    public partial class NotificationsListForm : Form
    {
        public NotificationsListForm()
        {
            InitializeComponent();
            _ = CargarLista();
        }

        private async Task CargarLista()
        {
            var lista = await ApiClient.Instance.Notificaciones.ObtenerMisNotificacionesAsync();

            DgvNotificaciones.DataSource = lista;

            foreach (var notif in lista)
            {
                if (!notif.Leido)
                {
                    _ = ApiClient.Instance.Notificaciones.MarcarComoLeidaAsync(notif.IdNotificacion);
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
