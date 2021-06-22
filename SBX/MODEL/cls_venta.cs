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
    public class cls_venta
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        SqlParameter[] Parametros;
        bool v_ok;
        public string Registro { get; set; }
        public string v_buscar { get; set; }
        public string v_tipo_busqueda { get; set; }
        public string Fecha_inicio { get; set; }
        public string Fecha_fin { get; set; }

        //getter and setter
        public int Codigo { get; set; }
        public int NumSeparado { get; set; }
        public int NumCredito { get; set; }
        public string Fecha { get; set; }
        public string NombreDocumento { get; set; }
        public string ConsecutivoDocumento { get; set; }
        public int Producto { get; set; }
        public string ModoVenta { get; set; }
        public string UM { get; set; }
        public float Cantidad { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public float Descuento { get; set; }
        public double Efectivo { get; set; }
        public double Tdebito { get; set; }
        public double Tcredito { get; set; }
        public string NumBaucherDebito { get; set; }
        public string NumBaucherCredito { get; set; }
        public double Cambio { get; set; }
        public double Total { get; set; }
        public string Proveedor { get; set; }
        public int Cliente { get; set; }
        public int Domicilio { get; set; }
        public int SistemaSeparado { get; set; }
        public int Credito { get; set; }
        public float IVA { get; set; }
        public string Usuario { get; set; }
        public string DescuentoProveedor { get; set; }
        public string Nota { get; set; }
        public string sucursal { get; set; }

        public string fact_Codigo { get; set; }
        public string fact_Fecha { get; set; }
        public string fact_Factura { get; set; }
        public string fact_Item { get; set; }
        public string fact_Nombre { get; set; }
        public string fact_Referencia { get; set; }
        public string fact_CodigoBarras { get; set; }
        public string fact_ModoVenta { get; set; }
        public string fact_UM { get; set; }
        public string fact_Cantidad { get; set; }
        public string fact_Cantidad_Exacta { get; set; }
        public string fact_Costo { get; set; }
        public string fact_Costo2 { get; set; }
        public string fact_PrecioVenta2 { get; set; }
        public string fact_PrecioVenta { get; set; }
        public string fact_descuento { get; set; }
        public string fact_ValorDescuento { get; set; }
        public string fact_Tdebito { get; set; }
        public string fact_NumBaucherDebito { get; set; }
        public string fact_Tcredito { get; set; }
        public string fact_NumBaucherCredito { get; set; }
        public string fact_Total { get; set; }
        public string fact_Efectivo { get; set; }
        public string fact_Cambio { get; set; }
        public string fact_Cliente { get; set; }
        public string fact_Sucursal { get; set; }
        public string fact_Domicilio { get; set; }
        public string fact_Usuario { get; set; }
        public string fact_CodigoDomicilio { get; set; }
        public string fact_Mensajero { get; set; }
        public string fact_Celular { get; set; }
        public string fact_Telefono { get; set; }
        public string fact_NombreC { get; set; }
        public string fact_Direccion { get; set; }
        public string fact_NMensajero { get; set; }
        public string fact_ValorDomicilio { get; set; }
        public string fact_DNI_emp { get; set; }
        public string fact_Nombre_emp { get; set; }
        public string fact_Telefono_emp { get; set; }
        public string fact_Celular_emp { get; set; }
        public string fact_Direccion_emp { get; set; }
        public string fact_Email_emp { get; set; }
        public string fact_SitioWeb_emp { get; set; }
        public byte[] fact_Foto_emp { get; set; }
        public string fact_Ciudad_emp { get; set; }
        public string fact_dni_cli { get; set; }
        public string fact_nombre_cli { get; set; }
        public string fact_ciudad_cli { get; set; }
        public string fact_telefono_cli { get; set; }
        public string fact_celular_cli { get; set; }
        public string fact_direccion_cli { get; set; }
        public string fact_email_cli { get; set; }
        public string fact_sitioweb_cli { get; set; }
        //Metodos
        public DataTable mtd_consultar_Venta()
        {
            v_query = " EXECUTE SP_BUSCAR_VENTAS  '" + v_tipo_busqueda + "','" + Fecha_inicio + "','" + Fecha_fin + "','" + v_buscar + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_Venta_Ultima_venta()
        {
            v_query = " SELECT Codigo FROM Venta WHERE Codigo = (SELECT MAX(Codigo) FROM Venta WHERE Usuario = "+ Usuario + ") ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_Ventas_factura()
        {
            v_query = " SELECT "+
                        "v.Fecha,v.NombreDocumento,v.ConsecutivoDocumento,CONCAT(c.DNI, ' - ', c.Nombre) ClienteVenta,d.Codigo CodigoDomicilio, "+
                        "d.Cliente ClienteDomicilio, d.Celular,d.Nombre NombreC, d.Direccion,d.Telefono,d.Mensajero,ISNULL(d.ValorDomicilio,0) ValorDomicilio, " +
                        "p.Item, p.Nombre,v.UM,v.PrecioVenta,v.Cantidad,v.descuento,V.IVA,V.Efectivo,V.Tdebito,V.Tcredito,V.Cambio,v.Total, " +
                        "m.Codigo Mensajero, m.Nombre NMensajero,p.SubCantidad,p.Sobres,v.ModoVenta,v.Nota " +
                        "FROM " +
                        "Venta v " +
                        "LEFT JOIN Domicilio d ON v.Domicilio = d.Codigo " +
                        "INNER JOIN Cliente c ON c.Codigo = v.Cliente " +
                        "INNER JOIN Producto p ON p.Item = v.Producto " +
                        "LEFT JOIN Mensajero m ON m.DNI = d.Mensajero  "+
                        "WHERE NombreDocumento = '" +NombreDocumento+"' AND ConsecutivoDocumento = '"+ConsecutivoDocumento+"'  ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_Ventas_factura_pdf()
        {
            v_query = " SELECT " +
                        "v.Fecha,v.NombreDocumento,v.ConsecutivoDocumento,CONCAT(c.DNI, ' - ', c.Nombre) ClienteVenta,d.Codigo CodigoDomicilio, " +
                        "d.Cliente ClienteDomicilio, d.Celular,d.Nombre NombreC, d.Direccion,d.Telefono,d.Mensajero,ISNULL(d.ValorDomicilio,0) ValorDomicilio, " +
                        "p.Item, p.Nombre,v.UM,v.PrecioVenta,v.Cantidad,v.descuento,V.IVA,V.Efectivo,V.Tdebito,V.Tcredito,V.Cambio,v.Total, " +
                        "m.Codigo Mensajero, m.Nombre NMensajero,p.SubCantidad,p.Sobres,v.ModoVenta,v.Nota " +
                        "FROM " +
                        "Venta v " +
                        "LEFT JOIN Domicilio d ON v.Domicilio = d.Codigo " +
                        "INNER JOIN Cliente c ON c.Codigo = v.Cliente " +
                        "INNER JOIN Producto p ON p.Item = v.Producto " +
                        "LEFT JOIN Mensajero m ON m.DNI = d.Mensajero  " +
                        "WHERE NombreDocumento = '" + NombreDocumento + "' AND ConsecutivoDocumento = '" + ConsecutivoDocumento + "'  ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[28];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Codigo";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = Codigo;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Fecha";
            Parametros[1].SqlDbType = SqlDbType.DateTime;
            Parametros[1].SqlValue = DateTime.Now;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@NombreDocumento";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = NombreDocumento;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@ConsecutivoDocumento";
            Parametros[3].SqlDbType = SqlDbType.Float;
            Parametros[3].SqlValue = ConsecutivoDocumento;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Producto";
            Parametros[4].SqlDbType = SqlDbType.Int;
            Parametros[4].SqlValue = Producto;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@ModoVenta";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = ModoVenta;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@UM";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].SqlValue = UM;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@Cantidad";
            Parametros[7].SqlDbType = SqlDbType.Float;
            Parametros[7].SqlValue = Cantidad;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@Costo";
            Parametros[8].SqlDbType = SqlDbType.Money;
            Parametros[8].SqlValue = Costo;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@PrecioVenta";
            Parametros[9].SqlDbType = SqlDbType.Money;
            Parametros[9].SqlValue = PrecioVenta;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@Descuento";
            Parametros[10].SqlDbType = SqlDbType.Float;
            Parametros[10].SqlValue = Descuento;

            Parametros[11] = new SqlParameter();
            Parametros[11].ParameterName = "@Efectivo";
            Parametros[11].SqlDbType = SqlDbType.Money;
            Parametros[11].SqlValue = Efectivo;

            Parametros[12] = new SqlParameter();
            Parametros[12].ParameterName = "@Tdebito";
            Parametros[12].SqlDbType = SqlDbType.Money;
            Parametros[12].SqlValue = Tdebito;

            Parametros[13] = new SqlParameter();
            Parametros[13].ParameterName = "@Tcredito";
            Parametros[13].SqlDbType = SqlDbType.Money;
            Parametros[13].SqlValue = Tcredito;

            Parametros[14] = new SqlParameter();
            Parametros[14].ParameterName = "@NumBaucherDebito";
            Parametros[14].SqlDbType = SqlDbType.VarChar;
            Parametros[14].SqlValue = NumBaucherDebito;

            Parametros[15] = new SqlParameter();
            Parametros[15].ParameterName = "@NumBaucherCredito";
            Parametros[15].SqlDbType = SqlDbType.VarChar;
            Parametros[15].SqlValue = NumBaucherCredito;

            Parametros[16] = new SqlParameter();
            Parametros[16].ParameterName = "@Cambio";
            Parametros[16].SqlDbType = SqlDbType.Money;
            Parametros[16].SqlValue = Cambio;

            Parametros[17] = new SqlParameter();
            Parametros[17].ParameterName = "@Total";
            Parametros[17].SqlDbType = SqlDbType.Money;
            Parametros[17].SqlValue = Total;

            Parametros[18] = new SqlParameter();
            Parametros[18].ParameterName = "@Proveedor";
            Parametros[18].SqlDbType = SqlDbType.VarChar;
            Parametros[18].SqlValue = Proveedor;

            Parametros[19] = new SqlParameter();
            Parametros[19].ParameterName = "@Cliente";
            Parametros[19].SqlDbType = SqlDbType.Int;
            Parametros[19].SqlValue = Cliente;

            Parametros[20] = new SqlParameter();
            Parametros[20].ParameterName = "@Domicilio";
            Parametros[20].SqlDbType = SqlDbType.Int;
            Parametros[20].SqlValue = Domicilio;

            Parametros[21] = new SqlParameter();
            Parametros[21].ParameterName = "@SistemaSeparado";
            Parametros[21].SqlDbType = SqlDbType.Int;
            Parametros[21].SqlValue = SistemaSeparado;

            Parametros[22] = new SqlParameter();
            Parametros[22].ParameterName = "@IVA";
            Parametros[22].SqlDbType = SqlDbType.Float;
            Parametros[22].SqlValue = IVA;

            Parametros[23] = new SqlParameter();
            Parametros[23].ParameterName = "@Usuario";
            Parametros[23].SqlDbType = SqlDbType.Int;
            Parametros[23].SqlValue = Usuario;

            Parametros[24] = new SqlParameter();
            Parametros[24].ParameterName = "@DescuentoProveedor";
            Parametros[24].SqlDbType = SqlDbType.Float;
            Parametros[24].SqlValue = DescuentoProveedor;

            Parametros[25] = new SqlParameter();
            Parametros[25].ParameterName = "@Nota";
            Parametros[25].SqlDbType = SqlDbType.VarChar;
            Parametros[25].SqlValue = Nota;

            Parametros[26] = new SqlParameter();
            Parametros[26].ParameterName = "@Sucursal";
            Parametros[26].SqlDbType = SqlDbType.VarChar;
            Parametros[26].SqlValue = sucursal;

            Parametros[27] = new SqlParameter();
            Parametros[27].ParameterName = "@Credito";
            Parametros[27].SqlDbType = SqlDbType.Int;
            Parametros[27].SqlValue = Credito;
        }
        public Boolean mtd_registrar()
        {
            switch (Registro)
            {
                case "":
                    if (sucursal == "")
                    {
                        v_query = " INSERT INTO Venta (Fecha,NombreDocumento,ConsecutivoDocumento,Producto,ModoVenta,UM,Cantidad,Costo,PrecioVenta," +
                    " descuento,Efectivo,Tdebito,Tcredito,NumBaucherDebito,NumBaucherCredito,Cambio,Total,Proveedor,Cliente,IVA,Usuario,DescuentoProveedor,Nota)" +
                    " VALUES (@Fecha,@NombreDocumento,@ConsecutivoDocumento,@Producto,@ModoVenta,@UM,@Cantidad,@Costo,@PrecioVenta," +
                    " @descuento,@Efectivo,@Tdebito,@Tcredito,@NumBaucherDebito,@NumBaucherCredito,@Cambio,@Total,@Proveedor,@Cliente,@IVA,@Usuario,@DescuentoProveedor,@Nota)";
                    }
                    else
                    {
                        v_query = " INSERT INTO Venta (Fecha,NombreDocumento,ConsecutivoDocumento,Producto,ModoVenta,UM,Cantidad,Costo,PrecioVenta," +
                    " descuento,Efectivo,Tdebito,Tcredito,NumBaucherDebito,NumBaucherCredito,Cambio,Total,Proveedor,Cliente,IVA,Usuario,DescuentoProveedor,Nota,sucursal)" +
                    " VALUES (@Fecha,@NombreDocumento,@ConsecutivoDocumento,@Producto,@ModoVenta,@UM,@Cantidad,@Costo,@PrecioVenta," +
                    " @descuento,@Efectivo,@Tdebito,@Tcredito,@NumBaucherDebito,@NumBaucherCredito,@Cambio,@Total,@Proveedor,@Cliente,@IVA,@Usuario,@DescuentoProveedor,@Nota,@sucursal)";
                    }                  
                    break;
                case "Domicilio":
                    if (sucursal == "")
                    {
                        v_query = " INSERT INTO Venta (Fecha,NombreDocumento,ConsecutivoDocumento,Producto,ModoVenta,UM,Cantidad,Costo,PrecioVenta," +
                                         " descuento,Efectivo,Tdebito,Tcredito,NumBaucherDebito,NumBaucherCredito,Cambio,Total,Proveedor,Cliente,Domicilio,IVA,Usuario,DescuentoProveedor,Nota)" +
                                         " VALUES (@Fecha,@NombreDocumento,@ConsecutivoDocumento,@Producto,@ModoVenta,@UM,@Cantidad,@Costo,@PrecioVenta," +
                                         " @descuento,@Efectivo,@Tdebito,@Tcredito,@NumBaucherDebito,@NumBaucherCredito,@Cambio,@Total,@Proveedor,@Cliente,@Domicilio,@IVA,@Usuario,@DescuentoProveedor,@Nota)";
                    }
                    else
                    {
                        v_query = " INSERT INTO Venta (Fecha,NombreDocumento,ConsecutivoDocumento,Producto,ModoVenta,UM,Cantidad,Costo,PrecioVenta," +
                                  " descuento,Efectivo,Tdebito,Tcredito,NumBaucherDebito,NumBaucherCredito,Cambio,Total,Proveedor,Cliente,Domicilio,IVA,Usuario,DescuentoProveedor,Nota,sucursal)" +
                                  " VALUES (@Fecha,@NombreDocumento,@ConsecutivoDocumento,@Producto,@ModoVenta,@UM,@Cantidad,@Costo,@PrecioVenta," +
                                  " @descuento,@Efectivo,@Tdebito,@Tcredito,@NumBaucherDebito,@NumBaucherCredito,@Cambio,@Total,@Proveedor,@Cliente,@Domicilio,@IVA,@Usuario,@DescuentoProveedor,@Nota,@sucursal)";
                    }

                    break;
                case "SistemaSeparado":
                    //v_query = " INSERT INTO Venta (Fecha,NombreDocumento,ConsecutivoDocumento,Producto,ModoVenta,UM,Cantidad,Costo,PrecioVenta," +
                    // " descuento,Efectivo,Tdebito,Tcredito,NumBaucherDebito,NumBaucherCredito,Cambio,Total,Proveedor,Cliente,SistemaSeparado,IVA,Usuario,DescuentoProveedor,Nota)" +
                    // " VALUES (@Fecha,@NombreDocumento,@ConsecutivoDocumento,@Producto,@ModoVenta,@UM,@Cantidad,@Costo,@PrecioVenta," +
                    // " @descuento,@Efectivo,@Tdebito,@Tcredito,@NumBaucherDebito,@NumBaucherCredito,@Cambio,@Total,@Proveedor,@Cliente,@SistemaSeparado,@IVA,@Usuario,@DescuentoProveedor,@Nota)";
                    if (sucursal == "")
                    {
                        v_query = " INSERT INTO Venta (Fecha,NombreDocumento,ConsecutivoDocumento,Producto,ModoVenta,UM,Cantidad,Costo,PrecioVenta," +
                                         " descuento,Efectivo,Tdebito,Tcredito,NumBaucherDebito,NumBaucherCredito,Cambio,Total,Proveedor,Cliente,SistemaSeparado,IVA,Usuario,DescuentoProveedor,Nota)" +
                                         " VALUES (@Fecha,@NombreDocumento,@ConsecutivoDocumento,@Producto,@ModoVenta,@UM,@Cantidad,@Costo,@PrecioVenta," +
                                         " @descuento,@Efectivo,@Tdebito,@Tcredito,@NumBaucherDebito,@NumBaucherCredito,@Cambio,@Total,@Proveedor,@Cliente,@SistemaSeparado,@IVA,@Usuario,@DescuentoProveedor,@Nota)";
                    }
                    else
                    {
                        v_query = " INSERT INTO Venta (Fecha,NombreDocumento,ConsecutivoDocumento,Producto,ModoVenta,UM,Cantidad,Costo,PrecioVenta," +
                                  " descuento,Efectivo,Tdebito,Tcredito,NumBaucherDebito,NumBaucherCredito,Cambio,Total,Proveedor,Cliente,SistemaSeparado,IVA,Usuario,DescuentoProveedor,Nota,sucursal)" +
                                  " VALUES (@Fecha,@NombreDocumento,@ConsecutivoDocumento,@Producto,@ModoVenta,@UM,@Cantidad,@Costo,@PrecioVenta," +
                                  " @descuento,@Efectivo,@Tdebito,@Tcredito,@NumBaucherDebito,@NumBaucherCredito,@Cambio,@Total,@Proveedor,@Cliente,@SistemaSeparado,@IVA,@Usuario,@DescuentoProveedor,@Nota,@sucursal)";
                    }
                    break;
                case "Credito":
                    if (sucursal == "")
                    {
                        v_query = " INSERT INTO Venta (Fecha,NombreDocumento,ConsecutivoDocumento,Producto,ModoVenta,UM,Cantidad,Costo,PrecioVenta," +
                                         " descuento,Efectivo,Tdebito,Tcredito,NumBaucherDebito,NumBaucherCredito,Cambio,Total,Proveedor,Cliente,IVA,Usuario,DescuentoProveedor,Nota,Credito)" +
                                         " VALUES (@Fecha,@NombreDocumento,@ConsecutivoDocumento,@Producto,@ModoVenta,@UM,@Cantidad,@Costo,@PrecioVenta," +
                                         " @descuento,@Efectivo,@Tdebito,@Tcredito,@NumBaucherDebito,@NumBaucherCredito,@Cambio,@Total,@Proveedor,@Cliente,@IVA,@Usuario,@DescuentoProveedor,@Nota,@Credito)";
                    }
                    else
                    {
                        v_query = " INSERT INTO Venta (Fecha,NombreDocumento,ConsecutivoDocumento,Producto,ModoVenta,UM,Cantidad,Costo,PrecioVenta," +
                                  " descuento,Efectivo,Tdebito,Tcredito,NumBaucherDebito,NumBaucherCredito,Cambio,Total,Proveedor,Cliente,IVA,Usuario,DescuentoProveedor,Nota,Credito)" +
                                  " VALUES (@Fecha,@NombreDocumento,@ConsecutivoDocumento,@Producto,@ModoVenta,@UM,@Cantidad,@Costo,@PrecioVenta," +
                                  " @descuento,@Efectivo,@Tdebito,@Tcredito,@NumBaucherDebito,@NumBaucherCredito,@Cambio,@Total,@Proveedor,@Cliente,@IVA,@Usuario,@DescuentoProveedor,@Nota,@Credito)";
                    }
                    break;
            }
          
            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE Venta SET Fecha = @Fecha,NombreDocumento = @NombreDocumento,ConsecutivoDocumento = @ConsecutivoDocumento,Producto = @Producto, "+
                      " ModoVenta = @ModoVenta,UM = @UM,Cantidad = @Cantidad,Costo = @Costo,PrecioVenta = @PrecioVenta," +
                      " descuento = @descuento,Efectivo = @Efectivo,Tdebito = @Tdebito,Tcredito = @Tcredito,NumBaucherDebito = @NumBaucherDebito, "+
                      " NumBaucherCredito = @NumBaucherCredito,Cambio = @Cambio,Total = @Total,Proveedor = @Proveedor,Cliente = @Cliente,Domicilio = @Domicilio,SistemaSeparado = @SistemaSeparado, Nota = @Nota " +
                      " WHERE Codigo = " + Codigo;

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_editar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM Venta WHERE Codigo = '" + Codigo + "'";
            v_ok = cls_datos.mtd_eliminar(v_query);

            //Eliminar Ventas de kardex
            if (v_ok == true)
            {
               v_query = "DELETE FROM Kardex WHERE CodigoVenta = '" + Codigo + "'";
               v_ok = cls_datos.mtd_eliminar(v_query);
            }
            //Eliminar Abonos
            if (v_ok == true)
            {
                v_query = "DELETE FROM AbonoSistemaSeparado WHERE sistemaSeparado = " + NumSeparado + " ";
                v_ok = cls_datos.mtd_eliminar(v_query);
            }
            //Eliminar sistema separado
            if (v_ok == true)
            {
                v_query = "DELETE FROM SistemaSeparado WHERE Codigo = " + NumSeparado + "";
                v_ok = cls_datos.mtd_eliminar(v_query);
            }
            //Eliminar Abonos credito
            if (v_ok == true)
            {
                v_query = "DELETE FROM AbonoCredito WHERE Credito = " + NumCredito + " ";
                v_ok = cls_datos.mtd_eliminar(v_query);
            }
            //Eliminar Creditos
            if (v_ok == true)
            {
                v_query = "DELETE FROM Credito WHERE Codigo = " + NumCredito + "";
                v_ok = cls_datos.mtd_eliminar(v_query);
            }
            //Eliminar domicilios
            if (v_ok == true)
            {
                v_query = "DELETE FROM Domicilio WHERE Codigo = " + Domicilio + "";
                v_ok = cls_datos.mtd_eliminar(v_query);
            }

            return v_ok;
        }
        public DataTable mtd_consultar_dato_impresion()
        {
            v_query = " EXECUTE SP_BUSCAR_IMPRESION '" + v_buscar + "'  ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
    }
}
