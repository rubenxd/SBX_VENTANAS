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
    public partial class frm_venta : Form
    {
        cls_producto cls_Producto = new cls_producto();
        cls_global cls_Global = new cls_global();
        cls_cliente cls_Cliente = new cls_cliente();
        cls_domicilio cls_Domicilio = new cls_domicilio();
        cls_sistema_separado cls_Sistema_separado = new cls_sistema_separado();
        cls_credito cls_Credito = new cls_credito();
        cls_empresa cls_Empresa = new cls_empresa();
        cls_venta cls_Venta = new cls_venta();
        cls_reporte_cotizacion cls_Reporte_Cotizacion = new cls_reporte_cotizacion();
        cls_orden_servicio cls_Orden_servicio = new cls_orden_servicio();

        DataTable v_dt;
        DataTable v_dt_2;
        DataTable v_dt_3;
        DataRow v_row2;
        DataRow v_row;
        DataRow v_row3;
        int v_contador = 0;
        bool v_existe;
        float v_cantidad = 0;
        int v_validado = 0;
        string v_UM = "UND";
        bool v_ok;
        int num_domicilio;
        int num_sistema_separado;
        int num_Credito;
        int Vendidos = 0;
        int Error = 0;
        int Codigo_cliente;
        bool v_confirmacion;
        bool v_confirmacion2;
        string codigoSucursal = "";
        string NombreSucursal = "";
        public string Usuario { get; set; }

        //getter and setter
        public string DNI { get; set; }
        public string Celular { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mesajero { get; set; }
        public string valor_domicilio { get; set; }
        public bool v_domicilio { get; set; }
        public bool v_sistema_separado { get; set; }
        public bool v_credito { get; set; }
        public DataTable v_dt_Permi { get; set; }
        public string cotizacion { get; set; }
        public DataTable v_dt_cotizacion { get; set; }
        public string PorcentajeDescuento { get; set; }
        public string ValorDescuento { get; set; }
        public string vl_Cliente { get; set; }
        public frm_venta()
        {
            InitializeComponent();
            MensajeInformativoBotones();
            timer1.Enabled = true;
            cbx_dato_busqueda.SelectedIndex = 0;
        }

        private void frm_venta_Load(object sender, EventArgs e)
        {
            foreach (DataRow rows in v_dt_Permi.Rows)
            {
                if (rows["Modulo"].ToString() == "VENTA")
                {
                    switch (rows["Permiso"].ToString())
                    {
                        case "descuento":
                            btn_descuento.Enabled = true;
                            break;
                        case "quitar_todo":
                            btn_quitar_todo.Enabled = true;
                            break;
                        case "quitar_uno":
                            btn_quitar.Enabled = true;
                            break;
                        case "consultas":
                            btn_consultas.Enabled = true;
                            break;
                        case "agregar_producto":
                            btn_producto.Enabled = true;
                            break;
                        case "agregar_cliente":
                            btn_cliente.Enabled = true;
                            break;
                        case "domicilio":
                            btn_domicilio.Enabled = true;
                            break;
                        case "separado":
                            btn_separado.Enabled = true;
                            break;
                        case "Cotizacion":
                            btn_cotizacion.Enabled = true;
                            break;
                        case "Credito":
                            btn_credito.Enabled = true;
                            break;
                        case "FechaFactura":
                            dtp_fecha_factura.Enabled = true;
                            break;
                    }
                }
            }
            if (cotizacion != null)
            {
                VerificarCaja();
                if (v_confirmacion == true)
                {
                    mtd_buscar_producto_cotizacion(cotizacion);
                    mtd_calculo_pago();
                }
                mtd_carga_cliente(txt_cliente.Text, codigoSucursal, NombreSucursal);
            }
        }
        //Metodos
        public void MensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar");
            Botones.SetToolTip(btn_cliente, "Agregar nuevo cliente");
            Botones.SetToolTip(btn_producto, "Agregar nuevo producto");
            Botones.SetToolTip(btn_consultas, "Consultas");
            Botones.SetToolTip(btn_descuento, "Descuentos");
            Botones.SetToolTip(btn_quitar, "Quitar");
            Botones.SetToolTip(btn_quitar_todo, "Quitar todo");
            Botones.SetToolTip(btn_guardar, "Guardar");
            Botones.SetToolTip(btn_buscar_cliente, "Buscar cliente");
            Botones.SetToolTip(btn_domicilio, "Domicilio");
            Botones.SetToolTip(btn_separado, "Separado");
            Botones.SetToolTip(btn_cotizacion, "Cotizacion");
            Botones.SetToolTip(btn_orden_servicio, "Orden de servicio");
            Botones.SetToolTip(btn_credito, "Credito");            
        }
        private void mtd_agregar_um(string UM)
        {
            v_UM = UM;
        }
        frm_ayuda frm_Ayuda;
        private void mtd_dato_venta(string Item)
        {
            errorProvider.Clear();
            cls_Producto.v_tipo_busqueda = "Buscar_data_producto_exacto_item";
            int Items = Convert.ToInt32(Item);
            cls_Producto.Item = Items.ToString();
            v_dt = cls_Producto.mtd_consultar_producto();
            if (v_dt.Rows.Count > 0)
            {
                v_existe = false;
                v_cantidad = 1;
                v_row = v_dt.Rows[0];
                v_UM = "UND";

                if (v_row["ModoVenta"].ToString() == "Pesaje" || v_row["ModoVenta"].ToString() == "Multi" || v_row["ModoVenta"].ToString() == "Desechable")
                {
                    frm_modo_venta frm_Modo_venta = new frm_modo_venta();
                    frm_Modo_venta.UM = v_row["Nombre_Unidad_medida"].ToString();
                    frm_Modo_venta.v_modo_venta = v_row["ModoVenta"].ToString();
                    frm_Modo_venta.Enviainfo += new frm_modo_venta.EnviarInfo(mtd_agregar_um);
                    frm_Modo_venta.ShowDialog();
                }

                if (v_UM != "")
                {
                    //Acomular productos existentes
                    //foreach (DataGridViewRow row in dtg_venta.Rows)
                    //{
                    //    if (Convert.ToInt32(row.Cells["cl_item"].Value) == Convert.ToInt32(v_row["Item"]) &&
                    //        row.Cells["cl_um"].Value.ToString() == v_UM)
                    //    {
                    //        v_cantidad = float.Parse(row.Cells["cl_cantidad"].Value.ToString()) + 1;
                    //        row.Cells["cl_cantidad"].Value = v_cantidad.ToString();
                    //        row.Cells["cl_referencia"].Value = v_row["Referencia"];
                    //        row.Cells["cl_codigo_barras"].Value = v_row["CodigoBarras"];
                    //        row.Cells["cl_nombre"].Value = v_row["Nombre"];
                    //        v_existe = true;
                    //    }
                    //}

                    if (!v_existe)
                    {
                        dtg_venta.Rows.Add(1);
                        v_contador = dtg_venta.Rows.Count;
                        dtg_venta.Rows[v_contador - 1].Cells["cl_item"].Value = string.Format("{0:0000}", v_row["Item"]);
                        dtg_venta.Rows[v_contador - 1].Cells["cl_referencia"].Value = v_row["Referencia"];
                        dtg_venta.Rows[v_contador - 1].Cells["cl_codigo_barras"].Value = v_row["CodigoBarras"];
                        dtg_venta.Rows[v_contador - 1].Cells["cl_nombre"].Value = v_row["Nombre"];
                        dtg_venta.Rows[v_contador - 1].Cells["cl_Cantidad"].Value = "1";
                        double precio = 0;
                        switch (v_UM)
                        {
                            case "UND":
                                precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                break;
                            case "UND P":
                                precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                break;
                            case "UND D":
                                precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                break;
                            case "Sobre":
                                precio = Convert.ToDouble(v_row["ValorSobre"]);
                                break;
                            case "Caja":
                                precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                break;
                            case "Bulto":
                                precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                break;
                            case "Bolsa":
                                precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                break;
                            default:
                                precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                break;
                        }
                        dtg_venta.Rows[v_contador - 1].Cells["cl_precio"].Value = precio.ToString("N");
                        dtg_venta.Rows[v_contador - 1].Cells["cl_um"].Value = v_UM;
                        dtg_venta.Rows[v_contador - 1].Cells["cl_descuento"].Value = "0";
                        dtg_venta.Rows[v_contador - 1].Cells["cl_valor_descuento"].Value = "0";
                        dtg_venta.Rows[v_contador - 1].Cells["cl_total"].Value = "0";
                        dtg_venta.Rows[v_contador - 1].Cells["cl_modo_venta"].Value = v_row["ModoVenta"];
                        dtg_venta.Rows[v_contador - 1].Cells["cl_proveedor"].Value = v_row["Proveedor"];
                        dtg_venta.Rows[v_contador - 1].Cells["cl_iva"].Value = v_row["IVA"];
                        dtg_venta.Rows[v_contador - 1].Cells["cl_desc_proveedor"].Value = v_row["DescuentoProveedor"];
                        dtg_venta.Rows[v_contador - 1].Cells["cl_subCantidad"].Value = v_row["Subcantidad"];
                        dtg_venta.Rows[v_contador - 1].Cells["cl_sobre"].Value = v_row["Sobres"];
                        double Costo = 0;
                        switch (v_UM)
                        {
                            case "UND":
                                Costo = Convert.ToDouble(v_row["Costo"]);
                                break;
                            case "UND P":
                                //Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["Sobres"]);
                                Costo = Costo / Convert.ToDouble(v_row["SubCantidad"]);
                                break;
                            case "UND D":
                                Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                break;
                            case "Sobre":
                                Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["Sobres"]);
                                break;
                            case "Caja":
                                Costo = Convert.ToDouble(v_row["Costo"]);
                                break;
                            case "Bulto":
                                Costo = Convert.ToDouble(v_row["Costo"]);
                                break;
                            case "Bolsa":
                                Costo = Convert.ToDouble(v_row["Costo"]);
                                break;
                            default:
                                Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                break;
                        }
                        dtg_venta.Rows[v_contador - 1].Cells["cl_costo"].Value = Costo.ToString("N");
                    }
                    mtd_calcular_venta();
                    txt_producto.Text = "";
                    mtd_rellenar();                  
                    mtd_calculo_pago();
                }
            }
            else
            {
                errorProvider.SetError(txt_producto, "Producto No existe");
            }         
        }
        private void mtd_buscar_producto()
        {
            errorProvider.Clear();
            cls_Producto.v_tipo_busqueda = "Buscar_data_producto_exacto_venta";
            cls_Producto.v_buscar = txt_producto.Text;
            cls_Producto.v_data_busqueda = cbx_dato_busqueda.Text;
            v_dt = cls_Producto.mtd_consultar_producto();
            if (v_dt.Rows.Count > 0)
            {
                v_UM = "UND";
                v_existe = false;
                v_cantidad = 1;
                v_row = v_dt.Rows[0];
                cls_Producto.Item = v_row["Item"].ToString();
                v_dt_3 = cls_Producto.mtd_consultar_stock_producto();
                v_row3 = v_dt_3.Rows[0];
                DataTable v_dt_2;
                bool ValidaStcok = false;
                cls_parametros cls_Parametros = new cls_parametros();
                v_dt_2 = cls_Parametros.mtd_consultar_parametros();
                foreach (DataRow item in v_dt_2.Rows)
                {
                    if (item["Validar_stock"].ToString() == "SI")
                    {
                        ValidaStcok = true;
                    }
                }
                if (ValidaStcok)
                {
                    if (Convert.ToDouble(v_row3["Cantidad"]) > 0 || Convert.ToDouble(v_row3["SubCantidad"]) > 0 || Convert.ToDouble(v_row3["Sobres"]) > 0)
                    {
                        if (v_row["ModoVenta"].ToString() == "Pesaje" || v_row["ModoVenta"].ToString() == "Multi" || v_row["ModoVenta"].ToString() == "Desechable")
                        {
                            frm_modo_venta frm_Modo_venta = new frm_modo_venta();
                            frm_Modo_venta.UM = v_row["Nombre_Unidad_medida"].ToString();
                            frm_Modo_venta.v_modo_venta = v_row["ModoVenta"].ToString();
                            frm_Modo_venta.Enviainfo += new frm_modo_venta.EnviarInfo(mtd_agregar_um);
                            frm_Modo_venta.ShowDialog();
                        }

                        if (v_UM != "")
                        {
                            if (!v_existe)
                            {
                                dtg_venta.Rows.Add(1);
                                v_contador = dtg_venta.Rows.Count;
                                dtg_venta.Rows[v_contador - 1].Cells["cl_item"].Value = string.Format("{0:0000}", v_row["Item"]);
                                dtg_venta.Rows[v_contador - 1].Cells["cl_referencia"].Value = v_row["Referencia"];
                                dtg_venta.Rows[v_contador - 1].Cells["cl_codigo_barras"].Value = v_row["CodigoBarras"];
                                dtg_venta.Rows[v_contador - 1].Cells["cl_nombre"].Value = v_row["Nombre"];
                                dtg_venta.Rows[v_contador - 1].Cells["cl_Cantidad"].Value = "1";
                                double precio = 0;
                                switch (v_UM)
                                {
                                    case "UND":
                                        precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                        break;
                                    case "UND P":
                                        precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                        break;
                                    case "UND D":
                                        precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                        break;
                                    case "Sobre":
                                        precio = Convert.ToDouble(v_row["ValorSobre"]);
                                        break;
                                    case "Caja":
                                        precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                        break;
                                    case "Bulto":
                                        precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                        break;
                                    case "Bolsa":
                                        precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                        break;
                                    default:
                                        precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                        break;
                                }
                                dtg_venta.Rows[v_contador - 1].Cells["cl_precio"].Value = precio;
                                dtg_venta.Rows[v_contador - 1].Cells["cl_um"].Value = v_UM;
                                dtg_venta.Rows[v_contador - 1].Cells["cl_descuento"].Value = "0";
                                dtg_venta.Rows[v_contador - 1].Cells["cl_valor_descuento"].Value = "0";
                                dtg_venta.Rows[v_contador - 1].Cells["cl_total"].Value = "0";
                                dtg_venta.Rows[v_contador - 1].Cells["cl_modo_venta"].Value = v_row["ModoVenta"];
                                dtg_venta.Rows[v_contador - 1].Cells["cl_proveedor"].Value = v_row["Proveedor"];
                                dtg_venta.Rows[v_contador - 1].Cells["cl_iva"].Value = v_row["IVA"];
                                dtg_venta.Rows[v_contador - 1].Cells["cl_desc_proveedor"].Value = v_row["DescuentoProveedor"];
                                dtg_venta.Rows[v_contador - 1].Cells["cl_subCantidad"].Value = v_row["Subcantidad"];
                                dtg_venta.Rows[v_contador - 1].Cells["cl_sobre"].Value = v_row["Sobres"];
                                double Costo = 0;
                                switch (v_UM)
                                {
                                    case "UND":
                                        Costo = Convert.ToDouble(v_row["Costo"]);
                                        break;
                                    case "UND P":
                                    //Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                    Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["Sobres"]);
                                    Costo = Costo / Convert.ToDouble(v_row["SubCantidad"]);
                                    break;
                                    case "UND D":
                                        Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                        break;
                                    case "Sobre":
                                        Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["Sobres"]);
                                        break;
                                    case "Caja":
                                        Costo = Convert.ToDouble(v_row["Costo"]);
                                        break;
                                    case "Bulto":
                                        Costo = Convert.ToDouble(v_row["Costo"]);
                                        break;
                                    case "Bolsa":
                                        Costo = Convert.ToDouble(v_row["Costo"]);
                                        break;
                                    default:
                                        Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                        break;
                                }
                                dtg_venta.Rows[v_contador - 1].Cells["cl_costo"].Value = Costo.ToString("N");
                            }

                            mtd_calcular_venta();
                            txt_producto.Text = "";
                            mtd_rellenar();
                            mtd_calculo_pago();
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txt_producto, "Sin existencias, Stock en cero (0)");
                    }
                }
                else
                {
                    if (v_row["ModoVenta"].ToString() == "Pesaje" || v_row["ModoVenta"].ToString() == "Multi" || v_row["ModoVenta"].ToString() == "Desechable")
                    {
                        frm_modo_venta frm_Modo_venta = new frm_modo_venta();
                        frm_Modo_venta.UM = v_row["Nombre_Unidad_medida"].ToString();
                        frm_Modo_venta.v_modo_venta = v_row["ModoVenta"].ToString();
                        frm_Modo_venta.Enviainfo += new frm_modo_venta.EnviarInfo(mtd_agregar_um);
                        frm_Modo_venta.ShowDialog();
                    }

                    if (v_UM != "")
                    {
                        if (!v_existe)
                        {
                            dtg_venta.Rows.Add(1);
                            v_contador = dtg_venta.Rows.Count;
                            dtg_venta.Rows[v_contador - 1].Cells["cl_item"].Value = string.Format("{0:0000}", v_row["Item"]);
                            dtg_venta.Rows[v_contador - 1].Cells["cl_referencia"].Value = v_row["Referencia"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_codigo_barras"].Value = v_row["CodigoBarras"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_nombre"].Value = v_row["Nombre"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_Cantidad"].Value = "1";
                            double precio = 0;
                            switch (v_UM)
                            {
                                case "UND":
                                    precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                    break;
                                case "UND P":
                                    precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                    break;
                                case "UND D":
                                    precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                    break;
                                case "Sobre":
                                    precio = Convert.ToDouble(v_row["ValorSobre"]);
                                    break;
                                case "Caja":
                                    precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                    break;
                                case "Bulto":
                                    precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                    break;
                                case "Bolsa":
                                    precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                    break;
                                default:
                                    precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                    break;
                            }
                            dtg_venta.Rows[v_contador - 1].Cells["cl_precio"].Value = precio;
                            dtg_venta.Rows[v_contador - 1].Cells["cl_um"].Value = v_UM;
                            dtg_venta.Rows[v_contador - 1].Cells["cl_descuento"].Value = "0";
                            dtg_venta.Rows[v_contador - 1].Cells["cl_valor_descuento"].Value = "0";
                            dtg_venta.Rows[v_contador - 1].Cells["cl_total"].Value = "0";
                            dtg_venta.Rows[v_contador - 1].Cells["cl_modo_venta"].Value = v_row["ModoVenta"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_proveedor"].Value = v_row["Proveedor"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_iva"].Value = v_row["IVA"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_desc_proveedor"].Value = v_row["DescuentoProveedor"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_subCantidad"].Value = v_row["Subcantidad"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_sobre"].Value = v_row["Sobres"];
                            double Costo = 0;
                            switch (v_UM)
                            {
                                case "UND":
                                    Costo = Convert.ToDouble(v_row["Costo"]);
                                    break;
                                case "UND P":
                                    //Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                    Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["Sobres"]);
                                    Costo = Costo / Convert.ToDouble(v_row["SubCantidad"]);
                                    break;
                                case "UND D":
                                    Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                    break;
                                case "Sobre":
                                    Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["Sobres"]);
                                    break;
                                case "Caja":
                                    Costo = Convert.ToDouble(v_row["Costo"]);
                                    break;
                                case "Bulto":
                                    Costo = Convert.ToDouble(v_row["Costo"]);
                                    break;
                                case "Bolsa":
                                    Costo = Convert.ToDouble(v_row["Costo"]);
                                    break;
                                default:
                                    Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                    break;
                            }
                            dtg_venta.Rows[v_contador - 1].Cells["cl_costo"].Value = Costo.ToString("N");
                        }

                        mtd_calcular_venta();
                        txt_producto.Text = "";
                        mtd_rellenar();
                        mtd_calculo_pago();
                    }
                }
            }
            else
            {
                errorProvider.SetError(txt_producto, "Producto No existe");
            }
        }

        private void mtd_buscar_producto_cotizacion(string vl_cotizacion)
        {         
            errorProvider.Clear();
            cls_Producto.v_tipo_busqueda = "Buscar_data_producto_exacto_venta";
            foreach (DataRow rows in v_dt_cotizacion.Rows)
            {
                cls_Producto.v_buscar = rows["Item"].ToString();
                v_dt = cls_Producto.mtd_consultar_producto();

                if (v_dt.Rows.Count > 0)
                {
                    cls_Producto.Cotizacion = vl_cotizacion;
                    v_UM = "UND";
                    v_existe = false;
                    v_cantidad = 1;
                    v_row = v_dt.Rows[0];

                    if (v_row["ModoVenta"].ToString() == "Pesaje" || v_row["ModoVenta"].ToString() == "Multi" || v_row["ModoVenta"].ToString() == "Desechable")
                    {
                        frm_modo_venta frm_Modo_venta = new frm_modo_venta();
                        frm_Modo_venta.UM = v_row["Nombre_Unidad_medida"].ToString();
                        frm_Modo_venta.v_modo_venta = v_row["ModoVenta"].ToString();
                        frm_Modo_venta.Enviainfo += new frm_modo_venta.EnviarInfo(mtd_agregar_um);
                        frm_Modo_venta.ShowDialog();
                    }

                    if (v_UM != "")
                    {                        
                        if (!v_existe)
                        {
                            dtg_venta.Rows.Add(1);
                            v_contador = dtg_venta.Rows.Count;
                            dtg_venta.Rows[v_contador - 1].Cells["cl_item"].Value = string.Format("{0:0000}", v_row["Item"]);
                            dtg_venta.Rows[v_contador - 1].Cells["cl_referencia"].Value = v_row["Referencia"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_codigo_barras"].Value = v_row["CodigoBarras"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_nombre"].Value = v_row["Nombre"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_Cantidad"].Value = "1";
                            double precio = 0;
                            switch (v_UM)
                            {
                                case "UND":
                                    precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                    break;
                                case "UND P":
                                    precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                    break;
                                case "UND D":
                                    precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                    break;
                                case "Sobre":
                                    precio = Convert.ToDouble(v_row["ValorSobre"]);
                                    break;
                                case "Caja":
                                    precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                    break;
                                case "Bulto":
                                    precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                    break;
                                case "Bolsa":
                                    precio = Convert.ToDouble(v_row["PrecioVenta"]);
                                    break;
                                default:
                                    precio = Convert.ToDouble(v_row["ValorSubcantidad"]);
                                    break;
                            }
                            dtg_venta.Rows[v_contador - 1].Cells["cl_precio"].Value = precio.ToString("N");
                            dtg_venta.Rows[v_contador - 1].Cells["cl_um"].Value = v_UM;
                            dtg_venta.Rows[v_contador - 1].Cells["cl_descuento"].Value = PorcentajeDescuento;
                            dtg_venta.Rows[v_contador - 1].Cells["cl_valor_descuento"].Value = 0;
                            dtg_venta.Rows[v_contador - 1].Cells["cl_total"].Value = "0";
                            dtg_venta.Rows[v_contador - 1].Cells["cl_modo_venta"].Value = v_row["ModoVenta"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_proveedor"].Value = v_row["Proveedor"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_iva"].Value = v_row["IVA"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_desc_proveedor"].Value = v_row["DescuentoProveedor"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_subCantidad"].Value = v_row["Subcantidad"];
                            dtg_venta.Rows[v_contador - 1].Cells["cl_sobre"].Value = v_row["Sobres"];
                            double Costo = 0;
                            switch (v_UM)
                            {
                                case "UND":
                                    Costo = Convert.ToDouble(v_row["Costo"]);
                                    break;
                                case "UND P":
                                    //Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                    Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["Sobres"]);
                                    Costo = Costo / Convert.ToDouble(v_row["SubCantidad"]);
                                    break;
                                case "UND D":
                                    Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                    break;
                                case "Sobre":
                                    Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["Sobres"]);
                                    break;
                                case "Caja":
                                    Costo = Convert.ToDouble(v_row["Costo"]);
                                    break;
                                case "Bulto":
                                    Costo = Convert.ToDouble(v_row["Costo"]);
                                    break;
                                case "Bolsa":
                                    Costo = Convert.ToDouble(v_row["Costo"]);
                                    break;
                                default:
                                    Costo = Convert.ToDouble(v_row["Costo"]) / Convert.ToDouble(v_row["SubCantidad"]);
                                    break;
                            }
                            dtg_venta.Rows[v_contador - 1].Cells["cl_costo"].Value = Costo.ToString("N");
                        }

                        mtd_calcular_venta();
                        txt_producto.Text = "";
                        mtd_rellenar();
                        mtd_calculo_pago();
                    }
                }
                else
                {
                    errorProvider.SetError(txt_producto, "Producto No existe");
                }
            }                  
        }
        private void mtd_rellenar()
        {
            if (txt_debito.Text.Trim() == "")
            {
                txt_debito.Text = "0";
            }
            if (txt_credito.Text.Trim() == "")
            {
                txt_credito.Text = "0";
            }
        }
        private void mtd_aplicar_descuento(string item,string porcj_descuento, string ValorDescuento)
        {
            foreach (DataGridViewRow rows in dtg_venta.SelectedRows)
            {
                if (item == rows.Cells["cl_item"].Value.ToString())
                {
                    rows.Cells["cl_descuento"].Value = porcj_descuento;
                    rows.Cells["cl_valor_descuento"].Value = ValorDescuento;
                }
            }
            mtd_calcular_venta();
        }
        private void mtd_descuentos()
        {
            if (dtg_venta.Rows.Count > 0)
            {
                frm_descuento frm_Descuento = new frm_descuento();
                frm_Descuento.descuento += new frm_descuento.EnviaDescuento(mtd_aplicar_descuento);
                foreach (DataGridViewRow rows in dtg_venta.SelectedRows)
                {
                    frm_Descuento.lbl_item.Text = rows.Cells["cl_item"].Value.ToString();
                    frm_Descuento.lbl_referencia.Text = rows.Cells["cl_referencia"].Value.ToString();
                    frm_Descuento.lbl_codigo_barras.Text = rows.Cells["cl_codigo_barras"].Value.ToString();
                    frm_Descuento.lbl_nombre.Text = rows.Cells["cl_nombre"].Value.ToString();
                    frm_Descuento.lbl_cantidad.Text = rows.Cells["cl_cantidad"].Value.ToString();
                    double costo = Convert.ToDouble(rows.Cells["cl_costo"].Value.ToString());
                    costo = costo * Convert.ToDouble(rows.Cells["cl_cantidad"].Value);
                    frm_Descuento.lbl_costo.Text = costo.ToString("N");
                    double precio = Convert.ToDouble(rows.Cells["cl_precio"].Value);
                    precio = precio  * Convert.ToDouble(rows.Cells["cl_cantidad"].Value);
                    frm_Descuento.lbl_precio_venta.Text = precio.ToString("N");
                }

                frm_Descuento.ShowDialog();
            }
        }
        private void mtd_calcular_venta()
        {
            CalcularIVAEMOS();
            double Venta = 0;
            double subtotal = 0;
            double descuento = 0;
            double Total = 0;
            foreach (DataGridViewRow rows in dtg_venta.Rows)
            {
                Venta = (Convert.ToDouble(rows.Cells["cl_cantidad"].Value) * Convert.ToDouble(rows.Cells["cl_precio"].Value));
                descuento = Venta * (Convert.ToDouble(rows.Cells["cl_descuento"].Value) / 100);
                subtotal = Venta - descuento;

                //rows.Cells["cl_valor_descuento"].Value = descuento.ToString();
                rows.Cells["cl_total"].Value = subtotal.ToString();
                Total += subtotal;
            }

            lbl_total.Text = Total.ToString("N");
        }
        
        private void mtd_carga_cliente(string dni,string Codsu,string Nomsu)
        {
            codigoSucursal = Codsu;
            NombreSucursal = Nomsu;
            txt_cliente.Text = dni;
            errorProvider.Clear();
            v_validado = 0;
            Codigo_cliente = 0;

            if (txt_cliente.Text.Trim() != "" && txt_cliente.Text.Trim() != "Cliente")
            {
                cls_Cliente.v_tipo_busqueda = "validacion";
                cls_Cliente.v_buscar = txt_cliente.Text;
                v_dt = cls_Cliente.mtd_consultar_cliente();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    lbl_nombre_cliente.Text = v_row["Nombre"].ToString() + " - " + codigoSucursal + " - "+ NombreSucursal;
                    Codigo_cliente = Convert.ToInt32(v_row["Codigo"]);
                }
                else
                {
                    lbl_nombre_cliente.Text = "--";
                    errorProvider.SetError(txt_cliente, "Cliente no existe");
                    v_validado++;
                }
            }
            else
            {
                lbl_nombre_cliente.Text = "--";
            }
        }
        private void mtd_validar()
        {
            v_validado = 0;
            errorProvider.Clear();
            mtd_carga_cliente(txt_cliente.Text,codigoSucursal,NombreSucursal);
            if (txt_efectivo.Text.Trim() == "")
            {
                errorProvider.SetError(txt_efectivo, "Ingrese Efectivo");
                v_validado++;
            }
            if (txt_debito.Text.Trim() == "")
            {
                errorProvider.SetError(txt_debito, "Ingrese Debito");
                v_validado++;
            }
            if (txt_credito.Text.Trim() == "")
            {
                errorProvider.SetError(txt_credito, "Ingrese credito");
                v_validado++;
            }  
        }
        private void mtd_guardar()
        {
            ///////////////////////////////////////////////////////////////////
            Vendidos = 0;
            Error = 0;
            double ConsDocumento = 0;
            string Documento = "";
            cls_Venta.Usuario = Usuario;
            if (v_domicilio == true)
            {
                 ConsDocumento = 0;
                 Documento = "";
                v_dt = cls_Empresa.mtd_consultar_Empresa();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    ConsDocumento = Convert.ToDouble(v_row["ConsecutivoActual"]);
                    ConsDocumento++;
                    Documento = v_row["NomDoc"].ToString();
                    cls_Venta.Registro = "Domicilio";

                    foreach (DataGridViewRow rows in dtg_venta.Rows)
                    {
                        // fecha asignada por el cliente
                        DateTime FechaFactura = dtp_fecha_factura.Value;
                        cls_Venta.Fecha = DateTime.Now.ToString();
                        //cls_Venta.Fecha = FechaFactura.ToString();
                        cls_Venta.NombreDocumento = Documento;
                        cls_Venta.ConsecutivoDocumento = ConsDocumento.ToString();
                        cls_Venta.Producto = Convert.ToInt32(rows.Cells["cl_item"].Value);
                        cls_Venta.ModoVenta = rows.Cells["cl_modo_venta"].Value.ToString();
                        cls_Venta.UM = rows.Cells["cl_UM"].Value.ToString();
                        float Cantidad = 0;
                        float Base = 0;
                        float Division = 0;
                        switch (rows.Cells["cl_modo_venta"].Value.ToString())
                        {
                            case "Unidad":
                                Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                break;
                            case "Multi":
                                if (rows.Cells["cl_UM"].Value.ToString() == "UND P")
                                {
                                    Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()) * float.Parse(rows.Cells["cl_sobre"].Value.ToString()));
                                    Division = 1 / Base;
                                    Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                }
                                if (rows.Cells["cl_UM"].Value.ToString() == "Sobre")
                                {
                                    Cantidad = (1 / float.Parse(rows.Cells["cl_sobre"].Value.ToString())) * float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }
                                if (rows.Cells["cl_UM"].Value.ToString() == "Caja")
                                {
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }
                                break;
                            case "Pesaje":
                                if (rows.Cells["cl_UM"].Value.ToString() != "Bulto")
                                {
                                    Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                    Division = 1 / Base;
                                    Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                }
                                else
                                {
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }

                                break;
                            case "Desechable":
                                if (rows.Cells["cl_UM"].Value.ToString() != "Bolsa")
                                {
                                    Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                    Division = 1 / Base;
                                    Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                }
                                else
                                {
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }
                                break;
                            case "Queso":
                                Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                break;
                        }

                       
                        cls_Venta.Cantidad = Cantidad;
                        cls_Venta.Costo = Convert.ToDouble(rows.Cells["cl_costo"].Value);
                        cls_Venta.PrecioVenta = Convert.ToDouble(rows.Cells["cl_precio"].Value);
                        cls_Venta.Descuento = float.Parse(rows.Cells["cl_descuento"].Value.ToString());
                        cls_Venta.Efectivo = 0;
                        cls_Venta.Tdebito = 0;
                        cls_Venta.Tcredito = 0;
                        cls_Venta.NumBaucherDebito = "";
                        cls_Venta.NumBaucherCredito = "";
                        cls_Venta.Cambio = 0;
                        cls_Venta.Total = Convert.ToDouble(lbl_total.Text);
                        cls_Venta.Proveedor = rows.Cells["cl_proveedor"].Value.ToString();
                        cls_Venta.IVA = Convert.ToInt32(rows.Cells["cl_iva"].Value);
                        cls_Venta.DescuentoProveedor = rows.Cells["cl_desc_proveedor"].Value.ToString();
                        cls_Venta.Nota = txt_nota.Text;
                        cls_Venta.sucursal = codigoSucursal;
                        if (txt_cliente.Text == "")
                        {
                            cls_Venta.Cliente = 1;
                        }
                        else
                        {
                            cls_Venta.Cliente = Codigo_cliente;
                        }
                        cls_Venta.Domicilio = num_domicilio;

                        v_ok = cls_Venta.mtd_registrar();
                        if (v_ok)
                        {
                            Vendidos++;
                        }
                        else
                        {
                            Error++;
                        }
                    }
                    frm_msg frm_Msg = new frm_msg();
                    frm_Msg.pnl_centro.BackColor = Color.White;
                    if (Error > 0)
                    {
                        frm_Msg.lbl_titulo.Text = "ERROR";
                        frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                    }                   
                    frm_Msg.txt_mensaje.Text = "Productos vendidos: " + Vendidos + ", Errores: " + Error;
                    frm_Msg.ShowDialog();
                    txt_producto.Focus();
                    dtg_venta.Rows.Clear();
                    txt_efectivo.Text = "";
                    txt_debito.Text = "0";
                    txt_credito.Text = "0";
                    txt_num_baucher_debit.Text = "Numero baucher";
                    txt_num_baucher_debit.ForeColor = Color.Gray;
                    txt_num_baucher_credito.Text = "Numero baucher";
                    txt_num_baucher_credito.ForeColor = Color.Gray;
                    lbl_cambio.Text = "0";
                    lbl_total.Text = "0";
                    txt_cliente.Text = "";
                    lbl_nombre_cliente.Text = "--";
                    txt_nota.Text = "";
                }
            }
            else if (v_sistema_separado == true)
            {
                 ConsDocumento = 0;
                 Documento = "";
                v_dt = cls_Empresa.mtd_consultar_Empresa();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    ConsDocumento = Convert.ToDouble(v_row["ConsecutivoActual"]);
                    ConsDocumento++;
                    Documento = v_row["NomDoc"].ToString();
                    cls_Venta.Registro = "SistemaSeparado";

                    foreach (DataGridViewRow rows in dtg_venta.Rows)
                    {
                        // fecha asignada por el cliente
                        DateTime FechaFactura = dtp_fecha_factura.Value;
                        //cls_Venta.Fecha = DateTime.Now.ToString();
                        cls_Venta.Fecha = FechaFactura.ToString();
                        cls_Venta.NombreDocumento = Documento;
                        cls_Venta.ConsecutivoDocumento = ConsDocumento.ToString();
                        cls_Venta.Producto = Convert.ToInt32(rows.Cells["cl_item"].Value);
                        cls_Venta.ModoVenta = rows.Cells["cl_modo_venta"].Value.ToString();
                        cls_Venta.UM = rows.Cells["cl_UM"].Value.ToString();
                        float Cantidad = 0;
                        float Base = 0;
                        float Division = 0;
                        switch (rows.Cells["cl_modo_venta"].Value.ToString())
                        {
                            case "Unidad":
                                Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                break;
                            case "Multi":
                                if (rows.Cells["cl_UM"].Value.ToString() == "UND P")
                                {
                                    Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()) * float.Parse(rows.Cells["cl_sobre"].Value.ToString()));
                                    Division = 1 / Base;
                                    Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                }
                                if (rows.Cells["cl_UM"].Value.ToString() == "Sobre")
                                {
                                    Cantidad = (1 / float.Parse(rows.Cells["cl_sobre"].Value.ToString())) * float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }
                                if (rows.Cells["cl_UM"].Value.ToString() == "Caja")
                                {
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }
                                break;
                            case "Pesaje":
                                if (rows.Cells["cl_UM"].Value.ToString() != "Bulto")
                                {
                                    Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                    Division = 1 / Base;
                                    Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                }
                                else
                                {
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }

                                break;
                            case "Desechable":
                                if (rows.Cells["cl_UM"].Value.ToString() != "Bolsa")
                                {
                                    Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                    Division = 1 / Base;
                                    Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                }
                                else
                                {
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }
                                break;
                            case "Queso":
                                Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                break;
                        }

                        cls_Venta.Cantidad = Cantidad;
                        cls_Venta.Costo = Convert.ToDouble(rows.Cells["cl_costo"].Value);
                        cls_Venta.PrecioVenta = Convert.ToDouble(rows.Cells["cl_precio"].Value);
                        cls_Venta.Descuento = float.Parse(rows.Cells["cl_descuento"].Value.ToString());
                        cls_Venta.Efectivo = 0;
                        cls_Venta.Tdebito = 0;
                        cls_Venta.Tcredito = 0;
                        cls_Venta.NumBaucherDebito = "";
                        cls_Venta.NumBaucherCredito = "";
                        cls_Venta.Cambio = 0;
                        cls_Venta.Total = Convert.ToDouble(lbl_total.Text);
                        cls_Venta.Proveedor = rows.Cells["cl_proveedor"].Value.ToString();
                        cls_Venta.IVA = Convert.ToInt32(rows.Cells["cl_iva"].Value);
                        cls_Venta.DescuentoProveedor = rows.Cells["cl_desc_proveedor"].Value.ToString();
                        cls_Venta.Nota = txt_nota.Text;
                        cls_Venta.sucursal = codigoSucursal;
                        if (txt_cliente.Text == "")
                        {
                            cls_Venta.Cliente = 1;
                        }
                        else
                        {
                            cls_Venta.Cliente = Codigo_cliente;
                        }
                        cls_Venta.SistemaSeparado = num_sistema_separado;

                        v_ok = cls_Venta.mtd_registrar();
                        if (v_ok)
                        {
                            Vendidos++;
                        }
                        else
                        {
                            Error++;
                        }
                    }
                    frm_msg frm_Msg = new frm_msg();
                    frm_Msg.pnl_centro.BackColor = Color.White;
                    if (Error > 0)
                    {
                        frm_Msg.lbl_titulo.Text = "ERROR";
                        frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                    }
                    frm_Msg.txt_mensaje.Text = "Productos vendidos: " + Vendidos + ", Errores: " + Error;
                    frm_Msg.ShowDialog();
                    txt_producto.Focus();
                    dtg_venta.Rows.Clear();
                    txt_efectivo.Text = "";
                    txt_debito.Text = "0";
                    txt_credito.Text = "0";
                    txt_num_baucher_debit.Text = "Numero baucher";
                    txt_num_baucher_debit.ForeColor = Color.Gray;
                    txt_num_baucher_credito.Text = "Numero baucher";
                    txt_num_baucher_credito.ForeColor = Color.Gray;
                    lbl_cambio.Text = "0";
                    lbl_total.Text = "0";
                    txt_cliente.Text = "";
                    lbl_nombre_cliente.Text = "--";
                    txt_nota.Text = "";
                }
            }
            else if (v_credito == true)
            {
                ConsDocumento = 0;
                Documento = "";
                v_dt = cls_Empresa.mtd_consultar_Empresa();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    ConsDocumento = Convert.ToDouble(v_row["ConsecutivoActual"]);
                    ConsDocumento++;
                    Documento = v_row["NomDoc"].ToString();
                    cls_Venta.Registro = "Credito";

                    foreach (DataGridViewRow rows in dtg_venta.Rows)
                    {
                        // fecha asignada por el cliente
                        DateTime FechaFactura = dtp_fecha_factura.Value;
                        //cls_Venta.Fecha = DateTime.Now.ToString();
                        cls_Venta.Fecha = FechaFactura.ToString();
                        cls_Venta.NombreDocumento = Documento;
                        cls_Venta.ConsecutivoDocumento = ConsDocumento.ToString();
                        cls_Venta.Producto = Convert.ToInt32(rows.Cells["cl_item"].Value);
                        cls_Venta.ModoVenta = rows.Cells["cl_modo_venta"].Value.ToString();
                        cls_Venta.UM = rows.Cells["cl_UM"].Value.ToString();
                        float Cantidad = 0;
                        float Base = 0;
                        float Division = 0;
                        switch (rows.Cells["cl_modo_venta"].Value.ToString())
                        {
                            case "Unidad":
                                Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                break;
                            case "Multi":
                                if (rows.Cells["cl_UM"].Value.ToString() == "UND P")
                                {
                                    Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()) * float.Parse(rows.Cells["cl_sobre"].Value.ToString()));
                                    Division = 1 / Base;
                                    Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                }
                                if (rows.Cells["cl_UM"].Value.ToString() == "Sobre")
                                {
                                    Cantidad = (1 / float.Parse(rows.Cells["cl_sobre"].Value.ToString())) * float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }
                                if (rows.Cells["cl_UM"].Value.ToString() == "Caja")
                                {
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }
                                break;
                            case "Pesaje":
                                if (rows.Cells["cl_UM"].Value.ToString() != "Bulto")
                                {
                                    Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                    Division = 1 / Base;
                                    Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                }
                                else
                                {
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }

                                break;
                            case "Desechable":
                                if (rows.Cells["cl_UM"].Value.ToString() != "Bolsa")
                                {
                                    Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                    Division = 1 / Base;
                                    Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                }
                                else
                                {
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                }
                                break;
                            case "Queso":
                                Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                break;
                        }

                        cls_Venta.Cantidad = Cantidad;
                        cls_Venta.Costo = Convert.ToDouble(rows.Cells["cl_costo"].Value);
                        cls_Venta.PrecioVenta = Convert.ToDouble(rows.Cells["cl_precio"].Value);
                        cls_Venta.Descuento = float.Parse(rows.Cells["cl_descuento"].Value.ToString());
                        cls_Venta.Efectivo = 0;
                        cls_Venta.Tdebito = 0;
                        cls_Venta.Tcredito = 0;
                        cls_Venta.NumBaucherDebito = "";
                        cls_Venta.NumBaucherCredito = "";
                        cls_Venta.Cambio = 0;
                        cls_Venta.Total = Convert.ToDouble(lbl_total.Text);
                        cls_Venta.Proveedor = rows.Cells["cl_proveedor"].Value.ToString();
                        cls_Venta.IVA = Convert.ToInt32(rows.Cells["cl_iva"].Value);
                        cls_Venta.DescuentoProveedor = rows.Cells["cl_desc_proveedor"].Value.ToString();
                        cls_Venta.Nota = txt_nota.Text;
                        cls_Venta.sucursal = codigoSucursal;
                        if (txt_cliente.Text == "")
                        {
                            cls_Venta.Cliente = 1;
                        }
                        else
                        {
                            cls_Venta.Cliente = Codigo_cliente;
                        }
                        cls_Venta.Credito = num_Credito;

                        v_ok = cls_Venta.mtd_registrar();
                        if (v_ok)
                        {
                            Vendidos++;
                        }
                        else
                        {
                            Error++;
                        }
                    }
                    frm_msg frm_Msg = new frm_msg();
                    frm_Msg.pnl_centro.BackColor = Color.White;
                    if (Error > 0)
                    {
                        frm_Msg.lbl_titulo.Text = "ERROR";
                        frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                    }
                    frm_Msg.txt_mensaje.Text = "Productos vendidos: " + Vendidos + ", Errores: " + Error;
                    frm_Msg.ShowDialog();
                    txt_producto.Focus();
                    dtg_venta.Rows.Clear();
                    txt_efectivo.Text = "";
                    txt_debito.Text = "0";
                    txt_credito.Text = "0";
                    txt_num_baucher_debit.Text = "Numero baucher";
                    txt_num_baucher_debit.ForeColor = Color.Gray;
                    txt_num_baucher_credito.Text = "Numero baucher";
                    txt_num_baucher_credito.ForeColor = Color.Gray;
                    lbl_cambio.Text = "0";
                    lbl_total.Text = "0";
                    txt_cliente.Text = "";
                    lbl_nombre_cliente.Text = "--";
                    txt_nota.Text = "";
                }
            }
            else
            {
                mtd_validar();
                if (v_validado == 0)
                {
                     ConsDocumento = 0;
                     Documento = "";
                    v_dt = cls_Empresa.mtd_consultar_Empresa();
                    if (v_dt.Rows.Count > 0)
                    {
                        v_row = v_dt.Rows[0];
                        ConsDocumento = Convert.ToDouble(v_row["ConsecutivoActual"]);
                        ConsDocumento++;
                        Documento = v_row["NomDoc"].ToString();
                        cls_Venta.Registro = "";

                        foreach (DataGridViewRow rows in dtg_venta.Rows)
                        {

                            // fecha asignada por el cliente
                            DateTime FechaFactura = dtp_fecha_factura.Value;
                            //cls_Venta.Fecha = DateTime.Now.ToString();
                            cls_Venta.Fecha = FechaFactura.ToString();
                            cls_Venta.NombreDocumento = Documento;
                            cls_Venta.ConsecutivoDocumento = ConsDocumento.ToString();
                            cls_Venta.Producto = Convert.ToInt32(rows.Cells["cl_item"].Value);
                            cls_Venta.ModoVenta = rows.Cells["cl_modo_venta"].Value.ToString();
                            cls_Venta.UM = rows.Cells["cl_UM"].Value.ToString();
                            float Cantidad = 0;
                            float Base = 0;
                            float Division = 0;
                            switch (rows.Cells["cl_modo_venta"].Value.ToString())
                            {
                                case "Unidad":
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    break;
                                case "Multi":
                                    if (rows.Cells["cl_UM"].Value.ToString() == "UND P")
                                    {
                                        Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()) * float.Parse(rows.Cells["cl_sobre"].Value.ToString()));
                                        Division = 1 / Base;
                                        Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                    }
                                    if (rows.Cells["cl_UM"].Value.ToString() == "Sobre")
                                    {
                                        Cantidad = (1 / float.Parse(rows.Cells["cl_sobre"].Value.ToString())) * float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    }
                                    if (rows.Cells["cl_UM"].Value.ToString() == "Caja")
                                    {
                                        Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    }                                                                   
                                    break;
                                case "Pesaje":
                                    if (rows.Cells["cl_UM"].Value.ToString() != "Bulto")
                                    {
                                        Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                        Division = 1 / Base;
                                        Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                    }
                                    else
                                    {
                                        Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    }
                                   
                                    break;
                                case "Desechable":
                                    if (rows.Cells["cl_UM"].Value.ToString() != "Bolsa")
                                    {
                                        Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                        Division = 1 / Base;
                                        Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                    }
                                    else
                                    {
                                        Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    }                                   
                                    break;
                                case "Queso":
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    break;
                            }
                     
                            cls_Venta.Cantidad = Cantidad;
                            cls_Venta.Costo = Convert.ToDouble(rows.Cells["cl_costo"].Value);
                            cls_Venta.PrecioVenta = Convert.ToDouble(rows.Cells["cl_precio"].Value);
                            cls_Venta.Descuento = float.Parse(rows.Cells["cl_descuento"].Value.ToString());
                            cls_Venta.Efectivo = Convert.ToDouble(txt_efectivo.Text);
                            cls_Venta.Tdebito = Convert.ToDouble(txt_debito.Text);
                            cls_Venta.Tcredito = Convert.ToDouble(txt_credito.Text);
                            if (txt_num_baucher_debit.Text == "Numero baucher")
                            {
                                cls_Venta.NumBaucherDebito = "";
                            }
                            else
                            {
                                cls_Venta.NumBaucherDebito = txt_num_baucher_debit.Text;
                            }
                            if (txt_num_baucher_credito.Text == "Numero baucher")
                            {
                                cls_Venta.NumBaucherCredito = "";
                            }
                            else {
                                cls_Venta.NumBaucherCredito = txt_num_baucher_credito.Text;
                            }                 
                            cls_Venta.Cambio = Convert.ToDouble(lbl_cambio.Text);
                            cls_Venta.Total = Convert.ToDouble(lbl_total.Text);
                            cls_Venta.Proveedor = rows.Cells["cl_proveedor"].Value.ToString();
                            cls_Venta.IVA = Convert.ToInt32(rows.Cells["cl_iva"].Value);
                            cls_Venta.DescuentoProveedor = rows.Cells["cl_desc_proveedor"].Value.ToString();
                            cls_Venta.Nota = txt_nota.Text;
                            cls_Venta.sucursal = codigoSucursal;
                            if (txt_cliente.Text == "")
                            {
                                cls_Venta.Cliente = 1;
                            }
                            else
                            {
                                cls_Venta.Cliente = Codigo_cliente;
                            }

                            v_ok = cls_Venta.mtd_registrar();
                            if (v_ok)
                            {
                                Vendidos++;
                            }
                            else
                            {
                                Error++;
                            }
                        }
                        frm_msg frm_Msg = new frm_msg();
                        frm_Msg.pnl_centro.BackColor = Color.White;
                        if (Error > 0)
                        {
                            frm_Msg.lbl_titulo.Text = "ERROR";
                            frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                        }
                        frm_Msg.txt_mensaje.Text = "Productos vendidos: " + Vendidos + ", Errores: " + Error;
                        frm_Msg.ShowDialog();
                        txt_producto.Focus();
                        dtg_venta.Rows.Clear();
                        txt_efectivo.Text = "";
                        txt_debito.Text = "0";
                        txt_credito.Text = "0";
                        txt_num_baucher_debit.Text = "Numero baucher";
                        txt_num_baucher_debit.ForeColor = Color.Gray;
                        txt_num_baucher_credito.Text = "Numero baucher";
                        txt_num_baucher_credito.ForeColor = Color.Gray;
                        lbl_cambio.Text = "0";
                        lbl_total.Text = "0";
                        txt_cliente.Text = "";
                        lbl_nombre_cliente.Text = "--";
                        txt_nota.Text = "";
                    }
                }
            }

            //verificar si imprimir o preguntar
            DataTable v_dt_2;
            bool PreuntaImprimir = false;
            cls_parametros cls_Parametros = new cls_parametros();
            v_dt_2 = cls_Parametros.mtd_consultar_parametros();
            foreach (DataRow item in v_dt_2.Rows)
            {
                if (item["PreuntaImprimir"].ToString() == "SI")
                {
                    PreuntaImprimir = true;
                }
            }

            //Imprimir ticket
            if (PreuntaImprimir) {
                frm_confirmacion frm_Confirmacion = new frm_confirmacion();
                frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion2);
                frm_Confirmacion.txt_mensaje.Text = "¿Desea imprimir factura?";
                frm_Confirmacion.ShowDialog();
                if (v_confirmacion2 == true)
                {
                    mtd_imprimir(Documento, ConsDocumento.ToString());
                }
                else
                {
                    CrearTicket ticket = new CrearTicket();
                    ticket.AbreCajon();//Para abrir el cajon de dinero.
                }
            }
            else
            {
                mtd_imprimir(Documento, ConsDocumento.ToString());
            }
        }
        private void mtd_confirmacion2(bool confirma)
        {
            v_confirmacion2 = confirma;
        }
        private void mtd_imprimir_factura_pdf(string Documento,string ConsDocumento) 
        {
        
        }
        private void mtd_calculo_pago()
        {
            CalcularIVAEMOS();
            double efectivo = 0;
            double debito = 0;
            double credito = 0;
            //calcular cambio
            if (txt_efectivo.Text.Trim() != "")
            {
                efectivo = Convert.ToDouble(txt_efectivo.Text);
            }
            if (txt_debito.Text.Trim() != "")
            {
                debito = Convert.ToDouble(txt_debito.Text);
            }
            if (txt_credito.Text.Trim() != "")
            {
                credito = Convert.ToDouble(txt_credito.Text);
            }
            double pago = efectivo + debito + credito;

            double cambio = pago - Convert.ToDouble(lbl_total.Text);
            lbl_cambio.Text = cambio.ToString("N");
            if (cambio < 0)
            {
                lbl_cambio.ForeColor = Color.OrangeRed;
            }
            else
            {
                lbl_cambio.ForeColor = Color.SeaGreen;
            }
        }
        private void mtd_info_domicilio(string dnid, string celulard, string nombred,
        string direcciond, string telefonod, string mensajerod, string valor_domiciliod,string codigoSu)
        {
            DNI = dnid;
            Celular = celulard;
            Nombre = nombred;
            Direccion = direcciond;
            Telefono = telefonod;
            Mesajero = mensajerod;
            valor_domicilio = valor_domiciliod;

            //registro datos domicilio
            cls_Domicilio.Cliente = dnid;
            cls_Domicilio.Celular = celulard;
            cls_Domicilio.Nombre = nombred;
            cls_Domicilio.Direccion = direcciond;
            cls_Domicilio.Telefono = telefonod;
            cls_Domicilio.Mensajero = mensajerod;
            cls_Domicilio.Valor_domicilio = Convert.ToDouble(valor_domicilio);
            cls_Domicilio.Estado = "Pendiente";
            cls_Domicilio.codigoSu = codigoSu;
            codigoSucursal = codigoSu;

            v_ok =  cls_Domicilio.mtd_registrar();
            if (v_ok == true)
            {
                //Consultar numero domicilio
                cls_Domicilio.v_tipo_busqueda = "max codigo";
                v_dt = cls_Domicilio.mtd_consultar_domicilio();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    num_domicilio = Convert.ToInt32(v_row["Codigo"]);
                }
                //registro venta
                v_domicilio = true;
                v_sistema_separado = false;
                v_credito = false;
                mtd_guardar();
            }
        }
        //variables globales para separados
        string clientes_1 = "";
        string NombreCliente = "";
        string valor_1 = "";
        string Abono_inicial_1 = "";
        string  periodo_pago_1 = "";
        string suministrar_1 = "";
        string num_cuotas_1 = "";
        string valor_cuotas_1 = "";
        string f_primer_pago_1 = "";
        string f_vence_1 = "";
        private void mtd_info_separado(string clientes,string nombreCliente, string valor, string Abono_inicial,
        string periodo_pago, string suministrar, string num_cuotas, string valor_cuotas, string f_primer_pago, string f_vence)
        {
             clientes_1 = clientes;
            NombreCliente = nombreCliente;
            valor_1 = valor;
            Abono_inicial_1 = Abono_inicial;
            periodo_pago_1 = periodo_pago;
            suministrar_1 = suministrar;
            num_cuotas_1 = num_cuotas;
            valor_cuotas_1 = valor_cuotas;
            f_primer_pago_1 = f_primer_pago;
            f_vence_1 = f_vence;

            cls_Sistema_separado.Cliente = Convert.ToInt32(clientes);
            cls_Sistema_separado.Valor = Convert.ToDouble(valor);
            cls_Sistema_separado.Abono_inicial = Convert.ToDouble(Abono_inicial);
            cls_Sistema_separado.Periodo_pago = periodo_pago;
            cls_Sistema_separado.Suministrar = suministrar;
            cls_Sistema_separado.Num_cuotas = Convert.ToInt32(num_cuotas);
            cls_Sistema_separado.Valor_cuota = Convert.ToDouble(valor_cuotas);
            cls_Sistema_separado.Fecha_primer_pago = f_primer_pago;
            cls_Sistema_separado.Fecha_vence = f_vence;
            cls_Sistema_separado.Estado = "Pendiente";
            cls_Sistema_separado.Modulo = "Venta";
            cls_Sistema_separado.usuario = this.Usuario;
            v_ok = cls_Sistema_separado.mtd_registrar();
            if (v_ok == true)
            {
                //Consultar numero separado
                cls_Sistema_separado.v_tipo_busqueda = "max codigo";
                v_dt = cls_Sistema_separado.mtd_consultar_sistema_separado();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    num_sistema_separado = Convert.ToInt32(v_row["Codigo"]);
                }
                //Registrar abono inicial 
                cls_Sistema_separado.Valor = Convert.ToDouble(Abono_inicial);
                cls_Sistema_separado.Codigo = num_sistema_separado;
                cls_Sistema_separado.usuario = this.Usuario;
                cls_Sistema_separado.mtd_registrar_abono();

                //registro venta
                v_domicilio = false;
                v_sistema_separado = true;
                v_credito = false;
                mtd_guardar();
            }
        }

        private void mtd_info_Credito(string clientes,string nombreCliente, string valor, string Abono_inicial,
       string periodo_pago, string suministrar, string num_cuotas, string valor_cuotas, string f_primer_pago, string f_vence)
        {
            clientes_1 = clientes;
            valor_1 = valor;
            Abono_inicial_1 = Abono_inicial;
            periodo_pago_1 = periodo_pago;
            suministrar_1 = suministrar;
            num_cuotas_1 = num_cuotas;
            valor_cuotas_1 = valor_cuotas;
            f_primer_pago_1 = f_primer_pago;
            f_vence_1 = f_vence;

            cls_Credito.Cliente = Convert.ToInt32(clientes);
            cls_Credito.Valor = Convert.ToDouble(valor);
            cls_Credito.Abono_inicial = Convert.ToDouble(Abono_inicial);
            cls_Credito.Periodo_pago = periodo_pago;
            cls_Credito.Suministrar = suministrar;
            cls_Credito.Num_cuotas = Convert.ToInt32(num_cuotas);
            cls_Credito.Valor_cuota = Convert.ToDouble(valor_cuotas);
            cls_Credito.Fecha_primer_pago = f_primer_pago;
            cls_Credito.Fecha_vence = f_vence;
            cls_Credito.Estado = "Pendiente";
            cls_Credito.Modulo = "Venta";
            cls_Credito.usuario = this.Usuario;
            v_ok = cls_Credito.mtd_registrar();
            if (v_ok == true)
            {
                //Consultar credito
                cls_Credito.v_tipo_busqueda = "max codigo";
                v_dt = cls_Credito.mtd_consultar_credito();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    num_Credito = Convert.ToInt32(v_row["Codigo"]);
                }
                //Registrar abono inicial 
                cls_Credito.Valor = Convert.ToDouble(Abono_inicial);
                cls_Credito.Codigo = num_Credito;
                cls_Credito.usuario = this.Usuario;
                cls_Credito.mtd_registrar_abono();

                //registro venta
                v_domicilio = false;
                v_sistema_separado = false;
                v_credito = true;
                mtd_guardar();
            }
        }
        private void mtd_imprimir(string NombDoc, string ConsecutivoDoc)
        {
            CrearTicket ticket = new CrearTicket();
            cls_empresa Empres = new cls_empresa();

            ticket.AbreCajon();//Para abrir el cajon de dinero.
            DataRow row;
            DataTable DTEmpresa;
            DTEmpresa = Empres.mtd_consultar_Empresa();
            row = DTEmpresa.Rows[0];
            string NombreImpresora = row["Impresora"].ToString();
            string NumerosCelular = row["Celular"].ToString();
            string dv = CalcularDigitoVerificacion(row["DNI"].ToString());
            //Datos de la cabecera del Ticket.
            ticket.TextoCentro(row["Nombre"].ToString());
            ticket.TextoCentro("NIT:" + row["DNI"] + "-"+ dv);
            ticket.TextoIzquierda("DIREC: " + row["Direccion"] + "");
            ticket.TextoIzquierda("TELEF: " + row["Telefono"] + "");
            ticket.TextoIzquierda("CELUL: " + row["Celular"] + "");
            ticket.TextoIzquierda("EMAIL: " + row["Email"] + "");
            ticket.TextoIzquierda("WEB: " + row["SitioWeb"] + "");
            ticket.TextoIzquierda("FECHA: " + DateTime.Now.ToShortDateString() + "");
            ticket.TextoIzquierda("HORA: " + DateTime.Now.ToShortTimeString());
            ticket.TextoIzquierda("USUARIO: " + Usuario);        
            ///
            DataTable DTVenta;
            cls_Venta.NombreDocumento = NombDoc;
            cls_Venta.ConsecutivoDocumento = ConsecutivoDoc;
            //DTVenta = cls_Venta.mtd_consultar_Ventas_factura();
            cls_Venta.v_buscar = NombDoc + '-' + ConsecutivoDoc;
            DTVenta = cls_Venta.mtd_consultar_dato_impresion();
            row = DTVenta.Rows[0];
            ///
            ticket.TextoIzquierda("FACTURA N. " + row["Factura"].ToString());
            if (v_domicilio == false && v_sistema_separado == false)
            {
                ticket.TextoIzquierda("CLIENTE: " + row["Cliente"].ToString() + "");
            }          
            //ticket.TextoIzquierda("");
            //ticket.lineasAsteriscos();
           
            if (v_domicilio == true)
            {
                ticket.TextoIzquierda("MENSAJERO: " + row["Mensajero"].ToString() + " " + row["NMensajero"].ToString());
                ticket.TextoIzquierda("# DOMICILIO: " + row["CodigoDomicilio"].ToString());
                ticket.TextoIzquierda("CELULAR: " + row["Celular"].ToString());
                ticket.TextoIzquierda("TELEFONO FIJO: " + row["Telefono"].ToString());
                ticket.TextoIzquierda("NOMBRES: " + row["NombreC"].ToString());
                ticket.TextoIzquierda("DIRECCION: " + row["Direccion"].ToString());
            }


            //ticket.lineasAsteriscos();

            double Subtotal = 0;
            double Impuesto = 0;
            double Descuento = 0;
            double TotalDescuento = 0;
            double Recibido = 0;
            double Devueltas = 0;
            double AritculosVendidos = 0;
            double Total = 0;
            double ValorDomicilio = 0;

            //SISTEMA DE SEPARADOS
            if (v_sistema_separado == true) 
            {
                ticket.TextoIzquierda("---------------------------");
                ticket.TextoIzquierda("INFO SISTEMA DE SEPARADO");
                ticket.TextoIzquierda("CLIENTE: " + clientes_1 + " - "+ NombreCliente);
                ticket.TextoIzquierda("ABONO INICIAL: " + Abono_inicial_1);
                ticket.TextoIzquierda("# CUOTAS: " + num_cuotas_1);
                ticket.TextoIzquierda("VALOR CUOTAS: " + valor_cuotas_1);
                ticket.TextoIzquierda("VALOR : " + valor_1);
                double saldo = Convert.ToDouble(valor_1) - Convert.ToDouble(Abono_inicial_1);
                ticket.TextoIzquierda("SALDO: " + saldo.ToString("N"));
            }
                
            foreach (DataRow rows in DTVenta.Rows)
            {            
                double Cant;
                ticket.TextoIzquierda("--------------------------------------");
                ticket.AgregaArticulo(rows["Item"].ToString()," ", rows["UM"].ToString()+" ", (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"])));
                ticket.TextoIzquierda(rows["Nombre"].ToString());
                ticket.MuestraCalculoPRecioProducto(rows["Cantidad_Exacta"].ToString(), Convert.ToDouble(rows["PrecioVenta"]));
                Descuento = ((Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"])) * (Convert.ToDouble(rows["Descuento"]) / 100));
                ticket.AgregarTotales("Descuento.........", Descuento);
                //ticket.AgregarTotales("IVA %.........",  Convert.ToDouble(rows["IVA"]));
               // ticket.AgregarTotales("IVA %.........",  0);
                //ticket.AgregarTotales("Valor IVA.........", (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad"])) * (Convert.ToDouble(rows["IVA"])/100));
                //ticket.AgregarTotales("Valor IVA.........", 0);
                double subtotal_inicial = 0;
                subtotal_inicial = (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"])) - Descuento;
                ticket.AgregarTotales("SubTotal.........", subtotal_inicial);
                TotalDescuento += Descuento;
                Subtotal += (Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad_Exacta"]));
                //Impuesto += ((Convert.ToDouble(rows["PrecioVenta"]) * Convert.ToDouble(rows["Cantidad"])) * (Convert.ToDouble(rows["IVA"]) / 100));
                Impuesto = 0;
                Recibido = Convert.ToDouble(rows["Efectivo"]) + Convert.ToDouble(rows["Tdebito"]) + Convert.ToDouble(rows["Tcredito"]);
                Devueltas = Convert.ToDouble(rows["Cambio"]);
                AritculosVendidos += Convert.ToDouble(rows["Cantidad_Exacta"]);
                ValorDomicilio = Convert.ToDouble(rows["ValorDomicilio"]);
                Total = (Subtotal - TotalDescuento) + Impuesto;
            }
            ticket.lineasIgual();
            //Resumen de la venta.
            ticket.AgregarTotales("SUBTOTAL......$", Subtotal);
            //ticket.AgregarTotales("IVA...........$", Impuesto);
            ticket.AgregarTotales("DESCUENTO.....$", TotalDescuento);

            if (v_domicilio == true)
            {
                ticket.AgregarTotales("DOMICILIO.....$", ValorDomicilio);
            }
            ticket.AgregarTotales("TOTAL.........$", Total);//Math.Round(Total));
            //ticket.TextoIzquierda("--------------------------------------");
            if (v_sistema_separado == false && v_domicilio == false) 
            {
                ticket.AgregarTotales("RECIBIDO......$", Recibido);
                ticket.AgregarTotales("CAMBIO........$", Devueltas);
            }
               
            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTICULOS VENDIDOS: " + AritculosVendidos + "");
            //ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("");
            //ticket.TextoCentro("SERVICIO A DOMICILIO");
            //ticket.TextoCentro(NumerosCelular);
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.CortaTicket();
            ticket.ImprimirTicket(NombreImpresora);//Nombre de la impresora ticketera
        }

        public string CalcularDigitoVerificacion(string Nit)
        {
            string Temp;
            int Contador;
            int Residuo;
            int Acumulador;
            int[] Vector = new int[15];

            Vector[0] = 3;
            Vector[1] = 7;
            Vector[2] = 13;
            Vector[3] = 17;
            Vector[4] = 19;
            Vector[5] = 23;
            Vector[6] = 29;
            Vector[7] = 37;
            Vector[8] = 41;
            Vector[9] = 43;
            Vector[10] = 47;
            Vector[11] = 53;
            Vector[12] = 59;
            Vector[13] = 67;
            Vector[14] = 71;

            Acumulador = 0;

            Residuo = 0;

            for (Contador = 0; Contador < Nit.Length; Contador++)
            {
                Temp = Nit[(Nit.Length - 1) - Contador].ToString();
                Acumulador = Acumulador + (Convert.ToInt32(Temp) * Vector[Contador]);
            }

            Residuo = Acumulador % 11;

            if (Residuo > 1)
                return Convert.ToString(11 - Residuo);

            return Residuo.ToString();
        }

        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        private void VerificarCaja()
        {
            v_confirmacion = true;
            DataRow rows;
            frm_confirmacion frm_Confirmacion = new frm_confirmacion();
            cls_caja cls_Caja = new cls_caja();
            cls_Caja.Usuario = Usuario;
            v_dt = cls_Caja.mtd_consultar_caja();
            if (v_dt.Rows.Count > 0)
            {
                rows = v_dt.Rows[0];
                if (rows["TipoOperacion"].ToString() == "CIERRE")
                {
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    frm_Confirmacion.txt_mensaje.Text = "Debe realizar Apertura de caja para ventas, ¿Desea realizar apertura de caja?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    {
                        frm_apertura_caja frm_Apertura_caja = new frm_apertura_caja();
                        frm_Apertura_caja.Usuario = Usuario;
                        frm_Apertura_caja.ShowDialog();
                    }
                }
            }
            else
            {
                frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                frm_Confirmacion.txt_mensaje.Text = "Debe realizar Apertura de caja para ventas, ¿Desea realizar apertura de caja?";
                frm_Confirmacion.ShowDialog();
                if (v_confirmacion == true)
                {
                    frm_apertura_caja frm_Apertura_caja = new frm_apertura_caja();
                    frm_Apertura_caja.Usuario = Usuario;
                    frm_Apertura_caja.ShowDialog();
                }
            }
        }
        //Eventos
        private void txt_producto_Enter(object sender, EventArgs e)
        {
            if (txt_producto.Text == "Item-Referencia-Código barras")
            {
                txt_producto.Text = "";
                txt_producto.ForeColor = Color.Black;
            }
        }
        private void txt_producto_Leave(object sender, EventArgs e)
        {
            if (txt_producto.Text == "")
            {
                txt_producto.Text = "Item-Referencia-Código barras";
                txt_producto.ForeColor = Color.Silver;
            }
        }
        frm_inventario frm_Producto;
        private void btn_producto_Click(object sender, EventArgs e)
        {
            if (frm_Producto == null || frm_Producto.IsDisposed)
            {
                frm_Producto = new frm_inventario("Venta");
                frm_Producto.v_dt_Permi = this.v_dt_Permi;
                frm_Producto.Show();
            }
            else
            {
                frm_Producto.BringToFront();
                frm_Producto.WindowState = FormWindowState.Normal;
            }
        }
        frm_cliente frm_cliente;
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            if (frm_cliente == null || frm_cliente.IsDisposed)
            {
                frm_cliente = new frm_cliente(true);
                frm_cliente.v_dt_Permi = this.v_dt_Permi;
                frm_cliente.Show();
            }
            else
            {
                frm_cliente.BringToFront();
                frm_cliente.WindowState = FormWindowState.Normal;
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            VerificarCaja();
            if (v_confirmacion == true)
            {
                if (frm_Ayuda == null || frm_Ayuda.IsDisposed)
                {
                    frm_Ayuda = new frm_ayuda("Buscar producto venta");
                    frm_Ayuda.Enviainfo += new frm_ayuda.EnviarInfo(mtd_dato_venta);
                    frm_Ayuda.Show();
                }
                else
                {
                    frm_Ayuda.BringToFront();
                    frm_Ayuda.WindowState = FormWindowState.Normal;
                }
            }   
        }
        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dtg_venta.Rows.Count > 0)
            {
                if (dtg_venta.CurrentRow != null)
                {
                    foreach (DataGridViewRow rows in dtg_venta.SelectedRows)
                    {
                        dtg_venta.Rows.Remove(dtg_venta.Rows[rows.Index]);
                    }          
                }
                mtd_calcular_venta();              
            }
            mtd_rellenar();
            mtd_calculo_pago();
        }
        private void btn_quitar_todo_Click(object sender, EventArgs e)
        {
            dtg_venta.Rows.Clear();
            mtd_calcular_venta();
            mtd_rellenar();
            mtd_calculo_pago();
        }
        private void txt_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_producto.Text.Trim() != "" && txt_producto.Text.Trim() != "Item-Referencia-Código barras")
            {
                //Enter
                if (e.KeyChar == (char)13)
                {
                    VerificarCaja();
                    if (v_confirmacion == true)
                    { 
                        mtd_buscar_producto();                      
                        mtd_calculo_pago();
                    }
                }
            }
        }
        private void dtg_venta_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            //dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            //dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
        }
        void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void dtg_venta_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {         
            foreach (DataGridViewRow row in dtg_venta.Rows)
            {
                if (row.Cells["cl_cantidad"].Value == null)
                {
                    row.Cells["cl_cantidad"].Value = "1";
                }
                else if (!cls_Global.IsNumericDouble(row.Cells["cl_cantidad"].Value.ToString()))
                {
                    row.Cells["cl_cantidad"].Value = "1";
                }

                if (row.Cells["cl_precio"].Value == null)
                {
                    row.Cells["cl_precio"].Value = "1";
                }
                else if (!cls_Global.IsNumericDouble(row.Cells["cl_precio"].Value.ToString()))
                {
                    row.Cells["cl_precio"].Value = "1";
                }        
            }
            CalcularIVAEMOS();
            mtd_calcular_venta();
            mtd_validar();
            mtd_calculo_pago();
        }

        private void CalcularIVAEMOS() 
        {
            double VALOR_IVA = 0;
            double IVA = 0;
            foreach (DataGridViewRow row in dtg_venta.Rows) 
            {
                //Validacion iva, cliente EMOS
                if (row.Cells["cl_nombre"].Value.ToString() == "IVA EMOS")
                {
                    IVA = Convert.ToDouble(row.Cells["cl_iva"].Value);
                    foreach (DataGridViewRow rowIVA in dtg_venta.Rows)
                    {
                        if (rowIVA.Cells["cl_nombre"].Value.ToString() != "IVA EMOS")
                        {
                            VALOR_IVA += (Convert.ToDouble(rowIVA.Cells["cl_costo"].Value) * Convert.ToDouble(rowIVA.Cells["cl_cantidad"].Value)) * (IVA / 100);
                            rowIVA.Cells["cl_precio"].Value = "0";
                        }
                    }
                    row.Cells["cl_precio"].Value = "0";
                    row.Cells["cl_costo"].Value = VALOR_IVA.ToString();
                }
            }
        }

        private void dtg_venta_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            foreach (DataGridViewRow row in dtg_venta.Rows)
            {
                if (row.Cells["cl_cantidad"].Value == null)
                {
                    row.Cells["cl_cantidad"].Value = "1";

                }
                else if(!cls_Global.IsNumericDouble(row.Cells["cl_cantidad"].Value.ToString()))
                {
                    row.Cells["cl_cantidad"].Value = "1";
                }

                if (row.Cells["cl_precio"].Value == null)
                {
                    row.Cells["cl_precio"].Value = "1";

                }
                else if (!cls_Global.IsNumericDouble(row.Cells["cl_precio"].Value.ToString()))
                {
                    row.Cells["cl_precio"].Value = "1";
                }              
            }
            CalcularIVAEMOS();
            mtd_calcular_venta();
            mtd_validar();
            mtd_calculo_pago();
        }
        private void btn_descuento_Click(object sender, EventArgs e)
        {
            mtd_descuentos();
            mtd_rellenar();
            mtd_calculo_pago();
        }
        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            if (frm_Ayuda == null || frm_Ayuda.IsDisposed)
            {
                frm_Ayuda = new frm_ayuda("Buscar cliente");
                frm_Ayuda.Enviainfo2 += new frm_ayuda.EnviarInfo2(mtd_carga_cliente);
                frm_Ayuda.Show();
            }
            else
            {
                frm_Ayuda.BringToFront();
                frm_Ayuda.WindowState = FormWindowState.Normal;
            }
        }
        private void txt_cliente_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_carga_cliente(txt_cliente.Text,codigoSucursal,NombreSucursal);
        }
        private void txt_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
            if (cls_Global.IsNumericDouble(txt_efectivo.Text))
            { 
                //Enter
                if (e.KeyChar == (char)13)
                {
                    mtd_validar();
                    mtd_calculo_pago();
                    if (Convert.ToDouble(txt_efectivo.Text) >= Convert.ToDouble(lbl_total.Text))
                    {
                        if (v_validado == 0)
                        {
                            v_domicilio = false;
                            v_sistema_separado = false;
                            v_credito = false;
                            if (dtg_venta.Rows.Count > 0)
                            {
                                mtd_guardar();
                            }
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txt_efectivo, "Efectivo debe ser mayor o igual al Total");
                    }
                }
            }
        }
        private void txt_debito_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_num_baucher_debit_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_num_baucher_credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_valor_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            mtd_validar();
            mtd_calculo_pago();
            if (cls_Global.IsNumericDouble(txt_efectivo.Text))
            {
                if (Convert.ToDouble(txt_efectivo.Text) >= Convert.ToDouble(lbl_total.Text))
                { 
                    if (v_validado == 0)
                    {
                        v_domicilio = false;
                        v_sistema_separado = false;
                        v_credito = false;
                        if (dtg_venta.Rows.Count > 0)
                        {
                            mtd_guardar();
                        }
                    }
                }
                else
                {
                    errorProvider.SetError(txt_efectivo,"Efectivo debe ser mayor o igual al Total");
                }          
            }
        }
        private void txt_efectivo_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_validar();
            mtd_calculo_pago();
        }
        private void txt_porc_descuento_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        private void txt_valor_descuento_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
        private void txt_debito_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_validar();
            mtd_calculo_pago();
        }
        private void txt_credito_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_validar();
            mtd_calculo_pago();
        }
        private void txt_num_baucher_debit_Enter(object sender, EventArgs e)
        {
            if (txt_num_baucher_debit.Text == "Numero baucher")
            {
                txt_num_baucher_debit.Text = "";
                txt_num_baucher_debit.ForeColor = Color.Black;
            }
        }
        private void txt_num_baucher_debit_Leave(object sender, EventArgs e)
        {
            if (txt_num_baucher_debit.Text == "")
            {
                txt_num_baucher_debit.Text = "Numero baucher";
                txt_num_baucher_debit.ForeColor = Color.Silver;
            }
        }
        private void txt_num_baucher_credito_Enter(object sender, EventArgs e)
        {
            if (txt_num_baucher_credito.Text == "Numero baucher")
            {
                txt_num_baucher_credito.Text = "";
                txt_num_baucher_credito.ForeColor = Color.Black;
            }
        }
        private void txt_num_baucher_credito_Leave(object sender, EventArgs e)
        {
            if (txt_num_baucher_credito.Text == "")
            {
                txt_num_baucher_credito.Text = "Numero baucher";
                txt_num_baucher_credito.ForeColor = Color.Silver;
            }
        }
        private void btn_domicilio_Click(object sender, EventArgs e)
        {
            if (dtg_venta.Rows.Count > 0)
            {
                frm_aplicar_domicilio frm_Aplicar_domicilio = new frm_aplicar_domicilio();
                frm_Aplicar_domicilio.v_dt_Permi = this.v_dt_Permi;
                frm_Aplicar_domicilio.Enviainfo += new frm_aplicar_domicilio.EnviarInfo(mtd_info_domicilio);
                frm_Aplicar_domicilio.ShowDialog();
            }
        }
        private void btn_separado_Click(object sender, EventArgs e)
        {
            if (dtg_venta.Rows.Count > 0)
            {
                frm_separado frm_Separado = new frm_separado();
                frm_Separado.v_dt_Permi = this.v_dt_Permi;
                frm_Separado.txt_valor.Text = lbl_total.Text;
                frm_Separado.Modulo = "Venta";
                frm_Separado.Usuario = Usuario;
                frm_Separado.Credito = 0;
                frm_Separado.Enviainfo += new frm_separado.EnviarInfo(mtd_info_separado);
                frm_Separado.ShowDialog();
            }
        }
        frm_ventas frm_Ventas;
        private void btn_consultas_Click(object sender, EventArgs e)
        {
            if (frm_Ventas == null || frm_Ventas.IsDisposed)
            {
                frm_Ventas = new frm_ventas();
                frm_Ventas.v_dt_Permi = this.v_dt_Permi;
                frm_Ventas.usuarios = Usuario;
                frm_Ventas.Show();
            }
            else
            {
                frm_Ventas.BringToFront();
                frm_Ventas.WindowState = FormWindowState.Normal;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha_hora.Text = DateTime.Now.ToString();
        }

        private void txt_nota_Leave(object sender, EventArgs e)
        {
            if (txt_nota.Text == "")
            {
                txt_nota.Text = "Nota";
                txt_nota.ForeColor = Color.Silver;
            }
        }

        private void txt_nota_Enter(object sender, EventArgs e)
        {
            if (txt_nota.Text == "Nota")
            {
                txt_nota.Text = "";
                txt_nota.ForeColor = Color.Black;
            }
        }

        private void btn_credito_Click(object sender, EventArgs e)
        {
            if (dtg_venta.Rows.Count > 0) 
            {
                if (dtg_venta.Rows.Count > 0)
                {
                    frm_separado frm_Separado = new frm_separado();
                    frm_Separado.v_dt_Permi = this.v_dt_Permi;
                    frm_Separado.txt_valor.Text = lbl_total.Text;
                    frm_Separado.Modulo = "Venta";
                    frm_Separado.Usuario = Usuario;
                    frm_Separado.Credito = 1;
                    frm_Separado.Enviainfo += new frm_separado.EnviarInfo(mtd_info_Credito);
                    frm_Separado.ShowDialog();
                }
            }    
        }
        private void mtd_info_credito(string Confirmacion) 
        {
        
        }

        private void btn_cotizacion_Click(object sender, EventArgs e)
        {
            mtd_carga_cliente(txt_cliente.Text, codigoSucursal, NombreSucursal);
            mtd_calculo_pago();

            v_domicilio = false;
            v_sistema_separado = false;
            if (dtg_venta.Rows.Count > 0)
            {
              mtd_guardar_Cotizacion();
            }                      
        }

        private void mtd_guardar_Cotizacion()
        {
            ///////////////////////////////////////////////////////////////////
            Vendidos = 0;
            Error = 0;
            double ConsDocumento = 0;
            string Documento = "";
            cls_Reporte_Cotizacion.Usuario = Usuario;
            
                    ConsDocumento = 0;
                    Documento = "";
                    v_dt = cls_Empresa.mtd_consultar_Empresa();
                    if (v_dt.Rows.Count > 0)
                    {
                        v_row = v_dt.Rows[0];
                        ConsDocumento = Convert.ToDouble(v_row["ConsecutivoActualCTZ"]);
                        ConsDocumento++;
                        Documento = v_row["NomDocCtz"].ToString();
                cls_Reporte_Cotizacion.Registro = "";

                        foreach (DataGridViewRow rows in dtg_venta.Rows)
                        {

                    cls_Reporte_Cotizacion.Fecha = DateTime.Now.ToString();
                    cls_Reporte_Cotizacion.NombreDocumento = Documento;
                    cls_Reporte_Cotizacion.ConsecutivoDocumento = ConsDocumento.ToString();
                    cls_Reporte_Cotizacion.Producto = Convert.ToInt32(rows.Cells["cl_item"].Value);
                    cls_Reporte_Cotizacion.ModoVenta = rows.Cells["cl_modo_venta"].Value.ToString();
                    cls_Reporte_Cotizacion.UM = rows.Cells["cl_UM"].Value.ToString();
                            float Cantidad = 0;
                            float Base = 0;
                            float Division = 0;
                            switch (rows.Cells["cl_modo_venta"].Value.ToString())
                            {
                                case "Unidad":
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    break;
                                case "Multi":
                                    if (rows.Cells["cl_UM"].Value.ToString() == "UND P")
                                    {
                                        Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()) * float.Parse(rows.Cells["cl_sobre"].Value.ToString()));
                                        Division = 1 / Base;
                                        Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                    }
                                    if (rows.Cells["cl_UM"].Value.ToString() == "Sobre")
                                    {
                                        Cantidad = (1 / float.Parse(rows.Cells["cl_sobre"].Value.ToString())) * float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    }
                                    if (rows.Cells["cl_UM"].Value.ToString() == "Caja")
                                    {
                                        Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    }
                                    break;
                                case "Pesaje":
                                    if (rows.Cells["cl_UM"].Value.ToString() != "Bulto")
                                    {
                                        Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                        Division = 1 / Base;
                                        Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                    }
                                    else
                                    {
                                        Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    }

                                    break;
                                case "Desechable":
                                    if (rows.Cells["cl_UM"].Value.ToString() != "Bolsa")
                                    {
                                        Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                        Division = 1 / Base;
                                        Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                                    }
                                    else
                                    {
                                        Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    }
                                    break;
                                case "Queso":
                                    Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                                    break;
                            }

                    cls_Reporte_Cotizacion.Cantidad = Cantidad;
                    cls_Reporte_Cotizacion.Costo = Convert.ToDouble(rows.Cells["cl_costo"].Value);
                    cls_Reporte_Cotizacion.PrecioVenta = Convert.ToDouble(rows.Cells["cl_precio"].Value);
                    cls_Reporte_Cotizacion.Descuento = float.Parse(rows.Cells["cl_descuento"].Value.ToString());
                    cls_Reporte_Cotizacion.Efectivo = 0;
                    cls_Reporte_Cotizacion.Tdebito = Convert.ToDouble(txt_debito.Text);
                    cls_Reporte_Cotizacion.Tcredito = Convert.ToDouble(txt_credito.Text);
                            if (txt_num_baucher_debit.Text == "Numero baucher")
                            {
                        cls_Reporte_Cotizacion.NumBaucherDebito = "";
                            }
                            else
                            {
                        cls_Reporte_Cotizacion.NumBaucherDebito = txt_num_baucher_debit.Text;
                            }
                            if (txt_num_baucher_credito.Text == "Numero baucher")
                            {
                        cls_Reporte_Cotizacion.NumBaucherCredito = "";
                            }
                            else
                            {
                        cls_Reporte_Cotizacion.NumBaucherCredito = txt_num_baucher_credito.Text;
                            }
                    cls_Reporte_Cotizacion.Cambio = Convert.ToDouble(lbl_cambio.Text);
                    cls_Reporte_Cotizacion.Total = Convert.ToDouble(lbl_total.Text);
                    cls_Reporte_Cotizacion.Proveedor = rows.Cells["cl_proveedor"].Value.ToString();
                    cls_Reporte_Cotizacion.IVA = Convert.ToInt32(rows.Cells["cl_iva"].Value);
                    cls_Reporte_Cotizacion.DescuentoProveedor = rows.Cells["cl_desc_proveedor"].Value.ToString();
                    cls_Reporte_Cotizacion.Nota = txt_nota.Text;
                    cls_Reporte_Cotizacion.sucursal = codigoSucursal;
                            if (txt_cliente.Text == "")
                            {
                        cls_Reporte_Cotizacion.Cliente = 1;
                            }
                            else
                            {
                        cls_Reporte_Cotizacion.Cliente = Codigo_cliente;
                            }

                            v_ok = cls_Reporte_Cotizacion.mtd_registrar();
                            if (v_ok)
                            {
                                Vendidos++;
                            }
                            else
                            {
                                Error++;
                            }
                        }
                        frm_msg frm_Msg = new frm_msg();
                        frm_Msg.pnl_centro.BackColor = Color.White;
                        if (Error > 0)
                        {
                            frm_Msg.lbl_titulo.Text = "ERROR";
                            frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                        }
                        frm_Msg.txt_mensaje.Text = "Productos Cotizados: " + Vendidos + ", Errores: " + Error;
                        frm_Msg.ShowDialog();
                        txt_producto.Focus();
                        dtg_venta.Rows.Clear();
                        txt_efectivo.Text = "";
                        txt_debito.Text = "0";
                        txt_credito.Text = "0";
                        txt_num_baucher_debit.Text = "Numero baucher";
                        txt_num_baucher_debit.ForeColor = Color.Gray;
                        txt_num_baucher_credito.Text = "Numero baucher";
                        txt_num_baucher_credito.ForeColor = Color.Gray;
                        lbl_cambio.Text = "0";
                        lbl_total.Text = "0";
                        txt_cliente.Text = "";
                        lbl_nombre_cliente.Text = "--";
                        txt_nota.Text = "";
                    }
            // mtd_imprimir(Documento, ConsDocumento.ToString()); // Impresion por Impresora Termica
            // imprimir cotizacion pdf
            if (MessageBox.Show("¿Desea imprimir Cotizacion?", "Imprimir Cotizacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<cls_reporte_cotizacion> lrctz = new List<cls_reporte_cotizacion>();
                cls_reporte_cotizacion cls_Reporte_Cotizacion1 = new cls_reporte_cotizacion();
                DateTime FechaHoy = DateTime.Now;
                DataTable DataTable2 = new DataTable();
                cls_Reporte_Cotizacion1.Fecha_inicio = FechaHoy;
                cls_Reporte_Cotizacion1.Fecha_fin = FechaHoy;
                cls_Reporte_Cotizacion1.v_buscar = ConsDocumento.ToString();
                DataTable2 = cls_Reporte_Cotizacion1.mtd_consultar();

                    foreach (DataRow rows in DataTable2.Rows)
                    {
                        cls_reporte_cotizacion cls_Reporte_Cotizacion = new cls_reporte_cotizacion();
                        DateTime Fecha = Convert.ToDateTime(rows["Fecha"].ToString());
                        cls_Reporte_Cotizacion.rpt_Fecha = Fecha.ToString("yyyy-MM-dd");
                        cls_Reporte_Cotizacion.rpt_Doc = rows["Doc"].ToString();
                        cls_Reporte_Cotizacion.rpt_Conse = rows["Conse"].ToString();
                        cls_Reporte_Cotizacion.rpt_Item = rows["Item"].ToString();
                        cls_Reporte_Cotizacion.rpt_Nombre = rows["Nombre"].ToString();
                        cls_Reporte_Cotizacion.rpt_Cantidad = rows["cantidad"].ToString();
                        double PrecioVenta = Convert.ToDouble(rows["PrecioVenta"].ToString());
                        cls_Reporte_Cotizacion.rpt_precioVenta = PrecioVenta.ToString("N");
                        double Descuento = Convert.ToDouble(rows["Descuento"].ToString());
                        cls_Reporte_Cotizacion.rpt_Descuento = Descuento.ToString("N");
                        cls_Reporte_Cotizacion.rpt_Total = rows["Total"].ToString();
                        cls_Reporte_Cotizacion.rpt_dni = rows["DNI"].ToString();
                        cls_Reporte_Cotizacion.rpt_Cliente = rows["Cliente"].ToString();
                        cls_Reporte_Cotizacion.rpt_Direccion = rows["Direccion"].ToString();
                        cls_Reporte_Cotizacion.rpt_Email = rows["Email"].ToString();
                        cls_Reporte_Cotizacion.rpt_Telefono = rows["Telefono"].ToString();
                        cls_Reporte_Cotizacion.rpt_Celular = rows["Celular"].ToString();
                        cls_Reporte_Cotizacion.rpt_Usuario = rows["Usuario"].ToString();
                        cls_Reporte_Cotizacion.rpt_NombreUsuario = rows["NombreUsuario"].ToString();
                        cls_Reporte_Cotizacion.rpt_Dni_empresa = rows["DNI_Empresa"].ToString();
                        cls_Reporte_Cotizacion.rpt_nombre_empresa = rows["Nombre_Empresa"].ToString();
                        cls_Reporte_Cotizacion.rpt_telefono_emp = rows["Telefono_emp"].ToString();
                        cls_Reporte_Cotizacion.rpt_celular_emp = rows["Celular_emp"].ToString();
                        cls_Reporte_Cotizacion.rpt_direccion_emp = rows["Direccion_emp"].ToString();
                        double Total2 = Convert.ToDouble(rows["Total2"].ToString());
                        cls_Reporte_Cotizacion.rpt_Total2 = Total2.ToString("N");
                        cls_Reporte_Cotizacion.Foto = (byte[])rows["Foto"];

                        lrctz.Add(cls_Reporte_Cotizacion);
                    }
                
                frm_cotizacion frm_Cotizacion = new frm_cotizacion();
                frm_Cotizacion.Reporte = "Cotizacion";
                frm_Cotizacion.lrctz = lrctz;
                frm_Cotizacion.Show();
            }
        }
        private void btn_orden_servicio_Click(object sender, EventArgs e)
        {
            if (dtg_venta.Rows.Count > 0)
            {
                if (lbl_nombre_cliente.Text != "--")
                {
                    mtd_carga_cliente(txt_cliente.Text, codigoSucursal, NombreSucursal);
                    mtd_calculo_pago();

                    v_domicilio = false;
                    v_sistema_separado = false;
                    if (dtg_venta.Rows.Count > 0)
                    {
                        mtd_guardar_Orden_Servicio();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione Cliente");
                }
            }
        }

        private void mtd_guardar_Orden_Servicio()
        {
            ///////////////////////////////////////////////////////////////////
            Vendidos = 0;
            Error = 0;
            double ConsDocumento = 0;
            string Documento = "";
            cls_Orden_servicio.Usuario = Usuario;

            ConsDocumento = 0;
            Documento = "";
            v_dt = cls_Empresa.mtd_consultar_Empresa();
            if (v_dt.Rows.Count > 0)
            {
                v_row = v_dt.Rows[0];
                ConsDocumento = Convert.ToDouble(v_row["ConsecutivoActualOrds"]);
                ConsDocumento++;
                Documento = v_row["NomDocOrds"].ToString();
                cls_Orden_servicio.Registro = "";

                foreach (DataGridViewRow rows in dtg_venta.Rows)
                {
                    cls_Orden_servicio.Fecha = DateTime.Now.ToString();
                    cls_Orden_servicio.NombreDocumento = Documento;
                    cls_Orden_servicio.ConsecutivoDocumento = ConsDocumento.ToString();
                    cls_Orden_servicio.Producto = Convert.ToInt32(rows.Cells["cl_item"].Value);
                    cls_Orden_servicio.ModoVenta = rows.Cells["cl_modo_venta"].Value.ToString();
                    cls_Orden_servicio.UM = rows.Cells["cl_UM"].Value.ToString();
                    float Cantidad = 0;
                    float Base = 0;
                    float Division = 0;
                    switch (rows.Cells["cl_modo_venta"].Value.ToString())
                    {
                        case "Unidad":
                            Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                            break;
                        case "Multi":
                            if (rows.Cells["cl_UM"].Value.ToString() == "UND P")
                            {
                                Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()) * float.Parse(rows.Cells["cl_sobre"].Value.ToString()));
                                Division = 1 / Base;
                                Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                            }
                            if (rows.Cells["cl_UM"].Value.ToString() == "Sobre")
                            {
                                Cantidad = (1 / float.Parse(rows.Cells["cl_sobre"].Value.ToString())) * float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                            }
                            if (rows.Cells["cl_UM"].Value.ToString() == "Caja")
                            {
                                Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                            }
                            break;
                        case "Pesaje":
                            if (rows.Cells["cl_UM"].Value.ToString() != "Bulto")
                            {
                                Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                Division = 1 / Base;
                                Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                            }
                            else
                            {
                                Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                            }

                            break;
                        case "Desechable":
                            if (rows.Cells["cl_UM"].Value.ToString() != "Bolsa")
                            {
                                Base = (float.Parse(rows.Cells["cl_subCantidad"].Value.ToString()));
                                Division = 1 / Base;
                                Cantidad = (Division * float.Parse(rows.Cells["cl_cantidad"].Value.ToString()));
                            }
                            else
                            {
                                Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                            }
                            break;
                        case "Queso":
                            Cantidad = float.Parse(rows.Cells["cl_cantidad"].Value.ToString());
                            break;
                    }

                    cls_Orden_servicio.Cantidad = Cantidad;
                    cls_Orden_servicio.Costo = Convert.ToDouble(rows.Cells["cl_costo"].Value);
                    cls_Orden_servicio.PrecioVenta = Convert.ToDouble(rows.Cells["cl_precio"].Value);
                    cls_Orden_servicio.Descuento = float.Parse(rows.Cells["cl_descuento"].Value.ToString());
                    cls_Orden_servicio.Efectivo = 0;
                    cls_Orden_servicio.Tdebito = Convert.ToDouble(txt_debito.Text);
                    cls_Orden_servicio.Tcredito = Convert.ToDouble(txt_credito.Text);
                    if (txt_num_baucher_debit.Text == "Numero baucher")
                    {
                        cls_Orden_servicio.NumBaucherDebito = "";
                    }
                    else
                    {
                        cls_Orden_servicio.NumBaucherDebito = txt_num_baucher_debit.Text;
                    }
                    if (txt_num_baucher_credito.Text == "Numero baucher")
                    {
                        cls_Orden_servicio.NumBaucherCredito = "";
                    }
                    else
                    {
                        cls_Orden_servicio.NumBaucherCredito = txt_num_baucher_credito.Text;
                    }
                    cls_Orden_servicio.Cambio = Convert.ToDouble(lbl_cambio.Text);
                    cls_Orden_servicio.Total = Convert.ToDouble(lbl_total.Text);
                    cls_Orden_servicio.Proveedor = rows.Cells["cl_proveedor"].Value.ToString();
                    cls_Orden_servicio.IVA = Convert.ToInt32(rows.Cells["cl_iva"].Value);
                    cls_Orden_servicio.DescuentoProveedor = rows.Cells["cl_desc_proveedor"].Value.ToString();
                    cls_Orden_servicio.Nota = txt_nota.Text;
                    cls_Orden_servicio.sucursal = codigoSucursal;
                    if (txt_cliente.Text == "")
                    {
                        cls_Orden_servicio.Cliente = 1;
                    }
                    else
                    {
                        cls_Orden_servicio.Cliente = Codigo_cliente;
                    }

                    v_ok = cls_Orden_servicio.mtd_registrar();
                    if (v_ok)
                    {
                        Vendidos++;
                    }
                    else
                    {
                        Error++;
                    }
                }
                frm_msg frm_Msg = new frm_msg();
                frm_Msg.pnl_centro.BackColor = Color.White;
                if (Error > 0)
                {
                    frm_Msg.lbl_titulo.Text = "ERROR";
                    frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                }
                frm_Msg.txt_mensaje.Text = "Productos Orden servicio: " + Vendidos + ", Errores: " + Error;
                frm_Msg.ShowDialog();
                txt_producto.Focus();
                dtg_venta.Rows.Clear();
                txt_efectivo.Text = "";
                txt_debito.Text = "0";
                txt_credito.Text = "0";
                txt_num_baucher_debit.Text = "Numero baucher";
                txt_num_baucher_debit.ForeColor = Color.Gray;
                txt_num_baucher_credito.Text = "Numero baucher";
                txt_num_baucher_credito.ForeColor = Color.Gray;
                lbl_cambio.Text = "0";
                lbl_total.Text = "0";
                txt_cliente.Text = "";
                lbl_nombre_cliente.Text = "--";
                txt_nota.Text = "";
            }
            // mtd_imprimir(Documento, ConsDocumento.ToString()); // Impresion por Impresora Termica
            if (MessageBox.Show("¿Desea imprimir Orden de servicio?", "Imprimir Orden de Servicio", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Imprimir Cotizacion PDF
                cls_orden_servicio cls_Orden_Servicio = new cls_orden_servicio();
                List<cls_orden_servicio> lrords = new List<cls_orden_servicio>();
                DataTable DataTable2 = new DataTable();
                DateTime FechaHoy = DateTime.Now;
                cls_Orden_Servicio.Fecha_inicio = FechaHoy.ToString("yyyyMMdd");
                cls_Orden_Servicio.Fecha_fin = FechaHoy.ToString("yyyyMMdd");
                cls_Orden_Servicio.v_buscar = ConsDocumento.ToString();
                DataTable2 = cls_Orden_Servicio.mtd_consultar();

                foreach (DataRow rows in DataTable2.Rows)
                {
                    cls_orden_servicio cls_Orden_Servicio2 = new cls_orden_servicio();
                    DateTime Fecha = Convert.ToDateTime(rows["Fecha"].ToString());
                    cls_Orden_Servicio2.rpt_Fecha = Fecha.ToString("yyyy-MM-dd");
                    cls_Orden_Servicio2.rpt_Doc = rows["Doc"].ToString();
                    cls_Orden_Servicio2.rpt_Conse = rows["Conse"].ToString();
                    cls_Orden_Servicio2.rpt_Item = rows["Item"].ToString();
                    cls_Orden_Servicio2.rpt_Nombre = rows["Nombre"].ToString();
                    cls_Orden_Servicio2.rpt_Cantidad = rows["cantidad"].ToString();
                    double PrecioVenta = Convert.ToDouble(rows["PrecioVenta"].ToString());
                    cls_Orden_Servicio2.rpt_precioVenta = PrecioVenta.ToString("N");
                    double Descuento = Convert.ToDouble(rows["Descuento"].ToString());
                    cls_Orden_Servicio2.rpt_Descuento = Descuento.ToString("N");
                    cls_Orden_Servicio2.rpt_Total = rows["Total"].ToString();
                    cls_Orden_Servicio2.rpt_dni = rows["DNI"].ToString();
                    cls_Orden_Servicio2.rpt_Cliente = rows["Cliente"].ToString();
                    cls_Orden_Servicio2.rpt_Direccion = rows["Direccion"].ToString();
                    cls_Orden_Servicio2.rpt_Email = rows["Email"].ToString();
                    cls_Orden_Servicio2.rpt_Telefono = rows["Telefono"].ToString();
                    cls_Orden_Servicio2.rpt_Celular = rows["Celular"].ToString();
                    cls_Orden_Servicio2.rpt_Usuario = rows["Usuario"].ToString();
                    cls_Orden_Servicio2.rpt_NombreUsuario = rows["NombreUsuario"].ToString();
                    cls_Orden_Servicio2.rpt_Dni_empresa = rows["DNI_Empresa"].ToString();
                    cls_Orden_Servicio2.rpt_nombre_empresa = rows["Nombre_Empresa"].ToString();
                    cls_Orden_Servicio2.rpt_telefono_emp = rows["Telefono_emp"].ToString();
                    cls_Orden_Servicio2.rpt_celular_emp = rows["Celular_emp"].ToString();
                    cls_Orden_Servicio2.rpt_direccion_emp = rows["Direccion_emp"].ToString();
                    double Total2 = Convert.ToDouble(rows["Total2"].ToString());
                    cls_Orden_Servicio2.rpt_Total2 = Total2.ToString("N");
                    cls_Orden_Servicio2.Foto = (byte[])rows["Foto"];
                    cls_Orden_Servicio2.Nota = rows["nota"].ToString();
                    cls_Orden_Servicio2.rpt_email_emp = rows["Email_emp"].ToString();
                    lrords.Add(cls_Orden_Servicio2);
                }

                frm_cotizacion frm_Cotizacion = new frm_cotizacion();
                frm_Cotizacion.Reporte = "OrdenServicio";
                frm_Cotizacion.lrords = lrords;
                frm_Cotizacion.Show();

            }
        }

        private void btn_creditos_Click(object sender, EventArgs e)
        {

        }
    }
}
