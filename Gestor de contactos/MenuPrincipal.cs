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
    public partial class MenuPrincipal : Form
    {
        private DataTable datosOriginales;
        private List<crear_contacto> listaContactos;
        private int contactosPorPagina = 10;
        private int paginaActual = 1;

        crear_cuenta objConexion = new crear_cuenta();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();

        public MenuPrincipal()
        {
            InitializeComponent();

            btnRestaurarContacto.Click += btnRestaurarContacto_Click;

            listaContactos = ObtenerListaDeContactos();

            ConfigurarDataGridView();
        }


        private List<crear_contacto> ObtenerListaDeContactos()
        {

            return objConexion.ObtenerDatos().Tables["Contactos"].AsEnumerable()
                .Select(row => new crear_contacto
                {
                    IDcontacto = Convert.ToInt32(row["IDcontacto"]),
                    Nombre = row["Nombre"].ToString(),
                })
                .ToList();
            throw new NotImplementedException();
        }

        private DataTable ObtenerDatosParaPagina1(int paginaActual)
        {
            // Calcula el índice de inicio y fin para la página actual
            int indiceInicio = (paginaActual - 1) * contactosPorPagina;
            int indiceFin = Math.Min(indiceInicio + contactosPorPagina, listaContactos.Count);


            var contactosPagina = listaContactos.Skip(indiceInicio).Take(contactosPorPagina).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("IdContactos", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));

            foreach (var contacto in contactosPagina)
            {
                dt.Rows.Add(contacto.IDcontacto, contacto.Nombre);
            }

            return dt;
        }

        private void MostrarDatosdeContactos()
        {
            dataGridContactos.DataSource = miTabla.DefaultView;
        }

        private void ConfigurarDataGridView()
        {

            dataGridContactos.AutoGenerateColumns = true;
            dataGridContactos.DataSource = ObtenerDatosParaPagina(paginaActual);

            Button btnatras = new Button() { Text = "atras", Location = new System.Drawing.Point(10, 400) };
            Button btnSiguiente = new Button() { Text = "Siguiente", Location = new System.Drawing.Point(100, 400) };

            btnatras.Click += btnatras_Click;
            btnSiguiente.Click += btnSiguiente_Click;

            Controls.Add(btnatras);
            Controls.Add(btnSiguiente);
        }

        private int CalcularCantidadDePaginas()
        {

            return (int)Math.Ceiling((double)listaContactos.Count / contactosPorPagina);
        }

        private void dataGridContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private List<crear_contacto> ObtenerListaDeContactosac()
        {
            return Enumerable.Range(1, 100).Select(i => new crear_contacto { Nombre = $"Contacto {i}" }).ToList();
        }
        private DataTable ObtenerDatosParaPagina(int paginaActual)
        {

            int indiceInicio = (paginaActual - 1) * contactosPorPagina;
            int indiceFin = Math.Min(indiceInicio + contactosPorPagina, listaContactos.Count);

            DataTable dt = new DataTable();
            dt.Columns.Add("IDcontacto", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));

            for (int i = indiceInicio; i < indiceFin; i++)
            {
                dt.Rows.Add(listaContactos[i].IDcontacto, listaContactos[i].Nombre);
            }

            return dt;
        }

        private void mostrarDatosdeContactos()
        {
            dataGridContactos.DataSource = miTabla.DefaultView;
        }

        private void btnAgregarContactos_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            openMenuPrincipalForm(new frmCrearContacto());
        }

        private new Form ActiveForm = null;
        private void openMenuPrincipalForm(Form MenuPrincipal)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = MenuPrincipal;
            MenuPrincipal.TopLevel = false;
            MenuPrincipal.Dock = DockStyle.Fill;
            MenuPrincipal.FormBorderStyle = FormBorderStyle.None;
            panelContenedor.Controls.Add(MenuPrincipal);
            panelContenedor.Tag = MenuPrincipal;
            MenuPrincipal.BringToFront();
            MenuPrincipal.Show();
        }


        private void btnCtsFrecuentes_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            openMenuPrincipalForm(new Contactos_frecuentes());
        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            openMenuPrincipalForm(new Papelera());
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            openMenuPrincipalForm(new Ayuda());
            Panel2.Visible = false;
            Panel3.Visible = false;

        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            miDs.Clear();
            miDs = objConexion.ObtenerDatos();
            miTabla = miDs.Tables["Contactos"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["IdContactos"] };
            mostrarDatosdeContactos();

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Panel3.Visible = true;
            // Oculta todos los formularios secundarios en el panel
            foreach (Control control in panelContenedor.Controls)
            {
                if (control is Form formulario)
                {
                    formulario.Hide();
                }
            }
        }

        private void ptbcerrar_Click(object sender, EventArgs e)
        {
            // Crear una lista para almacenar los formularios a cerrar

            var formulariosACerrar = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    formulariosACerrar.Add(form);
                }
            }
            foreach (var formularioACerrar in formulariosACerrar)
            {
                formularioACerrar.Close();
            }
        }

        private void ptbcerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Salir de tu cuenta?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                this.Close();
            }
        }


        private void RestaurarContacto(int idContacto)
        {
            using (SqlConnection conexion = new SqlConnection(crear_cuenta.ObtenerCadenaConexion()))
            {
                conexion.Open();
                string query = "UPDATE Contactos SET Eliminado = 0, FechaEliminacion = NULL WHERE IDcontacto = @idContacto";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idContacto", idContacto);
                cmd.ExecuteNonQuery();
            }
        }


        private void EjecutarConsulta(string queryActualizarTabla)
        {
            throw new NotImplementedException();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (paginaActual < CalcularCantidadDePaginas())
            {
                paginaActual++;
                dataGridContactos.DataSource = ObtenerDatosParaPagina(paginaActual);
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                dataGridContactos.DataSource = ObtenerDatosParaPagina(paginaActual);
            }
        }

        private void txtBuscarContacto_TextChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }
        private void RealizarBusqueda()
        {
            string terminoBusqueda = txtBuscarContacto.Text;

            using (SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Usuarios.mdf;Integrated Security=True"))
            {
                conexion.Open();
                string consulta = "SELECT * FROM Contactos WHERE Nombre LIKE @TerminoBusqueda OR Apellido LIKE @TerminoBusqueda";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@TerminoBusqueda", "%" + terminoBusqueda + "%");
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataSet dataSet = new DataSet();
                        adaptador.Fill(dataSet, "Contactos");
                        dataGridContactos.DataSource = dataSet.Tables["Contactos"];
                    }
                }
            }
        }


        private void lblBuscarContacto_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel77_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GuardarEstadoOriginal()
        {
            // Clona la estructura de la tabla actual
            datosOriginales = miTabla.Clone();

            // Copia los datos actuales a la tabla de datos originales
            foreach (DataRow row in miTabla.Rows)
            {
                datosOriginales.ImportRow(row);
            }
        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {

            // Guarda el estado original de los datos al iniciar la edición
            GuardarEstadoOriginal();
            // Habilita la edición de los datos en el DataGridView
            dataGridContactos.ReadOnly = false;

        }

        private void btnGuardarCC_Click(object sender, EventArgs e)
        {
            dataGridContactos.ReadOnly = true;

        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Configura el origen de datos del DataGridView (reemplaza esto con tu propia lógica)
            dataGridContactos.DataSource = ObtenerDatosDesdeTuOrigenDeDatos();

            // Por defecto, el DataGridView comienza en modo de solo lectura
            dataGridContactos.ReadOnly = true;
        }

        private DataTable ObtenerDatosDesdeTuOrigenDeDatos()
        {

            DataTable dt = new DataTable();

            return dt;
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            // Obtén el ID del contacto seleccionado en el DataGridView
            int idContactoSeleccionado = ObtenerIdContactoSeleccionado();

            // Marca el contacto como eliminado y asigna la fecha de eliminación
            MarcarComoEliminado(idContactoSeleccionado);

            // Actualiza el DataGridView
            ActualizarDataGridView();
        }

        private int ObtenerIdContactoSeleccionado()
        {
            int IDcontacto = Convert.ToInt32(dataGridContactos.CurrentRow.Cells["IDcontacto"].Value);
            return IDcontacto;
        }

        private void MarcarComoEliminado(int idContacto)
        {
            using (SqlConnection conexion = new SqlConnection(crear_cuenta.ObtenerCadenaConexion()))
            {
                conexion.Open();

                // Ejecutar la consulta para marcar como eliminado y asignar la fecha de eliminación
                string query = "UPDATE Contactos SET Eliminado = 1, FechaEliminacion = GETDATE() WHERE IDcontacto = @idContacto";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idContacto", idContacto);
                cmd.ExecuteNonQuery();
            }
        }

        private DataTable ObtenerDatosContactos(bool incluirEliminados = true)
        {
            using (SqlConnection conexion = new SqlConnection(crear_cuenta.ObtenerCadenaConexion()))
            {
                conexion.Open();

                // Define la consulta SQL para obtener los datos de contactos
                string query = incluirEliminados
                    ? "SELECT * FROM Contactos"
                    : "SELECT * FROM Contactos WHERE Eliminado = 0";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        private void ActualizarDataGridView()
        {
            // Obtén los datos actualizados para el DataGridView
            dataGridContactos.DataSource = ObtenerDatosContactos(false);
        }

        private void RestaurarEstadoOriginal()
        {
            // Limpia la tabla actual y restaura los datos originales
            miTabla.Clear();
            foreach (DataRow row in datosOriginales.Rows)
            {
                miTabla.ImportRow(row);
            }
        }

        private void btnRestaurarContacto_Click(object sender, EventArgs e)
        {
            // Obtén el ID del contacto seleccionado en el DataGridView
            int idContactoSeleccionado = ObtenerIdContactoSeleccionado();

            // Restaura el contacto (marca como no eliminado)
            RestaurarContacto(idContactoSeleccionado);

            // Actualiza el DataGridView
            ActualizarDataGridView();
        }

        private void btnCamcelarCCS_Click(object sender, EventArgs e)
        {
            // Restaura los datos a su estado original
            RestaurarEstadoOriginal();
            // Deshabilita la edición en el DataGridView
            dataGridContactos.ReadOnly = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            openMenuPrincipalForm(new FrmMiCuenta());
        }
    }

}
