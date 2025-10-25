namespace Proyecto_TallerII25_G56
{
    partial class NewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProduct));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            BCancelar = new Button();
            LNuevoProducto = new Label();
            BGuardar = new Button();
            CBProveedor = new ComboBox();
            LProveedor = new Label();
            TBCantidad = new TextBox();
            LPrecio = new Label();
            TBPrecio = new TextBox();
            TBApellido = new TextBox();
            TBNombre = new TextBox();
            LRubro = new Label();
            LCandidad = new Label();
            LNombre = new Label();
            LIdProducto = new Label();
            label1 = new Label();
            CBRubro = new ComboBox();
            CBDisponible = new ComboBox();
            LDisponible = new Label();
            LImagen = new Label();
            LDescripcion = new Label();
            TBDescripcion = new TextBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(279, 423);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 92);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(171, 12);
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
            BCancelar.Location = new Point(21, 480);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(136, 35);
            BCancelar.TabIndex = 48;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click_1;
            // 
            // LNuevoProducto
            // 
            LNuevoProducto.AutoSize = true;
            LNuevoProducto.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNuevoProducto.Location = new Point(257, 32);
            LNuevoProducto.Name = "LNuevoProducto";
            LNuevoProducto.Size = new Size(222, 33);
            LNuevoProducto.TabIndex = 47;
            LNuevoProducto.Text = "Nuevo producto";
            LNuevoProducto.Click += LNuevoUsuario_Click;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = SystemColors.ActiveBorder;
            BGuardar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BGuardar.ForeColor = Color.DarkGreen;
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(478, 480);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(125, 35);
            BGuardar.TabIndex = 46;
            BGuardar.Text = "Guardar";
            BGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BCancelar_Click_1;
            // 
            // CBProveedor
            // 
            CBProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            CBProveedor.FormattingEnabled = true;
            CBProveedor.Items.AddRange(new object[] { "Jufec S.A.", "Maxicuera", "Distribuidora Pack", "ChipiCoorp", "Maaths Dist S.R.L", "Calisa Ctes" });
            CBProveedor.Location = new Point(153, 369);
            CBProveedor.Name = "CBProveedor";
            CBProveedor.Size = new Size(199, 23);
            CBProveedor.TabIndex = 39;
            // 
            // LProveedor
            // 
            LProveedor.AutoSize = true;
            LProveedor.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LProveedor.ForeColor = SystemColors.ActiveCaptionText;
            LProveedor.Location = new Point(21, 369);
            LProveedor.Name = "LProveedor";
            LProveedor.Size = new Size(106, 25);
            LProveedor.TabIndex = 45;
            LProveedor.Text = "Proveedor:";
            // 
            // TBCantidad
            // 
            TBCantidad.Location = new Point(491, 175);
            TBCantidad.Name = "TBCantidad";
            TBCantidad.Size = new Size(107, 23);
            TBCantidad.TabIndex = 44;
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LPrecio.ForeColor = SystemColors.ActiveCaptionText;
            LPrecio.Location = new Point(376, 119);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(72, 25);
            LPrecio.TabIndex = 43;
            LPrecio.Text = "Precio:";
            // 
            // TBPrecio
            // 
            TBPrecio.Location = new Point(491, 119);
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Size = new Size(107, 23);
            TBPrecio.TabIndex = 42;
            TBPrecio.TextChanged += TBPrecio_TextChanged;
            // 
            // TBApellido
            // 
            TBApellido.Location = new Point(153, 121);
            TBApellido.Name = "TBApellido";
            TBApellido.Size = new Size(199, 23);
            TBApellido.TabIndex = 1;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(153, 175);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(199, 23);
            TBNombre.TabIndex = 38;
            // 
            // LRubro
            // 
            LRubro.AutoSize = true;
            LRubro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LRubro.ForeColor = SystemColors.ActiveCaptionText;
            LRubro.Location = new Point(21, 324);
            LRubro.Name = "LRubro";
            LRubro.Size = new Size(70, 25);
            LRubro.TabIndex = 37;
            LRubro.Text = "Rubro:";
            // 
            // LCandidad
            // 
            LCandidad.AutoSize = true;
            LCandidad.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCandidad.ForeColor = SystemColors.ActiveCaptionText;
            LCandidad.Location = new Point(376, 175);
            LCandidad.Name = "LCandidad";
            LCandidad.Size = new Size(94, 25);
            LCandidad.TabIndex = 36;
            LCandidad.Text = "Cantidad:";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombre.ForeColor = SystemColors.ActiveCaptionText;
            LNombre.Location = new Point(21, 173);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(84, 25);
            LNombre.TabIndex = 34;
            LNombre.Text = "Nombre:";
            // 
            // LIdProducto
            // 
            LIdProducto.AutoSize = true;
            LIdProducto.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LIdProducto.ForeColor = SystemColors.ActiveCaptionText;
            LIdProducto.Location = new Point(21, 121);
            LIdProducto.Name = "LIdProducto";
            LIdProducto.Size = new Size(126, 25);
            LIdProducto.TabIndex = 35;
            LIdProducto.Text = "Identificador:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(153, 147);
            label1.Name = "label1";
            label1.Size = new Size(156, 16);
            label1.TabIndex = 52;
            label1.Text = "Código numérico único del producto";
            // 
            // CBRubro
            // 
            CBRubro.DropDownStyle = ComboBoxStyle.DropDownList;
            CBRubro.FormattingEnabled = true;
            CBRubro.Items.AddRange(new object[] { "Almacén", "Bebés y niños", "Bebidas", "Higiene personal", "Hogar", "Limpieza", "Salud y belleza" });
            CBRubro.Location = new Point(153, 326);
            CBRubro.Name = "CBRubro";
            CBRubro.Size = new Size(199, 23);
            CBRubro.TabIndex = 53;
            // 
            // CBDisponible
            // 
            CBDisponible.DropDownStyle = ComboBoxStyle.DropDownList;
            CBDisponible.FormattingEnabled = true;
            CBDisponible.Items.AddRange(new object[] { "SI", "NO" });
            CBDisponible.Location = new Point(491, 228);
            CBDisponible.Name = "CBDisponible";
            CBDisponible.Size = new Size(107, 23);
            CBDisponible.TabIndex = 54;
            // 
            // LDisponible
            // 
            LDisponible.AutoSize = true;
            LDisponible.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LDisponible.ForeColor = SystemColors.ActiveCaptionText;
            LDisponible.Location = new Point(376, 228);
            LDisponible.Name = "LDisponible";
            LDisponible.Size = new Size(109, 25);
            LDisponible.TabIndex = 55;
            LDisponible.Text = "Disponible:";
            // 
            // LImagen
            // 
            LImagen.AutoSize = true;
            LImagen.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LImagen.ForeColor = SystemColors.ActiveCaptionText;
            LImagen.Location = new Point(376, 281);
            LImagen.Name = "LImagen";
            LImagen.Size = new Size(80, 25);
            LImagen.TabIndex = 56;
            LImagen.Text = "Imagen:";
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LDescripcion.ForeColor = SystemColors.ActiveCaptionText;
            LDescripcion.Location = new Point(21, 223);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(120, 25);
            LDescripcion.TabIndex = 58;
            LDescripcion.Text = "Descripción:";
            // 
            // TBDescripcion
            // 
            TBDescripcion.Location = new Point(153, 228);
            TBDescripcion.Multiline = true;
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Size = new Size(199, 86);
            TBDescripcion.TabIndex = 59;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(497, 281);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(106, 111);
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            // 
            // NewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 520);
            Controls.Add(pictureBox3);
            Controls.Add(TBDescripcion);
            Controls.Add(LDescripcion);
            Controls.Add(LImagen);
            Controls.Add(LDisponible);
            Controls.Add(CBDisponible);
            Controls.Add(CBRubro);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BCancelar);
            Controls.Add(LNuevoProducto);
            Controls.Add(BGuardar);
            Controls.Add(CBProveedor);
            Controls.Add(LProveedor);
            Controls.Add(TBCantidad);
            Controls.Add(LPrecio);
            Controls.Add(TBPrecio);
            Controls.Add(TBApellido);
            Controls.Add(TBNombre);
            Controls.Add(LRubro);
            Controls.Add(LCandidad);
            Controls.Add(LNombre);
            Controls.Add(LIdProducto);
            Name = "NewProduct";
            Text = "Nuevo producto";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox CBMostrarContrasenia;
        private Button BCancelar;
        private Label LNuevoProducto;
        private Button BGuardar;
        private ComboBox CBProveedor;
        private Label LProveedor;
        private TextBox TBCantidad;
        private Label LPrecio;
        private TextBox TBPrecio;
        private TextBox TBContrasenia;
        private TextBox TBApellido;
        private TextBox TBNombre;
        private Label LRubro;
        private Label LCandidad;
        private Label LNombre;
        private Label LIdProducto;
        private Label label1;
        private ComboBox CBRubro;
        private ComboBox CBDisponible;
        private Label LDisponible;
        private Label LImagen;
        private Label LDescripcion;
        private TextBox TBDescripcion;
        private PictureBox pictureBox3;
    }
}