
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelayuda = new System.Windows.Forms.Panel();
            this.dataGridViewPapelera = new System.Windows.Forms.DataGridView();
            this.iDcontactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correounoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correodosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerodeTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadenacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosDataSet = new Gestor_de_contactos.UsuariosDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblaviso = new System.Windows.Forms.Label();
            this.btnvaciar = new System.Windows.Forms.Button();
            this.contactosTableAdapter = new Gestor_de_contactos.UsuariosDataSetTableAdapters.ContactosTableAdapter();
            this.panelayuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPapelera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
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
            this.panelayuda.Controls.Add(this.dataGridViewPapelera);
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
            // dataGridViewPapelera
            // 
            this.dataGridViewPapelera.AutoGenerateColumns = false;
            this.dataGridViewPapelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPapelera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcontactoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.correounoDataGridViewTextBoxColumn,
            this.correodosDataGridViewTextBoxColumn,
            this.numerodeTelefonoDataGridViewTextBoxColumn,
            this.fechadenacimientoDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn});
            this.dataGridViewPapelera.DataSource = this.contactosBindingSource;
            this.dataGridViewPapelera.Location = new System.Drawing.Point(0, 83);
            this.dataGridViewPapelera.Name = "dataGridViewPapelera";
            this.dataGridViewPapelera.ReadOnly = true;
            this.dataGridViewPapelera.Size = new System.Drawing.Size(809, 348);
            this.dataGridViewPapelera.TabIndex = 4;
            this.dataGridViewPapelera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPapelera_CellContentClick);
            // 
            // iDcontactoDataGridViewTextBoxColumn
            // 
            this.iDcontactoDataGridViewTextBoxColumn.DataPropertyName = "IDcontacto";
            this.iDcontactoDataGridViewTextBoxColumn.HeaderText = "IDcontacto";
            this.iDcontactoDataGridViewTextBoxColumn.Name = "iDcontactoDataGridViewTextBoxColumn";
            this.iDcontactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correounoDataGridViewTextBoxColumn
            // 
            this.correounoDataGridViewTextBoxColumn.DataPropertyName = "Correouno";
            this.correounoDataGridViewTextBoxColumn.HeaderText = "Correouno";
            this.correounoDataGridViewTextBoxColumn.Name = "correounoDataGridViewTextBoxColumn";
            this.correounoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correodosDataGridViewTextBoxColumn
            // 
            this.correodosDataGridViewTextBoxColumn.DataPropertyName = "Correodos";
            this.correodosDataGridViewTextBoxColumn.HeaderText = "Correodos";
            this.correodosDataGridViewTextBoxColumn.Name = "correodosDataGridViewTextBoxColumn";
            this.correodosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerodeTelefonoDataGridViewTextBoxColumn
            // 
            this.numerodeTelefonoDataGridViewTextBoxColumn.DataPropertyName = "NumerodeTelefono";
            this.numerodeTelefonoDataGridViewTextBoxColumn.HeaderText = "NumerodeTelefono";
            this.numerodeTelefonoDataGridViewTextBoxColumn.Name = "numerodeTelefonoDataGridViewTextBoxColumn";
            this.numerodeTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechadenacimientoDataGridViewTextBoxColumn
            // 
            this.fechadenacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fechadenacimiento";
            this.fechadenacimientoDataGridViewTextBoxColumn.HeaderText = "Fechadenacimiento";
            this.fechadenacimientoDataGridViewTextBoxColumn.Name = "fechadenacimientoDataGridViewTextBoxColumn";
            this.fechadenacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactosBindingSource
            // 
            this.contactosBindingSource.DataMember = "Contactos";
            this.contactosBindingSource.DataSource = this.usuariosDataSet;
            // 
            // usuariosDataSet
            // 
            this.usuariosDataSet.DataSetName = "UsuariosDataSet";
            this.usuariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnvaciar
            // 
            this.btnvaciar.Location = new System.Drawing.Point(669, 49);
            this.btnvaciar.Name = "btnvaciar";
            this.btnvaciar.Size = new System.Drawing.Size(131, 28);
            this.btnvaciar.TabIndex = 1;
            this.btnvaciar.Text = "Vaciar Papelera";
            this.btnvaciar.UseVisualStyleBackColor = true;
            // 
            // contactosTableAdapter
            // 
            this.contactosTableAdapter.ClearBeforeFill = true;
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
            this.Load += new System.EventHandler(this.Papelera_Load);
            this.panelayuda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPapelera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelayuda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblaviso;
        private System.Windows.Forms.Button btnvaciar;
        private System.Windows.Forms.DataGridView dataGridViewPapelera;
        private UsuariosDataSet usuariosDataSet;
        private System.Windows.Forms.BindingSource contactosBindingSource;
        private UsuariosDataSetTableAdapters.ContactosTableAdapter contactosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcontactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correounoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correodosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodeTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadenacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
    }
}