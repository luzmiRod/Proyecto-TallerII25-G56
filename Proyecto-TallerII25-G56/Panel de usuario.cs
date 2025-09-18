using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Proyecto_TallerII25_G56
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void ModifyUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyUser modifyUser = new ModifyUser();
            modifyUser.MdiParent = this;
            modifyUser.Show();
        }
    }
}
