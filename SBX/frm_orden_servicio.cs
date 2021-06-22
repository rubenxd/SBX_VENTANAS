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

namespace SBX
{
    public partial class frm_orden_servicio : Form
    {
        cls_orden_servicio cls_Orden_Servicio = new cls_orden_servicio();
        cls_empresa cls_Empresa = new cls_empresa();
        DataTable V_dt = new DataTable();
        DataTable DataTable = new DataTable();
        public DataTable v_dt_Permi { get; set; }
        public string usuario { get; set; }
        public frm_orden_servicio()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cls_Orden_Servicio.Fecha_inicio = dtp_fecha_inicio.Text;
            cls_Orden_Servicio.Fecha_fin = dtp_fecha_fin.Text;
            cls_Orden_Servicio.v_buscar = txt_buscar.Text;
            V_dt = cls_Orden_Servicio.mtd_consultar();
            dtg_ventas.DataSource = V_dt;
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            List<cls_orden_servicio> lrords = new List<cls_orden_servicio>();
            foreach (DataGridViewRow item in dtg_ventas.SelectedRows)
            {
                cls_Orden_Servicio.Fecha_inicio = dtp_fecha_inicio.Text;
                cls_Orden_Servicio.Fecha_fin = dtp_fecha_fin.Text;
                cls_Orden_Servicio.v_buscar = item.Cells["Conse"].Value.ToString();
                DataTable = cls_Orden_Servicio.mtd_consultar();

                foreach (DataRow rows in DataTable.Rows)
                {
                    cls_orden_servicio cls_Orden_Servicio = new cls_orden_servicio();
                    DateTime Fecha = Convert.ToDateTime(rows["Fecha"].ToString());
                    cls_Orden_Servicio.rpt_Fecha = Fecha.ToString("yyyy-MM-dd");
                    cls_Orden_Servicio.rpt_Doc = rows["Doc"].ToString();
                    cls_Orden_Servicio.rpt_Conse = rows["Conse"].ToString();
                    cls_Orden_Servicio.rpt_Item = rows["Item"].ToString();
                    cls_Orden_Servicio.rpt_Nombre = rows["Nombre"].ToString();
                    cls_Orden_Servicio.rpt_Cantidad = rows["cantidad"].ToString();
                    double PrecioVenta = Convert.ToDouble(rows["PrecioVenta"].ToString());
                    cls_Orden_Servicio.rpt_precioVenta = PrecioVenta.ToString("N");
                    double Descuento = Convert.ToDouble(rows["Descuento"].ToString());
                    cls_Orden_Servicio.rpt_Descuento = Descuento.ToString("N");
                    cls_Orden_Servicio.rpt_Total = rows["Total"].ToString();
                    cls_Orden_Servicio.rpt_dni = rows["DNI"].ToString();
                    cls_Orden_Servicio.rpt_Cliente = rows["Cliente"].ToString();
                    cls_Orden_Servicio.rpt_Direccion = rows["Direccion"].ToString();
                    cls_Orden_Servicio.rpt_Email = rows["Email"].ToString();
                    cls_Orden_Servicio.rpt_Telefono = rows["Telefono"].ToString();
                    cls_Orden_Servicio.rpt_Celular = rows["Celular"].ToString();
                    cls_Orden_Servicio.rpt_Usuario = rows["Usuario"].ToString();
                    cls_Orden_Servicio.rpt_NombreUsuario = rows["NombreUsuario"].ToString();
                    cls_Orden_Servicio.rpt_Dni_empresa = rows["DNI_Empresa"].ToString();
                    cls_Orden_Servicio.rpt_nombre_empresa = rows["Nombre_Empresa"].ToString();
                    cls_Orden_Servicio.rpt_telefono_emp = rows["Telefono_emp"].ToString();
                    cls_Orden_Servicio.rpt_celular_emp = rows["Celular_emp"].ToString();
                    cls_Orden_Servicio.rpt_direccion_emp = rows["Direccion_emp"].ToString();
                    double Total2 = Convert.ToDouble(rows["Total2"].ToString());
                    cls_Orden_Servicio.rpt_Total2 = Total2.ToString("N");
                    cls_Orden_Servicio.Foto = (byte[])rows["Foto"];
                    cls_Orden_Servicio.Nota = rows["nota"].ToString();
                    cls_Orden_Servicio.rpt_email_emp = rows["Email_emp"].ToString();
                    lrords.Add(cls_Orden_Servicio);
                }
            }

            frm_cotizacion frm_Cotizacion = new frm_cotizacion();
            frm_Cotizacion.Reporte = "OrdenServicio";
            frm_Cotizacion.lrords = lrords;
            frm_Cotizacion.Show();
        }
        private void btn_facturar_Click(object sender, EventArgs e)
        {
            frm_venta frm_Venta = new frm_venta();
            foreach (DataGridViewRow item in dtg_ventas.SelectedRows)
            {
                cls_Orden_Servicio.Fecha_inicio = dtp_fecha_inicio.Text;
                cls_Orden_Servicio.Fecha_fin = dtp_fecha_fin.Text;
                cls_Orden_Servicio.v_buscar = item.Cells["Conse"].Value.ToString();
                DataTable = cls_Orden_Servicio.mtd_consultar();
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
    }
}
