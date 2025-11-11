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
using static Proyecto_TallerII25_G56.NewUser;

namespace Proyecto_TallerII25_G56
{
    public partial class NewClient : Form
    {
        public string CuitClienteRegistrado { get; private set; }
        public string NombreClienteRegistrado { get; private set; }
        public class ConexionBD
        {
            private readonly string connetionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connetionString);
            }
        }
        public NewClient()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TBDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TBCorreo_Validating(object sender, CancelEventArgs e)
        {

        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            using (SqlConnection sqlConnection = conexion.GetConnection())
            {
                try
                {
                    sqlConnection.Open();
                    string query = "INSERT INTO Cliente (nombre, " +
                        "cuit, telefono, email, direccion)" +
                        "VALUES (@nombre, @cuit, @telefono, @email, @direccion)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@nombre", TBNombre.Text);
                        sqlCommand.Parameters.AddWithValue("@cuit", TBCuit.Text);
                        sqlCommand.Parameters.AddWithValue("@telefono", TBTelefono.Text);
                        sqlCommand.Parameters.AddWithValue("@email", TBCorreo.Text);
                        sqlCommand.Parameters.AddWithValue("@direccion", TBDireccion.Text);
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("El cliente se guardó correctamente", "¡Hecho!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 2. Almacenar los datos en la propiedad antes de cerrar.
                            this.CuitClienteRegistrado = TBCuit.Text.Trim();
                            this.NombreClienteRegistrado = TBNombre.Text.Trim(); // O el nombre completo si es una concatenación

                            // 3. Establecer el DialogResult
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el cliente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void TBDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void LDNI_Click(object sender, EventArgs e)
        {

        }
    }
}
