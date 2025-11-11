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
            CBFiltroCajero = new ComboBox();
            LFiltroCajero = new Label();
            dgvHistorialVentas = new DataGridView();
            id_venta = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            cajero = new DataGridViewTextBoxColumn();
            monto_total = new DataGridViewTextBoxColumn();
            btnDescargar = new DataGridViewButtonColumn();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).BeginInit();
            SuspendLayout();
            // 
            // CBFiltroCajero
            // 
            CBFiltroCajero.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFiltroCajero.FormattingEnabled = true;
            CBFiltroCajero.Location = new Point(177, 52);
            CBFiltroCajero.Name = "CBFiltroCajero";
            CBFiltroCajero.Size = new Size(121, 23);
            CBFiltroCajero.TabIndex = 8;
            CBFiltroCajero.SelectedIndexChanged += CBFiltroCajero_SelectedIndexChanged;
            // 
            // LFiltroCajero
            // 
            LFiltroCajero.AutoSize = true;
            LFiltroCajero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFiltroCajero.Location = new Point(45, 52);
            LFiltroCajero.Name = "LFiltroCajero";
            LFiltroCajero.Size = new Size(126, 18);
            LFiltroCajero.TabIndex = 7;
            LFiltroCajero.Text = "Filtrar por cajero:";
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
            dgvHistorialVentas.Columns.AddRange(new DataGridViewColumn[] { id_venta, fecha, cajero, monto_total, btnDescargar });
            dgvHistorialVentas.Location = new Point(45, 89);
            dgvHistorialVentas.Name = "dgvHistorialVentas";
            dgvHistorialVentas.ReadOnly = true;
            dgvHistorialVentas.RowHeadersVisible = false;
            dgvHistorialVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvHistorialVentas.RowTemplate.Height = 10;
            dgvHistorialVentas.ShowEditingIcon = false;
            dgvHistorialVentas.Size = new Size(577, 176);
            dgvHistorialVentas.TabIndex = 6;
            dgvHistorialVentas.CellContentClick += dgvHistorialVentas_CellContentClick;
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
            // btnDescargar
            // 
            btnDescargar.HeaderText = "Comprobante";
            btnDescargar.Name = "btnDescargar";
            btnDescargar.ReadOnly = true;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseColumnTextForButtonValue = true;
            btnDescargar.Width = 120;
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
            Controls.Add(CBFiltroCajero);
            Controls.Add(LFiltroCajero);
            Controls.Add(dgvHistorialVentas);
            Name = "HistorialVentas";
            Text = "Historial de ventas";
            Load += HistorialVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBFiltroCajero;
        private Label LFiltroCajero;
        private DataGridView dgvHistorialVentas;
        private ImageList imageList1;
        private DataGridViewTextBoxColumn id_venta;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn cajero;
        private DataGridViewTextBoxColumn monto_total;
        private DataGridViewButtonColumn btnDescargar;
    }
}