namespace Proyecto_TallerII25_G56
{
    partial class UsersList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvUsuarios = new DataGridView();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            tipo_usuario = new DataGridViewTextBoxColumn();
            activo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { dni, nombre, apellido, correo, tipo_usuario, activo });
            dgvUsuarios.Location = new Point(21, 107);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(735, 210);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellFormatting += dgvUsuarios_CellFormatting;
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            // 
            // tipo_usuario
            // 
            tipo_usuario.HeaderText = "Tipo de usuario";
            tipo_usuario.Name = "tipo_usuario";
            // 
            // activo
            // 
            activo.HeaderText = "Estado";
            activo.Name = "activo";
            // 
            // UsersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2e24d0fabcfbb1ad0347371cb8c38327;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUsuarios);
            Name = "UsersList";
            Text = "Lista de usuarios";
            Load += UsersList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn tipo_usuario;
        private DataGridViewTextBoxColumn activo;
    }
}