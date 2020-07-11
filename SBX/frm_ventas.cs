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
using CrystalDecisions.Shared;

namespace SBX
{
    public partial class frm_ventas : Form
    {
        cls_venta cls_Venta = new cls_venta();

        //Variables
        DataTable v_dt;
        int v_fila = 0;
        int v_contador = 0;
        bool v_confirmacion;
        bool v_ok;
        int Eliminados;
        int Error;
        public DataTable v_dt_Permi { get; set; }

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public frm_ventas()
        {
            InitializeComponent();
            cbx_tipo_busqueda.SelectedIndex = 0;
            lbl_total_ventas.Text = "0";
            lbl_cantidad.Text = "0";
        }

        //metodos
        private void mtd_cargar_ventas()
        {
            cls_Venta.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            if (txt_buscar.Text == "Producto-Factura")
            {
                cls_Venta.v_buscar = "";
            }
            else
            {
                cls_Venta.v_buscar = txt_buscar.Text;
            }
            cls_Venta.v_tipo_busqueda = cbx_tipo_busqueda.Text;
           
            cls_Venta.Fecha_inicio = dtp_fecha_inicio.Value.ToString();
            cls_Venta.Fecha_fin = dtp_fecha_fin.Value.ToString();
            v_dt = cls_Venta.mtd_consultar_Venta();
            dtg_ventas.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                v_fila = v_dt.Rows.Count;
                dtg_ventas.Rows.Add(v_fila);
                v_contador = 0;
                lbl_total_ventas.Text = "0";
                double VentasTotales = 0;
                double CantidadVenta = 0;
                string Factura = "";
                
                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_ventas.Rows[v_contador].Cells["cl_codigo"].Value = rows["Codigo"];
                    dtg_ventas.Rows[v_contador].Cells["cl_fecha"].Value = rows["Fecha"];
                    dtg_ventas.Rows[v_contador].Cells["cl_factura"].Value = rows["Factura"];
                    dtg_ventas.Rows[v_contador].Cells["cl_item"].Value = rows["Item"];
                    dtg_ventas.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"];
                    dtg_ventas.Rows[v_contador].Cells["cl_referencia"].Value = rows["Referencia"];
                    dtg_ventas.Rows[v_contador].Cells["cl_codigo_baras"].Value = rows["CodigoBarras"];
                    dtg_ventas.Rows[v_contador].Cells["cl_modo_venta"].Value = rows["ModoVenta"];
                    dtg_ventas.Rows[v_contador].Cells["cl_um"].Value = rows["UM"];
                    CantidadVenta += Convert.ToDouble(rows["Cantidad"]);
                    dtg_ventas.Rows[v_contador].Cells["cl_cantidad"].Value = rows["Cantidad"];
                    double costo = Convert.ToDouble(rows["Costo"]);
                    dtg_ventas.Rows[v_contador].Cells["cl_costo"].Value = costo.ToString("N2");
                    double PrecioVenta = Convert.ToDouble(rows["PrecioVenta"]) ;
                    dtg_ventas.Rows[v_contador].Cells["cl_precio_venta"].Value = PrecioVenta.ToString("N2");
                    dtg_ventas.Rows[v_contador].Cells["descuento"].Value = rows["descuento"];
                    double ValorDescuento = Convert.ToDouble(rows["ValorDescuento"]);
                    dtg_ventas.Rows[v_contador].Cells["cl_valor_descuento"].Value = ValorDescuento.ToString("N2");
                    double Efectivo = Convert.ToDouble(rows["Efectivo"]);
                    dtg_ventas.Rows[v_contador].Cells["cl_efectivo"].Value = Efectivo.ToString("N2");
                    double Tdebito = Convert.ToDouble(rows["Tdebito"]);
                    dtg_ventas.Rows[v_contador].Cells["cl_t_debito"].Value = Tdebito.ToString("N2");
                    double Tcredito = Convert.ToDouble(rows["Tcredito"]);
                    dtg_ventas.Rows[v_contador].Cells["cl_t_credito"].Value = Tcredito.ToString("N2");
                    dtg_ventas.Rows[v_contador].Cells["cl_num_baucher_d"].Value = rows["NumBaucherDebito"];
                    dtg_ventas.Rows[v_contador].Cells["cl_num_baucher_c"].Value = rows["NumBaucherCredito"];
                    double Cambio = Convert.ToDouble(rows["Cambio"]);
                    dtg_ventas.Rows[v_contador].Cells["cl_cambio"].Value = Cambio.ToString("N2");
                    double Total = Convert.ToDouble(rows["Total"]);
                    if (Factura == "")
                    {
                        VentasTotales = Total;
                    }
                    else
                    {
                        //Factura = rows["Factura"].ToString();
                        if (Factura != rows["Factura"].ToString())
                        {
                            VentasTotales += Total;
                        }           
                    }
             
                    dtg_ventas.Rows[v_contador].Cells["cl_Total"].Value = Total.ToString("N2");
                    dtg_ventas.Rows[v_contador].Cells["cl_Usuario"].Value = rows["Usuario"];
                    dtg_ventas.Rows[v_contador].Cells["cl_cliente"].Value = rows["Cliente"];
                    dtg_ventas.Rows[v_contador].Cells["cl_sucursal"].Value = rows["Sucursal"];
                    dtg_ventas.Rows[v_contador].Cells["cl_domicilio"].Value = rows["Domicilio"];
                    Factura = rows["Factura"].ToString();
                    v_contador++;
                }

                lbl_total_ventas.Text = VentasTotales.ToString("N");
                lbl_cantidad.Text = CantidadVenta.ToString();
            }
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        private void mtd_eliminar()
        {
            frm_confirmacion frm_Confirmacion = new frm_confirmacion();
            if (dtg_ventas.Rows.Count > 0)
            {
                if (dtg_ventas.SelectedRows.Count > 0)
                { 
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    v_contador = dtg_ventas.SelectedRows.Count;
                    frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + "  Ventas?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    {
                        Eliminados = 0;
                        Error = 0;
                        foreach (DataGridViewRow rows in dtg_ventas.SelectedRows)
                        { 
                            int num = Convert.ToInt32(rows.Cells["cl_codigo"].Value);
                            cls_Venta.Codigo = num;
                            v_ok = cls_Venta.mtd_eliminar();
                            if (v_ok)
                            {
                                Eliminados++;
                            }
                            else
                            {
                                Error++;
                            }
                        }
                        frm_msg frm_Msg = new frm_msg();
                        frm_Msg.pnl_arriba.BackColor = Color.DimGray;
                        frm_Msg.lbl_titulo.Text = "Eliminar";
                        frm_Msg.txt_mensaje.Text = "Eliminados: " + Eliminados + ", Errores: " + Error;
                        frm_Msg.ShowDialog();
                    }
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

        //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_cargar_ventas();
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
           // mtd_cargar_ventas();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            mtd_eliminar();
            mtd_cargar_ventas();
        }
        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            cls_Venta.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            if (txt_buscar.Text == "Producto-Factura")
            {
                cls_Venta.v_buscar = "";
            }
            else
            {
                cls_Venta.v_buscar = txt_buscar.Text;
            }
            cls_Venta.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            cls_Venta.Fecha_inicio = dtp_fecha_inicio.Value.ToString();
            cls_Venta.Fecha_fin = dtp_fecha_fin.Value.ToString();
            v_dt = cls_Venta.mtd_consultar_Venta();
            mtd_exporta_excel();
        }
        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "Producto-Factura")
            {
                txt_buscar.Text = "";
                txt_buscar.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "Producto-Factura";
                txt_buscar.ForeColor = Color.Silver;
            }
        }
        private void lbl_minimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pnl_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Frm_ventas_Load(object sender, EventArgs e)
        {
            foreach (DataRow rows in v_dt_Permi.Rows)
            {
                if (rows["Modulo"].ToString() == "VENTA")
                {
                    switch (rows["Permiso"].ToString())
                    {
                        case "eliminar":
                            btn_eliminar.Enabled = true;
                            break;
                    }
                }
            }
        }
        private void btn_rp_factura_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (dtg_ventas.SelectedRows.Count > 0)
            {
                frm_reporte frm_Reporte = new frm_reporte();
                Factura factura = new Factura();
                //instancias                                  
                ParameterField parameterField = new ParameterField();
                ParameterFields parameterFields = new ParameterFields();
                ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                foreach (DataGridViewRow rows in dtg_ventas.SelectedRows)
                {                  
                    parameterField.Name = "@Factura";
                    string Fac = rows.Cells["cl_factura"].Value.ToString();
                    parameterDiscreteValue.Value = Fac;
                    parameterField.CurrentValues.Add(parameterDiscreteValue);
                    parameterFields.Add(parameterField);
                    frm_Reporte.crystalReportViewer1.ParameterFieldInfo = parameterFields;
                    factura.Load(@"C:\Users\RUBEN\Documents\Ruben\SBX\SBX_VENTANAS\SBX\Factura.rpt");
                    frm_Reporte.crystalReportViewer1.ReportSource = factura;           
                }
                frm_Reporte.Show();
                //factura.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\RUBEN\Documents\Ruben\SBX\FacturasPDF\fact.pdf");
            }
            this.Cursor = Cursors.Default;
        }
    }
}
