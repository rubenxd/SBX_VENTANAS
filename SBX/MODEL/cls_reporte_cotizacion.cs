using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.DB;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace SBX.MODEL
{
    public class cls_reporte_cotizacion
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
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin { get; set; }

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

        public int NumeroCotizacion { get; set; }

        public string NombreProducto { get; set; }
        public string DNI { get; set; }
        public string NombreCliente { get; set; }
        public string NombreUsuario { get; set; }

        //Datos para reporte cotizacion
        public string rpt_Fecha { get; set; }
        public string rpt_Doc { get; set; }
        public string rpt_Conse { get; set; }
        public string rpt_Item { get; set; }
        public string rpt_Nombre { get; set; }
        public string rpt_Cantidad { get; set; }
        public string rpt_precioVenta { get; set; }
        public string rpt_Descuento { get; set; }
        public string rpt_Total { get; set; }
        public string rpt_dni { get; set; }
        public string rpt_Cliente { get; set; }
        public string rpt_Direccion { get; set; }
        public string rpt_Email { get; set; }
        public string rpt_Telefono { get; set; }
        public string rpt_Celular { get; set; }
        public string rpt_Usuario { get; set; }
        public string rpt_NombreUsuario { get; set; }
        public string rpt_Total2 { get; set; }
        public string rpt_Dni_empresa { get; set; }
        public string rpt_nombre_empresa { get; set; }
        public string rpt_telefono_emp { get; set; }
        public string rpt_celular_emp { get; set; }
        public string rpt_direccion_emp { get; set; }
        public string rpt_email_emp { get; set; }
        public string rpt_sitioweb_emp { get; set; }
        public byte[] Foto { get; set; }
        public cls_reporte_cotizacion() { }

        public DataTable mtd_consultar()
        {
            v_query = " SELECT " +
" CONVERT(Date,Fecha) Fecha,Doc,Conse,Item,Nombre,cantidad, " +
" PrecioVenta, " +
" Descuento, " +
" Total, " +
" DNI,Cliente, Direccion,Email,Telefono,Celular, Usuario,NombreUsuario " +
" ,Total2 , DNI_Empresa, Nombre_Empresa, " +
"  Telefono_emp,Celular_emp,Direccion_emp,Email_emp,SitioWeb_emp,Foto " +
" FROM(" +
" SELECT ctz.Fecha, ctz.NombreDocumento Doc, ctz.ConsecutivoDocumento Conse, pd.Item, pd.Nombre, " +
" ctz.cantidad, " +
" ctz.PrecioVenta " +
", ctz.PrecioVenta * (ctz.descuento / 100) Descuento, ctz.Total, " +
" ct.DNI, ct.Nombre Cliente,ct.Direccion,ct.Email,ct.Telefono,ct.Celular, ctz.Usuario, us.NombreUsuario, " +
" (ctz.PrecioVenta * ctz.cantidad) - (ctz.PrecioVenta * (ctz.descuento / 100)) Total2, " +
"  (Select DNI from Empresa) DNI_Empresa,(Select Nombre from Empresa) Nombre_Empresa, " +
" (Select Telefono from Empresa) Telefono_emp , (Select Celular from Empresa)  Celular_emp, (Select Direccion from Empresa) Direccion_emp," +
"  (Select Email from Empresa) Email_emp, (Select SitioWeb from Empresa) SitioWeb_emp, " +
"  (Select Foto from Empresa) Foto " +
" FROM cotizacion ctz " +
" inner join Producto pd on pd.Item = ctz.Producto " +
" inner join Cliente ct on ct.Codigo = ctz.Cliente " +
" inner join Usuario us on us.Codigo = ctz.Usuario " +
" )Q where CONVERT(date,Fecha) Between '" + Fecha_inicio.ToString("yyyyMMdd")+"' AND '"+Fecha_fin.ToString("yyyyMMdd")+ "' AND  Q.Conse like '" + v_buscar + "%' "; 
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

        public Boolean mtd_registrar()
        {
            switch (Registro)
            {
                case "":
                    if (sucursal == "")
                    {
                        v_query = " INSERT INTO cotizacion (Fecha,NombreDocumento,ConsecutivoDocumento,Producto,ModoVenta,UM,Cantidad,Costo,PrecioVenta," +
                    " descuento,Efectivo,Tdebito,Tcredito,NumBaucherDebito,NumBaucherCredito,Cambio,Total,Proveedor,Cliente,IVA,Usuario,DescuentoProveedor,Nota)" +
                    " VALUES (@Fecha,@NombreDocumento,@ConsecutivoDocumento,@Producto,@ModoVenta,@UM,@Cantidad,@Costo,@PrecioVenta," +
                    " @descuento,@Efectivo,@Tdebito,@Tcredito,@NumBaucherDebito,@NumBaucherCredito,@Cambio,@Total,@Proveedor,@Cliente,@IVA,@Usuario,@DescuentoProveedor,@Nota)";
                    }
                    else
                    {
                        v_query = " INSERT INTO cotizacion (Fecha,NombreDocumento,ConsecutivoDocumento,Producto,ModoVenta,UM,Cantidad,Costo,PrecioVenta," +
                    " descuento,Efectivo,Tdebito,Tcredito,NumBaucherDebito,NumBaucherCredito,Cambio,Total,Proveedor,Cliente,IVA,Usuario,DescuentoProveedor,Nota,sucursal)" +
                    " VALUES (@Fecha,@NombreDocumento,@ConsecutivoDocumento,@Producto,@ModoVenta,@UM,@Cantidad,@Costo,@PrecioVenta," +
                    " @descuento,@Efectivo,@Tdebito,@Tcredito,@NumBaucherDebito,@NumBaucherCredito,@Cambio,@Total,@Proveedor,@Cliente,@IVA,@Usuario,@DescuentoProveedor,@Nota,@sucursal)";
                    }
                    break;               
            }

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
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
    }
}
