namespace Proyecto_TallerII25_G56
{
    partial class HistorialVentas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialVentas));
            CBFiltroUsuario = new ComboBox();
            LFiltroMes = new Label();
            dgvHistorialVentas = new DataGridView();
            id_venta = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            cajero = new DataGridViewTextBoxColumn();
            monto_total = new DataGridViewTextBoxColumn();
            detalle_venta = new DataGridViewImageColumn();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).BeginInit();
            SuspendLayout();
            // 
            // CBFiltroUsuario
            // 
            CBFiltroUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFiltroUsuario.FormattingEnabled = true;
            CBFiltroUsuario.Items.AddRange(new object[] { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" });
            CBFiltroUsuario.Location = new Point(170, 52);
            CBFiltroUsuario.Name = "CBFiltroUsuario";
            CBFiltroUsuario.Size = new Size(121, 23);
            CBFiltroUsuario.TabIndex = 8;
            // 
            // LFiltroMes
            // 
            LFiltroMes.AutoSize = true;
            LFiltroMes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFiltroMes.Location = new Point(45, 52);
            LFiltroMes.Name = "LFiltroMes";
            LFiltroMes.Size = new Size(113, 18);
            LFiltroMes.TabIndex = 7;
            LFiltroMes.Text = "Filtrar por mes:";
            // 
            // dgvHistorialVentas
            // 
            dgvHistorialVentas.AllowUserToAddRows = false;
            dgvHistorialVentas.AllowUserToDeleteRows = false;
            dgvHistorialVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHistorialVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorialVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorialVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialVentas.Columns.AddRange(new DataGridViewColumn[] { id_venta, fecha, cajero, monto_total, detalle_venta });
            dgvHistorialVentas.Location = new Point(45, 89);
            dgvHistorialVentas.Name = "dgvHistorialVentas";
            dgvHistorialVentas.ReadOnly = true;
            dgvHistorialVentas.RowHeadersVisible = false;
            dgvHistorialVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvHistorialVentas.RowTemplate.Height = 10;
            dgvHistorialVentas.ShowEditingIcon = false;
            dgvHistorialVentas.Size = new Size(577, 176);
            dgvHistorialVentas.TabIndex = 6;
            // 
            // id_venta
            // 
            id_venta.HeaderText = "Número de venta";
            id_venta.Name = "id_venta";
            id_venta.ReadOnly = true;
            id_venta.Width = 112;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Width = 81;
            // 
            // cajero
            // 
            cajero.HeaderText = "Cajero";
            cajero.Name = "cajero";
            cajero.ReadOnly = true;
            cajero.Width = 84;
            // 
            // monto_total
            // 
            monto_total.HeaderText = "Importe";
            monto_total.Name = "monto_total";
            monto_total.ReadOnly = true;
            monto_total.Width = 92;
            // 
            // detalle_venta
            // 
            detalle_venta.HeaderText = "Comprobante";
            detalle_venta.Name = "detalle_venta";
            detalle_venta.ReadOnly = true;
            detalle_venta.Resizable = DataGridViewTriState.True;
            detalle_venta.SortMode = DataGridViewColumnSortMode.Automatic;
            detalle_venta.Width = 139;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "finance-book-economy-svgrepo-com.png");
            // 
            // HistorialVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CBFiltroUsuario);
            Controls.Add(LFiltroMes);
            Controls.Add(dgvHistorialVentas);
            Name = "HistorialVentas";
            Text = "Historial de ventas";
            Load += HistorialVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBFiltroUsuario;
        private Label LFiltroMes;
        private DataGridView dgvHistorialVentas;
        private DataGridViewTextBoxColumn id_venta;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn cajero;
        private DataGridViewTextBoxColumn monto_total;
        private DataGridViewImageColumn detalle_venta;
        private ImageList imageList1;
    }
}