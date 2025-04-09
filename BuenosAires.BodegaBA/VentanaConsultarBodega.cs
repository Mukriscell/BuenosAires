using System.Drawing;
using System.Windows.Forms;
using System;

namespace BuenosAires.BodegaBA
{
    public partial class VentanaConsultarBodega : Form
    {
        public VentanaConsultarBodega()
        {
            InitializeComponent();
        }

        private void VentanaConsultarBodega_Load(object sender, EventArgs e)
        {
            // Agregar filas con los datos
            gridProductos.Rows.Add("11111", "Aire Wifi 9000 btu", "1", "DISPONIBLE");
            gridProductos.Rows.Add("22222", "Split Inv 12000 btu", "2", "DISPONIBLE");
            gridProductos.Rows.Add("88888", "Anwo VP", "8", "DISPONIBLE");
            gridProductos.Rows.Add("90001", "Aire Wifi 9000 btu", "3", "DISPONIBLE");
            gridProductos.Rows.Add("90002", "Anwo VP", "7", "DISPONIBLE");
            gridProductos.Rows.Add("90003", "Anwo Portátil", "2", "DISPONIBLE");
            gridProductos.Rows.Add("90004", "Kendal 12000", "1", "DISPONIBLE");
            gridProductos.Rows.Add("90005", "Aire Wifi 9000 btu", "0", "AGOTADO");
            gridProductos.Rows.Add("90006", "Anwo VP", "0", "AGOTADO");

            // Estilo de filas alternadas
            gridProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VentanaMenuPrincipal ventanaMenu = new VentanaMenuPrincipal();
            ventanaMenu.Show();
            this.Hide();
        }

        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
