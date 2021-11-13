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
    public class cls_ganancias_perdidas
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        SqlParameter[] Parametros;
        bool v_ok;

        public string FechaIni { get; set; }
        public string FechaFin { get; set; }

        public string Buscar { get; set; }
        public string TipoBusqueda { get; set; }

        public string UltimoCierre { get; set; }
        public string UltimaVenta { get; set; }
        public string Usuario { get; set; }
        public string CodigoSeparado { get; set; }

        public DataTable mtd_consultar()
        {
            v_query = " SP_GANACIAS_PERDIDAS '" + FechaIni+ "','" + FechaFin + "','" + TipoBusqueda + "','" + Buscar + "','"+Usuario+"'  ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

        public DataTable mtd_consultar_Abonos_separados()
        {   
            v_query = "select sp.Codigo,ISNULL(SUM(ValorAbono),0)  ValorAbonos, " +
                        "(select SUM(costo) from Venta where SistemaSeparado = asp.SistemaSeparado) Costo, " +
                        "((select SUM(costo) from Venta where SistemaSeparado = asp.SistemaSeparado)-ISNULL(SUM(ValorAbono), 0)) " +
                        "Resta, " +
                        " (select ISNULL(SUM(ValorAbono),0) "+
                        "from AbonoSistemaSeparado asp "+
                        "inner "+
                        "join SistemaSeparado sp on sp.Codigo = asp.SistemaSeparado "+
                        "WHERE(CONVERT(date, asp.Fecha) <= '" + FechaFin + "') and asp.usuario = " + Usuario + " " +
                        ") AbonoTotalSegunfecha, sp.Estado " +
                        "from AbonoSistemaSeparado asp " +
                        "inner join SistemaSeparado sp on sp.Codigo = asp.SistemaSeparado " +
                        "WHERE(CONVERT(date, asp.Fecha) BETWEEN '" + FechaIni + "' AND  '" + FechaFin + "') and asp.usuario = " + Usuario + "" +
                        "GROUP BY sp.Codigo, asp.SistemaSeparado, sp.Estado ";

            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_Abonos_separados_Total()
        {
            //v_query = "select sp.Codigo,ISNULL(SUM(ValorAbono),0)  ValorAbonos from AbonoSistemaSeparado asp " +
            //          "inner join SistemaSeparado sp on sp.Codigo = asp.SistemaSeparado " +
            //          "WHERE(CONVERT(date, asp.Fecha) BETWEEN '" + FechaIni + "' AND  '" + FechaFin + "') " +
            //          " GROUP BY sp.Codigo ";

            v_query = "select sp.Codigo,ISNULL(SUM(ValorAbono),0)  ValorAbonos, " +
                        "(select isnull(sum(costo),0) from Venta where SistemaSeparado = asp.SistemaSeparado) Costo, " +
                        "isnull(((select sum(costo) from Venta where SistemaSeparado = asp.SistemaSeparado)-ISNULL(SUM(ValorAbono), 0)),0) " +
                        "Resta " +
                        "from AbonoSistemaSeparado asp " +
                        "inner join SistemaSeparado sp on sp.Codigo = asp.SistemaSeparado " +
                        "WHERE(CONVERT(date, asp.Fecha)  BETWEEN '20131123' AND  '" + FechaFin + "') and asp.usuario = " + Usuario + " " +
                        "GROUP BY sp.Codigo, asp.SistemaSeparado ";

            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_Abonos_credito()
        {
            v_query = "select sp.Codigo,ISNULL(SUM(ValorAbono),0)  ValorAbonos from AbonoCredito asp " +
                      "inner join Credito sp on sp.Codigo = asp.Credito " +
                      "WHERE(CONVERT(date, asp.Fecha) BETWEEN '" + FechaIni + "' AND  '" + FechaFin + "') " +
                      " GROUP BY sp.Codigo ";

            //v_query = " select ISNULL(SUM(ValorAbono),0) ValorAbonos from AbonoSistemaSeparado " +
            //          " WHERE(CONVERT(date,Fecha) BETWEEN '" + FechaIni + "' AND  '" + FechaFin + "') ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_Abonos_separados_pagos()
        {

            v_query = "select ISNULL(SUM(ValorAbono),0)  ValorAbonos from AbonoSistemaSeparado asp " +
                      "inner join SistemaSeparado sp on sp.Codigo = asp.SistemaSeparado " +
                      "WHERE   sp.Codigo = "+ CodigoSeparado +
                      " ";
            //v_query = " select ISNULL(SUM(ValorAbono),0) ValorAbonos from AbonoSistemaSeparado " +
            //          " WHERE(CONVERT(date,Fecha) BETWEEN '" + FechaIni + "' AND  '" + FechaFin + "') ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

    }
}
