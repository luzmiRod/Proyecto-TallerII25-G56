using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_TallerII25_G56
{
    public partial class UsersList : Form
    {
        private DataTable? originalDataTable; // para guardar los datos originales
        public UsersList()
        {
            InitializeComponent();
            this.Resize += UsersList_Resize; // para centrar siempre
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ConfigurarCBFiltro();

        }

        private void ConfigurarCBFiltro()
        {
            CBFiltroUsuario.Items.Clear();
            CBFiltroUsuario.Items.Add("Todos");
            CBFiltroUsuario.Items.Add("Gerente");
            CBFiltroUsuario.Items.Add("Cajero");
            CBFiltroUsuario.Items.Add("Usuarios inactivos");

            // Seleccionar "Todos" por defecto
            CBFiltroUsuario.SelectedIndex = 0;
        }

        private void CargarDatos()
        {
            string connectionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT id_usuario, nombre, apellido, dni, correo, tipo_usuario, activo FROM Usuario";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    originalDataTable = new DataTable();
                    adapter.Fill(originalDataTable);

                    // No generar columnas automáticamente porque ya estan definidas en el diseñador
                    dgvUsuarios.AutoGenerateColumns = false;
                    dgvUsuarios.DataSource = originalDataTable;

                    // mapeo de columnas
                    dgvUsuarios.Columns["id_usuario"].DataPropertyName = "id_usuario";
                    dgvUsuarios.Columns["Nombre"].DataPropertyName = "nombre";
                    dgvUsuarios.Columns["Apellido"].DataPropertyName = "apellido";
                    dgvUsuarios.Columns["DNI"].DataPropertyName = "dni";
                    dgvUsuarios.Columns["Correo"].DataPropertyName = "correo";
                    dgvUsuarios.Columns["tipo_usuario"].DataPropertyName = "tipo_usuario";
                    dgvUsuarios.Columns["activo"].DataPropertyName = "activo";

                    AdjustDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void AplicarFiltro(string filtroSeleccionado)
        {
            if (originalDataTable == null) return;

            try
            {
                DataView dataView = new DataView(originalDataTable);
                string rowFilter = ""; // Inicializar el filtro vacío

                if (string.IsNullOrEmpty(filtroSeleccionado) || filtroSeleccionado == "Todos")
                {
                    rowFilter = ""; // Sin filtro
                }
                else if (filtroSeleccionado == "Gerente")
                {
                    rowFilter = "tipo_usuario = 'Gerente'";
                }
                else if (filtroSeleccionado == "Cajero") 
                {
                    rowFilter = "tipo_usuario = 'Cajero'";
                }
                else if (filtroSeleccionado == "Usuarios inactivos")
                {
                    rowFilter = "activo = 0";
                }

                dataView.RowFilter = rowFilter;

                dgvUsuarios.DataSource = dataView;
                AdjustDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar el filtro: " + ex.Message);
            }
        }

        private void MostrarValoresTipoUsuario()
        {
            if (originalDataTable == null) return;

            DataTable distinct = originalDataTable.DefaultView.ToTable(true, "tipo_usuario");
            StringBuilder sb = new StringBuilder();
            foreach (DataRow r in distinct.Rows)
            {
                sb.AppendLine(r["tipo_usuario"]?.ToString() ?? "<NULL>");
            }
            MessageBox.Show("Valores distintos en tipo_usuario:\n" + sb.ToString());
        }


        // Mostrar "Activo/Inactivo" en vez de 1/0 o True/False
        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // se verifica si la columna es "activo" y el valor no es nulo
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

        // Centrar el dgv
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

            // calcular altura necesaria
            int altoFilas = dgvUsuarios.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            int altoEncabezado = dgvUsuarios.ColumnHeadersHeight;

            //ajustar la altura del dgv
            dgvUsuarios.Height = altoFilas + altoEncabezado + 2;

            // Centrar después de ajustar
            CenterDataGridView();
        }

        // Mantener centrado si se redimensiona el formulario
        private void UsersList_Resize(object sender, EventArgs e)
        {
            CenterDataGridView();
        }

        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //se verifica que la celda sea de la columna "accion" y que no sea el encabezado
            if (e.ColumnIndex == dgvUsuarios.Columns["accion"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                //se definen las imagenes en variables y verifica que no sean nulas
                Image? imagenEditar = imageList1.Images["editar.png"];
                Image? imagenDarBaja = imageList1.Images["baja.png"];
                Image? imagenDarAlta = imageList1.Images["alta.png"];

                // *** NUEVO: Obtener el valor de la columna 'activo' para esta fila ***
                // Asume que la columna se llama "activo" y contiene 0 o 1.
                // Se usa Convert.ToInt32 para manejar posibles DBNull o diferentes tipos.
                int activo = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["activo"].Value);

                // *** NUEVO: Determinar qué imagen de acción usar ***
                Image? imagenAccion;
                if (activo == 0)
                {
                    // Si 'activo' es 0, el usuario está inactivo, así que se muestra la opción de DAR ALTA.
                    imagenAccion = imagenDarAlta;
                }
                else
                {
                    // Si 'activo' es 1 (u otro valor que no sea 0), el usuario está activo, se muestra DAR BAJA.
                    imagenAccion = imagenDarBaja;
                }

                //se valida que las imagenes y el objeto Graphics no sean nulos antes de dibujar
                // Ahora verificamos imagenEditar y la imagenAccion determinada (alta o baja).
                if (imagenEditar != null && imagenAccion != null && e.Graphics != null)
                {
                    int anchoBoton = 20;
                    // Se asume 2 botones, por eso se divide el ancho en 3 márgenes.
                    int margen = (e.CellBounds.Width - (anchoBoton * 2)) / 3;

                    Rectangle rectEditar = new Rectangle(
                        e.CellBounds.X + margen,
                        e.CellBounds.Y + (e.CellBounds.Height - anchoBoton) / 2,
                        anchoBoton,
                        anchoBoton);

                    // El rectángulo para la acción (Alta o Baja)
                    Rectangle rectAccion = new Rectangle(
                        e.CellBounds.X + margen + anchoBoton + margen,
                        e.CellBounds.Y + (e.CellBounds.Height - anchoBoton) / 2,
                        anchoBoton,
                        anchoBoton);

                    e.Graphics.DrawImage(imagenEditar, rectEditar);
                    // *** CAMBIO: Se dibuja la imagen determinada (imagenAccion) ***
                    e.Graphics.DrawImage(imagenAccion, rectAccion);

                    e.Handled = true;
                }
            }
        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //se verifica que el click sea en la columna "accion" y que no sea el encabezado
            if (e.ColumnIndex == dgvUsuarios.Columns["accion"].Index && e.RowIndex >= 0)
            {
                // Obtencion del estado 'activo' de la fila clicada
                int activoActual = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["activo"].Value);
                int idUsuario = (int)dgvUsuarios.Rows[e.RowIndex].Cells["id_usuario"].Value;

                //obtencion de las coordenadas del click
                int x = e.X;
                int y = e.Y;

                int anchoBoton = 20;
                int margen = (dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Size.Width - (anchoBoton * 2)) / 3;

                //verificacion de si el click fue en el boton editar
                Rectangle rectEditar = new Rectangle(
                    margen,
                    (dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Size.Height - anchoBoton) / 2,
                    anchoBoton,
                    anchoBoton);

                // Verifica si el clic fue en el boton de acción (Baja/Alta)
                Rectangle rectAccion = new Rectangle(
                    margen + anchoBoton + margen,
                    (dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Size.Height - anchoBoton) / 2,
                    anchoBoton,
                    anchoBoton);

                // aplicación de lógica basada en el área clicada
                if (rectEditar.Contains(x, y))
                {
                    // se instancia el formulario de modificar y se le pasa el id del usuario
                    ModifyUser formEditar = new ModifyUser(idUsuario);
                    formEditar.ShowDialog();

                    // se recargan los datos al cerrar el formulario de edición
                    CargarDatos();
                }
                else if (rectAccion.Contains(x, y))
                {
                    // variable 'estadoDestino' 0 (Baja) 1 (Alta)
                    int estadoDestino = (activoActual == 1) ? 0 : 1;
                    string accionMensaje = (activoActual == 1) ? "dar de baja" : "dar de alta";

                    // No permitir que el admin se de de baja a sí mismo
                    if (estadoDestino == 0 && idUsuario == SesionActual.IdUsuario)
                    {
                        MessageBox.Show("No puedes dar de baja tu propio usuario mientras estás logueado.",
                                        "Info",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Validar si es el único administrador
                    object valorTipo = dgvUsuarios.Rows[e.RowIndex].Cells["tipo_usuario"].Value;
                    if (estadoDestino == 0 && valorTipo != null && valorTipo.ToString() == "Administrador")
                    {
                        if (ContarAdministradores() <= 1)
                        {
                            MessageBox.Show("No se puede dar de baja el único usuario administrador.",
                                "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Confirmación de la acción
                    DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas {accionMensaje} este usuario?",
                        "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        CambiarEstadoUsuario(idUsuario, estadoDestino);
                    }
                }
            }
        }
        private int ContarAdministradores() //esta funcion es para evitar dar de baja al ultimo admin
        {
            string connectionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT COUNT(*) FROM Usuario WHERE tipo_usuario = 'Administrador'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                return (int)cmd.ExecuteScalar();
            }
        }
        private void CambiarEstadoUsuario(int idUsuario, int estadoDestino)
        {
            string connectionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            string query = "UPDATE Usuario SET activo = @estadoDestino WHERE id_usuario = @idUsuario";

            // mensaje de confirmación
            string mensajeAccion = (estadoDestino == 1) ? "dado de alta" : "dado de baja";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    // pasa el estado 0 o 1
                    cmd.Parameters.AddWithValue("@estadoDestino", estadoDestino);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show($"Usuario {mensajeAccion} exitosamente", "Hecho",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario para realizar la acción.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el estado del usuario: " + ex.Message);
            }
        }

        private void CBFiltroUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFiltroUsuario.SelectedItem != null)
            {
                string? filtroSeleccionado = CBFiltroUsuario.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(filtroSeleccionado))
                {
                    AplicarFiltro(filtroSeleccionado);
                }
            }
        }
    }
}
