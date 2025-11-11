using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TallerII25_G56
{
    public partial class ProveedoresList : Form
    {
        public class ConexionBD
        {
            private readonly string connetionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connetionString);
            }
        }
        public ProveedoresList()
        {
            InitializeComponent();
        }

        private void ProveedoresList_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarRubros();
        }

        public class RubroItem
        {
            public int IdRubro { get; set; }
            public string CodRubro { get; set; }
            public string Nombre { get; set; }

            public RubroItem(int idRubro, string codigo, string nombre)
            {
                IdRubro = idRubro;
                CodRubro = codigo;
                Nombre = nombre;
            }
            public override string ToString()
            {
                return $"{CodRubro} - {Nombre}";
            }
        }
        private void CargarRubros()
        {
            CBFiltroRubro.Items.Clear();

            ConexionBD conexion = new ConexionBD();
            using (SqlConnection sqlConnection = conexion.GetConnection())
            {
                try
                {
                    sqlConnection.Open();
                    // Consulta SQL para obtener todos los rubros
                    string query = "SELECT id_rubro, cod_rubro, nombre FROM Rubro ORDER BY nombre";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        // Usamos SqlDataReader para leer los resultados fila por fila
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            // Verifica si hay filas para leer
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Lee los valores de las columnas
                                    int id = reader.GetInt32(0); // Columna 0: id_rubro
                                    string codigo = reader.GetString(1);
                                    string nombre = reader.GetString(2); // Columna 1: nombre

                                    // Creamos un objeto que combine el nombre y el código
                                    // Esto es clave para trabajar con ComboBox
                                    CBFiltroRubro.Items.Add(new RubroItem(id, codigo, nombre));
                                }

                                CBFiltroRubro.SelectedIndex = -1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los rubros: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private DataTable dataTableProveedores; // <-- Guardamos los datos originales

        private void CargarDatos()
        {
            string connectionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            string query = @"SELECT 
            p.cod_prov, 
            p.nombre, 
            p.cuit, 
            p.direccion, 
            p.telefono, 
            p.email, 
            r.nombre AS rubro,
            p.cod_rubro AS id_rubro_fk
        FROM Proveedor p
        INNER JOIN Rubro r ON p.cod_rubro = r.id_rubro
        ORDER BY p.nombre";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    dataTableProveedores = new DataTable();
                    adapter.Fill(dataTableProveedores);

                    dgvProveedores.AutoGenerateColumns = false;

                    dgvProveedores.Columns["nombre"].DataPropertyName = "nombre";
                    dgvProveedores.Columns["cuit"].DataPropertyName = "cuit";
                    dgvProveedores.Columns["direccion"].DataPropertyName = "direccion";
                    dgvProveedores.Columns["telefono"].DataPropertyName = "telefono";
                    dgvProveedores.Columns["email"].DataPropertyName = "email";
                    dgvProveedores.Columns["rubro"].DataPropertyName = "rubro";

                    dgvProveedores.DataSource = dataTableProveedores;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AplicarFiltroRubro()
        {
            if (dataTableProveedores == null)
                return;

            DataView view = dataTableProveedores.DefaultView;

            if (CBFiltroRubro.SelectedItem is RubroItem selectedRubro)
            {
                view.RowFilter = $"id_rubro_fk = {selectedRubro.IdRubro}";
            }
            else
            {
                // Sin filtro → mostramos todos
                view.RowFilter = string.Empty;
            }
        }
        private void CBFiltroRubro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AplicarFiltroRubro();
        }
    }
}
