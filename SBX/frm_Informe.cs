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
    public partial class frm_Informe : Form
    {
        cls_ganancias_perdidas cl_gp = new cls_ganancias_perdidas();

        public string Codigo { get; set; }

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
            frm_reportes frm_Reportes = new frm_reportes();
            frm_Reportes.ShowDialog();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            double Costos = 0;
            double VentasD = 0;
            double VentasDomicilio = 0;
            double TotalVentas = 0;
            double Resultado = 0;
            Contador = 0;
            Filas = 0;

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
                Resultado = TotalVentas - Costos;

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
                    dtg_informe.Rows[Contador].Cells["cl_item"].Value = rows["Item"];
                    dtg_informe.Rows[Contador].Cells["cl_codigo_barras"].Value = rows["CodigoBarras"];
                    dtg_informe.Rows[Contador].Cells["cl_referencia"].Value = rows["Referencia"];
                    dtg_informe.Rows[Contador].Cells["cl_nombre"].Value = rows["Nombre"];
                    
                    dtg_informe.Rows[Contador].Cells["cl_cantidad"].Value = rows["Cantidad"];
                    double CantidadExacta = Convert.ToDouble(rows["Cantidad_exacta"]);
                    if (CantidadExacta < 1)
                    {
                        dtg_informe.Rows[Contador].Cells["cl_cantidad_exacta"].Value = Math.Round(CantidadExacta,2);
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
                    string Modulo = "V. Directa";
                    if (rows["Domicilio"].ToString() != " -  -  -  -  -  -  - ")
                    {
                        Modulo = "Domicilio";
                    }
                    dtg_informe.Rows[Contador].Cells["v_modulo"].Value = Modulo;

                    Contador++;
                }
            }
        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            double Costos = 0;
            double VentasD = 0;
            double VentasDomicilio = 0;
            double TotalVentas = 0;
            double Resultado = 0;
            Contador = 0;
            Filas = 0;

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
                Resultado = TotalVentas - Costos;

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
                    string Modulo = "V. Directa";
                    if (rows["Domicilio"].ToString() != " -  -  -  -  -  -  - ")
                    {
                        Modulo = "Domicilio";
                    }
                    dtg_informe.Rows[Contador].Cells["v_modulo"].Value = Modulo;

                    Contador++;
                }
            }
        }
    }
}
