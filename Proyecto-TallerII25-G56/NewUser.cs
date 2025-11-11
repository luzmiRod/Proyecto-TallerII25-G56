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

            //redimension del icono warning
            Icon iconOriginal = new Icon("resources/circle_warning.ico");
            Bitmap bitmap = new Bitmap(iconOriginal.ToBitmap(), new Size(20, 20));
            Icon resizedIcon = Icon.FromHandle(bitmap.GetHicon());
            //asignacion del icono redimensionado al ErrorProvider
            errorProvider1.Icon = resizedIcon;

            //deshabilitar boton agregar inicialmente
            BAgregar.Enabled = false;

            //suscripcion al evento TextChanged y SelectedIndexChanged para validar el formulario
            TBNombre.TextChanged += (s, e) => ValidarFormulario();
            TBApellido.TextChanged += (s, e) => ValidarFormulario();
            TBDNI.TextChanged += (s, e) => ValidarFormulario();
            TBCorreo.TextChanged += (s, e) => ValidarFormulario();
            TBContrasenia.TextChanged += (s, e) => ValidarFormulario();
            CBTipoUsuario.SelectedIndexChanged += (s, e) => ValidarFormulario();
        }
        private void ValidarFormulario()
        {
            bool camposCompletos =
                !string.IsNullOrWhiteSpace(TBNombre.Text) &&
                !string.IsNullOrWhiteSpace(TBApellido.Text) &&
                !string.IsNullOrWhiteSpace(TBDNI.Text) &&
                !string.IsNullOrWhiteSpace(TBCorreo.Text) &&
                !string.IsNullOrWhiteSpace(TBContrasenia.Text) &&
                TBContrasenia.Text.Length >= 6 && // contraseña mínima
                CBTipoUsuario.SelectedIndex > 0; // debe ser 1 o más

            BAgregar.Enabled = camposCompletos;
        }

        private void BAgregar_Click_1(object sender, EventArgs e)
        {
            if (!ValidateChildren()) // fuerza que todos los Validating se ejecuten
            {
                MessageBox.Show("Complete todos los campos obligatorios");
                return;
            }

            // Contraseña encriptada antes de guardar
            string hashedPassword = PasswordUtils.HashPassword(TBContrasenia.Text.Trim());

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
                            MessageBox.Show("Usuario agregado exitosamente", "¡Hecho!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //limpiar campos
                            TBNombre.Clear();
                            TBApellido.Clear();
                            TBDNI.Clear();
                            TBCorreo.Clear();
                            TBContrasenia.Clear();
                            CBTipoUsuario.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el usuario", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Código de error para violación de restricción UNIQUE (Duplicate Key)
                    if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                    {
                        string mensajePersonalizado = "Error de duplicidad. ";

                        // Inspeccionar el mensaje de error para determinar qué campo está duplicado
                        if (sqlEx.Message.Contains("UQ_Usuario_Correo") || sqlEx.Message.Contains("correo"))
                        {
                            mensajePersonalizado += "El **correo electrónico** ya está registrado para otro usuario.";
                        }
                        else if (sqlEx.Message.Contains("UQ_Usuario_DNI") || sqlEx.Message.Contains("dni"))
                        {
                            mensajePersonalizado += "El **DNI** ya está registrado para otro usuario.";
                        }
                        else
                        {
                            mensajePersonalizado += "Ya existe un registro con un valor único duplicado.";
                        }

                        MessageBox.Show(mensajePersonalizado, "Error de Duplicidad",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error general: {ex.Message}");
                }
            }
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

        private void TBNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBNombre.Text))
            {
                errorProvider1.SetError(TBNombre, "El nombre es obligatorio.");
            }
            else
            {
                errorProvider1.SetError(TBNombre, "");
            }
        }

        private void TBApellido_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBApellido.Text))
            {
                errorProvider1.SetError(TBApellido, "El apellido es obligatorio.");
            }
            else
            {
                errorProvider1.SetError(TBApellido, "");
            }
        }

        private void TBDNI_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDNI.Text))
            {
                errorProvider1.SetError(TBDNI, "El DNI es obligatorio.");
            }
            else
            {
                errorProvider1.SetError(TBDNI, "");
            }
        }

        private void TBCorreo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBCorreo.Text))
            {
                errorProvider1.SetError(TBCorreo, "El correo es obligatorio.");
            }
            else if (!Regex.IsMatch(TBCorreo.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(TBCorreo, "Formato de correo inválido.");
            }
            else
            {
                errorProvider1.SetError(TBCorreo, "");
            }
        }

        private void TBContrasenia_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBContrasenia.Text))
            {
                errorProvider1.SetError(TBContrasenia, "La contraseña es obligatoria.");
            }
            else if (TBContrasenia.Text.Length < 6)
            {
                errorProvider1.SetError(TBContrasenia, "Debe tener al menos 6 caracteres.");
            }
            else
            {
                errorProvider1.SetError(TBContrasenia, "");
            }
        }

        private void CBTipoUsuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (CBTipoUsuario.SelectedIndex <= 0)
            {
                errorProvider1.SetError(CBTipoUsuario, "Debe seleccionar un tipo de usuario");
            }
            else
            {
                errorProvider1.SetError(CBTipoUsuario, "");
            }
        }
    }
}
