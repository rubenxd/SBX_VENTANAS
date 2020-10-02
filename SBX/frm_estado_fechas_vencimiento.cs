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
    public partial class frm_estado_fechas_vencimiento : Form
    {
        MODEL.cls_producto cls_Producto = new MODEL.cls_producto();
        MODEL.cls_global cls_Global = new MODEL.cls_global();
        DataTable v_dt;
        int Validado = 0;
        public frm_estado_fechas_vencimiento()
        {
            InitializeComponent();
        }

        private void mtd_buscar()
        {
            this.Cursor = Cursors.WaitCursor;
            cls_Producto.v_buscar = txt_buscar.Text;
            cls_Producto.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            v_dt = cls_Producto.mtd_consultar_estado_fechas_vencimiento();
            dtg_productos.DataSource = v_dt;
            foreach (DataGridViewRow item in dtg_productos.Rows)
            {
                if (item.Cells["Estado"].Value.ToString() == "Vencido")
                {
                    item.Cells["Estado"].Style.BackColor = Color.OrangeRed;
                }
                if (item.Cells["Estado"].Value.ToString() == "Pronto a vencer")
                {
                    item.Cells["Estado"].Style.BackColor = Color.Gold;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {           
                mtd_buscar();            
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            
               
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                mtd_buscar();
            }
        }

        private void frm_estado_fechas_vencimiento_Load(object sender, EventArgs e)
        {
            cbx_tipo_busqueda.SelectedIndex = 0;
        }
    }
}
