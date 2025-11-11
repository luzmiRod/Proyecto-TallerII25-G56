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
    public partial class HistorialVentas : Form
    {
        public class ConexionBD
        {
            private readonly string connetionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connetionString);
            }
        }

        public HistorialVentas()
        {
            InitializeComponent();
            // Importante: Deshabilitar la generación automática de columnas
            dgvHistorialVentas.AutoGenerateColumns = false;
        }

        private void HistorialVentas_Load(object sender, EventArgs e)
        {
            CargarDatos(null);
            CargarCajeros();
        }
        private void CargarCajeros()
        {
            string connectionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_usuario, nombre + ' ' + apellido AS cajero FROM Usuario WHERE tipo_usuario = 'cajero' ORDER BY nombre";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow row = dt.NewRow();
                row["id_usuario"] = DBNull.Value; // valor nulo para representar “todos”
                row["cajero"] = "TODOS";
                dt.Rows.InsertAt(row, 0);

                CBFiltroCajero.DataSource = dt;
                CBFiltroCajero.DisplayMember = "cajero";
                CBFiltroCajero.ValueMember = "id_usuario";
                CBFiltroCajero.SelectedIndex = 0; // Mostrar "TODOS" por defecto
            }
        }
        private void CBFiltroCajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFiltroCajero.SelectedValue == null)
                return;

            if (CBFiltroCajero.SelectedValue == DBNull.Value)
            {
                CargarDatos(null); // Muestra todas las ventas
                return;
            }

            if (CBFiltroCajero.SelectedValue is int idCajero)
            {
                CargarDatos(idCajero);

                if (dgvHistorialVentas.Rows.Count == 0)
                {
                    MessageBox.Show("Este cajero no tiene ventas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void CargarDatos(int? idCajero)
        {
            ConexionBD conexionBd = new ConexionBD();
            DataTable dtVentas = new DataTable();
            string query = @"SELECT
                V.id_venta AS [Número de venta],
                V.fecha AS Fecha,
                U.nombre + ' ' + U.apellido AS Cajero,
                V.monto_total AS Importe
            FROM Venta V
            INNER JOIN Usuario U ON V.id_usuario = U.id_usuario";

            if (idCajero.HasValue)
            {
                query += " WHERE V.id_usuario = @id_usuario";
            }

            query += " ORDER BY V.fecha DESC";

            try
            {
                using (SqlConnection connection = conexionBd.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (idCajero.HasValue)
                        {
                            // Corrección: el parámetro debe ser @id_usuario (como en el query)
                            command.Parameters.AddWithValue("@id_usuario", idCajero.Value);
                        }

                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dtVentas);
                    }
                }

                // Limpiar filas existentes antes de cargar nuevos datos
                dgvHistorialVentas.Rows.Clear();

                // Llenar manualmente las filas del DataGridView
                foreach (DataRow row in dtVentas.Rows)
                {
                    dgvHistorialVentas.Rows.Add(
                        row["Número de venta"],
                        Convert.ToDateTime(row["Fecha"]).ToString("dd/MM/yyyy"), // Solo la fecha
                        row["Cajero"],
                        row["Importe"]
                    );
                }

                // Ajustar el formato del Importe a moneda
                if (dgvHistorialVentas.Columns.Contains("Importe"))
                {
                    dgvHistorialVentas.Columns["Importe"].DefaultCellStyle.Format = "C2";
                    dgvHistorialVentas.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHistorialVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda válida (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                // Verificar si se hizo clic en la columna del botón "Descargar"
                if (dgvHistorialVentas.Columns[e.ColumnIndex].Name == "btnDescargar")
                {
                    // Obtener el ID de la venta de la primera columna (índice 0)
                    // Si tu columna de ID está en otra posición, cambia el índice
                    int idVenta = Convert.ToInt32(dgvHistorialVentas.Rows[e.RowIndex].Cells[0].Value);

                    // Abrir diálogo para guardar el archivo
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveDialog.FileName = $"Comprobante_Venta_{idVenta}.pdf";
                    saveDialog.Title = "Guardar Comprobante";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        GeneradorComprobante generador = new GeneradorComprobante();
                        if (generador.GenerarComprobantePDF(idVenta, saveDialog.FileName))
                        {
                            MessageBox.Show("Comprobante generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Preguntar si desea abrir el archivo
                            if (MessageBox.Show("¿Desea abrir el comprobante?", "Abrir archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // Para .NET Core/8.0 usa este formato
                                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                                {
                                    FileName = saveDialog.FileName,
                                    UseShellExecute = true
                                });
                            }
                        }
                    }
                }
            }
        }

    }
}