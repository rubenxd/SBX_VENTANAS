using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.MODEL;
using SBX.DB;
using System.Data;
using System.Data.SqlClient;

namespace SBX.MODEL
{
    public class cls_rol_modulo_permiso
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        public string v_tipo_busqueda { get; set; }
        public string buscar { get; set; }
        public string Rol { get; set; }
        public string Modulo_Permiso { get; set; }
        bool v_ok;
        SqlParameter[] Parametros;

        public DataTable mtd_consultar_Rol_Modulo_permiso()
        {
            v_query = "SELECT mp.Codigo,m.codigo co_modulo,m.Nombre Modulo, p.codigo cod_permiso,p.Nombre Permiso  " +
                      "FROM Modulo_permiso mp " +
                      "INNER JOIN Modulo m ON m.codigo = mp.Modulo " +
                      "INNER JOIN Permiso p ON p.codigo = mp.Permiso " +
                      "ORDER BY Modulo ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_Rol_Modulo_permiso()
        {
            v_query = "SELECT * FROM Rol_Modulo_Permiso "+
                      "WHERE Rol = "+Rol;
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[2];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Rol";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = Rol;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Modulo_permiso";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = Modulo_Permiso;
        }
        public bool mtd_eliminar()
        {
            v_query = "DELETE FROM Rol_Modulo_Permiso WHERE Rol = " + Rol;
            v_ok = cls_datos.mtd_eliminar(v_query);
            return v_ok;
        }
        public bool mtd_registrar()
        {
                v_query = " INSERT INTO Rol_Modulo_Permiso VALUES(@Rol,@Modulo_permiso) ";
                mtd_asignaParametros();
                v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
    }
}
