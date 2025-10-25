using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TallerII25_G56
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            BLogin.Enabled = false;
        }
        private void VerificarCampos()
        {
            // El botón se habilita solo si AMBOS campos tienen texto (no están vacíos o solo con espacios)
            BLogin.Enabled = !string.IsNullOrWhiteSpace(TBCorreo.Text) && !string.IsNullOrWhiteSpace(TBContrasenia.Text);
        }
        private void BLogin_Click(object sender, EventArgs e)
        {
            string correo = TBCorreo.Text;
            string password = TBContrasenia.Text;
            string hashedPassword = PasswordUtils.HashPassword(password);

            string connectionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_usuario, nombre, apellido, correo, tipo_usuario, activo FROM usuario WHERE correo = @correo AND contrasena = @contrasena";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contrasena", hashedPassword);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read() && (correo != null) && (password != null))
                            {
                                // Guardar los datos del usuario en la sesión
                                SesionActual.IdUsuario = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                                SesionActual.Nombre = reader["nombre"].ToString() ?? string.Empty;
                                SesionActual.Apellido = reader["apellido"].ToString() ?? string.Empty;
                                SesionActual.Correo = reader["correo"].ToString() ?? string.Empty;
                                SesionActual.TipoUsuario = reader["tipo_usuario"].ToString() ?? string.Empty;
                                SesionActual.Activo = reader.GetBoolean(reader.GetOrdinal("activo") );

                                if (SesionActual.Activo != false)
                                {
                                UserPanel userForm = new UserPanel();
                                userForm.Show();
                                this.Hide();
                            } else
                            {
                                MessageBox.Show("Este usuario se encuentra deshabilitado. " +
                                  "Si crees que es un error, contactate al correo: " +
                                "soporte_supermercado@market.com", "No podes iniciar sesión",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        }
                            else
                            {
                                MessageBox.Show("Correo o contraseña incorrectos.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void TBCorreo_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }
        private void TBContrasenia_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBMostrarContrasenia_CheckedChanged(object sender, EventArgs e)
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

        private void TBCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(TBCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(TBCorreo, "El formato de correo no es válido");
            }
            else
            {
                errorProvider1.SetError(TBCorreo, "");
            }
        }
    }
}
