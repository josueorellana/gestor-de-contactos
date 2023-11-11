
namespace Gestor_de_contactos
{
    partial class Contactos_frecuentes
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
            this.lblnombreF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhtr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombreF
            // 
            this.lblnombreF.AutoSize = true;
            this.lblnombreF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblnombreF.Location = new System.Drawing.Point(127, 38);
            this.lblnombreF.Name = "lblnombreF";
            this.lblnombreF.Size = new System.Drawing.Size(57, 16);
            this.lblnombreF.TabIndex = 0;
            this.lblnombreF.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(361, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblhtr
            // 
            this.lblhtr.AutoSize = true;
            this.lblhtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhtr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblhtr.Location = new System.Drawing.Point(598, 38);
            this.lblhtr.Name = "lblhtr";
            this.lblhtr.Size = new System.Drawing.Size(56, 16);
            this.lblhtr.TabIndex = 2;
            this.lblhtr.Text = "Numero";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.lblnombreF);
            this.panel1.Controls.Add(this.lblhtr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 57);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 534);
            this.panel2.TabIndex = 4;
            // 
            // Contactos_frecuentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(812, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Contactos_frecuentes";
            this.Text = "Contactos_frecuentes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblnombreF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhtr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}