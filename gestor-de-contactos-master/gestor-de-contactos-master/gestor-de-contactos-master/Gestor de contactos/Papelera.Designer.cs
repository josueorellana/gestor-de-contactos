
namespace Gestor_de_contactos
{
    partial class Papelera
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelayuda = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnvaciar = new System.Windows.Forms.Button();
            this.lblaviso = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelayuda.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = ":";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 48);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(714, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 509);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 2;
            this.button3.Text = "Restaurar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panelayuda
            // 
            this.panelayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelayuda.Controls.Add(this.panel2);
            this.panelayuda.Controls.Add(this.button3);
            this.panelayuda.Controls.Add(this.button2);
            this.panelayuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelayuda.Location = new System.Drawing.Point(0, 48);
            this.panelayuda.Name = "panelayuda";
            this.panelayuda.Size = new System.Drawing.Size(812, 543);
            this.panelayuda.TabIndex = 3;
            this.panelayuda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelayuda_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblaviso);
            this.panel2.Controls.Add(this.btnvaciar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 80);
            this.panel2.TabIndex = 3;
            // 
            // btnvaciar
            // 
            this.btnvaciar.Location = new System.Drawing.Point(669, 49);
            this.btnvaciar.Name = "btnvaciar";
            this.btnvaciar.Size = new System.Drawing.Size(131, 28);
            this.btnvaciar.TabIndex = 1;
            this.btnvaciar.Text = "Vaciar Papelera";
            this.btnvaciar.UseVisualStyleBackColor = true;
            // 
            // lblaviso
            // 
            this.lblaviso.AutoSize = true;
            this.lblaviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblaviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaviso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblaviso.Location = new System.Drawing.Point(3, 14);
            this.lblaviso.Name = "lblaviso";
            this.lblaviso.Size = new System.Drawing.Size(691, 20);
            this.lblaviso.TabIndex = 2;
            this.lblaviso.Text = "Se eliminaran definitivamente los contactos que hayan estado en la papelera por m" +
    "ás de 30 días ";
            // 
            // Papelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(812, 591);
            this.Controls.Add(this.panelayuda);
            this.Controls.Add(this.panel1);
            this.Name = "Papelera";
            this.Text = "Papelera";
            this.panel1.ResumeLayout(false);
            this.panelayuda.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelayuda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblaviso;
        private System.Windows.Forms.Button btnvaciar;
    }
}