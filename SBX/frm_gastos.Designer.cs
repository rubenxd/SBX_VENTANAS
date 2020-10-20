namespace SBX
{
    partial class frm_gastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gastos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_agregar_gastos = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_exportar_excel = new System.Windows.Forms.Button();
            this.dtg_gastos = new System.Windows.Forms.DataGridView();
            this.cl_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_id_gasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_desc_gasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor_iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_abajo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_valorMasIVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total_iva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_gastos)).BeginInit();
            this.pnl_abajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.label3);
            this.pnl_arriba.Controls.Add(this.label2);
            this.pnl_arriba.Controls.Add(this.dtp_fecha_fin);
            this.pnl_arriba.Controls.Add(this.dtp_fecha_inicio);
            this.pnl_arriba.Controls.Add(this.btn_agregar_gastos);
            this.pnl_arriba.Controls.Add(this.btn_agregar);
            this.pnl_arriba.Controls.Add(this.btn_eliminar);
            this.pnl_arriba.Controls.Add(this.btn_buscar);
            this.pnl_arriba.Controls.Add(this.txt_buscar);
            this.pnl_arriba.Controls.Add(this.btn_exportar_excel);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(784, 42);
            this.pnl_arriba.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "F. Inicio:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "F. Fin:";
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_fin.Location = new System.Drawing.Point(467, 10);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_fin.TabIndex = 21;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(296, 10);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_inicio.TabIndex = 20;
            // 
            // btn_agregar_gastos
            // 
            this.btn_agregar_gastos.BackColor = System.Drawing.SystemColors.Window;
            this.btn_agregar_gastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_gastos.Enabled = false;
            this.btn_agregar_gastos.FlatAppearance.BorderSize = 0;
            this.btn_agregar_gastos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_agregar_gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_gastos.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar_gastos.Image")));
            this.btn_agregar_gastos.Location = new System.Drawing.Point(110, 6);
            this.btn_agregar_gastos.Name = "btn_agregar_gastos";
            this.btn_agregar_gastos.Size = new System.Drawing.Size(26, 26);
            this.btn_agregar_gastos.TabIndex = 19;
            this.btn_agregar_gastos.UseVisualStyleBackColor = false;
            this.btn_agregar_gastos.Click += new System.EventHandler(this.btn_agregar_gastos_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Enabled = false;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.Location = new System.Drawing.Point(78, 6);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(26, 26);
            this.btn_agregar.TabIndex = 18;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
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
            this.btn_eliminar.Location = new System.Drawing.Point(46, 6);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(26, 26);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
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
            this.btn_buscar.Location = new System.Drawing.Point(751, 8);
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
            this.txt_buscar.Location = new System.Drawing.Point(587, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(158, 20);
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
            this.btn_exportar_excel.Click += new System.EventHandler(this.btn_exportar_excel_Click);
            // 
            // dtg_gastos
            // 
            this.dtg_gastos.AllowUserToAddRows = false;
            this.dtg_gastos.AllowUserToDeleteRows = false;
            this.dtg_gastos.AllowUserToOrderColumns = true;
            this.dtg_gastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_gastos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_gastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_gastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_fecha,
            this.cl_id_gasto,
            this.cl_desc_gasto,
            this.cl_valor,
            this.cl_proveedor,
            this.cl_valor_iva});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_gastos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_gastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_gastos.Location = new System.Drawing.Point(0, 42);
            this.dtg_gastos.Name = "dtg_gastos";
            this.dtg_gastos.ReadOnly = true;
            this.dtg_gastos.Size = new System.Drawing.Size(784, 393);
            this.dtg_gastos.TabIndex = 7;
            // 
            // cl_fecha
            // 
            this.cl_fecha.HeaderText = "Fecha";
            this.cl_fecha.Name = "cl_fecha";
            this.cl_fecha.ReadOnly = true;
            // 
            // cl_id_gasto
            // 
            this.cl_id_gasto.HeaderText = "Codigo";
            this.cl_id_gasto.Name = "cl_id_gasto";
            this.cl_id_gasto.ReadOnly = true;
            // 
            // cl_desc_gasto
            // 
            this.cl_desc_gasto.HeaderText = "Desc. Gasto";
            this.cl_desc_gasto.Name = "cl_desc_gasto";
            this.cl_desc_gasto.ReadOnly = true;
            // 
            // cl_valor
            // 
            this.cl_valor.HeaderText = "Valor";
            this.cl_valor.Name = "cl_valor";
            this.cl_valor.ReadOnly = true;
            // 
            // cl_proveedor
            // 
            this.cl_proveedor.HeaderText = "Proveedor";
            this.cl_proveedor.Name = "cl_proveedor";
            this.cl_proveedor.ReadOnly = true;
            // 
            // cl_valor_iva
            // 
            this.cl_valor_iva.HeaderText = "Valor IVA";
            this.cl_valor_iva.Name = "cl_valor_iva";
            this.cl_valor_iva.ReadOnly = true;
            // 
            // pnl_abajo
            // 
            this.pnl_abajo.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_abajo.Controls.Add(this.label5);
            this.pnl_abajo.Controls.Add(this.txt_valorMasIVA);
            this.pnl_abajo.Controls.Add(this.label4);
            this.pnl_abajo.Controls.Add(this.txt_total_iva);
            this.pnl_abajo.Controls.Add(this.label1);
            this.pnl_abajo.Controls.Add(this.txt_total);
            this.pnl_abajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_abajo.Location = new System.Drawing.Point(0, 435);
            this.pnl_abajo.Name = "pnl_abajo";
            this.pnl_abajo.Size = new System.Drawing.Size(784, 47);
            this.pnl_abajo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(545, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total:";
            // 
            // txt_valorMasIVA
            // 
            this.txt_valorMasIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_valorMasIVA.Enabled = false;
            this.txt_valorMasIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorMasIVA.ForeColor = System.Drawing.Color.Black;
            this.txt_valorMasIVA.Location = new System.Drawing.Point(595, 14);
            this.txt_valorMasIVA.Name = "txt_valorMasIVA";
            this.txt_valorMasIVA.Size = new System.Drawing.Size(175, 23);
            this.txt_valorMasIVA.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Total IVA:";
            // 
            // txt_total_iva
            // 
            this.txt_total_iva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total_iva.Enabled = false;
            this.txt_total_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_iva.ForeColor = System.Drawing.Color.Black;
            this.txt_total_iva.Location = new System.Drawing.Point(344, 14);
            this.txt_total_iva.Name = "txt_total_iva";
            this.txt_total_iva.Size = new System.Drawing.Size(175, 23);
            this.txt_total_iva.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Valor:";
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.Black;
            this.txt_total.Location = new System.Drawing.Point(89, 14);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(175, 23);
            this.txt_total.TabIndex = 24;
            // 
            // frm_gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 482);
            this.Controls.Add(this.dtg_gastos);
            this.Controls.Add(this.pnl_abajo);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_gastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.frm_gastos_Load);
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_gastos)).EndInit();
            this.pnl_abajo.ResumeLayout(false);
            this.pnl_abajo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_exportar_excel;
        private System.Windows.Forms.DataGridView dtg_gastos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_agregar_gastos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_abajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id_gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_desc_gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor_iva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total_iva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_valorMasIVA;
        public System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        public System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
    }
}