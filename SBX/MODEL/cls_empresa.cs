using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.DB;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace SBX.MODEL
{
    public class cls_empresa
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
        public int Codigo { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Sitioweb { get; set; }
        public string Licencia { get; set; }
        public string Impresora { get; set; }
        public Image Foto { get; set; }
        public float ConInicial { get; set; }
        public float ConFinal { get; set; }
        public string Detalle { get; set; }
        public int Alerta { get; set; }
        public string NomDoc { get; set; }
        public string tamano_papel { get; set; }
        public string NomDocCtz { get; set; }
        public string NomDocOrds { get; set; }

        //Metodos
        public DataTable mtd_consultar_Empresa()
        {
            v_query = " EXECUTE sp_consultar_empresa ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_Empresa_CTZ()
        {
            v_query = " EXECUTE sp_consultar_empresa_Ctz ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[20];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Codigo";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = Codigo;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@DNI";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = DNI;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Nombre";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = Nombre;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Ciudad";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].SqlValue = Ciudad;

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
            Parametros[7].ParameterName = "@Email";
            Parametros[7].SqlDbType = SqlDbType.VarChar;
            Parametros[7].SqlValue = Email;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@SitioWeb";
            Parametros[8].SqlDbType = SqlDbType.VarChar;
            Parametros[8].SqlValue = Sitioweb;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@Licencia";
            Parametros[9].SqlDbType = SqlDbType.VarChar;
            Parametros[9].SqlValue = Licencia;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@Impresora";
            Parametros[10].SqlDbType = SqlDbType.VarChar;
            Parametros[10].SqlValue = Impresora;

            // Asignando el valor de la imagen
            // Stream usado como buffer
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            // Se guarda la imagen en el buffer
            Foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            // Se extraen los bytes del buffer para asignarlos como valor para el 
            // parámetro.
            Parametros[11] = new SqlParameter();
            Parametros[11].ParameterName = "@Foto";
            Parametros[11].SqlDbType = SqlDbType.Image;
            Parametros[11].SqlValue = ms.GetBuffer();

            Parametros[12] = new SqlParameter();
            Parametros[12].ParameterName = "@ConInicial";
            Parametros[12].SqlDbType = SqlDbType.VarChar;
            Parametros[12].SqlValue = ConInicial;

            Parametros[13] = new SqlParameter();
            Parametros[13].ParameterName = "@ConFinal";
            Parametros[13].SqlDbType = SqlDbType.VarChar;
            Parametros[13].SqlValue = ConFinal;

            Parametros[14] = new SqlParameter();
            Parametros[14].ParameterName = "@Detalle";
            Parametros[14].SqlDbType = SqlDbType.VarChar;
            Parametros[14].SqlValue = Detalle;

            Parametros[15] = new SqlParameter();
            Parametros[15].ParameterName = "@Alerta";
            Parametros[15].SqlDbType = SqlDbType.Int;
            Parametros[15].SqlValue = Alerta;

            Parametros[16] = new SqlParameter();
            Parametros[16].ParameterName = "@NomDoc";
            Parametros[16].SqlDbType = SqlDbType.VarChar;
            Parametros[16].SqlValue = NomDoc;

            Parametros[17] = new SqlParameter();
            Parametros[17].ParameterName = "@Tamano_papel";
            Parametros[17].SqlDbType = SqlDbType.VarChar;
            Parametros[17].SqlValue = tamano_papel;

            Parametros[18] = new SqlParameter();
            Parametros[18].ParameterName = "@NomDocCtz";
            Parametros[18].SqlDbType = SqlDbType.VarChar;
            Parametros[18].SqlValue = NomDocCtz;

            Parametros[19] = new SqlParameter();
            Parametros[19].ParameterName = "@NomDocOrds";
            Parametros[19].SqlDbType = SqlDbType.VarChar;
            Parametros[19].SqlValue = NomDocOrds;
        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO Empresa (DNI,Nombre,Ciudad,Direccion,Telefono,Celular,Email,SitioWeb,licencia,"+
                      " Impresora,Foto,ConsecutivoInicial,ConsecutivoFinal,Detalle,Alerta,NomDoc,tamano_papel,NomDocCtz,NomDocOrds)" +
                      " VALUES (@DNI,@Nombre,@Ciudad,@Direccion,@Telefono,@Celular,@Email,@SitioWeb,@licencia " +
                      " @Impresora,@Foto,@ConInicial,@ConFinal,@Detalle,@Alerta,@NomDoc,@Tamano_papel,@NomDocCtz,@NomDocOrds)";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE Empresa SET DNI = @DNI,Nombre = @Nombre,Ciudad = @Ciudad,Direccion = @Direccion,  " +
                      " Telefono = @Telefono,Celular = @Celular,Email = @Email,SitioWeb = @SitioWeb,Licencia = @Licencia, " +
                      " Impresora = @Impresora,Foto = @Foto,ConsecutivoInicial = @ConInicial, " +
                      " ConsecutivoFinal = @ConFinal,Detalle = @Detalle,Alerta = @Alerta,NomDoc = @NomDoc," +
                      " tamano_papel = @Tamano_papel, NomDocCtz = @NomDocCtz, NomDocOrds = @NomDocOrds " +
                      " WHERE Codigo = " + Codigo;

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_editar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM Empresa WHERE Codigo = '" + Codigo + "'";
            v_ok = cls_datos.mtd_eliminar(v_query);
            return v_ok;
        }
    }
}
