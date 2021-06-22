using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SBX.MODEL;

namespace SBX
{
    public partial class frm_cotizaciones : Form
    {
        cls_reporte_cotizacion cls_Reporte_Cotizacion = new cls_reporte_cotizacion();
        cls_empresa cls_Empresa = new cls_empresa();
        DataTable V_dt = new DataTable();
        DataTable DataTable = new DataTable();
        public DataTable v_dt_Permi { get; set; }
        public string usuario { get; set; }
        public frm_cotizaciones()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cls_Reporte_Cotizacion.Fecha_inicio = dtp_fecha_inicio.Text;
            cls_Reporte_Cotizacion.Fecha_fin = dtp_fecha_fin.Text;
            cls_Reporte_Cotizacion.v_buscar = txt_buscar.Text;
            V_dt = cls_Reporte_Cotizacion.mtd_consultar();
            dtg_ventas.DataSource = V_dt;
        }
       
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            List<cls_reporte_cotizacion> lrctz = new List<cls_reporte_cotizacion>();
            foreach (DataGridViewRow item in dtg_ventas.SelectedRows)
            {
                cls_Reporte_Cotizacion.Fecha_inicio = dtp_fecha_inicio.Text;
                cls_Reporte_Cotizacion.Fecha_fin = dtp_fecha_fin.Text;
                cls_Reporte_Cotizacion.v_buscar = item.Cells["Conse"].Value.ToString();
                DataTable = cls_Reporte_Cotizacion.mtd_consultar();
                
                foreach (DataRow rows in DataTable.Rows)
                {
                    cls_reporte_cotizacion cls_Reporte_Cotizacion = new cls_reporte_cotizacion();
                    DateTime Fecha = Convert.ToDateTime(rows["Fecha"].ToString());
                    cls_Reporte_Cotizacion.rpt_Fecha = Fecha.ToString("yyyy-MM-dd");
                    cls_Reporte_Cotizacion.rpt_Doc = rows["Doc"].ToString();
                    cls_Reporte_Cotizacion.rpt_Conse = rows["Conse"].ToString();
                    cls_Reporte_Cotizacion.rpt_Item = rows["Item"].ToString();
                    cls_Reporte_Cotizacion.rpt_Nombre = rows["Nombre"].ToString();
                    cls_Reporte_Cotizacion.rpt_Cantidad = rows["cantidad"].ToString();
                    double PrecioVenta = Convert.ToDouble(rows["PrecioVenta"].ToString());
                    cls_Reporte_Cotizacion.rpt_precioVenta = PrecioVenta.ToString("N");
                    double Descuento = Convert.ToDouble(rows["Descuento"].ToString());
                    cls_Reporte_Cotizacion.rpt_Descuento = Descuento.ToString("N");
                    cls_Reporte_Cotizacion.rpt_Total = rows["Total"].ToString();
                    cls_Reporte_Cotizacion.rpt_dni = rows["DNI"].ToString();
                    cls_Reporte_Cotizacion.rpt_Cliente = rows["Cliente"].ToString();
                    cls_Reporte_Cotizacion.rpt_Direccion = rows["Direccion"].ToString();
                    cls_Reporte_Cotizacion.rpt_Email = rows["Email"].ToString();
                    cls_Reporte_Cotizacion.rpt_Telefono = rows["Telefono"].ToString();
                    cls_Reporte_Cotizacion.rpt_Celular = rows["Celular"].ToString();
                    cls_Reporte_Cotizacion.rpt_Usuario = rows["Usuario"].ToString();
                    cls_Reporte_Cotizacion.rpt_NombreUsuario = rows["NombreUsuario"].ToString();
                    cls_Reporte_Cotizacion.rpt_Dni_empresa = rows["DNI_Empresa"].ToString();
                    cls_Reporte_Cotizacion.rpt_nombre_empresa = rows["Nombre_Empresa"].ToString();
                    cls_Reporte_Cotizacion.rpt_telefono_emp = rows["Telefono_emp"].ToString();
                    cls_Reporte_Cotizacion.rpt_celular_emp = rows["Celular_emp"].ToString();
                    cls_Reporte_Cotizacion.rpt_direccion_emp = rows["Direccion_emp"].ToString();
                    double Total2 = Convert.ToDouble(rows["Total2"].ToString());
                    cls_Reporte_Cotizacion.rpt_Total2 = Total2.ToString("N");
                    cls_Reporte_Cotizacion.Foto = (byte[])rows["Foto"];

                    lrctz.Add(cls_Reporte_Cotizacion);
                }
            }

            frm_cotizacion frm_Cotizacion = new frm_cotizacion();
            frm_Cotizacion.Reporte = "Cotizacion";
            frm_Cotizacion.lrctz = lrctz;
            frm_Cotizacion.Show();
        }
        private void btn_facturar_Click(object sender, EventArgs e)
        {
            frm_venta frm_Venta = new frm_venta();
            foreach (DataGridViewRow item in dtg_ventas.SelectedRows)
            {
                cls_Reporte_Cotizacion.Fecha_inicio = dtp_fecha_inicio.Text;
                cls_Reporte_Cotizacion.Fecha_fin = dtp_fecha_fin.Text;
                cls_Reporte_Cotizacion.v_buscar = item.Cells["Conse"].Value.ToString();
                DataTable = cls_Reporte_Cotizacion.mtd_consultar();
                frm_Venta.v_dt_cotizacion = DataTable;
                frm_Venta.cotizacion = item.Cells["Conse"].Value.ToString();
                frm_Venta.v_dt_Permi = v_dt_Permi;
                frm_Venta.Usuario = usuario;
                frm_Venta.txt_cliente.Text = item.Cells["DNI"].Value.ToString();
                double valor = 0;
                valor = (Convert.ToDouble(item.Cells["Descuento"].Value) / Convert.ToDouble(item.Cells["PrecioVenta"].Value)) * 100;
                frm_Venta.PorcentajeDescuento = valor.ToString();
                frm_Venta.ShowDialog();
            }
        }

        public void MensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar");
            Botones.SetToolTip(btn_facturar, "Facturar");
            Botones.SetToolTip(btn_Imprimir, "Imprimir PDF");
        }
        private void frm_cotizaciones_Load(object sender, EventArgs e)
        {
            MensajeInformativoBotones();
        }
    }
}
