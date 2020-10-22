using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using SBX.MODEL;

namespace SBX
{
    public partial class frm_Informe : Form
    {
        cls_ganancias_perdidas cl_gp = new cls_ganancias_perdidas();

        public string Codigo { get; set; }
        public DataTable v_dt_Permi { get; set; }

        DataTable v_dt;
        int Contador = 0;
        int Filas = 0;

        public frm_Informe()
        {
            InitializeComponent();
            cbx_tipo_busqueda.SelectedIndex = 0;
        }

        private void btn_imprimir_reporte_Click(object sender, EventArgs e)
        {
            //frm_reportes frm_Reportes = new frm_reportes();
            //frm_Reportes.ShowDialog();
            this.Cursor = Cursors.WaitCursor;          
            frm_reporte frm_Reporte = new frm_reporte();
            GananciasPerdidas gananciasPerdidas = new GananciasPerdidas();
            //instancias                                  
            ParameterField parameterField = new ParameterField();
            ParameterFields parameterFields = new ParameterFields();
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
               
            parameterField.Name = "@FechaIni";
            parameterDiscreteValue.Value = dtp_fecha_inicio.Text;
            parameterField.CurrentValues.Add(parameterDiscreteValue);
            parameterField.Name = "@FechaFin";
            parameterDiscreteValue.Value = dtp_fecha_fin.Text;
            parameterField.CurrentValues.Add(parameterDiscreteValue);
            parameterField.Name = "@tipoBusqueda";
            parameterDiscreteValue.Value = cbx_tipo_busqueda.Text;
            parameterField.CurrentValues.Add(parameterDiscreteValue);
            parameterField.Name = "@Buscar";
            parameterDiscreteValue.Value = txt_buscar.Text;
            parameterField.CurrentValues.Add(parameterDiscreteValue);
            parameterFields.Add(parameterField);
            frm_Reporte.crystalReportViewer1.ParameterFieldInfo = parameterFields;
            gananciasPerdidas.Load(@"C:\Users\RUBEN\Documents\Ruben\SBX\SBX_VENTANAS\SBX\GananciasPerdidas.rpt");
            frm_Reporte.crystalReportViewer1.ReportSource = gananciasPerdidas;          
            frm_Reporte.Show();
            //factura.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\RUBEN\Documents\Ruben\SBX\FacturasPDF\fact.pdf");          
            this.Cursor = Cursors.Default;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            mtd_consultar_datos();
            this.Cursor = Cursors.Default;
        }

        private void mtd_consultar_datos() 
        {
            double Costos = 0;
            double VentasD = 0;
            double VentasDomicilio = 0;
            double Gastos = 0;
            double TotalVentas = 0;
            double Resultado = 0;
            double TotalGastos = 0;
            double TotalIva = 0;
            Contador = 0;
            Filas = 0;

            //buscar gastos
            cls_gastos_m cl_gm = new cls_gastos_m();
            cl_gm.FechaIni = dtp_fecha_inicio.Text;
            cl_gm.Fechafin = dtp_fecha_fin.Text;
            v_dt = cl_gm.mtd_consultar_gastos();
            TotalGastos = 0;
            TotalIva = 0;
            if (v_dt.Rows.Count > 0)
            {
                foreach (DataRow rows in v_dt.Rows)
                {
                    double Valores = Convert.ToDouble(rows["Valor"]);
                    TotalGastos += Valores;
                    double ValoresIVA = Convert.ToDouble(rows["ValorIva"]);
                    TotalIva += ValoresIVA;
                }
                double total = TotalGastos + TotalIva;
                txt_gastos.Text = total.ToString("N0");
            }
            else
            {
                txt_gastos.Text = "0";
            }

            //
            cl_gp.FechaIni = dtp_fecha_inicio.Text;
            cl_gp.FechaFin = dtp_fecha_fin.Text;
            cl_gp.TipoBusqueda = cbx_tipo_busqueda.Text;
            cl_gp.Buscar = txt_buscar.Text;
            v_dt = cl_gp.mtd_consultar();
            dtg_informe.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                foreach (DataRow rows in v_dt.Rows)
                {
                    if (rows["Domicilio"].ToString() == " -  -  -  -  -  -  - ")
                    {
                        Costos += Convert.ToDouble(rows["Costo"]);
                        VentasD += Convert.ToDouble(rows["PrecioVenta"]) - Convert.ToDouble(rows["ValorDescuento"]);
                    }
                    else
                    {
                        Costos += Convert.ToDouble(rows["Costo"]);
                        VentasDomicilio += Convert.ToDouble(rows["PrecioVenta"]) - Convert.ToDouble(rows["ValorDescuento"]);
                    }
                }
                TotalVentas = VentasD + VentasDomicilio;
                Resultado = (TotalVentas - Costos) - Convert.ToDouble(txt_gastos.Text);

                txt_costos.Text = Costos.ToString("N2");
                txt_ventas_directas.Text = VentasD.ToString("N2");
                txt_ventas_domicilio.Text = VentasDomicilio.ToString("N2");
                txt_resultado.Text = Resultado.ToString("N2");

                if (Resultado < 0)
                {
                    lbl_resultado.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lbl_resultado.ForeColor = Color.SeaGreen;
                }

                //Cargar detalles
                dtg_informe.Rows.Clear();
                Filas = v_dt.Rows.Count;
                dtg_informe.Rows.Add(Filas);
                foreach (DataRow rows in v_dt.Rows)
                {
                    if (rows["Estado_sistema_separado"].ToString() != "Pendiente")
                    {
                        dtg_informe.Rows[Contador].Cells["cl_item"].Value = rows["Item"];
                        dtg_informe.Rows[Contador].Cells["cl_codigo_barras"].Value = rows["CodigoBarras"];
                        dtg_informe.Rows[Contador].Cells["cl_referencia"].Value = rows["Referencia"];
                        dtg_informe.Rows[Contador].Cells["cl_nombre"].Value = rows["Nombre"];

                        dtg_informe.Rows[Contador].Cells["cl_cantidad"].Value = rows["Cantidad"];
                        double CantidadExacta = Convert.ToDouble(rows["Cantidad_exacta"]);
                        if (CantidadExacta < 1)
                        {
                            dtg_informe.Rows[Contador].Cells["cl_cantidad_exacta"].Value = Math.Round(CantidadExacta, 2);
                        }
                        else
                        {
                            dtg_informe.Rows[Contador].Cells["cl_cantidad_exacta"].Value = Math.Round(CantidadExacta);
                        }

                        dtg_informe.Rows[Contador].Cells["cl_um"].Value = rows["UM"];
                        double costo = Convert.ToDouble(rows["Costo"]);
                        dtg_informe.Rows[Contador].Cells["cl_costos"].Value = costo.ToString("N2");
                        double PrecioVenta = Convert.ToDouble(rows["PrecioVenta"]);
                        dtg_informe.Rows[Contador].Cells["cl_precio_venta"].Value = PrecioVenta.ToString("N2");
                        double ValorDescuento = Convert.ToDouble(rows["ValorDescuento"]);
                        dtg_informe.Rows[Contador].Cells["cl_Descuentos"].Value = ValorDescuento.ToString("N2");
                        double Total = PrecioVenta - ValorDescuento;
                        dtg_informe.Rows[Contador].Cells["cl_total"].Value = Total.ToString("N2");
                        double Resultados = Total - costo;
                        dtg_informe.Rows[Contador].Cells["cl_resultado"].Value = Resultados.ToString("N2");
                        //string Modulo = "V. Directa";
                        //if (rows["Domicilio"].ToString() != " -  -  -  -  -  -  - ")
                        //{
                        //    Modulo = "Domicilio";
                        //}
                        dtg_informe.Rows[Contador].Cells["v_modulo"].Value = "V. Directa";
                        dtg_informe.Rows[Contador].Cells["cl_domicilio"].Value = rows["Domicilio"];
                        dtg_informe.Rows[Contador].Cells["cl_separado"].Value = rows["SistemaSeparado"];
                        Contador++;
                    }
                    else 
                    {
                        dtg_informe.Rows.Add(-1);
                    }                
                }
            }
            else
            {
                Resultado = (TotalVentas - Costos) - Convert.ToDouble(txt_gastos.Text);

                txt_costos.Text = Costos.ToString("N2");
                txt_ventas_directas.Text = VentasD.ToString("N2");
                txt_ventas_domicilio.Text = VentasDomicilio.ToString("N2");
                txt_resultado.Text = Resultado.ToString("N2");

                if (Resultado < 0)
                {
                    lbl_resultado.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lbl_resultado.ForeColor = Color.SeaGreen;
                }

            }
        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            //double Costos = 0;
            //double VentasD = 0;
            //double VentasDomicilio = 0;
            //double TotalVentas = 0;
            //double Resultado = 0;
            //Contador = 0;
            //Filas = 0;

            //cl_gp.FechaIni = dtp_fecha_inicio.Text;
            //cl_gp.FechaFin = dtp_fecha_fin.Text;
            //cl_gp.TipoBusqueda = cbx_tipo_busqueda.Text;
            //cl_gp.Buscar = txt_buscar.Text;
            //v_dt = cl_gp.mtd_consultar();
            //dtg_informe.Rows.Clear();
            //if (v_dt.Rows.Count > 0)
            //{
            //    foreach (DataRow rows in v_dt.Rows)
            //    {
            //        if (rows["Domicilio"].ToString() == " -  -  -  -  -  -  - ")
            //        {
            //            Costos += Convert.ToDouble(rows["Costo"]);
            //            VentasD += Convert.ToDouble(rows["PrecioVenta"]) - Convert.ToDouble(rows["ValorDescuento"]);
            //        }
            //        else
            //        {
            //            Costos += Convert.ToDouble(rows["Costo"]);
            //            VentasDomicilio += Convert.ToDouble(rows["PrecioVenta"]) - Convert.ToDouble(rows["ValorDescuento"]);
            //        }
            //    }
            //    TotalVentas = VentasD + VentasDomicilio;
            //    Resultado = TotalVentas - Costos;

            //    txt_costos.Text = Costos.ToString("N2");
            //    txt_ventas_directas.Text = VentasD.ToString("N2");
            //    txt_ventas_domicilio.Text = VentasDomicilio.ToString("N2");
            //    txt_resultado.Text = Resultado.ToString("N2");

            //    if (Resultado < 0)
            //    {
            //        lbl_resultado.ForeColor = Color.OrangeRed;
            //    }
            //    else
            //    {
            //        lbl_resultado.ForeColor = Color.SeaGreen;
            //    }

            //    //Cargar detalles
            //    dtg_informe.Rows.Clear();
            //    Filas = v_dt.Rows.Count;
            //    dtg_informe.Rows.Add(Filas);
            //    foreach (DataRow rows in v_dt.Rows)
            //    {
            //        dtg_informe.Rows[Contador].Cells["cl_item"].Value = rows["Item"];
            //        dtg_informe.Rows[Contador].Cells["cl_codigo_barras"].Value = rows["CodigoBarras"];
            //        dtg_informe.Rows[Contador].Cells["cl_referencia"].Value = rows["Referencia"];
            //        dtg_informe.Rows[Contador].Cells["cl_nombre"].Value = rows["Nombre"];

            //        dtg_informe.Rows[Contador].Cells["cl_cantidad"].Value = rows["Cantidad"];
            //        double CantidadExacta = Convert.ToDouble(rows["Cantidad_exacta"]);
            //        if (CantidadExacta < 1)
            //        {
            //            dtg_informe.Rows[Contador].Cells["cl_cantidad_exacta"].Value = Math.Round(CantidadExacta, 2);
            //        }
            //        else
            //        {
            //            dtg_informe.Rows[Contador].Cells["cl_cantidad_exacta"].Value = Math.Round(CantidadExacta);
            //        }

            //        dtg_informe.Rows[Contador].Cells["cl_um"].Value = rows["UM"];
            //        double costo = Convert.ToDouble(rows["Costo"]);
            //        dtg_informe.Rows[Contador].Cells["cl_costos"].Value = costo.ToString("N2");
            //        double PrecioVenta = Convert.ToDouble(rows["PrecioVenta"]);
            //        dtg_informe.Rows[Contador].Cells["cl_precio_venta"].Value = PrecioVenta.ToString("N2");
            //        double ValorDescuento = Convert.ToDouble(rows["ValorDescuento"]);
            //        dtg_informe.Rows[Contador].Cells["cl_Descuentos"].Value = ValorDescuento.ToString("N2");
            //        double Total = PrecioVenta - ValorDescuento;
            //        dtg_informe.Rows[Contador].Cells["cl_total"].Value = Total.ToString("N2");
            //        double Resultados = Total - costo;
            //        dtg_informe.Rows[Contador].Cells["cl_resultado"].Value = Resultados.ToString("N2");
            //        string Modulo = "V. Directa";
            //        if (rows["Domicilio"].ToString() != " -  -  -  -  -  -  - ")
            //        {
            //            Modulo = "Domicilio";
            //        }
            //        dtg_informe.Rows[Contador].Cells["v_modulo"].Value = Modulo;

            //        Contador++;
            //    }
            //}
        }

        private void btn_ver_gastos_Click(object sender, EventArgs e)
        {
            frm_gastos frm_Gastos = new frm_gastos("Informe");
            frm_Gastos.dtp_fecha_inicio.Text = this.dtp_fecha_inicio.Text;
            frm_Gastos.dtp_fecha_fin.Text = this.dtp_fecha_fin.Text;
            frm_Gastos.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm_Gastos.v_dt_Permi = v_dt_Permi;
            frm_Gastos.ShowDialog();
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Cursor = Cursors.WaitCursor;
                mtd_consultar_datos();
                this.Cursor = Cursors.Default;
            }
        }
        frm_saldos frm_Saldos;
        private void btn_saldos_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int BuscaAutomatica = 0;
            int BuscaPaginado = 0;
            //verifica Parametros
            cls_parametros cls_Parametros = new cls_parametros();
            v_dt = cls_Parametros.mtd_consultar_parametros();
            foreach (DataRow item in v_dt.Rows)
            {
                if (item["Buscar_automaticamente"].ToString() == "SI")
                {
                    BuscaAutomatica = 1;
                }
                if (item["Datos_paginados"].ToString() == "SI")
                {
                    BuscaPaginado = 1;
                }
            }

            if (frm_Saldos == null || frm_Saldos.IsDisposed)
            {
                frm_Saldos = new frm_saldos();           
                frm_Saldos.BuscaAutomaticamente = BuscaAutomatica;
                frm_Saldos.BuscaPaginados = BuscaPaginado;
                frm_Saldos.Show();
            }
            else
            {
                frm_Saldos.BringToFront();
                frm_Saldos.WindowState = FormWindowState.Normal;
            }
            this.Cursor = Cursors.Default;

        }
    }
}
