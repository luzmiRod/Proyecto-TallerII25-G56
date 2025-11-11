namespace Proyecto_TallerII25_G56
{
    partial class NewProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProveedor));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            BCancelar = new Button();
            LNombre = new Label();
            BAgregar = new Button();
            CBRubro = new ComboBox();
            TBCorreo = new TextBox();
            TBNombre = new TextBox();
            LCorreo = new Label();
            LCuil_cuit = new Label();
            TBTelefono = new TextBox();
            LTelefono = new Label();
            TBDireccion = new TextBox();
            LDireccion = new Label();
            TBCuilCuit = new TextBox();
            LRubro = new Label();
            BGuardar = new Button();
            LNuevoProveedor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(146, 426);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 92);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(156, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
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
            BCancelar.Location = new Point(18, 385);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(136, 35);
            BCancelar.TabIndex = 8;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombre.ForeColor = SystemColors.ActiveCaptionText;
            LNombre.Location = new Point(18, 131);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(84, 25);
            LNombre.TabIndex = 34;
            LNombre.Text = "Nombre:";
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(0, 0);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(75, 23);
            BAgregar.TabIndex = 0;
            // 
            // CBRubro
            // 
            CBRubro.DropDownStyle = ComboBoxStyle.DropDownList;
            CBRubro.FormattingEnabled = true;
            CBRubro.Location = new Point(176, 335);
            CBRubro.Name = "CBRubro";
            CBRubro.Size = new Size(183, 23);
            CBRubro.TabIndex = 6;
            // 
            // TBCorreo
            // 
            TBCorreo.Location = new Point(176, 216);
            TBCorreo.Name = "TBCorreo";
            TBCorreo.Size = new Size(183, 23);
            TBCorreo.TabIndex = 3;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(176, 133);
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
            LCorreo.Location = new Point(18, 211);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(76, 25);
            LCorreo.TabIndex = 36;
            LCorreo.Text = "Correo:";
            // 
            // LCuil_cuit
            // 
            LCuil_cuit.AutoSize = true;
            LCuil_cuit.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCuil_cuit.ForeColor = SystemColors.ActiveCaptionText;
            LCuil_cuit.Location = new Point(18, 172);
            LCuil_cuit.Name = "LCuil_cuit";
            LCuil_cuit.Size = new Size(103, 25);
            LCuil_cuit.TabIndex = 35;
            LCuil_cuit.Text = "CUIT/CUIL:";
            // 
            // TBTelefono
            // 
            TBTelefono.Location = new Point(176, 254);
            TBTelefono.Name = "TBTelefono";
            TBTelefono.Size = new Size(183, 23);
            TBTelefono.TabIndex = 4;
            TBTelefono.TextChanged += TBTelefono_TextChanged;
            TBTelefono.KeyPress += TBTelefono_KeyPress;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTelefono.ForeColor = SystemColors.ActiveCaptionText;
            LTelefono.Location = new Point(18, 249);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(93, 25);
            LTelefono.TabIndex = 52;
            LTelefono.Text = "Teléfono:";
            // 
            // TBDireccion
            // 
            TBDireccion.Location = new Point(176, 292);
            TBDireccion.Name = "TBDireccion";
            TBDireccion.Size = new Size(183, 23);
            TBDireccion.TabIndex = 5;
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LDireccion.ForeColor = SystemColors.ActiveCaptionText;
            LDireccion.Location = new Point(18, 287);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(99, 25);
            LDireccion.TabIndex = 54;
            LDireccion.Text = "Dirección:";
            // 
            // TBCuilCuit
            // 
            TBCuilCuit.Location = new Point(176, 177);
            TBCuilCuit.Name = "TBCuilCuit";
            TBCuilCuit.Size = new Size(183, 23);
            TBCuilCuit.TabIndex = 2;
            TBCuilCuit.KeyPress += TBCuilCuit_KeyPress;
            // 
            // LRubro
            // 
            LRubro.AutoSize = true;
            LRubro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LRubro.ForeColor = SystemColors.ActiveCaptionText;
            LRubro.Location = new Point(18, 330);
            LRubro.Name = "LRubro";
            LRubro.Size = new Size(70, 25);
            LRubro.TabIndex = 57;
            LRubro.Text = "Rubro:";
            // 
            // BGuardar
            // 
            BGuardar.BackColor = SystemColors.ActiveBorder;
            BGuardar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BGuardar.ForeColor = Color.DarkGreen;
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(234, 385);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(125, 35);
            BGuardar.TabIndex = 7;
            BGuardar.Text = "Guardar";
            BGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // LNuevoProveedor
            // 
            LNuevoProveedor.AutoSize = true;
            LNuevoProveedor.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNuevoProveedor.Location = new Point(86, 85);
            LNuevoProveedor.Name = "LNuevoProveedor";
            LNuevoProveedor.Size = new Size(235, 33);
            LNuevoProveedor.TabIndex = 59;
            LNuevoProveedor.Text = "Nuevo proveedor";
            // 
            // NewProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 514);
            Controls.Add(LNuevoProveedor);
            Controls.Add(BGuardar);
            Controls.Add(LRubro);
            Controls.Add(TBCuilCuit);
            Controls.Add(TBDireccion);
            Controls.Add(LDireccion);
            Controls.Add(TBTelefono);
            Controls.Add(LTelefono);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BCancelar);
            Controls.Add(CBRubro);
            Controls.Add(TBCorreo);
            Controls.Add(TBNombre);
            Controls.Add(LCorreo);
            Controls.Add(LNombre);
            Controls.Add(LCuil_cuit);
            Name = "NewProveedor";
            Text = "Nuevo proveedor";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox CBMostrarContrasenia;
        private Button BCancelar;
        private Label LNuevoProveedor;
        private Button BAgregar;
        private ComboBox CBRubro;
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
        private Label LCuil_cuit;
        private TextBox TBTelefono;
        private Label LTelefono;
        private TextBox TBDireccion;
        private Label LDireccion;
        private TextBox TBCuilCuit;
        private Label LRubro;
        private Button BGuardar;
    }
}