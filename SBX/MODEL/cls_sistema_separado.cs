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
        public string Estado { get; set; }

        //Metodos
        public DataTable mtd_consultar_sistema_separado()
        {
            v_query = " EXECUTE sp_consultar_sistema_separado  '" + v_buscar + "','" + v_tipo_busqueda + "','" + Fecha_inicio.Date + "','" + Fecha_fin.Date + "' ";
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
        public DataTable mtd_consultar_pagos()
        {
            v_query = "SELECT SistemaSeparado,Fecha,ValorAbono FROM AbonoSistemaSeparado WHERE SistemaSeparado = " + Codigo;
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_Abonos()
        {
            v_query = "SELECT ISNULL(SUM(ValorAbono),0) VlrAbono FROM AbonoSistemaSeparado WHERE Fecha BETWEEN '" + Fecha_inicio + "' AND '" + Fecha_fin + "' ";
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
            Parametros = new SqlParameter[3];

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
            v_query = " INSERT INTO AbonoSistemaSeparado (Fecha,ValorAbono,SistemaSeparado)" +
                      " VALUES (@Fecha,@ValorAbono,@SistemaSeparado)";

            mtd_asignaParametros_abonar();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE SistemaSeparado SET Estado = '"+ Estado + "' " +
                      " WHERE Codigo = " + Codigo;

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_ejecutar(v_query);
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
