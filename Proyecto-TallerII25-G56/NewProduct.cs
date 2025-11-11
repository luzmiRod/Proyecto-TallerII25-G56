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
    public partial class NewProduct : Form
    {
        public class ConexionBD
        {
            private readonly string connetionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connetionString);
            }
        }
        public NewProduct()
        {
            InitializeComponent();
            CargarRubros();
            CargarProveedores();
        }

        private void BCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite solo numeros y un punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
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
        public class ProveedorItem
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public ProveedorItem(int codigo, string nombre)
            {
                Codigo = codigo;
                Nombre = nombre;
            }
            public override string ToString()
            {
                return $"{Codigo} - {Nombre}";
            }
        }

        private void CargarRubros()
        {
            CBRubro.Items.Clear();

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
                                    CBRubro.Items.Add(new RubroItem(id, codigo, nombre));
                                }

                                    CBRubro.SelectedIndex = -1;
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
        private void CargarProveedores()
        {
            CBProveedor.Items.Clear();
            ConexionBD conexion = new ConexionBD();
            using (SqlConnection sqlConnection = conexion.GetConnection())
            {
                try
                {
                    sqlConnection.Open();
                    // Consulta SQL para obtener todos los proveedores
                    string query = "SELECT cod_prov, nombre FROM Proveedor ORDER BY nombre";
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
                                    int codigo = reader.GetInt32(0); // Columna 0: cod_proveedor
                                    string nombre = reader.GetString(1); // Columna 1: nombre
                                    // Creamos un objeto que combine el nombre y el código
                                    // Esto es clave para trabajar con ComboBox
                                    CBProveedor.Items.Add(new ProveedorItem(codigo, nombre));
                                }
                                CBProveedor.SelectedIndex = -1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los proveedores: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void LimpiarCampos()
        {
            TBCodProducto.Clear();
            TBNombre.Clear();
            TBDescripcion.Clear();
            TBPrecio.Clear();
            TBCantidad.Clear();
            CBRubro.SelectedIndex = -1;
            CBProveedor.SelectedIndex = -1;
            CBDisponible.SelectedIndex = -1;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            using (SqlConnection sqlConnection = conexion.GetConnection())
            {
                try
                {
                    sqlConnection.Open();
                    RubroItem rubroSeleccionado = (RubroItem)CBRubro.SelectedItem;
                    int idRubroParaInsertar = rubroSeleccionado.IdRubro;
                    ProveedorItem proveedorSeleccionado = (ProveedorItem)CBProveedor.SelectedItem;
                    int codigoProveedorParaInsertar = proveedorSeleccionado.Codigo;
                    string disponibilidadTexto = CBDisponible.SelectedItem != null ? CBDisponible.SelectedItem.ToString() : string.Empty;
                    int disponibleValor;

                    if (disponibilidadTexto.ToUpper() == "SI")
                    {
                        disponibleValor = 1;
                    }
                    else if (disponibilidadTexto.ToUpper() == "NO")
                    {
                        disponibleValor = 0;
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar 'SI' o 'NO' para el campo Disponible.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string query = "INSERT INTO Producto (cod_prod, nombre, descripcion," +
                        "precio, cantidad, disponible, cod_rubro, cod_prov) " +
                        "VALUES (@cod_prod, @nombre, @descripcion, @precio," +
                        "@cantidad, @disponible, @cod_rubro, @cod_prov)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@cod_prod", TBCodProducto.Text);
                        sqlCommand.Parameters.AddWithValue("@nombre", TBNombre.Text);
                        sqlCommand.Parameters.AddWithValue("@descripcion", TBDescripcion.Text);
                        sqlCommand.Parameters.AddWithValue("@precio", decimal.Parse(TBPrecio.Text));
                        sqlCommand.Parameters.AddWithValue("@cantidad", int.Parse(TBCantidad.Text));
                        sqlCommand.Parameters.AddWithValue("@disponible", disponibleValor);
                        sqlCommand.Parameters.AddWithValue("@cod_rubro", idRubroParaInsertar);
                        sqlCommand.Parameters.AddWithValue("@cod_prov", codigoProveedorParaInsertar);
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //LimpiarCampos();

                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CBRubro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
