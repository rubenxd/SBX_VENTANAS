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
    public class cls_rol
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        public string v_tipo_busqueda { get; set; }
        public string buscar { get; set; }
        bool v_ok;
        SqlParameter[] Parametros;

        //getter and setter
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string DescripcionRol { get; set; }

        //Metodos
        public DataTable mtd_consultar_Rol()
        {
            if (v_tipo_busqueda == "Contiene")
            {
                v_query = " SELECT * FROM Rol WHERE Codigo LIKE '" + buscar + "%' OR Nombre LIKE '" + buscar + "%' ";
            }
            else
            {
                v_query = " SELECT * FROM Rol WHERE Codigo = CASE WHEN ISNUMERIC('" + buscar + "') = 1 THEN '" + buscar + "' ELSE 0 END OR Nombre = '" + buscar + "' ";
            }
            
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_Rol_todos()
        {
            v_query = " SELECT *,(SELECT MAX(Codigo) FROM Rol) + 1 Codigomax FROM Rol ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[3];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Codigo";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = Codigo;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Nombre";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = Nombre;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@DescripcionRol";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = DescripcionRol;
        }
        public bool mtd_registrar()
        {
            v_query = " INSERT INTO Rol VALUES(@Codigo,@Nombre,@DescripcionRol) ";
            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public bool mtd_editar()
        {
            v_query = " UPDATE Rol SET Nombre = @Nombre,DescripcionRol = @DescripcionRol WHERE Codigo = @Codigo";
            mtd_asignaParametros();
            v_ok = cls_datos.mtd_editar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM Rol WHERE Codigo = '" + Codigo + "'";
            v_ok = cls_datos.mtd_eliminar(v_query);
            return v_ok;
        }
    }
}
