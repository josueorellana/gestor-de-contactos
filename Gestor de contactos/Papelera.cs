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
    public partial class Papelera : Form
    {
        private DataGridView dataGridContactos;
        public Papelera()
        {
            InitializeComponent();
        }

        private void panelayuda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Papelera_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewPapelera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarDataGridView()
        {
            // Obtén los datos de los contactos activos y actualiza el DataGridView principal
            dataGridContactos.DataSource = ObtenerDatosContactosActivos();

            // Obtén los datos de los contactos eliminados y actualiza el DataGridView de la papelera
            dataGridViewPapelera.DataSource = ObtenerDatosContactosEliminados();
        }

        private DataTable ObtenerDatosContactosActivos()
        {
            using (SqlConnection conexion = new SqlConnection(crear_cuenta.ObtenerCadenaConexion()))
            {
                conexion.Open();

                string query = "SELECT * FROM Contactos WHERE Eliminado = 0";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        private DataTable ObtenerDatosContactosEliminados()
        {
            using (SqlConnection conexion = new SqlConnection(crear_cuenta.ObtenerCadenaConexion()))
            {
                conexion.Open();

                string query = "SELECT * FROM Contactos WHERE Eliminado = 1";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
