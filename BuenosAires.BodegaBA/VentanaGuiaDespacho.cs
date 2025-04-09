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
    }
}
