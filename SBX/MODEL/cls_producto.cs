using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.DB;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace SBX.MODEL
{
    public class cls_producto
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_Datos = new cls_datos();
        SqlParameter[] Parametros;
        cls_global cl_Global = new cls_global();

        //Variables
        DataTable v_dt;
        string v_query = "";
        public string v_tipo_busqueda { get; set; }
        public string v_buscar { get; set; }
        public string v_data_busqueda { get; set; }
        bool v_ok;

        //getter and setter
        public string Item { get; set; }
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float IVA { get; set; }
        public int UnidadMedida { get; set; }
        public float Medida { get; set; }
        public int Estado { get; set; }
        public int Categoria { get; set; }
        public int Marca { get; set; }
        public string Proveedor { get; set; }
        public string ModoVenta { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Ubicacion { get; set; }
        public int SalidaPara { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public string CodigoBarras { get; set; }
        public float SubCantidad { get; set; }
        public double ValorSubcantidad { get; set; }
        public int Sobres { get; set; }
        public double ValorSobres { get; set; }
        public Image Foto { get; set; }
        public int Usuario { get; set; }
        public string movimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string descuento_proveedor { get; set; }
        public string FechaVencimiento { get; set; }

        public double Costo_productoCalculado { get; set; }
        public string Nota { get; set; }
        public string Cotizacion { get; set; }

        //Metodos
        public DataTable mtd_consultar_caracteristicas_producto()
        {
            v_query = " EXECUTE sp_consultar_caracteristicas_producto ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_stock_producto()
        {
            v_query = " EXECUTE sp_consulta_stock_items " + Item + " ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_producto()
        {
            v_query = " EXECUTE sp_consultar_producto '" + v_tipo_busqueda + "','" + v_buscar + "','" + Item + "','" + Referencia + "','" + CodigoBarras + "','" + v_data_busqueda + "' ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_producto_pruebas()
        {
            v_query = " EXECUTE sp_consultar_producto '" + v_tipo_busqueda + "','" + v_buscar + "','" + Item + "','" + Referencia + "','" + CodigoBarras + "','"+ v_data_busqueda + "' ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        
        public DataTable mtd_consultar_producto_Paginado()
        {
            DataSet ds = new DataSet();
            Paginar p;
            int maximo_x_pagina = 15;//cargar por default
            p = new Paginar("EXECUTE sp_consultar_producto '" + v_tipo_busqueda + "','" + v_buscar + "','" + Item + "','" + Referencia + "','" + CodigoBarras + "' ", "DataMember1", maximo_x_pagina);
            ds = p.cargar();
            v_dt = ds.Tables[0];
            return v_dt;
        }          
        public DataTable mtd_consultar_producto_kardex()
        {
            v_query = " EXECUTE SP_CONSULTA_ESTADO_PRODUCTOS_ESTADO_STOCKS '" + v_buscar + "','" + v_tipo_busqueda + "','"+v_data_busqueda+"' ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_estado_fechas_vencimiento()
        {
            v_query = " EXECUTE sp_estado_fecha_vencimiento  '"+v_buscar+ "','" + v_tipo_busqueda + "'";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_pro_mas_vendido(DateTime FechaInicio,DateTime FechaFin)
        {
           
            if (v_tipo_busqueda == "Contiene")
            {
                if (v_buscar != "")
                {
                    v_query = "SELECT P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,ISNULL(SUM(v.Cantidad),0) Cantidad_global, " +
                                       "CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END UND_UM " +
                                       "FROM Venta v " +
                                       "INNER JOIN Producto p on v.Producto = p.Item " +
                                        "WHERE p.Item LIKE '" + v_buscar + "%' AND (CONVERT(date,v.Fecha) BETWEEN '" + FechaInicio + "' AND '" + FechaFin + "') " +
                                       "GROUP BY P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,p.SubCantidad " +
                                       "ORDER BY CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END DESC";
                                  
                    v_dt = cls_Datos.mtd_consultar(v_query);
                    if (v_dt.Rows.Count == 0)
                    {
                        v_query = "SELECT P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,ISNULL(SUM(v.Cantidad),0) Cantidad_global, " +
                                       "CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END UND_UM " +
                                       "FROM Venta v " +
                                       "INNER JOIN Producto p on v.Producto = p.Item " +
                                        "WHERE p.CodigoBarras LIKE '" + v_buscar + "%'  AND (CONVERT(date,v.Fecha) BETWEEN '" + FechaInicio + "' AND '" + FechaFin + "') " +
                                       "GROUP BY P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,p.SubCantidad " +
                                       "ORDER BY CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END DESC";
                     
                        v_dt = cls_Datos.mtd_consultar(v_query);
                        if (v_dt.Rows.Count == 0)
                        {
                            v_query = "SELECT P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,ISNULL(SUM(v.Cantidad),0) Cantidad_global, " +
                                        "CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END UND_UM " +
                                        "FROM Venta v " +
                                        "INNER JOIN Producto p on v.Producto = p.Item " +
                                        "WHERE p.Nombre LIKE '" + v_buscar + "%'  AND (CONVERT(date,v.Fecha) BETWEEN '" + FechaInicio + "' AND '" + FechaFin + "') " +
                                        "GROUP BY P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,p.SubCantidad " +
                                        "ORDER BY CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END DESC";
                                               
                            v_dt = cls_Datos.mtd_consultar(v_query);
                        }
                    }
                }
                else
                {
                    v_query = "SELECT P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,ISNULL(SUM(v.Cantidad),0) Cantidad_global, " +
                    "CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END UND_UM " +
                    "FROM Venta v " +
                    "INNER JOIN Producto p on v.Producto = p.Item " +
                    "WHERE CONVERT(date,v.Fecha) BETWEEN '" + FechaInicio + "' AND '" + FechaFin + "'  " +
                    "GROUP BY P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,p.SubCantidad " +
                    "ORDER BY CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END DESC";
                    
                    v_dt = cls_Datos.mtd_consultar(v_query);
                }    
            }
            else
            {
                if (v_buscar != "")
                {
                    if (cl_Global.IsNumericDouble(v_buscar))
                    {
                        v_query = "SELECT P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,ISNULL(SUM(v.Cantidad),0) Cantidad_global, " +
                   "CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END UND_UM " +
                   "FROM Venta v " +
                   "INNER JOIN Producto p on v.Producto = p.Item " +
                  "WHERE p.Item = '" + v_buscar + "' AND (CONVERT(date,v.Fecha) BETWEEN '" + FechaInicio + "' AND '" + FechaFin + "') " +
                   "GROUP BY P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,p.SubCantidad " +
                   "ORDER BY CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END DESC";
                                              
                    }
                    else
                    {
                        v_query = "SELECT P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,ISNULL(SUM(v.Cantidad),0) Cantidad_global, " +
                   "CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END UND_UM " +
                   "FROM Venta v " +
                   "INNER JOIN Producto p on v.Producto = p.Item " +
                  "WHERE p.Item = 0 AND (CONVERT(date,v.Fecha) BETWEEN '" + FechaInicio + "' AND '" + FechaFin + "')" +
                   "GROUP BY P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,p.SubCantidad " +
                   "ORDER BY CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END DESC";
                       
                    }
                   
                    v_dt = cls_Datos.mtd_consultar(v_query);
                    if (v_dt.Rows.Count == 0)
                    {
                        v_query = "SELECT P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,ISNULL(SUM(v.Cantidad),0) Cantidad_global, " +
                 "CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END UND_UM " +
                 "FROM Venta v " +
                 "INNER JOIN Producto p on v.Producto = p.Item " +
                 "WHERE p.CodigoBarras = '" + v_buscar + "' AND (CONVERT(date,v.Fecha) BETWEEN '" + FechaInicio+ "' AND '" + FechaFin + "') " +
                 "GROUP BY P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,p.SubCantidad " +
                 "ORDER BY CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END DESC";
                       
                        v_dt = cls_Datos.mtd_consultar(v_query);
                        if (v_dt.Rows.Count == 0)
                        {
                            v_query = "SELECT P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,ISNULL(SUM(v.Cantidad),0) Cantidad_global, " +
                 "CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END UND_UM " +
                 "FROM Venta v " +
                 "INNER JOIN Producto p on v.Producto = p.Item " +
                "WHERE p.Nombre = '" + v_buscar + "' AND (CONVERT(date,v.Fecha) BETWEEN '" + FechaInicio + "' AND '" + FechaFin + "') " +
                 "GROUP BY P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,p.SubCantidad " +
                 "ORDER BY CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END DESC";
                          
                            v_dt = cls_Datos.mtd_consultar(v_query);
                        }
                    }
                }
                else
                {
                    v_query = "SELECT P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,ISNULL(SUM(v.Cantidad),0) Cantidad_global, " +
                "CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END UND_UM " +
                "FROM Venta v " +
                "INNER JOIN Producto p on v.Producto = p.Item " +
              "WHERE CONVERT(date,v.Fecha) BETWEEN '" + FechaInicio + "' AND '" + FechaFin + "' " +
                "GROUP BY P.Item,p.Nombre,v.PrecioVenta,v.ModoVenta,UM,p.SubCantidad " +
                "ORDER BY CASE WHEN p.SubCantidad != 0 THEN ROUND(SUM(v.Cantidad) * p.SubCantidad,0) ELSE SUM(v.Cantidad) END DESC";
                   
                    v_dt = cls_Datos.mtd_consultar(v_query);
                }       
            }
                
            return v_dt;
        }

        public DataTable mtd_consultar_producto_mas_vendido_sp(string FechaInicio, string FechaFin) 
        {
            v_query = " EXECUTE sp_calcular_producto_mas_vendido '" + FechaInicio + "','" + FechaFin + "','" + v_tipo_busqueda + "','" + v_buscar + "' ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_fechas_vecimiento()
        {
            v_query = " SELECT * FROM FechasVencimiento WHERE Item = "+Item;
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_Fechas_vence()
        {
            v_query = " EXECUTE SP_PRODUCTOS_FECHA_VENCIMIENTO '" + v_buscar + "' ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_producto_stocks()
        {
            v_query = " EXECUTE SP_STOCK_PRODUCTOS '" + v_buscar + "' ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[32];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Nombre";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = Nombre;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Descripcion";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = Descripcion;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Item";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = string.Format("{0:0000}",Item);

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Referencia";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].SqlValue = Referencia;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@CodigoBarras";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = CodigoBarras;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@IVA";
            Parametros[5].SqlDbType = SqlDbType.Float;
            Parametros[5].SqlValue = IVA;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@UnidadMedida";
            Parametros[6].SqlDbType = SqlDbType.Int;
            Parametros[6].SqlValue = UnidadMedida;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@Medida";
            Parametros[7].SqlDbType = SqlDbType.Float;
            Parametros[7].SqlValue = Medida;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@Estado";
            Parametros[8].SqlDbType = SqlDbType.Int;
            Parametros[8].SqlValue = Estado;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@Categoria";
            Parametros[9].SqlDbType = SqlDbType.Int;
            Parametros[9].SqlValue = Categoria;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@Marca";
            Parametros[10].SqlDbType = SqlDbType.Int;
            Parametros[10].SqlValue = Marca;

            Parametros[11] = new SqlParameter();
            Parametros[11].ParameterName = "@Proveedor";
            Parametros[11].SqlDbType = SqlDbType.VarChar;
            Parametros[11].SqlValue = Proveedor;

            Parametros[12] = new SqlParameter();
            Parametros[12].ParameterName = "@ModoVenta";
            Parametros[12].SqlDbType = SqlDbType.VarChar;
            Parametros[12].SqlValue = ModoVenta;

            Parametros[13] = new SqlParameter();
            Parametros[13].ParameterName = "@Costo";
            Parametros[13].SqlDbType = SqlDbType.Money;
            Parametros[13].SqlValue = Costo;

            Parametros[14] = new SqlParameter();
            Parametros[14].ParameterName = "@PrecioVenta";
            Parametros[14].SqlDbType = SqlDbType.Money;
            Parametros[14].SqlValue = PrecioVenta;

            Parametros[15] = new SqlParameter();
            Parametros[15].ParameterName = "@Ubicacion";
            Parametros[15].SqlDbType = SqlDbType.Int;
            Parametros[15].SqlValue = Ubicacion;

            Parametros[16] = new SqlParameter();
            Parametros[16].ParameterName = "@Salida_para";
            Parametros[16].SqlDbType = SqlDbType.Int;
            Parametros[16].SqlValue = SalidaPara;

            Parametros[17] = new SqlParameter();
            Parametros[17].ParameterName = "@Stock_minimo";
            Parametros[17].SqlDbType = SqlDbType.Int;
            Parametros[17].SqlValue = StockMinimo;

            Parametros[18] = new SqlParameter();
            Parametros[18].ParameterName = "@Stock_maximo";
            Parametros[18].SqlDbType = SqlDbType.Int;
            Parametros[18].SqlValue = StockMaximo;

            Parametros[19] = new SqlParameter();
            Parametros[19].ParameterName = "@Cantidad";
            Parametros[19].SqlDbType = SqlDbType.Decimal;
            Parametros[19].SqlValue = Cantidad;

            Parametros[20] = new SqlParameter();
            Parametros[20].ParameterName = "@Subcantidad";
            Parametros[20].SqlDbType = SqlDbType.Float;
            Parametros[20].SqlValue = SubCantidad;

            Parametros[21] = new SqlParameter();
            Parametros[21].ParameterName = "@ValorSubcantidad";
            Parametros[21].SqlDbType = SqlDbType.Money;
            Parametros[21].SqlValue = ValorSubcantidad;

            Parametros[22] = new SqlParameter();
            Parametros[22].ParameterName = "@Sobres";
            Parametros[22].SqlDbType = SqlDbType.Int;
            Parametros[22].SqlValue = Sobres;

            Parametros[23] = new SqlParameter();
            Parametros[23].ParameterName = "@ValorSobres";
            Parametros[23].SqlDbType = SqlDbType.Money;
            Parametros[23].SqlValue = ValorSobres;

            // Asignando el valor de la imagen
            // Stream usado como buffer
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            // Se guarda la imagen en el buffer
            Foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            // Se extraen los bytes del buffer para asignarlos como valor para el 
            // parámetro.
            Parametros[24] = new SqlParameter();
            Parametros[24].ParameterName = "@Foto";
            Parametros[24].SqlDbType = SqlDbType.Image;
            Parametros[24].SqlValue = ms.GetBuffer();

            Parametros[25] = new SqlParameter();
            Parametros[25].ParameterName = "@movimiento";
            Parametros[25].SqlDbType = SqlDbType.VarChar;
            Parametros[25].SqlValue = movimiento;

            Parametros[26] = new SqlParameter();
            Parametros[26].ParameterName = "@FechaRegistro";
            Parametros[26].SqlDbType = SqlDbType.DateTime;
            Parametros[26].SqlValue = DateTime.Now;

            Parametros[27] = new SqlParameter();
            Parametros[27].ParameterName = "@Usuario";
            Parametros[27].SqlDbType = SqlDbType.Int;
            Parametros[27].SqlValue = Usuario;

            Parametros[28] = new SqlParameter();
            Parametros[28].ParameterName = "@DescuentoProveedor";
            Parametros[28].SqlDbType = SqlDbType.Float;
            Parametros[28].SqlValue = descuento_proveedor;

            Parametros[29] = new SqlParameter();
            Parametros[29].ParameterName = "@FechaVencimiento";
            Parametros[29].SqlDbType = SqlDbType.Date;
            Parametros[29].SqlValue = "1900-01-01";

            Parametros[30] = new SqlParameter();
            Parametros[30].ParameterName = "@CostoCalculado";
            Parametros[30].SqlDbType = SqlDbType.Money;
            Parametros[30].SqlValue = Costo_productoCalculado;

            Parametros[31] = new SqlParameter();
            Parametros[31].ParameterName = "@Nota";
            Parametros[31].SqlDbType = SqlDbType.VarChar;
            Parametros[31].SqlValue = Nota;
        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO Producto (Referencia,Nombre,Descripcion,IVA,UnidadMedida,medida,Estado,Categoria,Marca,Proveedor, " +
                      " ModoVenta,Ubicacion,Salida_para,Stock_minimo,Stock_maximo,Cantidad,Costo,PrecioVenta,CodigoBarras, " +
                      " SubCantidad,ValorSubcantidad,Sobres,ValorSobre,Foto,Usuario,FechaRegistro,movimiento,DescuentoProveedor,FechaVencimiento,CostoCalculado,Nota) " +

                      " VALUES (@Referencia,@Nombre,@Descripcion,@IVA,@UnidadMedida,@medida,@Estado,@Categoria,@Marca,@Proveedor, " +
                      " @ModoVenta,@Ubicacion,@Salida_para,@Stock_minimo,@Stock_maximo,@Cantidad,@Costo,@PrecioVenta,@CodigoBarras, " +
                      " @SubCantidad,@ValorSubcantidad,@Sobres,@ValorSobres,@Foto,@Usuario,@FechaRegistro,@movimiento,@DescuentoProveedor,@FechaVencimiento,@CostoCalculado,@Nota) ";

            mtd_asignaParametros();
            v_ok = cls_Datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_registrar_fecha_vencimiento(string item, string fechaVencimiento)
        {
            v_query = " INSERT INTO FECHASVENCIMIENTO (Item,FechaVecimiento) " +
                      " VALUES ("+ item + ",'"+ fechaVencimiento + "') ";
            v_ok = cls_Datos.mtd_ejecutar(v_query);
            return v_ok;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE Producto SET Referencia = @Referencia,Nombre = @Nombre,Descripcion = @Descripcion,IVA = @IVA,  " +
                      " UnidadMedida = @UnidadMedida,medida = @medida,Estado = @Estado,Categoria = @Categoria,Marca = @Marca, " +
                      " Proveedor = @Proveedor,ModoVenta = @ModoVenta,Ubicacion = @Ubicacion,Salida_para = @Salida_para, " +
                      " Stock_minimo = @Stock_minimo,Stock_maximo = @Stock_maximo,Cantidad = @Cantidad,Costo = @Costo,PrecioVenta = @PrecioVenta, " +
                      " CodigoBarras = @CodigoBarras,SubCantidad= @SubCantidad,ValorSubcantidad = @ValorSubcantidad,Sobres = @Sobres, " +
                      " ValorSobre = @ValorSobres,Foto = @Foto,Usuario = @Usuario,FechaRegistro = @FechaRegistro,movimiento = @movimiento, " +
                      "DescuentoProveedor = @DescuentoProveedor, FechaVencimiento = @FechaVencimiento, CostoCalculado = @CostoCalculado, Nota = @Nota " +
                      " WHERE Item = "+Item;

            mtd_asignaParametros();
            v_ok = cls_Datos.mtd_editar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM Producto WHERE Item = '" + Item + "'";
            v_ok = cls_Datos.mtd_eliminar(v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar_fecha_vencimiento()
        {
            v_query = "DELETE FROM FechasVencimiento WHERE Item = '" + Item + "' AND FechaVecimiento = '"+FechaVencimiento+"'";
            v_ok = cls_Datos.mtd_eliminar(v_query);
            return v_ok;
        }

        public DataTable mtd_consultar_todos_productos()
        {
            v_query = " EXECUTE SP_CONSULTA_ESTADO_PRODUCTOS '" + v_buscar + "','" + v_tipo_busqueda + "','" + v_data_busqueda + "'  ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_todos_productos_saldos()
        {
            v_query = " EXECUTE SP_CONSULTA_ESTADO_PRODUCTOS_saldos '" + v_buscar + "','" + v_tipo_busqueda + "','" + v_data_busqueda + "'  ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_todos_productos_saldos_totales()
        {
            v_query = " EXECUTE SP_CALCULO_SALDOS_TOTALES '" + v_buscar + "','" + v_tipo_busqueda + "','" + v_data_busqueda + "'  ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_dato_inventario()
        {
            v_query = " EXECUTE sp_datos_inventario '" + Item + "'  ";
            v_dt = cls_Datos.mtd_consultar(v_query);
            return v_dt;
        }
    }
}
