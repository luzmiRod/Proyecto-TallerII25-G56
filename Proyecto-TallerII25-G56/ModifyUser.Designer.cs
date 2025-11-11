namespace Proyecto_TallerII25_G56
{
    partial class ModifyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUser));
            BCancelar = new Button();
            LModificarUsuario = new Label();
            BModificar = new Button();
            CBTipoUsuario = new ComboBox();
            LTipoUsuario = new Label();
            TBCorreo = new TextBox();
            LDNI = new Label();
            TBDNI = new TextBox();
            TBApellido = new TextBox();
            TBNombre = new TextBox();
            LCorreo = new Label();
            LNombre = new Label();
            LApellido = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BCancelar
            // 
            BCancelar.BackColor = SystemColors.ButtonShadow;
            BCancelar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = Color.SaddleBrown;
            BCancelar.ImageAlign = ContentAlignment.TopLeft;
            BCancelar.Location = new Point(29, 347);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(136, 35);
            BCancelar.TabIndex = 47;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // LModificarUsuario
            // 
            LModificarUsuario.AutoSize = true;
            LModificarUsuario.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LModificarUsuario.Location = new Point(83, 65);
            LModificarUsuario.Name = "LModificarUsuario";
            LModificarUsuario.Size = new Size(244, 33);
            LModificarUsuario.TabIndex = 46;
            LModificarUsuario.Text = "Modificar usuario";
            // 
            // BModificar
            // 
            BModificar.BackColor = SystemColors.ActiveBorder;
            BModificar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BModificar.ForeColor = Color.DarkGreen;
            BModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BModificar.Location = new Point(245, 347);
            BModificar.Name = "BModificar";
            BModificar.Size = new Size(125, 35);
            BModificar.TabIndex = 45;
            BModificar.Text = "Modificar";
            BModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BModificar.UseVisualStyleBackColor = false;
            BModificar.Click += BModificar_Click;
            // 
            // CBTipoUsuario
            // 
            CBTipoUsuario.FormattingEnabled = true;
            CBTipoUsuario.Items.AddRange(new object[] { "--Seleccione una opción--", "Cajero", "Gerente", "Administrador" });
            CBTipoUsuario.Location = new Point(187, 298);
            CBTipoUsuario.Name = "CBTipoUsuario";
            CBTipoUsuario.Size = new Size(183, 23);
            CBTipoUsuario.TabIndex = 38;
            // 
            // LTipoUsuario
            // 
            LTipoUsuario.AutoSize = true;
            LTipoUsuario.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTipoUsuario.ForeColor = SystemColors.ActiveCaptionText;
            LTipoUsuario.Location = new Point(29, 296);
            LTipoUsuario.Name = "LTipoUsuario";
            LTipoUsuario.Size = new Size(152, 25);
            LTipoUsuario.TabIndex = 44;
            LTipoUsuario.Text = "Tipo de usuario:";
            // 
            // TBCorreo
            // 
            TBCorreo.Location = new Point(187, 255);
            TBCorreo.Name = "TBCorreo";
            TBCorreo.Size = new Size(183, 23);
            TBCorreo.TabIndex = 43;
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LDNI.ForeColor = SystemColors.ActiveCaptionText;
            LDNI.Location = new Point(29, 206);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(47, 25);
            LDNI.TabIndex = 42;
            LDNI.Text = "DNI:";
            // 
            // TBDNI
            // 
            TBDNI.Location = new Point(187, 208);
            TBDNI.Name = "TBDNI";
            TBDNI.Size = new Size(183, 23);
            TBDNI.TabIndex = 41;
            // 
            // TBApellido
            // 
            TBApellido.Location = new Point(187, 167);
            TBApellido.Name = "TBApellido";
            TBApellido.Size = new Size(183, 23);
            TBApellido.TabIndex = 40;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(187, 123);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(183, 23);
            TBNombre.TabIndex = 37;
            TBNombre.TextChanged += TBNombre_TextChanged;
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCorreo.ForeColor = SystemColors.ActiveCaptionText;
            LCorreo.Location = new Point(29, 250);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(76, 25);
            LCorreo.TabIndex = 35;
            LCorreo.Text = "Correo:";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombre.ForeColor = SystemColors.ActiveCaptionText;
            LNombre.Location = new Point(29, 121);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(84, 25);
            LNombre.TabIndex = 33;
            LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LApellido.ForeColor = SystemColors.ActiveCaptionText;
            LApellido.Location = new Point(29, 162);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(88, 25);
            LApellido.TabIndex = 34;
            LApellido.Text = "Apellido:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(163, 388);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 92);
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // ModifyUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(414, 498);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BCancelar);
            Controls.Add(LModificarUsuario);
            Controls.Add(BModificar);
            Controls.Add(CBTipoUsuario);
            Controls.Add(LTipoUsuario);
            Controls.Add(TBCorreo);
            Controls.Add(LDNI);
            Controls.Add(TBDNI);
            Controls.Add(TBApellido);
            Controls.Add(TBNombre);
            Controls.Add(LCorreo);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Name = "ModifyUser";
            Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BCancelar;
        private Label LModificarUsuario;
        private Button BModificar;
        private ComboBox CBTipoUsuario;
        private Label LTipoUsuario;
        private TextBox TBCorreo;
        private Label LDNI;
        private TextBox TBDNI;
        private TextBox TBApellido;
        private TextBox TBNombre;
        private Label LCorreo;
        private Label LNombre;
        private Label LApellido;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}