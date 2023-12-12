using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestor_de_contactos
{
    public partial class MenuPrincipal : Form
    {

        crear_cuenta objConexion = new crear_cuenta();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();

        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void mostrarDatosdeContactos()
        {
            dataGridContactos.DataSource = miTabla.DefaultView;
        }

        private void btnAgregarContactos_Click(object sender, EventArgs e)
        {
            openMenuPrincipalForm(new frmCrearContacto());
        }


        // Con esto ajustamos el tamaño de los formularios para que se ajusten a un tamaña especifico o deseado como ventana o tamaño completo

        private new Form ActiveForm = null;
        private void openMenuPrincipalForm(Form MenuPrincipal)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = MenuPrincipal;
            MenuPrincipal.TopLevel = false;
            MenuPrincipal.Dock = DockStyle.Fill;
            MenuPrincipal.FormBorderStyle = FormBorderStyle.None;
            panelContenedor.Controls.Add(MenuPrincipal);
            panelContenedor.Tag = MenuPrincipal;
            MenuPrincipal.BringToFront();
            MenuPrincipal.Show();
        }


        private void btnCtsFrecuentes_Click(object sender, EventArgs e)
        {
            openMenuPrincipalForm(new Contactos_frecuentes());
        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            openMenuPrincipalForm(new Papelera());
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            openMenuPrincipalForm(new Ayuda());
            
        }
        
        
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            miDs.Clear();
            miDs = objConexion.ObtenerDatos();
            miTabla = miDs.Tables["Contactos"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["IdContactos"] };
            mostrarDatosdeContactos();

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;
                       
        }
               
        private void button1_Click(object sender, EventArgs e)
        {
            // Oculta todos los formularios secundarios en el panel
            foreach (Control control in panelContenedor.Controls)
            {
                if (control is Form formulario)
                {
                    formulario.Hide();
                }
            }
        }

        private void ptbcerrar_Click(object sender, EventArgs e)
        {
            // Crear una lista para almacenar los formularios a cerrar

            var formulariosACerrar = new List<Form>();

            // Iterar sobre todos los formularios abiertos y agregarlos a la lista
            foreach (Form form in Application.OpenForms)
            {
                // Excluir el formulario principal (si es necesario)
                if (form != this)
                {
                    formulariosACerrar.Add(form);
                }
            }

            // Cerrar los formularios almacenados en la lista
            foreach (var formularioACerrar in formulariosACerrar)
            {
                formularioACerrar.Close();
            }
        }

        private void ptbcerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Salir de tu cuenta?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.OK)
            {
                // Si el usuario hace clic en "Salir", cerrar el formulario principal
                this.Close();
            }
        }

        
    }
}
