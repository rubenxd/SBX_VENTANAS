using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.DB;
using System.Data.SqlClient;
using System.Data;

namespace SBX.MODEL
{
    public class cls_gastos_m
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        public string v_tipo_busqueda { get; set; }
        bool v_ok;
        SqlParameter[] Parametros;
        public string Buscar { get; set; }

        //getter and setter
        public int Codigo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public double Valor { get; set; }
        public int Gasto { get; set; }
        public string FechaIni { get; set; }
        public string Fechafin { get; set; }
        public string proveedor { get; set; }
        public string Valor_iva { get; set; }
        public string usuario { get; set; }

        //Metodos
        public DataTable mtd_consultar_gastos()
        {
            v_query = " SELECT gm.codigo,g.Nombre Gasto,gm.FechaRegistro,gm.Valor,gm.proveedor,ISNULL(gm.ValorIva,0) ValorIva FROM gastosm gm INNER JOIN Gastos g ON g.Codigo = gm.Gasto " +
                " WHERE g.Nombre LIKE '"+ Buscar + "%' AND CONVERT(date,FechaRegistro) BETWEEN '"+FechaIni+ "' AND '" + Fechafin + "' AND gm.usuario = '"+usuario+"' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[6];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Fecha";
            Parametros[0].SqlDbType = SqlDbType.DateTime;
            Parametros[0].SqlValue = DateTime.Now;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Gasto";
            Parametros[1].SqlDbType = SqlDbType.Int;
            Parametros[1].SqlValue = Gasto;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Valor";
            Parametros[2].SqlDbType = SqlDbType.Money;
            Parametros[2].SqlValue = Valor;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Valor_iva";
            Parametros[3].SqlDbType = SqlDbType.Money;
            Parametros[3].SqlValue = Valor_iva;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@proveedor";
            Parametros[4].SqlDbType = SqlDbType.Money;
            Parametros[4].SqlValue = proveedor;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@usuario";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = usuario;
        }
        public bool mtd_registrar()
        {
            v_query = " INSERT INTO gastosm VALUES(@Fecha,@Gasto,@Valor,@proveedor,@Valor_iva,@usuario) ";
            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM gastosm WHERE Codigo = '" + Codigo + "'";
            v_ok = cls_datos.mtd_eliminar(v_query);
            return v_ok;
        }
    }
}
