namespace SBX
{
    partial class frm_separado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_separado));
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.pbl_boton = new System.Windows.Forms.Panel();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpk_fecha_vence = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_valor_cuotas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_num_cuotas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_suministrar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_periodo_pago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_abono_unicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_arriba.SuspendLayout();
            this.pbl_boton.SuspendLayout();
            this.pnl_centro.SuspendLayout();
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
            this.pnl_arriba.Size = new System.Drawing.Size(356, 28);
            this.pnl_arriba.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 2;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_cerrar.Location = new System.Drawing.Point(329, 3);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(17, 16);
            this.lbl_cerrar.TabIndex = 0;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // pbl_boton
            // 
            this.pbl_boton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbl_boton.Controls.Add(this.btn_cliente);
            this.pbl_boton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbl_boton.Location = new System.Drawing.Point(0, 28);
            this.pbl_boton.Name = "pbl_boton";
            this.pbl_boton.Size = new System.Drawing.Size(356, 37);
            this.pbl_boton.TabIndex = 3;
            // 
            // btn_cliente
            // 
            this.btn_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cliente.BackColor = System.Drawing.Color.White;
            this.btn_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_cliente.Image")));
            this.btn_cliente.Location = new System.Drawing.Point(11, 5);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(26, 26);
            this.btn_cliente.TabIndex = 0;
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // pnl_centro
            // 
            this.pnl_centro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_centro.Controls.Add(this.label11);
            this.pnl_centro.Controls.Add(this.txt_total);
            this.pnl_centro.Controls.Add(this.label10);
            this.pnl_centro.Controls.Add(this.dtpk_fecha_vence);
            this.pnl_centro.Controls.Add(this.label9);
            this.pnl_centro.Controls.Add(this.dtp_fecha_inicio);
            this.pnl_centro.Controls.Add(this.label8);
            this.pnl_centro.Controls.Add(this.txt_valor_cuotas);
            this.pnl_centro.Controls.Add(this.label7);
            this.pnl_centro.Controls.Add(this.txt_num_cuotas);
            this.pnl_centro.Controls.Add(this.label5);
            this.pnl_centro.Controls.Add(this.cbx_suministrar);
            this.pnl_centro.Controls.Add(this.label6);
            this.pnl_centro.Controls.Add(this.cbx_periodo_pago);
            this.pnl_centro.Controls.Add(this.label3);
            this.pnl_centro.Controls.Add(this.txt_abono_unicial);
            this.pnl_centro.Controls.Add(this.label2);
            this.pnl_centro.Controls.Add(this.txt_valor);
            this.pnl_centro.Controls.Add(this.lbl_nombre);
            this.pnl_centro.Controls.Add(this.btn_cancelar);
            this.pnl_centro.Controls.Add(this.btn_guardar);
            this.pnl_centro.Controls.Add(this.btn_buscar);
            this.pnl_centro.Controls.Add(this.label4);
            this.pnl_centro.Controls.Add(this.txt_dni);
            this.pnl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centro.Location = new System.Drawing.Point(0, 65);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(356, 354);
            this.pnl_centro.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 110;
            this.label11.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(98, 113);
            this.txt_total.MaxLength = 10;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(211, 20);
            this.txt_total.TabIndex = 109;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 108;
            this.label10.Text = "F. vence";
            // 
            // dtpk_fecha_vence
            // 
            this.dtpk_fecha_vence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpk_fecha_vence.Enabled = false;
            this.dtpk_fecha_vence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_fecha_vence.Location = new System.Drawing.Point(100, 271);
            this.dtpk_fecha_vence.Name = "dtpk_fecha_vence";
            this.dtpk_fecha_vence.Size = new System.Drawing.Size(211, 20);
            this.dtpk_fecha_vence.TabIndex = 107;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 106;
            this.label9.Text = "F. primer pago";
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(100, 245);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(211, 20);
            this.dtp_fecha_inicio.TabIndex = 105;
            this.dtp_fecha_inicio.CloseUp += new System.EventHandler(this.dtp_fecha_inicio_CloseUp);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 104;
            this.label8.Text = "Valor cuotas";
            // 
            // txt_valor_cuotas
            // 
            this.txt_valor_cuotas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_valor_cuotas.Location = new System.Drawing.Point(98, 219);
            this.txt_valor_cuotas.MaxLength = 10;
            this.txt_valor_cuotas.Name = "txt_valor_cuotas";
            this.txt_valor_cuotas.Size = new System.Drawing.Size(211, 20);
            this.txt_valor_cuotas.TabIndex = 103;
            this.txt_valor_cuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_cuotas_KeyPress);
            this.txt_valor_cuotas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_valor_cuotas_KeyUp);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 102;
            this.label7.Text = "Num. cuotas";
            // 
            // txt_num_cuotas
            // 
            this.txt_num_cuotas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_num_cuotas.Location = new System.Drawing.Point(98, 193);
            this.txt_num_cuotas.MaxLength = 10;
            this.txt_num_cuotas.Name = "txt_num_cuotas";
            this.txt_num_cuotas.Size = new System.Drawing.Size(211, 20);
            this.txt_num_cuotas.TabIndex = 101;
            this.txt_num_cuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_cuotas_KeyPress);
            this.txt_num_cuotas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_num_cuotas_KeyUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 100;
            this.label5.Text = "Suministrar";
            // 
            // cbx_suministrar
            // 
            this.cbx_suministrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_suministrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_suministrar.Enabled = false;
            this.cbx_suministrar.FormattingEnabled = true;
            this.cbx_suministrar.Items.AddRange(new object[] {
            "Numero Cuotas",
            "Cuota Fija"});
            this.cbx_suministrar.Location = new System.Drawing.Point(98, 166);
            this.cbx_suministrar.Name = "cbx_suministrar";
            this.cbx_suministrar.Size = new System.Drawing.Size(211, 21);
            this.cbx_suministrar.TabIndex = 99;
            this.cbx_suministrar.SelectedIndexChanged += new System.EventHandler(this.cbx_suministrar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 98;
            this.label6.Text = "Periodo pago";
            // 
            // cbx_periodo_pago
            // 
            this.cbx_periodo_pago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_periodo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_periodo_pago.FormattingEnabled = true;
            this.cbx_periodo_pago.Items.AddRange(new object[] {
            "Mensual",
            "Quincenal",
            "Semanal",
            "Diario"});
            this.cbx_periodo_pago.Location = new System.Drawing.Point(98, 139);
            this.cbx_periodo_pago.Name = "cbx_periodo_pago";
            this.cbx_periodo_pago.Size = new System.Drawing.Size(211, 21);
            this.cbx_periodo_pago.TabIndex = 97;
            this.cbx_periodo_pago.SelectedIndexChanged += new System.EventHandler(this.cbx_periodo_pago_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 96;
            this.label3.Text = "Abono inicial";
            // 
            // txt_abono_unicial
            // 
            this.txt_abono_unicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_abono_unicial.Location = new System.Drawing.Point(98, 87);
            this.txt_abono_unicial.MaxLength = 10;
            this.txt_abono_unicial.Name = "txt_abono_unicial";
            this.txt_abono_unicial.Size = new System.Drawing.Size(211, 20);
            this.txt_abono_unicial.TabIndex = 95;
            this.txt_abono_unicial.Text = "0";
            this.txt_abono_unicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_abono_unicial_KeyPress);
            this.txt_abono_unicial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_abono_unicial_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 94;
            this.label2.Text = "Valor";
            // 
            // txt_valor
            // 
            this.txt_valor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_valor.Enabled = false;
            this.txt_valor.Location = new System.Drawing.Point(98, 61);
            this.txt_valor.MaxLength = 10;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(211, 20);
            this.txt_valor.TabIndex = 93;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(100, 36);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(15, 15);
            this.lbl_nombre.TabIndex = 92;
            this.lbl_nombre.Text = "--";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(179, 314);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(80, 30);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.DimGray;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(107, 314);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(66, 30);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(326, 9);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(22, 22);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 80;
            this.label4.Text = "DNI";
            // 
            // txt_dni
            // 
            this.txt_dni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_dni.Location = new System.Drawing.Point(98, 11);
            this.txt_dni.MaxLength = 10;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(211, 20);
            this.txt_dni.TabIndex = 0;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            this.txt_dni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dni_KeyUp);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frm_separado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(356, 419);
            this.Controls.Add(this.pnl_centro);
            this.Controls.Add(this.pbl_boton);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_separado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_separado";
            this.Load += new System.EventHandler(this.frm_separado_Load);
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            this.pbl_boton.ResumeLayout(false);
            this.pnl_centro.ResumeLayout(false);
            this.pnl_centro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.Panel pbl_boton;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_abono_unicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_periodo_pago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_suministrar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_num_cuotas;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_valor_cuotas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpk_fecha_vence;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_total;
    }
}