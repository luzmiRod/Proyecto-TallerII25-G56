namespace Proyecto_TallerII25_G56
{
    partial class ProductsList
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
            CBFiltroUsuario = new ComboBox();
            LFiltroRubro = new Label();
            comboBox1 = new ComboBox();
            LFiltroProveedor = new Label();
            dgvProductos = new DataGridView();
            id_producto = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            cod_rubro = new DataGridViewTextBoxColumn();
            cod_proveedor = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // CBFiltroUsuario
            // 
            CBFiltroUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFiltroUsuario.FormattingEnabled = true;
            CBFiltroUsuario.Items.AddRange(new object[] { "Almacén", "Bebés y niños", "Bebidas", "Higiene personal", "Hogar", "Limpieza", "Salud y belleza" });
            CBFiltroUsuario.Location = new Point(193, 119);
            CBFiltroUsuario.Name = "CBFiltroUsuario";
            CBFiltroUsuario.Size = new Size(121, 23);
            CBFiltroUsuario.TabIndex = 5;
            // 
            // LFiltroRubro
            // 
            LFiltroRubro.AutoSize = true;
            LFiltroRubro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFiltroRubro.Location = new Point(68, 119);
            LFiltroRubro.Name = "LFiltroRubro";
            LFiltroRubro.Size = new Size(119, 18);
            LFiltroRubro.TabIndex = 4;
            LFiltroRubro.Text = "Filtrar por rubro:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Jufec S.A.", "Maxicuera", "Distribuidora Pack", "ChipiCoorp", "Maaths Dist S.R.L", "Calisa Ctes" });
            comboBox1.Location = new Point(492, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // LFiltroProveedor
            // 
            LFiltroProveedor.AutoSize = true;
            LFiltroProveedor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFiltroProveedor.Location = new Point(332, 119);
            LFiltroProveedor.Name = "LFiltroProveedor";
            LFiltroProveedor.Size = new Size(154, 18);
            LFiltroProveedor.TabIndex = 6;
            LFiltroProveedor.Text = "Filtrar por proveedor:";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { id_producto, nombre, descripcion, cod_rubro, cod_proveedor, precio });
            dgvProductos.Location = new Point(68, 162);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvProductos.RowTemplate.Height = 10;
            dgvProductos.ShowEditingIcon = false;
            dgvProductos.Size = new Size(691, 176);
            dgvProductos.TabIndex = 8;
            // 
            // id_producto
            // 
            id_producto.HeaderText = "Cód producto";
            id_producto.Name = "id_producto";
            id_producto.Width = 128;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.Width = 95;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripción";
            descripcion.Name = "descripcion";
            descripcion.Width = 126;
            // 
            // cod_rubro
            // 
            cod_rubro.HeaderText = "Rubro";
            cod_rubro.Name = "cod_rubro";
            cod_rubro.Width = 82;
            // 
            // cod_proveedor
            // 
            cod_proveedor.HeaderText = "Proveedor";
            cod_proveedor.Name = "cod_proveedor";
            cod_proveedor.Width = 114;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            precio.Width = 83;
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 450);
            Controls.Add(dgvProductos);
            Controls.Add(comboBox1);
            Controls.Add(LFiltroProveedor);
            Controls.Add(CBFiltroUsuario);
            Controls.Add(LFiltroRubro);
            Name = "ProductsList";
            Text = "Lista de productos";
            Load += ProductsList_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBFiltroUsuario;
        private Label LFiltroRubro;
        private ComboBox comboBox1;
        private Label LFiltroProveedor;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn cod_rubro;
        private DataGridViewTextBoxColumn cod_proveedor;
        private DataGridViewTextBoxColumn precio;
    }
}