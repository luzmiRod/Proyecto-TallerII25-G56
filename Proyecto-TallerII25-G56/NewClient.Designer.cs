namespace Proyecto_TallerII25_G56
{
    partial class NewClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewClient));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            BCancelar = new Button();
            LNuevoCliente = new Label();
            BAgregar = new Button();
            TBCorreo = new TextBox();
            LCuit = new Label();
            TBCuit = new TextBox();
            TBNombre = new TextBox();
            LCorreo = new Label();
            LNombre = new Label();
            TBTelefono = new TextBox();
            LTelefono = new Label();
            TBDireccion = new TextBox();
            LDireccion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(152, 374);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 92);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 59);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = SystemColors.ButtonShadow;
            BCancelar.CausesValidation = false;
            BCancelar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = Color.SaddleBrown;
            BCancelar.ImageAlign = ContentAlignment.TopLeft;
            BCancelar.Location = new Point(24, 333);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(136, 35);
            BCancelar.TabIndex = 48;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // LNuevoCliente
            // 
            LNuevoCliente.AutoSize = true;
            LNuevoCliente.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNuevoCliente.Location = new Point(100, 67);
            LNuevoCliente.Name = "LNuevoCliente";
            LNuevoCliente.Size = new Size(194, 33);
            LNuevoCliente.TabIndex = 47;
            LNuevoCliente.Text = "Nuevo cliente";
            // 
            // BAgregar
            // 
            BAgregar.BackColor = SystemColors.ActiveBorder;
            BAgregar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregar.ForeColor = Color.DarkGreen;
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(240, 333);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(125, 35);
            BAgregar.TabIndex = 46;
            BAgregar.Text = "Guardar";
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // TBCorreo
            // 
            TBCorreo.Location = new Point(182, 207);
            TBCorreo.Name = "TBCorreo";
            TBCorreo.Size = new Size(183, 23);
            TBCorreo.TabIndex = 4;
            TBCorreo.KeyPress += TBCorreo_KeyPress;
            TBCorreo.Validating += TBCorreo_Validating;
            // 
            // LCuit
            // 
            LCuit.AutoSize = true;
            LCuit.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCuit.ForeColor = SystemColors.ActiveCaptionText;
            LCuit.Location = new Point(24, 164);
            LCuit.Name = "LCuit";
            LCuit.Size = new Size(103, 25);
            LCuit.TabIndex = 43;
            LCuit.Text = "CUIT/CUIL:";
            LCuit.Click += LDNI_Click;
            // 
            // TBCuit
            // 
            TBCuit.Location = new Point(182, 166);
            TBCuit.Name = "TBCuit";
            TBCuit.Size = new Size(183, 23);
            TBCuit.TabIndex = 3;
            TBCuit.KeyPress += TBDNI_KeyPress;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(182, 126);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(183, 23);
            TBNombre.TabIndex = 1;
            TBNombre.KeyPress += TBNombre_KeyPress;
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCorreo.ForeColor = SystemColors.ActiveCaptionText;
            LCorreo.Location = new Point(24, 202);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(76, 25);
            LCorreo.TabIndex = 36;
            LCorreo.Text = "Correo:";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombre.ForeColor = SystemColors.ActiveCaptionText;
            LNombre.Location = new Point(24, 124);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(84, 25);
            LNombre.TabIndex = 34;
            LNombre.Text = "Nombre:";
            // 
            // TBTelefono
            // 
            TBTelefono.Location = new Point(182, 252);
            TBTelefono.Name = "TBTelefono";
            TBTelefono.Size = new Size(183, 23);
            TBTelefono.TabIndex = 5;
            TBTelefono.KeyPress += TBTelefono_KeyPress;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTelefono.ForeColor = SystemColors.ActiveCaptionText;
            LTelefono.Location = new Point(24, 247);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(93, 25);
            LTelefono.TabIndex = 52;
            LTelefono.Text = "Teléfono:";
            // 
            // TBDireccion
            // 
            TBDireccion.Location = new Point(182, 293);
            TBDireccion.Name = "TBDireccion";
            TBDireccion.Size = new Size(183, 23);
            TBDireccion.TabIndex = 6;
            TBDireccion.TextChanged += TBDireccion_TextChanged;
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LDireccion.ForeColor = SystemColors.ActiveCaptionText;
            LDireccion.Location = new Point(24, 293);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(99, 25);
            LDireccion.TabIndex = 54;
            LDireccion.Text = "Dirección:";
            // 
            // NewClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 468);
            Controls.Add(TBDireccion);
            Controls.Add(LDireccion);
            Controls.Add(TBTelefono);
            Controls.Add(LTelefono);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BCancelar);
            Controls.Add(LNuevoCliente);
            Controls.Add(BAgregar);
            Controls.Add(TBCorreo);
            Controls.Add(LCuit);
            Controls.Add(TBCuit);
            Controls.Add(TBNombre);
            Controls.Add(LCorreo);
            Controls.Add(LNombre);
            Name = "NewClient";
            Text = "NewClient";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button BCancelar;
        private Label LNuevoCliente;
        private Button BAgregar;
        private TextBox TBCorreo;
        private Label LCuit;
        private TextBox TBCuit;
        private TextBox TBNombre;
        private Label LCorreo;
        private Label LNombre;
        private TextBox TBTelefono;
        private Label LTelefono;
        private TextBox TBDireccion;
        private Label LDireccion;
    }
}