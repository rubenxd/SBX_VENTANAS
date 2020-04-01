namespace SBX
{
    partial class frm_historial_separados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_historial_separados));
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_minimixar = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtg_pagos = new System.Windows.Forms.DataGridView();
            this.cl_num_separado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor_abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_num_separado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_arriba.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pagos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.Color.DimGray;
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.label1);
            this.pnl_arriba.Controls.Add(this.lbl_minimixar);
            this.pnl_arriba.Controls.Add(this.lbl_cerrar);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(545, 28);
            this.pnl_arriba.TabIndex = 1;
            this.pnl_arriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_arriba_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pagos";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // lbl_minimixar
            // 
            this.lbl_minimixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minimixar.AutoSize = true;
            this.lbl_minimixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minimixar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimixar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_minimixar.Location = new System.Drawing.Point(493, -2);
            this.lbl_minimixar.Name = "lbl_minimixar";
            this.lbl_minimixar.Size = new System.Drawing.Size(18, 19);
            this.lbl_minimixar.TabIndex = 1;
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
            this.lbl_cerrar.Location = new System.Drawing.Point(518, 3);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(17, 16);
            this.lbl_cerrar.TabIndex = 0;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtg_pagos);
            this.panel1.Controls.Add(this.lbl_cliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_num_separado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 355);
            this.panel1.TabIndex = 2;
            // 
            // dtg_pagos
            // 
            this.dtg_pagos.AllowUserToAddRows = false;
            this.dtg_pagos.AllowUserToDeleteRows = false;
            this.dtg_pagos.AllowUserToOrderColumns = true;
            this.dtg_pagos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_pagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_pagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_num_separado,
            this.cl_Fecha,
            this.cl_valor_abono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_pagos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_pagos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_pagos.Location = new System.Drawing.Point(0, 51);
            this.dtg_pagos.Name = "dtg_pagos";
            this.dtg_pagos.ReadOnly = true;
            this.dtg_pagos.Size = new System.Drawing.Size(543, 302);
            this.dtg_pagos.TabIndex = 33;
            // 
            // cl_num_separado
            // 
            this.cl_num_separado.HeaderText = "Num";
            this.cl_num_separado.Name = "cl_num_separado";
            this.cl_num_separado.ReadOnly = true;
            // 
            // cl_Fecha
            // 
            this.cl_Fecha.HeaderText = "Fecha";
            this.cl_Fecha.Name = "cl_Fecha";
            this.cl_Fecha.ReadOnly = true;
            this.cl_Fecha.Width = 200;
            // 
            // cl_valor_abono
            // 
            this.cl_valor_abono.HeaderText = "Valor abono";
            this.cl_valor_abono.Name = "cl_valor_abono";
            this.cl_valor_abono.ReadOnly = true;
            this.cl_valor_abono.Width = 200;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(112, 31);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(13, 13);
            this.lbl_cliente.TabIndex = 32;
            this.lbl_cliente.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cliente: ";
            // 
            // lbl_num_separado
            // 
            this.lbl_num_separado.AutoSize = true;
            this.lbl_num_separado.Location = new System.Drawing.Point(112, 8);
            this.lbl_num_separado.Name = "lbl_num_separado";
            this.lbl_num_separado.Size = new System.Drawing.Size(13, 13);
            this.lbl_num_separado.TabIndex = 30;
            this.lbl_num_separado.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Numero Separado: ";
            // 
            // frm_historial_separados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(545, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_historial_separados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_historial_separados";
            this.Load += new System.EventHandler(this.frm_historial_separados_Load);
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_minimixar;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg_pagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_num_separado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor_abono;
        public System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_num_separado;
        private System.Windows.Forms.Label label2;
    }
}