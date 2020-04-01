using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.DB;

namespace SBX.MODEL
{
    public class cls_kardex
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_Datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        bool v_ok;
        public int Codigo { get; set; }
        public string v_buscar { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin { get; set; }
        public string Tipo_busqueda { get; set; }

        public DataTable mtd_consultar_movimientos()
        {
            v_query = " EXECUTE sp_consulta_kardex '" + v_buscar + "','" + Fecha_inicio.Date + "','" + Fecha_fin.Date + "','"+Tipo_busqueda+"' ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM Kardex WHERE Codigo = '" + Codigo + "'";
            v_ok = cls_Datos.mtd_eliminar(v_query);
            return v_ok;
        }
    }
}
