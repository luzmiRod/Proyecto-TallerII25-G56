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
    public partial class ProveedoresList : Form
    {
        public ProveedoresList()
        {
            InitializeComponent();
        }

        private void ProveedoresList_Load(object sender, EventArgs e)
        {
            CargarDatosMock();
        }
        private void CargarDatosMock()
        {
            dgvProveedores.Rows.Add(
                "30-12345678-9",
                "Maxicuera",
                "Av. Independencia 5428",
                "379 - 4201478",
                "maxicuera@gmail.com",
                "Almacén"
            );

            dgvProveedores.Rows.Add(
                "30-12712678-0",
                "Distribuidora Pack",
                "Ruta 12 KM20",
                "379 - 4152689",
                "distripack@gmail.com",
                "Bebidas"
            );
        }

    }
}
