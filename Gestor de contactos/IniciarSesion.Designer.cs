
namespace Gestor_de_contactos
{
    partial class frmInicioDeSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioDeSesion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbOcultar = new System.Windows.Forms.PictureBox();
            this.pbMostrar = new System.Windows.Forms.PictureBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.btnIniciarsesion = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnprueba = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pbOcultar);
            this.groupBox1.Controls.Add(this.pbMostrar);
            this.groupBox1.Controls.Add(this.btnCrearCuenta);
            this.groupBox1.Controls.Add(this.btnIniciarsesion);
            this.groupBox1.Controls.Add(this.txtContrasena);
            this.groupBox1.Controls.Add(this.lblContraseña);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(106, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos correspondientes :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 141);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pbOcultar
            // 
            this.pbOcultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbOcultar.Image = ((System.Drawing.Image)(resources.GetObject("pbOcultar.Image")));
            this.pbOcultar.Location = new System.Drawing.Point(281, 245);
            this.pbOcultar.Name = "pbOcultar";
            this.pbOcultar.Size = new System.Drawing.Size(34, 22);
            this.pbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOcultar.TabIndex = 7;
            this.pbOcultar.TabStop = false;
            this.pbOcultar.Click += new System.EventHandler(this.pbOcultar_Click);
            // 
            // pbMostrar
            // 
            this.pbMostrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbMostrar.Image = ((System.Drawing.Image)(resources.GetObject("pbMostrar.Image")));
            this.pbMostrar.Location = new System.Drawing.Point(281, 245);
            this.pbMostrar.Name = "pbMostrar";
            this.pbMostrar.Size = new System.Drawing.Size(34, 22);
            this.pbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrar.TabIndex = 6;
            this.pbMostrar.TabStop = false;
            this.pbMostrar.Click += new System.EventHandler(this.pbMostrar_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrearCuenta.Location = new System.Drawing.Point(34, 347);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(233, 33);
            this.btnCrearCuenta.TabIndex = 5;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnIniciarsesion
            // 
            this.btnIniciarsesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIniciarsesion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarsesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIniciarsesion.Location = new System.Drawing.Point(34, 308);
            this.btnIniciarsesion.Name = "btnIniciarsesion";
            this.btnIniciarsesion.Size = new System.Drawing.Size(233, 33);
            this.btnIniciarsesion.TabIndex = 4;
            this.btnIniciarsesion.Text = "Iniciar sesion";
            this.btnIniciarsesion.UseVisualStyleBackColor = true;
            this.btnIniciarsesion.Click += new System.EventHandler(this.btnIniciarsesion_Click_1);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContrasena.Location = new System.Drawing.Point(12, 245);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(266, 22);
            this.txtContrasena.TabIndex = 3;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(8, 223);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(98, 19);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreo.Location = new System.Drawing.Point(12, 180);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(266, 22);
            this.txtCorreo.TabIndex = 1;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(8, 158);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(153, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Correo Electronico";
            // 
            // btnprueba
            // 
            this.btnprueba.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnprueba.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprueba.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnprueba.Location = new System.Drawing.Point(182, 482);
            this.btnprueba.Name = "btnprueba";
            this.btnprueba.Size = new System.Drawing.Size(106, 33);
            this.btnprueba.TabIndex = 9;
            this.btnprueba.Text = "Prueba";
            this.btnprueba.UseVisualStyleBackColor = true;
            this.btnprueba.Click += new System.EventHandler(this.btnprueba_Click);
            // 
            // frmInicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(504, 537);
            this.Controls.Add(this.btnprueba);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmInicioDeSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.frmInicioDeSesion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Button btnIniciarsesion;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pbMostrar;
        private System.Windows.Forms.PictureBox pbOcultar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnprueba;
    }
}

