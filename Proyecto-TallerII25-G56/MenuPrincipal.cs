using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TallerII25_G56
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para solitar soporte, contáctese " +
                "al correo: soporte_supermercado@market.com", "Soporte",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // Calcula la posición X para centrar el PictureBox
            int centerX = (this.ClientSize.Width - pictureBox1.Width) / 2;
            // Calcula la posición Y para centrar el PictureBox
            int centerY = (this.ClientSize.Height - pictureBox1.Height) / 2;

            pictureBox1.Location = new Point(centerX, centerY);
        }
    }
}
