namespace BuenosAires.BodegaBA
{
    partial class VentanaMenuPrincipal
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarProductosEnBodega = new System.Windows.Forms.Button();
            this.btnAdministrarGD = new System.Windows.Forms.Button();
            this.btnReservarAnwo = new System.Windows.Forms.Button();
            this.btnMantenedorProductos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Bodega - Menu Principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConsultarProductosEnBodega
            // 
            this.btnConsultarProductosEnBodega.Location = new System.Drawing.Point(195, 113);
            this.btnConsultarProductosEnBodega.Name = "btnConsultarProductosEnBodega";
            this.btnConsultarProductosEnBodega.Size = new System.Drawing.Size(208, 23);
            this.btnConsultarProductosEnBodega.TabIndex = 2;
            this.btnConsultarProductosEnBodega.Text = "Consultar productos en bodega";
            this.btnConsultarProductosEnBodega.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarGD
            // 
            this.btnAdministrarGD.Location = new System.Drawing.Point(195, 156);
            this.btnAdministrarGD.Name = "btnAdministrarGD";
            this.btnAdministrarGD.Size = new System.Drawing.Size(208, 23);
            this.btnAdministrarGD.TabIndex = 3;
            this.btnAdministrarGD.Text = "Administrar guias de despacho";
            this.btnAdministrarGD.UseVisualStyleBackColor = true;
            // 
            // btnReservarAnwo
            // 
            this.btnReservarAnwo.Location = new System.Drawing.Point(195, 199);
            this.btnReservarAnwo.Name = "btnReservarAnwo";
            this.btnReservarAnwo.Size = new System.Drawing.Size(208, 23);
            this.btnReservarAnwo.TabIndex = 4;
            this.btnReservarAnwo.Text = "Reservar equipos de ANWO";
            this.btnReservarAnwo.UseVisualStyleBackColor = true;
            // 
            // btnMantenedorProductos
            // 
            this.btnMantenedorProductos.Location = new System.Drawing.Point(195, 242);
            this.btnMantenedorProductos.Name = "btnMantenedorProductos";
            this.btnMantenedorProductos.Size = new System.Drawing.Size(208, 23);
            this.btnMantenedorProductos.TabIndex = 5;
            this.btnMantenedorProductos.Text = "Mantenedor de productos";
            this.btnMantenedorProductos.UseVisualStyleBackColor = true;
            this.btnMantenedorProductos.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(195, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(208, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // VentanaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 386);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMantenedorProductos);
            this.Controls.Add(this.btnReservarAnwo);
            this.Controls.Add(this.btnAdministrarGD);
            this.Controls.Add(this.btnConsultarProductosEnBodega);
            this.Controls.Add(this.label1);
            this.Name = "VentanaMenuPrincipal";
            this.Text = "BodegaBA";
            this.Load += new System.EventHandler(this.VentanaMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarProductosEnBodega;
        private System.Windows.Forms.Button btnAdministrarGD;
        private System.Windows.Forms.Button btnReservarAnwo;
        private System.Windows.Forms.Button btnMantenedorProductos;
        private System.Windows.Forms.Button btnSalir;
    }
}