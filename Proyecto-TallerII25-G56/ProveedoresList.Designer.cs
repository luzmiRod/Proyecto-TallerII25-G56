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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            CBFiltroRubro = new ComboBox();
            LFiltroRubro = new Label();
            dgvProveedores = new DataGridView();
            cuit = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            rubro = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // CBFiltroRubro
            // 
            CBFiltroRubro.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFiltroRubro.FormattingEnabled = true;
            CBFiltroRubro.Location = new Point(164, 56);
            CBFiltroRubro.Name = "CBFiltroRubro";
            CBFiltroRubro.Size = new Size(121, 23);
            CBFiltroRubro.TabIndex = 5;
            CBFiltroRubro.SelectedIndexChanged += CBFiltroRubro_SelectedIndexChanged_1;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { cuit, nombre, direccion, telefono, email, rubro });
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
            // cuit
            // 
            cuit.HeaderText = "CUIT/CUIL";
            cuit.Name = "cuit";
            cuit.ReadOnly = true;
            cuit.Width = 114;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 95;
            // 
            // direccion
            // 
            direccion.HeaderText = "Domicilio";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            direccion.Width = 105;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "Correo";
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 87;
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
            Controls.Add(CBFiltroRubro);
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

        private ComboBox CBFiltroRubro;
        private Label LFiltroRubro;
        private DataGridView dgvProveedores;
        private DataGridViewTextBoxColumn cuit;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn rubro;
    }
}