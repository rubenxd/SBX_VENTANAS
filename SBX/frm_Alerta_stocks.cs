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
    public partial class frm_Alerta_stocks : Form
    {
        MODEL.cls_producto cls_Producto = new MODEL.cls_producto();
        DataTable v_dt;
        public frm_Alerta_stocks()
        {
            InitializeComponent();
            cbx_tipo_busqueda.SelectedIndex = 0;
            cbx_dato_busqueda.SelectedIndex = 0;
            cbx_filtro_estado.SelectedIndex = 0;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_buscar();
        }

        private void mtd_buscar() 
        {
            this.Cursor = Cursors.WaitCursor;
            cls_Producto.v_buscar = txt_buscar.Text;
            cls_Producto.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            cls_Producto.v_data_busqueda = cbx_dato_busqueda.Text;
            v_dt = cls_Producto.mtd_consultar_producto_kardex();
            dtg_productos.DataSource = v_dt;
            this.Cursor = Cursors.Default;
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {                     
        }

        private void frm_Alerta_stocks_Load(object sender, EventArgs e)
        {
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                mtd_buscar();
            }
        }
    }
}
