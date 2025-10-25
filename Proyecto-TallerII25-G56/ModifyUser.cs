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
    public partial class ModifyUser : Form
    {
        private int _idUsuario;
        private Dictionary<string, string> _originalValues = new Dictionary<string, string>();
        public ModifyUser(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;

            CargarDatosUsuario();
            //guardar valores originales
            TBNombre.TextChanged += ControlChanged;
            TBApellido.TextChanged += ControlChanged;
            TBDNI.TextChanged += ControlChanged;
            TBCorreo.TextChanged += ControlChanged;
            CBTipoUsuario.SelectedIndexChanged += ControlChanged;

            //deshabilitar boton modificar inicialmente
            BModificar.Enabled = false;
            BModificar.Paint += new PaintEventHandler(BModificar_Paint);
        }

        private void BModificar_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;

            // Solo se personaliza el estilo cuando el botón está deshabilitado
            if (!btn.Enabled)
            {
                // Define el color gris transparente
                Color colorTransparente = Color.FromArgb(128, Color.Gray);

                using (SolidBrush brush = new SolidBrush(colorTransparente))
                {
                    e.Graphics.FillRectangle(brush, e.ClipRectangle);
                }

                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, e.ClipRectangle, Color.DarkGray, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            else
            {
                // si el boton esta habilitado se ve normal

            }
        }
        private void CargarDatosUsuario()
        {
            string connectionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT id_usuario, nombre, apellido, dni, correo, tipo_usuario, activo FROM Usuario WHERE id_usuario = @id_usuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_usuario", _idUsuario);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TBNombre.Text = reader["nombre"].ToString();
                    TBApellido.Text = reader["apellido"].ToString();
                    TBDNI.Text = reader["dni"].ToString();
                    TBCorreo.Text = reader["correo"].ToString();
                    CBTipoUsuario.SelectedItem = reader["tipo_usuario"].ToString();

                    //se guardan los valores originales
                    _originalValues["nombre"] = TBNombre.Text;
                    _originalValues["apellido"] = TBApellido.Text;
                    _originalValues["dni"] = TBDNI.Text;
                    _originalValues["correo"] = TBCorreo.Text;
                    _originalValues["tipo_usuario"] = CBTipoUsuario.SelectedItem?.ToString() ?? "";
                }
            }
        }
        private void ControlChanged(object sender, EventArgs e)
        {
            BModificar.Enabled = HayCambios();
        }

        private bool HayCambios()
        {
            return TBNombre.Text != _originalValues["nombre"] ||
                   TBApellido.Text != _originalValues["apellido"] ||
                   TBDNI.Text != _originalValues["dni"] ||
                   TBCorreo.Text != _originalValues["correo"] ||
                   (CBTipoUsuario.SelectedItem?.ToString() ?? "") != _originalValues["tipo_usuario"];
        }

        public event EventHandler UsuarioModificado;
        private void BModificar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            string query = @"UPDATE Usuario SET nombre = @nombre," +
                "apellido = @apellido, dni = @dni, correo = @correo," +
                "tipo_usuario = @tipo_usuario WHERE id_usuario = @id_usuario";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //parametros con valores de los controles
                    cmd.Parameters.AddWithValue("@nombre", TBNombre.Text);
                    cmd.Parameters.AddWithValue("@apellido", TBApellido.Text);
                    cmd.Parameters.AddWithValue("@dni", TBDNI.Text);
                    cmd.Parameters.AddWithValue("@correo", TBCorreo.Text);
                    cmd.Parameters.AddWithValue("@tipo_usuario", CBTipoUsuario.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@id_usuario", _idUsuario);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Usuario modificado exitosamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refrescar el datagridview en el formulario principal
                        UsuarioModificado?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el usuario", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
