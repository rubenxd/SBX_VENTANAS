namespace SBX
{
    partial class frm_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.lbl_noti = new System.Windows.Forms.Label();
            this.btn_alarma = new System.Windows.Forms.Button();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_fecha_hora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btn_Maximizar = new System.Windows.Forms.PictureBox();
            this.btn_Restaurar = new System.Windows.Forms.PictureBox();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_gastos = new System.Windows.Forms.Button();
            this.btn_caja = new System.Windows.Forms.Button();
            this.btn_separado = new System.Windows.Forms.Button();
            this.btn_domicilio = new System.Windows.Forms.Button();
            this.btn_empresa = new System.Windows.Forms.Button();
            this.btn_proveedor = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_producto = new System.Windows.Forms.Button();
            this.btn_venta = new System.Windows.Forms.Button();
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).BeginInit();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_arriba
            // 
            this.pnl_arriba.BackColor = System.Drawing.Color.SeaGreen;
            this.pnl_arriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_arriba.Controls.Add(this.lbl_noti);
            this.pnl_arriba.Controls.Add(this.btn_alarma);
            this.pnl_arriba.Controls.Add(this.lbl_usuario);
            this.pnl_arriba.Controls.Add(this.lbl_fecha_hora);
            this.pnl_arriba.Controls.Add(this.pictureBox1);
            this.pnl_arriba.Controls.Add(this.label1);
            this.pnl_arriba.Controls.Add(this.btnMinimizar);
            this.pnl_arriba.Controls.Add(this.btnCerrar);
            this.pnl_arriba.Controls.Add(this.btn_Maximizar);
            this.pnl_arriba.Controls.Add(this.btn_Restaurar);
            this.pnl_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_arriba.Name = "pnl_arriba";
            this.pnl_arriba.Size = new System.Drawing.Size(900, 30);
            this.pnl_arriba.TabIndex = 0;
            this.pnl_arriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_arriba_MouseDown);
            // 
            // lbl_noti
            // 
            this.lbl_noti.AutoSize = true;
            this.lbl_noti.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_noti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_noti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noti.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_noti.Location = new System.Drawing.Point(103, 11);
            this.lbl_noti.Name = "lbl_noti";
            this.lbl_noti.Size = new System.Drawing.Size(14, 13);
            this.lbl_noti.TabIndex = 15;
            this.lbl_noti.Text = "0";
            this.lbl_noti.Visible = false;
            // 
            // btn_alarma
            // 
            this.btn_alarma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alarma.FlatAppearance.BorderSize = 0;
            this.btn_alarma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alarma.Image = ((System.Drawing.Image)(resources.GetObject("btn_alarma.Image")));
            this.btn_alarma.Location = new System.Drawing.Point(87, 0);
            this.btn_alarma.Name = "btn_alarma";
            this.btn_alarma.Size = new System.Drawing.Size(23, 23);
            this.btn_alarma.TabIndex = 14;
            this.btn_alarma.UseVisualStyleBackColor = true;
            this.btn_alarma.Visible = false;
            this.btn_alarma.Click += new System.EventHandler(this.Btn_alarma_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_usuario.Location = new System.Drawing.Point(239, 5);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(57, 15);
            this.lbl_usuario.TabIndex = 13;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_fecha_hora
            // 
            this.lbl_fecha_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_hora.AutoSize = true;
            this.lbl_fecha_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_hora.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_fecha_hora.Location = new System.Drawing.Point(565, 5);
            this.lbl_fecha_hora.Name = "lbl_fecha_hora";
            this.lbl_fecha_hora.Size = new System.Drawing.Size(89, 15);
            this.lbl_fecha_hora.TabIndex = 12;
            this.lbl_fecha_hora.Text = "Fecha y hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(37, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "SBX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(818, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Visible = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(870, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Visible = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maximizar.Image")));
            this.btn_Maximizar.Location = new System.Drawing.Point(844, 2);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(20, 20);
            this.btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Maximizar.TabIndex = 11;
            this.btn_Maximizar.TabStop = false;
            this.btn_Maximizar.Visible = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restaurar.Image")));
            this.btn_Restaurar.Location = new System.Drawing.Point(844, 2);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(20, 20);
            this.btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Restaurar.TabIndex = 10;
            this.btn_Restaurar.TabStop = false;
            this.btn_Restaurar.Visible = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.Gray;
            this.pnl_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_menu.Controls.Add(this.btn_config);
            this.pnl_menu.Controls.Add(this.btn_reportes);
            this.pnl_menu.Controls.Add(this.btn_gastos);
            this.pnl_menu.Controls.Add(this.btn_caja);
            this.pnl_menu.Controls.Add(this.btn_separado);
            this.pnl_menu.Controls.Add(this.btn_domicilio);
            this.pnl_menu.Controls.Add(this.btn_empresa);
            this.pnl_menu.Controls.Add(this.btn_proveedor);
            this.pnl_menu.Controls.Add(this.btn_cliente);
            this.pnl_menu.Controls.Add(this.btn_inventario);
            this.pnl_menu.Controls.Add(this.btn_producto);
            this.pnl_menu.Controls.Add(this.btn_venta);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_menu.Location = new System.Drawing.Point(0, 30);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(900, 61);
            this.pnl_menu.TabIndex = 1;
            // 
            // btn_config
            // 
            this.btn_config.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_config.FlatAppearance.BorderSize = 0;
            this.btn_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_config.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_config.Image = ((System.Drawing.Image)(resources.GetObject("btn_config.Image")));
            this.btn_config.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_config.Location = new System.Drawing.Point(792, 0);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(72, 57);
            this.btn_config.TabIndex = 68;
            this.btn_config.Text = "Ajustes";
            this.btn_config.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Visible = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_reportes.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportes.Image")));
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_reportes.Location = new System.Drawing.Point(720, 0);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(72, 57);
            this.btn_reportes.TabIndex = 67;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Visible = false;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_gastos
            // 
            this.btn_gastos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_gastos.FlatAppearance.BorderSize = 0;
            this.btn_gastos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_gastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_gastos.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_gastos.Image = ((System.Drawing.Image)(resources.GetObject("btn_gastos.Image")));
            this.btn_gastos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_gastos.Location = new System.Drawing.Point(648, 0);
            this.btn_gastos.Name = "btn_gastos";
            this.btn_gastos.Size = new System.Drawing.Size(72, 57);
            this.btn_gastos.TabIndex = 66;
            this.btn_gastos.Text = "Gastos";
            this.btn_gastos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_gastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_gastos.UseVisualStyleBackColor = true;
            this.btn_gastos.Visible = false;
            this.btn_gastos.Click += new System.EventHandler(this.btn_gastos_Click);
            // 
            // btn_caja
            // 
            this.btn_caja.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_caja.FlatAppearance.BorderSize = 0;
            this.btn_caja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_caja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_caja.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_caja.Image = ((System.Drawing.Image)(resources.GetObject("btn_caja.Image")));
            this.btn_caja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_caja.Location = new System.Drawing.Point(576, 0);
            this.btn_caja.Name = "btn_caja";
            this.btn_caja.Size = new System.Drawing.Size(72, 57);
            this.btn_caja.TabIndex = 65;
            this.btn_caja.Text = "Caja";
            this.btn_caja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_caja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_caja.UseVisualStyleBackColor = true;
            this.btn_caja.Visible = false;
            this.btn_caja.Click += new System.EventHandler(this.btn_caja_Click);
            // 
            // btn_separado
            // 
            this.btn_separado.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_separado.FlatAppearance.BorderSize = 0;
            this.btn_separado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_separado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_separado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_separado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_separado.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_separado.Image = ((System.Drawing.Image)(resources.GetObject("btn_separado.Image")));
            this.btn_separado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_separado.Location = new System.Drawing.Point(504, 0);
            this.btn_separado.Name = "btn_separado";
            this.btn_separado.Size = new System.Drawing.Size(72, 57);
            this.btn_separado.TabIndex = 64;
            this.btn_separado.Text = " Separado";
            this.btn_separado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_separado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_separado.UseVisualStyleBackColor = true;
            this.btn_separado.Visible = false;
            this.btn_separado.Click += new System.EventHandler(this.btn_separado_Click);
            // 
            // btn_domicilio
            // 
            this.btn_domicilio.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_domicilio.FlatAppearance.BorderSize = 0;
            this.btn_domicilio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_domicilio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_domicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_domicilio.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_domicilio.Image = ((System.Drawing.Image)(resources.GetObject("btn_domicilio.Image")));
            this.btn_domicilio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_domicilio.Location = new System.Drawing.Point(432, 0);
            this.btn_domicilio.Name = "btn_domicilio";
            this.btn_domicilio.Size = new System.Drawing.Size(72, 57);
            this.btn_domicilio.TabIndex = 61;
            this.btn_domicilio.Text = " Domicilio";
            this.btn_domicilio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_domicilio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_domicilio.UseVisualStyleBackColor = true;
            this.btn_domicilio.Visible = false;
            this.btn_domicilio.Click += new System.EventHandler(this.btnDomicilio_Click);
            // 
            // btn_empresa
            // 
            this.btn_empresa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_empresa.FlatAppearance.BorderSize = 0;
            this.btn_empresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_empresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empresa.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_empresa.Image = ((System.Drawing.Image)(resources.GetObject("btn_empresa.Image")));
            this.btn_empresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_empresa.Location = new System.Drawing.Point(360, 0);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(72, 57);
            this.btn_empresa.TabIndex = 5;
            this.btn_empresa.Text = "Empresa";
            this.btn_empresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_empresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_empresa.UseVisualStyleBackColor = true;
            this.btn_empresa.Visible = false;
            this.btn_empresa.Click += new System.EventHandler(this.btn_empresa_Click);
            // 
            // btn_proveedor
            // 
            this.btn_proveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_proveedor.FlatAppearance.BorderSize = 0;
            this.btn_proveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_proveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proveedor.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_proveedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_proveedor.Image")));
            this.btn_proveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_proveedor.Location = new System.Drawing.Point(288, 0);
            this.btn_proveedor.Name = "btn_proveedor";
            this.btn_proveedor.Size = new System.Drawing.Size(72, 57);
            this.btn_proveedor.TabIndex = 4;
            this.btn_proveedor.Text = "Proveedo";
            this.btn_proveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_proveedor.UseVisualStyleBackColor = true;
            this.btn_proveedor.Visible = false;
            this.btn_proveedor.Click += new System.EventHandler(this.btn_proveedor_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_cliente.Image")));
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cliente.Location = new System.Drawing.Point(216, 0);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(72, 57);
            this.btn_cliente.TabIndex = 3;
            this.btn_cliente.Text = " Cliente";
            this.btn_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Visible = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.BackColor = System.Drawing.Color.Gray;
            this.btn_inventario.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_inventario.FlatAppearance.BorderSize = 0;
            this.btn_inventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventario.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_inventario.Image = ((System.Drawing.Image)(resources.GetObject("btn_inventario.Image")));
            this.btn_inventario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_inventario.Location = new System.Drawing.Point(144, 0);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(72, 57);
            this.btn_inventario.TabIndex = 2;
            this.btn_inventario.Text = " Inventario";
            this.btn_inventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_inventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_inventario.UseVisualStyleBackColor = false;
            this.btn_inventario.Visible = false;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_producto
            // 
            this.btn_producto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_producto.FlatAppearance.BorderSize = 0;
            this.btn_producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_producto.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_producto.Image")));
            this.btn_producto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_producto.Location = new System.Drawing.Point(72, 0);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(72, 57);
            this.btn_producto.TabIndex = 1;
            this.btn_producto.Text = "Producto";
            this.btn_producto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Visible = false;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // btn_venta
            // 
            this.btn_venta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_venta.FlatAppearance.BorderSize = 0;
            this.btn_venta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venta.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_venta.Image = ((System.Drawing.Image)(resources.GetObject("btn_venta.Image")));
            this.btn_venta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_venta.Location = new System.Drawing.Point(0, 0);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(72, 57);
            this.btn_venta.TabIndex = 0;
            this.btn_venta.Text = " Venta";
            this.btn_venta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_venta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_venta.UseVisualStyleBackColor = true;
            this.btn_venta.Visible = false;
            this.btn_venta.Click += new System.EventHandler(this.btn_venta_Click);
            // 
            // pnl_centro
            // 
            this.pnl_centro.BackColor = System.Drawing.SystemColors.Menu;
            this.pnl_centro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centro.Location = new System.Drawing.Point(0, 91);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(900, 509);
            this.pnl_centro.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnl_centro);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_inicio_FormClosing);
            this.Load += new System.EventHandler(this.frm_inicio_Load);
            this.pnl_arriba.ResumeLayout(false);
            this.pnl_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arriba;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnl_menu;
        public System.Windows.Forms.Button btn_venta;
        public System.Windows.Forms.Button btn_producto;
        public System.Windows.Forms.Button btn_inventario;
        public System.Windows.Forms.Button btn_cliente;
        public System.Windows.Forms.Button btn_proveedor;
        public System.Windows.Forms.Button btn_empresa;
        private System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_Restaurar;
        public System.Windows.Forms.PictureBox btn_Maximizar;
        public System.Windows.Forms.Button btn_domicilio;
        public System.Windows.Forms.Button btn_separado;
        private System.Windows.Forms.Label lbl_fecha_hora;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Button btn_gastos;
        public System.Windows.Forms.Button btn_caja;
        public System.Windows.Forms.Button btn_reportes;
        public System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_alarma;
        private System.Windows.Forms.Label lbl_noti;
        private System.Windows.Forms.Timer timer1;
    }
}