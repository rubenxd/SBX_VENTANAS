namespace SBX
{
    partial class frm_producto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_producto));
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.dtg_productos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_paginacion = new System.Windows.Forms.Panel();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_ultima = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.txt_max_paginas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ultima_pagina = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_paginas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_registros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.cbx_dato_busqueda = new System.Windows.Forms.ComboBox();
            this.btn_fecha_vencimiento = new System.Windows.Forms.Button();
            this.btn_estado_stock = new System.Windows.Forms.Button();
            this.btn_producto_mas_vendido = new System.Windows.Forms.Button();
            this.cbx_tipo_busqueda = new System.Windows.Forms.ComboBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_exportar_excel = new System.Windows.Forms.Button();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.lbl_minimizar = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_centro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productos)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_paginacion.SuspendLayout();
            this.pnl_arriba.SuspendLayout();
            this.pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_centro
            // 
            this.pnl_centro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_centro.Controls.Add(this.dtg_productos);
            this.pnl_centro.Controls.Add(this.panel1);
            this.pnl_centro.Controls.Add(this.pnl_arriba);
            this.pnl_centro.Controls.Add(this.pnl_titulo);
            this.pnl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centro.Location = new System.Drawing.Point(0, 0);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(939, 500);
            this.pnl_centro.TabIndex = 0;
            // 
            // dtg_productos
            // 
            this.dtg_productos.AllowUserToAddRows = false;
            this.dtg_productos.AllowUserToDeleteRows = false;
            this.dtg_productos.AllowUserToOrderColumns = true;
            this.dtg_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_productos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_productos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_productos.Location = new System.Drawing.Point(0, 42);
            this.dtg_productos.Name = "dtg_productos";
            this.dtg_productos.ReadOnly = true;
            this.dtg_productos.Size = new System.Drawing.Size(935, 453);
            this.dtg_productos.TabIndex = 6;
            this.dtg_productos.DoubleClick += new System.EventHandler(this.dtg_productos_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_paginacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 1);
            this.panel1.TabIndex = 7;
            // 
            // pnl_paginacion
            // 
            this.pnl_paginacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_paginacion.Controls.Add(this.btn_actualizar);
            this.pnl_paginacion.Controls.Add(this.btn_ultima);
            this.pnl_paginacion.Controls.Add(this.btn_siguiente);
            this.pnl_paginacion.Controls.Add(this.btn_atras);
            this.pnl_paginacion.Controls.Add(this.btn_primero);
            this.pnl_paginacion.Controls.Add(this.txt_max_paginas);
            this.pnl_paginacion.Controls.Add(this.label5);
            this.pnl_paginacion.Controls.Add(this.lbl_ultima_pagina);
            this.pnl_paginacion.Controls.Add(this.label4);
            this.pnl_paginacion.Controls.Add(this.lbl_paginas);
            this.pnl_paginacion.Controls.Add(this.label3);
            this.pnl_paginacion.Controls.Add(this.lbl_registros);
            this.pnl_paginacion.Controls.Add(this.label2);
            this.pnl_paginacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_paginacion.Location = new System.Drawing.Point(0, 0);
            this.pnl_paginacion.Name = "pnl_paginacion";
            this.pnl_paginacion.Size = new System.Drawing.Size(935, 1);
            this.pnl_paginacion.TabIndex = 11;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_actualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(832, 8);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(25, 25);
            this.btn_actualizar.TabIndex = 15;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Visible = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_ultima
            // 
            this.btn_ultima.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ultima.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ultima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ultima.FlatAppearance.BorderSize = 0;
            this.btn_ultima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_ultima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultima.Image = ((System.Drawing.Image)(resources.GetObject("btn_ultima.Image")));
            this.btn_ultima.Location = new System.Drawing.Point(468, 5);
            this.btn_ultima.Name = "btn_ultima";
            this.btn_ultima.Size = new System.Drawing.Size(30, 30);
            this.btn_ultima.TabIndex = 14;
            this.btn_ultima.UseVisualStyleBackColor = false;
            this.btn_ultima.Visible = false;
            this.btn_ultima.Click += new System.EventHandler(this.btn_ultima_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_siguiente.BackColor = System.Drawing.SystemColors.Control;
            this.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_siguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siguiente.Image = ((System.Drawing.Image)(resources.GetObject("btn_siguiente.Image")));
            this.btn_siguiente.Location = new System.Drawing.Point(425, 5);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(30, 30);
            this.btn_siguiente.TabIndex = 13;
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Visible = false;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_atras.BackColor = System.Drawing.SystemColors.Control;
            this.btn_atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atras.FlatAppearance.BorderSize = 0;
            this.btn_atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_atras.Image")));
            this.btn_atras.Location = new System.Drawing.Point(382, 5);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(30, 30);
            this.btn_atras.TabIndex = 12;
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Visible = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_primero.BackColor = System.Drawing.SystemColors.Control;
            this.btn_primero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_primero.FlatAppearance.BorderSize = 0;
            this.btn_primero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primero.Image = ((System.Drawing.Image)(resources.GetObject("btn_primero.Image")));
            this.btn_primero.Location = new System.Drawing.Point(343, 5);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(30, 30);
            this.btn_primero.TabIndex = 11;
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Visible = false;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // txt_max_paginas
            // 
            this.txt_max_paginas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_max_paginas.Location = new System.Drawing.Point(759, 11);
            this.txt_max_paginas.Name = "txt_max_paginas";
            this.txt_max_paginas.Size = new System.Drawing.Size(56, 20);
            this.txt_max_paginas.TabIndex = 7;
            this.txt_max_paginas.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Maximo paginas: ";
            this.label5.Visible = false;
            // 
            // lbl_ultima_pagina
            // 
            this.lbl_ultima_pagina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ultima_pagina.AutoSize = true;
            this.lbl_ultima_pagina.Location = new System.Drawing.Point(603, 14);
            this.lbl_ultima_pagina.Name = "lbl_ultima_pagina";
            this.lbl_ultima_pagina.Size = new System.Drawing.Size(13, 13);
            this.lbl_ultima_pagina.TabIndex = 5;
            this.lbl_ultima_pagina.Text = "0";
            this.lbl_ultima_pagina.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ultima pagina: ";
            this.label4.Visible = false;
            // 
            // lbl_paginas
            // 
            this.lbl_paginas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_paginas.AutoSize = true;
            this.lbl_paginas.Location = new System.Drawing.Point(266, 14);
            this.lbl_paginas.Name = "lbl_paginas";
            this.lbl_paginas.Size = new System.Drawing.Size(13, 13);
            this.lbl_paginas.TabIndex = 3;
            this.lbl_paginas.Text = "0";
            this.lbl_paginas.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paginas: ";
            this.label3.Visible = false;
            // 
            // lbl_registros
            // 
            this.lbl_registros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_registros.AutoSize = true;
            this.lbl_registros.Location = new System.Drawing.Point(132, 14);
            this.lbl_registros.Name = "lbl_registros";
            this.lbl_registros.Size = new System.Drawing.Size(13, 13);
            this.lbl_registros.TabIndex = 1;
            this.lbl_registros.Text = "0";
            this.lbl_registros.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registros: ";
            this.label2.Visible = false;
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.cbx_dato_busqueda);
            this.pnl_arriba.Controls.Add(this.btn_fecha_vencimiento);
            this.pnl_arriba.Controls.Add(this.btn_estado_stock);
            this.pnl_arriba.Controls.Add(this.btn_producto_mas_vendido);
            this.pnl_arriba.Controls.Add(this.cbx_tipo_busqueda);
            this.pnl_arriba.Controls.Add(this.btn_editar);
            this.pnl_arriba.Controls.Add(this.btn_eliminar);
            this.pnl_arriba.Controls.Add(this.btn_buscar);
            this.pnl_arriba.Controls.Add(this.txt_buscar);
            this.pnl_arriba.Controls.Add(this.btn_exportar_excel);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(935, 42);
            this.pnl_arriba.TabIndex = 4;
            // 
            // cbx_dato_busqueda
            // 
            this.cbx_dato_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_dato_busqueda.FormattingEnabled = true;
            this.cbx_dato_busqueda.Items.AddRange(new object[] {
            "Nombre",
            "Item",
            "Referencia",
            "Codigo Barras"});
            this.cbx_dato_busqueda.Location = new System.Drawing.Point(483, 8);
            this.cbx_dato_busqueda.Name = "cbx_dato_busqueda";
            this.cbx_dato_busqueda.Size = new System.Drawing.Size(168, 21);
            this.cbx_dato_busqueda.TabIndex = 20;
            // 
            // btn_fecha_vencimiento
            // 
            this.btn_fecha_vencimiento.BackColor = System.Drawing.SystemColors.Window;
            this.btn_fecha_vencimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fecha_vencimiento.FlatAppearance.BorderSize = 0;
            this.btn_fecha_vencimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_fecha_vencimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fecha_vencimiento.Image = ((System.Drawing.Image)(resources.GetObject("btn_fecha_vencimiento.Image")));
            this.btn_fecha_vencimiento.Location = new System.Drawing.Point(138, 6);
            this.btn_fecha_vencimiento.Name = "btn_fecha_vencimiento";
            this.btn_fecha_vencimiento.Size = new System.Drawing.Size(26, 26);
            this.btn_fecha_vencimiento.TabIndex = 19;
            this.btn_fecha_vencimiento.UseVisualStyleBackColor = false;
            this.btn_fecha_vencimiento.Click += new System.EventHandler(this.btn_fecha_vencimiento_Click);
            // 
            // btn_estado_stock
            // 
            this.btn_estado_stock.BackColor = System.Drawing.SystemColors.Window;
            this.btn_estado_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_estado_stock.FlatAppearance.BorderSize = 0;
            this.btn_estado_stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_estado_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estado_stock.Image = ((System.Drawing.Image)(resources.GetObject("btn_estado_stock.Image")));
            this.btn_estado_stock.Location = new System.Drawing.Point(106, 6);
            this.btn_estado_stock.Name = "btn_estado_stock";
            this.btn_estado_stock.Size = new System.Drawing.Size(26, 26);
            this.btn_estado_stock.TabIndex = 18;
            this.btn_estado_stock.UseVisualStyleBackColor = false;
            this.btn_estado_stock.Click += new System.EventHandler(this.btn_estado_stock_Click);
            // 
            // btn_producto_mas_vendido
            // 
            this.btn_producto_mas_vendido.BackColor = System.Drawing.SystemColors.Window;
            this.btn_producto_mas_vendido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_producto_mas_vendido.FlatAppearance.BorderSize = 0;
            this.btn_producto_mas_vendido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_producto_mas_vendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto_mas_vendido.Image = ((System.Drawing.Image)(resources.GetObject("btn_producto_mas_vendido.Image")));
            this.btn_producto_mas_vendido.Location = new System.Drawing.Point(195, 6);
            this.btn_producto_mas_vendido.Name = "btn_producto_mas_vendido";
            this.btn_producto_mas_vendido.Size = new System.Drawing.Size(26, 26);
            this.btn_producto_mas_vendido.TabIndex = 17;
            this.btn_producto_mas_vendido.UseVisualStyleBackColor = false;
            this.btn_producto_mas_vendido.Visible = false;
            this.btn_producto_mas_vendido.Click += new System.EventHandler(this.btn_producto_mas_vendido_Click);
            // 
            // cbx_tipo_busqueda
            // 
            this.cbx_tipo_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tipo_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_busqueda.FormattingEnabled = true;
            this.cbx_tipo_busqueda.Items.AddRange(new object[] {
            "Contiene",
            "Exactamente"});
            this.cbx_tipo_busqueda.Location = new System.Drawing.Point(349, 8);
            this.cbx_tipo_busqueda.Name = "cbx_tipo_busqueda";
            this.cbx_tipo_busqueda.Size = new System.Drawing.Size(123, 21);
            this.cbx_tipo_busqueda.TabIndex = 16;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Enabled = false;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(42, 6);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(26, 26);
            this.btn_editar.TabIndex = 14;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(74, 6);
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
            this.btn_buscar.Location = new System.Drawing.Point(902, 8);
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
            this.txt_buscar.Location = new System.Drawing.Point(657, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(239, 20);
            this.txt_buscar.TabIndex = 7;
            this.txt_buscar.Text = "Item-Nombre-Referencia-Codigo barras";
            this.txt_buscar.Enter += new System.EventHandler(this.txt_buscar_Enter);
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            // 
            // btn_exportar_excel
            // 
            this.btn_exportar_excel.BackColor = System.Drawing.SystemColors.Window;
            this.btn_exportar_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar_excel.Enabled = false;
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
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.DimGray;
            this.pnl_titulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_titulo.Controls.Add(this.lbl_minimizar);
            this.pnl_titulo.Controls.Add(this.lbl_cerrar);
            this.pnl_titulo.Controls.Add(this.label1);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(935, 0);
            this.pnl_titulo.TabIndex = 3;
            // 
            // lbl_minimizar
            // 
            this.lbl_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minimizar.AutoSize = true;
            this.lbl_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minimizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_minimizar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_minimizar.Location = new System.Drawing.Point(883, 1);
            this.lbl_minimizar.Name = "lbl_minimizar";
            this.lbl_minimizar.Size = new System.Drawing.Size(18, 19);
            this.lbl_minimizar.TabIndex = 5;
            this.lbl_minimizar.Text = "_";
            this.lbl_minimizar.Click += new System.EventHandler(this.lbl_minimizar_Click);
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_cerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_cerrar.Location = new System.Drawing.Point(909, 4);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(20, 19);
            this.lbl_cerrar.TabIndex = 4;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(406, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Productos";
            // 
            // frm_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(939, 500);
            this.Controls.Add(this.pnl_centro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frm_producto_Load);
            this.pnl_centro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_paginacion.ResumeLayout(false);
            this.pnl_paginacion.PerformLayout();
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_exportar_excel;
        private System.Windows.Forms.DataGridView dtg_productos;
        private System.Windows.Forms.Label lbl_minimizar;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.ComboBox cbx_tipo_busqueda;
        private System.Windows.Forms.Button btn_producto_mas_vendido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_paginacion;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_ultima;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.TextBox txt_max_paginas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ultima_pagina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_paginas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_registros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_estado_stock;
        private System.Windows.Forms.Button btn_fecha_vencimiento;
        private System.Windows.Forms.ComboBox cbx_dato_busqueda;
    }
}