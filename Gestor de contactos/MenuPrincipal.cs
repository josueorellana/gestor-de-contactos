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
            

    private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void agregarContacosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarContactos_Click(object sender, EventArgs e)
        {
            openMenuPrincipalForm(new frmCrearContacto());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            
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
    }
}
