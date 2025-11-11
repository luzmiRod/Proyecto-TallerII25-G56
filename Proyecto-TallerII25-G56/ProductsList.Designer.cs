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
            CBFiltroRubro = new ComboBox();
            LFiltroRubro = new Label();
            CBFiltroStock = new ComboBox();
            LFiltroStock = new Label();
            dgvProductos = new DataGridView();
            cod_prod = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            rubro = new DataGridViewTextBoxColumn();
            proveedor = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            BAgregarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // CBFiltroRubro
            // 
            CBFiltroRubro.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFiltroRubro.FormattingEnabled = true;
            CBFiltroRubro.Location = new Point(137, 68);
            CBFiltroRubro.Name = "CBFiltroRubro";
            CBFiltroRubro.Size = new Size(121, 23);
            CBFiltroRubro.TabIndex = 5;
            // 
            // LFiltroRubro
            // 
            LFiltroRubro.AutoSize = true;
            LFiltroRubro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFiltroRubro.Location = new Point(12, 68);
            LFiltroRubro.Name = "LFiltroRubro";
            LFiltroRubro.Size = new Size(119, 18);
            LFiltroRubro.TabIndex = 4;
            LFiltroRubro.Text = "Filtrar por rubro:";
            // 
            // CBFiltroStock
            // 
            CBFiltroStock.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFiltroStock.FormattingEnabled = true;
            CBFiltroStock.Location = new Point(411, 68);
            CBFiltroStock.Name = "CBFiltroStock";
            CBFiltroStock.Size = new Size(121, 23);
            CBFiltroStock.TabIndex = 7;
            // 
            // LFiltroStock
            // 
            LFiltroStock.AutoSize = true;
            LFiltroStock.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFiltroStock.Location = new Point(276, 68);
            LFiltroStock.Name = "LFiltroStock";
            LFiltroStock.Size = new Size(120, 18);
            LFiltroStock.TabIndex = 6;
            LFiltroStock.Text = "Filtrar por stock:";
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
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { cod_prod, nombre, descripcion, rubro, proveedor, cantidad, precio });
            dgvProductos.Location = new Point(12, 148);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvProductos.RowTemplate.Height = 10;
            dgvProductos.ShowEditingIcon = false;
            dgvProductos.Size = new Size(897, 176);
            dgvProductos.TabIndex = 8;
            // 
            // cod_prod
            // 
            cod_prod.HeaderText = "Cód producto";
            cod_prod.Name = "cod_prod";
            cod_prod.Width = 128;
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
            // rubro
            // 
            rubro.HeaderText = "Rubro";
            rubro.Name = "rubro";
            rubro.Width = 82;
            // 
            // proveedor
            // 
            proveedor.HeaderText = "Proveedor";
            proveedor.Name = "proveedor";
            proveedor.Width = 114;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad disponible";
            cantidad.Name = "cantidad";
            cantidad.Width = 170;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            precio.Width = 83;
            // 
            // BAgregarProducto
            // 
            BAgregarProducto.BackColor = SystemColors.ActiveBorder;
            BAgregarProducto.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregarProducto.ForeColor = Color.DarkGreen;
            BAgregarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregarProducto.Location = new Point(567, 68);
            BAgregarProducto.Name = "BAgregarProducto";
            BAgregarProducto.Size = new Size(206, 24);
            BAgregarProducto.TabIndex = 10;
            BAgregarProducto.Text = "Agregar nuevo producto";
            BAgregarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregarProducto.UseVisualStyleBackColor = false;
            BAgregarProducto.Click += BAgregarProducto_Click;
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 450);
            Controls.Add(BAgregarProducto);
            Controls.Add(dgvProductos);
            Controls.Add(CBFiltroStock);
            Controls.Add(LFiltroStock);
            Controls.Add(CBFiltroRubro);
            Controls.Add(LFiltroRubro);
            Name = "ProductsList";
            Text = "Lista de productos";
            Load += ProductsList_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBFiltroRubro;
        private Label LFiltroRubro;
        private ComboBox CBFiltroStock;
        private Label LFiltroStock;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn cod_prod;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn rubro;
        private DataGridViewTextBoxColumn proveedor;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private Button BAgregarProducto;
    }
}