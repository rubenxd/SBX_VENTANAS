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
        List<int> codigoSeparados;

        List<int> codigoCreditos;
        public DataTable v_dt_Permi { get; set; }

        DataTable v_dt;
        DataTable v_dt_detalle;
        int Contador = 0;
        int Filas = 0;

        public frm_Informe()
        {
            InitializeComponent();
            cbx_tipo_busqueda.SelectedIndex = 0;
        }

        private void btn_imprimir_reporte_Click(object sender, EventArgs e)
        {
            frm_ganancias_y_perdidas frm_Ganancias_Y_Perdidas = new frm_ganancias_y_perdidas();
            frm_Ganancias_Y_Perdidas.Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            mtd_consultar_datos();
            this.Cursor = Cursors.Default;
        }

        private void mtd_consultar_datos() 
        {
            codigoSeparados = new List<int>();
            codigoCreditos = new List<int>();
            double Costos = 0;
            double CostosDomicilio = 0;
            double CostosSeparado = 0;
            double CostosCredito = 0;
            double VentasD = 0;
            double VentasDomicilio = 0;
            double VentasSeparado = 0;
            double Gastos = 0;
            double TotalVentas = 0;
            double TotalCostos = 0;
            double Resultado = 0;
            double TotalGastos = 0;
            double TotalIva = 0;
            Contador = 0;
            Filas = 0;

            //limpiar campos
            txt_costos.Text = "0";
            txt_costo_dm.Text = "0";

    
            txt_costo_sp.Text = "0";
            txt_gastos.Text = "0";
            txt_total_ventas.Text = "0";
            txt_total_costos.Text = "0";
            txt_resultado.Text = "0";
            txt_ventas_directas.Text = "0";
            txt_ventas_domicilio.Text = "0";
            txt_ventas_separado.Text = "0";
            txt_ventas_sp_total.Text = "0";
            txt_credito.Text = "0";

            //VENTAS DIRECTAS Y DOMICILIOS
            cl_gp.FechaIni = dtp_fecha_inicio.Value;
            cl_gp.FechaFin = dtp_fecha_fin.Value;
            cl_gp.TipoBusqueda = cbx_tipo_busqueda.Text;
            cl_gp.Buscar = txt_buscar.Text;
            cl_gp.Usuario = this.Codigo;
            v_dt = cl_gp.mtd_consultar();
            v_dt_detalle = v_dt;
            dtg_informe.Rows.Clear();
            if (v_dt.Rows.Count > 0) 
            {
                foreach (DataRow rows in v_dt.Rows) 
                {
                    if (rows["Domicilio"].ToString() == " -  -  -  -  -  -  - " && rows["SistemaSeparado"].ToString() == " -  -  - " && rows["Creditos"].ToString() == " -  -  - ")
                    {
                        Costos += Convert.ToDouble(rows["Costo"]);
                        VentasD += Convert.ToDouble(rows["PrecioVenta"]) - Convert.ToDouble(rows["ValorDescuento"]);
                    }
                    else if (rows["Estado_Domicilio"].ToString() == "Pago" || rows["Estado_Domicilio"].ToString() == "Procesado")
                    {
                        CostosDomicilio += Convert.ToDouble(rows["Costo"]);
                        VentasDomicilio += Convert.ToDouble(rows["PrecioVenta"]) - Convert.ToDouble(rows["ValorDescuento"]);
                    }
                }
            }
            txt_costos.Text = Costos.ToString("N2");
            txt_ventas_directas.Text = VentasD.ToString("N2");
            txt_costo_dm.Text = CostosDomicilio.ToString("N2");
            txt_ventas_domicilio.Text = VentasDomicilio.ToString("N2");

            //SISTEMA DE SEPARADOS
            cl_gp.FechaIni = dtp_fecha_inicio.Value;
            cl_gp.FechaFin = dtp_fecha_fin.Value;
            cl_gp.Usuario = this.Codigo;
            double valorAbono = 0;
            double valorAbonoTotal = 0;
            double costosp = 0;
            double costospTotal = 0;
            double CostoTotalSumandoSeparados = 0;
            double CostoTotalSumandoSeparadosTotal = 0;
            double Resta = 0;
            double Abonototal = 0;
            string Estado = "";
            //Abonos separados hoy
            v_dt = cl_gp.mtd_consultar_Abonos_separados();
            if (v_dt.Rows.Count > 0)
            {
                foreach (DataRow rows in v_dt.Rows)
                {
                    valorAbono += Convert.ToDouble(rows["ValorAbonos"].ToString());                  
                    codigoSeparados.Add(Convert.ToInt32(rows["Codigo"]));                  
                    costosp = Convert.ToDouble(rows["costo"]);
                    Abonototal = Convert.ToDouble(rows["AbonoTotalSegunfecha"]);
                    Resta = Convert.ToDouble(rows["Resta"]);
                }
                //if (Abonototal >= costosp)
                //{
                //    txt_costo_sp.Text = costosp.ToString("N0");
                //}
                //else
                //{
                //    txt_costo_sp.Text = Resta.ToString("N0");
                //}
                
                txt_ventas_separado.Text = valorAbono.ToString("N0");
                txt_ventas_sp_total.Text = Abonototal.ToString("N0");
            }

            //Abonos credito
            v_dt = cl_gp.mtd_consultar_Abonos_credito();
            valorAbono = 0;
            if (v_dt.Rows.Count > 0)
            {
                foreach (DataRow rows in v_dt.Rows)
                {
                    valorAbono += Convert.ToDouble(rows["ValorAbonos"].ToString());                 
                }
                txt_credito.Text = valorAbono.ToString("N0");
            }

            //buscar gastos
            cls_gastos_m cl_gm = new cls_gastos_m();
            cl_gm.FechaIni = dtp_fecha_inicio.Value;
            cl_gm.Fechafin = dtp_fecha_fin.Value;
            cl_gm.usuario = this.Codigo;
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

            //TOTALES
            //Ventas
            double TotalVentasF = (Convert.ToDouble(txt_ventas_directas.Text) + Convert.ToDouble(txt_ventas_domicilio.Text) + Convert.ToDouble(txt_ventas_sp_total.Text) + Convert.ToDouble(txt_credito.Text)) - Convert.ToDouble(txt_gastos.Text);
            txt_total_ventas.Text = TotalVentasF.ToString("N0");
            //Costos
            double TotalCostosF = (Convert.ToDouble(txt_costos.Text) + Convert.ToDouble(txt_costo_dm.Text) + Convert.ToDouble(txt_costo_sp.Text)) ;
            txt_total_costos.Text = TotalCostosF.ToString("N0");
            double ResultadoF = TotalVentasF - TotalCostosF;
            txt_resultado.Text = ResultadoF.ToString("N0");
            ////Ganacias SP
            //double totalGnSp = Convert.ToDouble(txt_ventas_sp_total.Text) - Convert.ToDouble(txt_costo_total_sp.Text);
            //txt_gn_sp.Text = totalGnSp.ToString("N0");
            //Total global
            //double totalGlobal = ResultadoF + totalGnSp;
            //txt_total_global.Text = totalGlobal.ToString("N0");

            //Cargar detalles
            dtg_informe.Rows.Clear();
            int contadorFilas = 0;
            foreach (DataRow rows in v_dt_detalle.Rows)
            {
                if (rows["Estado_sistema_separado"].ToString() != "Pendiente" && rows["Estado_Domicilio"].ToString() != "Pendiente" && rows["Estado_Credito"].ToString() != "Pendiente")
                {
                    contadorFilas++;
                }
            }
            if (contadorFilas > 0)
            {
                Filas = contadorFilas;
                    dtg_informe.Rows.Add(Filas);
                    foreach (DataRow rows in v_dt_detalle.Rows)
                    {
                    if (rows["Estado_sistema_separado"].ToString() != "Pendiente" && rows["Estado_Domicilio"].ToString() != "Pendiente" && rows["Estado_Credito"].ToString() != "Pendiente")
                    {
                        dtg_informe.Rows[Contador].Cells["cl_factura"].Value = rows["Factura"];
                        dtg_informe.Rows[Contador].Cells["cl_usuario"].Value = rows["NombreUsuario"];
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

                        dtg_informe.Rows[Contador].Cells["v_modulo"].Value = "V. Directa";
                        dtg_informe.Rows[Contador].Cells["cl_domicilio"].Value = rows["Domicilio"];
                        dtg_informe.Rows[Contador].Cells["cl_separado"].Value = rows["SistemaSeparado"];
                        dtg_informe.Rows[Contador].Cells["cl_creditos"].Value = rows["Creditos"];
                        Contador++;
                    }                     
                    }           
            }                                              
        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
           
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

        private void frm_Informe_Load(object sender, EventArgs e)
        {
            ////Consulta cierres de caja
            //cls_caja cls_Caja = new cls_caja();
            //cls_Caja.FechaInicio = dtp_fecha_inicio.Text;
            //cls_Caja.FechaFin = dtp_fecha_fin.Text;
            //v_dt = cls_Caja.mtd_consultar_Cierres();
            //if (v_dt.Rows.Count > 0)
            //{
            //    foreach (DataRow item in v_dt.Rows)
            //    {
            //        cbx_cierres.Items.Add(item["CodigoCaja"]);
            //    }
            //    cbx_cierres.SelectedIndex = cbx_cierres.Items.Count - 1;
            //}
        }

        private void btn_ventas_separado_Click(object sender, EventArgs e)
        {
            if (txt_ventas_separado.Text != "")
            {

                frm_separados frm_separados = new frm_separados(codigoSeparados,"Separados");              
                frm_separados.FormBorderStyle = FormBorderStyle.FixedDialog;
                frm_separados.v_dt_Permi = v_dt_Permi;
                frm_separados.Usuario = this.Codigo;
                frm_separados.ShowDialog();
            }       
        }

        private void btn_ventas_separado_total_Click(object sender, EventArgs e)
        {
            if (txt_ventas_sp_total.Text != "")
            {

                frm_separados frm_separados = new frm_separados(codigoSeparados, "Separados");
                frm_separados.FormBorderStyle = FormBorderStyle.FixedDialog;
                frm_separados.v_dt_Permi = v_dt_Permi;
                frm_separados.Usuario = this.Codigo;
                frm_separados.ShowDialog();
            }
        }
        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            if (dtg_informe.Rows.Count > 0)
            {
                frm_detalle_informe_ventas frm_Detalle_Informe_Ventas = new frm_detalle_informe_ventas();
                frm_Detalle_Informe_Ventas.v_dt_detalle = this.v_dt_detalle;
                frm_Detalle_Informe_Ventas.ShowDialog();
            }        
        }
    }
}
