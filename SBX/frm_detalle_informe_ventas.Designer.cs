
namespace SBX
{
    partial class frm_detalle_informe_ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_informe = new System.Windows.Forms.DataGridView();
            this.cl_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cantidad_exacta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_costos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Descuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_separado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_informe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_informe
            // 
            this.dtg_informe.AllowUserToAddRows = false;
            this.dtg_informe.AllowUserToDeleteRows = false;
            this.dtg_informe.AllowUserToOrderColumns = true;
            this.dtg_informe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_informe.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_informe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_informe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtg_informe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_factura,
            this.cl_usuario,
            this.cl_item,
            this.cl_codigo_barras,
            this.cl_referencia,
            this.cl_nombre,
            this.cl_cantidad,
            this.cl_cantidad_exacta,
            this.cl_um,
            this.cl_costos,
            this.cl_precio_venta,
            this.cl_Descuentos,
            this.cl_total,
            this.cl_resultado,
            this.v_modulo,
            this.cl_domicilio,
            this.cl_separado});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_informe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_informe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_informe.Location = new System.Drawing.Point(0, 0);
            this.dtg_informe.Name = "dtg_informe";
            this.dtg_informe.ReadOnly = true;
            this.dtg_informe.Size = new System.Drawing.Size(800, 450);
            this.dtg_informe.TabIndex = 11;
            // 
            // cl_factura
            // 
            this.cl_factura.HeaderText = "Factura";
            this.cl_factura.Name = "cl_factura";
            this.cl_factura.ReadOnly = true;
            // 
            // cl_usuario
            // 
            this.cl_usuario.HeaderText = "Usuario";
            this.cl_usuario.Name = "cl_usuario";
            this.cl_usuario.ReadOnly = true;
            // 
            // cl_item
            // 
            this.cl_item.FillWeight = 52.75564F;
            this.cl_item.HeaderText = "Item";
            this.cl_item.Name = "cl_item";
            this.cl_item.ReadOnly = true;
            // 
            // cl_codigo_barras
            // 
            this.cl_codigo_barras.FillWeight = 761.4211F;
            this.cl_codigo_barras.HeaderText = "Codigo Barras";
            this.cl_codigo_barras.Name = "cl_codigo_barras";
            this.cl_codigo_barras.ReadOnly = true;
            // 
            // cl_referencia
            // 
            this.cl_referencia.FillWeight = 52.75564F;
            this.cl_referencia.HeaderText = "Referencia";
            this.cl_referencia.Name = "cl_referencia";
            this.cl_referencia.ReadOnly = true;
            // 
            // cl_nombre
            // 
            this.cl_nombre.FillWeight = 52.75564F;
            this.cl_nombre.HeaderText = "Nombre";
            this.cl_nombre.Name = "cl_nombre";
            this.cl_nombre.ReadOnly = true;
            // 
            // cl_cantidad
            // 
            this.cl_cantidad.FillWeight = 52.75564F;
            this.cl_cantidad.HeaderText = "Cantidad";
            this.cl_cantidad.Name = "cl_cantidad";
            this.cl_cantidad.ReadOnly = true;
            // 
            // cl_cantidad_exacta
            // 
            this.cl_cantidad_exacta.FillWeight = 52.75564F;
            this.cl_cantidad_exacta.HeaderText = "Desc. Cantidad";
            this.cl_cantidad_exacta.Name = "cl_cantidad_exacta";
            this.cl_cantidad_exacta.ReadOnly = true;
            // 
            // cl_um
            // 
            this.cl_um.FillWeight = 52.75564F;
            this.cl_um.HeaderText = "UM";
            this.cl_um.Name = "cl_um";
            this.cl_um.ReadOnly = true;
            // 
            // cl_costos
            // 
            this.cl_costos.FillWeight = 52.75564F;
            this.cl_costos.HeaderText = "Costos";
            this.cl_costos.Name = "cl_costos";
            this.cl_costos.ReadOnly = true;
            // 
            // cl_precio_venta
            // 
            this.cl_precio_venta.FillWeight = 52.75564F;
            this.cl_precio_venta.HeaderText = "Precio venta";
            this.cl_precio_venta.Name = "cl_precio_venta";
            this.cl_precio_venta.ReadOnly = true;
            // 
            // cl_Descuentos
            // 
            this.cl_Descuentos.FillWeight = 52.75564F;
            this.cl_Descuentos.HeaderText = "Descuentos";
            this.cl_Descuentos.Name = "cl_Descuentos";
            this.cl_Descuentos.ReadOnly = true;
            // 
            // cl_total
            // 
            this.cl_total.FillWeight = 52.75564F;
            this.cl_total.HeaderText = "Total";
            this.cl_total.Name = "cl_total";
            this.cl_total.ReadOnly = true;
            // 
            // cl_resultado
            // 
            this.cl_resultado.FillWeight = 52.75564F;
            this.cl_resultado.HeaderText = "Resultado";
            this.cl_resultado.Name = "cl_resultado";
            this.cl_resultado.ReadOnly = true;
            // 
            // v_modulo
            // 
            this.v_modulo.FillWeight = 52.75564F;
            this.v_modulo.HeaderText = "Modulo";
            this.v_modulo.Name = "v_modulo";
            this.v_modulo.ReadOnly = true;
            // 
            // cl_domicilio
            // 
            this.cl_domicilio.FillWeight = 52.75564F;
            this.cl_domicilio.HeaderText = "Domicilio";
            this.cl_domicilio.Name = "cl_domicilio";
            this.cl_domicilio.ReadOnly = true;
            // 
            // cl_separado
            // 
            this.cl_separado.FillWeight = 52.75564F;
            this.cl_separado.HeaderText = "Separado";
            this.cl_separado.Name = "cl_separado";
            this.cl_separado.ReadOnly = true;
            this.cl_separado.Width = 150;
            // 
            // frm_detalle_informe_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtg_informe);
            this.Name = "frm_detalle_informe_ventas";
            this.Load += new System.EventHandler(this.frm_detalle_informe_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_informe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cantidad_exacta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_um;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_costos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Descuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_separado;
        public System.Windows.Forms.DataGridView dtg_informe;
    }
}