using System.Windows.Forms;

namespace BuenosAires.BodegaBA
{
    partial class VentanaLoginVentas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBuenosAires = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lnkOlvideContrasena = new System.Windows.Forms.LinkLabel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(79, 69);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(385, 18);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ingresar al Sistema de Ventas (Vista de Vendedor)";
            // 
            // lblBuenosAires
            // 
            this.lblBuenosAires.AutoSize = true;
            this.lblBuenosAires.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuenosAires.Location = new System.Drawing.Point(12, 31);
            this.lblBuenosAires.Name = "lblBuenosAires";
            this.lblBuenosAires.Size = new System.Drawing.Size(108, 18);
            this.lblBuenosAires.TabIndex = 2;
            this.lblBuenosAires.Text = "Buenos Aires";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(20, 34);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(44, 13);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(20, 80);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(71, 13);
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(20, 50);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(250, 20);
            this.txtCorreo.TabIndex = 1;
            this.txtCorreo.Text = "atorres@duocuc.cl";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(20, 100);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(250, 20);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(93, 126);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            // 
            // lnkOlvideContrasena
            // 
            this.lnkOlvideContrasena.AutoSize = true;
            this.lnkOlvideContrasena.Location = new System.Drawing.Point(90, 160);
            this.lnkOlvideContrasena.Name = "lnkOlvideContrasena";
            this.lnkOlvideContrasena.Size = new System.Drawing.Size(106, 13);
            this.lnkOlvideContrasena.TabIndex = 5;
            this.lnkOlvideContrasena.TabStop = true;
            this.lnkOlvideContrasena.Text = "Olvidé mi contraseña";
            // 
            // panelLogin
            // 
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.lblCorreo);
            this.panelLogin.Controls.Add(this.txtCorreo);
            this.panelLogin.Controls.Add(this.lblContrasena);
            this.panelLogin.Controls.Add(this.txtContrasena);
            this.panelLogin.Controls.Add(this.btnIngresar);
            this.panelLogin.Controls.Add(this.lnkOlvideContrasena);
            this.panelLogin.Location = new System.Drawing.Point(99, 101);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(300, 200);
            this.panelLogin.TabIndex = 0;
            // 
            // VentanaLoginVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 361);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblBuenosAires);
            this.Name = "VentanaLoginVentas";
            this.Text = "Sistema VentaBA";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuenosAires;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel lnkOlvideContrasena;
        private System.Windows.Forms.Panel panelLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}