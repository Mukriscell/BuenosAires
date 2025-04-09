using System;

namespace BuenosAires.BodegaBA
{
    partial class VentanaConsultarBodega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_PROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD_PROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISPO_PROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos Disponibles en Bodega ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buenos Aires";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "(Vista de Bodeguero y Administrador)";
            // 
            // grid
            // 
            this.grid.AllowUserToOrderColumns = true;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.NOM_PROD,
            this.CANTIDAD_PROD,
            this.DISPO_PROD});
            this.grid.Location = new System.Drawing.Point(12, 179);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(776, 259);
            this.grid.TabIndex = 4;
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_PRODUCTO.DataPropertyName = "id_producto";
            this.ID_PRODUCTO.FillWeight = 60.91373F;
            this.ID_PRODUCTO.HeaderText = "ID PROD";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // NOM_PROD
            // 
            this.NOM_PROD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOM_PROD.FillWeight = 179.7587F;
            this.NOM_PROD.HeaderText = "Nombre Producto";
            this.NOM_PROD.Name = "NOM_PROD";
            // 
            // CANTIDAD_PROD
            // 
            this.CANTIDAD_PROD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CANTIDAD_PROD.FillWeight = 55.21474F;
            this.CANTIDAD_PROD.HeaderText = "Cantidad";
            this.CANTIDAD_PROD.Name = "CANTIDAD_PROD";
            // 
            // DISPO_PROD
            // 
            this.DISPO_PROD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DISPO_PROD.FillWeight = 104.113F;
            this.DISPO_PROD.HeaderText = "Disponibles";
            this.DISPO_PROD.Name = "DISPO_PROD";
            // 
            // VentanaConsultarBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaConsultarBodega";
            this.Text = "BodegaBA";
            this.Load += new System.EventHandler(this.VentanaConsultarBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_PROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_PROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISPO_PROD;

        // Método agregado para manejar el evento Click de label1
        private void label1_Click(object sender, EventArgs e)
        {
            // Puedes dejar este método vacío o agregar funcionalidad según sea necesario
        }
    }
}
