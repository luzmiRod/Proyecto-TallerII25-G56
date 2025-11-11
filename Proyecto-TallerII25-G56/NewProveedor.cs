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

namespace Proyecto_TallerII25_G56
{
    public partial class NewProveedor : Form
    {
        public class ConexionBD
        {
            private readonly string connetionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connetionString);
            }
        }
        public NewProveedor()
        {
            InitializeComponent();
            CargarRubros();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBCuilCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public class RubroItem
        {
            public int Id_Rubro { get; set; }
            public string Codigo { get; set; }
            public string Nombre { get; set; }

            public RubroItem(int idRubro, string codigo, string nombre)
            {
                Id_Rubro = idRubro;
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
            // Asegúrate de que tu ComboBox se llame CMRubro (o ajusta el nombre)
            // Es recomendable limpiar la lista antes de cargarla
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
                                    int idRubro = reader.GetInt32(0); // Columna 0: id_rubro
                                    string codigo = reader.GetString(1);
                                    string nombre = reader.GetString(2); // Columna 1: nombre

                                    // Creamos un objeto que combine el nombre y el código
                                    // Esto es clave para trabajar con ComboBox
                                    CBRubro.Items.Add(new RubroItem(idRubro, codigo, nombre));
                                }

                                // Opcional: Seleccionar el primer elemento por defecto
                                if (CBRubro.Items.Count > 0)
                                {
                                    CBRubro.SelectedIndex = -1;
                                }
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

        private void LimpiarCampos()
        {
            TBCuilCuit.Clear();
            TBNombre.Clear();
            TBCorreo.Clear();
            TBDireccion.Clear();
            TBTelefono.Clear();
            CBRubro.SelectedIndex = -1;
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
                    int codigoRubroParaInsertar = rubroSeleccionado.Id_Rubro;
                    string query = "INSERT INTO Proveedor (cuit, nombre, email, direccion," +
                        " telefono, cod_rubro) VALUES ( @cuit, @nombre, @email, @direccion," +
                        " @telefono, @cod_rubro)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@cuit", TBCuilCuit.Text);
                        sqlCommand.Parameters.AddWithValue("@nombre", TBNombre.Text);
                        sqlCommand.Parameters.AddWithValue("@email", TBCorreo.Text);
                        sqlCommand.Parameters.AddWithValue("@direccion", TBDireccion.Text);
                        sqlCommand.Parameters.AddWithValue("@telefono", TBTelefono.Text);
                        sqlCommand.Parameters.AddWithValue("@cod_rubro", codigoRubroParaInsertar);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Proveedor agregado exitosamente.", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el proveedor: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
