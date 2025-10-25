namespace Proyecto_TallerII25_G56
{
    partial class ProveedoresList
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CBFiltroUsuario = new ComboBox();
            LFiltroRubro = new Label();
            dgvProveedores = new DataGridView();
            cuit_cuil = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            domicilio = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            rubro = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // CBFiltroUsuario
            // 
            CBFiltroUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFiltroUsuario.FormattingEnabled = true;
            CBFiltroUsuario.Items.AddRange(new object[] { "Almacén", "Bebés y niños", "Bebidas", "Higiene personal", "Hogar", "Limpieza", "Salud y belleza" });
            CBFiltroUsuario.Location = new Point(164, 56);
            CBFiltroUsuario.Name = "CBFiltroUsuario";
            CBFiltroUsuario.Size = new Size(121, 23);
            CBFiltroUsuario.TabIndex = 5;
            // 
            // LFiltroRubro
            // 
            LFiltroRubro.AutoSize = true;
            LFiltroRubro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFiltroRubro.Location = new Point(39, 56);
            LFiltroRubro.Name = "LFiltroRubro";
            LFiltroRubro.Size = new Size(119, 18);
            LFiltroRubro.TabIndex = 4;
            LFiltroRubro.Text = "Filtrar por rubro:";
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { cuit_cuil, nombre, domicilio, telefono, correo, rubro });
            dgvProveedores.Location = new Point(39, 93);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvProveedores.RowTemplate.Height = 10;
            dgvProveedores.ShowEditingIcon = false;
            dgvProveedores.Size = new Size(702, 176);
            dgvProveedores.TabIndex = 3;
            // 
            // cuit_cuil
            // 
            cuit_cuil.HeaderText = "CUIT/CUIL";
            cuit_cuil.Name = "cuit_cuil";
            cuit_cuil.ReadOnly = true;
            cuit_cuil.Width = 114;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 95;
            // 
            // domicilio
            // 
            domicilio.HeaderText = "Domicilio";
            domicilio.Name = "domicilio";
            domicilio.ReadOnly = true;
            domicilio.Width = 105;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            correo.ReadOnly = true;
            correo.Width = 87;
            // 
            // rubro
            // 
            rubro.HeaderText = "Rubro";
            rubro.Name = "rubro";
            rubro.ReadOnly = true;
            rubro.Width = 82;
            // 
            // ProveedoresList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CBFiltroUsuario);
            Controls.Add(LFiltroRubro);
            Controls.Add(dgvProveedores);
            Name = "ProveedoresList";
            Text = "Lista de proveedores";
            Load += ProveedoresList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBFiltroUsuario;
        private Label LFiltroRubro;
        private DataGridView dgvProveedores;
        private DataGridViewTextBoxColumn cuit_cuil;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn domicilio;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn rubro;
    }
}