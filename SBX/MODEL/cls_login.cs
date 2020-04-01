using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.DB;
using System.Data;

namespace SBX.MODEL
{
    public class cls_login
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";

        //getter and setter
        public int Codigo { get; set; }
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string FechaNacimiento { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
        public int Rol { get; set; }

        //Metodos
        public DataTable mtd_consultar_estado()
        {
            v_query = " EXECUTE sp_verificar_login  '"+NombreUsuario+"','"+Contrasena+"' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
    }
}
