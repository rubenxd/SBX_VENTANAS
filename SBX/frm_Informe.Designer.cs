namespace SBX
{
    partial class frm_Informe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Informe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_tipo_busqueda = new System.Windows.Forms.ComboBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_imprimir_reporte = new System.Windows.Forms.Button();
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.pnl_abajo = new System.Windows.Forms.Panel();
            this.dtg_informe = new System.Windows.Forms.DataGridView();
            this.cl_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cantidad_exacta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_costos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Descuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_contenido = new System.Windows.Forms.Panel();
            this.btn_ver_gastos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gastos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ventas_domicilio = new System.Windows.Forms.TextBox();
            this.txt_costos = new System.Windows.Forms.TextBox();
            this.txt_ventas_directas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnl_centro.SuspendLayout();
            this.pnl_abajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_informe)).BeginInit();
            this.pnl_contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbx_tipo_busqueda);
            this.panel1.Controls.Add(this.txt_buscar);
            this.panel1.Controls.Add(this.btn_consultar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtp_fecha_fin);
            this.panel1.Controls.Add(this.dtp_fecha_inicio);
            this.panel1.Controls.Add(this.btn_imprimir_reporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 42);
            this.panel1.TabIndex = 9;
            // 
            // cbx_tipo_busqueda
            // 
            this.cbx_tipo_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tipo_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_busqueda.FormattingEnabled = true;
            this.cbx_tipo_busqueda.Items.AddRange(new object[] {
            "Contiene",
            "Exactamente"});
            this.cbx_tipo_busqueda.Location = new System.Drawing.Point(550, 9);
            this.cbx_tipo_busqueda.Name = "cbx_tipo_busqueda";
            this.cbx_tipo_busqueda.Size = new System.Drawing.Size(123, 21);
            this.cbx_tipo_busqueda.TabIndex = 87;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.ForeColor = System.Drawing.Color.Gray;
            this.txt_buscar.Location = new System.Drawing.Point(682, 9);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(181, 20);
            this.txt_buscar.TabIndex = 86;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_buscar_KeyUp);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consultar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultar.Image")));
            this.btn_consultar.Location = new System.Drawing.Point(869, 6);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(26, 26);
            this.btn_consultar.TabIndex = 85;
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 84;
            this.label4.Text = "F. Inicio:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "F. Fin:";
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_fin.Location = new System.Drawing.Point(427, 9);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_fecha_fin.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_fin.TabIndex = 82;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(256, 9);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_inicio.TabIndex = 81;
            // 
            // btn_imprimir_reporte
            // 
            this.btn_imprimir_reporte.BackColor = System.Drawing.SystemColors.Window;
            this.btn_imprimir_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir_reporte.FlatAppearance.BorderSize = 0;
            this.btn_imprimir_reporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_imprimir_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir_reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir_reporte.Image")));
            this.btn_imprimir_reporte.Location = new System.Drawing.Point(12, 6);
            this.btn_imprimir_reporte.Name = "btn_imprimir_reporte";
            this.btn_imprimir_reporte.Size = new System.Drawing.Size(26, 26);
            this.btn_imprimir_reporte.TabIndex = 2;
            this.btn_imprimir_reporte.UseVisualStyleBackColor = false;
            this.btn_imprimir_reporte.Visible = false;
            this.btn_imprimir_reporte.Click += new System.EventHandler(this.btn_imprimir_reporte_Click);
            // 
            // pnl_centro
            // 
            this.pnl_centro.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_centro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_centro.Controls.Add(this.pnl_abajo);
            this.pnl_centro.Controls.Add(this.pnl_contenido);
            this.pnl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centro.Location = new System.Drawing.Point(0, 42);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(909, 397);
            this.pnl_centro.TabIndex = 10;
            // 
            // pnl_abajo
            // 
            this.pnl_abajo.Controls.Add(this.dtg_informe);
            this.pnl_abajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_abajo.Location = new System.Drawing.Point(0, 218);
            this.pnl_abajo.Name = "pnl_abajo";
            this.pnl_abajo.Size = new System.Drawing.Size(907, 177);
            this.pnl_abajo.TabIndex = 12;
            // 
            // dtg_informe
            // 
            this.dtg_informe.AllowUserToAddRows = false;
            this.dtg_informe.AllowUserToDeleteRows = false;
            this.dtg_informe.AllowUserToOrderColumns = true;
            this.dtg_informe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_informe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_informe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_informe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_informe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_item,
            this.cl_codigo_barras,
            this.cl_referencia,
            this.cl_nombre,
            this.cl_cantidad,
            this.cl_cantidad_exacta,
            this.cl_um,
            this.cl_costos,
            this.cl_precio_venta,
            this.cl_Descuentos,
            this.cl_total,
            this.cl_resultado,
            this.v_modulo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_informe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_informe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_informe.Location = new System.Drawing.Point(0, 0);
            this.dtg_informe.Name = "dtg_informe";
            this.dtg_informe.ReadOnly = true;
            this.dtg_informe.Size = new System.Drawing.Size(907, 177);
            this.dtg_informe.TabIndex = 10;
            // 
            // cl_item
            // 
            this.cl_item.HeaderText = "Item";
            this.cl_item.Name = "cl_item";
            this.cl_item.ReadOnly = true;
            // 
            // cl_codigo_barras
            // 
            this.cl_codigo_barras.HeaderText = "Codigo Barras";
            this.cl_codigo_barras.Name = "cl_codigo_barras";
            this.cl_codigo_barras.ReadOnly = true;
            // 
            // cl_referencia
            // 
            this.cl_referencia.HeaderText = "Referencia";
            this.cl_referencia.Name = "cl_referencia";
            this.cl_referencia.ReadOnly = true;
            // 
            // cl_nombre
            // 
            this.cl_nombre.HeaderText = "Nombre";
            this.cl_nombre.Name = "cl_nombre";
            this.cl_nombre.ReadOnly = true;
            // 
            // cl_cantidad
            // 
            this.cl_cantidad.HeaderText = "Cantidad";
            this.cl_cantidad.Name = "cl_cantidad";
            this.cl_cantidad.ReadOnly = true;
            // 
            // cl_cantidad_exacta
            // 
            this.cl_cantidad_exacta.HeaderText = "Desc. Cantidad";
            this.cl_cantidad_exacta.Name = "cl_cantidad_exacta";
            this.cl_cantidad_exacta.ReadOnly = true;
            // 
            // cl_um
            // 
            this.cl_um.HeaderText = "UM";
            this.cl_um.Name = "cl_um";
            this.cl_um.ReadOnly = true;
            // 
            // cl_costos
            // 
            this.cl_costos.HeaderText = "Costos";
            this.cl_costos.Name = "cl_costos";
            this.cl_costos.ReadOnly = true;
            // 
            // cl_precio_venta
            // 
            this.cl_precio_venta.HeaderText = "Precio venta";
            this.cl_precio_venta.Name = "cl_precio_venta";
            this.cl_precio_venta.ReadOnly = true;
            // 
            // cl_Descuentos
            // 
            this.cl_Descuentos.HeaderText = "Descuentos";
            this.cl_Descuentos.Name = "cl_Descuentos";
            this.cl_Descuentos.ReadOnly = true;
            // 
            // cl_total
            // 
            this.cl_total.HeaderText = "Total";
            this.cl_total.Name = "cl_total";
            this.cl_total.ReadOnly = true;
            // 
            // cl_resultado
            // 
            this.cl_resultado.HeaderText = "Resultado";
            this.cl_resultado.Name = "cl_resultado";
            this.cl_resultado.ReadOnly = true;
            // 
            // v_modulo
            // 
            this.v_modulo.HeaderText = "Modulo";
            this.v_modulo.Name = "v_modulo";
            this.v_modulo.ReadOnly = true;
            // 
            // pnl_contenido
            // 
            this.pnl_contenido.Controls.Add(this.btn_ver_gastos);
            this.pnl_contenido.Controls.Add(this.label7);
            this.pnl_contenido.Controls.Add(this.txt_gastos);
            this.pnl_contenido.Controls.Add(this.label2);
            this.pnl_contenido.Controls.Add(this.label1);
            this.pnl_contenido.Controls.Add(this.txt_resultado);
            this.pnl_contenido.Controls.Add(this.label3);
            this.pnl_contenido.Controls.Add(this.lbl_resultado);
            this.pnl_contenido.Controls.Add(this.label6);
            this.pnl_contenido.Controls.Add(this.txt_ventas_domicilio);
            this.pnl_contenido.Controls.Add(this.txt_costos);
            this.pnl_contenido.Controls.Add(this.txt_ventas_directas);
            this.pnl_contenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_contenido.Location = new System.Drawing.Point(0, 0);
            this.pnl_contenido.Name = "pnl_contenido";
            this.pnl_contenido.Size = new System.Drawing.Size(907, 218);
            this.pnl_contenido.TabIndex = 11;
            // 
            // btn_ver_gastos
            // 
            this.btn_ver_gastos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ver_gastos.BackColor = System.Drawing.SystemColors.Window;
            this.btn_ver_gastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ver_gastos.FlatAppearance.BorderSize = 0;
            this.btn_ver_gastos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_ver_gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_gastos.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver_gastos.Image")));
            this.btn_ver_gastos.Location = new System.Drawing.Point(638, 148);
            this.btn_ver_gastos.Name = "btn_ver_gastos";
            this.btn_ver_gastos.Size = new System.Drawing.Size(26, 26);
            this.btn_ver_gastos.TabIndex = 86;
            this.btn_ver_gastos.UseVisualStyleBackColor = false;
            this.btn_ver_gastos.Click += new System.EventHandler(this.btn_ver_gastos_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gastos";
            // 
            // txt_gastos
            // 
            this.txt_gastos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_gastos.Enabled = false;
            this.txt_gastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gastos.Location = new System.Drawing.Point(384, 148);
            this.txt_gastos.Name = "txt_gastos";
            this.txt_gastos.Size = new System.Drawing.Size(250, 26);
            this.txt_gastos.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costos";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resumen Ganancias y perdidas";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_resultado.Enabled = false;
            this.txt_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.Location = new System.Drawing.Point(384, 180);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(250, 26);
            this.txt_resultado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ventas directas";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(255, 184);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(82, 20);
            this.lbl_resultado.TabIndex = 7;
            this.lbl_resultado.Text = "Resultado";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ventas domicilio";
            // 
            // txt_ventas_domicilio
            // 
            this.txt_ventas_domicilio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ventas_domicilio.Enabled = false;
            this.txt_ventas_domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ventas_domicilio.Location = new System.Drawing.Point(384, 116);
            this.txt_ventas_domicilio.Name = "txt_ventas_domicilio";
            this.txt_ventas_domicilio.Size = new System.Drawing.Size(250, 26);
            this.txt_ventas_domicilio.TabIndex = 6;
            // 
            // txt_costos
            // 
            this.txt_costos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_costos.Enabled = false;
            this.txt_costos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costos.Location = new System.Drawing.Point(384, 56);
            this.txt_costos.Name = "txt_costos";
            this.txt_costos.Size = new System.Drawing.Size(250, 26);
            this.txt_costos.TabIndex = 4;
            // 
            // txt_ventas_directas
            // 
            this.txt_ventas_directas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ventas_directas.Enabled = false;
            this.txt_ventas_directas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ventas_directas.Location = new System.Drawing.Point(384, 86);
            this.txt_ventas_directas.Name = "txt_ventas_directas";
            this.txt_ventas_directas.Size = new System.Drawing.Size(250, 26);
            this.txt_ventas_directas.TabIndex = 5;
            // 
            // frm_Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 439);
            this.Controls.Add(this.pnl_centro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Informe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Informe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_centro.ResumeLayout(false);
            this.pnl_abajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_informe)).EndInit();
            this.pnl_contenido.ResumeLayout(false);
            this.pnl_contenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_imprimir_reporte;
        private System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ventas_domicilio;
        private System.Windows.Forms.TextBox txt_ventas_directas;
        private System.Windows.Forms.TextBox txt_costos;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.DataGridView dtg_informe;
        private System.Windows.Forms.Panel pnl_contenido;
        private System.Windows.Forms.Panel pnl_abajo;
        private System.Windows.Forms.ComboBox cbx_tipo_busqueda;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cantidad_exacta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_um;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_costos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Descuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_modulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_gastos;
        private System.Windows.Forms.Button btn_ver_gastos;
    }
}