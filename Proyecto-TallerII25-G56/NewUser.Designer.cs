namespace Proyecto_TallerII25_G56
{
    partial class NewUser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            CBTipoUsuario = new ComboBox();
            LTipoUsuario = new Label();
            TBCorreo = new TextBox();
            LDNI = new Label();
            TBDNI = new TextBox();
            TBContrasenia = new TextBox();
            TBApellido = new TextBox();
            TBNombre = new TextBox();
            LContrasenia = new Label();
            LCorreo = new Label();
            LNombre = new Label();
            LApellido = new Label();
            BAgregar = new Button();
            LNuevoUsuario = new Label();
            BCancelar = new Button();
            CBMostrarContrasenia = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // CBTipoUsuario
            // 
            CBTipoUsuario.FormattingEnabled = true;
            CBTipoUsuario.Items.AddRange(new object[] { "--Seleccione una opción--", "Cajero", "Gerente", "Administrador" });
            CBTipoUsuario.Location = new Point(187, 361);
            CBTipoUsuario.Name = "CBTipoUsuario";
            CBTipoUsuario.Size = new Size(183, 23);
            CBTipoUsuario.TabIndex = 21;
            // 
            // LTipoUsuario
            // 
            LTipoUsuario.AutoSize = true;
            LTipoUsuario.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTipoUsuario.ForeColor = SystemColors.ActiveCaptionText;
            LTipoUsuario.Location = new Point(29, 359);
            LTipoUsuario.Name = "LTipoUsuario";
            LTipoUsuario.Size = new Size(152, 25);
            LTipoUsuario.TabIndex = 27;
            LTipoUsuario.Text = "Tipo de usuario:";
            // 
            // TBCorreo
            // 
            TBCorreo.Location = new Point(187, 265);
            TBCorreo.Name = "TBCorreo";
            TBCorreo.Size = new Size(183, 23);
            TBCorreo.TabIndex = 26;
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LDNI.ForeColor = SystemColors.ActiveCaptionText;
            LDNI.Location = new Point(29, 216);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(47, 25);
            LDNI.TabIndex = 25;
            LDNI.Text = "DNI:";
            // 
            // TBDNI
            // 
            TBDNI.Location = new Point(187, 218);
            TBDNI.Name = "TBDNI";
            TBDNI.Size = new Size(183, 23);
            TBDNI.TabIndex = 24;
            TBDNI.KeyPress += TBDNI_KeyPress;
            // 
            // TBContrasenia
            // 
            TBContrasenia.Location = new Point(187, 307);
            TBContrasenia.Name = "TBContrasenia";
            TBContrasenia.Size = new Size(183, 23);
            TBContrasenia.TabIndex = 22;
            TBContrasenia.UseSystemPasswordChar = true;
            // 
            // TBApellido
            // 
            TBApellido.Location = new Point(187, 177);
            TBApellido.Name = "TBApellido";
            TBApellido.Size = new Size(183, 23);
            TBApellido.TabIndex = 23;
            TBApellido.KeyPress += TBApellido_KeyPress;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(187, 133);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(183, 23);
            TBNombre.TabIndex = 20;
            TBNombre.TextChanged += TBNombre_TextChanged;
            TBNombre.KeyPress += TBNombre_KeyPress;
            // 
            // LContrasenia
            // 
            LContrasenia.AutoSize = true;
            LContrasenia.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LContrasenia.ForeColor = SystemColors.ActiveCaptionText;
            LContrasenia.Location = new Point(29, 307);
            LContrasenia.Name = "LContrasenia";
            LContrasenia.Size = new Size(116, 25);
            LContrasenia.TabIndex = 19;
            LContrasenia.Text = "Contraseña:";
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCorreo.ForeColor = SystemColors.ActiveCaptionText;
            LCorreo.Location = new Point(29, 260);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(76, 25);
            LCorreo.TabIndex = 18;
            LCorreo.Text = "Correo:";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombre.ForeColor = SystemColors.ActiveCaptionText;
            LNombre.Location = new Point(29, 131);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(84, 25);
            LNombre.TabIndex = 16;
            LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LApellido.ForeColor = SystemColors.ActiveCaptionText;
            LApellido.Location = new Point(29, 172);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(88, 25);
            LApellido.TabIndex = 17;
            LApellido.Text = "Apellido:";
            // 
            // BAgregar
            // 
            BAgregar.BackColor = Color.LightGreen;
            BAgregar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(245, 422);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(125, 35);
            BAgregar.TabIndex = 28;
            BAgregar.Text = "Crear usuario";
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click_1;
            // 
            // LNuevoUsuario
            // 
            LNuevoUsuario.AutoSize = true;
            LNuevoUsuario.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNuevoUsuario.Location = new Point(93, 74);
            LNuevoUsuario.Name = "LNuevoUsuario";
            LNuevoUsuario.Size = new Size(202, 33);
            LNuevoUsuario.TabIndex = 29;
            LNuevoUsuario.Text = "Nuevo usuario";
            LNuevoUsuario.Click += LNuevoUsuario_Click;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.DarkSalmon;
            BCancelar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ImageAlign = ContentAlignment.TopLeft;
            BCancelar.Location = new Point(29, 422);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(136, 35);
            BCancelar.TabIndex = 30;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // CBMostrarContrasenia
            // 
            CBMostrarContrasenia.AutoSize = true;
            CBMostrarContrasenia.Location = new Point(187, 336);
            CBMostrarContrasenia.Name = "CBMostrarContrasenia";
            CBMostrarContrasenia.Size = new Size(128, 19);
            CBMostrarContrasenia.TabIndex = 31;
            CBMostrarContrasenia.Text = "Mostrar contraseña";
            CBMostrarContrasenia.UseVisualStyleBackColor = true;
            CBMostrarContrasenia.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(157, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(157, 463);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 92);
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // NewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 567);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(CBMostrarContrasenia);
            Controls.Add(BCancelar);
            Controls.Add(LNuevoUsuario);
            Controls.Add(BAgregar);
            Controls.Add(CBTipoUsuario);
            Controls.Add(LTipoUsuario);
            Controls.Add(TBCorreo);
            Controls.Add(LDNI);
            Controls.Add(TBDNI);
            Controls.Add(TBContrasenia);
            Controls.Add(TBApellido);
            Controls.Add(TBNombre);
            Controls.Add(LContrasenia);
            Controls.Add(LCorreo);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Name = "NewUser";
            Text = "Nuevo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBTipoUsuario;
        private Label LTipoUsuario;
        private TextBox TBCorreo;
        private Label LDNI;
        private TextBox TBDNI;
        private TextBox TBContrasenia;
        private TextBox TBApellido;
        private TextBox TBNombre;
        private Label LContrasenia;
        private Label LCorreo;
        private Label LNombre;
        private Label LApellido;
        private Button BAgregar;
        private Label LNuevoUsuario;
        private Button BCancelar;
        private CheckBox CBMostrarContrasenia;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
