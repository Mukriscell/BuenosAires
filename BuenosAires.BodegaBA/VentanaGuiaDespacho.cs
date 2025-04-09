using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuenosAires.BodegaBA
{
    public partial class VentanaGuiaDespacho : Form
    {
        public VentanaGuiaDespacho()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            VentanaMenuPrincipal ventanaMenu = new VentanaMenuPrincipal();
            ventanaMenu.Show();
            this.Hide();
        }

        private void gridDespacho_CellContent_Load(object sender, DataGridViewCellEventArgs e)
        {
            gridDespacho.Rows.Add("11", "Aire Wifi 9000 btu", "1", "DISPONIBLE", "Ana Torres", "Despachado Imprimir Entregado");
            gridDespacho.Rows.Add("22", "Split Inv 12000 btu", "2", "DISPONIBLE", "Juan Perez", "Despachado Imprimir Entregado");
            gridDespacho.Rows.Add("88", "Anwo VP", "8", "DISPONIBLE", "Ana Torres", "Despachado Imprimir Entregado");

            // Estilo de filas alternadas
            gridDespacho.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

        }
    }
}
