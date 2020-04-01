using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBX.MODEL;
using System.Runtime.InteropServices;

namespace SBX
{
    public partial class frm_prod_mas_vendido : Form
    {
        cls_producto cls_Produc = new cls_producto();
        DataTable DT;
        int Contador = 0;
        int Filas = 0;
        public frm_prod_mas_vendido()
        {
            InitializeComponent();
        }
        private void frm_prod_mas_vendido_Load(object sender, EventArgs e)
        {
            cbx_tipo_busqueda.SelectedIndex = 0;
        }

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void mtd_buscar()
        {
            cls_Produc.v_buscar = txt_buscar.Text;
            cls_Produc.v_tipo_busqueda = cbx_tipo_busqueda.Text;

            DT = cls_Produc.mtd_consultar_pro_mas_vendido(Convert.ToDateTime(dtp_fecha_inicio.Text), Convert.ToDateTime(dtp_fecha_fin.Text));
            dtg_informe.Rows.Clear();
            if (DT.Rows.Count > 0)
            {
                Contador = 0;
                Filas = DT.Rows.Count;
                dtg_informe.Rows.Add(Filas);
                foreach (DataRow rows in DT.Rows)
                {
                    dtg_informe.Rows[Contador].Cells["cl_item"].Value = rows["Item"];
                    dtg_informe.Rows[Contador].Cells["cl_nombre"].Value = rows["Nombre"];
                    double PrecioVenta = Convert.ToDouble(rows["PrecioVenta"]);
                    dtg_informe.Rows[Contador].Cells["cl_precio_Venta"].Value = PrecioVenta.ToString("N0");
                    dtg_informe.Rows[Contador].Cells["cl_modo_v"].Value = rows["ModoVenta"];
                    dtg_informe.Rows[Contador].Cells["cl_um"].Value = rows["UM"];
                    dtg_informe.Rows[Contador].Cells["cl_cantidad"].Value = rows["Cantidad_global"];
                    dtg_informe.Rows[Contador].Cells["cl_und_um"].Value = rows["UND_UM"];
                    Contador++;
                }
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_buscar();
        }
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_buscar();
        }
        private void pnl_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Dtg_informe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
