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
    public class cls_caja
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        SqlParameter[] Parametros;
        bool v_ok;

        //getter and setter
        public int Codigo { get; set; }
        public double Valor { get; set; }
        public string TipoOperacion { get; set; }
        public string Usuario { get; set; }
        public string FechaRegistro { get; set; }
        public string Codigo_Ultimo_Cierre { get; set; }
        public string Codigo_Ultima_venta { get; set; }
        public string ModoBusqueda { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Codigo_cierre { get; set; }


        //Metodos
        public DataTable mtd_consultar_caja()
        {
            v_query = "SELECT TOP(1)* FROM Caja WHERE Usuario = "+Usuario+ " ORDER BY FechaRegistro DESC ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_caja_cierre()
        {
            v_query = "SELECT TOP(1)* FROM Caja WHERE Usuario = " + Usuario + " AND TipoOperacion = 'CIERRE' ORDER BY FechaRegistro DESC ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_todo_caja()
        {
            if (ModoBusqueda == "Contiene")
            {
                v_query = "SELECT c.*,u.NombreUsuario FROM Caja c " +
                    "INNER JOIN Usuario u ON u.Codigo = c.Usuario " +
                    "WHERE u.NombreUsuario LIKE '" + Usuario + "%' AND CONVERT(DATE,c.FechaRegistro) BETWEEN '" + FechaInicio + "' AND '" + FechaFin + "' " +
                    "ORDER BY c.FechaRegistro DESC ";
            }
            else
            {
                v_query = "SELECT c.*,u.NombreUsuario FROM Caja c " +
                    "INNER JOIN Usuario u ON u.Codigo = c.Usuario " +
                    "WHERE u.NombreUsuario = '" + Usuario + "' AND  CONVERT(DATE,c.FechaRegistro) BETWEEN '" + FechaInicio + "' AND '" + FechaFin + "' " +
                    "ORDER BY c.FechaRegistro DESC ";
            }
          
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_Existencia_Venta()
        {
            v_query = "SELECT COUNT(*) conteo FROM Caja WHERE Usuario = " + Usuario + " AND Codigo_ultima_venta ="+Codigo_Ultima_venta+" ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_conteo_domicilios_pendientes()
        {
            v_query = "SELECT COUNT(*) Conteo FROM Domicilio WHERE Estado = 'Pendiente'";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

        public DataTable mtd_consultar_caja_para_reporte()
        {
            v_query = "select * from Caja where codigo = "+ Codigo_cierre;
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[6];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Valor";
            Parametros[0].SqlDbType = SqlDbType.Money;
            Parametros[0].SqlValue = Valor;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Usuario";
            Parametros[1].SqlDbType = SqlDbType.Int;
            Parametros[1].SqlValue = Usuario;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Tipooperacion";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = TipoOperacion;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@FechaRegistro";
            Parametros[3].SqlDbType = SqlDbType.DateTime;
            Parametros[3].SqlValue = DateTime.Now;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Codigo_ultimo_cierre";
            Parametros[4].SqlDbType = SqlDbType.Int;
            Parametros[4].SqlValue = Codigo_Ultimo_Cierre;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Codigo_ultima_venta";
            Parametros[5].SqlDbType = SqlDbType.Int;
            Parametros[5].SqlValue = Codigo_Ultima_venta;
        }
        public bool mtd_registrar()
        {
            if (TipoOperacion == "CIERRE")
            {
                v_query = " INSERT INTO Caja (Valor,TipoOperacion,usuario,fechaRegistro,Codigo_ultimo_cierre,Codigo_ultima_venta,CodigoCaja) VALUES(@Valor,@Tipooperacion,@Usuario,@FechaRegistro,@Codigo_ultimo_cierre,@Codigo_ultima_venta,(SELECT ISNULL(MAX(CodigoCaja),0) CodigoCaja FROM Caja WHERE Usuario = @Usuario )) ";
            }
            else
            {
                v_query = " INSERT INTO Caja (Valor,TipoOperacion,usuario,fechaRegistro,Codigo_ultimo_cierre,Codigo_ultima_venta,CodigoCaja) VALUES(@Valor,@Tipooperacion,@Usuario,@FechaRegistro,@Codigo_ultimo_cierre,@Codigo_ultima_venta,(SELECT ISNULL(MAX(CodigoCaja),0)+1 CodigoCaja FROM Caja WHERE Usuario = @Usuario )) ";
            }
           
            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public DataTable mtd_consultar_caja_ultima_apertura()
        {
            v_query = "SELECT TOP(1)* FROM Caja WHERE Usuario = " + Usuario + " AND TipoOperacion = 'APERTURA' ORDER BY FechaRegistro DESC ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

        //Consultas ventas directas
        public DataTable mtd_consultar_total_venta_directa()
        {
            v_query = "EXEC SP_CALCULAR_INGRESOS '" + Codigo_Ultimo_Cierre + "','" + Codigo_Ultima_venta + "','" + Usuario + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        //Consultar Gastos
        public DataTable mtd_consultar_Gastos()
        {
            v_query = "SELECT ISNULL(SUM(Valor),0) Gastos FROM GastosM " +
                      "WHERE " +
                      "(FechaRegistro BETWEEN (SELECT c2.FechaRegistro FROM Caja c2 WHERE c2.Codigo = " + Codigo_Ultimo_Cierre + " AND c2.Usuario = " + Usuario + ") " +
                      "AND (SELECT v2.Fecha FROM Venta v2 WHERE v2.Codigo = " + Codigo_Ultima_venta + " AND v2.Usuario = " + Usuario + ")  AND Usuario = " + Usuario + ") ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

        public string CodigoCierre { get; set; }
        public string BaseCaja { get; set; }
        public string Ingresos { get; set; }
        public string Gastos { get; set; }
        public string CierreCaja { get; set; }
        public string ConteoDinero { get; set; }
        public string TotalDiferencia { get; set; }

        private void mtd_asignaParametros_Cierre_caja()
        {
            Parametros = new SqlParameter[7];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Codigo";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = CodigoCierre;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@BaseCaja";
            Parametros[1].SqlDbType = SqlDbType.Money;
            Parametros[1].SqlValue = BaseCaja;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Ingresos";
            Parametros[2].SqlDbType = SqlDbType.Money;
            Parametros[2].SqlValue = Ingresos;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Gastos";
            Parametros[3].SqlDbType = SqlDbType.Money;
            Parametros[3].SqlValue = Gastos;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@CierreCaja";
            Parametros[4].SqlDbType = SqlDbType.Money;
            Parametros[4].SqlValue = CierreCaja;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@ConteoDinero";
            Parametros[5].SqlDbType = SqlDbType.Money;
            Parametros[5].SqlValue = ConteoDinero;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@TotalDiferencia";
            Parametros[6].SqlDbType = SqlDbType.Money;
            Parametros[6].SqlValue = TotalDiferencia;
        }

        public bool mtd_registrar_Cierre()
        {           
            v_query = " INSERT INTO Cierre_Caja(Codigo,BaseCaja,Ingresos,Gastos,CierreCaja,ConteoDinero,TotalDiferencia) VALUES(@Codigo,@BaseCaja,@Ingresos,@Gastos,@CierreCaja,@ConteoDinero,@TotalDiferencia) ";

            mtd_asignaParametros_Cierre_caja();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }

        public DataTable mtd_consultar_Cierre_caja()
        {
            v_query = "SELECT * FROM cierre_caja WHERE Codigo = " + Codigo + " ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
    }
}
