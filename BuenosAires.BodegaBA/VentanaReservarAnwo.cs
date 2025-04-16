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
    public partial class VentanaReservarAnwo : Form
    {
        public VentanaReservarAnwo()
        {
            InitializeComponent();
            ConfigurarGrid();
            CargarDatos();
        }
        private void ConfigurarGrid()
        {
            // Limpiar columnas existentes para evitar duplicados
            gridEquipos.Columns.Clear();

            // Configuración de columnas
            gridEquipos.Columns.Add("NroSerie", "Nro Serie");
            gridEquipos.Columns.Add("NombreProducto", "Nombre Producto");
            gridEquipos.Columns.Add("Precio", "Precio");
            gridEquipos.Columns.Add("Reservado", "Reservado");

            // Columna de opciones con un botón
            DataGridViewButtonColumn btnReservar = new DataGridViewButtonColumn
            {
                Name = "Opciones",
                HeaderText = "Opciones",
                Text = "Reservar",
                UseColumnTextForButtonValue = true
            };
            gridEquipos.Columns.Add(btnReservar);

            // Ajustes visuales
            gridEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridEquipos.AllowUserToAddRows = false;
        }

        private void CargarDatos()
        {
            // Datos de ejemplo
            gridEquipos.Rows.Add("11111", "Aire Wifi 9000 btu", "300000", "Sí");
            gridEquipos.Rows.Add("22222", "Split Inv 12000 btu", "400000", "Sí");
            gridEquipos.Rows.Add("88888", "Anwo VP", "300000", "No");
            gridEquipos.Rows.Add("90001", "Aire Wifi 9000 btu", "300000", "No");
            gridEquipos.Rows.Add("90002", "Anwo Portátil", "300000", "No");
            gridEquipos.Rows.Add("90003", "Kendal 12000", "400000", "No");
            gridEquipos.Rows.Add("90005", "Aire Wifi 9000 btu", "300000", "No");
            gridEquipos.Rows.Add("90006", "Anwo VP", "300000", "No");
        }

        private void gridEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridEquipos.Columns["Opciones"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show($"Reservando producto con Nro Serie: {gridEquipos.Rows[e.RowIndex].Cells["NroSerie"].Value}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            VentanaMenuPrincipal ventanaMenu = new VentanaMenuPrincipal();
            ventanaMenu.Show();
            this.Hide();    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
