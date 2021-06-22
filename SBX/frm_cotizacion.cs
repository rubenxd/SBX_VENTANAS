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
using SBX.DB;
using SBX.MODEL;

namespace SBX
{
    public partial class frm_cotizacion : Form
    {
        MODEL.cls_reporte_cotizacion cls_Reporte_Cotizacion = new MODEL.cls_reporte_cotizacion();
        DataTable DataTable = new DataTable();
        public List<cls_reporte_cotizacion> lrctz { get; set; }
        public List<cls_venta> lrFact { get; set; }
        public List<cls_orden_servicio> lrords  { get; set; }

    public string Reporte { get; set; }
        public frm_cotizacion()
        {
            InitializeComponent();
        }

        private void frm_cotizacion_Load(object sender, EventArgs e)
        {
            switch (Reporte)
            {
                case "Cotizacion":
                    ReportDataSource rds = new ReportDataSource("reporte_cotizacion", lrctz);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "SBX.Report2.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rds);
                    this.reportViewer1.RefreshReport();
                    break;
                case "Factura":
                    ReportDataSource rds_fac = new ReportDataSource("reporte_Factura", lrFact);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "SBX.Report1.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rds_fac);
                    this.reportViewer1.RefreshReport();
                    break;
                case "OrdenServicio":
                    ReportDataSource rds_ords = new ReportDataSource("reporte_orden_servicio", lrords);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "SBX.Report3.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rds_ords);
                    this.reportViewer1.RefreshReport();
                    break;
                default:
                    break;
            }        
        }   
    }
}
