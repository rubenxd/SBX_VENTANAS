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
    public partial class frm_informe_cierre : Form
    {
        cls_caja cls_Caja = new cls_caja();
        public string CodigoultimoCierre { get; set; }
        public string CodigoUltimaVenta { get; set; }
        public string Usuario { get; set; }
        public string Valor_cierre { get; set; }
        public string CodigoUlCierre { get; set; }
        public bool Impresion { get; set; }

        DataTable v_dt;
        DataRow rows;
        double valores = 0;

        public frm_informe_cierre()
        {
            InitializeComponent(); 
        }
       
        private void frm_informe_cierre_Load(object sender, EventArgs e)
        {
            if (Impresion)
            {
                mtd_cargar_cierre_caja();
            }
        }

        //metodos
        private void mtd_cargar_cierre_caja()
        {
            //cargar ingresos
            cls_Caja.Codigo_Ultimo_Cierre = CodigoultimoCierre;
            cls_Caja.Codigo_Ultima_venta = CodigoUltimaVenta;
            cls_Caja.Usuario = this.Usuario;

            v_dt = cls_Caja.mtd_consultar_total_venta_directa();
            if (v_dt.Rows.Count > 0)
            {
                rows = v_dt.Rows[0];
                valores = Convert.ToDouble(rows["Ingresos"]);
                txt_ingresos.Text = valores.ToString("N0");

                valores = Convert.ToDouble(rows["Gastos"]);
                txt_gastos.Text = valores.ToString("N0");
            }

            //Cargar Base
            v_dt = cls_Caja.mtd_consultar_caja_ultima_apertura();
            if (v_dt.Rows.Count > 0)
            {
                rows = v_dt.Rows[0];
                valores = Convert.ToDouble(rows["Valor"]);
                txt_apertura.Text = valores.ToString("N0");
            }

            //Cierre de caja
            double CierreCaja = (Convert.ToDouble(txt_apertura.Text) + Convert.ToDouble(txt_ingresos.Text)) - Convert.ToDouble(txt_gastos.Text);
            txt_cierre_caja.Text = CierreCaja.ToString("N0");

            //Cargar conteo caja          
             valores = Convert.ToDouble(Valor_cierre);
             txt_conteo_dinero.Text = valores.ToString("N0");

            //Diferencia
            if (CierreCaja < 0)
            {
                CierreCaja = CierreCaja * -1;
            }
            double Diferencia = valores - CierreCaja;
            txt_diferencia.Text = Diferencia.ToString("N0");


            //Insertar Cierre de caja para Reeimpresiones
            cls_Caja.CodigoCierre = CodigoUlCierre;
            cls_Caja.BaseCaja = txt_apertura.Text;
            cls_Caja.Ingresos = txt_ingresos.Text;
            cls_Caja.Gastos = txt_gastos.Text;
            cls_Caja.CierreCaja = CierreCaja.ToString();
            cls_Caja.ConteoDinero = txt_conteo_dinero.Text;
            cls_Caja.TotalDiferencia = txt_diferencia.Text;
            cls_Caja.mtd_registrar_Cierre();
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ImprimirCierreCaja()
        {
            CrearTicket ticket = new CrearTicket();
            cls_empresa Empres = new cls_empresa();
           
            double TConteoDinero = 0;
            TConteoDinero = Convert.ToDouble(txt_conteo_dinero.Text);
            //Armar informe cierre de caja

            DataRow row;
            DataTable DTEmpresa;
            DTEmpresa = Empres.mtd_consultar_Empresa();
            row = DTEmpresa.Rows[0];
            string NombreImpresora = row["Impresora"].ToString();
            string NumerosCelular = row["Celular"].ToString();
            //Datos de la cabecera del Ticket.
            ticket.TextoCentro(row["Nombre"].ToString());
            ticket.TextoCentro("NIT:" + row["DNI"]);
            ticket.TextoIzquierda("DIREC: " + row["Direccion"] + "");
            ticket.TextoIzquierda("TELEF: " + row["Telefono"] + "");
            ticket.TextoIzquierda("CELUL: " + row["Celular"] + "");
            ticket.TextoIzquierda("EMAIL: " + row["Email"] + "");
            ticket.TextoIzquierda("WEB: " + row["SitioWeb"] + "");
            ticket.TextoIzquierda("FECHA: " + DateTime.Now.ToShortDateString() + "");
            ticket.TextoIzquierda("HORA: " + DateTime.Now.ToShortTimeString());
            ticket.TextoIzquierda("USUARIO: " + Usuario);
            ticket.TextoIzquierda("");

            double TotalBaseCaja = Convert.ToDouble(txt_apertura.Text);
            double Ingresos = Convert.ToDouble(txt_ingresos.Text);
            double Gastos = Convert.ToDouble(txt_gastos.Text);
            double CierreCaja = Convert.ToDouble(txt_cierre_caja.Text);
            double ConteoDinero = Convert.ToDouble(txt_conteo_dinero.Text);
            double TotalDiferencia = Convert.ToDouble(txt_diferencia.Text);

            //Informacion cierre.
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("APERTURA CAJA:");
            ticket.TextoIzquierda("" + TotalBaseCaja.ToString("N2") + "");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("INGRESOS:");
            ticket.TextoIzquierda("" + Ingresos.ToString("N2") + "");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("GASTOS:");
            ticket.TextoIzquierda("" + Gastos.ToString("N2") + "");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("CIERRE CAJA:");
            ticket.TextoIzquierda("" + CierreCaja.ToString("N2") + "");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("CONTEO DINERO:");
            ticket.TextoIzquierda("" + ConteoDinero.ToString("N2") + "");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("DIFERENCIA:");
            ticket.TextoIzquierda("" + TotalDiferencia.ToString("N2") + "");
            ticket.lineasAsteriscos();
            //
            //ticket.TextoCentro("VENTAS");
            //ticket.lineasAsteriscos();
            //ticket.TextoIzquierda("");
            ////informacion de ventas
            //vent.CodigoUsuario = CodigoUsuario;
            //DT = vent.InformeVentasCierreCaja();
            //if (DT.Rows.Count > 0)
            //{
            //    string NomDocTemp = "";
            //    string ConseDocTemp = "";

            //    foreach (DataRow rowsVent in DT.Rows)
            //    {
            //        if (NomDocTemp != "" && ConseDocTemp != "")
            //        {
            //            if (NomDocTemp == rowsVent["NombreDocumento"].ToString() && ConseDocTemp == rowsVent["ConsecutivoDocumento"].ToString())
            //            {                         
            //                ticket.TextoIzquierda("Item: " + rowsVent["Item"].ToString() + "");
            //                ticket.TextoIzquierda("Codigo Barras: " + rowsVent["CodigoBarras"].ToString() + "");
            //                ticket.TextoIzquierda("Nombre: " + rowsVent["Nombre"].ToString() + "");
            //                double ValorUnidad = Convert.ToDouble(rowsVent["ValorUnidad"]);
            //                ticket.TextoIzquierda("Valor Unidad: " + ValorUnidad.ToString("N") + "");
            //                ticket.TextoIzquierda("Cantidad: " + rowsVent["Cantidad"].ToString() + "");
            //                double Subtotal = Convert.ToDouble(rowsVent["SubTotal"]);
            //                ticket.TextoIzquierda("SubTotal: " + Subtotal.ToString("N") + "");
            //                ticket.TextoIzquierda("Descuento %: " + rowsVent["Descuento"] + "");
            //                double ValorDescuento = Convert.ToDouble(rowsVent["ValorDescuento"]);
            //                ticket.TextoIzquierda("Valor Desc.: " + ValorDescuento.ToString("N") + "");
            //                ticket.TextoIzquierda("Propina %: " + rowsVent["Propina"] + "");
            //                double ValorPropina = Convert.ToDouble(rowsVent["ValorPropina"]);
            //                ticket.TextoIzquierda("Valor Prop.: " + ValorPropina.ToString("N") + "");
            //                double ValorDomicilio = Convert.ToDouble(rowsVent["ValorDomicilio"]);
            //                ticket.TextoIzquierda("Valor Domi.: " + ValorDomicilio.ToString("N") + "");
            //                double Total = Convert.ToDouble(rowsVent["TOTAL"]);
            //                ticket.TextoIzquierda("TOTAL: " + Total.ToString("N") + "");
            //                ticket.TextoIzquierda("-------------------------");
            //            }
            //            else
            //            {
            //                ticket.TextoIzquierda("");
            //                ticket.lineasAsteriscos();
            //                ticket.TextoIzquierda("");
            //                ticket.TextoIzquierda("FACTURA: " + rowsVent["NombreDocumento"].ToString() + "-" + rowsVent["ConsecutivoDocumento"].ToString() + "");

            //                ticket.TextoIzquierda("Item: " + rowsVent["Item"].ToString() + "");
            //                ticket.TextoIzquierda("Codigo Barras: " + rowsVent["CodigoBarras"].ToString() + "");
            //                ticket.TextoIzquierda("Nombre: " + rowsVent["Nombre"].ToString() + "");
            //                double ValorUnidad = Convert.ToDouble(rowsVent["ValorUnidad"]);
            //                ticket.TextoIzquierda("Valor Unidad: " + ValorUnidad.ToString("N") + "");
            //                ticket.TextoIzquierda("Cantidad: " + rowsVent["Cantidad"].ToString() + "");
            //                double Subtotal = Convert.ToDouble(rowsVent["SubTotal"]);
            //                ticket.TextoIzquierda("SubTotal: " + Subtotal.ToString("N") + "");
            //                ticket.TextoIzquierda("Descuento %: " + rowsVent["Descuento"] + "");
            //                double ValorDescuento = Convert.ToDouble(rowsVent["ValorDescuento"]);
            //                ticket.TextoIzquierda("Valor Desc.: " + ValorDescuento.ToString("N") + "");
            //                ticket.TextoIzquierda("Propina %: " + rowsVent["Propina"] + "");
            //                double ValorPropina = Convert.ToDouble(rowsVent["ValorPropina"]);
            //                ticket.TextoIzquierda("Valor Prop.: " + ValorPropina.ToString("N") + "");
            //                double ValorDomicilio = Convert.ToDouble(rowsVent["ValorDomicilio"]);
            //                ticket.TextoIzquierda("Valor Domi.: " + ValorDomicilio.ToString("N") + "");
            //                double Total = Convert.ToDouble(rowsVent["TOTAL"]);
            //                ticket.TextoIzquierda("TOTAL: " + Total.ToString("N") + "");
            //                ticket.TextoIzquierda("-------------------------");
            //            }
            //        }
            //        else
            //        {
            //            ticket.TextoIzquierda("FACTURA: " + rowsVent["NombreDocumento"].ToString() + "-" + rowsVent["ConsecutivoDocumento"].ToString() + "");
            //            ticket.TextoIzquierda("Item: " + rowsVent["Item"].ToString() + "");
            //            ticket.TextoIzquierda("Codigo Barras: " + rowsVent["CodigoBarras"].ToString() + "");
            //            ticket.TextoIzquierda("Nombre: " + rowsVent["Nombre"].ToString() + "");
            //            double ValorUnidad = Convert.ToDouble(rowsVent["ValorUnidad"]);
            //            ticket.TextoIzquierda("Valor Unidad: " + ValorUnidad.ToString("N") + "");
            //            ticket.TextoIzquierda("Cantidad: " + rowsVent["Cantidad"].ToString() + "");
            //            double Subtotal = Convert.ToDouble(rowsVent["SubTotal"]);
            //            ticket.TextoIzquierda("SubTotal: " + Subtotal.ToString("N") + "");
            //            ticket.TextoIzquierda("Descuento %: " + rowsVent["Descuento"] + "");
            //            double ValorDescuento = Convert.ToDouble(rowsVent["ValorDescuento"]);
            //            ticket.TextoIzquierda("Valor Desc.: " + ValorDescuento.ToString("N") + "");
            //            ticket.TextoIzquierda("Propina %: " + rowsVent["Propina"] + "");
            //            double ValorPropina = Convert.ToDouble(rowsVent["ValorPropina"]);
            //            ticket.TextoIzquierda("Valor Prop.: " + ValorPropina.ToString("N") + "");
            //            double ValorDomicilio = Convert.ToDouble(rowsVent["ValorDomicilio"]);
            //            ticket.TextoIzquierda("Valor Domi.: " + ValorDomicilio.ToString("N") + "");
            //            double Total = Convert.ToDouble(rowsVent["TOTAL"]);
            //            ticket.TextoIzquierda("TOTAL: " + Total.ToString("N") + "");
            //            ticket.TextoIzquierda("-------------------------");
            //        }

            //        NomDocTemp = rowsVent["NombreDocumento"].ToString();
            //        ConseDocTemp = rowsVent["ConsecutivoDocumento"].ToString();                                               
            //    }
            //}
            //else
            //{
            //    ticket.TextoIzquierda("No ha realizado ventas");
            //}
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.CortaTicket();

            ticket.ImprimirTicketCaja(NombreImpresora);//Nombre de la impresora ticketera
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            ImprimirCierreCaja();
        }
    }
}
