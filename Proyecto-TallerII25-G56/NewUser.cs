//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Proyecto_TallerII25_G56
{
    public partial class NewUser : Form
    {
        public class ConexionBD
        {
            private readonly string connetionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connetionString);
            }
        }

        public NewUser()
        {
            InitializeComponent();
            CBTipoUsuario.SelectedIndex = 0; //muestra el primer valor del ComboBox
            TBContrasenia.UseSystemPasswordChar = true;


        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAgregar_Click_1(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TBCorreo.Text) ||
                string.IsNullOrWhiteSpace(TBContrasenia.Text) ||
                string.IsNullOrWhiteSpace(TBDNI.Text) ||
                string.IsNullOrWhiteSpace(TBNombre.Text) ||
                string.IsNullOrWhiteSpace(TBApellido.Text) ||
                CBTipoUsuario.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.");
                return;
            }

            // Validación del formato de correo
            if (!Regex.IsMatch(TBCorreo.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo ingresado no es válido.");
                return;
            }

            // Validación de la longitud mínima de contraseña
            if (TBContrasenia.Text.Trim().Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                return;
            }

            // Contraseña encriptada antes de guardar
            string hashedPassword = HashPassword(TBContrasenia.Text.Trim());

            ConexionBD conexion = new ConexionBD();
            using (SqlConnection sqlConnection = conexion.GetConnection())
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"INSERT INTO Usuario (correo, contrasena, tipo_usuario, dni, nombre, apellido, activo, fecha_creacion) 
                                   VALUES (@correo, @contrasena, @tipo_usuario, @dni, @nombre, @apellido, @activo, @fecha_creacion)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@correo", TBCorreo.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@contrasena", hashedPassword);
                        sqlCommand.Parameters.AddWithValue("@tipo_usuario", CBTipoUsuario.Text);
                        sqlCommand.Parameters.AddWithValue("@dni", TBDNI.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@nombre", TBNombre.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@apellido", TBApellido.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@activo", 1);
                        sqlCommand.Parameters.AddWithValue("@fecha_creacion", DateTime.Now);

                        int result = sqlCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Usuario agregado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el usuario.");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Error de SQL Server: {sqlEx.Message}\nCódigo: {sqlEx.Number}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error general: {ex.Message}");
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2")); // convierte en hex
                }
                return builder.ToString();
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {

        }

        private void LNuevoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void TBDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite el ingreso de caracteres del tipo digit y que se pueda borrar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite el ingreso de caracteres del tipo letter y espacios, también permite borrar
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite el ingreso de caracteres del tipo letter y espacios, también permite borrar
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMostrarContrasenia.Checked)
            {
                TBContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                TBContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
