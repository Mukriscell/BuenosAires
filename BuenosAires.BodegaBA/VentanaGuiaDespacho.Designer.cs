
namespace BuenosAires.BodegaBA
{
    partial class VentanaGuiaDespacho
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridDespacho = new System.Windows.Forms.DataGridView();
            this.btnVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.NroGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMB_PROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_GD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_FAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMB_CLI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDespacho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "(Vista de Bodeguero y Administrador)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buenos Aires";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guias de Despacho\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gridDespacho
            // 
            this.gridDespacho.AllowUserToOrderColumns = true;
            this.gridDespacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDespacho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroGD,
            this.NOMB_PROD,
            this.ESTADO_GD,
            this.NUM_FAC,
            this.NOMB_CLI,
            this.OPC});
            this.gridDespacho.Location = new System.Drawing.Point(33, 150);
            this.gridDespacho.Name = "gridDespacho";
            this.gridDespacho.Size = new System.Drawing.Size(701, 258);
            this.gridDespacho.TabIndex = 3;
            this.gridDespacho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDespacho_CellContent_Load);
            // 
            // btnVolverMenuPrincipal
            // 
            this.btnVolverMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenuPrincipal.Location = new System.Drawing.Point(281, 445);
            this.btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            this.btnVolverMenuPrincipal.Size = new System.Drawing.Size(186, 43);
            this.btnVolverMenuPrincipal.TabIndex = 4;
            this.btnVolverMenuPrincipal.Text = "Volver al Menu Principal";
            this.btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnVolverMenuPrincipal.Click += new System.EventHandler(this.btnVolverMenuPrincipal_Click);
            // 
            // NroGD
            // 
            this.NroGD.HeaderText = "Nro GD";
            this.NroGD.Name = "NroGD";
            // 
            // NOMB_PROD
            // 
            this.NOMB_PROD.HeaderText = "Producto";
            this.NOMB_PROD.Name = "NOMB_PROD";
            // 
            // ESTADO_GD
            // 
            this.ESTADO_GD.HeaderText = "Estado GD";
            this.ESTADO_GD.Name = "ESTADO_GD";
            // 
            // NUM_FAC
            // 
            this.NUM_FAC.HeaderText = "Nro Fac";
            this.NUM_FAC.Name = "NUM_FAC";
            // 
            // NOMB_CLI
            // 
            this.NOMB_CLI.HeaderText = "Cliente";
            this.NOMB_CLI.Name = "NOMB_CLI";
            // 
            // OPC
            // 
            this.OPC.HeaderText = "Opciones";
            this.OPC.Name = "OPC";
            // 
            // VentanaGuiaDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.btnVolverMenuPrincipal);
            this.Controls.Add(this.gridDespacho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaGuiaDespacho";
            this.Text = "VentanaGuiaDespacho";
            ((System.ComponentModel.ISupportInitialize)(this.gridDespacho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridDespacho;
        private System.Windows.Forms.Button btnVolverMenuPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMB_PROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_GD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_FAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMB_CLI;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPC;
    }
}