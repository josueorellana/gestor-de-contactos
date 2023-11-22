using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Gestor_de_contactos
{
    public partial class CrearCuenta : Form
    {
        crear_cuenta objConexion = new crear_cuenta();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();

        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void prueba_Load(object sender, EventArgs e)
        {
            
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["Usuario"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["IdUsuario"] };
            mostrarDatos();
        }    
            private void mostrarDatos()
            {
                grdDatosUsuarios.DataSource = miTabla.DefaultView;
            }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correoElectronico = txtCorreoElectronico.Text;
            string numeroTelefono = txtNumeroDeTelefono.Text;
            string contrasena = txtPassword.Text;

            // Valida la información proporcionada por el usuario
            if (nombre.Length == 0)
            {
                MessageBox.Show("Debes ingresar un nombre.");
                return;
            }

            if (apellido.Length == 0)
            {
                MessageBox.Show("Debes ingresar un apellido.");
                return;
            }

            if (!correoElectronico.Contains("@"))
            {
                MessageBox.Show("El correo electrónico debe contener un símbolo @.");
                return;
            }

            if (numeroTelefono.Length < 8)
            {
                MessageBox.Show("El número de teléfono debe tener al menos 10 dígitos.");
                return;
            }

            if (contrasena.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return;
            }

            // Crea la cuenta de usuario
            SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=usuarios;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO Usuarios (Nombre, Apellido, CorreoElectronico, NumeroTelefono, Contrasena) VALUES (@nombre, @apellido, @correoElectronico, @numeroTelefono, @contrasena)", conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@correoElectronico", correoElectronico);
            comando.Parameters.AddWithValue("@numeroTelefono", numeroTelefono);
            comando.Parameters.AddWithValue("@contrasena", contrasena);
            comando.ExecuteNonQuery();
            conexion.Close();

            // Muestra un mensaje de éxito
            MessageBox.Show("La cuenta de usuario se creó correctamente.");
        }
    
    }
    
}
