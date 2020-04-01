using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.DB;

namespace SBX.MODEL
{
    public class cls_estado
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";

        //getter and setter
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        //Metodos
        public DataTable mtd_consultar_estado()
        {
            v_query = " EXECUTE sp_consultar_estado ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
    }
}
