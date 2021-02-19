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
    public partial class frm_agregar_abono : Form
    {
        //Delegado
        public delegate void EnviarInfo(double pago,double valor,int cod_sisp);
        public event EnviarInfo Enviainfo;

        cls_sistema_separado cls_Sistema_separado = new cls_sistema_separado();
        cls_global cls_Global = new cls_global();

        //Variables
        DataTable v_dt;
        DataRow v_rows;
        bool v_ok;
        int v_fila = 0;
        int v_contador = 0;
        int v_validado = 0;
        public String usuario { get; set; }

        public frm_agregar_abono()
        {
            InitializeComponent();
        }
        private void frm_agregar_abono_Load(object sender, EventArgs e)
        {
            mtd_calculos();
            if (lbl_estado.Text == "Pago")
            {
                pnl_abajo.Enabled = false;
            }
        }
        //Metodos
        private void mtd_calculos()
        {
            cls_Sistema_separado.Codigo = Convert.ToInt32(lbl_num_separado.Text);
            v_dt = cls_Sistema_separado.mtd_consultar_abono_sistema();
            if (v_dt.Rows.Count > 0)
            {
                v_rows = v_dt.Rows[0];
                double pago = Convert.ToDouble(v_rows["Pago"]);
                lbl_pagado.Text = pago.ToString("N0");
                lbl_cuota_num.Text = v_rows["Cuotas"].ToString();
                double Saldo = Convert.ToDouble(lbl_valor.Text) - pago;
                lbl_saldo.Text = Saldo.ToString("N0"); 
            }
        }

        //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            v_validado = 0;
            if (!cls_Global.IsNumericDouble(txt_abono.Text))
            {
                v_validado++;
                errorProvider.SetError(txt_abono,"Ingrese valores numericos");
            }

            if (v_validado == 0)
            {
                if (Convert.ToDouble(txt_abono.Text) > 0)
                {
                    if ((Convert.ToDouble(lbl_pagado.Text) + (Convert.ToDouble(txt_abono.Text))) > Convert.ToDouble(lbl_valor.Text))
                    {
                        errorProvider.SetError(txt_abono, "La cuota mas lo pagado supera el valor separado");
                    }
                    else
                    {
                        cls_Sistema_separado.Codigo = Convert.ToInt32(lbl_num_separado.Text);
                        cls_Sistema_separado.Valor = Convert.ToDouble(txt_abono.Text);
                        cls_Sistema_separado.Saldo = lbl_saldo.Text;
                        cls_Sistema_separado.Valortotal = lbl_valor.Text;
                        cls_Sistema_separado.Cliente_separado = lbl_cliente.Text;
                       
                        v_ok = cls_Sistema_separado.mtd_registrar_abono();
                        frm_msg frm_Msg = new frm_msg();
                        if (v_ok == true)
                        {
                            frm_Msg.txt_mensaje.Text = "Abono registrado correctamente";
                            frm_Msg.ShowDialog();
                            //mtd_imprimir(lbl_num_separado.Text, "");
                            Enviainfo((Convert.ToDouble(lbl_pagado.Text) + (Convert.ToDouble(txt_abono.Text))), Convert.ToDouble(lbl_valor.Text), Convert.ToInt32(lbl_num_separado.Text));
                            this.Dispose();
                        }
                    }
                }
                else
                {
                    errorProvider.SetError(txt_abono, "Abono debe ser mayor a cero (0)");
                }
            }
        }

        //private void mtd_imprimir(string NomSeparado, string NumAbono)
        //{
        //    CrearTicket ticket = new CrearTicket();
        //    cls_empresa Empres = new cls_empresa();

        //    ticket.AbreCajon();//Para abrir el cajon de dinero.
        //    DataRow row;
        //    DataTable DTEmpresa;
        //    DTEmpresa = Empres.mtd_consultar_Empresa();
        //    row = DTEmpresa.Rows[0];
        //    string NombreImpresora = row["Impresora"].ToString();
        //    string NumerosCelular = row["Celular"].ToString();
        //    //Datos de la cabecera del Ticket.
        //    ticket.TextoCentro(row["Nombre"].ToString());
        //    ticket.TextoCentro("NIT:" + row["DNI"]);
        //    ticket.TextoIzquierda("DIREC: " + row["Direccion"] + "");
        //    ticket.TextoIzquierda("TELEF: " + row["Telefono"] + "");
        //    ticket.TextoIzquierda("CELUL: " + row["Celular"] + "");
        //    ticket.TextoIzquierda("EMAIL: " + row["Email"] + "");
        //    ticket.TextoIzquierda("WEB: " + row["SitioWeb"] + "");
        //    ticket.TextoIzquierda("FECHA: " + DateTime.Now.ToShortDateString() + "");
        //    ticket.TextoIzquierda("HORA: " + DateTime.Now.ToShortTimeString());
        //    ticket.TextoIzquierda("USUARIO: " + Usuario);
        //    ///
        //    DataTable DTVenta;
        //    cls_Venta.NombreDocumento = NombDoc;
        //    cls_Venta.ConsecutivoDocumento = ConsecutivoDoc;
        //    //DTVenta = cls_Venta.mtd_consultar_Ventas_factura();
        //    cls_Venta.v_buscar = NombDoc + '-' + ConsecutivoDoc;
        //    DTVenta = cls_Venta.mtd_consultar_dato_impresion();
        //    row = DTVenta.Rows[0];
        //    ///
        //    ticket.TextoIzquierda("FACTURA N. " + row["Factura"].ToString());
        //    if (v_domicilio == false)
        //    {
        //        ticket.TextoIzquierda("CLIENTE: " + row["Cliente"].ToString() + "");
        //    }
        //    //ticket.TextoIzquierda("");
        //    //ticket.lineasAsteriscos();

        //    if (v_domicilio == true)
        //    {
        //        ticket.TextoIzquierda("MENSAJERO: " + row["Mensajero"].ToString() + " " + row["NMensajero"].ToString());
        //        ticket.TextoIzquierda("# DOMICILIO: " + row["CodigoDomicilio"].ToString());
        //        ticket.TextoIzquierda("CELULAR: " + row["Celular"].ToString());
        //        ticket.TextoIzquierda("TELEFONO FIJO: " + row["Telefono"].ToString());
        //        ticket.TextoIzquierda("NOMBRES: " + row["NombreC"].ToString());
        //        ticket.TextoIzquierda("DIRECCION: " + row["Direccion"].ToString());
        //    }
        //    //ticket.lineasAsteriscos();

        //    double Subtotal = 0;
        //    double Impuesto = 0;
        //    double Descuento = 0;
        //    double TotalDescuento = 0;
        //    double Recibido = 0;
        //    double Devueltas = 0;
        //    double AritculosVendidos = 0;
        //    double Total = 0;
        //    double ValorDomicilio = 0;
        //    foreach (DataRow rows in DTVenta.Rows)
        //    {
        //        double Cant;
        //        ticket.TextoIzquierda("--------------------------------------");
        //        ticket.AgregaArticulo(rows["Item"].ToString(), " ", rows["UM"].ToString() + " ", (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"])));
        //        ticket.TextoIzquierda(rows["Nombre"].ToString());
        //        ticket.MuestraCalculoPRecioProducto(rows["Cantidad_Exacta"].ToString(), Convert.ToDouble(rows["PrecioVenta"]));
        //        Descuento = ((Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"])) * (Convert.ToDouble(rows["Descuento"]) / 100));
        //        ticket.AgregarTotales("Descuento.........", Descuento);
        //        //ticket.AgregarTotales("IVA %.........",  Convert.ToDouble(rows["IVA"]));
        //        // ticket.AgregarTotales("IVA %.........",  0);
        //        //ticket.AgregarTotales("Valor IVA.........", (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad"])) * (Convert.ToDouble(rows["IVA"])/100));
        //        //ticket.AgregarTotales("Valor IVA.........", 0);
        //        double subtotal_inicial = 0;
        //        subtotal_inicial = (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"])) - Descuento;
        //        ticket.AgregarTotales("SubTotal.........", subtotal_inicial);
        //        TotalDescuento += Descuento;
        //        Subtotal += (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"]));
        //        //Impuesto += ((Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad"])) * (Convert.ToDouble(rows["IVA"]) / 100));
        //        Impuesto = 0;
        //        Recibido = Convert.ToDouble(rows["Efectivo"]) + Convert.ToDouble(rows["Tdebito"]) + Convert.ToDouble(rows["Tcredito"]);
        //        Devueltas = Convert.ToDouble(rows["Cambio"]);
        //        AritculosVendidos += Convert.ToDouble(rows["Cantidad_Exacta"]);
        //        ValorDomicilio = Convert.ToDouble(rows["ValorDomicilio"]);
        //        Total = (Subtotal - TotalDescuento) + Impuesto;
        //    }
        //    ticket.lineasIgual();
        //    //Resumen de la venta.
        //    ticket.AgregarTotales("SUBTOTAL......$", Subtotal);
        //    //ticket.AgregarTotales("IVA...........$", Impuesto);
        //    ticket.AgregarTotales("DESCUENTO.....$", TotalDescuento);

        //    if (v_domicilio == true)
        //    {
        //        ticket.AgregarTotales("DOMICILIO.....$", ValorDomicilio);
        //    }
        //    ticket.AgregarTotales("TOTAL.........$", Math.Round(Total));
        //    //ticket.TextoIzquierda("--------------------------------------");
        //    ticket.AgregarTotales("RECIBIDO......$", Recibido);
        //    ticket.AgregarTotales("CAMBIO........$", Devueltas);
        //    //Texto final del Ticket.
        //    ticket.TextoIzquierda("");
        //    ticket.TextoIzquierda("ARTICULOS VENDIDOS: " + AritculosVendidos + "");
        //    //ticket.TextoIzquierda("");
        //    //ticket.TextoIzquierda("");
        //    //ticket.TextoCentro("SERVICIO A DOMICILIO");
        //    //ticket.TextoCentro(NumerosCelular);
        //    ticket.TextoIzquierda("");
        //    ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
        //    ticket.TextoIzquierda("");
        //    ticket.TextoIzquierda("");
        //    ticket.TextoIzquierda("");
        //    ticket.TextoIzquierda("");
        //    ticket.CortaTicket();
        //    ticket.ImprimirTicket(NombreImpresora);//Nombre de la impresora ticketera
        //}
        private void btn_ver_productos_Click(object sender, EventArgs e)
        {
            if (btn_ver_productos.Text == "Ver productos")
            {
                this.Height = 516;
                dtg_productos.Height = 106;
                pnl_info.Height = 365;
                btn_ver_productos.Text = "Ocultar Productos";

                cls_Sistema_separado.Codigo = Convert.ToInt32(lbl_num_separado.Text);
                v_dt = cls_Sistema_separado.mtd_consultar_productos();
                dtg_productos.Rows.Clear();
                if (v_dt.Rows.Count > 0)
                {
                    v_contador = 0;
                    v_fila = v_dt.Rows.Count;
                    dtg_productos.Rows.Add(v_fila);
                    foreach (DataRow rows in v_dt.Rows)
                    {
                        dtg_productos.Rows[v_contador].Cells["cl_producto"].Value = rows["Producto"].ToString();
                        v_contador++;
                    }
                }
            }
            else
            {
                this.Height = 403;
                dtg_productos.Height = 0;
                pnl_info.Height = 260;
                btn_ver_productos.Text = "Ver productos";
            }
        }
    }
}
