using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_contactos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void btnAgregarContactos_Click(object sender, EventArgs e)
        {
            openMenuPrincipalForm(new frmCrearContacto());
        }


        // Con esto ajustamos el tamaño de los formularios para que se ajusten a un tamaña especifico o deseado como ventana o tamaño completo

        private Form ActiveForm = null;
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

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ptbcerrar_Click(object sender, EventArgs e)
        {

        }

        private void ptbcerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelSideMenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
