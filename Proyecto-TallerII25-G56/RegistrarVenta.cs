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
            EliminarProducto eliminarProducto = new EliminarProducto();
            eliminarProducto.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BRegistrarCliente_Click(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.ShowDialog();
        }

        private void TBNombreApellidoCliente_Click(object sender, EventArgs e)
        {

        }

        private void PBButtonFindCliente_Click(object sender, EventArgs e)
        {
            // Limpia el TextBox de nombre y apellido antes de la búsqueda.
            TBNombreApellidoCliente.Text = string.Empty;

            // Obtiene el DNI del TextBox y verifica que no esté vacío.
            string dni = TBDniCliente.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                return;
            }

            try
            {
                // Usa la sentencia 'using' para asegurar que la conexión se cierre correctamente.
                using (SqlConnection connection = new ConexionBD().GetConnection())
                {
                    connection.Open();

                    // Consulta SQL para buscar el cliente por DNI.
                    // Usamos parámetros para evitar la inyección de SQL.
                    string query = "SELECT nombre, apellido FROM Cliente WHERE dni = @dni";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agrega el parámetro DNI con el valor del TextBox.
                        command.Parameters.AddWithValue("@dni", dni);

                        // Ejecuta el comando y lee el resultado.
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Si se encuentra el cliente, completa el otro TextBox.
                                string nombre = reader["nombre"].ToString();
                                string apellido = reader["apellido"].ToString();
                                TBNombreApellidoCliente.Text = $"{nombre} {apellido}";
                            }
                            else
                            {
                                // Si no se encuentra el cliente, muestra un mensaje.
                                MessageBox.Show("Cliente no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Captura cualquier error de la base de datos y muestra un mensaje de error.
                MessageBox.Show("Error al conectar o consultar la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBDniCliente_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
