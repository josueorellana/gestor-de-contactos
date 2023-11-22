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
           


        }
    }
    
}
