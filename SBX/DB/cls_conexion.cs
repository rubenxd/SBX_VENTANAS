﻿using SBX.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.DB
{
    public class cls_conexion
    {
        //Variables
        SqlConnection v_cadenaCn;

        //Constructor
        public cls_conexion()
        {
            try
            {
                v_cadenaCn = new SqlConnection(mtd_obtenerConexion());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Metodos
        public static string mtd_obtenerConexion()
        {
            return Settings.Default.DB_SBXConnectionString;
        }
        public SqlConnection Cadenacn
        {
            get
            {
                return v_cadenaCn;
            }
        }
    }
}
