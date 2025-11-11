namespace Proyecto_TallerII25_G56
{
    partial class NewRubro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRubro));
            LNuevoRubro = new Label();
            BGuardar = new Button();
            TBCodigo = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            BCancelar = new Button();
            TBNombre = new TextBox();
            LNombre = new Label();
            LCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LNuevoRubro
            // 
            LNuevoRubro.AutoSize = true;
            LNuevoRubro.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNuevoRubro.Location = new Point(99, 85);
            LNuevoRubro.Name = "LNuevoRubro";
            LNuevoRubro.Size = new Size(175, 33);
            LNuevoRubro.TabIndex = 76;
            LNuevoRubro.Text = "Nuevo rubro";
            // 
            // BGuardar
            // 
            BGuardar.BackColor = SystemColors.ActiveBorder;
            BGuardar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BGuardar.ForeColor = Color.DarkGreen;
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(228, 217);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(125, 35);
            BGuardar.TabIndex = 3;
            BGuardar.Text = "Guardar";
            BGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // TBCodigo
            // 
            TBCodigo.Location = new Point(169, 177);
            TBCodigo.Name = "TBCodigo";
            TBCodigo.Size = new Size(183, 23);
            TBCodigo.TabIndex = 2;
            TBCodigo.KeyPress += TBCodigo_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(140, 258);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 92);
            pictureBox2.TabIndex = 68;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(169, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 70);
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = SystemColors.ButtonShadow;
            BCancelar.CausesValidation = false;
            BCancelar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = Color.SaddleBrown;
            BCancelar.ImageAlign = ContentAlignment.TopLeft;
            BCancelar.Location = new Point(12, 217);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(136, 35);
            BCancelar.TabIndex = 4;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(169, 133);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(183, 23);
            TBNombre.TabIndex = 1;
            TBNombre.TextChanged += TBNombre_TextChanged;
            TBNombre.KeyPress += TBNombre_KeyPress;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombre.ForeColor = SystemColors.ActiveCaptionText;
            LNombre.Location = new Point(11, 131);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(84, 25);
            LNombre.TabIndex = 60;
            LNombre.Text = "Nombre:";
            // 
            // LCodigo
            // 
            LCodigo.AutoSize = true;
            LCodigo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCodigo.ForeColor = SystemColors.ActiveCaptionText;
            LCodigo.Location = new Point(11, 172);
            LCodigo.Name = "LCodigo";
            LCodigo.Size = new Size(79, 25);
            LCodigo.TabIndex = 61;
            LCodigo.Text = "Código:";
            // 
            // NewRubro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 359);
            Controls.Add(LNuevoRubro);
            Controls.Add(BGuardar);
            Controls.Add(TBCodigo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BCancelar);
            Controls.Add(TBNombre);
            Controls.Add(LNombre);
            Controls.Add(LCodigo);
            Name = "NewRubro";
            Text = "Nuevo rubro";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNuevoRubro;
        private Button BGuardar;
        private TextBox TBCodigo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button BCancelar;
        private TextBox TBNombre;
        private Label LNombre;
        private Label LCodigo;
    }
}