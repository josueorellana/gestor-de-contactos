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
    class crear_contacto
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Usuarios.mdf;Integrated Security=True";

        public string Nombre { get; internal set; }
        public int IDcontacto { get; internal set; }

        public void EjecutarConsulta(string query)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
