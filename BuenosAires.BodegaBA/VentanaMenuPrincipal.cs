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
    public partial class VentanaMenuPrincipal : Form
    {
        public VentanaMenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void VentanaMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarProductosEnBodega_Click(object sender, EventArgs e)
        {
            VentanaConsultarBodega ventanaConsultar = new VentanaConsultarBodega();
            ventanaConsultar.Show();
            this.Hide();
        }

        private void btnAdministrarGD_Click(object sender, EventArgs e)
        {
            VentanaGuiaDespacho ventanaGD = new VentanaGuiaDespacho();
            ventanaGD.Show();
            this.Hide();
        }

        private void btnReservarAnwo_Click(object sender, EventArgs e)
        {
            VentanaReservarAnwo ventanaReservar = new VentanaReservarAnwo();
            ventanaReservar.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}