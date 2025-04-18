using System;
using System.Windows.Forms;

namespace BuenosAires.BodegaBA
{
    public partial class BodegaVistaVenta : Form
    {
        public BodegaVistaVenta()
        {
            InitializeComponent();
            CargarDatosEjemplo();
        }

        private void CargarDatosEjemplo()
        {
            // Agregar datos de ejemplo
            dgvProductos.Rows.Add("11111", "Aire Wifi 9000 btu", "1", "DISPONIBLE");
            dgvProductos.Rows.Add("22222", "Split Inv 12000 btu", "2", "DISPONIBLE");
            dgvProductos.Rows.Add("88888", "Anwo VP", "8", "DISPONIBLE");
            dgvProductos.Rows.Add("90001", "Aire Wifi 9000 btu", "3", "DISPONIBLE");
            dgvProductos.Rows.Add("90002", "Anwo VP", "7", "DISPONIBLE");
            dgvProductos.Rows.Add("90003", "Anwo Portátil", "2", "DISPONIBLE");
            dgvProductos.Rows.Add("90004", "Kendal 12000", "1", "DISPONIBLE");
            dgvProductos.Rows.Add("90005", "Aire Wifi 9000 btu", "0", "AGOTADO");
            dgvProductos.Rows.Add("90006", "Anwo VP", "0", "AGOTADO");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}