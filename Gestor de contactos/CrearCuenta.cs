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
            string nombreyapellido = txtNombre.Text;
            string correo = txtCorreoElectronico.Text;
            string numerodetelefono = txtNumeroDeTelefono.Text;
            string password = txtPassword.Text;

            // Valida la información proporcionada por el usuario
            if (nombreyapellido.Length == 0)
            {
                MessageBox.Show("Debes ingresar un nombre.");
                return;
            }
            if (!correo.Contains("@"))
            {
                MessageBox.Show("El correo electrónico debe contener un símbolo @.");
                return;
            }

            if (numerodetelefono.Length < 8)
            {
                MessageBox.Show("El número de teléfono debe tener al menos 10 dígitos.");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return;
            }

            // Crea la cuenta de usuario y
            SqlConnection conexion = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Usuarios.mdf;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO Usuario (nombre, correo, numerodetelefono, password) VALUES (@nombre, @apellido, @correo, @numerodetelefono, @password)", conexion);
            comando.Parameters.AddWithValue("@nombre", nombreyapellido);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@numerodetelefono", numerodetelefono);
            comando.Parameters.AddWithValue("@password", password);
            comando.ExecuteNonQuery();
            conexion.Close();

            // Actualiza el DataTable
            DataRow nuevaFila = miTabla.NewRow();
            nuevaFila["nombre"] = nombreyapellido;
            nuevaFila["correo"] = correo;
            nuevaFila["numerodetelefono"] = numerodetelefono;
            nuevaFila["password"] = password;
            miTabla.Rows.Add(nuevaFila);

            // Actualiza la interfaz de usuario
            mostrarDatos();

            // Muestra un mensaje de éxito
            MessageBox.Show("La cuenta de usuario se creó correctamente.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
