namespace SBX
{
    partial class frm_Creditos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_separados));
            this.dtg_sistema_separado = new System.Windows.Forms.DataGridView();
            this.cl_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_abono_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_num_cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_periodo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_fecha_primer_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_fecha_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor_abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_fecha_abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.btn_historial = new System.Windows.Forms.Button();
            this.btn_abono = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.cbx_tipo_busqueda = new System.Windows.Forms.ComboBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_exportar_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sistema_separado)).BeginInit();
            this.pnl_arriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_sistema_separado
            // 
            this.dtg_sistema_separado.AllowUserToAddRows = false;
            this.dtg_sistema_separado.AllowUserToDeleteRows = false;
            this.dtg_sistema_separado.AllowUserToOrderColumns = true;
            this.dtg_sistema_separado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_sistema_separado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_sistema_separado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_sistema_separado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_num,
            this.cl_estado,
            this.cl_fecha,
            this.cl_cliente,
            this.cl_producto,
            this.cl_cantidad,
            this.cl_costo,
            this.cl_precio_venta,
            this.cl_abono_inicial,
            this.cl_num_cuotas,
            this.cl_valor_cuota,
            this.cl_periodo_pago,
            this.cl_Total,
            this.cl_fecha_primer_pago,
            this.cl_fecha_vence,
            this.cl_valor_abono,
            this.cl_fecha_abono,
            this.cl_factura});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_sistema_separado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_sistema_separado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_sistema_separado.Location = new System.Drawing.Point(0, 42);
            this.dtg_sistema_separado.Name = "dtg_sistema_separado";
            this.dtg_sistema_separado.ReadOnly = true;
            this.dtg_sistema_separado.Size = new System.Drawing.Size(937, 442);
            this.dtg_sistema_separado.TabIndex = 9;
            this.dtg_sistema_separado.DoubleClick += new System.EventHandler(this.dtg_sistema_separado_DoubleClick);
            // 
            // cl_num
            // 
            this.cl_num.HeaderText = "Num";
            this.cl_num.Name = "cl_num";
            this.cl_num.ReadOnly = true;
            this.cl_num.Width = 50;
            // 
            // cl_estado
            // 
            this.cl_estado.HeaderText = "Estado";
            this.cl_estado.Name = "cl_estado";
            this.cl_estado.ReadOnly = true;
            // 
            // cl_fecha
            // 
            this.cl_fecha.HeaderText = "Fecha";
            this.cl_fecha.Name = "cl_fecha";
            this.cl_fecha.ReadOnly = true;
            // 
            // cl_cliente
            // 
            this.cl_cliente.HeaderText = "Cliente";
            this.cl_cliente.Name = "cl_cliente";
            this.cl_cliente.ReadOnly = true;
            // 
            // cl_producto
            // 
            this.cl_producto.HeaderText = "Producto";
            this.cl_producto.Name = "cl_producto";
            this.cl_producto.ReadOnly = true;
            this.cl_producto.Visible = false;
            // 
            // cl_cantidad
            // 
            this.cl_cantidad.HeaderText = "Cantidad";
            this.cl_cantidad.Name = "cl_cantidad";
            this.cl_cantidad.ReadOnly = true;
            this.cl_cantidad.Visible = false;
            // 
            // cl_costo
            // 
            this.cl_costo.HeaderText = "Costo";
            this.cl_costo.Name = "cl_costo";
            this.cl_costo.ReadOnly = true;
            this.cl_costo.Visible = false;
            // 
            // cl_precio_venta
            // 
            this.cl_precio_venta.HeaderText = "Precio venta";
            this.cl_precio_venta.Name = "cl_precio_venta";
            this.cl_precio_venta.ReadOnly = true;
            this.cl_precio_venta.Visible = false;
            // 
            // cl_abono_inicial
            // 
            this.cl_abono_inicial.HeaderText = "Abono inicial";
            this.cl_abono_inicial.Name = "cl_abono_inicial";
            this.cl_abono_inicial.ReadOnly = true;
            // 
            // cl_num_cuotas
            // 
            this.cl_num_cuotas.HeaderText = "Num cuotas";
            this.cl_num_cuotas.Name = "cl_num_cuotas";
            this.cl_num_cuotas.ReadOnly = true;
            // 
            // cl_valor_cuota
            // 
            this.cl_valor_cuota.HeaderText = "Valor cuota";
            this.cl_valor_cuota.Name = "cl_valor_cuota";
            this.cl_valor_cuota.ReadOnly = true;
            // 
            // cl_periodo_pago
            // 
            this.cl_periodo_pago.HeaderText = "Periodo pago";
            this.cl_periodo_pago.Name = "cl_periodo_pago";
            this.cl_periodo_pago.ReadOnly = true;
            // 
            // cl_Total
            // 
            this.cl_Total.HeaderText = "Total";
            this.cl_Total.Name = "cl_Total";
            this.cl_Total.ReadOnly = true;
            // 
            // cl_fecha_primer_pago
            // 
            this.cl_fecha_primer_pago.HeaderText = "Primer pago";
            this.cl_fecha_primer_pago.Name = "cl_fecha_primer_pago";
            this.cl_fecha_primer_pago.ReadOnly = true;
            // 
            // cl_fecha_vence
            // 
            this.cl_fecha_vence.HeaderText = "Fecha vence";
            this.cl_fecha_vence.Name = "cl_fecha_vence";
            this.cl_fecha_vence.ReadOnly = true;
            // 
            // cl_valor_abono
            // 
            this.cl_valor_abono.HeaderText = "Valor abonos";
            this.cl_valor_abono.Name = "cl_valor_abono";
            this.cl_valor_abono.ReadOnly = true;
            this.cl_valor_abono.Visible = false;
            // 
            // cl_fecha_abono
            // 
            this.cl_fecha_abono.HeaderText = "Fecha ultimo abono";
            this.cl_fecha_abono.Name = "cl_fecha_abono";
            this.cl_fecha_abono.ReadOnly = true;
            this.cl_fecha_abono.Visible = false;
            // 
            // cl_factura
            // 
            this.cl_factura.HeaderText = "Factura";
            this.cl_factura.Name = "cl_factura";
            this.cl_factura.ReadOnly = true;
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.btn_historial);
            this.pnl_arriba.Controls.Add(this.btn_abono);
            this.pnl_arriba.Controls.Add(this.label3);
            this.pnl_arriba.Controls.Add(this.label2);
            this.pnl_arriba.Controls.Add(this.dtp_fecha_fin);
            this.pnl_arriba.Controls.Add(this.dtp_fecha_inicio);
            this.pnl_arriba.Controls.Add(this.cbx_tipo_busqueda);
            this.pnl_arriba.Controls.Add(this.btn_eliminar);
            this.pnl_arriba.Controls.Add(this.btn_buscar);
            this.pnl_arriba.Controls.Add(this.txt_buscar);
            this.pnl_arriba.Controls.Add(this.btn_exportar_excel);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(937, 42);
            this.pnl_arriba.TabIndex = 8;
            // 
            // btn_historial
            // 
            this.btn_historial.BackColor = System.Drawing.Color.White;
            this.btn_historial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_historial.FlatAppearance.BorderSize = 0;
            this.btn_historial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historial.Image = ((System.Drawing.Image)(resources.GetObject("btn_historial.Image")));
            this.btn_historial.Location = new System.Drawing.Point(107, 6);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(26, 26);
            this.btn_historial.TabIndex = 82;
            this.btn_historial.UseVisualStyleBackColor = false;
            this.btn_historial.Click += new System.EventHandler(this.btn_historial_Click);
            // 
            // btn_abono
            // 
            this.btn_abono.BackColor = System.Drawing.Color.White;
            this.btn_abono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_abono.FlatAppearance.BorderSize = 0;
            this.btn_abono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_abono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abono.Image = ((System.Drawing.Image)(resources.GetObject("btn_abono.Image")));
            this.btn_abono.Location = new System.Drawing.Point(75, 6);
            this.btn_abono.Name = "btn_abono";
            this.btn_abono.Size = new System.Drawing.Size(26, 26);
            this.btn_abono.TabIndex = 81;
            this.btn_abono.UseVisualStyleBackColor = false;
            this.btn_abono.Click += new System.EventHandler(this.btn_abono_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 80;
            this.label3.Text = "F. Inicio:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 79;
            this.label2.Text = "F. Fin:";
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_fin.Location = new System.Drawing.Point(452, 10);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_fin.TabIndex = 78;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(281, 10);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_inicio.TabIndex = 77;
            // 
            // cbx_tipo_busqueda
            // 
            this.cbx_tipo_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tipo_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_busqueda.FormattingEnabled = true;
            this.cbx_tipo_busqueda.Items.AddRange(new object[] {
            "Contiene",
            "Exactamente"});
            this.cbx_tipo_busqueda.Location = new System.Drawing.Point(568, 10);
            this.cbx_tipo_busqueda.Name = "cbx_tipo_busqueda";
            this.cbx_tipo_busqueda.Size = new System.Drawing.Size(85, 21);
            this.cbx_tipo_busqueda.TabIndex = 76;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(42, 6);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(26, 26);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(904, 8);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(22, 22);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.ForeColor = System.Drawing.Color.Gray;
            this.txt_buscar.Location = new System.Drawing.Point(659, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(239, 20);
            this.txt_buscar.TabIndex = 7;
            this.txt_buscar.Text = "Num-cliente-producto";
            this.txt_buscar.Enter += new System.EventHandler(this.txt_buscar_Enter);
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            // 
            // btn_exportar_excel
            // 
            this.btn_exportar_excel.BackColor = System.Drawing.SystemColors.Window;
            this.btn_exportar_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar_excel.FlatAppearance.BorderSize = 0;
            this.btn_exportar_excel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_exportar_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar_excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportar_excel.Image")));
            this.btn_exportar_excel.Location = new System.Drawing.Point(9, 6);
            this.btn_exportar_excel.Name = "btn_exportar_excel";
            this.btn_exportar_excel.Size = new System.Drawing.Size(26, 26);
            this.btn_exportar_excel.TabIndex = 2;
            this.btn_exportar_excel.UseVisualStyleBackColor = false;
            this.btn_exportar_excel.Click += new System.EventHandler(this.btn_exportar_excel_Click);
            // 
            // frm_separados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(937, 484);
            this.Controls.Add(this.dtg_sistema_separado);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_separados";
            this.Text = "frm_separados";
            this.Load += new System.EventHandler(this.frm_separados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sistema_separado)).EndInit();
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_sistema_separado;
        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Button btn_abono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_tipo_busqueda;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_exportar_excel;
        private System.Windows.Forms.Button btn_historial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_abono_inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_num_cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor_cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_periodo_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fecha_primer_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fecha_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor_abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fecha_abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_factura;
        public System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        public System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
    }
}