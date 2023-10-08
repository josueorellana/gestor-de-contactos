
namespace Gestor_de_contactos
{
    partial class frmCrearCuenta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblContraseña);
            this.groupBox1.Controls.Add(this.lblCorreoElectronico);
            this.groupBox1.Controls.Add(this.lblApellidos);
            this.groupBox1.Controls.Add(this.lblNombres);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Location = new System.Drawing.Point(107, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos requeridos :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(18, 175);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(67, 13);
            this.lblContraseña.TabIndex = 13;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(18, 133);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(115, 13);
            this.lblCorreoElectronico.TabIndex = 12;
            this.lblCorreoElectronico.Text = "Correo Electronico";
            this.lblCorreoElectronico.Click += new System.EventHandler(this.lblCorreoElectronico_Click);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(18, 89);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(61, 13);
            this.lblApellidos.TabIndex = 11;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(18, 38);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 10;
            this.lblNombres.Text = "Nombres";
            this.lblNombres.Click += new System.EventHandler(this.lblNombres_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.DarkViolet;
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrear.Location = new System.Drawing.Point(187, 222);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(21, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(97, 168);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(146, 20);
            this.txtContraseña.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(139, 126);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(180, 20);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(85, 82);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(158, 20);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(85, 31);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(158, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // frmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 532);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCrearCuenta";
            this.Text = "Crear Cuenta";
            this.Load += new System.EventHandler(this.frmCrearCuenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
    }
}