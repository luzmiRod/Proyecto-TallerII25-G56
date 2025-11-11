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
    public partial class NewRubro : Form
    {
        public class ConexionBD
        {
            private readonly string connetionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connetionString);
            }
        }
        public NewRubro()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
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
        private void LimpiarCampos()
        {
            TBCodigo.Clear();
            TBNombre.Clear();
        }
        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBCodigo.Text) || string.IsNullOrWhiteSpace(TBNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el Código y el Nombre del Rubro.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir si falta información
            }
            ConexionBD conexion = new ConexionBD();
            using (SqlConnection sqlConnection = conexion.GetConnection())
            {
                try
                {
                    sqlConnection.Open();
                    string verificarQuery = "SELECT COUNT(1) FROM Rubro WHERE cod_rubro = @cod_rubro";
                    using (SqlCommand verificarCommand = new SqlCommand(verificarQuery, sqlConnection))
                    {
                        // Usamos el texto original del TextBox para el parámetro
                        verificarCommand.Parameters.AddWithValue("@cod_rubro", TBCodigo.Text);

                        // Ejecutamos la consulta y obtenemos el resultado
                        int count = (int)verificarCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            // Si count > 0, significa que el código ya está en uso.
                            MessageBox.Show("¡Advertencia! El Código '" + TBCodigo.Text + "' ya ha sido asignado a otro rubro. Por favor, intente con otro código.", "Código en uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Detener la ejecución para que el usuario pueda corregir.
                        }
                    }
                    string query = "INSERT INTO Rubro (cod_rubro, nombre)" +
                        "VALUES (@cod_rubro, @nombre)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@cod_rubro", TBCodigo.Text);
                        sqlCommand.Parameters.AddWithValue("@nombre", TBNombre.Text);
                        sqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Nuevo rubro agregado correctamente", "¡Hecho!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el rubro: " + ex.Message);
                }
            }
        }
    }
}
