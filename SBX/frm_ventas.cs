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
        cls_credito cls_Credito = new cls_credito();
        cls_sistema_separado cls_Sistema_Separado = new cls_sistema_separado();
        cls_domicilio cls_Domicilio = new cls_domicilio();
        //Variables
        DataTable v_dt;
        int v_fila = 0;
        int v_contador = 0;
        bool v_confirmacion;
        bool v_ok;
        int Eliminados;
        int Error;

        int BuscaAutomatica = 0;
        int BuscaPaginado = 0;
        public DataTable v_dt_Permi { get; set; }
        public string usuarios { get; set; }

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
            MensajeInformativoBotones();
        }

        //metodos

        public void MensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar");
            Botones.SetToolTip(btn_exportar_excel, "Exportar a Excel");
            Botones.SetToolTip(btn_eliminar, "Eliminar");
            Botones.SetToolTip(btn_impresion_ticket, "Impresion Tikect");
            Botones.SetToolTip(btn_cotizaciones, "Cotizaciones");
            Botones.SetToolTip(btn_impresion, "Impresion PDF");
            Botones.SetToolTip(btn_orden_servicio, "Orden de servicio");  
        }
        private void mtd_cargar_ventas()
        {
            lbl_total_ventas.Text = "0";
            lbl_cantidad.Text = "0";
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
           
            cls_Venta.Fecha_inicio = dtp_fecha_inicio.Text;
            cls_Venta.Fecha_fin = dtp_fecha_fin.Text;
            v_dt = cls_Venta.mtd_consultar_Venta();
            dtg_ventas.Rows.Clear();

            if (v_dt.Rows.Count > 0)
            {
                v_fila = v_dt.Rows.Count;
                dtg_ventas.Rows.Add(v_fila);
                v_contador = 0;
                lbl_total_ventas.Text = "0";
                double VentasTotales = 0;
                double DescuentosTotales = 0;
                double CantidadVenta = 0;
                float CantidadExacta = 0;
                string Factura = "";
                float cantidad = 0;
                float precioVentas = 0;
                double totalVentas = 0;
                string FacturaTemp = "";
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
                    CantidadExacta += float.Parse(rows["Cantidad_exacta"].ToString());
                    cantidad = float.Parse(rows["Cantidad_exacta"].ToString());
                    dtg_ventas.Rows[v_contador].Cells["cl_cantidad"].Value = rows["Cantidad_exacta"].ToString();                  
                    double costo = Convert.ToDouble(rows["Costo2"]);
                    dtg_ventas.Rows[v_contador].Cells["cl_costo"].Value = costo.ToString("N2");
                    double PrecioVenta = 0;
                    PrecioVenta = Convert.ToDouble(rows["PrecioVenta2"]);
                    dtg_ventas.Rows[v_contador].Cells["cl_precio_venta"].Value = PrecioVenta.ToString("N2");
                    double Total_2 = Convert.ToDouble(rows["Total"]);
                    double Abonos = 0;
                    double Debe = 0;
                    double ValorDescuento_1 = Convert.ToDouble(rows["ValorDescuento"]);
                    Debe = Total_2;
                    string EstadoDomicilio = "";
                    
                    if (rows["credito"].ToString() != "0")
                    {
                        cls_Credito.Codigo = Convert.ToInt32(rows["credito"]);
                        v_dt = cls_Credito.mtd_consultar_sum_abonos();
                        DataRow rowCredt = v_dt.Rows[0];

                        Abonos = Convert.ToDouble(rowCredt["ValorAbonos"]);
                        PrecioVenta = 0;
                    }
                   
                    if (rows["separado"].ToString() != "0")
                    {
                        cls_Sistema_Separado.Codigo = Convert.ToInt32(rows["separado"]);
                        v_dt = cls_Sistema_Separado.mtd_consultar_sum_abonos();
                        DataRow rowCredt = v_dt.Rows[0];
                        Abonos = Convert.ToDouble(rowCredt["ValorAbonos"]);
                        PrecioVenta = 0;
                    }

                    if (rows["Domicilio"].ToString() != "0")
                    {
                        cls_Domicilio.Codigo = Convert.ToInt32(rows["Domicilio"]);
                        v_dt = cls_Domicilio.mtd_consultar_domicilio_Estado();
                        DataRow rowCredt = v_dt.Rows[0];
                        EstadoDomicilio = rowCredt["Estado"].ToString();
                        if (EstadoDomicilio != "Pago" && EstadoDomicilio != "Procesado")
                        {
                            PrecioVenta = 0;
                        }                       
                    }

                    if (rows["separado"].ToString() != "0" || rows["credito"].ToString() != "0")
                    {
                        Debe = (Debe - Abonos) - ValorDescuento_1;
                    }
                    else
                    {
                        Debe = 0;
                    }
                   
                    dtg_ventas.Rows[v_contador].Cells["cl_debe"].Value = Debe.ToString("N2");
                    VentasTotales += PrecioVenta;
                    dtg_ventas.Rows[v_contador].Cells["cl_abonos"].Value = Abonos.ToString("N2");
                    VentasTotales += Abonos;
                    dtg_ventas.Rows[v_contador].Cells["descuento"].Value = rows["descuento"];
                    double ValorDescuento = Convert.ToDouble(rows["ValorDescuento"]);
                    DescuentosTotales += ValorDescuento;
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
                    //if (Factura == "")
                    //{
                    //    VentasTotales = Total;
                    //}
                    //else
                    //{
                    //    //Factura = rows["Factura"].ToString();
                    //    if (Factura != rows["Factura"].ToString())
                    //    {
                    //        VentasTotales += Total;
                    //    }           
                    //}


             
                    dtg_ventas.Rows[v_contador].Cells["cl_Total"].Value = Total.ToString("N2");
                    dtg_ventas.Rows[v_contador].Cells["cl_Usuario"].Value = rows["Usuario"];
                    dtg_ventas.Rows[v_contador].Cells["cl_cliente"].Value = rows["Cliente"];
                    dtg_ventas.Rows[v_contador].Cells["cl_sucursal"].Value = rows["Sucursal"];
                    dtg_ventas.Rows[v_contador].Cells["cl_domicilio"].Value = rows["Domicilio"];
                    dtg_ventas.Rows[v_contador].Cells["cl_separado"].Value = rows["separado"];
                    dtg_ventas.Rows[v_contador].Cells["cl_credito"].Value = rows["credito"];
                    Factura = rows["Factura"].ToString();
                    v_contador++;
                }
                totalVentas = VentasTotales - DescuentosTotales;
                lbl_total_ventas.Text = totalVentas.ToString("N");
                //lbl_cantidad.Text = CantidadVenta.ToString();
                lbl_cantidad.Text = CantidadExacta.ToString();
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
                            int numSeparado = Convert.ToInt32(rows.Cells["cl_separado"].Value);
                            int numCredito = Convert.ToInt32(rows.Cells["cl_credito"].Value);
                            int numDomicilio = Convert.ToInt32(rows.Cells["cl_domicilio"].Value);
                            cls_Venta.Codigo = num;
                            cls_Venta.NumSeparado = numSeparado;
                            cls_Venta.NumCredito = numCredito;
                            cls_Venta.Domicilio = numDomicilio;
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
            this.Cursor = Cursors.WaitCursor;
            mtd_cargar_ventas();
            this.Cursor = Cursors.Default;
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (BuscaAutomatica == 1 )
            {
                this.Cursor = Cursors.WaitCursor;
                mtd_cargar_ventas();
                this.Cursor = Cursors.Default;
            }     
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
            cls_Venta.Fecha_inicio = dtp_fecha_inicio.Text;
            cls_Venta.Fecha_fin = dtp_fecha_fin.Text;
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
                if (rows["Modulo"].ToString() == "VENTAS")
                {
                    switch (rows["Permiso"].ToString())
                    {
                        case "eliminar":
                            btn_eliminar.Enabled = true;
                            break;
                        case "exportar_excel":
                            btn_exportar_excel.Enabled = true;
                            break;
                        case "ImprimirTicket":
                            btn_impresion_ticket.Enabled = true;
                            break;
                        case "ImprimirPDF":
                            btn_impresion.Enabled = true;
                            break;
                        case "Cotizacion":
                            btn_cotizaciones.Enabled = true;
                            break;
                    }
                }
            }

            BuscaAutomatica = 0;
            BuscaPaginado = 0;
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
        }
        
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Cursor = Cursors.WaitCursor;
                mtd_cargar_ventas();
                this.Cursor = Cursors.Default;
            }             
        }
        string Domicilio = "";
        private void btn_impresion_ticket_Click(object sender, EventArgs e)
        {
            string Doc = "";
            string conseDoc = "";
           
            string[] Factura;
            if (dtg_ventas.Rows.Count > 0) 
            {
                if (dtg_ventas.SelectedRows.Count > 0) 
                {
                    foreach (DataGridViewRow rows in dtg_ventas.SelectedRows)
                    {
                        Factura = rows.Cells["cl_factura"].Value.ToString().Split('-');

                        Doc = Factura[0];
                        conseDoc = Factura[1];
                        Domicilio = rows.Cells["cl_domicilio"].Value.ToString();
                    }
                    mtd_imprimir(Doc, conseDoc);
                }
                    
            }
              
        }

        private void mtd_imprimir(string NombDoc, string ConsecutivoDoc)
        {
            CrearTicket ticket = new CrearTicket();
            cls_empresa Empres = new cls_empresa();

            //ticket.AbreCajon();//Para abrir el cajon de dinero.
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
            //ticket.TextoIzquierda("USUARIO: " + Usuario);
            ///
            DataTable DTVenta;
            cls_Venta.NombreDocumento = NombDoc;
            cls_Venta.ConsecutivoDocumento = ConsecutivoDoc;
            //DTVenta = cls_Venta.mtd_consultar_Ventas_factura();
            cls_Venta.v_buscar = NombDoc + '-' + ConsecutivoDoc;
            DTVenta = cls_Venta.mtd_consultar_dato_impresion();
            row = DTVenta.Rows[0];
            ///
            ticket.TextoIzquierda("FACTURA N. " + row["Factura"].ToString());
            if (Domicilio == "0")
            {
                ticket.TextoIzquierda("CLIENTE: " + row["Cliente"].ToString() + "");
            }
            //ticket.TextoIzquierda("");
            //ticket.lineasAsteriscos();

            if (Domicilio != "0")
            {
                ticket.TextoIzquierda("MENSAJERO: " + row["Mensajero"].ToString() + " " + row["NMensajero"].ToString());
                ticket.TextoIzquierda("# DOMICILIO: " + row["CodigoDomicilio"].ToString());
                ticket.TextoIzquierda("CELULAR: " + row["Celular"].ToString());
                ticket.TextoIzquierda("TELEFONO FIJO: " + row["Telefono"].ToString());
                ticket.TextoIzquierda("NOMBRES: " + row["NombreC"].ToString());
                ticket.TextoIzquierda("DIRECCION: " + row["Direccion"].ToString());
            }
            //ticket.lineasAsteriscos();

            double Subtotal = 0;
            double Impuesto = 0;
            double Descuento = 0;
            double TotalDescuento = 0;
            double Recibido = 0;
            double Devueltas = 0;
            double AritculosVendidos = 0;
            double Total = 0;
            double ValorDomicilio = 0;
            foreach (DataRow rows in DTVenta.Rows)
            {               
                double Cant;

                ticket.TextoIzquierda("--------------------------------------");
                ticket.AgregaArticulo(rows["Item"].ToString(), " ", rows["UM"].ToString() + " ", (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"])));
                ticket.TextoIzquierda(rows["Nombre"].ToString());
                ticket.MuestraCalculoPRecioProducto(rows["Cantidad_Exacta"].ToString(), Convert.ToDouble(rows["PrecioVenta"]));
                Descuento = ((Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"])) * (Convert.ToDouble(rows["Descuento"]) / 100));
                ticket.AgregarTotales("Descuento.........", Descuento);
                //ticket.AgregarTotales("IVA %.........",  Convert.ToDouble(rows["IVA"]));
                //ticket.AgregarTotales("IVA %.........", 0);
                //ticket.AgregarTotales("Valor IVA.........", (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad"])) * (Convert.ToDouble(rows["IVA"])/100));
                //ticket.AgregarTotales("Valor IVA.........", 0);
                double subtotal_inicial = 0;
                subtotal_inicial = (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"])) - Descuento;
                ticket.AgregarTotales("SubTotal.........", subtotal_inicial);
                TotalDescuento += Descuento;
                Subtotal += (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"]));
                //Impuesto += ((Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad"])) * (Convert.ToDouble(rows["IVA"]) / 100));
                Impuesto = 0;
                Recibido = Convert.ToDouble(rows["Efectivo"]) + Convert.ToDouble(rows["Tdebito"]) + Convert.ToDouble(rows["Tcredito"]);
                Devueltas = Convert.ToDouble(rows["Cambio"]);
                AritculosVendidos += Convert.ToDouble(rows["Cantidad_Exacta"]);
                ValorDomicilio = Convert.ToDouble(rows["ValorDomicilio"]);
                Total = (Subtotal - TotalDescuento) + Impuesto;
            }
            ticket.lineasIgual();
            //Resumen de la venta.
            ticket.AgregarTotales("SUBTOTAL......$", Subtotal);
            //ticket.AgregarTotales("IVA...........$", Impuesto);
            ticket.AgregarTotales("DESCUENTO.....$", TotalDescuento);

            if (Domicilio != "0")
            {
                ticket.AgregarTotales("DOMICILIO.....$", ValorDomicilio);
            }
            ticket.AgregarTotales("TOTAL.........$", Math.Round(Total));
            //ticket.TextoIzquierda("");
            ticket.AgregarTotales("RECIBIDO......$", Recibido);
            ticket.AgregarTotales("CAMBIO........$", Devueltas);
            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTICULOS VENDIDOS: " + AritculosVendidos + "");
            //ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("");
            //ticket.TextoCentro("SERVICIO A DOMICILIO");
            //ticket.TextoCentro(NumerosCelular);
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.CortaTicket();
            ticket.ImprimirTicket(NombreImpresora);//Nombre de la impresora ticketera
        }
        private void btn_cotizaciones_Click(object sender, EventArgs e)
        {
            frm_cotizaciones frm_Cotizaciones = new frm_cotizaciones();
            frm_Cotizaciones.v_dt_Permi = v_dt_Permi;
            frm_Cotizaciones.usuario = usuarios;
            frm_Cotizaciones.Show();
        }
        private void btn_impresion_Click(object sender, EventArgs e)
        {
            //Imprimir factura PDF
            if (MessageBox.Show("¿Desea imprimir Factura?", "Imprimir factura", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataTable DT_FACT = new DataTable();
                List<cls_venta> lrFact = new List<cls_venta>();
                foreach (DataGridViewRow item in dtg_ventas.SelectedRows)
                {
                    cls_Venta.v_buscar = item.Cells["cl_factura"].Value.ToString();
                }               
                DT_FACT = cls_Venta.mtd_consultar_dato_impresion();
                foreach (DataRow rows in DT_FACT.Rows)
                {
                    cls_venta cls_Venta_2 = new cls_venta();
                    cls_Venta_2.fact_Codigo = rows["Codigo"].ToString();
                    DateTime Fecha = Convert.ToDateTime(rows["Fecha"].ToString());
                    cls_Venta_2.fact_Fecha = Fecha.ToString("yyyy-MM-dd");
                    cls_Venta_2.fact_Factura = rows["Factura"].ToString();
                    cls_Venta_2.fact_Item = rows["Item"].ToString();
                    cls_Venta_2.fact_Nombre = rows["Nombre"].ToString();
                    cls_Venta_2.fact_Referencia = rows["Referencia"].ToString();
                    cls_Venta_2.fact_CodigoBarras = rows["CodigoBarras"].ToString();
                    cls_Venta_2.fact_ModoVenta = rows["ModoVenta"].ToString();
                    cls_Venta_2.fact_UM = rows["UM"].ToString();
                    cls_Venta_2.fact_Cantidad = rows["Cantidad"].ToString();
                    cls_Venta_2.fact_Cantidad_Exacta = rows["Cantidad_Exacta"].ToString();
                    cls_Venta_2.fact_Costo = rows["Costo"].ToString();
                    cls_Venta_2.fact_Costo2 = rows["Costo2"].ToString();
                    double fact_PrecioVenta2 = Convert.ToDouble(rows["PrecioVenta2"]);
                    cls_Venta_2.fact_PrecioVenta2 = fact_PrecioVenta2.ToString("N");
                    double fact_PrecioVenta = Convert.ToDouble(rows["PrecioVenta"]);
                    cls_Venta_2.fact_PrecioVenta = fact_PrecioVenta.ToString("N");
                    cls_Venta_2.fact_descuento = rows["descuento"].ToString();
                    double fact_ValorDescuento = ((Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"])) * (Convert.ToDouble(rows["Descuento"]) / 100));
                    cls_Venta_2.fact_ValorDescuento = fact_ValorDescuento.ToString("N");
                    double subtotal = 0;
                    subtotal = (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"]));
                    cls_Venta_2.fact_Tdebito = rows["Tdebito"].ToString();
                    cls_Venta_2.fact_NumBaucherDebito = rows["NumBaucherDebito"].ToString();
                    cls_Venta_2.fact_Tcredito = rows["Tcredito"].ToString();
                    cls_Venta_2.fact_NumBaucherCredito = rows["NumBaucherCredito"].ToString();
                    double total = subtotal - fact_ValorDescuento;
                    cls_Venta_2.fact_Total = total.ToString("N");
                    cls_Venta_2.fact_Efectivo = rows["Efectivo"].ToString();
                    cls_Venta_2.fact_Cambio = rows["Cambio"].ToString();
                    cls_Venta_2.fact_Cliente = rows["Cliente"].ToString();
                    cls_Venta_2.fact_Sucursal = rows["Sucursal"].ToString();
                    cls_Venta_2.fact_Domicilio = rows["Domicilio"].ToString();
                    cls_Venta_2.fact_Usuario = rows["Usuario"].ToString();
                    cls_Venta_2.fact_CodigoDomicilio = rows["CodigoDomicilio"].ToString();
                    cls_Venta_2.fact_Mensajero = rows["Mensajero"].ToString();
                    cls_Venta_2.fact_Celular = rows["Celular"].ToString();
                    cls_Venta_2.fact_Telefono = rows["Telefono"].ToString();
                    cls_Venta_2.fact_NombreC = rows["NombreC"].ToString();
                    cls_Venta_2.fact_Direccion = rows["Direccion"].ToString();
                    cls_Venta_2.fact_NMensajero = rows["NMensajero"].ToString();
                    cls_Venta_2.fact_ValorDomicilio = rows["ValorDomicilio"].ToString();
                    cls_Venta_2.fact_DNI_emp = rows["DNI_emp"].ToString();
                    cls_Venta_2.fact_Nombre_emp = rows["Nombre_emp"].ToString();
                    cls_Venta_2.fact_Telefono_emp = rows["Telefono_emp"].ToString();
                    cls_Venta_2.fact_Celular_emp = rows["Celular_emp"].ToString();
                    cls_Venta_2.fact_Direccion_emp = rows["Direccion_emp"].ToString();
                    cls_Venta_2.fact_Email_emp = rows["Email_emp"].ToString();
                    cls_Venta_2.fact_SitioWeb_emp = rows["SitioWeb_emp"].ToString();
                    cls_Venta_2.fact_Foto_emp = (byte[])rows["Foto_emp"];
                    cls_Venta_2.fact_Ciudad_emp = rows["Ciudad_emp"].ToString();
                    cls_Venta_2.fact_dni_cli = rows["dni_cli"].ToString();
                    cls_Venta_2.fact_nombre_cli = rows["nombre_cli"].ToString();
                    cls_Venta_2.fact_ciudad_cli = rows["ciudad_cli"].ToString();
                    cls_Venta_2.fact_telefono_cli = rows["telefono_cli"].ToString();
                    cls_Venta_2.fact_celular_cli = rows["celular_cli"].ToString();
                    cls_Venta_2.fact_direccion_cli = rows["direccion_cli"].ToString();
                    cls_Venta_2.fact_email_cli = rows["email_cli"].ToString();
                    cls_Venta_2.fact_sitioweb_cli = rows["sitioweb_cli"].ToString();

                    lrFact.Add(cls_Venta_2);
                }
                frm_cotizacion frm_Cotizacion = new frm_cotizacion();
                frm_Cotizacion.Reporte = "Factura";
                frm_Cotizacion.lrFact = lrFact;
                frm_Cotizacion.Show();
            }
        }

        private void btn_orden_servicio_Click(object sender, EventArgs e)
        {
            frm_orden_servicio frm_Orden_Servicio = new frm_orden_servicio();
            frm_Orden_Servicio.v_dt_Permi = v_dt_Permi;
            frm_Orden_Servicio.usuario = usuarios;
            frm_Orden_Servicio.Show();
        }
    }
}
