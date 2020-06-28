namespace SBX
{
    partial class frm_venta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_venta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.dtg_venta = new System.Windows.Forms.DataGridView();
            this.pnl_abajo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_fecha_hora = new System.Windows.Forms.Label();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_nombre_cliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_buscar_cliente = new System.Windows.Forms.Button();
            this.txt_num_baucher_credito = new System.Windows.Forms.TextBox();
            this.txt_num_baucher_debit = new System.Windows.Forms.TextBox();
            this.txt_credito = new System.Windows.Forms.TextBox();
            this.txt_efectivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_debito = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.btn_separado = new System.Windows.Forms.Button();
            this.btn_domicilio = new System.Windows.Forms.Button();
            this.btn_descuento = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_quitar_todo = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.btn_producto = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.cl_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_modo_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_desc_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_subCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_sobre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_centro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_venta)).BeginInit();
            this.pnl_abajo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_centro
            // 
            this.pnl_centro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_centro.Controls.Add(this.dtg_venta);
            this.pnl_centro.Controls.Add(this.pnl_abajo);
            this.pnl_centro.Controls.Add(this.pnl_arriba);
            this.pnl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centro.Location = new System.Drawing.Point(0, 0);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(900, 546);
            this.pnl_centro.TabIndex = 1;
            // 
            // dtg_venta
            // 
            this.dtg_venta.AllowUserToAddRows = false;
            this.dtg_venta.AllowUserToDeleteRows = false;
            this.dtg_venta.AllowUserToOrderColumns = true;
            this.dtg_venta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_venta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtg_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_item,
            this.cl_referencia,
            this.cl_codigo_barras,
            this.cl_nombre,
            this.cl_cantidad,
            this.cl_precio,
            this.cl_um,
            this.cl_descuento,
            this.cl_valor_descuento,
            this.cl_total,
            this.cl_costo,
            this.cl_modo_venta,
            this.cl_Proveedor,
            this.cl_iva,
            this.cl_desc_proveedor,
            this.cl_subCantidad,
            this.cl_sobre});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_venta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_venta.Location = new System.Drawing.Point(0, 45);
            this.dtg_venta.Name = "dtg_venta";
            this.dtg_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_venta.Size = new System.Drawing.Size(896, 293);
            this.dtg_venta.TabIndex = 27;
            this.dtg_venta.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtg_venta_CellValidating);
            this.dtg_venta.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtg_venta_EditingControlShowing);
            this.dtg_venta.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtg_venta_RowValidating);
            // 
            // pnl_abajo
            // 
            this.pnl_abajo.Controls.Add(this.txt_nota);
            this.pnl_abajo.Controls.Add(this.panel1);
            this.pnl_abajo.Controls.Add(this.lbl_cambio);
            this.pnl_abajo.Controls.Add(this.txt_cliente);
            this.pnl_abajo.Controls.Add(this.label8);
            this.pnl_abajo.Controls.Add(this.label5);
            this.pnl_abajo.Controls.Add(this.label7);
            this.pnl_abajo.Controls.Add(this.lbl_nombre_cliente);
            this.pnl_abajo.Controls.Add(this.label6);
            this.pnl_abajo.Controls.Add(this.btn_buscar_cliente);
            this.pnl_abajo.Controls.Add(this.txt_num_baucher_credito);
            this.pnl_abajo.Controls.Add(this.txt_num_baucher_debit);
            this.pnl_abajo.Controls.Add(this.txt_credito);
            this.pnl_abajo.Controls.Add(this.txt_efectivo);
            this.pnl_abajo.Controls.Add(this.label4);
            this.pnl_abajo.Controls.Add(this.label1);
            this.pnl_abajo.Controls.Add(this.txt_debito);
            this.pnl_abajo.Controls.Add(this.lbl_total);
            this.pnl_abajo.Controls.Add(this.label3);
            this.pnl_abajo.Controls.Add(this.label2);
            this.pnl_abajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_abajo.Location = new System.Drawing.Point(0, 338);
            this.pnl_abajo.Name = "pnl_abajo";
            this.pnl_abajo.Size = new System.Drawing.Size(896, 204);
            this.pnl_abajo.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lbl_fecha_hora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 26);
            this.panel1.TabIndex = 27;
            // 
            // lbl_fecha_hora
            // 
            this.lbl_fecha_hora.AutoSize = true;
            this.lbl_fecha_hora.Font = new System.Drawing.Font("Arial", 10F);
            this.lbl_fecha_hora.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_fecha_hora.Location = new System.Drawing.Point(7, 5);
            this.lbl_fecha_hora.Name = "lbl_fecha_hora";
            this.lbl_fecha_hora.Size = new System.Drawing.Size(92, 16);
            this.lbl_fecha_hora.TabIndex = 26;
            this.lbl_fecha_hora.Text = "Fecha y hora";
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_cambio.Location = new System.Drawing.Point(329, 153);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(21, 24);
            this.lbl_cambio.TabIndex = 25;
            this.lbl_cambio.Text = "0";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.ForeColor = System.Drawing.Color.Black;
            this.txt_cliente.Location = new System.Drawing.Point(332, 46);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(216, 26);
            this.txt_cliente.TabIndex = 22;
            this.txt_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cliente_KeyPress);
            this.txt_cliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_cliente_KeyUp);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(228, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cambio:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(813, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "#";
            this.label7.Visible = false;
            // 
            // lbl_nombre_cliente
            // 
            this.lbl_nombre_cliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_nombre_cliente.AutoSize = true;
            this.lbl_nombre_cliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_cliente.Location = new System.Drawing.Point(599, 52);
            this.lbl_nombre_cliente.Name = "lbl_nombre_cliente";
            this.lbl_nombre_cliente.Size = new System.Drawing.Size(15, 15);
            this.lbl_nombre_cliente.TabIndex = 24;
            this.lbl_nombre_cliente.Text = "--";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(813, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "#";
            this.label6.Visible = false;
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_buscar_cliente.BackColor = System.Drawing.SystemColors.Window;
            this.btn_buscar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_cliente.FlatAppearance.BorderSize = 0;
            this.btn_buscar_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_buscar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_cliente.Image")));
            this.btn_buscar_cliente.Location = new System.Drawing.Point(569, 51);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(22, 15);
            this.btn_buscar_cliente.TabIndex = 23;
            this.btn_buscar_cliente.UseVisualStyleBackColor = false;
            this.btn_buscar_cliente.Click += new System.EventHandler(this.btn_buscar_cliente_Click);
            // 
            // txt_num_baucher_credito
            // 
            this.txt_num_baucher_credito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_num_baucher_credito.Enabled = false;
            this.txt_num_baucher_credito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_baucher_credito.ForeColor = System.Drawing.Color.Gray;
            this.txt_num_baucher_credito.Location = new System.Drawing.Point(839, 269);
            this.txt_num_baucher_credito.Name = "txt_num_baucher_credito";
            this.txt_num_baucher_credito.Size = new System.Drawing.Size(53, 26);
            this.txt_num_baucher_credito.TabIndex = 16;
            this.txt_num_baucher_credito.Text = "Numero baucher";
            this.txt_num_baucher_credito.Visible = false;
            this.txt_num_baucher_credito.Enter += new System.EventHandler(this.txt_num_baucher_credito_Enter);
            this.txt_num_baucher_credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_baucher_credito_KeyPress);
            this.txt_num_baucher_credito.Leave += new System.EventHandler(this.txt_num_baucher_credito_Leave);
            // 
            // txt_num_baucher_debit
            // 
            this.txt_num_baucher_debit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_num_baucher_debit.Enabled = false;
            this.txt_num_baucher_debit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_baucher_debit.ForeColor = System.Drawing.Color.Gray;
            this.txt_num_baucher_debit.Location = new System.Drawing.Point(839, 234);
            this.txt_num_baucher_debit.Name = "txt_num_baucher_debit";
            this.txt_num_baucher_debit.Size = new System.Drawing.Size(53, 26);
            this.txt_num_baucher_debit.TabIndex = 15;
            this.txt_num_baucher_debit.Text = "Numero baucher";
            this.txt_num_baucher_debit.Visible = false;
            this.txt_num_baucher_debit.Enter += new System.EventHandler(this.txt_num_baucher_debit_Enter);
            this.txt_num_baucher_debit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_baucher_debit_KeyPress);
            this.txt_num_baucher_debit.Leave += new System.EventHandler(this.txt_num_baucher_debit_Leave);
            // 
            // txt_credito
            // 
            this.txt_credito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_credito.Enabled = false;
            this.txt_credito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_credito.Location = new System.Drawing.Point(747, 269);
            this.txt_credito.Name = "txt_credito";
            this.txt_credito.Size = new System.Drawing.Size(52, 26);
            this.txt_credito.TabIndex = 12;
            this.txt_credito.Text = "0";
            this.txt_credito.Visible = false;
            this.txt_credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_credito_KeyPress);
            this.txt_credito.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_credito_KeyUp);
            // 
            // txt_efectivo
            // 
            this.txt_efectivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_efectivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_efectivo.Location = new System.Drawing.Point(332, 80);
            this.txt_efectivo.Name = "txt_efectivo";
            this.txt_efectivo.Size = new System.Drawing.Size(216, 26);
            this.txt_efectivo.TabIndex = 8;
            this.txt_efectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_efectivo_KeyPress);
            this.txt_efectivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_efectivo_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "T. credito";
            this.label4.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total:";
            // 
            // txt_debito
            // 
            this.txt_debito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_debito.Enabled = false;
            this.txt_debito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_debito.Location = new System.Drawing.Point(747, 234);
            this.txt_debito.Name = "txt_debito";
            this.txt_debito.Size = new System.Drawing.Size(52, 26);
            this.txt_debito.TabIndex = 10;
            this.txt_debito.Text = "0";
            this.txt_debito.Visible = false;
            this.txt_debito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_debito_KeyPress);
            this.txt_debito.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_debito_KeyUp);
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(329, 119);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(21, 24);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "T. debito";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Efectivo";
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_arriba.Controls.Add(this.btn_separado);
            this.pnl_arriba.Controls.Add(this.btn_domicilio);
            this.pnl_arriba.Controls.Add(this.btn_descuento);
            this.pnl_arriba.Controls.Add(this.btn_guardar);
            this.pnl_arriba.Controls.Add(this.btn_quitar_todo);
            this.pnl_arriba.Controls.Add(this.btn_quitar);
            this.pnl_arriba.Controls.Add(this.btn_consultas);
            this.pnl_arriba.Controls.Add(this.btn_producto);
            this.pnl_arriba.Controls.Add(this.btn_cliente);
            this.pnl_arriba.Controls.Add(this.btn_buscar);
            this.pnl_arriba.Controls.Add(this.txt_producto);
            this.pnl_arriba.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(896, 45);
            this.pnl_arriba.TabIndex = 0;
            // 
            // btn_separado
            // 
            this.btn_separado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_separado.BackColor = System.Drawing.SystemColors.Window;
            this.btn_separado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_separado.Enabled = false;
            this.btn_separado.FlatAppearance.BorderSize = 0;
            this.btn_separado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_separado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_separado.Image = ((System.Drawing.Image)(resources.GetObject("btn_separado.Image")));
            this.btn_separado.Location = new System.Drawing.Point(630, 9);
            this.btn_separado.Name = "btn_separado";
            this.btn_separado.Size = new System.Drawing.Size(26, 26);
            this.btn_separado.TabIndex = 10;
            this.btn_separado.UseVisualStyleBackColor = false;
            this.btn_separado.Click += new System.EventHandler(this.btn_separado_Click);
            // 
            // btn_domicilio
            // 
            this.btn_domicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_domicilio.BackColor = System.Drawing.SystemColors.Window;
            this.btn_domicilio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_domicilio.Enabled = false;
            this.btn_domicilio.FlatAppearance.BorderSize = 0;
            this.btn_domicilio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_domicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_domicilio.Image = ((System.Drawing.Image)(resources.GetObject("btn_domicilio.Image")));
            this.btn_domicilio.Location = new System.Drawing.Point(662, 9);
            this.btn_domicilio.Name = "btn_domicilio";
            this.btn_domicilio.Size = new System.Drawing.Size(26, 26);
            this.btn_domicilio.TabIndex = 9;
            this.btn_domicilio.UseVisualStyleBackColor = false;
            this.btn_domicilio.Click += new System.EventHandler(this.btn_domicilio_Click);
            // 
            // btn_descuento
            // 
            this.btn_descuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_descuento.BackColor = System.Drawing.SystemColors.Window;
            this.btn_descuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_descuento.Enabled = false;
            this.btn_descuento.FlatAppearance.BorderSize = 0;
            this.btn_descuento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_descuento.Image = ((System.Drawing.Image)(resources.GetObject("btn_descuento.Image")));
            this.btn_descuento.Location = new System.Drawing.Point(695, 9);
            this.btn_descuento.Name = "btn_descuento";
            this.btn_descuento.Size = new System.Drawing.Size(26, 26);
            this.btn_descuento.TabIndex = 8;
            this.btn_descuento.UseVisualStyleBackColor = false;
            this.btn_descuento.Click += new System.EventHandler(this.btn_descuento_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(598, 9);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(26, 26);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_quitar_todo
            // 
            this.btn_quitar_todo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quitar_todo.BackColor = System.Drawing.SystemColors.Window;
            this.btn_quitar_todo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar_todo.Enabled = false;
            this.btn_quitar_todo.FlatAppearance.BorderSize = 0;
            this.btn_quitar_todo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_quitar_todo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar_todo.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitar_todo.Image")));
            this.btn_quitar_todo.Location = new System.Drawing.Point(727, 9);
            this.btn_quitar_todo.Name = "btn_quitar_todo";
            this.btn_quitar_todo.Size = new System.Drawing.Size(26, 26);
            this.btn_quitar_todo.TabIndex = 6;
            this.btn_quitar_todo.UseVisualStyleBackColor = false;
            this.btn_quitar_todo.Click += new System.EventHandler(this.btn_quitar_todo_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quitar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_quitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar.Enabled = false;
            this.btn_quitar.FlatAppearance.BorderSize = 0;
            this.btn_quitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitar.Image")));
            this.btn_quitar.Location = new System.Drawing.Point(759, 9);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(26, 26);
            this.btn_quitar.TabIndex = 5;
            this.btn_quitar.UseVisualStyleBackColor = false;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_consultas
            // 
            this.btn_consultas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consultas.BackColor = System.Drawing.SystemColors.Window;
            this.btn_consultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultas.Enabled = false;
            this.btn_consultas.FlatAppearance.BorderSize = 0;
            this.btn_consultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultas.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultas.Image")));
            this.btn_consultas.Location = new System.Drawing.Point(793, 9);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(26, 26);
            this.btn_consultas.TabIndex = 4;
            this.btn_consultas.UseVisualStyleBackColor = false;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // btn_producto
            // 
            this.btn_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_producto.BackColor = System.Drawing.SystemColors.Window;
            this.btn_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_producto.Enabled = false;
            this.btn_producto.FlatAppearance.BorderSize = 0;
            this.btn_producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_producto.Image")));
            this.btn_producto.Location = new System.Drawing.Point(827, 9);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(26, 26);
            this.btn_producto.TabIndex = 2;
            this.btn_producto.UseVisualStyleBackColor = false;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cliente.BackColor = System.Drawing.SystemColors.Window;
            this.btn_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cliente.Enabled = false;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_cliente.Image")));
            this.btn_cliente.Location = new System.Drawing.Point(863, 9);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(26, 26);
            this.btn_cliente.TabIndex = 3;
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(394, 10);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(22, 22);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_producto
            // 
            this.txt_producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.ForeColor = System.Drawing.Color.Gray;
            this.txt_producto.Location = new System.Drawing.Point(10, 9);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(362, 26);
            this.txt_producto.TabIndex = 0;
            this.txt_producto.Text = "Item-Referencia-Código barras";
            this.txt_producto.Enter += new System.EventHandler(this.txt_producto_Enter);
            this.txt_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_producto_KeyPress);
            this.txt_producto.Leave += new System.EventHandler(this.txt_producto_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_nota
            // 
            this.txt_nota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nota.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nota.ForeColor = System.Drawing.Color.Gray;
            this.txt_nota.Location = new System.Drawing.Point(10, 6);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(876, 26);
            this.txt_nota.TabIndex = 28;
            this.txt_nota.Text = "Nota";
            this.txt_nota.Enter += new System.EventHandler(this.txt_nota_Enter);
            this.txt_nota.Leave += new System.EventHandler(this.txt_nota_Leave);
            // 
            // cl_item
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            this.cl_item.DefaultCellStyle = dataGridViewCellStyle1;
            this.cl_item.FillWeight = 70.91371F;
            this.cl_item.HeaderText = "Item";
            this.cl_item.Name = "cl_item";
            this.cl_item.ReadOnly = true;
            // 
            // cl_referencia
            // 
            this.cl_referencia.FillWeight = 70.91371F;
            this.cl_referencia.HeaderText = "Referencia";
            this.cl_referencia.Name = "cl_referencia";
            this.cl_referencia.ReadOnly = true;
            // 
            // cl_codigo_barras
            // 
            this.cl_codigo_barras.FillWeight = 70.91371F;
            this.cl_codigo_barras.HeaderText = "Codigo b.";
            this.cl_codigo_barras.Name = "cl_codigo_barras";
            this.cl_codigo_barras.ReadOnly = true;
            // 
            // cl_nombre
            // 
            this.cl_nombre.FillWeight = 70.91371F;
            this.cl_nombre.HeaderText = "Nombre";
            this.cl_nombre.Name = "cl_nombre";
            this.cl_nombre.ReadOnly = true;
            // 
            // cl_cantidad
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            this.cl_cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.cl_cantidad.FillWeight = 70.91371F;
            this.cl_cantidad.HeaderText = "Cantidad";
            this.cl_cantidad.Name = "cl_cantidad";
            // 
            // cl_precio
            // 
            this.cl_precio.FillWeight = 70.91371F;
            this.cl_precio.HeaderText = "Precio";
            this.cl_precio.Name = "cl_precio";
            // 
            // cl_um
            // 
            this.cl_um.FillWeight = 70.91371F;
            this.cl_um.HeaderText = "U.M";
            this.cl_um.Name = "cl_um";
            this.cl_um.ReadOnly = true;
            // 
            // cl_descuento
            // 
            this.cl_descuento.FillWeight = 70.91371F;
            this.cl_descuento.HeaderText = "%Des";
            this.cl_descuento.Name = "cl_descuento";
            this.cl_descuento.ReadOnly = true;
            // 
            // cl_valor_descuento
            // 
            this.cl_valor_descuento.FillWeight = 70.91371F;
            this.cl_valor_descuento.HeaderText = "Vlr.Desc";
            this.cl_valor_descuento.Name = "cl_valor_descuento";
            this.cl_valor_descuento.ReadOnly = true;
            // 
            // cl_total
            // 
            this.cl_total.FillWeight = 70.91371F;
            this.cl_total.HeaderText = "Total";
            this.cl_total.Name = "cl_total";
            this.cl_total.ReadOnly = true;
            // 
            // cl_costo
            // 
            this.cl_costo.HeaderText = "Costo";
            this.cl_costo.Name = "cl_costo";
            this.cl_costo.Visible = false;
            // 
            // cl_modo_venta
            // 
            this.cl_modo_venta.HeaderText = "Modo venta";
            this.cl_modo_venta.Name = "cl_modo_venta";
            this.cl_modo_venta.Visible = false;
            // 
            // cl_Proveedor
            // 
            this.cl_Proveedor.HeaderText = "Proveedor";
            this.cl_Proveedor.Name = "cl_Proveedor";
            this.cl_Proveedor.Visible = false;
            // 
            // cl_iva
            // 
            this.cl_iva.HeaderText = "IVA";
            this.cl_iva.Name = "cl_iva";
            this.cl_iva.Visible = false;
            // 
            // cl_desc_proveedor
            // 
            this.cl_desc_proveedor.HeaderText = "Desc proveedor";
            this.cl_desc_proveedor.Name = "cl_desc_proveedor";
            this.cl_desc_proveedor.Visible = false;
            // 
            // cl_subCantidad
            // 
            this.cl_subCantidad.HeaderText = "SubCantidad";
            this.cl_subCantidad.Name = "cl_subCantidad";
            this.cl_subCantidad.Visible = false;
            // 
            // cl_sobre
            // 
            this.cl_sobre.HeaderText = "Sobre";
            this.cl_sobre.Name = "cl_sobre";
            this.cl_sobre.Visible = false;
            // 
            // frm_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(900, 546);
            this.Controls.Add(this.pnl_centro);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "frm_venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frm_venta_Load);
            this.pnl_centro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_venta)).EndInit();
            this.pnl_abajo.ResumeLayout(false);
            this.pnl_abajo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_quitar_todo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btn_descuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_efectivo;
        private System.Windows.Forms.TextBox txt_credito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_debito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_num_baucher_debit;
        private System.Windows.Forms.TextBox txt_num_baucher_credito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_buscar_cliente;
        private System.Windows.Forms.Label lbl_nombre_cliente;
        private System.Windows.Forms.Label lbl_cambio;
        private System.Windows.Forms.Panel pnl_abajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtg_venta;
        private System.Windows.Forms.Button btn_domicilio;
        private System.Windows.Forms.Button btn_separado;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_fecha_hora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_um;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_modo_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_desc_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_subCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_sobre;
    }
}

