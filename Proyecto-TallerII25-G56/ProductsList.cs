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
    public partial class ProductsList : Form
    {
        public class ConexionBD
        {
            private readonly string connetionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connetionString);
            }
        }
        private DataTable? originalDataTable;
        public ProductsList()
        {
            InitializeComponent();
            CargarRubros();
            CBFiltroStock.Items.Add("Todos");
            CBFiltroStock.Items.Add("DISPONIBLE");
            CBFiltroStock.Items.Add("NO DISPONIBLE");
            CBFiltroStock.SelectedIndex = 0;

            CBFiltroStock.SelectedIndexChanged += CBFiltroStock_SelectedIndexChanged;
            CBFiltroRubro.SelectedIndexChanged += CBFiltroRubro_SelectedIndexChanged;
        }
        private void AplicarFiltrosCombinados()
        {
            if (originalDataTable == null) return;

            List<string> filtros = new List<string>();

            // --- 1. FILTRO DE STOCK ---
            string stockSeleccionado = CBFiltroStock.SelectedItem.ToString();
            switch (stockSeleccionado)
            {
                case "DISPONIBLE":
                    filtros.Add("cantidad > 0");
                    break;
                case "NO DISPONIBLE":
                    filtros.Add("cantidad = 0");
                    break;
                case "Todos":
                default:
                    // No se añade filtro
                    break;
            }

            // --- 2. FILTRO DE RUBRO ---
            if (CBFiltroRubro.SelectedItem != null)
            {
                string rubroSeleccionado = CBFiltroRubro.SelectedItem.ToString();
                if (rubroSeleccionado != "Todos")
                {
                    filtros.Add(string.Format("nombre_rubro = '{0}'", rubroSeleccionado.Replace("'", "''")));
                }
            }

            string filtroFinal = string.Join(" AND ", filtros);

            originalDataTable.DefaultView.RowFilter = filtroFinal;

            // El DataGridView, al estar enlazado, se actualizará automáticamente.
        }
        private void CBFiltroRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Llamar al método unificado para aplicar ambos filtros
            AplicarFiltrosCombinados();
        }

        private void CBFiltroStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltrosCombinados();
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarRubros()
        {
            CBFiltroRubro.Items.Clear();
            CBFiltroRubro.Items.Add("Todos");
            ConexionBD conexion = new ConexionBD();
            using (SqlConnection conn = conexion.GetConnection())
            {
                conn.Open();
                string query = "SELECT nombre FROM Rubro";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CBFiltroRubro.Items.Add(reader["nombre"].ToString());
                        }
                    }
                }
            }

        }
        private void ProductsList_Load_1(object sender, EventArgs e)
        {
            CargarDatos();
            CheckUserPermission();
        }
        private void CheckUserPermission()
        {
            // Oculta el botón si el usuario es "cajero"
            // Nota: El nombre de la variable del botón en tu código es BAgregarProducto
            if (SesionActual.TipoUsuario.ToLower() == "cajero")
            {
                // La propiedad Visible controla si el control se muestra
                BAgregarProducto.Visible = false;
            }
        }
        private void CargarDatos()
        {
            string connectionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            string query = @"SELECT 
                    p.cod_prod, 
                    p.nombre, 
                    p.descripcion, 
                    p.precio, 
                    p.cantidad,
                    r.nombre  AS nombre_rubro, -- Nombre del Rubro
                    pr.nombre AS nombre_prov  -- Nombre del Proveedor
                FROM Producto p
                INNER JOIN Rubro r ON p.cod_rubro = r.id_rubro
                INNER JOIN Proveedor pr ON p.cod_prov = pr.cod_prov";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    originalDataTable = new DataTable();
                    adapter.Fill(originalDataTable);

                    dgvProductos.AutoGenerateColumns = false;

                    //mapear columnas
                    dgvProductos.Columns["cod_prod"].DataPropertyName = "cod_prod";
                    dgvProductos.Columns["nombre"].DataPropertyName = "nombre";
                    dgvProductos.Columns["descripcion"].DataPropertyName = "descripcion";
                    dgvProductos.Columns["precio"].DataPropertyName = "precio";
                    dgvProductos.Columns["cantidad"].DataPropertyName = "cantidad";
                    dgvProductos.Columns["rubro"].DataPropertyName = "nombre_rubro";
                    dgvProductos.Columns["proveedor"].DataPropertyName = "nombre_prov";

                    dgvProductos.DataSource = originalDataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);

            }

        }

        private void BAgregarProducto_Click(object sender, EventArgs e)
        {
            NewProduct newProductForm = new NewProduct();
        }
    }
}
