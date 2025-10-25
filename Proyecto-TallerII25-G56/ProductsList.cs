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
    public partial class ProductsList : Form
    {
        public ProductsList()
        {
            InitializeComponent();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ProductsList_Load_1(object sender, EventArgs e)
        {
            CargarDatosMock();
        }

        private void CargarDatosMock()
        {
            dgvProductos.Rows.Add(
                "012358",
                "Fideos",
                "Alimento no perecedero",
                "Almacén",
                "Maxicuera",
                "$899"
            );

            dgvProductos.Rows.Add(
                "045789",
                "Coca Cola",
                "Gaseosa 1,5l",
                "Bebidas",
                "Distribuidora Pack",
                "$1500"
            );
        }
    }
}
