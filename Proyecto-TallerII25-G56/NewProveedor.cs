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
    public partial class NewProveedor : Form
    {
        public NewProveedor()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
