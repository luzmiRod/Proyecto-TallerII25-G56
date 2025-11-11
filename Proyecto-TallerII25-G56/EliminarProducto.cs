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
    public partial class EliminarProducto : Form
    {
        private RegistrarVenta _formularioPadre;
        public EliminarProducto(RegistrarVenta padre)
        {
            InitializeComponent();
            _formularioPadre = padre;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            string codigoProducto = TBCodigoEliminar.Text.Trim();
            if (string.IsNullOrEmpty(codigoProducto) || !int.TryParse(TBCantidadEliminar.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese un código y una cantidad válida.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _formularioPadre.RemoverProductoDeVenta(codigoProducto, cantidad);

            this.Close();
        }
    }
}
