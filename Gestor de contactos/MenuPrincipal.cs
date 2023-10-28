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

       

            private Form ActiveForm = null;
        private void openMenuPrincipalForm(Form MenuPrincipal)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = MenuPrincipal;
            MenuPrincipal.TopLevel = false;
            MenuPrincipal.FormBorderStyle = FormBorderStyle.None;
            MenuPrincipal.Dock = DockStyle.Fill;
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
    }
}
