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
    public partial class frmInicioDeSesion : Form
    {
        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtContrasena.PasswordChar = '*';

        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtContrasena.PasswordChar = '\0';

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            CrearCuenta ver = new CrearCuenta();
            ver.Show();
        }

        private void frmInicioDeSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnprueba_Click(object sender, EventArgs e)
        {

            Form menuP = new MenuPrincipal();
            menuP.Show();

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {


        }
        public static class UsuarioActual
        {
            public static int Id { get; set; }
        }

        private void btnIniciarsesion_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(crear_cuenta.ObtenerCadenaConexion()))
            {
                conexion.Open();

                string query = "SELECT Id FROM Usuario WHERE correo = @correo AND password = @contrasena";
                SqlCommand cmd = new SqlCommand(query, conexion);

                // Configurar parámetros
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@contrasena", txtContrasena.Text);

                // Ejecutar la consulta
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // Almacenar el ID del usuario actual
                    UsuarioActual.Id = (int)result;

                    // Iniciar sesión exitosa, abrir el formulario MenuPrincipal
                    MenuPrincipal menup = new MenuPrincipal();
                    menup.Show();
                    this.Hide(); // Ocultar el formulario de inicio de sesión
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo de nuevo.");
                }
            }
        }
    }
}
