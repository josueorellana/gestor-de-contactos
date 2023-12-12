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
        public frmCrearContacto()
        {
            InitializeComponent();
        }

        DataTable miTabla = new DataTable();

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
            string nombre = txtnombres.Text;
            string apellido= txtApellidos.Text;
            string correouno = txtCorreo.Text;
            string correodos = txtCorreo2.Text;
            string numerodetelefono = txtTelefono.Text;
            string fechadenacimiento = dtpFechaDeNacimiento.Text;
            string pais = cboPais.Text;
            string empresa = txtEmpresa.Text;
            string cargo = txtCargo.Text;

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
            if (!correouno.Contains("@"))
            {
                MessageBox.Show("El correo electrónico debe contener un símbolo @.");
                return;
            }
            if (!correodos.Contains("@"))
            {
                MessageBox.Show("El correo electrónico debe contener un símbolo @.");
                return;
            }

            if (numerodetelefono.Length < 8)
            {
                MessageBox.Show("El número de teléfono debe tener al menos 10 dígitos.");
                return;
            }

            if (fechadenacimiento.Length == 0)
            {
                MessageBox.Show("Debes ingresar su fecha de nacimiento.");
                return;
            }
            if (pais.Length == 0)
            {
                MessageBox.Show("Debes seleccionar un pais.");
                return;
            }
            if (empresa.Length == 0)
            {
                MessageBox.Show("ingresa el nombre de la empresa.");
                return;
            }
            if (cargo.Length == 0)
            {
                MessageBox.Show("Debes ingresar el cargo de la empresa.");
                return;
            }

            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Usuarios.mdf;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO Contactos (Nombre, Apellido, Correouno, Correodos, NumerodeTelefono, Fechadenacimiento, pais, empresa, cargo) VALUES (@nombre, @apellido, @correouno, @correodos, @numerodetelefono, @fechadenacimiento, @pais, @empresa, @cargo)", conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@correouno", correouno);
            comando.Parameters.AddWithValue("@correodos", correodos);
            comando.Parameters.AddWithValue("@numerodetelefono", numerodetelefono);
            comando.Parameters.AddWithValue("@fechadenacimiento", fechadenacimiento);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@empresa", empresa);
            comando.Parameters.AddWithValue("@cargo", cargo);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos se ingresaron correctamente");
            limpiarDatos();

            DataRow nuevaFila = miTabla.NewRow();
            nuevaFila["Nombre"] = nombre;
            nuevaFila["apellido"] = apellido;
            nuevaFila["Correouno"] = correouno;
            nuevaFila["Correodos"] = correodos;
            nuevaFila["Numerodetelefono"] = numerodetelefono;
            nuevaFila["Fechadenacimiento"] = fechadenacimiento;
            nuevaFila["pais"] = pais;
            nuevaFila["empresa"] = empresa;
            nuevaFila["cargo"] = cargo;
            miTabla.Rows.Add(nuevaFila);

        }       
        
        private void limpiarDatos()
        {
            txtnombres.Text = "";
            txtApellidos.Text = "";
            txtCorreo.Text = "";
            txtCorreo2.Text = "";
            txtTelefono.Text = "";
            txtTelefono2.Text = "";
            cboPais.Text = "";
            txtDireccion.Text = "";
            txtEmpresa.Text = "";
            txtCargo.Text = "";
        }
               
    }
}
