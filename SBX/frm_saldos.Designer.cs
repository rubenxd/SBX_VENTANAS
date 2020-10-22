namespace SBX
{
    partial class frm_saldos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_saldos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cbx_tipo_busqueda = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_exportar_excel = new System.Windows.Forms.Button();
            this.dtg_saldos = new System.Windows.Forms.DataGridView();
            this.dtg_productos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnl_paginacion.SuspendLayout();
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_saldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_paginacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 45);
            this.panel1.TabIndex = 11;
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
            this.pnl_paginacion.Location = new System.Drawing.Point(0, 3);
            this.pnl_paginacion.Name = "pnl_paginacion";
            this.pnl_paginacion.Size = new System.Drawing.Size(992, 42);
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
            this.btn_actualizar.Location = new System.Drawing.Point(852, 8);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(25, 25);
            this.btn_actualizar.TabIndex = 15;
            this.btn_actualizar.UseVisualStyleBackColor = false;
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
            this.btn_ultima.Location = new System.Drawing.Point(488, 5);
            this.btn_ultima.Name = "btn_ultima";
            this.btn_ultima.Size = new System.Drawing.Size(30, 30);
            this.btn_ultima.TabIndex = 14;
            this.btn_ultima.UseVisualStyleBackColor = false;
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
            this.btn_siguiente.Location = new System.Drawing.Point(445, 5);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(30, 30);
            this.btn_siguiente.TabIndex = 13;
            this.btn_siguiente.UseVisualStyleBackColor = false;
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
            this.btn_atras.Location = new System.Drawing.Point(402, 5);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(30, 30);
            this.btn_atras.TabIndex = 12;
            this.btn_atras.UseVisualStyleBackColor = false;
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
            this.btn_primero.Location = new System.Drawing.Point(363, 5);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(30, 30);
            this.btn_primero.TabIndex = 11;
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // txt_max_paginas
            // 
            this.txt_max_paginas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_max_paginas.Location = new System.Drawing.Point(779, 11);
            this.txt_max_paginas.Name = "txt_max_paginas";
            this.txt_max_paginas.Size = new System.Drawing.Size(56, 20);
            this.txt_max_paginas.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Maximo paginas: ";
            // 
            // lbl_ultima_pagina
            // 
            this.lbl_ultima_pagina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ultima_pagina.AutoSize = true;
            this.lbl_ultima_pagina.Location = new System.Drawing.Point(623, 14);
            this.lbl_ultima_pagina.Name = "lbl_ultima_pagina";
            this.lbl_ultima_pagina.Size = new System.Drawing.Size(13, 13);
            this.lbl_ultima_pagina.TabIndex = 5;
            this.lbl_ultima_pagina.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ultima pagina: ";
            // 
            // lbl_paginas
            // 
            this.lbl_paginas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_paginas.AutoSize = true;
            this.lbl_paginas.Location = new System.Drawing.Point(286, 14);
            this.lbl_paginas.Name = "lbl_paginas";
            this.lbl_paginas.Size = new System.Drawing.Size(13, 13);
            this.lbl_paginas.TabIndex = 3;
            this.lbl_paginas.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paginas: ";
            // 
            // lbl_registros
            // 
            this.lbl_registros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_registros.AutoSize = true;
            this.lbl_registros.Location = new System.Drawing.Point(152, 14);
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
            this.label2.Location = new System.Drawing.Point(89, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registros: ";
            this.label2.Visible = false;
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.cbx_dato_busqueda);
            this.pnl_arriba.Controls.Add(this.cbx_tipo_busqueda);
            this.pnl_arriba.Controls.Add(this.btn_buscar);
            this.pnl_arriba.Controls.Add(this.txt_buscar);
            this.pnl_arriba.Controls.Add(this.btn_exportar_excel);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(992, 42);
            this.pnl_arriba.TabIndex = 10;
            // 
            // cbx_dato_busqueda
            // 
            this.cbx_dato_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_dato_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_dato_busqueda.FormattingEnabled = true;
            this.cbx_dato_busqueda.Items.AddRange(new object[] {
            "Nombre",
            "Item",
            "Referencia",
            "Codigo Barras"});
            this.cbx_dato_busqueda.Location = new System.Drawing.Point(536, 8);
            this.cbx_dato_busqueda.Name = "cbx_dato_busqueda";
            this.cbx_dato_busqueda.Size = new System.Drawing.Size(168, 21);
            this.cbx_dato_busqueda.TabIndex = 20;
            // 
            // cbx_tipo_busqueda
            // 
            this.cbx_tipo_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tipo_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_busqueda.FormattingEnabled = true;
            this.cbx_tipo_busqueda.Items.AddRange(new object[] {
            "Contiene",
            "Exactamente"});
            this.cbx_tipo_busqueda.Location = new System.Drawing.Point(402, 8);
            this.cbx_tipo_busqueda.Name = "cbx_tipo_busqueda";
            this.cbx_tipo_busqueda.Size = new System.Drawing.Size(123, 21);
            this.cbx_tipo_busqueda.TabIndex = 16;
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
            this.btn_buscar.Location = new System.Drawing.Point(955, 8);
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
            this.txt_buscar.Location = new System.Drawing.Point(710, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(239, 20);
            this.txt_buscar.TabIndex = 7;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
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
            // 
            // dtg_saldos
            // 
            this.dtg_saldos.AllowUserToAddRows = false;
            this.dtg_saldos.AllowUserToDeleteRows = false;
            this.dtg_saldos.AllowUserToOrderColumns = true;
            this.dtg_saldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_saldos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_saldos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_saldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_saldos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_saldos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_saldos.Location = new System.Drawing.Point(0, 381);
            this.dtg_saldos.Name = "dtg_saldos";
            this.dtg_saldos.ReadOnly = true;
            this.dtg_saldos.Size = new System.Drawing.Size(992, 63);
            this.dtg_saldos.TabIndex = 13;
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
            this.dtg_productos.Size = new System.Drawing.Size(992, 339);
            this.dtg_productos.TabIndex = 14;
            // 
            // frm_saldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 489);
            this.Controls.Add(this.dtg_productos);
            this.Controls.Add(this.dtg_saldos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_arriba);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_saldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldos";
            this.Load += new System.EventHandler(this.frm_saldos_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_paginacion.ResumeLayout(false);
            this.pnl_paginacion.PerformLayout();
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_saldos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.ComboBox cbx_dato_busqueda;
        private System.Windows.Forms.ComboBox cbx_tipo_busqueda;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_exportar_excel;
        private System.Windows.Forms.DataGridView dtg_saldos;
        private System.Windows.Forms.DataGridView dtg_productos;
    }
}