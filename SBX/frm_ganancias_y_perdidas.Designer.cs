
namespace SBX
{
    partial class frm_ganancias_y_perdidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ganancias_y_perdidas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.txt_venta = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.dtg_informe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_informe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_buscar);
            this.panel1.Controls.Add(this.btn_consultar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtp_fecha_fin);
            this.panel1.Controls.Add(this.dtp_fecha_inicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 44);
            this.panel1.TabIndex = 10;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.ForeColor = System.Drawing.Color.Gray;
            this.txt_buscar.Location = new System.Drawing.Point(748, 9);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(181, 20);
            this.txt_buscar.TabIndex = 86;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consultar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultar.Image")));
            this.btn_consultar.Location = new System.Drawing.Point(938, 6);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(26, 26);
            this.btn_consultar.TabIndex = 85;
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 84;
            this.label4.Text = "F. Inicio:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(568, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "F. Fin:";
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_fin.Location = new System.Drawing.Point(612, 9);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_fecha_fin.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_fin.TabIndex = 82;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(441, 9);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(110, 20);
            this.dtp_fecha_inicio.TabIndex = 81;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_resultado);
            this.panel2.Controls.Add(this.txt_venta);
            this.panel2.Controls.Add(this.txt_costo);
            this.panel2.Controls.Add(this.txt_cantidad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 163);
            this.panel2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 94;
            this.label6.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "T Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 92;
            this.label2.Text = "T Costo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Cantidad";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Enabled = false;
            this.txt_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.ForeColor = System.Drawing.Color.Gray;
            this.txt_resultado.Location = new System.Drawing.Point(123, 117);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(425, 30);
            this.txt_resultado.TabIndex = 90;
            // 
            // txt_venta
            // 
            this.txt_venta.Enabled = false;
            this.txt_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_venta.ForeColor = System.Drawing.Color.Gray;
            this.txt_venta.Location = new System.Drawing.Point(123, 81);
            this.txt_venta.Name = "txt_venta";
            this.txt_venta.Size = new System.Drawing.Size(425, 30);
            this.txt_venta.TabIndex = 89;
            // 
            // txt_costo
            // 
            this.txt_costo.Enabled = false;
            this.txt_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo.ForeColor = System.Drawing.Color.Gray;
            this.txt_costo.Location = new System.Drawing.Point(123, 45);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(425, 30);
            this.txt_costo.TabIndex = 88;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Enabled = false;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.Gray;
            this.txt_cantidad.Location = new System.Drawing.Point(123, 9);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(425, 30);
            this.txt_cantidad.TabIndex = 87;
            // 
            // dtg_informe
            // 
            this.dtg_informe.AllowUserToAddRows = false;
            this.dtg_informe.AllowUserToDeleteRows = false;
            this.dtg_informe.AllowUserToOrderColumns = true;
            this.dtg_informe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtg_informe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_informe.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_informe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_informe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_informe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_informe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_informe.Location = new System.Drawing.Point(0, 44);
            this.dtg_informe.Name = "dtg_informe";
            this.dtg_informe.ReadOnly = true;
            this.dtg_informe.Size = new System.Drawing.Size(978, 450);
            this.dtg_informe.TabIndex = 12;
            // 
            // frm_ganancias_y_perdidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 657);
            this.Controls.Add(this.dtg_informe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_ganancias_y_perdidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ganancias_y_perdidas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_informe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtg_informe;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.TextBox txt_venta;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}