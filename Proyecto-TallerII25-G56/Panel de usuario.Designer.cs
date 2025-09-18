

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
            exitToolStripMenuItem = new ToolStripMenuItem();
            usuariosMenu = new ToolStripMenuItem();
            AddNewUserToolStripMenuItem = new ToolStripMenuItem();
            ModifyUserToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            usersListToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            productsMenu = new ToolStripMenuItem();
            notAvailableToolStripMenuItem = new ToolStripMenuItem();
            listarProductosToolStripMenuItem = new ToolStripMenuItem();
            stockMenu = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.Transparent;
            menuStrip.BackgroundImageLayout = ImageLayout.None;
            menuStrip.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip.Items.AddRange(new ToolStripItem[] { adminMenu, usuariosMenu, productsMenu, stockMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(737, 27);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // adminMenu
            // 
            adminMenu.Alignment = ToolStripItemAlignment.Right;
            adminMenu.BackColor = Color.PaleGoldenrod;
            adminMenu.DropDownItems.AddRange(new ToolStripItem[] { profileToolStripMenuItem, exitToolStripMenuItem });
            adminMenu.ForeColor = Color.FromArgb(128, 64, 0);
            adminMenu.ImageTransparentColor = Color.Transparent;
            adminMenu.Name = "adminMenu";
            adminMenu.Size = new Size(70, 23);
            adminMenu.Text = "Admin";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileToolStripMenuItem.ImageTransparentColor = Color.Black;
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.ShowShortcutKeys = false;
            profileToolStripMenuItem.Size = new Size(120, 24);
            profileToolStripMenuItem.Text = "Mi perfil";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShowShortcutKeys = false;
            exitToolStripMenuItem.Size = new Size(120, 24);
            exitToolStripMenuItem.Text = "Salir";
            exitToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            exitToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // usuariosMenu
            // 
            usuariosMenu.BackColor = Color.FromArgb(128, 64, 0);
            usuariosMenu.DropDownItems.AddRange(new ToolStripItem[] { AddNewUserToolStripMenuItem, ModifyUserToolStripMenuItem, toolStripSeparator6, usersListToolStripMenuItem, toolStripSeparator7 });
            usuariosMenu.ForeColor = Color.PaleGoldenrod;
            usuariosMenu.Name = "usuariosMenu";
            usuariosMenu.Size = new Size(90, 23);
            usuariosMenu.Text = "Usuarios";
            // 
            // AddNewUserToolStripMenuItem
            // 
            AddNewUserToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewUserToolStripMenuItem.ImageTransparentColor = Color.Black;
            AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem";
            AddNewUserToolStripMenuItem.ShowShortcutKeys = false;
            AddNewUserToolStripMenuItem.Size = new Size(236, 24);
            AddNewUserToolStripMenuItem.Text = "Agregar nuevo usuario";
            AddNewUserToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            AddNewUserToolStripMenuItem.Click += AddNewUserToolStripMenuItem_Click;
            // 
            // ModifyUserToolStripMenuItem
            // 
            ModifyUserToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModifyUserToolStripMenuItem.ImageTransparentColor = Color.Black;
            ModifyUserToolStripMenuItem.Name = "ModifyUserToolStripMenuItem";
            ModifyUserToolStripMenuItem.ShowShortcutKeys = false;
            ModifyUserToolStripMenuItem.Size = new Size(236, 24);
            ModifyUserToolStripMenuItem.Text = "Modificar usuario existente";
            ModifyUserToolStripMenuItem.Click += ModifyUserToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(233, 6);
            // 
            // usersListToolStripMenuItem
            // 
            usersListToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersListToolStripMenuItem.ImageTransparentColor = Color.Black;
            usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
            usersListToolStripMenuItem.ShowShortcutKeys = false;
            usersListToolStripMenuItem.Size = new Size(236, 24);
            usersListToolStripMenuItem.Text = "Listar usuarios";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(233, 6);
            // 
            // productsMenu
            // 
            productsMenu.BackColor = Color.PaleGoldenrod;
            productsMenu.DropDownItems.AddRange(new ToolStripItem[] { notAvailableToolStripMenuItem, listarProductosToolStripMenuItem });
            productsMenu.ForeColor = Color.FromArgb(128, 64, 0);
            productsMenu.Name = "productsMenu";
            productsMenu.Size = new Size(101, 23);
            productsMenu.Text = "Productos";
            // 
            // notAvailableToolStripMenuItem
            // 
            notAvailableToolStripMenuItem.CheckOnClick = true;
            notAvailableToolStripMenuItem.Enabled = false;
            notAvailableToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notAvailableToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            notAvailableToolStripMenuItem.Name = "notAvailableToolStripMenuItem";
            notAvailableToolStripMenuItem.ShowShortcutKeys = false;
            notAvailableToolStripMenuItem.Size = new Size(220, 24);
            notAvailableToolStripMenuItem.Text = "Agregar nuevo producto";
            // 
            // listarProductosToolStripMenuItem
            // 
            listarProductosToolStripMenuItem.Enabled = false;
            listarProductosToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            listarProductosToolStripMenuItem.Size = new Size(220, 24);
            listarProductosToolStripMenuItem.Text = "Listar productos";
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
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem adminMenu;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosMenu;
        private System.Windows.Forms.ToolStripMenuItem AddNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsMenu;
        private System.Windows.Forms.ToolStripMenuItem notAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem stockMenu;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem listarProductosToolStripMenuItem;
    }
}



