namespace Proyecto_TallerII25_G56
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            ingresarToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { soporteToolStripMenuItem, ingresarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(2);
            menuStrip1.Size = new Size(622, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            soporteToolStripMenuItem.BackColor = Color.FromArgb(128, 64, 0);
            soporteToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            soporteToolStripMenuItem.ForeColor = Color.PaleGoldenrod;
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(70, 24);
            soporteToolStripMenuItem.Text = "Soporte";
            soporteToolStripMenuItem.Click += soporteToolStripMenuItem_Click;
            // 
            // ingresarToolStripMenuItem
            // 
            ingresarToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            ingresarToolStripMenuItem.BackColor = Color.PaleGoldenrod;
            ingresarToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ingresarToolStripMenuItem.ForeColor = Color.FromArgb(128, 64, 0);
            ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            ingresarToolStripMenuItem.Size = new Size(72, 24);
            ingresarToolStripMenuItem.Text = "Ingresar";
            ingresarToolStripMenuItem.Click += ingresarToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Yellow_and_Blue_Playful_Hand_drawn_Supermarket_Logo__2_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 235);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2e24d0fabcfbb1ad0347371cb8c38327;
            ClientSize = new Size(622, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            Text = "Supermercado";
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ingresarToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem soporteToolStripMenuItem;
    }
}