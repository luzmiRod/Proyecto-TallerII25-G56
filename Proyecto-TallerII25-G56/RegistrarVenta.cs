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
    public partial class RegistrarVenta : Form
    {
        public class ConexionBD
        {
            private readonly string connetionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connetionString);
            }
        }
        // Dentro de la clase RegistrarVenta
        private int _idClienteSeleccionado = 0; // Se inicializa en 0 (o cualquier valor que indique que no hay cliente)
        public class DetalleVenta
        {
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal SubtotalProducto => Cantidad * PrecioUnitario;
        }
        // Lista para almacenar los productos agregados a la venta
        private List<DetalleVenta> productosAgregados = new List<DetalleVenta>();
        public RegistrarVenta()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto eliminarProducto = new EliminarProducto(this);
            eliminarProducto.ShowDialog();
        }

        // Dentro de la clase RegistrarVenta : Form

        private void BRegistrarCliente_Click(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient();

            if (newClient.ShowDialog() == DialogResult.OK)
            {
                string nuevoCuit = newClient.CuitClienteRegistrado;
                string nuevoNombre = newClient.NombreClienteRegistrado;

                if (!string.IsNullOrEmpty(nuevoCuit))
                {
                    TBCuitCliente.Text = nuevoCuit;
                    TBNombreCliente.Text = nuevoNombre;
                    BuscarYSeleccionarCliente(); 
                }
            }
        }

        // Dentro de la clase RegistrarVenta : Form

        private void PBButtonFindCliente_Click(object sender, EventArgs e)
        {
            // Simplemente llama al método de búsqueda reutilizable.
            BuscarYSeleccionarCliente();
        }

        private void BuscarYSeleccionarCliente()
        {
            _idClienteSeleccionado = 0;
            TBNombreCliente.Text = string.Empty;

            // Obtiene el cuit del TextBox y verifica que no esté vacío.
            string cuit = TBCuitCliente.Text.Trim();
            if (string.IsNullOrEmpty(cuit))
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new ConexionBD().GetConnection())
                {
                    connection.Open();

                    string query = "SELECT id_cliente, nombre FROM Cliente WHERE cuit = @cuit";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // se agrega el parámetro cuit con el valor del TextBox.
                        command.Parameters.AddWithValue("@cuit", cuit);

                        // Ejecuta el comando y lee el resultado.
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _idClienteSeleccionado = Convert.ToInt32(reader["id_cliente"]);
                                string nombre = reader["nombre"].ToString();
                                TBNombreCliente.Text = $"{nombre}";
                            }
                            else
                            {
                                MessageBox.Show("Cliente no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Captura cualquier error de la base de datos y muestra un mensaje de error.
                _idClienteSeleccionado = 0;
                MessageBox.Show("Error al conectar o consultar la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBCuitCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BAgregarProducto_Click(object sender, EventArgs e)
        {
            string codigoProducto = TBCodigo.Text.Trim();
            if (!int.TryParse(TBCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida y mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(codigoProducto))
            {
                MessageBox.Show("Ingrese un código de producto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection connection = new ConexionBD().GetConnection())
                {
                    connection.Open();
                    string query = "SELECT nombre, precio, cantidad FROM Producto WHERE cod_prod = @cod_prod";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cod_prod", codigoProducto);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //obtener datos del producto y cantidad
                                string nombreProducto = reader["nombre"].ToString();
                                decimal precioUnitario = Convert.ToDecimal(reader["precio"]);
                                int cantidadDisponible = Convert.ToInt32(reader["cantidad"]);
                                if (cantidad > cantidadDisponible)
                                {
                                    //mostrar un mensaje de que el stock es insuficiente y mostrar la cantidad disponible
                                    MessageBox.Show($"Cantidad disponible para la venta" +
                                        $" de este producto: {cantidadDisponible}", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                //verificar si el producto ya está en la lista
                                DetalleVenta productoExistente = productosAgregados.FirstOrDefault(p => p.Codigo == codigoProducto);

                                if (productoExistente != null)
                                {
                                    // Si ya está, solo actualiza la cantidad (verificando que no exceda el stock)
                                    if (productoExistente.Cantidad + cantidad > cantidadDisponible)
                                    {
                                        MessageBox.Show($"Al agregar esta cantidad, se excederá el stock disponible ({cantidadDisponible}).", "Stock Excedido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        return;
                                    }
                                    productoExistente.Cantidad += cantidad;
                                }
                                else
                                {
                                    // Si es nuevo, lo agrega a la lista
                                    productosAgregados.Add(new DetalleVenta
                                    {
                                        Codigo = codigoProducto,
                                        Descripcion = nombreProducto,
                                        Cantidad = cantidad,
                                        PrecioUnitario = precioUnitario
                                    });
                                }
                                // 4. Actualizar la interfaz (TextBox de productos y totales)
                                ActualizarPantallaVenta();

                                // Opcional: Limpiar campos de entrada para el próximo producto
                                TBCodigo.Clear();
                                TBCantidad.Clear();
                                TBCodigo.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado con el código ingresado.", "Producto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos al buscar producto: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarPantallaVenta()
        {
            // 1. Actualizar el TextBox de Productos Agregados
            TBProdAgregados.Clear();
            decimal totalVenta = 0;

            foreach (var item in productosAgregados)
            {
                // Formato: [CANTIDAD] x [PRECIO UNITARIO] - [DESCRIPCION] (Subtotal: [SUBTOTAL])
                string linea = $"{item.Cantidad} x {item.PrecioUnitario:C} - {item.Descripcion} (Subtotal: {item.SubtotalProducto:C})";
                TBProdAgregados.AppendText(linea + Environment.NewLine);

                totalVenta += item.SubtotalProducto;
            }

            TBSubtotal.Text = totalVenta.ToString("N2"); // Formato numérico con 2 decimales
            TBTotal.Text = totalVenta.ToString("N2");    // Formato numérico con 2 decimales
        }

        public void RemoverProductoDeVenta(string codigo, int cantidadEliminar)
        {
            DetalleVenta producto = productosAgregados.FirstOrDefault(p => p.Codigo == codigo);

            if (producto != null)
            {
                if (cantidadEliminar >= producto.Cantidad)
                {
                    // Eliminar el producto completamente si la cantidad es mayor o igual
                    productosAgregados.Remove(producto);
                    MessageBox.Show($"Producto {producto.Descripcion} completamente removido de la venta.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Reducir la cantidad
                    producto.Cantidad -= cantidadEliminar;
                    MessageBox.Show($"{cantidadEliminar} unidades de {producto.Descripcion} removidas. Quedan {producto.Cantidad} unidades.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ActualizarPantallaVenta();
            }
            else
            {
                MessageBox.Show("El producto no se encuentra en la lista de venta actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // --- 1. Validaciones de Datos ---

            // 1.1. Cajero logueado (Usando SesionActual.IdUsuario)
            if (SesionActual.IdUsuario <= 0)
            {
                MessageBox.Show("No hay un cajero logueado. Cierre e inicie sesión nuevamente.", "Error de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 1.2. Cliente seleccionado (id_cliente es NOT NULL en tu tabla Venta)
            if (_idClienteSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar un cliente antes de guardar la venta.", "Cliente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1.3. Productos agregados (mínimo un producto)
            if (productosAgregados.Count == 0)
            {
                MessageBox.Show("La venta no tiene productos. Agregue al menos uno.", "Venta Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1.4. Total de la Venta
            if (!decimal.TryParse(TBTotal.Text, out decimal totalVenta) || totalVenta <= 0)
            {
                MessageBox.Show("El total de la venta es inválido o cero.", "Error de Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- 2. Ejecutar la Transacción de Guardado ---

            bool exito = GuardarVentaEnBD(_idClienteSeleccionado, SesionActual.IdUsuario, totalVenta, productosAgregados);

            if (exito)
            {
                MessageBox.Show("¡Venta registrada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormularioDespuesDeGuardar();
            }
            else
            {
                // El mensaje de error detallado se muestra dentro de GuardarVentaEnBD, aquí solo indicamos el fallo.
                MessageBox.Show("Ocurrió un error al registrar la venta. La venta no se guardó.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------------------------
        // MÉTODOS AUXILIARES PARA EL ACCESO A DATOS
        // ----------------------------------------------------------------------

        private bool GuardarVentaEnBD(int idCliente, int idCajero, decimal totalVenta, List<DetalleVenta> detalles)
        {
            ConexionBD conexionBd = new ConexionBD();
            using (SqlConnection connection = conexionBd.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // 1. Insertar la cabecera de la Venta y obtener el ID generado.
                    int idVenta = InsertarVenta(connection, transaction, idCliente, idCajero, totalVenta);

                    // 2. Insertar los Detalles de Venta y actualizar el Stock.
                    foreach (var detalle in detalles)
                    {
                        InsertarDetalleVenta(connection, transaction, idVenta, detalle);
                        ActualizarStock(connection, transaction, detalle.Codigo, detalle.Cantidad);
                    }

                    // 3. Confirmar la transacción
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // Si algo falla, deshacer todos los cambios.
                    transaction.Rollback();
                    MessageBox.Show("Transacción fallida. No se registró la venta ni se modificó el stock. Detalles: " + ex.Message, "Error Crítico de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private int InsertarVenta(SqlConnection connection, SqlTransaction transaction, int idCliente, int idCajero, decimal totalVenta)
        {
            // Consulta para insertar en Venta y recuperar el ID generado
            string query = @"INSERT INTO Venta (id_cliente, id_usuario, fecha, monto_total)
        VALUES (@id_cliente, @id_usuario, GETDATE(), @monto_total);
        SELECT SCOPE_IDENTITY();";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@id_cliente", idCliente);
                command.Parameters.AddWithValue("@id_usuario", idCajero);
                command.Parameters.AddWithValue("@monto_total", totalVenta);

                // Ejecutar y obtener el ID de la venta
                object result = command.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                {
                    throw new Exception("Error al obtener el ID de la venta insertada.");
                }
                return Convert.ToInt32(result);
            }
        }

        private void InsertarDetalleVenta(SqlConnection connection, SqlTransaction transaction, int idVenta, DetalleVenta detalle)
        {
            // OJO: Asumimos que 'Producto.cod_prod' (VARCHAR) se mapea a 'DetalleVenta.id_producto' (INT) 
            // en tu tabla SQL. Si 'id_producto' es INT, necesitamos el ID INT real del producto, no el código.
            // **Ajuste:** Si tu clase DetalleVenta.Codigo es el ID INT del producto (y no el código de barras/string), funcionará.
            // Si Codigo es el código de barras (string), la columna FK id_producto en DetalleVenta debe ser VARCHAR,
            // O necesitas buscar el ID INT del producto ANTES de insertarlo.

            // Si estás usando DetalleVenta.Codigo (string) para id_producto (INT): ESTO PUEDE FALLAR.
            // Aquí asumiremos que 'detalle.Codigo' contiene el id_producto (INT) que va a la FK. 
            // NOTA: Revisa tu lógica de producto/ID para asegurar que Codigo (string) no está siendo
            // usado donde se espera un INT (id_producto). Si Codigo es el cod_prod, 
            // y tu FK en DetalleVenta es Producto.cod_prod, entonces DetalleVenta.id_producto debe ser VARCHAR/string.

            // Para la implementación directa, asumo que `detalle.Codigo` es el valor a insertar en la columna `id_producto` (como INT):
            if (!int.TryParse(detalle.Codigo, out int idProducto))
            {
                // Si el código del producto no es un INT, lanza un error para detener la transacción.
                throw new Exception($"El código de producto '{detalle.Codigo}' no es un número válido para la FK id_producto.");
            }

            string query = @"INSERT INTO DetalleVenta (id_venta, id_producto, precio_unitario, cantidad, subtotal)
        VALUES (@id_venta, @id_producto, @precio_unitario, @cantidad, @subtotal)";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@id_venta", idVenta);
                command.Parameters.AddWithValue("@id_producto", idProducto); // Usando el INT parseado
                command.Parameters.AddWithValue("@precio_unitario", detalle.PrecioUnitario);
                command.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                command.Parameters.AddWithValue("@subtotal", detalle.SubtotalProducto);

                command.ExecuteNonQuery();
            }
        }

        private void ActualizarStock(SqlConnection connection, SqlTransaction transaction, string codigoProducto, int cantidadVendida)
        {
            // Asumimos que la columna de stock en la tabla Producto es 'cantidad'
            // y que la clave de búsqueda es 'cod_prod' (usando el código del producto).

            // De nuevo, si cod_prod es VARCHAR y DetalleVenta.Codigo es el ID (INT), hay un problema de diseño.
            // Aquí usamos el Codigo del objeto DetalleVenta, que esperamos sea el cod_prod:

            string query = @"UPDATE Producto
        SET cantidad = cantidad - @cantidadVendida
        WHERE cod_prod = @cod_prod";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@cantidadVendida", cantidadVendida);
                command.Parameters.AddWithValue("@cod_prod", codigoProducto);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    // Si no se actualiza ninguna fila, el producto pudo no existir o el stock era 0/insuficiente (aunque se valida antes).
                    throw new Exception($"Alerta: El stock del producto con código {codigoProducto} no fue actualizado (posiblemente inexistente o código incorrecto).");
                }
            }
        }

        private void LimpiarFormularioDespuesDeGuardar()
        {
            // Limpiar la lista de productos
            productosAgregados.Clear();

            // Limpiar campos de cliente
            _idClienteSeleccionado = 0;
            TBCuitCliente.Clear();
            TBNombreCliente.Clear();

            // Limpiar campos de producto
            TBCodigo.Clear();
            TBCantidad.Clear();

            // Actualizar la pantalla (limpiará la lista visible y los totales)
            ActualizarPantallaVenta();
        }
    }
}
