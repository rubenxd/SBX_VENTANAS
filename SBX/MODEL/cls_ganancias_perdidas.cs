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

        public DataTable mtd_consultar()
        {
            v_query = " SP_GANACIAS_PERDIDAS '" + FechaIni+ "','" + FechaFin + "','" + TipoBusqueda + "','" + Buscar + "'  ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

    }
}
