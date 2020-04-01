﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.DB;
using System.Data.SqlClient;
using System.Data;

namespace SBX.MODEL
{
    public class cls_gastos
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

        //getter and setter
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //Metodos
        public DataTable mtd_consultar_gastos()
        {
            v_query = " SELECT * FROM Gastos ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[2];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Nombre";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = Nombre;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Descripcion";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = Descripcion;
        }
        public bool mtd_registrar()
        {
            v_query = " INSERT INTO Gastos VALUES(@Nombre,@Descripcion) ";
            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM Gastos WHERE Codigo = '" + Codigo + "'";
            v_ok = cls_datos.mtd_eliminar(v_query);
            return v_ok;
        }
    }
}
