using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX
{
    public partial class frm_prueba_consultas : Form
    {
        public frm_prueba_consultas()
        {
            InitializeComponent();
            cbx_dato_busqueda.SelectedIndex = 0;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MODEL.cls_producto cls_Producto = new MODEL.cls_producto();
            cls_Producto.v_tipo_busqueda = "Buscar_data_producto";
            cls_Producto.v_buscar = txt_buscar.Text;
            cls_Producto.Item = "";
            cls_Producto.Referencia = "";
            cls_Producto.CodigoBarras = "";
            cls_Producto.v_data_busqueda = cbx_dato_busqueda.Text;
            dataGridView1.DataSource = cls_Producto.mtd_consultar_producto_pruebas();
            this.Cursor = Cursors.Default;
        }
    }
}
