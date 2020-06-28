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
    public class cls_sucursal
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

        //getter and setter
        public int Codigo { get; set; }    
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Sitioweb { get; set; }
        public string CodigoCliente { get; set; }

        //Metodos
        public DataTable mtd_consultar_sucursal()
        {
            v_query = " EXECUTE sp_consultar_sucursal  '" + v_buscar + "','" + v_tipo_busqueda + "'";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_sucursal_por_Cliente()
        {
            v_query = " SELECT * FROM  Sucursal WHERE Cliente = " + CodigoCliente + "";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_sucursal_exacta()
        {
            v_query = " SELECT * FROM  Sucursal WHERE Codigo = " + Codigo + "";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[9];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Codigo";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = Codigo;
          
            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Nombre";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = Nombre;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Ciudad";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = Ciudad;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Direccion";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].SqlValue = Direccion;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Telefono";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = Telefono;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Celular";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = Celular;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@Email";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].SqlValue = Email;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@SitioWeb";
            Parametros[7].SqlDbType = SqlDbType.VarChar;
            Parametros[7].SqlValue = Sitioweb;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@Cliente";
            Parametros[8].SqlDbType = SqlDbType.Int;
            Parametros[8].SqlValue = CodigoCliente;
        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO sucursal (Nombre,Ciudad,Direccion,Telefono,Celular,Email,SitioWeb,Cliente)" +
                      " VALUES (@Nombre,@Ciudad,@Direccion,@Telefono,@Celular,@Email,@SitioWeb,@Cliente)";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);        
            return v_ok;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE sucursal SET Nombre = @Nombre,Ciudad = @Ciudad,Direccion = @Direccion,  " +
                      " Telefono = @Telefono,Celular = @Celular,Email = @Email,SitioWeb = @SitioWeb " +
                      " WHERE Codigo = " + Codigo;

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_editar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM sucursal WHERE Codigo = '" + Codigo + "'";
            v_ok = cls_datos.mtd_eliminar(v_query);
            return v_ok;
        }
    }
}
