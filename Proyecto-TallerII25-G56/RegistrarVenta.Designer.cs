namespace Proyecto_TallerII25_G56
{
    partial class RegistrarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVenta));
            LRegistrarVenta = new Label();
            BGuardar = new Button();
            TBCodigo = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            BCancelar = new Button();
            TBProdAgregados = new TextBox();
            TBCantidad = new TextBox();
            LProductosAgregados = new Label();
            LCantidad = new Label();
            LCodProducto = new Label();
            TBSubtotal = new TextBox();
            LSubtotal = new Label();
            BAgregarProducto = new Button();
            TBTotal = new TextBox();
            LTotal = new Label();
            BEliminarProducto = new Button();
            LCuitCliente = new Label();
            TBCuitCliente = new TextBox();
            PBButtonFindCliente = new PictureBox();
            TBNombreCliente = new TextBox();
            LNoClienteAun = new Label();
            BRegistrarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBButtonFindCliente).BeginInit();
            SuspendLayout();
            // 
            // LRegistrarVenta
            // 
            LRegistrarVenta.AutoSize = true;
            LRegistrarVenta.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LRegistrarVenta.Location = new Point(252, 44);
            LRegistrarVenta.Name = "LRegistrarVenta";
            LRegistrarVenta.Size = new Size(305, 33);
            LRegistrarVenta.TabIndex = 87;
            LRegistrarVenta.Text = "Registrar nueva venta";
            // 
            // BGuardar
            // 
            BGuardar.BackColor = SystemColors.ActiveBorder;
            BGuardar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BGuardar.ForeColor = Color.DarkGreen;
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(541, 429);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(125, 35);
            BGuardar.TabIndex = 5;
            BGuardar.Text = "Guardar";
            BGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // TBCodigo
            // 
            TBCodigo.Location = new Point(180, 173);
            TBCodigo.Name = "TBCodigo";
            TBCodigo.Size = new Size(183, 23);
            TBCodigo.TabIndex = 2;
            TBCodigo.KeyPress += TBCodigo_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(301, 372);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 92);
            pictureBox2.TabIndex = 84;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(180, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 70);
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = SystemColors.ButtonShadow;
            BCancelar.CausesValidation = false;
            BCancelar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = Color.SaddleBrown;
            BCancelar.ImageAlign = ContentAlignment.TopLeft;
            BCancelar.Location = new Point(12, 429);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(136, 35);
            BCancelar.TabIndex = 6;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // TBProdAgregados
            // 
            TBProdAgregados.Enabled = false;
            TBProdAgregados.Location = new Point(180, 225);
            TBProdAgregados.Multiline = true;
            TBProdAgregados.Name = "TBProdAgregados";
            TBProdAgregados.Size = new Size(183, 108);
            TBProdAgregados.TabIndex = 81;
            // 
            // TBCantidad
            // 
            TBCantidad.Location = new Point(505, 173);
            TBCantidad.Name = "TBCantidad";
            TBCantidad.Size = new Size(56, 23);
            TBCantidad.TabIndex = 3;
            TBCantidad.KeyPress += TBNombre_KeyPress;
            // 
            // LProductosAgregados
            // 
            LProductosAgregados.AutoSize = true;
            LProductosAgregados.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LProductosAgregados.ForeColor = SystemColors.ActiveCaptionText;
            LProductosAgregados.Location = new Point(12, 220);
            LProductosAgregados.Name = "LProductosAgregados";
            LProductosAgregados.Size = new Size(109, 50);
            LProductosAgregados.TabIndex = 79;
            LProductosAgregados.Text = "Productos\r\nagregados:";
            // 
            // LCantidad
            // 
            LCantidad.AutoSize = true;
            LCantidad.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCantidad.ForeColor = SystemColors.ActiveCaptionText;
            LCantidad.Location = new Point(405, 173);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(94, 25);
            LCantidad.TabIndex = 77;
            LCantidad.Text = "Cantidad:";
            // 
            // LCodProducto
            // 
            LCodProducto.AutoSize = true;
            LCodProducto.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCodProducto.ForeColor = SystemColors.ActiveCaptionText;
            LCodProducto.Location = new Point(12, 173);
            LCodProducto.Name = "LCodProducto";
            LCodProducto.Size = new Size(162, 25);
            LCodProducto.TabIndex = 78;
            LCodProducto.Text = "Código producto:";
            // 
            // TBSubtotal
            // 
            TBSubtotal.Enabled = false;
            TBSubtotal.Location = new Point(505, 220);
            TBSubtotal.Name = "TBSubtotal";
            TBSubtotal.Size = new Size(56, 23);
            TBSubtotal.TabIndex = 89;
            // 
            // LSubtotal
            // 
            LSubtotal.AutoSize = true;
            LSubtotal.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LSubtotal.ForeColor = SystemColors.ActiveCaptionText;
            LSubtotal.Location = new Point(405, 220);
            LSubtotal.Name = "LSubtotal";
            LSubtotal.Size = new Size(89, 25);
            LSubtotal.TabIndex = 88;
            LSubtotal.Text = "Subtotal:";
            // 
            // BAgregarProducto
            // 
            BAgregarProducto.BackColor = Color.FromArgb(192, 255, 192);
            BAgregarProducto.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregarProducto.ForeColor = Color.DarkGreen;
            BAgregarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregarProducto.Location = new Point(577, 173);
            BAgregarProducto.Name = "BAgregarProducto";
            BAgregarProducto.Size = new Size(89, 25);
            BAgregarProducto.TabIndex = 4;
            BAgregarProducto.Text = "+ Agregar";
            BAgregarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregarProducto.UseVisualStyleBackColor = false;
            BAgregarProducto.Click += BAgregarProducto_Click;
            // 
            // TBTotal
            // 
            TBTotal.Enabled = false;
            TBTotal.Location = new Point(505, 308);
            TBTotal.Name = "TBTotal";
            TBTotal.Size = new Size(56, 23);
            TBTotal.TabIndex = 92;
            // 
            // LTotal
            // 
            LTotal.AutoSize = true;
            LTotal.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTotal.ForeColor = SystemColors.ActiveCaptionText;
            LTotal.Location = new Point(405, 308);
            LTotal.Name = "LTotal";
            LTotal.Size = new Size(61, 25);
            LTotal.TabIndex = 91;
            LTotal.Text = "Total:";
            // 
            // BEliminarProducto
            // 
            BEliminarProducto.BackColor = SystemColors.Control;
            BEliminarProducto.CausesValidation = false;
            BEliminarProducto.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BEliminarProducto.ForeColor = Color.Firebrick;
            BEliminarProducto.ImageAlign = ContentAlignment.TopLeft;
            BEliminarProducto.Location = new Point(12, 346);
            BEliminarProducto.Name = "BEliminarProducto";
            BEliminarProducto.Size = new Size(162, 25);
            BEliminarProducto.TabIndex = 93;
            BEliminarProducto.Text = "x Eliminar producto";
            BEliminarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarProducto.UseVisualStyleBackColor = false;
            BEliminarProducto.Click += BEliminarProducto_Click;
            // 
            // LCuitCliente
            // 
            LCuitCliente.AutoSize = true;
            LCuitCliente.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCuitCliente.ForeColor = SystemColors.ActiveCaptionText;
            LCuitCliente.Location = new Point(12, 114);
            LCuitCliente.Name = "LCuitCliente";
            LCuitCliente.Size = new Size(165, 25);
            LCuitCliente.TabIndex = 94;
            LCuitCliente.Text = "CUIT/CUIL cliente:";
            // 
            // TBCuitCliente
            // 
            TBCuitCliente.Location = new Point(180, 116);
            TBCuitCliente.Name = "TBCuitCliente";
            TBCuitCliente.Size = new Size(183, 23);
            TBCuitCliente.TabIndex = 1;
            // 
            // PBButtonFindCliente
            // 
            PBButtonFindCliente.Image = (Image)resources.GetObject("PBButtonFindCliente.Image");
            PBButtonFindCliente.InitialImage = (Image)resources.GetObject("PBButtonFindCliente.InitialImage");
            PBButtonFindCliente.Location = new Point(369, 116);
            PBButtonFindCliente.Name = "PBButtonFindCliente";
            PBButtonFindCliente.Size = new Size(22, 23);
            PBButtonFindCliente.TabIndex = 96;
            PBButtonFindCliente.TabStop = false;
            PBButtonFindCliente.Click += PBButtonFindCliente_Click;
            // 
            // TBNombreCliente
            // 
            TBNombreCliente.Enabled = false;
            TBNombreCliente.Location = new Point(405, 116);
            TBNombreCliente.Name = "TBNombreCliente";
            TBNombreCliente.Size = new Size(183, 23);
            TBNombreCliente.TabIndex = 97;
            // 
            // LNoClienteAun
            // 
            LNoClienteAun.AutoSize = true;
            LNoClienteAun.Font = new Font("Arial", 8.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            LNoClienteAun.ForeColor = Color.Firebrick;
            LNoClienteAun.Location = new Point(180, 146);
            LNoClienteAun.Name = "LNoClienteAun";
            LNoClienteAun.Size = new Size(105, 14);
            LNoClienteAun.TabIndex = 98;
            LNoClienteAun.Text = "¿Aún no es cliente?";
            // 
            // BRegistrarCliente
            // 
            BRegistrarCliente.BackColor = Color.FromArgb(192, 255, 192);
            BRegistrarCliente.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BRegistrarCliente.ForeColor = Color.DarkGreen;
            BRegistrarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            BRegistrarCliente.Location = new Point(291, 142);
            BRegistrarCliente.Name = "BRegistrarCliente";
            BRegistrarCliente.Size = new Size(71, 23);
            BRegistrarCliente.TabIndex = 99;
            BRegistrarCliente.Text = "+ Registrar";
            BRegistrarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            BRegistrarCliente.UseVisualStyleBackColor = false;
            BRegistrarCliente.Click += BRegistrarCliente_Click;
            // 
            // RegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 482);
            Controls.Add(BRegistrarCliente);
            Controls.Add(LNoClienteAun);
            Controls.Add(TBNombreCliente);
            Controls.Add(PBButtonFindCliente);
            Controls.Add(TBCuitCliente);
            Controls.Add(LCuitCliente);
            Controls.Add(BEliminarProducto);
            Controls.Add(TBTotal);
            Controls.Add(LTotal);
            Controls.Add(BAgregarProducto);
            Controls.Add(TBSubtotal);
            Controls.Add(LSubtotal);
            Controls.Add(LRegistrarVenta);
            Controls.Add(BGuardar);
            Controls.Add(TBCodigo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BCancelar);
            Controls.Add(TBProdAgregados);
            Controls.Add(TBCantidad);
            Controls.Add(LProductosAgregados);
            Controls.Add(LCantidad);
            Controls.Add(LCodProducto);
            Name = "RegistrarVenta";
            Text = "Registrar venta";
            Load += RegistrarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBButtonFindCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LRegistrarVenta;
        private Button BGuardar;
        private TextBox TBCodigo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button BCancelar;
        private TextBox TBProdAgregados;
        private TextBox TBCantidad;
        private Label LProductosAgregados;
        private Label LCantidad;
        private Label LCodProducto;
        private TextBox TBSubtotal;
        private Label LSubtotal;
        private Button BAgregarProducto;
        private TextBox TBTotal;
        private Label LTotal;
        private Button BEliminarProducto;
        private Label LCuitCliente;
        private TextBox TBCuitCliente;
        private PictureBox PBButtonFindCliente;
        private TextBox TBNombreCliente;
        private Label LNoClienteAun;
        private Button BRegistrarCliente;
    }
}