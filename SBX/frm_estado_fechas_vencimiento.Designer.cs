namespace SBX
{
    partial class frm_estado_fechas_vencimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_estado_fechas_vencimiento));
            this.dtg_productos = new System.Windows.Forms.DataGridView();
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_exportar_excel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productos)).BeginInit();
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_productos
            // 
            this.dtg_productos.AllowUserToAddRows = false;
            this.dtg_productos.AllowUserToDeleteRows = false;
            this.dtg_productos.AllowUserToOrderColumns = true;
            this.dtg_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_productos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_productos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_productos.Location = new System.Drawing.Point(0, 42);
            this.dtg_productos.Name = "dtg_productos";
            this.dtg_productos.ReadOnly = true;
            this.dtg_productos.Size = new System.Drawing.Size(800, 408);
            this.dtg_productos.TabIndex = 9;
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.btn_buscar);
            this.pnl_arriba.Controls.Add(this.txt_buscar);
            this.pnl_arriba.Controls.Add(this.btn_exportar_excel);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(800, 42);
            this.pnl_arriba.TabIndex = 8;
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
            this.btn_buscar.Location = new System.Drawing.Point(767, 8);
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
            this.txt_buscar.Location = new System.Drawing.Point(561, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(192, 20);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_estado_fechas_vencimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtg_productos);
            this.Controls.Add(this.pnl_arriba);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_estado_fechas_vencimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechas Vencimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productos)).EndInit();
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_productos;
        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_exportar_excel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}