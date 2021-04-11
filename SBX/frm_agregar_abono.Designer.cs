namespace SBX
{
    partial class frm_agregar_abono
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_agregar_abono));
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.pnl_info = new System.Windows.Forms.Panel();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_fecha_fin = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_fecha_inicio = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_pagado = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_valor_cuota = new System.Windows.Forms.Label();
            this.lbl_num_cuotas = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_num_separado = new System.Windows.Forms.Label();
            this.dtg_productos = new System.Windows.Forms.DataGridView();
            this.cl_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ver_productos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_abajo = new System.Windows.Forms.Panel();
            this.lbl_cuota_num = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_abono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_arriba.SuspendLayout();
            this.pnl_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productos)).BeginInit();
            this.pnl_abajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.Color.DimGray;
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.label1);
            this.pnl_arriba.Controls.Add(this.lbl_cerrar);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(358, 28);
            this.pnl_arriba.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abonos";
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_cerrar.Location = new System.Drawing.Point(331, 3);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(17, 16);
            this.lbl_cerrar.TabIndex = 0;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // pnl_info
            // 
            this.pnl_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_info.Controls.Add(this.lbl_estado);
            this.pnl_info.Controls.Add(this.lbl_fecha_fin);
            this.pnl_info.Controls.Add(this.label14);
            this.pnl_info.Controls.Add(this.lbl_fecha_inicio);
            this.pnl_info.Controls.Add(this.label12);
            this.pnl_info.Controls.Add(this.lbl_pagado);
            this.pnl_info.Controls.Add(this.label11);
            this.pnl_info.Controls.Add(this.lbl_saldo);
            this.pnl_info.Controls.Add(this.lbl_valor_cuota);
            this.pnl_info.Controls.Add(this.lbl_num_cuotas);
            this.pnl_info.Controls.Add(this.lbl_valor);
            this.pnl_info.Controls.Add(this.lbl_cliente);
            this.pnl_info.Controls.Add(this.lbl_num_separado);
            this.pnl_info.Controls.Add(this.dtg_productos);
            this.pnl_info.Controls.Add(this.btn_ver_productos);
            this.pnl_info.Controls.Add(this.label8);
            this.pnl_info.Controls.Add(this.label6);
            this.pnl_info.Controls.Add(this.label5);
            this.pnl_info.Controls.Add(this.label4);
            this.pnl_info.Controls.Add(this.label3);
            this.pnl_info.Controls.Add(this.label2);
            this.pnl_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_info.Location = new System.Drawing.Point(0, 28);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(358, 260);
            this.pnl_info.TabIndex = 8;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(285, 234);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(64, 13);
            this.lbl_estado.TabIndex = 35;
            this.lbl_estado.Text = "Pendiente";
            // 
            // lbl_fecha_fin
            // 
            this.lbl_fecha_fin.AutoSize = true;
            this.lbl_fecha_fin.Location = new System.Drawing.Point(112, 203);
            this.lbl_fecha_fin.Name = "lbl_fecha_fin";
            this.lbl_fecha_fin.Size = new System.Drawing.Size(13, 13);
            this.lbl_fecha_fin.TabIndex = 34;
            this.lbl_fecha_fin.Text = "--";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Fecha Fin:";
            // 
            // lbl_fecha_inicio
            // 
            this.lbl_fecha_inicio.AutoSize = true;
            this.lbl_fecha_inicio.Location = new System.Drawing.Point(112, 180);
            this.lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            this.lbl_fecha_inicio.Size = new System.Drawing.Size(13, 13);
            this.lbl_fecha_inicio.TabIndex = 32;
            this.lbl_fecha_inicio.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Fecha inicio:";
            // 
            // lbl_pagado
            // 
            this.lbl_pagado.AutoSize = true;
            this.lbl_pagado.Location = new System.Drawing.Point(112, 135);
            this.lbl_pagado.Name = "lbl_pagado";
            this.lbl_pagado.Size = new System.Drawing.Size(13, 13);
            this.lbl_pagado.TabIndex = 30;
            this.lbl_pagado.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Pagado: ";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(112, 158);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(13, 13);
            this.lbl_saldo.TabIndex = 28;
            this.lbl_saldo.Text = "--";
            // 
            // lbl_valor_cuota
            // 
            this.lbl_valor_cuota.AutoSize = true;
            this.lbl_valor_cuota.Location = new System.Drawing.Point(112, 113);
            this.lbl_valor_cuota.Name = "lbl_valor_cuota";
            this.lbl_valor_cuota.Size = new System.Drawing.Size(13, 13);
            this.lbl_valor_cuota.TabIndex = 27;
            this.lbl_valor_cuota.Text = "--";
            // 
            // lbl_num_cuotas
            // 
            this.lbl_num_cuotas.AutoSize = true;
            this.lbl_num_cuotas.Location = new System.Drawing.Point(112, 87);
            this.lbl_num_cuotas.Name = "lbl_num_cuotas";
            this.lbl_num_cuotas.Size = new System.Drawing.Size(13, 13);
            this.lbl_num_cuotas.TabIndex = 26;
            this.lbl_num_cuotas.Text = "--";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(112, 62);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(13, 13);
            this.lbl_valor.TabIndex = 25;
            this.lbl_valor.Text = "--";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(112, 38);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(13, 13);
            this.lbl_cliente.TabIndex = 24;
            this.lbl_cliente.Text = "--";
            // 
            // lbl_num_separado
            // 
            this.lbl_num_separado.AutoSize = true;
            this.lbl_num_separado.Location = new System.Drawing.Point(112, 13);
            this.lbl_num_separado.Name = "lbl_num_separado";
            this.lbl_num_separado.Size = new System.Drawing.Size(13, 13);
            this.lbl_num_separado.TabIndex = 23;
            this.lbl_num_separado.Text = "--";
            // 
            // dtg_productos
            // 
            this.dtg_productos.AllowUserToAddRows = false;
            this.dtg_productos.AllowUserToDeleteRows = false;
            this.dtg_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_producto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_productos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_productos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_productos.Location = new System.Drawing.Point(0, 258);
            this.dtg_productos.Name = "dtg_productos";
            this.dtg_productos.ReadOnly = true;
            this.dtg_productos.Size = new System.Drawing.Size(356, 0);
            this.dtg_productos.TabIndex = 22;
            // 
            // cl_producto
            // 
            this.cl_producto.HeaderText = "Producto";
            this.cl_producto.Name = "cl_producto";
            this.cl_producto.ReadOnly = true;
            // 
            // btn_ver_productos
            // 
            this.btn_ver_productos.BackColor = System.Drawing.Color.DimGray;
            this.btn_ver_productos.FlatAppearance.BorderSize = 0;
            this.btn_ver_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ver_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_productos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_productos.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ver_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ver_productos.Location = new System.Drawing.Point(7, 227);
            this.btn_ver_productos.Name = "btn_ver_productos";
            this.btn_ver_productos.Size = new System.Drawing.Size(119, 27);
            this.btn_ver_productos.TabIndex = 21;
            this.btn_ver_productos.Text = "Ver productos";
            this.btn_ver_productos.UseVisualStyleBackColor = false;
            this.btn_ver_productos.Click += new System.EventHandler(this.btn_ver_productos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Saldo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor Cuota: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numero cuotas: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero: ";
            // 
            // pnl_abajo
            // 
            this.pnl_abajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_abajo.Controls.Add(this.lbl_cuota_num);
            this.pnl_abajo.Controls.Add(this.btn_cancelar);
            this.pnl_abajo.Controls.Add(this.btn_aceptar);
            this.pnl_abajo.Controls.Add(this.label9);
            this.pnl_abajo.Controls.Add(this.txt_abono);
            this.pnl_abajo.Controls.Add(this.label7);
            this.pnl_abajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_abajo.Location = new System.Drawing.Point(0, 288);
            this.pnl_abajo.Name = "pnl_abajo";
            this.pnl_abajo.Size = new System.Drawing.Size(358, 115);
            this.pnl_abajo.TabIndex = 9;
            // 
            // lbl_cuota_num
            // 
            this.lbl_cuota_num.AutoSize = true;
            this.lbl_cuota_num.Location = new System.Drawing.Point(95, 11);
            this.lbl_cuota_num.Name = "lbl_cuota_num";
            this.lbl_cuota_num.Size = new System.Drawing.Size(13, 13);
            this.lbl_cuota_num.TabIndex = 29;
            this.lbl_cuota_num.Text = "--";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(179, 78);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(80, 30);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.DimGray;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(107, 78);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(66, 30);
            this.btn_aceptar.TabIndex = 24;
            this.btn_aceptar.Text = "Guardar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Abonar: ";
            // 
            // txt_abono
            // 
            this.txt_abono.Location = new System.Drawing.Point(96, 40);
            this.txt_abono.Name = "txt_abono";
            this.txt_abono.Size = new System.Drawing.Size(189, 20);
            this.txt_abono.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cuota Numero: ";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frm_agregar_abono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(358, 403);
            this.Controls.Add(this.pnl_abajo);
            this.Controls.Add(this.pnl_info);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_agregar_abono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_agregar_abono";
            this.Load += new System.EventHandler(this.frm_agregar_abono_Load);
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            this.pnl_info.ResumeLayout(false);
            this.pnl_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productos)).EndInit();
            this.pnl_abajo.ResumeLayout(false);
            this.pnl_abajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.Panel pnl_info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ver_productos;
        private System.Windows.Forms.DataGridView dtg_productos;
        private System.Windows.Forms.Panel pnl_abajo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_abono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_producto;
        public System.Windows.Forms.Label lbl_num_separado;
        public System.Windows.Forms.Label lbl_saldo;
        public System.Windows.Forms.Label lbl_valor_cuota;
        public System.Windows.Forms.Label lbl_num_cuotas;
        public System.Windows.Forms.Label lbl_valor;
        public System.Windows.Forms.Label lbl_cliente;
        public System.Windows.Forms.Label lbl_cuota_num;
        public System.Windows.Forms.Label lbl_pagado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.Label lbl_fecha_inicio;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lbl_fecha_fin;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lbl_estado;
    }
}