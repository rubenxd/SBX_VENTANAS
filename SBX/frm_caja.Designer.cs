namespace SBX
{
    partial class frm_caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_caja));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_apertura_caja = new System.Windows.Forms.Button();
            this.btn_cierre_caja = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.cbx_tipo_busqueda = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dtg_caja = new System.Windows.Forms.DataGridView();
            this.cl_codigo_Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_codigo_operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_caja)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.btn_imprimir);
            this.pnl_arriba.Controls.Add(this.btn_apertura_caja);
            this.pnl_arriba.Controls.Add(this.btn_cierre_caja);
            this.pnl_arriba.Controls.Add(this.label3);
            this.pnl_arriba.Controls.Add(this.label2);
            this.pnl_arriba.Controls.Add(this.dtp_fecha_fin);
            this.pnl_arriba.Controls.Add(this.dtp_fecha_inicio);
            this.pnl_arriba.Controls.Add(this.cbx_tipo_busqueda);
            this.pnl_arriba.Controls.Add(this.btn_buscar);
            this.pnl_arriba.Controls.Add(this.txt_buscar);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(884, 42);
            this.pnl_arriba.TabIndex = 5;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.Location = new System.Drawing.Point(74, 6);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(26, 26);
            this.btn_imprimir.TabIndex = 23;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_apertura_caja
            // 
            this.btn_apertura_caja.BackColor = System.Drawing.SystemColors.Window;
            this.btn_apertura_caja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apertura_caja.FlatAppearance.BorderSize = 0;
            this.btn_apertura_caja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_apertura_caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apertura_caja.Image = ((System.Drawing.Image)(resources.GetObject("btn_apertura_caja.Image")));
            this.btn_apertura_caja.Location = new System.Drawing.Point(42, 6);
            this.btn_apertura_caja.Name = "btn_apertura_caja";
            this.btn_apertura_caja.Size = new System.Drawing.Size(26, 26);
            this.btn_apertura_caja.TabIndex = 22;
            this.btn_apertura_caja.UseVisualStyleBackColor = false;
            this.btn_apertura_caja.Click += new System.EventHandler(this.btn_apertura_caja_Click);
            // 
            // btn_cierre_caja
            // 
            this.btn_cierre_caja.BackColor = System.Drawing.SystemColors.Window;
            this.btn_cierre_caja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cierre_caja.FlatAppearance.BorderSize = 0;
            this.btn_cierre_caja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_cierre_caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cierre_caja.Image = ((System.Drawing.Image)(resources.GetObject("btn_cierre_caja.Image")));
            this.btn_cierre_caja.Location = new System.Drawing.Point(10, 6);
            this.btn_cierre_caja.Name = "btn_cierre_caja";
            this.btn_cierre_caja.Size = new System.Drawing.Size(26, 26);
            this.btn_cierre_caja.TabIndex = 21;
            this.btn_cierre_caja.UseVisualStyleBackColor = false;
            this.btn_cierre_caja.Click += new System.EventHandler(this.btn_cierre_caja_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "F. Inicio:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "F. Fin:";
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_fin.Location = new System.Drawing.Point(438, 10);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_fin.TabIndex = 18;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(267, 10);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_inicio.TabIndex = 17;
            // 
            // cbx_tipo_busqueda
            // 
            this.cbx_tipo_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tipo_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_busqueda.FormattingEnabled = true;
            this.cbx_tipo_busqueda.Items.AddRange(new object[] {
            "Contiene",
            "Exactamente"});
            this.cbx_tipo_busqueda.Location = new System.Drawing.Point(559, 10);
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
            this.btn_buscar.Location = new System.Drawing.Point(851, 8);
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
            this.txt_buscar.Location = new System.Drawing.Point(695, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(150, 20);
            this.txt_buscar.TabIndex = 7;
            this.txt_buscar.Text = "Usuario";
            this.txt_buscar.Enter += new System.EventHandler(this.txt_buscar_Enter);
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            // 
            // dtg_caja
            // 
            this.dtg_caja.AllowUserToAddRows = false;
            this.dtg_caja.AllowUserToDeleteRows = false;
            this.dtg_caja.AllowUserToOrderColumns = true;
            this.dtg_caja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_caja.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_caja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_caja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_codigo_Caja,
            this.cl_codigo_operacion,
            this.cl_usuario,
            this.cl_fecha,
            this.cl_operacion,
            this.cl_valor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_caja.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_caja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_caja.Location = new System.Drawing.Point(0, 42);
            this.dtg_caja.Name = "dtg_caja";
            this.dtg_caja.ReadOnly = true;
            this.dtg_caja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_caja.Size = new System.Drawing.Size(884, 379);
            this.dtg_caja.TabIndex = 6;
            // 
            // cl_codigo_Caja
            // 
            this.cl_codigo_Caja.HeaderText = "CodigoCaja";
            this.cl_codigo_Caja.Name = "cl_codigo_Caja";
            this.cl_codigo_Caja.ReadOnly = true;
            // 
            // cl_codigo_operacion
            // 
            this.cl_codigo_operacion.HeaderText = "Codigo";
            this.cl_codigo_operacion.Name = "cl_codigo_operacion";
            this.cl_codigo_operacion.ReadOnly = true;
            // 
            // cl_usuario
            // 
            this.cl_usuario.HeaderText = "Usuario";
            this.cl_usuario.Name = "cl_usuario";
            this.cl_usuario.ReadOnly = true;
            // 
            // cl_fecha
            // 
            this.cl_fecha.HeaderText = "Fecha";
            this.cl_fecha.Name = "cl_fecha";
            this.cl_fecha.ReadOnly = true;
            // 
            // cl_operacion
            // 
            this.cl_operacion.HeaderText = "Operacion";
            this.cl_operacion.Name = "cl_operacion";
            this.cl_operacion.ReadOnly = true;
            // 
            // cl_valor
            // 
            this.cl_valor.HeaderText = "Valor";
            this.cl_valor.Name = "cl_valor";
            this.cl_valor.ReadOnly = true;
            // 
            // frm_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 421);
            this.Controls.Add(this.dtg_caja);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_caja";
            this.Load += new System.EventHandler(this.frm_caja_Load);
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_caja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.ComboBox cbx_tipo_busqueda;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dtg_caja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Button btn_apertura_caja;
        private System.Windows.Forms.Button btn_cierre_caja;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo_Caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo_operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor;
    }
}