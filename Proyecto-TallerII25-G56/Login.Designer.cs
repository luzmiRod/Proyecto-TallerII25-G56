
namespace Proyecto_TallerII25_G56
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LLogin = new Label();
            TBCorreo = new TextBox();
            TBContrasenia = new TextBox();
            LContrasenia = new Label();
            LCorreo = new Label();
            pictureBox1 = new PictureBox();
            BCancelar = new Button();
            BLogin = new Button();
            pictureBox2 = new PictureBox();
            CBMostrarContrasenia = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // LLogin
            // 
            LLogin.AutoSize = true;
            LLogin.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LLogin.Location = new Point(108, 74);
            LLogin.Name = "LLogin";
            LLogin.Size = new Size(193, 33);
            LLogin.TabIndex = 34;
            LLogin.Text = "Iniciar sesión";
            // 
            // TBCorreo
            // 
            TBCorreo.Location = new Point(197, 135);
            TBCorreo.Name = "TBCorreo";
            TBCorreo.Size = new Size(183, 23);
            TBCorreo.TabIndex = 1;
            TBCorreo.TextChanged += TBCorreo_TextChanged;
            TBCorreo.Validating += TBCorreo_Validating;
            // 
            // TBContrasenia
            // 
            TBContrasenia.Location = new Point(197, 177);
            TBContrasenia.Name = "TBContrasenia";
            TBContrasenia.Size = new Size(183, 23);
            TBContrasenia.TabIndex = 2;
            TBContrasenia.UseSystemPasswordChar = true;
            TBContrasenia.TextChanged += TBContrasenia_TextChanged;
            // 
            // LContrasenia
            // 
            LContrasenia.AutoSize = true;
            LContrasenia.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LContrasenia.ForeColor = SystemColors.ActiveCaptionText;
            LContrasenia.Location = new Point(39, 177);
            LContrasenia.Name = "LContrasenia";
            LContrasenia.Size = new Size(116, 25);
            LContrasenia.TabIndex = 31;
            LContrasenia.Text = "Contraseña:";
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCorreo.ForeColor = SystemColors.ActiveCaptionText;
            LCorreo.Location = new Point(39, 130);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(76, 25);
            LCorreo.TabIndex = 30;
            LCorreo.Text = "Correo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_svgrepo_com__1_;
            pictureBox1.Location = new Point(161, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 75);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = SystemColors.ButtonShadow;
            BCancelar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = Color.SaddleBrown;
            BCancelar.ImageAlign = ContentAlignment.TopLeft;
            BCancelar.Location = new Point(39, 240);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(136, 31);
            BCancelar.TabIndex = 37;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // BLogin
            // 
            BLogin.BackColor = SystemColors.ActiveBorder;
            BLogin.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BLogin.ForeColor = Color.DarkGreen;
            BLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BLogin.Location = new Point(255, 240);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(125, 31);
            BLogin.TabIndex = 36;
            BLogin.Text = "Entrar";
            BLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLogin.UseVisualStyleBackColor = false;
            BLogin.Click += BLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(157, 314);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 92);
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // CBMostrarContrasenia
            // 
            CBMostrarContrasenia.AutoSize = true;
            CBMostrarContrasenia.Location = new Point(197, 206);
            CBMostrarContrasenia.Name = "CBMostrarContrasenia";
            CBMostrarContrasenia.Size = new Size(128, 19);
            CBMostrarContrasenia.TabIndex = 40;
            CBMostrarContrasenia.Text = "Mostrar contraseña";
            CBMostrarContrasenia.UseVisualStyleBackColor = true;
            CBMostrarContrasenia.CheckedChanged += CBMostrarContrasenia_CheckedChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(424, 450);
            Controls.Add(CBMostrarContrasenia);
            Controls.Add(pictureBox2);
            Controls.Add(BCancelar);
            Controls.Add(BLogin);
            Controls.Add(pictureBox1);
            Controls.Add(LLogin);
            Controls.Add(TBCorreo);
            Controls.Add(TBContrasenia);
            Controls.Add(LContrasenia);
            Controls.Add(LCorreo);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LLogin;
        private TextBox TBCorreo;
        private TextBox TBContrasenia;
        private Label LContrasenia;
        private Label LCorreo;
        private PictureBox pictureBox1;
        private Button BCancelar;
        private Button BLogin;
        private PictureBox pictureBox2;
        private CheckBox CBMostrarContrasenia;
        private ErrorProvider errorProvider1;
    }
}