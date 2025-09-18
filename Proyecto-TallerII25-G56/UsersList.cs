using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_TallerII25_G56
{
    public partial class UsersList : Form
    {
        public UsersList()
        {
            InitializeComponent();
            this.Resize += UsersList_Resize; // 👈 para centrar siempre
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT nombre, apellido, dni, correo, tipo_usuario, activo FROM Usuario";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // No generar columnas automáticamente porque ya las definiste en el diseñador
                    dgvUsuarios.AutoGenerateColumns = false;
                    dgvUsuarios.DataSource = dataTable;

                    // Mapear columnas
                    dgvUsuarios.Columns["Nombre"].DataPropertyName = "nombre";
                    dgvUsuarios.Columns["Apellido"].DataPropertyName = "apellido";
                    dgvUsuarios.Columns["DNI"].DataPropertyName = "dni";
                    dgvUsuarios.Columns["Correo"].DataPropertyName = "correo";
                    dgvUsuarios.Columns["tipo_usuario"].DataPropertyName = "tipo_usuario";
                    dgvUsuarios.Columns["activo"].DataPropertyName = "activo";

                    // Ajustar todo
                    AdjustDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        // Mostrar "Activo/Inactivo" en vez de 1/0 o True/False
        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Asegúrate de que estás en la columna correcta y el valor no es nulo
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "activo" && e.Value != null)
            {
                // Verifica si el valor es de tipo booleano
                if (e.Value is bool estado)
                {
                    e.Value = estado ? "Activo" : "Inactivo";
                    e.FormattingApplied = true;
                }
            }
        }

        // Centrar el DataGridView
        private void CenterDataGridView()
        {
            dgvUsuarios.Left = (this.ClientSize.Width - dgvUsuarios.Width) / 2;
            dgvUsuarios.Top = (this.ClientSize.Height - dgvUsuarios.Height) / 2;
        }

        // Ajustar tamaño automático + centrar
        private void AdjustDataGridView()
        {
            // Ajustar filas y columnas
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Hacer que la columna correo se expanda
            dgvUsuarios.Columns["Correo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Centrar después de ajustar
            CenterDataGridView();
        }

        // Mantener centrado si se redimensiona el formulario
        private void UsersList_Resize(object sender, EventArgs e)
        {
            CenterDataGridView();
        }
    }
}
