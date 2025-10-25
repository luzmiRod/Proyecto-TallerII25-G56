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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            imageList1 = new ImageList(components);
            LFiltroUsuario = new Label();
            CBFiltroUsuario = new ComboBox();
            accion = new DataGridViewImageColumn();
            activo = new DataGridViewTextBoxColumn();
            tipo_usuario = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            id_usuario = new DataGridViewTextBoxColumn();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "editar.png");
            imageList1.Images.SetKeyName(1, "baja.png");
            imageList1.Images.SetKeyName(2, "alta.png");
            // 
            // LFiltroUsuario
            // 
            LFiltroUsuario.AutoSize = true;
            LFiltroUsuario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFiltroUsuario.Location = new Point(21, 70);
            LFiltroUsuario.Name = "LFiltroUsuario";
            LFiltroUsuario.Size = new Size(79, 18);
            LFiltroUsuario.TabIndex = 1;
            LFiltroUsuario.Text = "Filtrar por:";
            // 
            // CBFiltroUsuario
            // 
            CBFiltroUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFiltroUsuario.FormattingEnabled = true;
            CBFiltroUsuario.Items.AddRange(new object[] { "Todos", "Gerente", "Cajero", "Usuarios inactivos" });
            CBFiltroUsuario.Location = new Point(106, 70);
            CBFiltroUsuario.Name = "CBFiltroUsuario";
            CBFiltroUsuario.Size = new Size(121, 23);
            CBFiltroUsuario.TabIndex = 2;
            CBFiltroUsuario.SelectedIndexChanged += CBFiltroUsuario_SelectedIndexChanged;
            // 
            // accion
            // 
            accion.HeaderText = "Acción";
            accion.Name = "accion";
            accion.Width = 68;
            // 
            // activo
            // 
            activo.HeaderText = "Estado";
            activo.Name = "activo";
            activo.Width = 88;
            // 
            // tipo_usuario
            // 
            tipo_usuario.HeaderText = "Tipo de usuario";
            tipo_usuario.Name = "tipo_usuario";
            tipo_usuario.Width = 140;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            correo.Width = 87;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.Width = 96;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.Width = 95;
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.Width = 62;
            // 
            // id_usuario
            // 
            id_usuario.HeaderText = "id_usuario";
            id_usuario.Name = "id_usuario";
            id_usuario.Visible = false;
            id_usuario.Width = 115;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { id_usuario, dni, nombre, apellido, correo, tipo_usuario, activo, accion });
            dgvUsuarios.Location = new Point(21, 107);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvUsuarios.RowTemplate.Height = 10;
            dgvUsuarios.ShowEditingIcon = false;
            dgvUsuarios.Size = new Size(664, 176);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellFormatting += dgvUsuarios_CellFormatting;
            dgvUsuarios.CellMouseClick += dgvUsuarios_CellMouseClick;
            dgvUsuarios.CellPainting += dgvUsuarios_CellPainting;
            // 
            // UsersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(CBFiltroUsuario);
            Controls.Add(LFiltroUsuario);
            Controls.Add(dgvUsuarios);
            Name = "UsersList";
            Text = "Lista de usuarios";
            Load += UsersList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private Label LFiltroUsuario;
        private ComboBox CBFiltroUsuario;
        private DataGridViewImageColumn accion;
        private DataGridViewTextBoxColumn activo;
        private DataGridViewTextBoxColumn tipo_usuario;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridView dgvUsuarios;
    }
}