namespace SBX
{
    partial class frm_Alertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Alertas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_cerrar_b_n = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dtg_informe = new System.Windows.Forms.DataGridView();
            this.cl_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_fecha_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_bus = new System.Windows.Forms.Button();
            this.txt_buscar_stock = new System.Windows.Forms.TextBox();
            this.dtg_stocks = new System.Windows.Forms.DataGridView();
            this.cl_item_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nombre_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_stock_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_stock_max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_agotado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_titulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_informe)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stocks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnl_titulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_titulo.Controls.Add(this.lbl_titulo);
            this.pnl_titulo.Controls.Add(this.lbl_cerrar_b_n);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(955, 29);
            this.pnl_titulo.TabIndex = 2;
            this.pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_titulo_MouseDown);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_titulo.Location = new System.Drawing.Point(10, 2);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(59, 17);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Alertas";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cerrar_b_n
            // 
            this.lbl_cerrar_b_n.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar_b_n.AutoSize = true;
            this.lbl_cerrar_b_n.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar_b_n.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar_b_n.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_cerrar_b_n.Location = new System.Drawing.Point(931, 2);
            this.lbl_cerrar_b_n.Name = "lbl_cerrar_b_n";
            this.lbl_cerrar_b_n.Size = new System.Drawing.Size(15, 15);
            this.lbl_cerrar_b_n.TabIndex = 6;
            this.lbl_cerrar_b_n.Text = "X";
            this.lbl_cerrar_b_n.Click += new System.EventHandler(this.Lbl_cerrar_b_n_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Controls.Add(this.dtg_informe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 403);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas vencimiento";
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
            this.btn_buscar.Location = new System.Drawing.Point(413, 29);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(22, 22);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.ForeColor = System.Drawing.Color.Gray;
            this.txt_buscar.Location = new System.Drawing.Point(210, 31);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(197, 20);
            this.txt_buscar.TabIndex = 12;
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_buscar_KeyUp);
            // 
            // dtg_informe
            // 
            this.dtg_informe.AllowUserToAddRows = false;
            this.dtg_informe.AllowUserToDeleteRows = false;
            this.dtg_informe.AllowUserToOrderColumns = true;
            this.dtg_informe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_informe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_informe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_informe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_item,
            this.cl_nombre,
            this.cl_fecha_vence,
            this.cl_estado});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_informe.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_informe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_informe.Location = new System.Drawing.Point(3, 69);
            this.dtg_informe.Name = "dtg_informe";
            this.dtg_informe.ReadOnly = true;
            this.dtg_informe.Size = new System.Drawing.Size(434, 331);
            this.dtg_informe.TabIndex = 11;
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
            // 
            // cl_fecha_vence
            // 
            this.cl_fecha_vence.HeaderText = "Fecha v";
            this.cl_fecha_vence.Name = "cl_fecha_vence";
            this.cl_fecha_vence.ReadOnly = true;
            // 
            // cl_estado
            // 
            this.cl_estado.HeaderText = "Estado";
            this.cl_estado.Name = "cl_estado";
            this.cl_estado.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.btn_bus);
            this.groupBox2.Controls.Add(this.txt_buscar_stock);
            this.groupBox2.Controls.Add(this.dtg_stocks);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(452, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 403);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // btn_bus
            // 
            this.btn_bus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bus.BackColor = System.Drawing.SystemColors.Window;
            this.btn_bus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bus.FlatAppearance.BorderSize = 0;
            this.btn_bus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_bus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bus.Image = ((System.Drawing.Image)(resources.GetObject("btn_bus.Image")));
            this.btn_bus.Location = new System.Drawing.Point(466, 29);
            this.btn_bus.Name = "btn_bus";
            this.btn_bus.Size = new System.Drawing.Size(22, 22);
            this.btn_bus.TabIndex = 14;
            this.btn_bus.UseVisualStyleBackColor = false;
            this.btn_bus.Click += new System.EventHandler(this.Btn_bus_Click);
            // 
            // txt_buscar_stock
            // 
            this.txt_buscar_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar_stock.ForeColor = System.Drawing.Color.Gray;
            this.txt_buscar_stock.Location = new System.Drawing.Point(263, 31);
            this.txt_buscar_stock.Name = "txt_buscar_stock";
            this.txt_buscar_stock.Size = new System.Drawing.Size(197, 20);
            this.txt_buscar_stock.TabIndex = 13;
            this.txt_buscar_stock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_buscar_stock_KeyUp);
            // 
            // dtg_stocks
            // 
            this.dtg_stocks.AllowUserToAddRows = false;
            this.dtg_stocks.AllowUserToDeleteRows = false;
            this.dtg_stocks.AllowUserToOrderColumns = true;
            this.dtg_stocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_stocks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_stocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_item_s,
            this.cl_nombre_s,
            this.cl_stock,
            this.cl_stock_min,
            this.cl_stock_max,
            this.cl_agotado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_stocks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_stocks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_stocks.Location = new System.Drawing.Point(3, 69);
            this.dtg_stocks.Name = "dtg_stocks";
            this.dtg_stocks.ReadOnly = true;
            this.dtg_stocks.Size = new System.Drawing.Size(490, 331);
            this.dtg_stocks.TabIndex = 12;
            // 
            // cl_item_s
            // 
            this.cl_item_s.HeaderText = "Item";
            this.cl_item_s.Name = "cl_item_s";
            this.cl_item_s.ReadOnly = true;
            // 
            // cl_nombre_s
            // 
            this.cl_nombre_s.HeaderText = "Nombre";
            this.cl_nombre_s.Name = "cl_nombre_s";
            this.cl_nombre_s.ReadOnly = true;
            // 
            // cl_stock
            // 
            this.cl_stock.HeaderText = "Stock";
            this.cl_stock.Name = "cl_stock";
            this.cl_stock.ReadOnly = true;
            // 
            // cl_stock_min
            // 
            this.cl_stock_min.HeaderText = "Min";
            this.cl_stock_min.Name = "cl_stock_min";
            this.cl_stock_min.ReadOnly = true;
            // 
            // cl_stock_max
            // 
            this.cl_stock_max.HeaderText = "Max";
            this.cl_stock_max.Name = "cl_stock_max";
            this.cl_stock_max.ReadOnly = true;
            // 
            // cl_agotado
            // 
            this.cl_agotado.HeaderText = "Agotado";
            this.cl_agotado.Name = "cl_agotado";
            this.cl_agotado.ReadOnly = true;
            // 
            // frm_Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Alertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Alertas";
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_informe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_cerrar_b_n;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtg_informe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fecha_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_estado;
        private System.Windows.Forms.DataGridView dtg_stocks;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_bus;
        private System.Windows.Forms.TextBox txt_buscar_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_item_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_stock_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_stock_max;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_agotado;
    }
}