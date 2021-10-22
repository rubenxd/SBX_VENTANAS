namespace SBX
{
    partial class frm_ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ventas));
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_minimixar = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.dtg_ventas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_orden_servicio = new System.Windows.Forms.Button();
            this.btn_impresion = new System.Windows.Forms.Button();
            this.btn_impresion_ticket = new System.Windows.Forms.Button();
            this.btn_cotizaciones = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.cbx_tipo_busqueda = new System.Windows.Forms.ComboBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_exportar_excel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_total_ventas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cl_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_codigo_baras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_modo_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_t_debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_num_baucher_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_t_credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_num_baucher_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_efectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_separado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_abonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ventas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.Color.DimGray;
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.label1);
            this.pnl_arriba.Controls.Add(this.lbl_minimixar);
            this.pnl_arriba.Controls.Add(this.lbl_cerrar);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(945, 28);
            this.pnl_arriba.TabIndex = 1;
            this.pnl_arriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_arriba_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ventas";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // lbl_minimixar
            // 
            this.lbl_minimixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minimixar.AutoSize = true;
            this.lbl_minimixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minimixar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimixar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_minimixar.Location = new System.Drawing.Point(892, -2);
            this.lbl_minimixar.Name = "lbl_minimixar";
            this.lbl_minimixar.Size = new System.Drawing.Size(18, 19);
            this.lbl_minimixar.TabIndex = 1;
            this.lbl_minimixar.Text = "_";
            this.lbl_minimixar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_minimixar.Click += new System.EventHandler(this.lbl_minimixar_Click);
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_cerrar.Location = new System.Drawing.Point(918, 3);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(17, 16);
            this.lbl_cerrar.TabIndex = 0;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // dtg_ventas
            // 
            this.dtg_ventas.AllowUserToAddRows = false;
            this.dtg_ventas.AllowUserToDeleteRows = false;
            this.dtg_ventas.AllowUserToOrderColumns = true;
            this.dtg_ventas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_codigo,
            this.cl_fecha,
            this.cl_factura,
            this.cl_item,
            this.cl_nombre,
            this.cl_referencia,
            this.cl_codigo_baras,
            this.cl_modo_venta,
            this.cl_um,
            this.cl_cantidad,
            this.cl_costo,
            this.cl_precio_venta,
            this.descuento,
            this.cl_valor_descuento,
            this.cl_t_debito,
            this.cl_num_baucher_d,
            this.cl_t_credito,
            this.cl_num_baucher_c,
            this.cl_Total,
            this.cl_efectivo,
            this.cl_cambio,
            this.cl_cliente,
            this.cl_sucursal,
            this.cl_domicilio,
            this.cl_separado,
            this.cl_credito,
            this.cl_abonos,
            this.cl_debe,
            this.cl_Usuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_ventas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtg_ventas.Location = new System.Drawing.Point(0, 70);
            this.dtg_ventas.Name = "dtg_ventas";
            this.dtg_ventas.ReadOnly = true;
            this.dtg_ventas.Size = new System.Drawing.Size(945, 388);
            this.dtg_ventas.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_orden_servicio);
            this.panel1.Controls.Add(this.btn_impresion);
            this.panel1.Controls.Add(this.btn_impresion_ticket);
            this.panel1.Controls.Add(this.btn_cotizaciones);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_fecha_fin);
            this.panel1.Controls.Add(this.dtp_fecha_inicio);
            this.panel1.Controls.Add(this.cbx_tipo_busqueda);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.txt_buscar);
            this.panel1.Controls.Add(this.btn_exportar_excel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 42);
            this.panel1.TabIndex = 8;
            // 
            // btn_orden_servicio
            // 
            this.btn_orden_servicio.BackColor = System.Drawing.SystemColors.Window;
            this.btn_orden_servicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_orden_servicio.FlatAppearance.BorderSize = 0;
            this.btn_orden_servicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_orden_servicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orden_servicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_orden_servicio.Image")));
            this.btn_orden_servicio.Location = new System.Drawing.Point(170, 6);
            this.btn_orden_servicio.Name = "btn_orden_servicio";
            this.btn_orden_servicio.Size = new System.Drawing.Size(26, 26);
            this.btn_orden_servicio.TabIndex = 84;
            this.btn_orden_servicio.UseVisualStyleBackColor = false;
            this.btn_orden_servicio.Visible = false;
            this.btn_orden_servicio.Click += new System.EventHandler(this.btn_orden_servicio_Click);
            // 
            // btn_impresion
            // 
            this.btn_impresion.BackColor = System.Drawing.SystemColors.Window;
            this.btn_impresion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_impresion.FlatAppearance.BorderSize = 0;
            this.btn_impresion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_impresion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_impresion.Image = ((System.Drawing.Image)(resources.GetObject("btn_impresion.Image")));
            this.btn_impresion.Location = new System.Drawing.Point(138, 6);
            this.btn_impresion.Name = "btn_impresion";
            this.btn_impresion.Size = new System.Drawing.Size(26, 26);
            this.btn_impresion.TabIndex = 83;
            this.btn_impresion.UseVisualStyleBackColor = false;
            this.btn_impresion.Click += new System.EventHandler(this.btn_impresion_Click);
            // 
            // btn_impresion_ticket
            // 
            this.btn_impresion_ticket.BackColor = System.Drawing.SystemColors.Window;
            this.btn_impresion_ticket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_impresion_ticket.FlatAppearance.BorderSize = 0;
            this.btn_impresion_ticket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_impresion_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_impresion_ticket.Image = ((System.Drawing.Image)(resources.GetObject("btn_impresion_ticket.Image")));
            this.btn_impresion_ticket.Location = new System.Drawing.Point(74, 6);
            this.btn_impresion_ticket.Name = "btn_impresion_ticket";
            this.btn_impresion_ticket.Size = new System.Drawing.Size(26, 26);
            this.btn_impresion_ticket.TabIndex = 82;
            this.btn_impresion_ticket.UseVisualStyleBackColor = false;
            this.btn_impresion_ticket.Click += new System.EventHandler(this.btn_impresion_ticket_Click);
            // 
            // btn_cotizaciones
            // 
            this.btn_cotizaciones.BackColor = System.Drawing.SystemColors.Window;
            this.btn_cotizaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cotizaciones.FlatAppearance.BorderSize = 0;
            this.btn_cotizaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_cotizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cotizaciones.Image = ((System.Drawing.Image)(resources.GetObject("btn_cotizaciones.Image")));
            this.btn_cotizaciones.Location = new System.Drawing.Point(106, 6);
            this.btn_cotizaciones.Name = "btn_cotizaciones";
            this.btn_cotizaciones.Size = new System.Drawing.Size(26, 26);
            this.btn_cotizaciones.TabIndex = 81;
            this.btn_cotizaciones.UseVisualStyleBackColor = false;
            this.btn_cotizaciones.Click += new System.EventHandler(this.btn_cotizaciones_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 12);
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
            this.label2.Location = new System.Drawing.Point(416, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 79;
            this.label2.Text = "F. Fin:";
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_fin.Location = new System.Drawing.Point(460, 10);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_fin.TabIndex = 78;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(289, 10);
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
            this.cbx_tipo_busqueda.Location = new System.Drawing.Point(576, 10);
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
            this.btn_buscar.Location = new System.Drawing.Point(912, 8);
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
            this.txt_buscar.Location = new System.Drawing.Point(667, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(239, 20);
            this.txt_buscar.TabIndex = 7;
            this.txt_buscar.Text = "Producto-Factura";
            this.txt_buscar.Enter += new System.EventHandler(this.txt_buscar_Enter);
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_cantidad);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_total_ventas);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 458);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 95);
            this.panel2.TabIndex = 9;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(138, 55);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(23, 25);
            this.lbl_cantidad.TabIndex = 84;
            this.lbl_cantidad.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 83;
            this.label6.Text = "Cantidad:";
            // 
            // lbl_total_ventas
            // 
            this.lbl_total_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total_ventas.AutoSize = true;
            this.lbl_total_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_ventas.Location = new System.Drawing.Point(140, 19);
            this.lbl_total_ventas.Name = "lbl_total_ventas";
            this.lbl_total_ventas.Size = new System.Drawing.Size(23, 25);
            this.lbl_total_ventas.TabIndex = 82;
            this.lbl_total_ventas.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Total Venta:";
            // 
            // cl_codigo
            // 
            this.cl_codigo.HeaderText = "Codigo";
            this.cl_codigo.Name = "cl_codigo";
            this.cl_codigo.ReadOnly = true;
            this.cl_codigo.Visible = false;
            // 
            // cl_fecha
            // 
            this.cl_fecha.HeaderText = "Fecha";
            this.cl_fecha.Name = "cl_fecha";
            this.cl_fecha.ReadOnly = true;
            // 
            // cl_factura
            // 
            this.cl_factura.HeaderText = "Factura";
            this.cl_factura.Name = "cl_factura";
            this.cl_factura.ReadOnly = true;
            // 
            // cl_item
            // 
            this.cl_item.HeaderText = "Item";
            this.cl_item.Name = "cl_item";
            this.cl_item.ReadOnly = true;
            // 
            // cl_nombre
            // 
            this.cl_nombre.HeaderText = "Nombre";
            this.cl_nombre.Name = "cl_nombre";
            this.cl_nombre.ReadOnly = true;
            this.cl_nombre.Width = 200;
            // 
            // cl_referencia
            // 
            this.cl_referencia.HeaderText = "Referencia";
            this.cl_referencia.Name = "cl_referencia";
            this.cl_referencia.ReadOnly = true;
            // 
            // cl_codigo_baras
            // 
            this.cl_codigo_baras.HeaderText = "Codigo barras";
            this.cl_codigo_baras.Name = "cl_codigo_baras";
            this.cl_codigo_baras.ReadOnly = true;
            this.cl_codigo_baras.Width = 150;
            // 
            // cl_modo_venta
            // 
            this.cl_modo_venta.HeaderText = "Modo venta";
            this.cl_modo_venta.Name = "cl_modo_venta";
            this.cl_modo_venta.ReadOnly = true;
            // 
            // cl_um
            // 
            this.cl_um.HeaderText = "UM";
            this.cl_um.Name = "cl_um";
            this.cl_um.ReadOnly = true;
            // 
            // cl_cantidad
            // 
            this.cl_cantidad.HeaderText = "Cantidad";
            this.cl_cantidad.Name = "cl_cantidad";
            this.cl_cantidad.ReadOnly = true;
            // 
            // cl_costo
            // 
            this.cl_costo.HeaderText = "Costo";
            this.cl_costo.Name = "cl_costo";
            this.cl_costo.ReadOnly = true;
            // 
            // cl_precio_venta
            // 
            this.cl_precio_venta.HeaderText = "Precio venta";
            this.cl_precio_venta.Name = "cl_precio_venta";
            this.cl_precio_venta.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "% Desc";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // cl_valor_descuento
            // 
            this.cl_valor_descuento.HeaderText = "Valor descuento";
            this.cl_valor_descuento.Name = "cl_valor_descuento";
            this.cl_valor_descuento.ReadOnly = true;
            // 
            // cl_t_debito
            // 
            this.cl_t_debito.HeaderText = "TDebito";
            this.cl_t_debito.Name = "cl_t_debito";
            this.cl_t_debito.ReadOnly = true;
            // 
            // cl_num_baucher_d
            // 
            this.cl_num_baucher_d.HeaderText = "Num baucher debito";
            this.cl_num_baucher_d.Name = "cl_num_baucher_d";
            this.cl_num_baucher_d.ReadOnly = true;
            // 
            // cl_t_credito
            // 
            this.cl_t_credito.HeaderText = "TCredito";
            this.cl_t_credito.Name = "cl_t_credito";
            this.cl_t_credito.ReadOnly = true;
            // 
            // cl_num_baucher_c
            // 
            this.cl_num_baucher_c.HeaderText = "Num baucher Credito";
            this.cl_num_baucher_c.Name = "cl_num_baucher_c";
            this.cl_num_baucher_c.ReadOnly = true;
            // 
            // cl_Total
            // 
            this.cl_Total.HeaderText = "Total";
            this.cl_Total.Name = "cl_Total";
            this.cl_Total.ReadOnly = true;
            // 
            // cl_efectivo
            // 
            this.cl_efectivo.HeaderText = "Efectivo";
            this.cl_efectivo.Name = "cl_efectivo";
            this.cl_efectivo.ReadOnly = true;
            // 
            // cl_cambio
            // 
            this.cl_cambio.HeaderText = "Cambio";
            this.cl_cambio.Name = "cl_cambio";
            this.cl_cambio.ReadOnly = true;
            // 
            // cl_cliente
            // 
            this.cl_cliente.HeaderText = "Cliente";
            this.cl_cliente.Name = "cl_cliente";
            this.cl_cliente.ReadOnly = true;
            // 
            // cl_sucursal
            // 
            this.cl_sucursal.HeaderText = "Sucursal";
            this.cl_sucursal.Name = "cl_sucursal";
            this.cl_sucursal.ReadOnly = true;
            // 
            // cl_domicilio
            // 
            this.cl_domicilio.HeaderText = "Domicilio";
            this.cl_domicilio.Name = "cl_domicilio";
            this.cl_domicilio.ReadOnly = true;
            // 
            // cl_separado
            // 
            this.cl_separado.HeaderText = "Separado";
            this.cl_separado.Name = "cl_separado";
            this.cl_separado.ReadOnly = true;
            // 
            // cl_credito
            // 
            this.cl_credito.HeaderText = "Credito";
            this.cl_credito.Name = "cl_credito";
            this.cl_credito.ReadOnly = true;
            // 
            // cl_abonos
            // 
            this.cl_abonos.HeaderText = "Abonos";
            this.cl_abonos.Name = "cl_abonos";
            this.cl_abonos.ReadOnly = true;
            // 
            // cl_debe
            // 
            this.cl_debe.HeaderText = "Debe";
            this.cl_debe.Name = "cl_debe";
            this.cl_debe.ReadOnly = true;
            // 
            // cl_Usuario
            // 
            this.cl_Usuario.HeaderText = "Usuario";
            this.cl_Usuario.Name = "cl_Usuario";
            this.cl_Usuario.ReadOnly = true;
            // 
            // frm_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(945, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtg_ventas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ventas";
            this.Load += new System.EventHandler(this.Frm_ventas_Load);
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ventas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_minimixar;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.DataGridView dtg_ventas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.ComboBox cbx_tipo_busqueda;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_exportar_excel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_total_ventas;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cotizaciones;
        private System.Windows.Forms.Button btn_impresion_ticket;
        private System.Windows.Forms.Button btn_impresion;
        private System.Windows.Forms.Button btn_orden_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo_baras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_modo_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_um;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_t_debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_num_baucher_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_t_credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_num_baucher_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_efectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_separado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_abonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Usuario;
    }
}