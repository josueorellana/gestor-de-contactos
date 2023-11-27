﻿using System;
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
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreoElectronico.Text;
            string numerodetelefono = txtNumeroDeTelefono.Text;
            string password = txtPassword.Text;

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

            // Crea la cuenta de usuario
            SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=usuarios;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO Usuarios (Nombre, Apellido, Correo, Numerodetelefono, password) VALUES (@nombre, @apellido, @correo, @numerodetelefono, @password)", conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@numerodetelefono", numerodetelefono);
            comando.Parameters.AddWithValue("@password", password);
            comando.ExecuteNonQuery();
            conexion.Close();

            // Actualiza el DataTable
            DataRow nuevaFila = miTabla.NewRow();
            nuevaFila["Nombre"] = nombre;
            nuevaFila["Apellido"] = apellido;
            nuevaFila["Correo"] = correo;
            nuevaFila["Numerodetelefono"] = numerodetelefono;
            nuevaFila["Password"] = password;
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
