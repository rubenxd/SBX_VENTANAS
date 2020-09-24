namespace SBX
{
    partial class frm_ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ayuda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.lbl_minimixar = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.lbl_frm = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.cbx_dato_busqueda = new System.Windows.Forms.ComboBox();
            this.cbx_tipo_busqueda = new System.Windows.Forms.ComboBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_ayudas = new System.Windows.Forms.DataGridView();
            this.pnl_arriba.SuspendLayout();
            this.pnl_acciones.SuspendLayout();
            this.pnl_paginacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ayudas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.Color.DimGray;
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.lbl_minimixar);
            this.pnl_arriba.Controls.Add(this.lbl_cerrar);
            this.pnl_arriba.Controls.Add(this.lbl_frm);
            this.pnl_arriba.Controls.Add(this.lbl_titulo);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(830, 32);
            this.pnl_arriba.TabIndex = 0;
            this.pnl_arriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_arriba_MouseDown);
            // 
            // lbl_minimixar
            // 
            this.lbl_minimixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minimixar.AutoSize = true;
            this.lbl_minimixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minimixar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimixar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_minimixar.Location = new System.Drawing.Point(779, 2);
            this.lbl_minimixar.Name = "lbl_minimixar";
            this.lbl_minimixar.Size = new System.Drawing.Size(18, 19);
            this.lbl_minimixar.TabIndex = 3;
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
            this.lbl_cerrar.Location = new System.Drawing.Point(804, 7);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(17, 16);
            this.lbl_cerrar.TabIndex = 2;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // lbl_frm
            // 
            this.lbl_frm.AutoSize = true;
            this.lbl_frm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frm.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_frm.Location = new System.Drawing.Point(78, 5);
            this.lbl_frm.Name = "lbl_frm";
            this.lbl_frm.Size = new System.Drawing.Size(20, 17);
            this.lbl_frm.TabIndex = 1;
            this.lbl_frm.Text = "--";
            this.lbl_frm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_frm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_frm_MouseDown);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_titulo.Location = new System.Drawing.Point(8, 5);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(64, 17);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Ayuda -";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_titulo_MouseDown);
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
            this.btn_buscar.Location = new System.Drawing.Point(795, 9);
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
            this.txt_buscar.Location = new System.Drawing.Point(592, 11);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(197, 20);
            this.txt_buscar.TabIndex = 7;
            this.txt_buscar.Text = "Buscar";
            this.txt_buscar.Enter += new System.EventHandler(this.txt_buscar_Enter);
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            // 
            // pnl_acciones
            // 
            this.pnl_acciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_acciones.Controls.Add(this.cbx_dato_busqueda);
            this.pnl_acciones.Controls.Add(this.cbx_tipo_busqueda);
            this.pnl_acciones.Controls.Add(this.btn_buscar);
            this.pnl_acciones.Controls.Add(this.txt_buscar);
            this.pnl_acciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_acciones.Location = new System.Drawing.Point(0, 32);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Size = new System.Drawing.Size(830, 43);
            this.pnl_acciones.TabIndex = 9;
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
            this.cbx_dato_busqueda.Location = new System.Drawing.Point(416, 11);
            this.cbx_dato_busqueda.Name = "cbx_dato_busqueda";
            this.cbx_dato_busqueda.Size = new System.Drawing.Size(168, 21);
            this.cbx_dato_busqueda.TabIndex = 16;
            // 
            // cbx_tipo_busqueda
            // 
            this.cbx_tipo_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_busqueda.FormattingEnabled = true;
            this.cbx_tipo_busqueda.Items.AddRange(new object[] {
            "Contiene",
            "Exactamente"});
            this.cbx_tipo_busqueda.Location = new System.Drawing.Point(212, 11);
            this.cbx_tipo_busqueda.Name = "cbx_tipo_busqueda";
            this.cbx_tipo_busqueda.Size = new System.Drawing.Size(200, 21);
            this.cbx_tipo_busqueda.TabIndex = 15;
            this.cbx_tipo_busqueda.SelectedIndexChanged += new System.EventHandler(this.cbx_tipo_busqueda_SelectedIndexChanged);
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
            this.pnl_paginacion.Controls.Add(this.label1);
            this.pnl_paginacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_paginacion.Location = new System.Drawing.Point(0, 434);
            this.pnl_paginacion.Name = "pnl_paginacion";
            this.pnl_paginacion.Size = new System.Drawing.Size(830, 1);
            this.pnl_paginacion.TabIndex = 10;
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
            this.btn_actualizar.Location = new System.Drawing.Point(780, 8);
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
            this.btn_ultima.Location = new System.Drawing.Point(416, 5);
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
            this.btn_siguiente.Location = new System.Drawing.Point(373, 5);
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
            this.btn_atras.Location = new System.Drawing.Point(330, 5);
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
            this.btn_primero.Location = new System.Drawing.Point(291, 5);
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
            this.txt_max_paginas.Location = new System.Drawing.Point(707, 11);
            this.txt_max_paginas.Name = "txt_max_paginas";
            this.txt_max_paginas.Size = new System.Drawing.Size(56, 20);
            this.txt_max_paginas.TabIndex = 7;
            this.txt_max_paginas.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 14);
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
            this.lbl_ultima_pagina.Location = new System.Drawing.Point(551, 14);
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
            this.label4.Location = new System.Drawing.Point(468, 14);
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
            this.lbl_paginas.Location = new System.Drawing.Point(214, 14);
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
            this.label3.Location = new System.Drawing.Point(157, 14);
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
            this.lbl_registros.Location = new System.Drawing.Point(80, 14);
            this.lbl_registros.Name = "lbl_registros";
            this.lbl_registros.Size = new System.Drawing.Size(13, 13);
            this.lbl_registros.TabIndex = 1;
            this.lbl_registros.Text = "0";
            this.lbl_registros.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registros: ";
            this.label1.Visible = false;
            // 
            // dtg_ayudas
            // 
            this.dtg_ayudas.AllowUserToAddRows = false;
            this.dtg_ayudas.AllowUserToDeleteRows = false;
            this.dtg_ayudas.AllowUserToOrderColumns = true;
            this.dtg_ayudas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ayudas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_ayudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_ayudas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_ayudas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_ayudas.Location = new System.Drawing.Point(0, 75);
            this.dtg_ayudas.Name = "dtg_ayudas";
            this.dtg_ayudas.ReadOnly = true;
            this.dtg_ayudas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtg_ayudas.Size = new System.Drawing.Size(830, 359);
            this.dtg_ayudas.TabIndex = 11;
            this.dtg_ayudas.DoubleClick += new System.EventHandler(this.dtg_ayudas_DoubleClick);
            // 
            // frm_ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(830, 435);
            this.Controls.Add(this.dtg_ayudas);
            this.Controls.Add(this.pnl_paginacion);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ayuda";
            this.Load += new System.EventHandler(this.frm_ayuda_Load);
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            this.pnl_acciones.ResumeLayout(false);
            this.pnl_acciones.PerformLayout();
            this.pnl_paginacion.ResumeLayout(false);
            this.pnl_paginacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ayudas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_frm;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_minimixar;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.ComboBox cbx_tipo_busqueda;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_ayudas;
        private System.Windows.Forms.ComboBox cbx_dato_busqueda;
    }
}