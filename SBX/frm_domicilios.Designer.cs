namespace SBX
{
    partial class frm_domicilios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_domicilios));
            this.dtg_domicilio = new System.Windows.Forms.DataGridView();
            this.cl_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_mensajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor_domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.btn_pago_domicilio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.cbx_tipo_busqueda = new System.Windows.Forms.ComboBox();
            this.btn_mensajero = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_exportar_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_domicilio)).BeginInit();
            this.pnl_arriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_domicilio
            // 
            this.dtg_domicilio.AllowUserToAddRows = false;
            this.dtg_domicilio.AllowUserToDeleteRows = false;
            this.dtg_domicilio.AllowUserToOrderColumns = true;
            this.dtg_domicilio.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_domicilio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_domicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_domicilio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_numero,
            this.cl_fecha,
            this.cl_estado,
            this.cl_celular,
            this.cl_dni,
            this.cl_nombre,
            this.cl_direccion,
            this.cl_mensajero,
            this.cl_factura,
            this.cl_item,
            this.cl_referencia,
            this.cl_codigo_barras,
            this.cl_nombre_producto,
            this.cl_cantidad,
            this.cl_um,
            this.cl_precio,
            this.cl_descuento,
            this.cl_valor_descuento,
            this.cl_valor_domicilio,
            this.cl_total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_domicilio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_domicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_domicilio.Location = new System.Drawing.Point(0, 42);
            this.dtg_domicilio.Name = "dtg_domicilio";
            this.dtg_domicilio.ReadOnly = true;
            this.dtg_domicilio.Size = new System.Drawing.Size(900, 430);
            this.dtg_domicilio.TabIndex = 7;
            // 
            // cl_numero
            // 
            this.cl_numero.HeaderText = "Num";
            this.cl_numero.Name = "cl_numero";
            this.cl_numero.ReadOnly = true;
            this.cl_numero.Width = 50;
            // 
            // cl_fecha
            // 
            this.cl_fecha.HeaderText = "Fecha";
            this.cl_fecha.Name = "cl_fecha";
            this.cl_fecha.ReadOnly = true;
            // 
            // cl_estado
            // 
            this.cl_estado.HeaderText = "Estado";
            this.cl_estado.Name = "cl_estado";
            this.cl_estado.ReadOnly = true;
            // 
            // cl_celular
            // 
            this.cl_celular.HeaderText = "Celular";
            this.cl_celular.Name = "cl_celular";
            this.cl_celular.ReadOnly = true;
            // 
            // cl_dni
            // 
            this.cl_dni.HeaderText = "DNI";
            this.cl_dni.Name = "cl_dni";
            this.cl_dni.ReadOnly = true;
            // 
            // cl_nombre
            // 
            this.cl_nombre.HeaderText = "Nombre";
            this.cl_nombre.Name = "cl_nombre";
            this.cl_nombre.ReadOnly = true;
            // 
            // cl_direccion
            // 
            this.cl_direccion.HeaderText = "Direccion";
            this.cl_direccion.Name = "cl_direccion";
            this.cl_direccion.ReadOnly = true;
            // 
            // cl_mensajero
            // 
            this.cl_mensajero.HeaderText = "Mensajero";
            this.cl_mensajero.Name = "cl_mensajero";
            this.cl_mensajero.ReadOnly = true;
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
            // cl_referencia
            // 
            this.cl_referencia.HeaderText = "Referencia";
            this.cl_referencia.Name = "cl_referencia";
            this.cl_referencia.ReadOnly = true;
            // 
            // cl_codigo_barras
            // 
            this.cl_codigo_barras.HeaderText = "Codigo barras";
            this.cl_codigo_barras.Name = "cl_codigo_barras";
            this.cl_codigo_barras.ReadOnly = true;
            // 
            // cl_nombre_producto
            // 
            this.cl_nombre_producto.HeaderText = "Nombre Producto";
            this.cl_nombre_producto.Name = "cl_nombre_producto";
            this.cl_nombre_producto.ReadOnly = true;
            // 
            // cl_cantidad
            // 
            this.cl_cantidad.HeaderText = "Cantidad";
            this.cl_cantidad.Name = "cl_cantidad";
            this.cl_cantidad.ReadOnly = true;
            // 
            // cl_um
            // 
            this.cl_um.HeaderText = "UM";
            this.cl_um.Name = "cl_um";
            this.cl_um.ReadOnly = true;
            // 
            // cl_precio
            // 
            this.cl_precio.HeaderText = "Precio";
            this.cl_precio.Name = "cl_precio";
            this.cl_precio.ReadOnly = true;
            // 
            // cl_descuento
            // 
            this.cl_descuento.HeaderText = "% desc";
            this.cl_descuento.Name = "cl_descuento";
            this.cl_descuento.ReadOnly = true;
            // 
            // cl_valor_descuento
            // 
            this.cl_valor_descuento.HeaderText = "Valor Descuento";
            this.cl_valor_descuento.Name = "cl_valor_descuento";
            this.cl_valor_descuento.ReadOnly = true;
            // 
            // cl_valor_domicilio
            // 
            this.cl_valor_domicilio.HeaderText = "Valor Domicilio";
            this.cl_valor_domicilio.Name = "cl_valor_domicilio";
            this.cl_valor_domicilio.ReadOnly = true;
            // 
            // cl_total
            // 
            this.cl_total.HeaderText = "Total";
            this.cl_total.Name = "cl_total";
            this.cl_total.ReadOnly = true;
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.btn_pago_domicilio);
            this.pnl_arriba.Controls.Add(this.label3);
            this.pnl_arriba.Controls.Add(this.label2);
            this.pnl_arriba.Controls.Add(this.dtp_fecha_fin);
            this.pnl_arriba.Controls.Add(this.dtp_fecha_inicio);
            this.pnl_arriba.Controls.Add(this.cbx_tipo_busqueda);
            this.pnl_arriba.Controls.Add(this.btn_mensajero);
            this.pnl_arriba.Controls.Add(this.btn_eliminar);
            this.pnl_arriba.Controls.Add(this.btn_buscar);
            this.pnl_arriba.Controls.Add(this.txt_buscar);
            this.pnl_arriba.Controls.Add(this.btn_exportar_excel);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(900, 42);
            this.pnl_arriba.TabIndex = 6;
            // 
            // btn_pago_domicilio
            // 
            this.btn_pago_domicilio.BackColor = System.Drawing.Color.White;
            this.btn_pago_domicilio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pago_domicilio.Enabled = false;
            this.btn_pago_domicilio.FlatAppearance.BorderSize = 0;
            this.btn_pago_domicilio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_pago_domicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pago_domicilio.Image = ((System.Drawing.Image)(resources.GetObject("btn_pago_domicilio.Image")));
            this.btn_pago_domicilio.Location = new System.Drawing.Point(75, 6);
            this.btn_pago_domicilio.Name = "btn_pago_domicilio";
            this.btn_pago_domicilio.Size = new System.Drawing.Size(26, 26);
            this.btn_pago_domicilio.TabIndex = 81;
            this.btn_pago_domicilio.UseVisualStyleBackColor = false;
            this.btn_pago_domicilio.Click += new System.EventHandler(this.btn_pago_domicilio_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 12);
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
            this.label2.Location = new System.Drawing.Point(371, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 79;
            this.label2.Text = "F. Fin:";
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_fin.Location = new System.Drawing.Point(415, 10);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_fin.TabIndex = 78;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(244, 10);
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
            this.cbx_tipo_busqueda.Location = new System.Drawing.Point(531, 10);
            this.cbx_tipo_busqueda.Name = "cbx_tipo_busqueda";
            this.cbx_tipo_busqueda.Size = new System.Drawing.Size(85, 21);
            this.cbx_tipo_busqueda.TabIndex = 76;
            // 
            // btn_mensajero
            // 
            this.btn_mensajero.BackColor = System.Drawing.Color.White;
            this.btn_mensajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mensajero.Enabled = false;
            this.btn_mensajero.FlatAppearance.BorderSize = 0;
            this.btn_mensajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_mensajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mensajero.Image = ((System.Drawing.Image)(resources.GetObject("btn_mensajero.Image")));
            this.btn_mensajero.Location = new System.Drawing.Point(107, 6);
            this.btn_mensajero.Name = "btn_mensajero";
            this.btn_mensajero.Size = new System.Drawing.Size(26, 26);
            this.btn_mensajero.TabIndex = 75;
            this.btn_mensajero.UseVisualStyleBackColor = false;
            this.btn_mensajero.Click += new System.EventHandler(this.btn_mensajero_Click);
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
            this.btn_buscar.Location = new System.Drawing.Point(867, 8);
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
            this.txt_buscar.Location = new System.Drawing.Point(622, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(239, 20);
            this.txt_buscar.TabIndex = 7;
            this.txt_buscar.Text = "Num-Celular-DNI-Mensajero-Producto";
            this.txt_buscar.Enter += new System.EventHandler(this.txt_buscar_Enter);
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
            // frm_domicilios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(900, 472);
            this.Controls.Add(this.dtg_domicilio);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_domicilios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_domicilios";
            this.Load += new System.EventHandler(this.frm_domicilios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_domicilio)).EndInit();
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_domicilio;
        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_exportar_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_mensajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_um;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor_domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_total;
        private System.Windows.Forms.Button btn_mensajero;
        private System.Windows.Forms.ComboBox cbx_tipo_busqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Button btn_pago_domicilio;
    }
}