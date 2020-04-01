namespace SBX
{
    partial class frm_mensajero
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mensajero));
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.lbl_minimixar = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtg_mesajero = new System.Windows.Forms.DataGridView();
            this.cl_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_tipo_busqueda = new System.Windows.Forms.ComboBox();
            this.btn_exportar_excel = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.pnl_txt = new System.Windows.Forms.Panel();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.pnl_botones = new System.Windows.Forms.Panel();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_mesajero)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_txt.SuspendLayout();
            this.pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.Color.DimGray;
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.lbl_minimixar);
            this.pnl_arriba.Controls.Add(this.lbl_cerrar);
            this.pnl_arriba.Controls.Add(this.label9);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(868, 32);
            this.pnl_arriba.TabIndex = 34;
            this.pnl_arriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_arriba_MouseDown);
            // 
            // lbl_minimixar
            // 
            this.lbl_minimixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minimixar.AutoSize = true;
            this.lbl_minimixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minimixar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimixar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_minimixar.Location = new System.Drawing.Point(819, 2);
            this.lbl_minimixar.Name = "lbl_minimixar";
            this.lbl_minimixar.Size = new System.Drawing.Size(18, 19);
            this.lbl_minimixar.TabIndex = 5;
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
            this.lbl_cerrar.Location = new System.Drawing.Point(844, 7);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(17, 16);
            this.lbl_cerrar.TabIndex = 4;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(4, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mensajero";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label9_MouseDown);
            // 
            // dtg_mesajero
            // 
            this.dtg_mesajero.AllowUserToAddRows = false;
            this.dtg_mesajero.AllowUserToDeleteRows = false;
            this.dtg_mesajero.AllowUserToOrderColumns = true;
            this.dtg_mesajero.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_mesajero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_mesajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_mesajero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_codigo,
            this.cl_dni,
            this.cl_Nombre,
            this.cl_Ciudad,
            this.cl_direccion,
            this.cl_telefono,
            this.cl_celular,
            this.cl_email});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_mesajero.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_mesajero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_mesajero.Location = new System.Drawing.Point(0, 250);
            this.dtg_mesajero.Name = "dtg_mesajero";
            this.dtg_mesajero.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_mesajero.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_mesajero.Size = new System.Drawing.Size(868, 172);
            this.dtg_mesajero.TabIndex = 42;
            this.dtg_mesajero.DoubleClick += new System.EventHandler(this.dtg_mesajero_DoubleClick);
            // 
            // cl_codigo
            // 
            this.cl_codigo.HeaderText = "Codigo";
            this.cl_codigo.Name = "cl_codigo";
            this.cl_codigo.ReadOnly = true;
            this.cl_codigo.Visible = false;
            // 
            // cl_dni
            // 
            this.cl_dni.HeaderText = "DNI";
            this.cl_dni.Name = "cl_dni";
            this.cl_dni.ReadOnly = true;
            this.cl_dni.Width = 120;
            // 
            // cl_Nombre
            // 
            this.cl_Nombre.HeaderText = "Nombre";
            this.cl_Nombre.Name = "cl_Nombre";
            this.cl_Nombre.ReadOnly = true;
            this.cl_Nombre.Width = 250;
            // 
            // cl_Ciudad
            // 
            this.cl_Ciudad.HeaderText = "Ciudad";
            this.cl_Ciudad.Name = "cl_Ciudad";
            this.cl_Ciudad.ReadOnly = true;
            // 
            // cl_direccion
            // 
            this.cl_direccion.HeaderText = "Direccion";
            this.cl_direccion.Name = "cl_direccion";
            this.cl_direccion.ReadOnly = true;
            this.cl_direccion.Width = 200;
            // 
            // cl_telefono
            // 
            this.cl_telefono.HeaderText = "Telefono";
            this.cl_telefono.Name = "cl_telefono";
            this.cl_telefono.ReadOnly = true;
            this.cl_telefono.Width = 130;
            // 
            // cl_celular
            // 
            this.cl_celular.HeaderText = "Celular";
            this.cl_celular.Name = "cl_celular";
            this.cl_celular.ReadOnly = true;
            this.cl_celular.Width = 130;
            // 
            // cl_email
            // 
            this.cl_email.HeaderText = "Email";
            this.cl_email.Name = "cl_email";
            this.cl_email.ReadOnly = true;
            this.cl_email.Width = 200;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbx_tipo_busqueda);
            this.panel1.Controls.Add(this.btn_exportar_excel);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.txt_buscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 39);
            this.panel1.TabIndex = 41;
            // 
            // cbx_tipo_busqueda
            // 
            this.cbx_tipo_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tipo_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_busqueda.FormattingEnabled = true;
            this.cbx_tipo_busqueda.Items.AddRange(new object[] {
            "Contiene",
            "Exactamente"});
            this.cbx_tipo_busqueda.Location = new System.Drawing.Point(538, 9);
            this.cbx_tipo_busqueda.Name = "cbx_tipo_busqueda";
            this.cbx_tipo_busqueda.Size = new System.Drawing.Size(85, 21);
            this.cbx_tipo_busqueda.TabIndex = 15;
            // 
            // btn_exportar_excel
            // 
            this.btn_exportar_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exportar_excel.BackColor = System.Drawing.SystemColors.Window;
            this.btn_exportar_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar_excel.FlatAppearance.BorderSize = 0;
            this.btn_exportar_excel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_exportar_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar_excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportar_excel.Image")));
            this.btn_exportar_excel.Location = new System.Drawing.Point(68, 9);
            this.btn_exportar_excel.Name = "btn_exportar_excel";
            this.btn_exportar_excel.Size = new System.Drawing.Size(20, 20);
            this.btn_exportar_excel.TabIndex = 4;
            this.btn_exportar_excel.UseVisualStyleBackColor = false;
            this.btn_exportar_excel.Click += new System.EventHandler(this.btn_exportar_excel_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(8, 9);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(20, 20);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
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
            this.btn_buscar.Location = new System.Drawing.Point(832, 7);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(22, 22);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(38, 9);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(20, 20);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.ForeColor = System.Drawing.Color.Gray;
            this.txt_buscar.Location = new System.Drawing.Point(629, 9);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(197, 20);
            this.txt_buscar.TabIndex = 5;
            this.txt_buscar.Text = "DNI-Nombre";
            this.txt_buscar.Enter += new System.EventHandler(this.txt_buscar_Enter);
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            // 
            // pnl_txt
            // 
            this.pnl_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_txt.Controls.Add(this.lbl_codigo);
            this.pnl_txt.Controls.Add(this.label8);
            this.pnl_txt.Controls.Add(this.txt_email);
            this.pnl_txt.Controls.Add(this.label1);
            this.pnl_txt.Controls.Add(this.txt_celular);
            this.pnl_txt.Controls.Add(this.label6);
            this.pnl_txt.Controls.Add(this.txt_telefono);
            this.pnl_txt.Controls.Add(this.label5);
            this.pnl_txt.Controls.Add(this.txt_direccion);
            this.pnl_txt.Controls.Add(this.label4);
            this.pnl_txt.Controls.Add(this.txt_ciudad);
            this.pnl_txt.Controls.Add(this.label3);
            this.pnl_txt.Controls.Add(this.txt_nombre);
            this.pnl_txt.Controls.Add(this.label2);
            this.pnl_txt.Controls.Add(this.txt_dni);
            this.pnl_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_txt.Location = new System.Drawing.Point(0, 74);
            this.pnl_txt.Name = "pnl_txt";
            this.pnl_txt.Size = new System.Drawing.Size(868, 137);
            this.pnl_txt.TabIndex = 40;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(153, 4);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(0, 15);
            this.lbl_codigo.TabIndex = 51;
            this.lbl_codigo.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(453, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_email.Location = new System.Drawing.Point(517, 77);
            this.txt_email.MaxLength = 100;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(197, 20);
            this.txt_email.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Celular *";
            // 
            // txt_celular
            // 
            this.txt_celular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_celular.Location = new System.Drawing.Point(517, 51);
            this.txt_celular.MaxLength = 12;
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(197, 20);
            this.txt_celular.TabIndex = 39;
            this.txt_celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_celular_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "Telefono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_telefono.Location = new System.Drawing.Point(517, 25);
            this.txt_telefono.MaxLength = 10;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(197, 20);
            this.txt_telefono.TabIndex = 38;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Direccion";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_direccion.Location = new System.Drawing.Point(221, 103);
            this.txt_direccion.MaxLength = 200;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(211, 20);
            this.txt_direccion.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ciudad";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ciudad.Location = new System.Drawing.Point(221, 77);
            this.txt_ciudad.MaxLength = 100;
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(211, 20);
            this.txt_ciudad.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nombre *";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nombre.Location = new System.Drawing.Point(221, 51);
            this.txt_nombre.MaxLength = 200;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(211, 20);
            this.txt_nombre.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "DNI *";
            // 
            // txt_dni
            // 
            this.txt_dni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_dni.Location = new System.Drawing.Point(221, 25);
            this.txt_dni.MaxLength = 50;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(211, 20);
            this.txt_dni.TabIndex = 34;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // pnl_botones
            // 
            this.pnl_botones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_botones.Controls.Add(this.btn_limpiar);
            this.pnl_botones.Controls.Add(this.btn_guardar);
            this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_botones.Location = new System.Drawing.Point(0, 32);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(868, 42);
            this.pnl_botones.TabIndex = 39;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.Location = new System.Drawing.Point(43, 8);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(26, 26);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(9, 8);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(26, 26);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frm_mensajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(868, 422);
            this.Controls.Add(this.dtg_mesajero);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_txt);
            this.Controls.Add(this.pnl_botones);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_mensajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_mensajero";
            this.Load += new System.EventHandler(this.frm_mensajero_Load);
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_mesajero)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_txt.ResumeLayout(false);
            this.pnl_txt.PerformLayout();
            this.pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.Label lbl_minimixar;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtg_mesajero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_tipo_busqueda;
        private System.Windows.Forms.Button btn_exportar_excel;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Panel pnl_txt;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_email;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}