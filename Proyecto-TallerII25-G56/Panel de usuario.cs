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
            this.Resize += new EventHandler(UserPanel_Resize);

        }

        private void ModifyUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void UserPanel_Resize(object sender, EventArgs e)
        {

        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            ControlarMenuPorTipoUsuario();
            adminMenu.Text = $"{SesionActual.Nombre} ({SesionActual.TipoUsuario})";
        }

        private void ControlarMenuPorTipoUsuario()
        {
            // Obtener el tipo de usuario actual
            string tipoUsuario = SesionActual.TipoUsuario;

            // Habilitar o deshabilitar menús según el tipo de usuario
            if (tipoUsuario == "Administrador" || tipoUsuario == "Gerente")
            {
                this.UsuariosMenu.Visible = true;
                this.AddNewProductMenuStrip.Enabled = true;
                this.registrarVentaToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.UsuariosMenu.Visible = false;
                this.AddNewProductMenuStrip.Enabled = false;
                this.AddNewRubroToolStripMenuItem.Enabled = false;
                this.AddNewProveedorToolStripMenuItem.Enabled = false;
            }
        }
        private void usuariosMenu_Click(object sender, EventArgs e)
        {

        }

        private void productsMenu_Click(object sender, EventArgs e)
        {

        }

        private void notAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();
            newProduct.MdiParent = this;
            newProduct.Show();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsList productsList = new ProductsList();
            productsList.MdiParent = this;
            productsList.Show();
        }

        private void AddNewProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProveedor newProveedor = new NewProveedor();
            newProveedor.MdiParent = this;
            newProveedor.Show();
        }

        private void verProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedoresList proveedoresList = new ProveedoresList();
            proveedoresList.MdiParent = this;
            proveedoresList.Show();
        }

        private void AddNewRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRubro newRubro = new NewRubro();
            newRubro.MdiParent = this;
            newRubro.Show();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarVenta registrarVenta = new RegistrarVenta();
            registrarVenta.MdiParent = this;
            registrarVenta.Show();
        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialVentas historialVentas = new HistorialVentas();
            historialVentas.MdiParent = this;
            historialVentas.Show();
        }
    }
}
