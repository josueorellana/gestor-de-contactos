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
    public partial class frmInicioDeSesion : Form
    {
        string usuario = "Usuario";
        string Password = "Password";

        public frmInicioDeSesion()
        {
            InitializeComponent();
        }



        private void btnLong_in_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != usuario || txtContraseña.Text != Password)
            { 
                  if (txtUsuario.Text != usuario)
                { 
                    MessageBox.Show("Usuario incorrecto","Datos equivocados",MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);
                   txtUsuario.Clear();

                 }  
                  if (txtContraseña.Text != Password)
                {
                    MessageBox.Show("Contraseña incorrecta", "Datos equivocados", MessageBoxButtons.RetryCancel,
                             MessageBoxIcon.Error);
                    txtContraseña.Clear();
                     }
                 }

            else
               {
                txtUsuario.Clear();
                txtContraseña.Clear();
                Panel principal = new Panel();
                principal.ShowDialog();
                }


        }
        

        
        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtContraseña.PasswordChar = '*';
                       
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtContraseña.PasswordChar = '\0';

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            frmCrearCuenta frm = new frmCrearCuenta();
            frm.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
