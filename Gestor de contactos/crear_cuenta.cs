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
        SqlConnection miConexion = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet miDs = new DataSet();

        public crear_cuenta()
        {
            String cadenaConexio = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Usuarios.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexio;
            miConexion.Open();
        }
            public DataSet obtenerDatos()
        { 
            miDs.Clear();
            miComando.Connection = miConexion;

            miComando.CommandText = "select * from Usuario";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "Usuario");

            return miDs;
        }
    }
}

