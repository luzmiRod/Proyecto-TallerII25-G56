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
    public partial class HistorialVentas : Form
    {
        public HistorialVentas()
        {
            InitializeComponent();
        }

        private void HistorialVentas_Load(object sender, EventArgs e)
        {
            CargarDatosMock();
        }

        private void CargarDatosMock()
        {
            Image? imagen = imageList1.Images["finance-book-economy-svgrepo-com.png"];
            dgvHistorialVentas.Rows.Add(
                "012358",
                "26/09/25",
                "Luzmila Rodriguez",
                "$ 36784",
                imagen
            );

            dgvHistorialVentas.Rows.Add(
                "045789",
                "15/08/25",
                "Leandro Muñoz",
                "$ 13456",
                imagen
            );
        }
    }
}
