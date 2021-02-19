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
    public class cls_domicilio
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
        public string Fecha_inicio { get; set; }
        public string Fecha_fin { get; set; }

        //getter and setter
        public int Codigo { get; set; }
        public string Cliente { get; set; } 
        public string Nombre { get; set; } 
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; } 
        public DateTime Fecha { get; set; }
        public string Mensajero { get; set; }
        public double Valor_domicilio { get; set; }
        public string Estado { get; set; }
        public string codigoSu { get; set; }

        //Metodos
        public DataTable mtd_consultar_domicilio()
        {
            v_query = " EXECUTE sp_consultar_domicilio  '" + v_buscar + "','" + v_tipo_busqueda + "','" + Fecha_inicio + "','" + Fecha_fin + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[11];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Codigo";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = Codigo;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Cliente";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = Cliente;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Nombre";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = Nombre;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Fecha";
            Parametros[3].SqlDbType = SqlDbType.DateTime;
            Parametros[3].SqlValue = DateTime.Now;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Direccion";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = Direccion;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Telefono";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = Telefono;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@Celular";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].SqlValue = Celular;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@Mensajero";
            Parametros[7].SqlDbType = SqlDbType.Int;
            Parametros[7].SqlValue = Mensajero;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@ValorDomicilio";
            Parametros[8].SqlDbType = SqlDbType.Int;
            Parametros[8].SqlValue = Valor_domicilio;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@Estado";
            Parametros[9].SqlDbType = SqlDbType.VarChar;
            Parametros[9].SqlValue = Estado;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@sucursal";
            Parametros[10].SqlDbType = SqlDbType.VarChar;
            Parametros[10].SqlValue = codigoSu;
        }
        public Boolean mtd_registrar()
        {
           
           v_query = " INSERT INTO Domicilio (Cliente,Nombre,Direccion,Telefono,Celular,Mensajero,ValorDomicilio,Fecha,Estado,sucursal)" +
                      " VALUES (@Cliente,@Nombre,@Direccion,@Telefono,@Celular,@Mensajero,@ValorDomicilio,@Fecha,@Estado,@sucursal)";
            
            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE Domicilio SET Estado = 'Pago' "+
                      " WHERE Codigo = " + Codigo;

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_ejecutar(v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "SELECT Codigo FROM Venta WHERE Domicilio = '" + Codigo + "'";
            v_dt = cls_datos.mtd_consultar(v_query);

            v_query = "DELETE FROM Domicilio WHERE Codigo = '" + Codigo + "'";
            v_ok = cls_datos.mtd_eliminar(v_query);

            //Eliminar Ventas domicilio de kardex
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
