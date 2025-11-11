

namespace Proyecto_TallerII25_G56
{
    partial class UserPanel
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            menuStrip = new MenuStrip();
            adminMenu = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            UsuariosMenu = new ToolStripMenuItem();
            AddNewUserToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            UsersListToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            productsMenu = new ToolStripMenuItem();
            AddNewProductMenuStrip = new ToolStripMenuItem();
            listarProductosToolStripMenuItem = new ToolStripMenuItem();
            rubroToolStripMenuItem = new ToolStripMenuItem();
            AddNewRubroToolStripMenuItem = new ToolStripMenuItem();
            verRubrosToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            AddNewProveedorToolStripMenuItem = new ToolStripMenuItem();
            verProveedoresToolStripMenuItem = new ToolStripMenuItem();
            stockMenu = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            registrarVentaToolStripMenuItem = new ToolStripMenuItem();
            historialDeVentasToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.Transparent;
            menuStrip.BackgroundImageLayout = ImageLayout.None;
            menuStrip.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip.Items.AddRange(new ToolStripItem[] { adminMenu, UsuariosMenu, productsMenu, stockMenu, ventasToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(737, 27);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // adminMenu
            // 
            adminMenu.Alignment = ToolStripItemAlignment.Right;
            adminMenu.BackColor = Color.PaleGoldenrod;
            adminMenu.DropDownItems.AddRange(new ToolStripItem[] { profileToolStripMenuItem, ExitToolStripMenuItem });
            adminMenu.ForeColor = Color.FromArgb(128, 64, 0);
            adminMenu.ImageTransparentColor = Color.Transparent;
            adminMenu.Name = "adminMenu";
            adminMenu.Size = new Size(12, 23);
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Enabled = false;
            profileToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileToolStripMenuItem.ImageTransparentColor = Color.Black;
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.ShowShortcutKeys = false;
            profileToolStripMenuItem.Size = new Size(120, 24);
            profileToolStripMenuItem.Text = "Mi perfil";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            ExitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.ShowShortcutKeys = false;
            ExitToolStripMenuItem.Size = new Size(120, 24);
            ExitToolStripMenuItem.Text = "Salir";
            ExitToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            ExitToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // UsuariosMenu
            // 
            UsuariosMenu.BackColor = Color.FromArgb(128, 64, 0);
            UsuariosMenu.DropDownItems.AddRange(new ToolStripItem[] { AddNewUserToolStripMenuItem, toolStripSeparator6, UsersListToolStripMenuItem, toolStripSeparator7 });
            UsuariosMenu.ForeColor = Color.PaleGoldenrod;
            UsuariosMenu.Name = "UsuariosMenu";
            UsuariosMenu.Size = new Size(90, 23);
            UsuariosMenu.Text = "Usuarios";
            UsuariosMenu.Click += usuariosMenu_Click;
            // 
            // AddNewUserToolStripMenuItem
            // 
            AddNewUserToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewUserToolStripMenuItem.ImageTransparentColor = Color.Black;
            AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem";
            AddNewUserToolStripMenuItem.ShowShortcutKeys = false;
            AddNewUserToolStripMenuItem.Size = new Size(211, 24);
            AddNewUserToolStripMenuItem.Text = "Agregar nuevo usuario";
            AddNewUserToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            AddNewUserToolStripMenuItem.Click += AddNewUserToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(208, 6);
            // 
            // UsersListToolStripMenuItem
            // 
            UsersListToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsersListToolStripMenuItem.ImageTransparentColor = Color.Black;
            UsersListToolStripMenuItem.Name = "UsersListToolStripMenuItem";
            UsersListToolStripMenuItem.ShowShortcutKeys = false;
            UsersListToolStripMenuItem.Size = new Size(211, 24);
            UsersListToolStripMenuItem.Text = "Lista de usuarios";
            UsersListToolStripMenuItem.Click += UsersListToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(208, 6);
            // 
            // productsMenu
            // 
            productsMenu.BackColor = Color.PaleGoldenrod;
            productsMenu.DropDownItems.AddRange(new ToolStripItem[] { AddNewProductMenuStrip, listarProductosToolStripMenuItem, rubroToolStripMenuItem, proveedoresToolStripMenuItem });
            productsMenu.ForeColor = Color.FromArgb(128, 64, 0);
            productsMenu.Name = "productsMenu";
            productsMenu.Size = new Size(101, 23);
            productsMenu.Text = "Productos";
            productsMenu.Click += productsMenu_Click;
            // 
            // AddNewProductMenuStrip
            // 
            AddNewProductMenuStrip.CheckOnClick = true;
            AddNewProductMenuStrip.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewProductMenuStrip.ImageScaling = ToolStripItemImageScaling.None;
            AddNewProductMenuStrip.Name = "AddNewProductMenuStrip";
            AddNewProductMenuStrip.ShowShortcutKeys = false;
            AddNewProductMenuStrip.Size = new Size(220, 24);
            AddNewProductMenuStrip.Text = "Agregar nuevo producto";
            AddNewProductMenuStrip.Click += notAvailableToolStripMenuItem_Click;
            // 
            // listarProductosToolStripMenuItem
            // 
            listarProductosToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            listarProductosToolStripMenuItem.Size = new Size(220, 24);
            listarProductosToolStripMenuItem.Text = "Lista de productos";
            listarProductosToolStripMenuItem.Click += listarProductosToolStripMenuItem_Click;
            // 
            // rubroToolStripMenuItem
            // 
            rubroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddNewRubroToolStripMenuItem, verRubrosToolStripMenuItem });
            rubroToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rubroToolStripMenuItem.Name = "rubroToolStripMenuItem";
            rubroToolStripMenuItem.Size = new Size(220, 24);
            rubroToolStripMenuItem.Text = "Rubro";
            // 
            // AddNewRubroToolStripMenuItem
            // 
            AddNewRubroToolStripMenuItem.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewRubroToolStripMenuItem.Name = "AddNewRubroToolStripMenuItem";
            AddNewRubroToolStripMenuItem.Size = new Size(153, 22);
            AddNewRubroToolStripMenuItem.Text = "Agregar nuevo";
            AddNewRubroToolStripMenuItem.Click += AddNewRubroToolStripMenuItem_Click;
            // 
            // verRubrosToolStripMenuItem
            // 
            verRubrosToolStripMenuItem.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verRubrosToolStripMenuItem.Name = "verRubrosToolStripMenuItem";
            verRubrosToolStripMenuItem.Size = new Size(153, 22);
            verRubrosToolStripMenuItem.Text = "Ver rubros";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddNewProveedorToolStripMenuItem, verProveedoresToolStripMenuItem });
            proveedoresToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(220, 24);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // AddNewProveedorToolStripMenuItem
            // 
            AddNewProveedorToolStripMenuItem.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewProveedorToolStripMenuItem.Name = "AddNewProveedorToolStripMenuItem";
            AddNewProveedorToolStripMenuItem.Size = new Size(162, 22);
            AddNewProveedorToolStripMenuItem.Text = "Agregar nuevo";
            AddNewProveedorToolStripMenuItem.Click += AddNewProveedorToolStripMenuItem_Click;
            // 
            // verProveedoresToolStripMenuItem
            // 
            verProveedoresToolStripMenuItem.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verProveedoresToolStripMenuItem.Name = "verProveedoresToolStripMenuItem";
            verProveedoresToolStripMenuItem.Size = new Size(162, 22);
            verProveedoresToolStripMenuItem.Text = "Ver proveedores";
            verProveedoresToolStripMenuItem.Click += verProveedoresToolStripMenuItem_Click;
            // 
            // stockMenu
            // 
            stockMenu.BackColor = Color.FromArgb(128, 64, 0);
            stockMenu.DropDownItems.AddRange(new ToolStripItem[] { stockToolStripMenuItem });
            stockMenu.ForeColor = Color.PaleGoldenrod;
            stockMenu.Name = "stockMenu";
            stockMenu.Size = new Size(65, 23);
            stockMenu.Text = "Stock";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Enabled = false;
            stockToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(165, 24);
            stockToolStripMenuItem.Text = "No disponible";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.BackColor = Color.PaleGoldenrod;
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarVentaToolStripMenuItem, historialDeVentasToolStripMenuItem });
            ventasToolStripMenuItem.ForeColor = Color.FromArgb(128, 64, 0);
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(73, 23);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registrarVentaToolStripMenuItem
            // 
            registrarVentaToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            registrarVentaToolStripMenuItem.Size = new Size(193, 24);
            registrarVentaToolStripMenuItem.Text = "Registrar venta";
            registrarVentaToolStripMenuItem.Click += registrarVentaToolStripMenuItem_Click;
            // 
            // historialDeVentasToolStripMenuItem
            // 
            historialDeVentasToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            historialDeVentasToolStripMenuItem.Size = new Size(193, 24);
            historialDeVentasToolStripMenuItem.Text = "Historial de ventas";
            historialDeVentasToolStripMenuItem.Click += historialDeVentasToolStripMenuItem_Click;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(737, 523);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserPanel";
            Text = "Panel de usuario";
            Load += UserPanel_Load;
            Resize += UserPanel_Resize;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.MdiParent = this;
            newUser.Show();
        }

        private void UsersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersList usersList = new UsersList();
            usersList.MdiParent = this;
            usersList.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SesionActual.Limpiar();
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem adminMenu;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuariosMenu;
        private System.Windows.Forms.ToolStripMenuItem AddNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsMenu;
        private System.Windows.Forms.ToolStripMenuItem AddNewProductMenuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem stockMenu;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem listarProductosToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem registrarVentaToolStripMenuItem;
        private ToolStripMenuItem rubroToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem AddNewRubroToolStripMenuItem;
        private ToolStripMenuItem verRubrosToolStripMenuItem;
        private ToolStripMenuItem AddNewProveedorToolStripMenuItem;
        private ToolStripMenuItem verProveedoresToolStripMenuItem;
        private ToolStripMenuItem historialDeVentasToolStripMenuItem;
    }
}



