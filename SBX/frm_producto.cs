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

namespace SBX
{
    public partial class frm_producto : Form
    {
        //Instancias
        cls_producto cls_Producto = new cls_producto();

        //Variables
        DataTable v_dt;
        int v_fila = 0;
        int v_contador = 0;
        bool v_confirmacion;
        bool v_ok;
        int Eliminados;
        int Error;
        public DataTable v_dt_Permi { get; set; }

        //Inicio de formulario
        public frm_producto()
        {
            InitializeComponent();
        }
        public frm_producto(string frm_)
        {
            InitializeComponent();
            pnl_titulo.Height = 32;
        }
        private void frm_producto_Load(object sender, EventArgs e)
        {
            mtd_mensajeInformativoBotones();
            cbx_tipo_busqueda.SelectedIndex = 0;

            foreach (DataRow rows in v_dt_Permi.Rows)
            {
                if (rows["Modulo"].ToString() == "PRODUCTO")
                {
                    switch (rows["Permiso"].ToString())
                    {
                        case "exportar_excel":
                            btn_exportar_excel.Enabled = true;
                            break;
                        case "editar":
                            btn_editar.Enabled = true;
                            break;
                        case "eliminar":
                            btn_eliminar.Enabled = true;
                            break;
                    }
                }
            }
        }

        //Metodos
        Paginar p;
        public void mtd_mensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar");
            Botones.SetToolTip(btn_exportar_excel, "Exportar a excel");
            Botones.SetToolTip(btn_eliminar, "Eliminar");
            Botones.SetToolTip(btn_editar, "Editar");
            Botones.SetToolTip(btn_producto_mas_vendido, "Producto mas vendido");
        }
        string v_buscar = "";
        string v_tipo_busqueda = "";
        private void mtd_cargar_productos()
        {
          
            cls_Producto.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            v_tipo_busqueda = cbx_tipo_busqueda.Text;
            if (txt_buscar.Text == "Item-Nombre-Referencia-Codigo barras")
            {
                cls_Producto.v_buscar = "";
                v_buscar = "";
            }
            else
            {
                cls_Producto.v_buscar = txt_buscar.Text;
                v_buscar = txt_buscar.Text;
            }
          
            DataSet ds = new DataSet();
            int maximo_x_pagina = 10;//cargar por default
            p = new Paginar("EXECUTE SP_CONSULTA_ESTADO_PRODUCTOS '" + v_buscar + "','" + v_tipo_busqueda + "' ", "DataMember1", maximo_x_pagina);
          
            //v_dt = cls_Producto.mtd_consultar_producto_kardex();
            //dtg_productos.Rows.Clear();
            dtg_productos.DataSource = p.cargar();
            dtg_productos.DataMember = "datamember1";
            dtg_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //if (v_dt.Rows.Count > 0)
            //{
            //    v_fila = v_dt.Rows.Count;
            //    dtg_productos.Rows.Add(v_fila);
            //    v_contador = 0;
            //    foreach (DataRow rows in v_dt.Rows)
            //    {
            //        dtg_productos.Rows[v_contador].Cells["cl_item"].Value = string.Format("{0:0000}",rows["Item"]);
            //        dtg_productos.Rows[v_contador].Cells["cl_referencia"].Value = rows["Referencia"];
            //        dtg_productos.Rows[v_contador].Cells["cl_codigo_barras"].Value = rows["CodigoBarras"];
            //        dtg_productos.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"];
            //        dtg_productos.Rows[v_contador].Cells["cl_descripcion"].Value = rows["Descripcion"];
            //        double Stock = Convert.ToDouble(rows["Stock"]);

            //        dtg_productos.Rows[v_contador].Cells["cl_stock"].Value = Math.Round(Stock, 2);
            //        double stockSubcantidad = Convert.ToDouble(rows["stockSubcantidad"]);
            //        dtg_productos.Rows[v_contador].Cells["cl_stock_subcantidad"].Value = Math.Round(stockSubcantidad, 2);
            //        double stockSobres = Convert.ToDouble(rows["stockSobres"]);
            //        dtg_productos.Rows[v_contador].Cells["cl_stock_sobre"].Value = Math.Round(stockSobres, 2);
            //        if (rows["ModoVenta"].ToString() != "Unidad" && rows["ModoVenta"].ToString() != "Queso")
            //        {
            //            //Sub cantidad
            //            int Entero = (int)Stock;
            //            double decimales = Stock - Entero;                     
            //            double subC = decimales * Convert.ToDouble(rows["Subcantidad"]);                   
            //            string Stock_glo = "";
            //            if (rows["ModoVenta"].ToString() == "Multi")
            //            {
            //                //sobres
            //                int EnteroSob = (int)stockSobres;
            //                double decimalesSob = stockSobres - EnteroSob;
            //                double sobr = decimalesSob * Convert.ToDouble(rows["Sobres"]);
            //                int EnteroSobre = (int)sobr;
            //                Stock_glo = "Cant: " + Entero + " - Sub: " + Math.Round(subC, 2) + " - Sb: " + EnteroSobre;
            //            }
            //            else
            //            {
            //                 Stock_glo = "Cant: " + Entero + " - Sub: " + Math.Round(subC, 2);
            //            }

            //            dtg_productos.Rows[v_contador].Cells["cl_stock_global"].Value = Stock_glo;
            //        }
            //        else
            //        {
            //            dtg_productos.Rows[v_contador].Cells["cl_stock_global"].Value = Math.Round(Stock, 2);
            //        }
            //        double costo = Convert.ToDouble(rows["CostoCalculado"]);
            //        dtg_productos.Rows[v_contador].Cells["cl_costo"].Value = costo.ToString("N2");
            //        double TCostos = Convert.ToDouble(rows["TotalCostoCalculado"]);
            //        dtg_productos.Rows[v_contador].Cells["cl_total_costo"].Value = TCostos.ToString("N2");
            //        double Precio_venta = Convert.ToDouble(rows["PrecioVenta"]);
            //        dtg_productos.Rows[v_contador].Cells["cl_precio_venta"].Value = Precio_venta.ToString("N2");
            //        double TPrecioVenta = Convert.ToDouble(rows["TotalPrecioVenta"]);
            //        dtg_productos.Rows[v_contador].Cells["cl_total_venta"].Value = TPrecioVenta.ToString("N2");
            //        double vlr_sub = Convert.ToDouble(rows["ValorSubCantidad"]);
            //        dtg_productos.Rows[v_contador].Cells["cl_valor_subcantidad"].Value = vlr_sub.ToString("N2");
            //        double t_valor_subCantidad = Convert.ToDouble(rows["TotalPrecioVentaSubcantidad"]);
            //        dtg_productos.Rows[v_contador].Cells["cl_total_valor_subcatidad"].Value = t_valor_subCantidad.ToString("N2");

            //        double vlr_sob = Convert.ToDouble(rows["ValorSobre"]);
            //        dtg_productos.Rows[v_contador].Cells["cl_valor_sobre"].Value = vlr_sob.ToString("N2");
            //        double Tvalor_sobre = Convert.ToDouble(rows["TotalPrecioVentaSobres"]);
            //        dtg_productos.Rows[v_contador].Cells["cl_total_valor_sobre"].Value = Tvalor_sobre.ToString("N2");
            //        dtg_productos.Rows[v_contador].Cells["cl_iva"].Value = rows["IVA"];
            //        dtg_productos.Rows[v_contador].Cells["cl_unidad_medida"].Value = rows["UnidadMedida"];
            //        dtg_productos.Rows[v_contador].Cells["cl_categoria"].Value = rows["Categoria"];
            //        dtg_productos.Rows[v_contador].Cells["cl_marca"].Value = rows["Marca"];
            //        dtg_productos.Rows[v_contador].Cells["cl_ubicacion"].Value = rows["Ubicacion"];
            //        dtg_productos.Rows[v_contador].Cells["cl_salida_para"].Value = rows["Salidapara"];
            //        dtg_productos.Rows[v_contador].Cells["cl_dni_proveedor"].Value = rows["proveedor"];
            //        dtg_productos.Rows[v_contador].Cells["cl_proveedor"].Value = rows["NombreProveedor"];
            //        dtg_productos.Rows[v_contador].Cells["cl_stock_minimo"].Value = rows["Stock_minimo"];
            //        dtg_productos.Rows[v_contador].Cells["cl_stock_maximo"].Value = rows["Stock_maximo"];
            //        v_contador++;
            //    }
            //}
            actualizar();
        }
        private void mtd_exporta_excel()
        {
            frm_exportar_excel frm_Exportando_excel = new frm_exportar_excel();
            frm_Exportando_excel.Show();

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;

            frm_Exportando_excel.mtd_progreso(20);
         
            foreach (DataColumn columna in v_dt.Columns)
            {
                    IndiceColumna++;
                    Excel.Cells[1, IndiceColumna] = columna.ColumnName;
            }
            frm_Exportando_excel.mtd_progreso(70);
            int IndiceFila = 0;

            foreach (DataRow Row in v_dt.Rows)
            {
                    IndiceFila++;
                    IndiceColumna = 0;

                    foreach (DataColumn Columna in v_dt.Columns)
                    {
                    IndiceColumna++;
                    if (Columna.ColumnName != "Foto")
                    {
                        Excel.Cells[IndiceFila + 1, IndiceColumna] = Row[Columna.ColumnName];
                    }
                }
            }
            frm_Exportando_excel.mtd_progreso(100);
            frm_Exportando_excel.Hide();

            Excel.Visible = true;
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        private void mtd_eliminar()
        {
            frm_confirmacion frm_Confirmacion = new frm_confirmacion();
            if (dtg_productos.Rows.Count > 0)
            {
                if (dtg_productos.SelectedRows.Count > 0)
                {
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    v_contador = dtg_productos.SelectedRows.Count;
                    frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + "  Productos?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    { 
                        Eliminados = 0;
                        Error = 0;
                        foreach (DataGridViewRow rows in dtg_productos.SelectedRows)
                        { 
                            int Items = Convert.ToInt32(rows.Cells["cl_item"].Value);
                            cls_Producto.Item = Items.ToString();
                            v_ok = cls_Producto.mtd_eliminar();
                            if (v_ok)
                            {
                                Eliminados++;
                            }
                            else
                            {
                                Error++;
                            }
                        }
                        frm_msg frm_Msg = new frm_msg();
                        frm_Msg.pnl_arriba.BackColor = Color.DimGray;
                        frm_Msg.lbl_titulo.Text = "Eliminar";
                        frm_Msg.txt_mensaje.Text = "Eliminados: " + Eliminados + ", Errores: " + Error;
                        frm_Msg.ShowDialog();
                    }
                }
            }
        }
        //private void mtd_calculo_totales()
        //{
        //    double Tstock = 0;
        //    double Tsubcantidad = 0;
        //    double Tsobre = 0;
        //    double Tcosto = 0;
        //    double TprecioVenta = 0;
        //    if (dtg_productos.Rows.Count > 0)
        //    {
        //        foreach (DataGridViewRow rows in dtg_productos.Rows)
        //        {
        //            Tstock += Convert.ToDouble(rows.Cells["cl_stock"].Value);
        //            Tsubcantidad += Convert.ToDouble(rows.Cells["cl_stock_subcantidad"].Value);
        //            Tsobre += Convert.ToDouble(rows.Cells["cl_stock_sobre"].Value);
        //            Tcosto += Convert.ToDouble(rows.Cells["cl_total_costo"].Value);
        //            TprecioVenta += Convert.ToDouble(rows.Cells["cl_total_venta"].Value);
        //        }

            
        //    }
        //    else
        //    {
               
        //    }
        //}

        //Eventos
        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "Item-Nombre-Referencia-Codigo barras")
            {
                txt_buscar.Text = "";
                txt_buscar.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "Item-Nombre-Referencia-Codigo barras";
                txt_buscar.ForeColor = Color.Silver;
            }
        }
        private void lbl_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_cargar_productos();
            //mtd_calculo_totales();
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_cargar_productos();
            //mtd_calculo_totales();
        }
        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            cls_Producto.v_tipo_busqueda = "Buscar_data_producto";
            cls_Producto.Item = "";
            cls_Producto.Referencia = "";
            cls_Producto.CodigoBarras = "";
            if (txt_buscar.Text == "Item-Nombre-Referencia-Codigo barras")
            {
                cls_Producto.v_buscar = "";
            }
            else
            {
                cls_Producto.v_buscar = txt_buscar.Text;
            }
            v_dt = cls_Producto.mtd_consultar_producto();
            mtd_exporta_excel();
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dtg_productos.Rows.Count > 0)
            {
                if (dtg_productos.SelectedRows.Count > 0)
                {
                    frm_inventario frm_Inventario = new frm_inventario("Modificar");
                    foreach (DataGridViewRow rows in dtg_productos.SelectedRows)
                    {
                        frm_Inventario.mtd_dato_venta(rows.Cells["Item"].Value.ToString());
                    }
                    frm_Inventario.v_dt_Permi = v_dt_Permi;
                    frm_Inventario.Show();
                }
            }
        }
        private void dtg_productos_DoubleClick(object sender, EventArgs e)
        {
            if (dtg_productos.Rows.Count > 0)
            {
                if (btn_editar.Enabled == true)
                {
                    if (dtg_productos.SelectedRows.Count > 0)
                    {
                        frm_inventario frm_Inventario = new frm_inventario("Modificar");
                        foreach (DataGridViewRow rows in dtg_productos.SelectedRows)
                        {
                            frm_Inventario.mtd_dato_venta(rows.Cells["Item"].Value.ToString());
                        }
                        frm_Inventario.v_dt_Permi = v_dt_Permi;
                        frm_Inventario.ShowDialog();
                    }
                }
            }          
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            mtd_eliminar();
            mtd_cargar_productos();
        }
        private void btn_producto_mas_vendido_Click(object sender, EventArgs e)
        {
            frm_prod_mas_vendido frm_prod = new frm_prod_mas_vendido();
            frm_prod.Show();
        }
        private void actualizar()
        {
            lbl_registros.Text = p.countRow().ToString();
            lbl_paginas.Text = p.numPag().ToString();
            lbl_ultima_pagina.Text = p.countPag().ToString();
            txt_max_paginas.Text = p.limitRow().ToString();                
        }
        private void btn_primero_Click(object sender, EventArgs e)
        {
            p.primeraPagina();
            actualizar();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            p.atras();
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            p.actualizaTope(Convert.ToInt32(txt_max_paginas.Text));
            actualizar();
        }
    }
}
