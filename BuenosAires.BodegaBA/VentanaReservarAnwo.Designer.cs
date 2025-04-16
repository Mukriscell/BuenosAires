namespace BuenosAires.BodegaBA
{
    partial class VentanaReservarAnwo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridEquipos = new System.Windows.Forms.DataGridView();
            this.NRO_SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMB_PROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESERVADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPC = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buenos Aires";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reserva de Equipos ANWO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(249, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Productos Disponibles en ANWO";
            // 
            // gridEquipos
            // 
            this.gridEquipos.AllowUserToAddRows = false;
            this.gridEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NRO_SERIE,
            this.NOMB_PROD,
            this.PRECIO,
            this.RESERVADO,
            this.OPC});
            this.gridEquipos.Location = new System.Drawing.Point(23, 127);
            this.gridEquipos.Name = "gridEquipos";
            this.gridEquipos.Size = new System.Drawing.Size(750, 300);
            this.gridEquipos.TabIndex = 3;
            this.gridEquipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEquipos_CellContentClick);
            // 
            // NRO_SERIE
            // 
            this.NRO_SERIE.HeaderText = "Nro Serie";
            this.NRO_SERIE.Name = "NRO_SERIE";
            // 
            // NOMB_PROD
            // 
            this.NOMB_PROD.HeaderText = "Nombre Producto";
            this.NOMB_PROD.Name = "NOMB_PROD";
            this.NOMB_PROD.Width = 200;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "Precio";
            this.PRECIO.Name = "PRECIO";
            // 
            // RESERVADO
            // 
            this.RESERVADO.HeaderText = "Reservado";
            this.RESERVADO.Name = "RESERVADO";
            // 
            // OPC
            // 
            this.OPC.HeaderText = "Opciones";
            this.OPC.Name = "OPC";
            this.OPC.Width = 200;
            // 
            // btnVolverMenuPrincipal
            // 
            this.btnVolverMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVolverMenuPrincipal.Location = new System.Drawing.Point(298, 433);
            this.btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            this.btnVolverMenuPrincipal.Size = new System.Drawing.Size(180, 40);
            this.btnVolverMenuPrincipal.TabIndex = 4;
            this.btnVolverMenuPrincipal.Text = "Volver al menú principal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(157, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "(Vista de Bodeguero y Administrador)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // VentanaReservarAnwo
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridEquipos);
            this.Controls.Add(this.btnVolverMenuPrincipal);
            this.Name = "VentanaReservarAnwo";
            this.Text = "Sistema BodegaBA";
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridEquipos;
        private System.Windows.Forms.Button btnVolverMenuPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO_SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMB_PROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESERVADO;
        private System.Windows.Forms.DataGridViewLinkColumn OPC;
        private System.Windows.Forms.Label label4;
    }
}