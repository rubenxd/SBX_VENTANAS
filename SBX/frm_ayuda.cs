using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBX.MODEL;
using System.Runtime.InteropServices;

namespace SBX
{
    public partial class frm_ayuda : Form
    {
        //Instancias
        cls_producto cls_Producto = new cls_producto();
        cls_global cls_Global = new cls_global();
        cls_proveedor cls_Proveedor = new cls_proveedor();
        cls_cliente cls_Cliente = new cls_cliente();
        cls_mensajero cls_Mensajero = new cls_mensajero();
        cls_rol cls_Rol = new cls_rol();

        //Delegado
        public delegate void EnviarInfo(string dato);
        public event EnviarInfo Enviainfo;

        //Delegado
        public delegate void EnviarInfo2(string dato,string dato2,string dato3);
        public event EnviarInfo2 Enviainfo2;

        //Variables
        string v_busqueda = "";
        DataTable v_dt;
        DataTable v_dt_2;
        DataRow rows2;
        int v_contador = 0;
        int v_filas = 0;
        string v_dato = "";
        string v_dato2 = "";
        string v_dato3 = "";

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Inicio formulario
        public frm_ayuda()
        {
            InitializeComponent();
        }
        public frm_ayuda(string frm)
        {
            InitializeComponent();
            lbl_frm.Text = frm;
            v_busqueda = frm;
        }
        private void frm_ayuda_Load(object sender, EventArgs e)
        {
            cbx_tipo_busqueda.SelectedIndex = 0;
            cbx_dato_busqueda.SelectedIndex = 0;
        }

        //Metodos
        Paginar p;
        private void mtd_cargar_informacion()
        {
            string v_buscar = "";
            string v_tipo_busqueda = "";
            string v_dato_busqueda = "";
            switch (v_busqueda)
            {
                case "Buscar producto":
                    if (txt_buscar.Text == "Buscar")
                    {
                        cls_Producto.v_buscar = "";
                        v_buscar = "";
                    }
                    else
                    {
                        cls_Producto.v_buscar = txt_buscar.Text;
                        v_buscar = txt_buscar.Text;
                    }
                      
                        cls_Producto.Item = "0";
                        if (cbx_tipo_busqueda.Text == "Contiene")
                        {
                            cls_Producto.v_tipo_busqueda = "Buscar_data_producto";
                        v_tipo_busqueda= "Buscar_data_producto";
                    }
                        else
                        {
                            cls_Producto.v_tipo_busqueda = "Buscar_data_producto_exacto";
                        v_tipo_busqueda = "Buscar_data_producto_exacto";
                    }
                    v_dato_busqueda = cbx_dato_busqueda.Text;
                    cls_Producto.v_tipo_busqueda = cbx_tipo_busqueda.Text;
                    cls_Producto.v_data_busqueda = cbx_dato_busqueda.Text;
                    dtg_ayudas.DataSource = cls_Producto.mtd_consultar_todos_productos();

                    //------------
                    //DataSet ds = new DataSet();                   
                    //    int maximo_x_pagina = 10;//cargar por default
                    //    //p = new Paginar("EXECUTE sp_consultar_producto '" + v_tipo_busqueda + "','" + v_buscar + "','','','','"+ v_dato_busqueda + "' ", "DataMember1", maximo_x_pagina);
                    //    p = new Paginar("EXECUTE SP_CONSULTA_ESTADO_PRODUCTOS '" + v_buscar + "','" + cbx_tipo_busqueda.Text + "','" + v_dato_busqueda + "' ", "DataMember1", maximo_x_pagina);

                    //    ds = p.cargar();
                    //    v_dt = ds.Tables[0];
                    //    //-------------

                    //    //v_dt = cls_Producto.mtd_consultar_producto_Paginado();

                    //       dtg_ayudas.Rows.Clear();
                    //        if (v_dt.Rows.Count > 0)
                    //        {
                    //            dtg_ayudas.Columns.Clear();
                    //            dtg_ayudas.Columns.Add("cl_item", "Item");
                    //            dtg_ayudas.Columns[0].Width = 50;
                    //            dtg_ayudas.Columns[0].ReadOnly = true;
                    //            dtg_ayudas.Columns.Add("cl_nombre", "Nombre");
                    //            dtg_ayudas.Columns[1].Width = 500;
                    //            dtg_ayudas.Columns[1].ReadOnly = true;
                    //            dtg_ayudas.Columns.Add("cl_referencia", "Referencia");
                    //            dtg_ayudas.Columns[2].ReadOnly = true;
                    //            dtg_ayudas.Columns.Add("cl_codigo_barras", "CodigoBarras");
                    //            dtg_ayudas.Columns[3].ReadOnly = true;
                    //            //dtg_ayudas.Columns.Add("cl_descripcion", "Descripcion");
                    //            //dtg_ayudas.Columns[4].ReadOnly = true;

                    //            v_contador = 0;
                    //            v_filas = v_dt.Rows.Count;
                    //            dtg_ayudas.Rows.Add(v_filas);
                    //            foreach (DataRow rows in v_dt.Rows)
                    //            {
                    //                dtg_ayudas.Rows[v_contador].Cells["cl_item"].Value = string.Format("{0:0000}", rows["Item"]);
                    //                dtg_ayudas.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"].ToString();
                    //                dtg_ayudas.Rows[v_contador].Cells["cl_referencia"].Value = rows["Referencia"].ToString();
                    //                dtg_ayudas.Rows[v_contador].Cells["cl_codigo_barras"].Value = rows["CodigoBarras"].ToString();
                    //                //dtg_ayudas.Rows[v_contador].Cells["cl_descripcion"].Value = rows["Descripcion"].ToString();
                    //                v_contador++;
                    //            }
                    //        }
                    //    actualizar();
                    break;
                case "Buscar producto venta":
                    if (txt_buscar.Text == "Buscar")
                    {
                        cls_Producto.v_buscar = "";
                        v_buscar = "";
                    }
                    else
                    {
                        cls_Producto.v_buscar = txt_buscar.Text;
                        v_buscar = txt_buscar.Text;
                    }

                    cls_Producto.Item = "0";
                    if (cbx_tipo_busqueda.Text == "Contiene")
                    {
                        cls_Producto.v_tipo_busqueda = "Buscar_data_producto_venta";
                        v_tipo_busqueda = "Buscar_data_producto_venta";
                    }
                    else
                    {
                        cls_Producto.v_tipo_busqueda = "Buscar_data_producto_exacto_venta";
                        v_tipo_busqueda = "Buscar_data_producto_exacto_venta";
                    }
                    v_dato_busqueda = cbx_dato_busqueda.Text;
                    cls_Producto.v_tipo_busqueda = cbx_tipo_busqueda.Text;
                    cls_Producto.v_data_busqueda = cbx_dato_busqueda.Text;
                    dtg_ayudas.DataSource = cls_Producto.mtd_consultar_todos_productos();
                    ////------------       OPCION DE PAGINACION ----------------------------------------------------------------       
                    //maximo_x_pagina = 10;
                    ////p = new Paginar("EXECUTE sp_consultar_producto '" + v_tipo_busqueda + "','" + v_buscar + "','','','','" + v_dato_busqueda + "' ", "DataMember1", maximo_x_pagina);
                    //p = new Paginar("EXECUTE SP_CONSULTA_ESTADO_PRODUCTOS '" + v_buscar + "','" + cbx_tipo_busqueda.Text + "','"+ v_dato_busqueda + "' ", "DataMember1", maximo_x_pagina);
                    ////dtg_ayudas.DataSource = p.cargar();
                    ////dtg_ayudas.DataMember = "datamember1";
                    //ds = p.cargar();
                    //v_dt = ds.Tables["DataMember1"];
                    ////-------------

                    ////v_dt = cls_Producto.mtd_consultar_producto();
                    //dtg_ayudas.Rows.Clear();
                    //if (v_dt != null)
                    //{
                    //    if (v_dt.Rows.Count > 0)
                    //    {
                    //        dtg_ayudas.Columns.Clear();
                    //        dtg_ayudas.Columns.Add("cl_item", "Item");
                    //        dtg_ayudas.Columns[0].Width = 50;
                    //        dtg_ayudas.Columns[0].ReadOnly = true;
                    //        dtg_ayudas.Columns.Add("cl_nombre", "Nombre");
                    //        dtg_ayudas.Columns[1].Width = 350;
                    //        dtg_ayudas.Columns[1].ReadOnly = true;
                    //        dtg_ayudas.Columns.Add("cl_referencia", "Referencia");
                    //        dtg_ayudas.Columns[2].Width = 100;
                    //        dtg_ayudas.Columns[2].ReadOnly = true;
                    //        dtg_ayudas.Columns.Add("cl_precioVenta", "Precio");
                    //        dtg_ayudas.Columns[3].ReadOnly = true;
                    //        dtg_ayudas.Columns.Add("cl_stock", "Stock");
                    //        dtg_ayudas.Columns[4].ReadOnly = true;
                    //        dtg_ayudas.Columns.Add("cl_precio_sub", "Precio sub");
                    //        dtg_ayudas.Columns[5].ReadOnly = true;
                    //        dtg_ayudas.Columns.Add("cl_sub", "stock sub");
                    //        dtg_ayudas.Columns[6].ReadOnly = true;
                    //        dtg_ayudas.Columns.Add("cl_precio_und", "Precio und");
                    //        dtg_ayudas.Columns[7].ReadOnly = true;
                    //        dtg_ayudas.Columns.Add("cl_und", "Stock und");
                    //        dtg_ayudas.Columns[8].ReadOnly = true;
                    //        dtg_ayudas.Columns.Add("cl_codigo_barras", "Codigo barras");
                    //        v_contador = 0;
                    //        cls_producto cls_Producto = new cls_producto();
                    //        DataTable DTDatos = new DataTable();
                    //        double precio = 0;
                    //        v_filas = v_dt.Rows.Count;
                    //        dtg_ayudas.Rows.Add(v_filas);
                    //        foreach (DataRow rows in v_dt.Rows)
                    //        {
                    //            precio = 0;
                    //            dtg_ayudas.Rows[v_contador].Cells["cl_item"].Value = string.Format("{0:0000}", rows["Item"]);
                    //            dtg_ayudas.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"].ToString();
                    //            dtg_ayudas.Rows[v_contador].Cells["cl_referencia"].Value = rows["Referencia"].ToString();
                    //            ////Consulta stock de producto              
                    //            //cls_Producto.v_buscar = rows["Item"].ToString();
                    //            //cls_Producto.v_tipo_busqueda = "Exactamente";
                    //            //DTDatos = cls_Producto.mtd_consultar_producto_kardex();
                    //            //DataRow DTRows = DTDatos.Rows[0];
                    //            dtg_ayudas.Rows[v_contador].Cells["cl_precioVenta"].Value = rows["Precio"].ToString();
                    //            dtg_ayudas.Rows[v_contador].Cells["cl_stock"].Value = rows["Stock"].ToString();
                    //            dtg_ayudas.Rows[v_contador].Cells["cl_precio_sub"].Value = rows["Vlr. Sub"];
                    //            dtg_ayudas.Rows[v_contador].Cells["cl_sub"].Value = rows["Stock Sub"].ToString();
                    //            dtg_ayudas.Rows[v_contador].Cells["cl_precio_und"].Value = rows["Vlr. und"];
                    //            dtg_ayudas.Rows[v_contador].Cells["cl_und"].Value = rows["Stock und"].ToString();
                    //            dtg_ayudas.Rows[v_contador].Cells["cl_codigo_barras"].Value = rows["CodigoBarras"].ToString();
                    //            v_contador++;

                    //        }
                    //    }
                    //    dtg_ayudas.DataMember = "datamember1";
                    //    actualizar();
                    //}
                    //------------   FIN    OPCION DE PAGINACION ----------------------------------------------------------------                 
                    break;
                case "Buscar proveedor":
                    if (txt_buscar.Text == "Buscar")
                    {
                        cls_Proveedor.v_buscar = "";
                    }
                    else
                    {
                        cls_Proveedor.v_buscar = txt_buscar.Text;
                    }
                    
                        if (cbx_tipo_busqueda.Text == "Contiene")
                        {
                            cls_Proveedor.v_tipo_busqueda = "Contiene";
                        }
                        else
                        {
                            cls_Proveedor.v_tipo_busqueda = "";
                        }

                        v_dt = cls_Proveedor.mtd_consultar_proveedor();
                        dtg_ayudas.Rows.Clear();
                        if (v_dt.Rows.Count > 0)
                        {
                            dtg_ayudas.Columns.Clear();
                            dtg_ayudas.Columns.Add("cl_DNI", "DNI");
                            dtg_ayudas.Columns[0].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_Nombre", "Nombre");
                            dtg_ayudas.Columns[1].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_ciudad", "Ciudad");
                            dtg_ayudas.Columns[2].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_direccion", "Direccion");
                            dtg_ayudas.Columns[3].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_telefono", "Telefono");
                            dtg_ayudas.Columns[4].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_celular", "Celular");
                            dtg_ayudas.Columns[5].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_email", "Email");
                            dtg_ayudas.Columns[6].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_sitio_web", "Sitio web");
                            dtg_ayudas.Columns[7].ReadOnly = true;

                            v_contador = 0;
                            v_filas = v_dt.Rows.Count;
                            dtg_ayudas.Rows.Add(v_filas);
                            foreach (DataRow rows in v_dt.Rows)
                            {
                                dtg_ayudas.Rows[v_contador].Cells["cl_DNI"].Value = rows["DNI"];
                                dtg_ayudas.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_ciudad"].Value = rows["Ciudad"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_direccion"].Value = rows["Direccion"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_telefono"].Value = rows["Telefono"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_celular"].Value = rows["Celular"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_email"].Value = rows["Email"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_sitio_web"].Value = rows["SitioWeb"].ToString();
                              
                                v_contador++;
                            }
                        }
                    break;
                case "Buscar cliente":
                    if (txt_buscar.Text == "Buscar")
                    {
                        cls_Cliente.v_buscar = "";
                    }
                    else
                    {
                        cls_Cliente.v_buscar = txt_buscar.Text;
                    }
                  
                        if (cbx_tipo_busqueda.Text == "Contiene")
                        {
                            cls_Cliente.v_tipo_busqueda = "Contiene";
                        }
                        else
                        {
                            cls_Cliente.v_tipo_busqueda = "";
                        }

                        v_dt = cls_Cliente.mtd_consultar_cliente();
                        dtg_ayudas.Rows.Clear();
                        if (v_dt.Rows.Count > 0)
                        {
                            dtg_ayudas.Columns.Clear();
                            dtg_ayudas.Columns.Add("cl_DNI", "DNI");
                            dtg_ayudas.Columns[0].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_Nombre", "Nombre");
                            dtg_ayudas.Columns[1].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_ciudad", "Ciudad");
                            dtg_ayudas.Columns[2].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_direccion", "Direccion");
                            dtg_ayudas.Columns[3].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_telefono", "Telefono");
                            dtg_ayudas.Columns[4].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_celular", "Celular");
                            dtg_ayudas.Columns[5].ReadOnly = true;
                            //dtg_ayudas.Columns.Add("cl_email", "Email");
                            //dtg_ayudas.Columns[6].ReadOnly = true;
                            //dtg_ayudas.Columns.Add("cl_sitio_web", "Sitio web");
                            //dtg_ayudas.Columns[7].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_sucursal_codigo", "Cod Suc");                    
                            dtg_ayudas.Columns[6].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_sucursal", "Sucursal");
                            dtg_ayudas.Columns[7].ReadOnly = true;

                        v_contador = 0;
                            v_filas = v_dt.Rows.Count;
                            dtg_ayudas.Rows.Add(v_filas);
                            foreach (DataRow rows in v_dt.Rows)
                            {
                                dtg_ayudas.Rows[v_contador].Cells["cl_DNI"].Value = rows["DNI"];
                                dtg_ayudas.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_ciudad"].Value = rows["Ciudad"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_direccion"].Value = rows["Direccion"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_telefono"].Value = rows["Telefono"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_celular"].Value = rows["Celular"].ToString();
                                //dtg_ayudas.Rows[v_contador].Cells["cl_email"].Value = rows["Email"].ToString();
                                //dtg_ayudas.Rows[v_contador].Cells["cl_sitio_web"].Value = rows["SitioWeb"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_sucursal_codigo"].Value = rows["cods"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_sucursal"].Value = rows["NombreS"].ToString();

                            v_contador++;
                            }
                        }
                    break;
                case "Buscar Mensajero":
                    if (txt_buscar.Text == "Buscar")
                    {
                        cls_Mensajero.v_buscar = "";
                    }
                    else
                    {
                        cls_Mensajero.v_buscar = txt_buscar.Text;
                    }
                   
                        if (cbx_tipo_busqueda.Text == "Contiene")
                        {
                            cls_Mensajero.v_tipo_busqueda = "Contiene";
                        }
                        else
                        {
                            cls_Mensajero.v_tipo_busqueda = "";
                        }

                        v_dt = cls_Mensajero.mtd_consultar_mensajero();
                        dtg_ayudas.Rows.Clear();
                        if (v_dt.Rows.Count > 0)
                        {
                            dtg_ayudas.Columns.Clear();
                            dtg_ayudas.Columns.Add("cl_DNI", "DNI");
                            dtg_ayudas.Columns[0].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_Nombre", "Nombre");
                            dtg_ayudas.Columns[1].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_ciudad", "Ciudad");
                            dtg_ayudas.Columns[2].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_direccion", "Direccion");
                            dtg_ayudas.Columns[3].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_telefono", "Telefono");
                            dtg_ayudas.Columns[4].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_celular", "Celular");            
                            dtg_ayudas.Columns[5].ReadOnly = true;
                            dtg_ayudas.Columns.Add("cl_email", "Email");
                            dtg_ayudas.Columns[6].ReadOnly = true;

                            v_contador = 0;
                            v_filas = v_dt.Rows.Count;
                            dtg_ayudas.Rows.Add(v_filas);
                            foreach (DataRow rows in v_dt.Rows)
                            {
                                dtg_ayudas.Rows[v_contador].Cells["cl_DNI"].Value = rows["DNI"];
                                dtg_ayudas.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_ciudad"].Value = rows["Ciudad"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_direccion"].Value = rows["Direccion"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_telefono"].Value = rows["Telefono"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_celular"].Value = rows["Celular"].ToString();
                                dtg_ayudas.Rows[v_contador].Cells["cl_email"].Value = rows["Email"].ToString();

                                v_contador++;
                            }
                        }
                    break;
                case "Buscar Rol_permiso":
                    if (txt_buscar.Text == "Buscar")
                    {
                        cls_Rol.buscar = "";
                    }
                    else
                    {
                        cls_Rol.buscar = txt_buscar.Text;
                    }

                    if (cbx_tipo_busqueda.Text == "Contiene")
                    {
                        cls_Rol.v_tipo_busqueda = "Contiene";
                    }
                    else
                    {
                        cls_Rol.v_tipo_busqueda = "";
                    }

                    v_dt = cls_Rol.mtd_consultar_Rol();
                    dtg_ayudas.Rows.Clear();
                    if (v_dt.Rows.Count > 0)
                    {
                        dtg_ayudas.Columns.Clear();
                        dtg_ayudas.Columns.Add("Cl_codigo", "Codigo");
                        dtg_ayudas.Columns[0].ReadOnly = true;
                        dtg_ayudas.Columns.Add("cl_Nombre", "Nombre");    
                        dtg_ayudas.Columns[1].ReadOnly = true;
                        dtg_ayudas.Columns.Add("cl_Descripcion", "Descripcion");
                        dtg_ayudas.Columns[2].ReadOnly = true;
                     
                        v_contador = 0;
                        v_filas = v_dt.Rows.Count;
                        dtg_ayudas.Rows.Add(v_filas);
                        foreach (DataRow rows in v_dt.Rows)
                        {
                            dtg_ayudas.Rows[v_contador].Cells["Cl_codigo"].Value = rows["Codigo"];
                            dtg_ayudas.Rows[v_contador].Cells["cl_Nombre"].Value = rows["Nombre"].ToString();
                            dtg_ayudas.Rows[v_contador].Cells["cl_Descripcion"].Value = rows["DescripcionRol"].ToString();

                            v_contador++;
                        }
                    }

                    break;
            }
        }
        private void actualizar()
        {
            lbl_registros.Text = p.countRow().ToString();
            lbl_paginas.Text = p.numPag().ToString();
            lbl_ultima_pagina.Text = p.countPag().ToString();
            txt_max_paginas.Text = p.limitRow().ToString();
            DataSet ds = new DataSet();
            ds = p.cargar();
            v_dt = ds.Tables["datamember1"];
            //-------------

            //v_dt = cls_Producto.mtd_consultar_producto();
            dtg_ayudas.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                dtg_ayudas.Columns.Clear();
                dtg_ayudas.Columns.Add("cl_item", "Item");
                dtg_ayudas.Columns[0].Width = 50;
                dtg_ayudas.Columns[0].ReadOnly = true;
                dtg_ayudas.Columns.Add("cl_nombre", "Nombre");
                dtg_ayudas.Columns[1].Width = 350;
                dtg_ayudas.Columns[1].ReadOnly = true;
                dtg_ayudas.Columns.Add("cl_referencia", "Referencia");
                dtg_ayudas.Columns[2].Width = 100;
                dtg_ayudas.Columns[2].ReadOnly = true;
                dtg_ayudas.Columns.Add("cl_precioVenta", "Precio");
                dtg_ayudas.Columns[3].ReadOnly = true;
                dtg_ayudas.Columns.Add("cl_stock", "Stock");
                dtg_ayudas.Columns[4].ReadOnly = true;
                dtg_ayudas.Columns.Add("cl_precio_sub", "Precio sub");
                dtg_ayudas.Columns[5].ReadOnly = true;
                dtg_ayudas.Columns.Add("cl_sub", "stock sub");
                dtg_ayudas.Columns[6].ReadOnly = true;
                dtg_ayudas.Columns.Add("cl_precio_und", "Precio und");
                dtg_ayudas.Columns[7].ReadOnly = true;
                dtg_ayudas.Columns.Add("cl_und", "Stock und");
                dtg_ayudas.Columns[8].ReadOnly = true;
                dtg_ayudas.Columns.Add("cl_codigo_barras", "Codigo barras");
                cls_producto cls_Producto = new cls_producto();
                DataTable DTDatos = new DataTable();
                double precio = 0;
                v_contador = 0;
                v_filas = v_dt.Rows.Count;
                dtg_ayudas.Rows.Add(v_filas);
                foreach (DataRow rows in v_dt.Rows)
                {

                    dtg_ayudas.Rows[v_contador].Cells["cl_item"].Value = string.Format("{0:0000}", rows["Item"]);
                    dtg_ayudas.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"].ToString();
                    dtg_ayudas.Rows[v_contador].Cells["cl_referencia"].Value = rows["Referencia"].ToString();
                    //Consulta stock de producto              
                    //cls_Producto.v_buscar = rows["Item"].ToString();
                    //cls_Producto.v_tipo_busqueda = "Exactamente";
                    //DTDatos = cls_Producto.mtd_consultar_producto_kardex();
                    //if (DTDatos.Rows.Count > 0)
                    //{
                    //    DataRow DTRows = DTDatos.Rows[0];
                    //    dtg_ayudas.Rows[v_contador].Cells["cl_precioVenta"].Value = DTRows["Precio"].ToString();
                    //    dtg_ayudas.Rows[v_contador].Cells["cl_stock"].Value = DTRows["Stock"].ToString();
                    //    dtg_ayudas.Rows[v_contador].Cells["cl_precio_sub"].Value = DTRows["Vlr. Sub"];
                    //    dtg_ayudas.Rows[v_contador].Cells["cl_sub"].Value = DTRows["Stock Sub"].ToString();
                    //    dtg_ayudas.Rows[v_contador].Cells["cl_precio_und"].Value = DTRows["Vlr. und"];
                    //    dtg_ayudas.Rows[v_contador].Cells["cl_und"].Value = DTRows["Stock und"].ToString();
                    //    dtg_ayudas.Rows[v_contador].Cells["cl_codigo_barras"].Value = rows["CodigoBarras"].ToString();
                    //}
                    dtg_ayudas.Rows[v_contador].Cells["cl_precioVenta"].Value = rows["Precio"].ToString();
                    dtg_ayudas.Rows[v_contador].Cells["cl_stock"].Value = rows["Stock"].ToString();
                    dtg_ayudas.Rows[v_contador].Cells["cl_precio_sub"].Value = rows["Vlr. Sub"];
                    dtg_ayudas.Rows[v_contador].Cells["cl_sub"].Value = rows["Stock Sub"].ToString();
                    dtg_ayudas.Rows[v_contador].Cells["cl_precio_und"].Value = rows["Vlr. und"];
                    dtg_ayudas.Rows[v_contador].Cells["cl_und"].Value = rows["Stock und"].ToString();
                    dtg_ayudas.Rows[v_contador].Cells["cl_codigo_barras"].Value = rows["CodigoBarras"].ToString();
                    v_contador++;

                }
            }
        }

        //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void lbl_minimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            mtd_cargar_informacion();
            this.Cursor = Cursors.Default;
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            //mtd_cargar_informacion();
        }
        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "Buscar")
            {
                txt_buscar.Text = "";
                txt_buscar.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "Buscar";
                txt_buscar.ForeColor = Color.Silver;
            }
        }
        private void dtg_ayudas_DoubleClick(object sender, EventArgs e)
        {
            if (dtg_ayudas.Rows.Count > 0)
            {
                v_filas = dtg_ayudas.CurrentRow.Index;
                switch (v_busqueda)
                {
                    case "Buscar producto":
                        //Enviar item de producto    
                        v_dato = dtg_ayudas[0, v_filas].Value.ToString();
                        break;
                    case "Buscar producto venta":
                        //Enviar item de producto    
                        v_dato = dtg_ayudas[0, v_filas].Value.ToString();
                        break;
                    case "Buscar proveedor":
                        //Enviar DNI de proveedor
                        v_dato = dtg_ayudas[0, v_filas].Value.ToString();
                        v_dato2 = dtg_ayudas[1, v_filas].Value.ToString();
                        v_dato3 = "";
                        break;
                    case "Buscar cliente":
                        //Enviar DNI de ciente
                        v_dato = dtg_ayudas[0, v_filas].Value.ToString();
                        v_dato2 = dtg_ayudas[6, v_filas].Value.ToString();
                        v_dato3 = dtg_ayudas[7, v_filas].Value.ToString();
                        break;
                    case "Buscar Mensajero":
                        //Enviar DNI de mensajero
                        v_dato = dtg_ayudas[0, v_filas].Value.ToString();
                        break;
                    case "Buscar Rol_permiso":
                        //Enviar Codigo rol
                        v_dato = dtg_ayudas[0, v_filas].Value.ToString();
                        v_dato2 = dtg_ayudas[1, v_filas].Value.ToString();
                        v_dato3 = dtg_ayudas[2, v_filas].Value.ToString();
                        break;
                }

                if (v_busqueda == "Buscar Rol_permiso" || v_busqueda == "Buscar proveedor" || v_busqueda == "Buscar cliente")
                {
                    Enviainfo2(v_dato,v_dato2,v_dato3);
                }
                else
                {
                    Enviainfo(v_dato);
                }
               
                this.Dispose();
            }
        }
        private void pnl_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lbl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lbl_frm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            p.actualizaTope(Convert.ToInt32(txt_max_paginas.Text));
            actualizar();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            p.atras();
            actualizar();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            p.primeraPagina();
            actualizar();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            p.adelante();
            actualizar();
        }
        private void btn_ultima_Click(object sender, EventArgs e)
        {
            p.ultimaPagina();
            actualizar();
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Cursor = Cursors.WaitCursor;
                mtd_cargar_informacion();
                this.Cursor = Cursors.Default;
            }
        }

        private void cbx_tipo_busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_tipo_busqueda.SelectedIndex == 0)
            {
                cbx_dato_busqueda.Enabled = true;
            }
            else
            {
                cbx_dato_busqueda.Enabled = false;
            }
        }
    }
}
