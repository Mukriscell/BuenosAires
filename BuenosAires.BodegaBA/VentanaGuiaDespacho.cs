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

            ConfigurarGrid();

            CargarDatos();

            ConfigurarEventos();

        }


        private void ConfigurarGrid()

        {

            gridDespacho.AutoGenerateColumns = false;

            gridDespacho.AllowUserToAddRows = false;

            gridDespacho.RowHeadersVisible = false;

            gridDespacho.BackgroundColor = Color.White;

            gridDespacho.BorderStyle = BorderStyle.Fixed3D;

            gridDespacho.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

        }


        private void CargarDatos()

        {

            gridDespacho.Rows.Add("11", "Aire Wifi 9000 btu", "Entregado", "1", "Ana Torres", "Despachado Imprimir Entregado");

            gridDespacho.Rows.Add("22", "Split Inv 12000 btu", "Despachado", "2", "Juan Perez", "Despachado Imprimir Entregado");

            gridDespacho.Rows.Add("88", "Anwo VP", "EnBodega", "8", "Ana Torres", "Despachado Imprimir Entregado");


            foreach (DataGridViewRow row in gridDespacho.Rows)

            {

                if (row.Cells["OPC"] is DataGridViewLinkCell linkCell)

                {

                    linkCell.LinkColor = Color.Blue;

                }

            }

        }


        private void ConfigurarEventos()

        {

            btnVolverMenuPrincipal.Click += BtnVolverMenuPrincipal_Click;

            gridDespacho.CellContentClick += GridDespacho_CellContentClick;

        }


        private void BtnVolverMenuPrincipal_Click(object sender, EventArgs e)

        {

            this.Close();

        }


        private void GridDespacho_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.ColumnIndex == gridDespacho.Columns["OPC"].Index && e.RowIndex >= 0)

            {

                string opcionSeleccionada = gridDespacho.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();



                // Aquí puedes agregar la lógica para cada opción

                if (opcionSeleccionada.Contains("Despachado"))

                {

                    MessageBox.Show("Opción Despachado seleccionada");

                }

                else if (opcionSeleccionada.Contains("Imprimir"))

                {

                    MessageBox.Show("Opción Imprimir seleccionada");

                }

                else if (opcionSeleccionada.Contains("Entregado"))

                {

                    MessageBox.Show("Opción Entregado seleccionada");

                }

            }

        }

    }

}