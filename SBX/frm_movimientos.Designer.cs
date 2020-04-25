namespace SBX
{
    partial class frm_movimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_movimientos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_minimixar = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.cbx_tipo_busqueda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_exportar_excel = new System.Windows.Forms.Button();
            this.dtg_movimientos = new System.Windows.Forms.DataGridView();
            this.cl_codigo_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_fecha_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_modo_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_movimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_minimixar);
            this.panel1.Controls.Add(this.lbl_cerrar);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 32);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lbl_minimixar
            // 
            this.lbl_minimixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minimixar.AutoSize = true;
            this.lbl_minimixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minimixar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimixar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_minimixar.Location = new System.Drawing.Point(836, 1);
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
            this.lbl_cerrar.Location = new System.Drawing.Point(864, 6);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(17, 16);
            this.lbl_cerrar.TabIndex = 2;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_titulo.Location = new System.Drawing.Point(6, 5);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(97, 17);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Movimientos";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_titulo_MouseDown);
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.cbx_tipo_busqueda);
            this.pnl_arriba.Controls.Add(this.label3);
            this.pnl_arriba.Controls.Add(this.label2);
            this.pnl_arriba.Controls.Add(this.dtp_fecha_fin);
            this.pnl_arriba.Controls.Add(this.dtp_fecha_inicio);
            this.pnl_arriba.Controls.Add(this.btn_buscar);
            this.pnl_arriba.Controls.Add(this.txt_buscar);
            this.pnl_arriba.Controls.Add(this.btn_exportar_excel);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 32);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(889, 42);
            this.pnl_arriba.TabIndex = 9;
            // 
            // cbx_tipo_busqueda
            // 
            this.cbx_tipo_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tipo_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_busqueda.FormattingEnabled = true;
            this.cbx_tipo_busqueda.Items.AddRange(new object[] {
            "Contiene",
            "Exactamente"});
            this.cbx_tipo_busqueda.Location = new System.Drawing.Point(479, 9);
            this.cbx_tipo_busqueda.Name = "cbx_tipo_busqueda";
            this.cbx_tipo_busqueda.Size = new System.Drawing.Size(85, 21);
            this.cbx_tipo_busqueda.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "F. Inicio:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "F. Fin:";
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_fin.Location = new System.Drawing.Point(358, 10);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_fin.TabIndex = 11;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(187, 10);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_inicio.TabIndex = 10;
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
            this.btn_buscar.Location = new System.Drawing.Point(856, 8);
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
            this.txt_buscar.Location = new System.Drawing.Point(573, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(277, 20);
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
            this.btn_exportar_excel.FlatAppearance.BorderSize = 0;
            this.btn_exportar_excel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_exportar_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar_excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportar_excel.Image")));
            this.btn_exportar_excel.Location = new System.Drawing.Point(5, 6);
            this.btn_exportar_excel.Name = "btn_exportar_excel";
            this.btn_exportar_excel.Size = new System.Drawing.Size(26, 26);
            this.btn_exportar_excel.TabIndex = 2;
            this.btn_exportar_excel.UseVisualStyleBackColor = false;
            this.btn_exportar_excel.Click += new System.EventHandler(this.btn_exportar_excel_Click);
            // 
            // dtg_movimientos
            // 
            this.dtg_movimientos.AllowUserToAddRows = false;
            this.dtg_movimientos.AllowUserToDeleteRows = false;
            this.dtg_movimientos.AllowUserToOrderColumns = true;
            this.dtg_movimientos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_movimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_movimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_codigo_movimiento,
            this.cl_fecha_registro,
            this.cl_movimiento,
            this.cl_item,
            this.cl_nombre,
            this.cl_referencia,
            this.cl_Codigo_barras,
            this.cl_modo_venta,
            this.cl_UM,
            this.cl_cantidad,
            this.cl_costo,
            this.cl_precio_venta,
            this.cl_nota,
            this.cl_dni,
            this.cl_proveedor,
            this.cl_accion,
            this.cl_usuario});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_movimientos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_movimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_movimientos.Location = new System.Drawing.Point(0, 74);
            this.dtg_movimientos.Name = "dtg_movimientos";
            this.dtg_movimientos.Size = new System.Drawing.Size(889, 426);
            this.dtg_movimientos.TabIndex = 10;
            // 
            // cl_codigo_movimiento
            // 
            this.cl_codigo_movimiento.HeaderText = "Codigo";
            this.cl_codigo_movimiento.Name = "cl_codigo_movimiento";
            this.cl_codigo_movimiento.Visible = false;
            // 
            // cl_fecha_registro
            // 
            this.cl_fecha_registro.HeaderText = "Fecha registro";
            this.cl_fecha_registro.Name = "cl_fecha_registro";
            this.cl_fecha_registro.ReadOnly = true;
            this.cl_fecha_registro.Width = 120;
            // 
            // cl_movimiento
            // 
            this.cl_movimiento.HeaderText = "Movimiento";
            this.cl_movimiento.Name = "cl_movimiento";
            this.cl_movimiento.ReadOnly = true;
            this.cl_movimiento.Width = 80;
            // 
            // cl_item
            // 
            this.cl_item.HeaderText = "Item";
            this.cl_item.Name = "cl_item";
            this.cl_item.ReadOnly = true;
            this.cl_item.Width = 80;
            // 
            // cl_nombre
            // 
            this.cl_nombre.HeaderText = "Nombre";
            this.cl_nombre.Name = "cl_nombre";
            this.cl_nombre.ReadOnly = true;
            this.cl_nombre.Width = 250;
            // 
            // cl_referencia
            // 
            this.cl_referencia.HeaderText = "Referencia";
            this.cl_referencia.Name = "cl_referencia";
            this.cl_referencia.ReadOnly = true;
            // 
            // cl_Codigo_barras
            // 
            this.cl_Codigo_barras.HeaderText = "Codigo barras";
            this.cl_Codigo_barras.Name = "cl_Codigo_barras";
            this.cl_Codigo_barras.ReadOnly = true;
            this.cl_Codigo_barras.Width = 110;
            // 
            // cl_modo_venta
            // 
            this.cl_modo_venta.HeaderText = "Modo venta";
            this.cl_modo_venta.Name = "cl_modo_venta";
            // 
            // cl_UM
            // 
            this.cl_UM.HeaderText = "UM";
            this.cl_UM.Name = "cl_UM";
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
            this.cl_precio_venta.Width = 110;
            // 
            // cl_nota
            // 
            this.cl_nota.HeaderText = "Nota";
            this.cl_nota.Name = "cl_nota";
            // 
            // cl_dni
            // 
            this.cl_dni.HeaderText = "DNI";
            this.cl_dni.Name = "cl_dni";
            this.cl_dni.ReadOnly = true;
            // 
            // cl_proveedor
            // 
            this.cl_proveedor.HeaderText = "Proveedor";
            this.cl_proveedor.Name = "cl_proveedor";
            this.cl_proveedor.ReadOnly = true;
            // 
            // cl_accion
            // 
            this.cl_accion.HeaderText = "Accion";
            this.cl_accion.Name = "cl_accion";
            this.cl_accion.ReadOnly = true;
            // 
            // cl_usuario
            // 
            this.cl_usuario.HeaderText = "Usuario";
            this.cl_usuario.Name = "cl_usuario";
            // 
            // frm_movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(889, 500);
            this.Controls.Add(this.dtg_movimientos);
            this.Controls.Add(this.pnl_arriba);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_movimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_movimientos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_movimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_exportar_excel;
        private System.Windows.Forms.DataGridView dtg_movimientos;
        private System.Windows.Forms.ComboBox cbx_tipo_busqueda;
        private System.Windows.Forms.Label lbl_minimixar;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fecha_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_modo_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_usuario;
    }
}