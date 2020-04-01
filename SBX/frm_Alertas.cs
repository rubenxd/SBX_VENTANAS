using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX
{
    public partial class frm_Alertas : Form
    {
        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        MODEL.cls_producto cl_produc = new MODEL.cls_producto();
        DataTable v_dt;
        DataTable v_dt_2;
        DataRow rows2;
        int v_fila = 0;
        int v_contador = 0;
        public frm_Alertas()
        {
            InitializeComponent();
        }

        private void Lbl_cerrar_b_n_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Metodos
        private void mtd_consultar_producto_fecha_vence() 
        {
            cl_produc.v_buscar = txt_buscar.Text;
            v_dt = cl_produc.mtd_consultar_Fechas_vence();
            dtg_informe.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                v_fila = v_dt.Rows.Count;
                dtg_informe.Rows.Add(v_fila);
                v_contador = 0;
                foreach (DataRow rows in v_dt.Rows)
                {                   
                    cl_produc.v_buscar = rows["Item"].ToString();
                    v_dt_2 = cl_produc.mtd_consultar_producto_stocks();
                    if (v_dt_2.Rows.Count > 0)
                    {
                        rows2 = v_dt_2.Rows[0];
                        if (Convert.ToDouble(rows2["Stock"]) > 0)
                        {
                            dtg_informe.Rows[v_contador].Cells["cl_item"].Value = string.Format("{0:0000}", rows["Item"]);
                            dtg_informe.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"];
                            dtg_informe.Rows[v_contador].Cells["cl_fecha_vence"].Value = rows["FechaVecimiento"];
                            dtg_informe.Rows[v_contador].Cells["cl_estado"].Value = rows["Estado"];
                            if (rows["Estado"].ToString() == "Vencido")
                            {
                                dtg_informe.Rows[v_contador].Cells["cl_estado"].Style.BackColor = Color.OrangeRed;
                            }
                            if (rows["Estado"].ToString() == "Pronto a vencer")
                            {
                                dtg_informe.Rows[v_contador].Cells["cl_estado"].Style.BackColor = Color.Yellow;
                            }
                            v_contador++;
                        }
                        else
                        {
                            dtg_informe.Rows.RemoveAt(v_contador);
                        }
                    } 
                }
            }
        }
        private void mtd_consultar_producto_stocks()
        {
            cl_produc.v_buscar = txt_buscar_stock.Text;
            v_dt = cl_produc.mtd_consultar_producto_stocks();
            dtg_stocks.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                v_fila = v_dt.Rows.Count;
                dtg_stocks.Rows.Add(v_fila);
                v_contador = 0;
                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_stocks.Rows[v_contador].Cells["cl_item_s"].Value = string.Format("{0:0000}", rows["Item"]);
                    dtg_stocks.Rows[v_contador].Cells["cl_nombre_s"].Value = rows["Nombre"];
                    dtg_stocks.Rows[v_contador].Cells["cl_stock"].Value = rows["Stock"];
                    dtg_stocks.Rows[v_contador].Cells["cl_stock_min"].Value = rows["Alerta_Stock_minimo"];
                    dtg_stocks.Rows[v_contador].Cells["cl_stock_max"].Value = rows["Alerta_Stock_Maximo"];
                    dtg_stocks.Rows[v_contador].Cells["cl_agotado"].Value = rows["Alerta_stock_agotado"];
                    if (rows["Alerta_Stock_minimo"].ToString() != "")
                    {
                        dtg_stocks.Rows[v_contador].Cells["cl_stock_min"].Style.BackColor = Color.Yellow;
                    }
                    if (rows["Alerta_Stock_Maximo"].ToString() != "")
                    {
                        dtg_stocks.Rows[v_contador].Cells["cl_stock_max"].Style.BackColor = Color.Yellow;
                    }
                    if (rows["Alerta_stock_agotado"].ToString() != "")
                    {
                        dtg_stocks.Rows[v_contador].Cells["cl_agotado"].Style.BackColor = Color.OrangeRed;
                    }

                    v_contador++;
                }
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_consultar_producto_fecha_vence();
        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_consultar_producto_fecha_vence();
        }

        private void Btn_bus_Click(object sender, EventArgs e)
        {
            mtd_consultar_producto_stocks();
        }

        private void Txt_buscar_stock_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_consultar_producto_stocks();
        }

        private void Pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
