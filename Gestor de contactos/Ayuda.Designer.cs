
namespace Gestor_de_contactos
{
    partial class Ayuda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnbuscarayuda = new System.Windows.Forms.Button();
            this.textBoxprgnta1 = new System.Windows.Forms.TextBox();
            this.textBoxprgnta2 = new System.Windows.Forms.TextBox();
            this.textBoxprgnta3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.btnbuscarayuda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnbuscarayuda
            // 
            this.btnbuscarayuda.Location = new System.Drawing.Point(36, 10);
            this.btnbuscarayuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarayuda.Name = "btnbuscarayuda";
            this.btnbuscarayuda.Size = new System.Drawing.Size(716, 24);
            this.btnbuscarayuda.TabIndex = 3;
            this.btnbuscarayuda.Text = "buscar";
            this.btnbuscarayuda.UseVisualStyleBackColor = true;
            this.btnbuscarayuda.Click += new System.EventHandler(this.btnbuscarayuda_Click);
            // 
            // textBoxprgnta1
            // 
            this.textBoxprgnta1.Location = new System.Drawing.Point(36, 41);
            this.textBoxprgnta1.Name = "textBoxprgnta1";
            this.textBoxprgnta1.Size = new System.Drawing.Size(464, 20);
            this.textBoxprgnta1.TabIndex = 1;
            this.textBoxprgnta1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxprgnta2
            // 
            this.textBoxprgnta2.Location = new System.Drawing.Point(36, 70);
            this.textBoxprgnta2.Name = "textBoxprgnta2";
            this.textBoxprgnta2.Size = new System.Drawing.Size(464, 20);
            this.textBoxprgnta2.TabIndex = 2;
            // 
            // textBoxprgnta3
            // 
            this.textBoxprgnta3.Location = new System.Drawing.Point(36, 96);
            this.textBoxprgnta3.Name = "textBoxprgnta3";
            this.textBoxprgnta3.Size = new System.Drawing.Size(464, 20);
            this.textBoxprgnta3.TabIndex = 3;
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(859, 701);
            this.Controls.Add(this.textBoxprgnta3);
            this.Controls.Add(this.textBoxprgnta2);
            this.Controls.Add(this.textBoxprgnta1);
            this.Controls.Add(this.panel1);
            this.Name = "Ayuda";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnbuscarayuda;
        private System.Windows.Forms.TextBox textBoxprgnta1;
        private System.Windows.Forms.TextBox textBoxprgnta2;
        private System.Windows.Forms.TextBox textBoxprgnta3;
    }
}