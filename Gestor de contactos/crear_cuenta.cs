using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gestor_de_contactos
{
    class crear_cuenta
    {
        public static string ObtenerCadenaConexion()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Usuarios.mdf;Integrated Security=True";
        }

        public DataSet ObtenerDatos()
        {
            DataSet miDs = new DataSet();

            using (SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion()))
            {
                conexion.Open();

                SqlCommand miComando = new SqlCommand();
                miComando.Connection = conexion;
                miComando.CommandText = "select * from Usuario";

                SqlDataAdapter miAdaptador = new SqlDataAdapter();
                miAdaptador.SelectCommand = miComando;
                miAdaptador.Fill(miDs, "Usuario");

                miComando.CommandText = "select * from Contactos";
                miAdaptador.SelectCommand = miComando;
                miAdaptador.Fill(miDs, "Contactos");
            }


            return miDs;
        }

    }
}

