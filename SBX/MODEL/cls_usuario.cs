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
    public class cls_usuario
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        public string v_tipo_busqueda { get; set; }
        public string Buscar { get; set; }
        bool v_ok;
        SqlParameter[] Parametros;

        public int Codigo { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaNC { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
        public string Rol { get; set; }

        public DataTable mtd_consultar_usuario()
        {
            if (v_tipo_busqueda == "Contiene")
            {
                v_query = " SELECT u.*,r.Nombre Nrol,dbo.fnLeeClave(u.Contrasena) dContrasena  FROM Usuario u INNER JOIN Rol r ON r.Codigo = u.Rol WHERE DNI LIKE '" + Buscar + "%' OR Nombre LIKE '" + Buscar + "%' OR NombreUsuario LIKE '" + Buscar + "%' ";
            }
            else
            {
                v_query = " SELECT u.*,r.Nombre Nrol,dbo.fnLeeClave(u.Contrasena) dContrasena  FROM Usuario u INNER JOIN Rol r ON r.Codigo = u.Rol WHERE DNI = '" + Buscar + "' OR Nombre = '" + Buscar + "' OR NombreUsuario = '" + Buscar + "' ";
            }
          
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_datos_usuario()
        {        
            v_query = " SELECT * FROM Usuario WHERE "+ v_tipo_busqueda+" = '"+Buscar+"'";       
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_permisos_usuario()
        {
            v_query = " SELECT NombreUsuario,u.Nombres,u.Apellidos,m.Nombre Modulo,p.Nombre Permiso FROM Rol_Modulo_Permiso RMP "+
                        "INNER JOIN Modulo_permiso MP ON RMP.Modulo_permiso = MP.Codigo "+
                        "INNER JOIN Modulo m ON m.codigo = MP.Modulo "+
                        "INNER JOIN Permiso p ON p.codigo = MP.Permiso "+
                        "INNER JOIN Usuario u ON u.Rol = RMP.Rol "+
                        "WHERE u.Codigo = " + Codigo + "";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_usuario_logeado()
        {
            v_query = " SELECT * FROM Usuario_logeado WHERE CodigoUsuario = "+Codigo;   
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[11];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@DNI";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = DNI;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Nombre";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = Nombre;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Apellido";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = Apellido;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Celular";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].SqlValue = Celular;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Telefono";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = Telefono;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Email";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = Email;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@FechaNacimiento";
            Parametros[6].SqlDbType = SqlDbType.Date;
            Parametros[6].SqlValue = FechaNC;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@Usuario";
            Parametros[7].SqlDbType = SqlDbType.VarChar;
            Parametros[7].SqlValue = Usuario;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@Contrasena";
            Parametros[8].SqlDbType = SqlDbType.VarChar;
            Parametros[8].SqlValue = Contrasena;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@Estado";
            Parametros[9].SqlDbType = SqlDbType.VarChar;
            Parametros[9].SqlValue = Estado;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@Rol";
            Parametros[10].SqlDbType = SqlDbType.VarChar;
            Parametros[10].SqlValue = Rol;

        }
        public bool mtd_registrar()
        {
            v_query = " INSERT INTO Usuario VALUES "+
                      "(@DNI, @Nombre,@Apellido,@Celular,@Telefono,@Email, @FechaNacimiento,@Usuario, ENCRYPTBYPASSPHRASE('password', @Contrasena), @Estado, (SELECT Codigo FROM Rol WHERE Nombre = @Rol )) ";
            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public bool mtd_registrar_user_logeado()
        {
            v_query = " INSERT INTO Usuario_logeado VALUES " +
                      "("+ Codigo + ",SYSDATETIME()) ";
            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public bool mtd_modificar()
        {
            v_query = " UPDATE Usuario SET " +
                      "DNI = @DNI, Nombres = @Nombre,Apellidos = @Apellido,Celular = @Celular,Telefono = @Telefono,Email = @Email, "+
                      "FechaNacimiento = @FechaNacimiento,NombreUsuario = @Usuario, Contrasena = ENCRYPTBYPASSPHRASE('password', @Contrasena), Estado = @Estado, " +
                      "Rol = (SELECT Codigo FROM Rol WHERE Nombre = @Rol )  WHERE Codigo = "+ Codigo;
            mtd_asignaParametros();
            v_ok = cls_datos.mtd_editar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM Usuario WHERE Codigo = '" + Codigo + "'";
            v_ok = cls_datos.mtd_eliminar(v_query);
            return v_ok;
        }
    }
}
