public static class TemaManager
{
    public static bool ModoOscuroActivo { get; private set; } = false;

    private static readonly Color ColorFondoOscuro = Color.FromArgb(30, 30, 30);
    private static readonly Color ColorTextoClaro = Color.White;
    private static readonly Color ColorFondoClaro = Color.White;
    private static readonly Color ColorTextoOscuro = Color.Black;
    private static readonly Color ColorPanelIzquiero = Color.FromArgb(58, 177, 155);

    public static void AplicarTema(Form formulario, bool modoOscuro)
    {
        ModoOscuroActivo = modoOscuro;
        AplicarTemaAControl(formulario, modoOscuro);
    }

    private static void AplicarTemaAControl(Control control, bool oscuro)
    {
        if (control.Tag?.ToString() == "NoCambiarTema")
            return;

        if (control is DataGridView dgv)
        {
            if (oscuro)
            {
                dgv.BackgroundColor = Color.FromArgb(30, 30, 30);
                dgv.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
                dgv.DefaultCellStyle.ForeColor = Color.White;
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
                dgv.DefaultCellStyle.SelectionForeColor = Color.White;

                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 177, 155);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.EnableHeadersVisualStyles = false;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }
            else
            {
                dgv.BackgroundColor = Color.White;
                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.DefaultCellStyle.ForeColor = Color.Black;
                dgv.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 177, 155);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.EnableHeadersVisualStyles = false;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }

            return; 
        }

        if (oscuro)
        {
            control.BackColor = ColorFondoOscuro;
            control.ForeColor = ColorTextoClaro;
        }
        else
        {
            control.BackColor = ColorFondoClaro;
            control.ForeColor = ColorTextoOscuro;
        }

        foreach (Control child in control.Controls)
        {
            AplicarTemaAControl(child, oscuro);
        }
    }
}

