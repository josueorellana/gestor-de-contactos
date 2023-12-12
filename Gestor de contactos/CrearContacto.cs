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
using System.IO;

namespace Gestor_de_contactos
{
    public partial class frmCrearContacto : Form
    {
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();


        public frmCrearContacto()
        {
            InitializeComponent();
            {
                // Otros códigos de inicialización...
                miTabla = new DataTable();
                // Configura las columnas de la tabla, por ejemplo:
                miTabla.Columns.Add("Nombre", typeof(string));
                miTabla.Columns.Add("Apellido", typeof(string));
                miTabla.Columns.Add("Correouno", typeof(string));
                miTabla.Columns.Add("Correodos", typeof(string));
                miTabla.Columns.Add("NumerodeTelefono", typeof(string));
                miTabla.Columns.Add("Fechadenacimiento", typeof(string));
                miTabla.Columns.Add("Pais", typeof(string));
                miTabla.Columns.Add("Empresa", typeof(string));
                miTabla.Columns.Add("Cargo", typeof(string));
                // Agrega las demás columnas de la misma manera
            }
        }

        private void mostrarDatos()
        {
        }

        private DataSet ObtenerDatos()
        {
            throw new NotImplementedException();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pbCargarImagen.ImageLocation = abrirImagen.FileName;
                pbCargarImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombres.Text;
            string Apellido= txtApellidos.Text;
            string Correouno = txtCorreo.Text;
            string Correodos = txtCorreo2.Text;
            string Numerodetelefono = txtTelefono.Text;
            string Fechadenacimiento = dtpFechaDeNacimiento.Text;
            string Pais = cboPais.Text;
            string Empresa = txtEmpresa.Text;
            string Cargo = txtCargo.Text;

            if (Nombre.Length == 0)
            {
                MessageBox.Show("Debes ingresar un nombre.");
                return;
            }
            if (Apellido.Length == 0)
            {
                MessageBox.Show("Debes ingresar un apellido.");
                return;
            }
            if (!Correouno.Contains("@"))
            {
                MessageBox.Show("El correo electrónico debe contener un símbolo @.");
                return;
            }

            if (Numerodetelefono.Length < 8)
            {
                MessageBox.Show("El número de teléfono debe tener al menos 10 dígitos.");
                return;
            }

            if (Fechadenacimiento.Length == 0)
            {
                MessageBox.Show("Debes ingresar su fecha de nacimiento.");
                return;
            }
            if (Pais.Length == 0)
            {
                MessageBox.Show("Debes seleccionar un pais.");
                return;
            }
            if (Empresa.Length == 0)
            {
                MessageBox.Show("ingresa el nombre de la empresa.");
                return;
            }
            if (Cargo.Length == 0)
            {
                MessageBox.Show("Debes ingresar el cargo de la empresa.");
                return;
            }

            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Usuarios.mdf;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO Contactos (Nombre, Apellido, Correouno, Correodos, NumerodeTelefono, Fechadenacimiento, Pais, Empresa, Cargo) VALUES (@Nombre, @Apellido, @Correouno, @Correodos, @NumerodeTelefono, @Fechadenacimiento, @Pais, @Empresa, @Cargo)", conexion);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Correouno", Correouno);
            comando.Parameters.AddWithValue("@Correodos", Correodos);
            comando.Parameters.AddWithValue("@Numerodetelefono", Numerodetelefono);
            comando.Parameters.AddWithValue("@Fechadenacimiento", Fechadenacimiento);
            comando.Parameters.AddWithValue("@Pais", Pais);
            comando.Parameters.AddWithValue("@Empresa", Empresa);
            comando.Parameters.AddWithValue("@Cargo", Cargo);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos se ingresaron correctamente");
            limpiarDatos();

            DataRow nuevaFila = miTabla.NewRow();
            nuevaFila["Nombre"] = Nombre;
            nuevaFila["Apellido"] = Apellido;
            nuevaFila["Correouno"] = Correouno;
            nuevaFila["Correodos"] = Correodos;
            nuevaFila["Numerodetelefono"] = Numerodetelefono;
            nuevaFila["Fechadenacimiento"] = Fechadenacimiento;
            nuevaFila["Pais"] = Pais;
            nuevaFila["Empresa"] = Empresa;
            nuevaFila["Cargo"] = Cargo;
            miTabla.Rows.Add(nuevaFila);

            mostrarDatos();
        }

        private void limpiarDatos()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtCorreo.Text = "";
            txtCorreo2.Text = "";
            txtTelefono.Text = "";
            cboPais.Text = "";
            txtDireccion.Text = "";
            txtEmpresa.Text = "";
            txtCargo.Text = "";
        }
               
    }
}
