namespace SBX
{
    partial class frm_aplicar_domicilio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_aplicar_domicilio));
            this.pnl_arriba = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.pbl_boton = new System.Windows.Forms.Panel();
            this.btn_add_mensajero = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.lbl_nombre_mensajero = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_valor_domicilio = new System.Windows.Forms.TextBox();
            this.btn_buscar_mensajero = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mensajero = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_nomSuc = new System.Windows.Forms.Label();
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
            this.pnl_arriba.Size = new System.Drawing.Size(364, 28);
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
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Domicilio";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_cerrar.Location = new System.Drawing.Point(337, 3);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(17, 16);
            this.lbl_cerrar.TabIndex = 0;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // pbl_boton
            // 
            this.pbl_boton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbl_boton.Controls.Add(this.btn_add_mensajero);
            this.pbl_boton.Controls.Add(this.btn_cliente);
            this.pbl_boton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbl_boton.Location = new System.Drawing.Point(0, 28);
            this.pbl_boton.Name = "pbl_boton";
            this.pbl_boton.Size = new System.Drawing.Size(364, 37);
            this.pbl_boton.TabIndex = 0;
            // 
            // btn_add_mensajero
            // 
            this.btn_add_mensajero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_mensajero.BackColor = System.Drawing.Color.White;
            this.btn_add_mensajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_mensajero.FlatAppearance.BorderSize = 0;
            this.btn_add_mensajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_add_mensajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_mensajero.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_mensajero.Image")));
            this.btn_add_mensajero.Location = new System.Drawing.Point(40, 4);
            this.btn_add_mensajero.Name = "btn_add_mensajero";
            this.btn_add_mensajero.Size = new System.Drawing.Size(26, 26);
            this.btn_add_mensajero.TabIndex = 1;
            this.btn_add_mensajero.UseVisualStyleBackColor = false;
            this.btn_add_mensajero.Click += new System.EventHandler(this.btn_add_mensajero_Click);
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
            this.btn_cliente.Location = new System.Drawing.Point(5, 5);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(26, 26);
            this.btn_cliente.TabIndex = 0;
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // pnl_centro
            // 
            this.pnl_centro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_centro.Controls.Add(this.lbl_nomSuc);
            this.pnl_centro.Controls.Add(this.lbl_codigo);
            this.pnl_centro.Controls.Add(this.label9);
            this.pnl_centro.Controls.Add(this.lbl_nombre_mensajero);
            this.pnl_centro.Controls.Add(this.btn_limpiar);
            this.pnl_centro.Controls.Add(this.btn_cancelar);
            this.pnl_centro.Controls.Add(this.btn_guardar);
            this.pnl_centro.Controls.Add(this.label8);
            this.pnl_centro.Controls.Add(this.txt_valor_domicilio);
            this.pnl_centro.Controls.Add(this.btn_buscar_mensajero);
            this.pnl_centro.Controls.Add(this.label7);
            this.pnl_centro.Controls.Add(this.txt_mensajero);
            this.pnl_centro.Controls.Add(this.btn_buscar);
            this.pnl_centro.Controls.Add(this.label4);
            this.pnl_centro.Controls.Add(this.txt_dni);
            this.pnl_centro.Controls.Add(this.label6);
            this.pnl_centro.Controls.Add(this.txt_telefono);
            this.pnl_centro.Controls.Add(this.label5);
            this.pnl_centro.Controls.Add(this.txt_direccion);
            this.pnl_centro.Controls.Add(this.label3);
            this.pnl_centro.Controls.Add(this.txt_nombre);
            this.pnl_centro.Controls.Add(this.label2);
            this.pnl_centro.Controls.Add(this.txt_celular);
            this.pnl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centro.Location = new System.Drawing.Point(0, 65);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(364, 358);
            this.pnl_centro.TabIndex = 1;
            // 
            // lbl_nombre_mensajero
            // 
            this.lbl_nombre_mensajero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_nombre_mensajero.AutoSize = true;
            this.lbl_nombre_mensajero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_mensajero.Location = new System.Drawing.Point(96, 224);
            this.lbl_nombre_mensajero.Name = "lbl_nombre_mensajero";
            this.lbl_nombre_mensajero.Size = new System.Drawing.Size(15, 15);
            this.lbl_nombre_mensajero.TabIndex = 91;
            this.lbl_nombre_mensajero.Text = "--";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.DimGray;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(147, 291);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(66, 30);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
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
            this.btn_cancelar.Location = new System.Drawing.Point(219, 291);
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
            this.btn_guardar.Location = new System.Drawing.Point(75, 291);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(66, 30);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 87;
            this.label8.Text = "Vlr. domicilio";
            // 
            // txt_valor_domicilio
            // 
            this.txt_valor_domicilio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_valor_domicilio.Location = new System.Drawing.Point(96, 250);
            this.txt_valor_domicilio.MaxLength = 10;
            this.txt_valor_domicilio.Name = "txt_valor_domicilio";
            this.txt_valor_domicilio.Size = new System.Drawing.Size(211, 20);
            this.txt_valor_domicilio.TabIndex = 8;
            this.txt_valor_domicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_domicilio_KeyPress);
            // 
            // btn_buscar_mensajero
            // 
            this.btn_buscar_mensajero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_buscar_mensajero.BackColor = System.Drawing.SystemColors.Window;
            this.btn_buscar_mensajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_mensajero.FlatAppearance.BorderSize = 0;
            this.btn_buscar_mensajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_buscar_mensajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_mensajero.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_mensajero.Image")));
            this.btn_buscar_mensajero.Location = new System.Drawing.Point(325, 196);
            this.btn_buscar_mensajero.Name = "btn_buscar_mensajero";
            this.btn_buscar_mensajero.Size = new System.Drawing.Size(22, 22);
            this.btn_buscar_mensajero.TabIndex = 7;
            this.btn_buscar_mensajero.UseVisualStyleBackColor = false;
            this.btn_buscar_mensajero.Click += new System.EventHandler(this.btn_buscar_mensajero_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 83;
            this.label7.Text = "Mensajero";
            // 
            // txt_mensajero
            // 
            this.txt_mensajero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mensajero.Location = new System.Drawing.Point(96, 198);
            this.txt_mensajero.MaxLength = 10;
            this.txt_mensajero.Name = "txt_mensajero";
            this.txt_mensajero.Size = new System.Drawing.Size(211, 20);
            this.txt_mensajero.TabIndex = 6;
            this.txt_mensajero.Text = "0";
            this.txt_mensajero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mensajero_KeyPress);
            this.txt_mensajero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_mensajero_KeyUp);
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
            this.btn_buscar.Location = new System.Drawing.Point(325, 9);
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
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 80;
            this.label4.Text = "DNI";
            // 
            // txt_dni
            // 
            this.txt_dni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_dni.Location = new System.Drawing.Point(96, 11);
            this.txt_dni.MaxLength = 10;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(211, 20);
            this.txt_dni.TabIndex = 0;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            this.txt_dni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dni_KeyUp);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 79;
            this.label6.Text = "Telefono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_telefono.Location = new System.Drawing.Point(96, 172);
            this.txt_telefono.MaxLength = 10;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(211, 20);
            this.txt_telefono.TabIndex = 5;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 77;
            this.label5.Text = "Direccion *";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_direccion.Location = new System.Drawing.Point(96, 116);
            this.txt_direccion.MaxLength = 200;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(211, 50);
            this.txt_direccion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 75;
            this.label3.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nombre.Location = new System.Drawing.Point(96, 90);
            this.txt_nombre.MaxLength = 200;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(211, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Celular *";
            // 
            // txt_celular
            // 
            this.txt_celular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_celular.Location = new System.Drawing.Point(96, 64);
            this.txt_celular.MaxLength = 12;
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(211, 20);
            this.txt_celular.TabIndex = 2;
            this.txt_celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_celular_KeyPress);
            this.txt_celular.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_celular_KeyUp);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 93;
            this.label9.Text = "Sucursal";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(96, 39);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(0, 15);
            this.lbl_codigo.TabIndex = 94;
            // 
            // lbl_nomSuc
            // 
            this.lbl_nomSuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_nomSuc.AutoSize = true;
            this.lbl_nomSuc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomSuc.Location = new System.Drawing.Point(125, 39);
            this.lbl_nomSuc.Name = "lbl_nomSuc";
            this.lbl_nomSuc.Size = new System.Drawing.Size(0, 15);
            this.lbl_nomSuc.TabIndex = 95;
            // 
            // frm_aplicar_domicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 423);
            this.Controls.Add(this.pnl_centro);
            this.Controls.Add(this.pbl_boton);
            this.Controls.Add(this.pnl_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_aplicar_domicilio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_aplicar_domicilio";
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
        private System.Windows.Forms.Button btn_add_mensajero;
        private System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_valor_domicilio;
        private System.Windows.Forms.Button btn_buscar_mensajero;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_mensajero;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lbl_nombre_mensajero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_nomSuc;
    }
}