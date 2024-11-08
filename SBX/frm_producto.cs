﻿using System;
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
        public int BuscaAutomaticamente { get; set; }
        public int BuscaPaginados { get; set; }
        public string Usuario { get; set; }

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
            cbx_dato_busqueda.SelectedIndex = 0;

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
            if (BuscaPaginados == 0)
            {
                panel1.Visible = false;
            }
        }

        //Metodos
        Paginar p;
        DataTable datosProductos;
        public void mtd_mensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar");
            Botones.SetToolTip(btn_exportar_excel, "Exportar a excel");
            Botones.SetToolTip(btn_eliminar, "Eliminar");
            Botones.SetToolTip(btn_editar, "Editar");
            Botones.SetToolTip(btn_producto_mas_vendido, "Producto mas vendido");
            Botones.SetToolTip(btn_estado_stock, "Estado Stocks");
            Botones.SetToolTip(btn_fecha_vencimiento, "Estado Fecha vencimiento");
            Botones.SetToolTip(btn_nuevo, "Agregar Producto");
        }
        string v_buscar = "";
        string v_tipo_busqueda = "";
        string v_dato_busqueda = "";
        private void mtd_cargar_productos()
        {
            this.Cursor = Cursors.WaitCursor;
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
            v_dato_busqueda = cbx_dato_busqueda.Text;
            cls_Producto.v_data_busqueda = v_dato_busqueda;
            if (BuscaPaginados == 1)
            {
                //datos paginados
                panel1.Visible = true;
                DataSet ds = new DataSet();
                int maximo_x_pagina = 16;//cargar por default
                p = new Paginar("EXECUTE SP_CONSULTA_ESTADO_PRODUCTOS '" + v_buscar + "','" + cbx_tipo_busqueda.Text + "','" + v_dato_busqueda + "' ", "DataMember1", maximo_x_pagina);
                dtg_productos.DataSource = p.cargar();
                dtg_productos.DataMember = "datamember1";
                dtg_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                actualizar();
            }
            else
            {
                //datos listado
                dtg_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                panel1.Visible = false;
                datosProductos = cls_Producto.mtd_consultar_todos_productos();
                dtg_productos.DataSource = datosProductos;
            }
            this.Cursor = Cursors.Default;
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
                            int Items = Convert.ToInt32(rows.Cells["Item"].Value);
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
            else
            {
                MessageBox.Show("No hay datos para eliminar", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (BuscaAutomaticamente == 1)
            {
                mtd_cargar_productos();
            }
           
            //mtd_calculo_totales();
        }
        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            if (dtg_productos.Rows.Count > 0)
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
            else 
            {
                MessageBox.Show("No hay datos para exportar a excel","Sin datos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }         
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
                    frm_Inventario.Usuario = this.Usuario;
                    frm_Inventario.Show();
                }
            }
            else
            {
                MessageBox.Show("No hay datos para Editar", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dtg_productos_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
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
                        frm_Inventario.Usuario = this.Usuario;
                        frm_Inventario.ShowDialog();
                    }
                }
            }
            this.Cursor = Cursors.Default;
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

        private void btn_estado_stock_Click(object sender, EventArgs e)
        {
            frm_Alerta_stocks frm_Alerta_Stocks = new frm_Alerta_stocks();
            frm_Alerta_Stocks.Show();
        }

        private void btn_fecha_vencimiento_Click(object sender, EventArgs e)
        {
            frm_estado_fechas_vencimiento frm_Estado_Fechas_Vencimiento = new frm_estado_fechas_vencimiento();
            frm_Estado_Fechas_Vencimiento.Show();
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {            
                mtd_cargar_productos();
            }
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frm_inventario frm_Inventario = new frm_inventario();
            frm_Inventario.Usuario = this.Usuario;
            frm_Inventario.v_dt_Permi = this.v_dt_Permi;
            frm_Inventario.Show();
        }
    }
}
