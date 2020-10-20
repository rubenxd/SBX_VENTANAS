using SBX.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.MODEL
{
    public class cls_parametros
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
        public string Buscar_automaticamente { get; set; }
        public string Datos_paginados { get; set; }
    
        public DataTable mtd_consultar_parametros()
        {
            v_query = " SELECT * FROM Parametros ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[2];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Buscar_automaticamente";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = Buscar_automaticamente;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Datos_paginados";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = Datos_paginados;
        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO Parametros (Buscar_automaticamente,Datos_paginados)" +
                      " VALUES (@Buscar_automaticamente,@Datos_paginados)";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE Parametros SET Buscar_automaticamente = @Buscar_automaticamente,Datos_paginados = @Datos_paginados ";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_editar(Parametros, v_query);
            return v_ok;
        }
    }
}
