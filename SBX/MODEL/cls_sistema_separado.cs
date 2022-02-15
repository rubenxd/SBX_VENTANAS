using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.DB;
using System.Data;
using System.Data.SqlClient;

namespace SBX.MODEL
{
    public class cls_sistema_separado
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        SqlParameter[] Parametros;
        bool v_ok;
        public string v_buscar { get; set; }
        public string v_tipo_busqueda { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin { get; set; }
        public List<int> Lst_sepaerados { get; set; }

        //getter and setter
        public int Codigo { get; set; }
        public string Fecha { get; set; }
        public double Valor { get; set; }
        public double Abono_inicial { get; set; }
        public string Periodo_pago { get; set; }
        public string Suministrar { get; set; }
        public int Num_cuotas { get; set; }
        public double Valor_cuota { get; set; }
        public string Fecha_primer_pago { get; set; }
        public string Fecha_vence { get; set; }
        public int Cliente { get; set; }
        public string Cliente_separado { get; set; }
        public string Estado { get; set; }

        public string Saldo { get; set; }
        public string Valortotal { get; set; }
        public string Modulo { get; set; }

        public string usuario { get; set; }
        //Metodos
        public DataTable mtd_consultar_sistema_separado()
        {
            v_query = " EXECUTE sp_consultar_sistema_separado  '" + v_buscar + "','" + v_tipo_busqueda + "','" + Fecha_inicio.ToString("yyyyMMdd") + "','" + Fecha_fin.ToString("yyyyMMdd") + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_sistema_separado_exacto()
        {
            v_query = " SELECT "+
   "  Codigo,Estado,Fecha,Cliente,AbonoInicial,NumCuotas,ValorCuota,PeriodoPago,Valor," +
   "  FechaPrimerPago,FechaVence,Factura" +
   "  FROM(" +
   "  SELECT sp.Codigo, sp.Estado, sp.Fecha, CONCAT(c.DNI, ' - ', c.Nombre) Cliente, " +
   "  CONCAT(p.Item, ' - ', p.Referencia, ' - ', p.CodigoBarras, ' - ', p.Nombre) Producto, " +
   "  v.Cantidad, v.Costo, v.PrecioVenta, sp.AbonoInicial, sp.NumCuotas, sp.ValorCuota, " +
   "  sp.PeriodoPago, sp.Valor, sp.FechaPrimerPago, sp.FechaVence, ISNULL(ab.ValorAbono, 0) ValorAbono, ISNULL(ab.Fecha, '') FechaAbono, " +
   "  CONCAT(v.NombreDocumento, ' - ', v.ConsecutivoDocumento) Factura" +
   "  FROM Venta v" +
   "  INNER JOIN SistemaSeparado sp ON sp.Codigo = v.SistemaSeparado" +
   "  INNER JOIN Cliente c ON c.Codigo = sp.Cliente" +
   "  INNER JOIN Producto p ON p.Item = v.Producto" +
   "  LEFT JOIN AbonoSistemaSeparado ab ON ab.SistemaSeparado = sp.Codigo" +
   "  WHERE CONVERT(VARCHAR, sp.Codigo) IN("+ v_buscar + ")" +
   "  )gb" +
   "  group by Codigo, Estado, Fecha, Cliente, AbonoInicial, NumCuotas, ValorCuota, PeriodoPago, Valor," +
   "  FechaPrimerPago, FechaVence, Factura" +
   "  ORDER BY Codigo DESC";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_productos()
        {
            v_query = " SELECT CONCAT('Cant:',v.Cantidad,' - ',p.Item,' - ',p.Referencia,' - ',p.CodigoBarras, ' - ',p.Nombre) Producto FROM Venta v "+
                      " INNER JOIN Producto p ON p.item = v.Producto "+
                      " WHERE v.SistemaSeparado = "+Codigo;
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_abono_sistema()
        {
            v_query = " SELECT ISNULL(SUM(ValorAbono),0) Pago,COUNT(*)+1 Cuotas FROM AbonoSistemaSeparado "+
                      " WHERE SistemaSeparado = "+ Codigo;
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_abono_sistema_Documento_Factura()
        {
            v_query = "select top(1) NombreDocumento, ConsecutivoDocumento from Venta " +
                      " where SistemaSeparado = " + Codigo;
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_pagos()
        {
            v_query = "SELECT SistemaSeparado,Fecha,ValorAbono FROM AbonoSistemaSeparado WHERE SistemaSeparado = " + Codigo;
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_Abonos()
        {
            v_query = "SELECT ISNULL(SUM(ValorAbono),0) VlrAbono FROM AbonoSistemaSeparado WHERE Fecha BETWEEN '" + Fecha_inicio.ToString("yyyyMMdd") + "' AND '" + Fecha_fin.ToString("yyyyMMdd") + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_sum_abonos()
        {
            v_query = " select isnull(sum(Valorabono),0) ValorAbonos from AbonoSistemaSeparado  where SistemaSeparado = " + Codigo;
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[12];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Codigo";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = Codigo;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Valor";
            Parametros[1].SqlDbType = SqlDbType.Money;
            Parametros[1].SqlValue = Valor;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@AbonoInicial";
            Parametros[2].SqlDbType = SqlDbType.Money;
            Parametros[2].SqlValue = Abono_inicial;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@PeriodoPago";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].SqlValue = Periodo_pago;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Suministrar";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = Suministrar;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@NumCuotas";
            Parametros[5].SqlDbType = SqlDbType.Int;
            Parametros[5].SqlValue = Num_cuotas;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@ValorCuota";
            Parametros[6].SqlDbType = SqlDbType.Money;
            Parametros[6].SqlValue = Valor_cuota;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@FechaPrimerPago";
            Parametros[7].SqlDbType = SqlDbType.Date;
            Parametros[7].SqlValue = Fecha_primer_pago;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@FechaVence";
            Parametros[8].SqlDbType = SqlDbType.Date;
            Parametros[8].SqlValue = Fecha_vence;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@Cliente";
            Parametros[9].SqlDbType = SqlDbType.Int;
            Parametros[9].SqlValue = Cliente;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@Estado";
            Parametros[10].SqlDbType = SqlDbType.VarChar;
            Parametros[10].SqlValue = Estado;

            Parametros[11] = new SqlParameter();
            Parametros[11].ParameterName = "@Fecha";
            Parametros[11].SqlDbType = SqlDbType.DateTime;
            Parametros[11].SqlValue = DateTime.Now;
        }
        private void mtd_asignaParametros_abonar()
        {
            Parametros = new SqlParameter[4];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Fecha";
            Parametros[0].SqlDbType = SqlDbType.DateTime;
            Parametros[0].SqlValue = DateTime.Now;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@ValorAbono";
            Parametros[1].SqlDbType = SqlDbType.Money;
            Parametros[1].SqlValue = Valor;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@SistemaSeparado";
            Parametros[2].SqlDbType = SqlDbType.Int;
            Parametros[2].SqlValue = Codigo;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@usuario";
            Parametros[3].SqlDbType = SqlDbType.Int;
            Parametros[3].SqlValue = usuario;

        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO SistemaSeparado (Fecha,Valor,AbonoInicial,PeriodoPago,Suministrar,NumCuotas,"+
                      " ValorCuota,FechaPrimerPago,FechaVence,Cliente,Estado)" +
                      " VALUES (@Fecha,@Valor,@AbonoInicial,@PeriodoPago,@Suministrar,@NumCuotas," +
                      " @ValorCuota,@FechaPrimerPago,@FechaVence,@Cliente,@Estado)";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_registrar_abono()
        {
            v_query = " INSERT INTO AbonoSistemaSeparado (Fecha,ValorAbono,SistemaSeparado,usuario)" +
                      " VALUES (@Fecha,@ValorAbono,@SistemaSeparado,@usuario)";

            mtd_asignaParametros_abonar();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            if (Modulo != "Venta")
            {
                if (v_ok == true)
                {
                    mtd_imprimir();
                }
            }
           
            return v_ok;
        }

        private void mtd_imprimir()
        {
            CrearTicket ticket = new CrearTicket();
            cls_empresa Empres = new cls_empresa();

            ticket.AbreCajon();//Para abrir el cajon de dinero.
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
            ticket.TextoIzquierda("--------------------------------------------");
            ticket.TextoIzquierda("CLIENTE: "+Cliente_separado);

            Codigo = Convert.ToInt32(Codigo);
            v_dt = mtd_consultar_abono_sistema();
            DataRow v_rows;
            if (v_dt.Rows.Count > 0)
            {
                v_rows = v_dt.Rows[0];
                double pago = Convert.ToDouble(v_rows["Pago"]);
                double Saldo_1 = 0;
                double Valortotal_1 = Convert.ToDouble(Valortotal);

                ticket.TextoIzquierda("VALOR : " + Valortotal_1.ToString("N0") + "");
                ticket.TextoIzquierda("VALOR ABONO : " + Valor.ToString("N0") + "");
                ticket.TextoIzquierda("TOTAL PAGADO: " + pago.ToString("N0") + "");
                double cuotas = Convert.ToDouble(v_rows["Cuotas"]) - 1;
                ticket.TextoIzquierda("CUOTA: " + cuotas + "");
                Saldo_1 = Valortotal_1 - pago;
                ticket.TextoIzquierda("SALDO: " + Saldo_1.ToString("N0") + "");
         
                //double Saldo = Convert.ToDouble(lbl_valor.Text) - pago; 
                //lbl_saldo.Text = Saldo.ToString("N0");
            }
            v_dt = mtd_consultar_abono_sistema_Documento_Factura();
            DataRow v_rows2;
            string NombDoc = "";
            string ConsecutivoDoc = "";
            if (v_dt.Rows.Count > 0)
            {
                v_rows2 = v_dt.Rows[0];
                NombDoc = v_rows2["NombreDocumento"].ToString();
                ConsecutivoDoc = v_rows2["ConsecutivoDocumento"].ToString();
            }
            //ticket.TextoIzquierda("USUARIO: " + Usuario);
            ///
            cls_venta cls_Venta = new cls_venta();
            DataTable DTVenta;
            cls_Venta.NombreDocumento = NombDoc;
            cls_Venta.ConsecutivoDocumento = ConsecutivoDoc;
            //DTVenta = cls_Venta.mtd_consultar_Ventas_factura();
            cls_Venta.v_buscar = NombDoc + '-' + ConsecutivoDoc;
            DTVenta = cls_Venta.mtd_consultar_dato_impresion();
            row = DTVenta.Rows[0];
            /////
            ticket.TextoIzquierda("FACTURA N. " + row["Factura"].ToString());
            //if (v_domicilio == false && v_sistema_separado == false)
            //{
            //    ticket.TextoIzquierda("CLIENTE: " + row["Cliente"].ToString() + "");
            //}
            ////ticket.TextoIzquierda("");
            ////ticket.lineasAsteriscos();

            //if (v_domicilio == true)
            //{
            //    ticket.TextoIzquierda("MENSAJERO: " + row["Mensajero"].ToString() + " " + row["NMensajero"].ToString());
            //    ticket.TextoIzquierda("# DOMICILIO: " + row["CodigoDomicilio"].ToString());
            //    ticket.TextoIzquierda("CELULAR: " + row["Celular"].ToString());
            //    ticket.TextoIzquierda("TELEFONO FIJO: " + row["Telefono"].ToString());
            //    ticket.TextoIzquierda("NOMBRES: " + row["NombreC"].ToString());
            //    ticket.TextoIzquierda("DIRECCION: " + row["Direccion"].ToString());
            //}


            ticket.lineasAsteriscos();

            double Subtotal = 0;
            double Impuesto = 0;
            double Descuento = 0;
            double TotalDescuento = 0;
            double Recibido = 0;
            double Devueltas = 0;
            double AritculosVendidos = 0;
            double Total = 0;
            double ValorDomicilio = 0;

            ////SISTEMA DE SEPARADOS
            //if (v_sistema_separado == true)
            //{
            //    ticket.TextoIzquierda("---------------------------");
            //    ticket.TextoIzquierda("INFO SISTEMA DE SEPARADO");
            //    ticket.TextoIzquierda("CLIENTE: " + clientes_1);
            //    ticket.TextoIzquierda("ABONO INICIAL: " + Abono_inicial_1);
            //    ticket.TextoIzquierda("# CUOTAS: " + num_cuotas_1);
            //    ticket.TextoIzquierda("VALOR CUOTAS: " + valor_cuotas_1);
            //    ticket.TextoIzquierda("VALOR : " + valor_1);
            //    double saldo = Convert.ToDouble(valor_1) - Convert.ToDouble(Abono_inicial_1);
            //    ticket.TextoIzquierda("SALDO: " + saldo.ToString("N"));
            //}

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
                // ticket.AgregarTotales("IVA %.........",  0);
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

            //if (v_domicilio == true)
            //{
            //    ticket.AgregarTotales("DOMICILIO.....$", ValorDomicilio);
            //}
            ticket.AgregarTotales("TOTAL.........$", Math.Round(Total));
            ////ticket.TextoIzquierda("--------------------------------------");
            //if (v_sistema_separado == false && v_domicilio == false)
            //{
            //    ticket.AgregarTotales("RECIBIDO......$", Recibido);
            //    ticket.AgregarTotales("CAMBIO........$", Devueltas);
            //}

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTICULOS: " + AritculosVendidos + "");
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


        public Boolean mtd_Editar()
        {
            DateTime fecha = DateTime.Now;
            v_query = " UPDATE SistemaSeparado SET FechaPago = '"+ fecha.ToString("yyyyMMdd") + "', Estado = '" + Estado + "' " +
                      " WHERE Codigo = " + Codigo;

           // mtd_asignaParametros();
            v_ok = cls_datos.mtd_ejecutar(v_query);

            if (v_ok == true)
            {
                //cambiar fecha factura
                fecha = DateTime.Now;
                v_query = " update Venta set Fecha = '" + fecha.ToString("yyyyMMdd") + "' " +
                          " WHERE SistemaSeparado = " + Codigo;
                v_ok = cls_datos.mtd_ejecutar(v_query);
            }
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "SELECT Codigo FROM Venta WHERE SistemaSeparado = '" + Codigo + "'";
            v_dt = cls_datos.mtd_consultar(v_query);

            v_query = "DELETE FROM SistemaSeparado WHERE Codigo = '" + Codigo + "'";
            v_ok = cls_datos.mtd_eliminar(v_query);

            //Eliminar Ventas separado de kardex
            if (v_ok == true)
            {
                foreach (DataRow rows in v_dt.Rows)
                {
                    v_query = "DELETE FROM Kardex WHERE CodigoVenta = '" + rows["Codigo"] + "'";
                    v_ok = cls_datos.mtd_eliminar(v_query);
                }
            }

            return v_ok;
        }
    }
}
