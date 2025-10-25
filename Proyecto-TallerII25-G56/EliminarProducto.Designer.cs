namespace Proyecto_TallerII25_G56
{
    partial class EliminarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarProducto));
            pictureBox1 = new PictureBox();
            LEliminarProducto = new Label();
            BAgregarProducto = new Button();
            TBCodigo = new TextBox();
            TBNombre = new TextBox();
            LCantidad = new Label();
            LCodProducto = new Label();
            BCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 42);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LEliminarProducto
            // 
            LEliminarProducto.AutoSize = true;
            LEliminarProducto.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LEliminarProducto.Location = new Point(183, 21);
            LEliminarProducto.Name = "LEliminarProducto";
            LEliminarProducto.Size = new Size(145, 23);
            LEliminarProducto.TabIndex = 1;
            LEliminarProducto.Text = "Eliminar producto";
            // 
            // BAgregarProducto
            // 
            BAgregarProducto.BackColor = SystemColors.Control;
            BAgregarProducto.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregarProducto.ForeColor = Color.Firebrick;
            BAgregarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregarProducto.Location = new Point(352, 105);
            BAgregarProducto.Name = "BAgregarProducto";
            BAgregarProducto.Size = new Size(89, 25);
            BAgregarProducto.TabIndex = 95;
            BAgregarProducto.Text = "Eliminar";
            BAgregarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // TBCodigo
            // 
            TBCodigo.Font = new Font("Segoe UI", 5.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBCodigo.Location = new Point(120, 72);
            TBCodigo.Name = "TBCodigo";
            TBCodigo.Size = new Size(183, 17);
            TBCodigo.TabIndex = 91;
            // 
            // TBNombre
            // 
            TBNombre.Font = new Font("Segoe UI", 5.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBNombre.Location = new Point(383, 72);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(56, 17);
            TBNombre.TabIndex = 94;
            // 
            // LCantidad
            // 
            LCantidad.AutoSize = true;
            LCantidad.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCantidad.ForeColor = SystemColors.ActiveCaptionText;
            LCantidad.Location = new Point(318, 70);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(59, 16);
            LCantidad.TabIndex = 92;
            LCantidad.Text = "Cantidad:";
            // 
            // LCodProducto
            // 
            LCodProducto.AutoSize = true;
            LCodProducto.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCodProducto.ForeColor = SystemColors.ActiveCaptionText;
            LCodProducto.Location = new Point(12, 72);
            LCodProducto.Name = "LCodProducto";
            LCodProducto.Size = new Size(102, 16);
            LCodProducto.TabIndex = 93;
            LCodProducto.Text = "Código producto:";
            // 
            // BCancelar
            // 
            BCancelar.BackColor = SystemColors.Control;
            BCancelar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = Color.FromArgb(128, 64, 0);
            BCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BCancelar.Location = new Point(257, 105);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(89, 25);
            BCancelar.TabIndex = 96;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // EliminarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 143);
            Controls.Add(BCancelar);
            Controls.Add(BAgregarProducto);
            Controls.Add(TBCodigo);
            Controls.Add(TBNombre);
            Controls.Add(LCantidad);
            Controls.Add(LCodProducto);
            Controls.Add(LEliminarProducto);
            Controls.Add(pictureBox1);
            Name = "EliminarProducto";
            Text = "Eliminar producto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LEliminarProducto;
        private Button BAgregarProducto;
        private TextBox TBCodigo;
        private TextBox TBNombre;
        private Label LCantidad;
        private Label LCodProducto;
        private Button BCancelar;
    }
}