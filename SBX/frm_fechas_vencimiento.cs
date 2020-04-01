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
    public partial class frm_fechas_vencimiento : Form
    {
        MODEL.cls_producto cls_Productos = new MODEL.cls_producto();
        public string Item { get; set; }
        DataTable dt;
        int fila;
        int contador;
        bool OK;
        private void Frm_fechas_vencimiento_Load(object sender, EventArgs e)
        {
            lbl_item.Text = Item;
            mtd_cargar_fechas();
        }
        public frm_fechas_vencimiento()
        {     
            InitializeComponent();
        }
        private void mtd_cargar_fechas()
        {
            cls_Productos.Item = lbl_item.Text;
            dt = cls_Productos.mtd_consultar_fechas_vecimiento();
            dtg_fechas_vencimiento.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                contador = 0;
                fila = dt.Rows.Count;
                dtg_fechas_vencimiento.Rows.Add(fila);
                foreach (DataRow rows in dt.Rows)
                {
                    dtg_fechas_vencimiento.Rows[contador].Cells["cl_item"].Value = rows["Item"];
                    dtg_fechas_vencimiento.Rows[contador].Cells["cl_fecha_vencimiento"].Value = rows["FechaVecimiento"];
                    contador++;
                }
            }
        }
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            DateTime FechaVence;
            if (dtg_fechas_vencimiento.Rows.Count > 0)
            {
                foreach (DataGridViewRow rowss in dtg_fechas_vencimiento.SelectedRows)
                {
                    cls_Productos.Item = rowss.Cells["cl_item"].Value.ToString();
                  
                    FechaVence = Convert.ToDateTime(rowss.Cells["cl_fecha_vencimiento"].Value);
                    cls_Productos.FechaVencimiento = FechaVence.ToString("yyyy-MM-dd");
                    cls_Productos.mtd_eliminar_fecha_vencimiento();
                }
            }
                frm_msg msg = new frm_msg();
                msg.txt_mensaje.Text = "Fecha de vencimiento Eliminada correctamente";
                msg.ShowDialog();

                mtd_cargar_fechas();
        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OK = cls_Productos.mtd_registrar_fecha_vencimiento(lbl_item.Text,dtp_fecha_vence.Value.ToString());
            if (OK == true)
            {
                frm_msg msg = new frm_msg();
                msg.txt_mensaje.Text = "Fecha de vencimiento Guardada correctamente";
                msg.ShowDialog();

                mtd_cargar_fechas();
            }
        }

        private void Lbl_cerrar_b_n_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
