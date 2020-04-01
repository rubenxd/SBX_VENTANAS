namespace SBX
{
    partial class frm_fechas_vencimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_fechas_vencimiento));
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_cerrar_b_n = new System.Windows.Forms.Label();
            this.dtg_fechas_vencimiento = new System.Windows.Forms.DataGridView();
            this.cl_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fecha_vence = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_item = new System.Windows.Forms.Label();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_fechas_vencimiento)).BeginInit();
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
            this.pnl_titulo.Size = new System.Drawing.Size(376, 29);
            this.pnl_titulo.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_titulo.Location = new System.Drawing.Point(10, 2);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(151, 17);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Fechas vencimiento";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cerrar_b_n
            // 
            this.lbl_cerrar_b_n.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar_b_n.AutoSize = true;
            this.lbl_cerrar_b_n.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar_b_n.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar_b_n.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_cerrar_b_n.Location = new System.Drawing.Point(352, 2);
            this.lbl_cerrar_b_n.Name = "lbl_cerrar_b_n";
            this.lbl_cerrar_b_n.Size = new System.Drawing.Size(15, 15);
            this.lbl_cerrar_b_n.TabIndex = 6;
            this.lbl_cerrar_b_n.Text = "X";
            this.lbl_cerrar_b_n.Click += new System.EventHandler(this.Lbl_cerrar_b_n_Click);
            // 
            // dtg_fechas_vencimiento
            // 
            this.dtg_fechas_vencimiento.AllowUserToAddRows = false;
            this.dtg_fechas_vencimiento.AllowUserToDeleteRows = false;
            this.dtg_fechas_vencimiento.AllowUserToOrderColumns = true;
            this.dtg_fechas_vencimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_fechas_vencimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_fechas_vencimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_item,
            this.cl_Fecha_vencimiento});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_fechas_vencimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_fechas_vencimiento.Location = new System.Drawing.Point(12, 61);
            this.dtg_fechas_vencimiento.Name = "dtg_fechas_vencimiento";
            this.dtg_fechas_vencimiento.Size = new System.Drawing.Size(348, 125);
            this.dtg_fechas_vencimiento.TabIndex = 2;
            // 
            // cl_item
            // 
            this.cl_item.HeaderText = "Item";
            this.cl_item.Name = "cl_item";
            this.cl_item.ReadOnly = true;
            // 
            // cl_Fecha_vencimiento
            // 
            this.cl_Fecha_vencimiento.HeaderText = "Fecha Vencimiento";
            this.cl_Fecha_vencimiento.Name = "cl_Fecha_vencimiento";
            this.cl_Fecha_vencimiento.Width = 200;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.DimGray;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(112, 195);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(66, 30);
            this.btn_guardar.TabIndex = 80;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 83;
            this.label1.Text = "Item: ";
            // 
            // dtp_fecha_vence
            // 
            this.dtp_fecha_vence.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_fecha_vence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_vence.Location = new System.Drawing.Point(218, 36);
            this.dtp_fecha_vence.Name = "dtp_fecha_vence";
            this.dtp_fecha_vence.Size = new System.Drawing.Size(142, 20);
            this.dtp_fecha_vence.TabIndex = 81;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(125, 38);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 15);
            this.label29.TabIndex = 82;
            this.label29.Text = "F. Vencimiento";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.DimGray;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(184, 195);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(66, 30);
            this.btn_eliminar.TabIndex = 84;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // lbl_item
            // 
            this.lbl_item.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.Location = new System.Drawing.Point(51, 38);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(14, 15);
            this.lbl_item.TabIndex = 85;
            this.lbl_item.Text = "0";
            // 
            // frm_fechas_vencimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(376, 237);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_fecha_vence);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dtg_fechas_vencimiento);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_fechas_vencimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_fechas_vencimiento";
            this.Load += new System.EventHandler(this.Frm_fechas_vencimiento_Load);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_fechas_vencimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label lbl_cerrar_b_n;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dtg_fechas_vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Fecha_vencimiento;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fecha_vence;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lbl_item;
    }
}