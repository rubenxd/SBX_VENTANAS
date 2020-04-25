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
    public partial class frm_movimientos : Form
    {
        //instancias
        cls_kardex cls_Kardex = new cls_kardex();

        //Variables
        DataTable v_dt;
        int v_fila = 0;
        int v_contador = 0;
        double v_valores = 0;
        bool v_confirmacion;

       

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Inico formulario
        public frm_movimientos()
        {
            InitializeComponent();
            cbx_tipo_busqueda.SelectedIndex = 0;
            MensajeInformativoBotones();
        }

        //Metodos
        private void mtd_consultar_movimientos()
        {
        
            if (txt_buscar.Text == "Item-Nombre-Referencia-Codigo barras")
            {
                cls_Kardex.v_buscar = "";
            }
            else
            {
                cls_Kardex.v_buscar = txt_buscar.Text;
            }
            cls_Kardex.Fecha_inicio = dtp_fecha_inicio.Value;
            cls_Kardex.Fecha_fin = dtp_fecha_fin.Value;
            cls_Kardex.Tipo_busqueda = cbx_tipo_busqueda.Text;
            v_dt = cls_Kardex.mtd_consultar_movimientos();
            dtg_movimientos.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                v_contador = 0;
                v_fila = v_dt.Rows.Count;
                dtg_movimientos.Rows.Add(v_fila);
                foreach (DataRow rows in v_dt.Rows)
                {                    
                    dtg_movimientos.Rows[v_contador].Cells["cl_codigo_movimiento"].Value = rows["Codigo"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_fecha_registro"].Value = rows["FechaRegistro"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_movimiento"].Value = rows["Movimiento"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_item"].Value = string.Format("{0:0000}", rows["Item"]);
                    dtg_movimientos.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_referencia"].Value = rows["Referencia"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_codigo_barras"].Value = rows["CodigoBarras"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_modo_venta"].Value = rows["ModoVenta"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_UM"].Value = rows["UM"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_cantidad"].Value = rows["Cantidad"];    
                    v_valores = Convert.ToDouble(rows["Costo"]);
                    dtg_movimientos.Rows[v_contador].Cells["cl_costo"].Value = v_valores.ToString("N");
                    v_valores = Convert.ToDouble(rows["PrecioVenta"]);
                    dtg_movimientos.Rows[v_contador].Cells["cl_precio_venta"].Value = v_valores.ToString("N");
                    dtg_movimientos.Rows[v_contador].Cells["cl_nota"].Value = rows["Nota"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_dni"].Value = rows["DNIproveedor"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_proveedor"].Value = rows["Proveedor"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_accion"].Value = rows["Accion"];
                    dtg_movimientos.Rows[v_contador].Cells["cl_usuario"].Value = rows["NombreUsuario"];
                    v_contador++;
                }     
            }
        }
        private void mtd_exporta_excel()
        {
            frm_exportar_excel frm_Exportando_excel = new frm_exportar_excel();
            frm_Exportando_excel.Show();

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;

            frm_Exportando_excel.mtd_progreso(20);

            foreach (DataColumn columna in v_dt.Columns)
            {
                IndiceColumna++;
                Excel.Cells[1, IndiceColumna] = columna.ColumnName;
            }
            frm_Exportando_excel.mtd_progreso(70);
            int IndiceFila = 0;

            foreach (DataRow Row in v_dt.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;

                foreach (DataColumn Columna in v_dt.Columns)
                {
                    IndiceColumna++;
                    Excel.Cells[IndiceFila + 1, IndiceColumna] = Row[Columna.ColumnName];

                }
            }
            frm_Exportando_excel.mtd_progreso(100);
            frm_Exportando_excel.Hide();

            Excel.Visible = true;
        }
        public void MensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar");
            Botones.SetToolTip(btn_exportar_excel, "Exportar a excel");
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        //metodo no esta en uso debido a que para mantener el historial de movimientos
        //del producto no se eliminan los movimientos
        //private void mtd_eliminar()
        //{
        //    if (dtg_movimientos.Rows.Count > 0)
        //    {
        //        frm_confirmacion frm_Confirmacion = new frm_confirmacion();
        //        frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
        //        frm_Confirmacion.pnl_arriba.BackColor = Color.OrangeRed;
        //        v_contador = dtg_movimientos.SelectedRows.Count;
        //        frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar "+v_contador+" movimientos?";
        //        frm_Confirmacion.ShowDialog();
        //        if (v_confirmacion == true)
        //        {
        //            //Eliminar todos los movimientos seleccionados
        //            foreach (DataGridViewRow rows in dtg_movimientos.SelectedRows)
        //            {
        //                cls_Kardex.Codigo = Convert.ToInt32(rows.Cells["cl_codigo_movimiento"].Value);
        //                v_ok = cls_Kardex.mtd_eliminar();
        //                if (v_ok)
        //                {
        //                    Eliminados++;
        //                }
        //                else
        //                {
        //                    Error++;
        //                }
        //            }

        //            frm_msg frm_Msg = new frm_msg();
        //            frm_Msg.pnl_arriba.BackColor = Color.DimGray;
        //            lbl_titulo.Text = "Eliminar";
        //            frm_Msg.txt_mensaje.Text = "Eliminados: "+Eliminados+", Errores: "+Error;
        //            frm_Msg.ShowDialog();
        //        }
        //    }      
        //}


        //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_consultar_movimientos();
        }
        private void lbl_minimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "Item-Nombre-Referencia-Codigo barras")
            {
                txt_buscar.Text = "";
                txt_buscar.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "Item-Nombre-Referencia-Codigo barras";
                txt_buscar.ForeColor = Color.Silver;
            }
        }
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Enter
            if (e.KeyChar == (char)13)
            {
                mtd_consultar_movimientos();
            }
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_consultar_movimientos();
        }
        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            mtd_exporta_excel();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lbl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
