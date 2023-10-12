using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Gestor_de_contactos
{
    public partial class frmCrearCuenta : Form
    {
        public frmCrearCuenta()
        {
            InitializeComponent();
        }

          
               

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Validar los datos introducidos por el usuario
            string nombre = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string correo = txtCorreo.Text;
            string contraseña = txtContraseña.Text;

            if (nombre.Length == 0)
            {
                MessageBox.Show("Debe introducir un nombre.");
                return;
            }

            if (apellidos.Length == 0)
            {
                MessageBox.Show("Debe introducir apellidos.");
                return;
            }

            if (!Regex.IsMatch(correo, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z]+$"))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                return;
            }

            if (contraseña.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                return;
            }

            MessageBoxButtons boton = MessageBoxButtons.OK;
              DialogResult dr = MessageBox.Show("Su cuenta fue creada correctamente", "Cuenta creada", boton,
                             MessageBoxIcon.Information);

            if ( dr == DialogResult.OK) { 
               frmInicioDeSesion Inicio = new frmInicioDeSesion();
               Inicio.ShowDialog();
                    
               this.Close();

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                              
                
    }
}
