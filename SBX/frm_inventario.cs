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
using SBX.DB;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;

namespace SBX
{
    public partial class frm_inventario : Form
    {
        //instancias
        cls_global cls_Global = new cls_global();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inventario));  
        cls_unidad_medida cls_Unidad_Medida = new cls_unidad_medida();
        cls_estado cls_Estado = new cls_estado();
        cls_categoria cls_Categoria = new cls_categoria();
        cls_marca cls_Marca = new cls_marca();
        cls_ubicacion cls_Ubicacion = new cls_ubicacion();
        cls_salida_para cls_salida_para = new cls_salida_para();
        cls_producto cls_Producto = new cls_producto();
        frm_inicio frm_Inicio = new frm_inicio();
        cls_proveedor cls_Proveedor = new cls_proveedor();

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Variables globales
        int v_validado = 0;
        bool v_validar = false;
        DataTable v_dt;
        string v_caracteristica = "";
        Image Foto;
        int v_codigo_unidad_medida;
        int v_codigo_estado;
        int v_codigo_categoria;
        int v_codigo_marca;
        bool v_ok = true;
        DataRow v_row;
        double v_valores = 0;
        int v_contador = 0;
        int v_filas = 0;
        bool v_confirmacion;
        string v_item_producto;
        int vl = 0;
        public string accion { get; set; }
        public DataTable v_dt_Permi { get; set; }
        public string Usuario { get; set; }

        //Inicio de formulario
        public frm_inventario()
        {
            InitializeComponent();
            mtd_cargar_consecutivo_item();
            txt_desc.Text = "0";
            //pnl_arriba.Height = 32;
        }
        public frm_inventario(string Accion)
        {
            InitializeComponent();
           // pnl_arriba.Height = 32;


            if (Accion != "Modificar")
            {
                mtd_cargar_consecutivo_item();
            }
            accion = Accion;
        }
        private void frm_producto_Load(object sender, EventArgs e)
        {
            txt_desc.Text = "0";
            mtd_mensajeInformativoBotones();
            if (accion != "Modificar")
            {
                cbx_modo_venta.Text = "Unidad";
            }

            rd_entrada.Checked = true;
            mtd_caracteristicas();

            foreach (DataRow rows in v_dt_Permi.Rows)
            {
                if (rows["Modulo"].ToString() == "INVENTARIO")
                {
                    switch (rows["Permiso"].ToString())
                    {
                        case "guardar":
                            btn_guardar.Enabled = true;
                            break;
                        case "consultas":
                            btn_consultas.Enabled = true;
                            break;
                        case "limpiar":
                            btn_limpiar.Enabled = true;
                            break;
                        case "caracteristicas":
                            btn_caracteristicas.Enabled = true;
                            break;
                        case "agregar_proveedor":
                            btn_agregar_proveedor.Enabled = true;
                            break;
                    }
                }
            }
            //Actualiza fechas de vencimiento
            cls_Producto.v_buscar = "";
            cls_Producto.mtd_consultar_estado_fechas_vencimiento();
        }

        //Metodos
        public void mtd_mensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar_proveedor, "Buscar proveedor");
            Botones.SetToolTip(btn_buscar_producto ,"Buscar producto");
            Botones.SetToolTip(btn_guardar, "Guardar");
            Botones.SetToolTip(btn_consultas, "Consultas");
            Botones.SetToolTip(btn_caracteristicas, "Caracteristicas");
            Botones.SetToolTip(btn_limpiar, "Limpiar");
            Botones.SetToolTip(btn_agregar_proveedor, "Agregar proveedor");
            Botones.SetToolTip(btn_foto, "Agregar foto");
        }
        private void mtd_limpiar()
        {
            errorProvider.Clear();
           
            txt_item.Text = "";
            txt_referencia.Text = "";
            txt_nombre.Text = "";
            txt_iva.Text = "0";
            cbx_unidad_medida.Text = "N/A";
            txt_medida.Text = "0";
            cbx_estado.Text = "Activo";
            cbx_categoria.Text = "N/A";
            cbx_marca.Text = "N/A";
            txt_proveedor.Text = "0";
            v_validar = false;
            cbx_modo_venta.Enabled = true;
            cbx_modo_venta.Text = "Unidad";
            txt_cantidad.Text = "";
            txt_costo.Text = "";
            txt_precio_venta.Text = "";
            txt_codigo_barras.Text = "";
            txt_subcantidad.Text = "0";
            txt_valor_subcantidad.Text = "0";
            txt_sobres.Text = "0";
            txt_valor_sobres.Text = "0";
            rd_entrada.Checked = true;
            cbx_ubicacion.Text = "N/A";
            cbx_salida_para.Text = "N/A";
            txt_stock_minimo.Text = "0";
            txt_stock_maximo.Text = "0";
            lbl_stock_actual.Text = "0";
            lbl_stock_actual.BackColor = Color.SeaGreen;
            txt_descripcion.Text = "";
            pbx_foto.Image = ((System.Drawing.Image)(resources.GetObject("pbx_foto.Image")));
            lbl_stock_actual.Text = "0";
            lbl_stock_actual.BackColor = Color.SeaGreen;
            lbl_estado_stock.Text = "--";
            lbl_sub.Text = "0";
            txt_nom_proveedor.Text = "";
            txt_desc.Text = "0";
            txt_c_d_iva.Text = "";
            txt_margen.Text = "";
            txt_fecha_vence.Text = "";
            mtd_cargar_consecutivo_item();
            btn_add_fecha_vence.Enabled = false;
            txt_nota.Text = "";
        }
        private void mtd_validar()
        {
            double v_formato_numeros;
            v_validado = 0;
            errorProvider.Clear();
            lbl_estado_stock.Text = "";
            
            //Valida que los campos requeridos contengan la informacion necesaria
            if (txt_item.Text == "") { errorProvider.SetError(txt_item,"Ingrese Item"); v_validado++; }
            if (txt_nombre.Text == "") { errorProvider.SetError(txt_nombre, "Ingrese Nombre"); v_validado++; }
            if (txt_iva.Text == "") { errorProvider.SetError(txt_iva, "Ingrese IVA"); v_validado++; }
            if (txt_proveedor.Text == "") { errorProvider.SetError(txt_proveedor, "Ingrese proveedor"); v_validado++; }
            if (txt_cantidad.Text == "") { errorProvider.SetError(txt_cantidad, "Ingrese Cantidad"); v_validado++; }
            if (txt_costo.Text == "") { errorProvider.SetError(txt_costo, "Ingrese costo"); v_validado++; }
           
            if (txt_precio_venta.Text == "") { errorProvider.SetError(txt_precio_venta, "Ingrese precio venta"); v_validado++; }

            //Validar los campos de tipo numero double
            if (txt_medida.Text == "")
            {
                txt_medida.Text = "0";
            }
            if (!cls_Global.IsNumericDouble(txt_medida.Text))
            {
                errorProvider.SetError(txt_medida, "Ingrese valores numericos");
                v_validado++;
            }
            if (txt_costo.Text != "")
            {
                if (!cls_Global.IsNumericDouble(txt_costo.Text))
                {
                    errorProvider.SetError(txt_costo, "Ingrese valores numericos");
                    v_validado++;
                }
                else
                {
                    v_formato_numeros = Convert.ToDouble(txt_costo.Text);
                    txt_costo.Text = v_formato_numeros.ToString("N");
                }
            }
            if (txt_precio_venta.Text != "")
            {
                if (!cls_Global.IsNumericDouble(txt_precio_venta.Text))
                {
                    errorProvider.SetError(txt_precio_venta, "Ingrese valores numericos");
                    v_validado++;
                }
                else
                {
                    v_formato_numeros = Convert.ToDouble(txt_precio_venta.Text);
                    txt_precio_venta.Text = v_formato_numeros.ToString("N");
                }
            }
                      
            if (cbx_modo_venta.Text == "Pesaje")
            {
                if (!(cbx_unidad_medida.Text == "KG" || cbx_unidad_medida.Text == "LB" || cbx_unidad_medida.Text == "G" || cbx_unidad_medida.Text == "MT"))
                {
                    errorProvider.SetError(cbx_unidad_medida, "Ingrese Unidad medida (KILOGRAMO,LIBRA,GRAMO)"); v_validado++;
                }
                if (txt_subcantidad.Text == "") { errorProvider.SetError(txt_subcantidad, "Ingrese Subcantidad"); v_validado++; }
                if (txt_valor_subcantidad.Text == "") { errorProvider.SetError(txt_valor_subcantidad, "Ingrese valor subcantidad"); v_validado++; }

                //Validar los campos de tipo numero double
                if (txt_subcantidad.Text != "")
                {
                    if (!cls_Global.IsNumericDouble(txt_subcantidad.Text))
                    {
                        errorProvider.SetError(txt_subcantidad, "Ingrese valores numericos");
                        v_validado++;
                    }
                }
                if (txt_valor_subcantidad.Text != "")
                {
                    if (!cls_Global.IsNumericDouble(txt_valor_subcantidad.Text))
                    {
                        errorProvider.SetError(txt_valor_subcantidad, "Ingrese valores numericos");
                        v_validado++;
                    }
                    else
                    {
                        v_formato_numeros = Convert.ToDouble(txt_valor_subcantidad.Text);
                        txt_valor_subcantidad.Text = v_formato_numeros.ToString("N");
                    }
                }           
            }

            if (cbx_modo_venta.Text == "Queso")
            {
                if (!(cbx_unidad_medida.Text == "KG" || cbx_unidad_medida.Text == "LB" || cbx_unidad_medida.Text == "G" || cbx_unidad_medida.Text == "MT"))
                {
                    errorProvider.SetError(cbx_unidad_medida, "Ingrese Unidad medida (KILOGRAMO,LIBRA,GRAMO)"); v_validado++;
                }
            }

            if (cbx_modo_venta.Text == "Multi")
            {
                if (txt_subcantidad.Text == "") { errorProvider.SetError(txt_subcantidad, "Ingrese Subcantidad"); v_validado++; }
                if (txt_valor_subcantidad.Text == "") { errorProvider.SetError(txt_valor_subcantidad, "Ingrese valor subcantidad"); v_validado++; }
                if (txt_sobres.Text == "") { errorProvider.SetError(txt_sobres, "Ingrese sobres"); v_validado++; }
                if (txt_valor_sobres.Text == "") { errorProvider.SetError(txt_valor_sobres, "Ingrese valor sobres"); v_validado++; }

                //Validar los campos de tipo numero double
                if (txt_subcantidad.Text != "")
                {
                    if (!cls_Global.IsNumericDouble(txt_subcantidad.Text))
                    {
                        errorProvider.SetError(txt_subcantidad, "Ingrese valores numericos");
                        v_validado++;
                    }
                }
                if (txt_valor_subcantidad.Text != "")
                {
                    if (!cls_Global.IsNumericDouble(txt_valor_subcantidad.Text))
                    {
                        errorProvider.SetError(txt_valor_subcantidad, "Ingrese valores numericos");
                        v_validado++;
                    }
                    else
                    {
                        v_formato_numeros = Convert.ToDouble(txt_valor_subcantidad.Text);
                        txt_valor_subcantidad.Text = v_formato_numeros.ToString("N");
                    }
                }
                if (txt_sobres.Text != "")
                {
                    if (!cls_Global.IsNumericDouble(txt_sobres.Text))
                    {
                        errorProvider.SetError(txt_sobres, "Ingrese valores numericos");
                        v_validado++;
                    }
                }
                if (txt_valor_sobres.Text != "")
                {
                    if (!cls_Global.IsNumericDouble(txt_valor_sobres.Text))
                    {
                        errorProvider.SetError(txt_valor_sobres, "Ingrese valores numericos");
                        v_validado++;
                    }
                    else
                    {
                        v_formato_numeros = Convert.ToDouble(txt_valor_sobres.Text);
                        txt_valor_sobres.Text = v_formato_numeros.ToString("N");
                    }
                }            
            }

            if (cbx_unidad_medida.Text == "")
            {
                errorProvider.SetError(cbx_unidad_medida, "Seleccione unidad de medida");
                v_validado++;
            }
            if (cbx_estado.Text == "")
            {
                errorProvider.SetError(cbx_estado, "Seleccione estado");
                v_validado++;
            }
            if (cbx_categoria.Text == "")
            {
                errorProvider.SetError(cbx_categoria, "Seleccione categoria");
                v_validado++;
            }
            if (cbx_marca.Text == "")
            {
                errorProvider.SetError(cbx_marca, "Seleccione marca");
                v_validado++;
            }
            if (cbx_modo_venta.Text == "")
            {
                errorProvider.SetError(cbx_modo_venta, "Seleccione modo venta");
                v_validado++;
            }
            if (cbx_ubicacion.Text == "")
            {
                errorProvider.SetError(cbx_ubicacion, "Seleccione ubicacion");
                v_validado++;
            }
            if (cbx_salida_para.Text == "")
            {
                errorProvider.SetError(cbx_salida_para, "Seleccione salida para");
                v_validado++;
            }

            if (txt_stock_minimo.Text.Trim() == "")
            {
                errorProvider.SetError(txt_stock_minimo, "Ingrese stock minimo");
                v_validado++;
            }
            else
            {
                if ((Convert.ToDouble(lbl_stock_actual.Text) >= Convert.ToDouble(txt_stock_minimo.Text)) && Convert.ToDouble(lbl_stock_actual.Text) != 0)
                {
                    lbl_estado_stock.Text = "Hay stock ";
                    lbl_stock_actual.ForeColor = Color.White;
                    lbl_stock_actual.BackColor = Color.SeaGreen;
                }
                else if((Convert.ToDouble(lbl_stock_actual.Text) < Convert.ToDouble(txt_stock_minimo.Text)) && Convert.ToDouble(lbl_stock_actual.Text) != 0)
                {
                    lbl_estado_stock.Text = "Stock se esta agotando ";
                    lbl_stock_actual.ForeColor = Color.Black;
                    lbl_stock_actual.BackColor = Color.Gold;
                }
            }

            if (txt_stock_maximo.Text.Trim() == "")
            {
                errorProvider.SetError(txt_stock_maximo, "Ingrese stock maximo");
                v_validado++;
            }
            else
            {
                if (Convert.ToDouble(lbl_stock_actual.Text) > Convert.ToDouble(txt_stock_maximo.Text))
                {
                    lbl_stock_actual.BackColor = Color.SteelBlue;
                    lbl_stock_actual.ForeColor = Color.White;
                    if (lbl_estado_stock.Text != "")
                    {
                        lbl_estado_stock.Text += ",";
                    }
                    lbl_estado_stock.Text += "Stock maximo superado";
                }
            }

            if (Convert.ToDouble(lbl_stock_actual.Text) <= 0)
            {
                lbl_estado_stock.Text = "Stock agotado ";
                lbl_stock_actual.ForeColor = Color.White;
                lbl_stock_actual.BackColor = Color.OrangeRed;
            }

            mtd_Validar_proveedor();
        }
        private void mtd_cargar_foto()
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pbx_foto.Image = Image.FromFile(dialog.FileName);
            }
        }
        private void mtd_cargar_unidad_medida()
        {
            cls_Unidad_Medida.v_tipo_busqueda = "Normal";
            v_dt = cls_Unidad_Medida.mtd_consultar_unidad_medida();
            errorProvider.Clear();
            v_caracteristica = cbx_unidad_medida.Text;
            cbx_unidad_medida.Items.Clear();
            foreach (DataRow rows in v_dt.Rows)
            {    
                    cbx_unidad_medida.Items.Add(rows["Nombre"]);
            }
            cbx_unidad_medida.Text = v_caracteristica;
        }
        private void mtd_cargar_estado()
        {
            v_dt = cls_Estado.mtd_consultar_estado();
            errorProvider.Clear();
            v_caracteristica = cbx_estado.Text;
            cbx_estado.Items.Clear();
            foreach (DataRow rows in v_dt.Rows)
            {
                    cbx_estado.Items.Add(rows["Nombre"]);
            }
            cbx_estado.Text = "Activo";
            cbx_estado.Text = v_caracteristica;
        }
        private void mtd_cargar_categoria()
        {
            cls_Categoria.v_tipo_busqueda = "Normal";
            v_dt = cls_Categoria.mtd_consultar_categoria();
            errorProvider.Clear();
            v_caracteristica = cbx_categoria.Text;
            cbx_categoria.Items.Clear();
            foreach (DataRow rows in v_dt.Rows)
            {
                    cbx_categoria.Items.Add(rows["Nombre"]);
            }
            cbx_categoria.Text = v_caracteristica;
        }
        private void mtd_cargar_marca()
        {
            cls_Marca.v_tipo_busqueda = "Normal";
            v_dt = cls_Marca.mtd_consultar_marca();
            errorProvider.Clear();
            v_caracteristica = cbx_marca.Text;
            cbx_marca.Items.Clear();
            foreach (DataRow rows in v_dt.Rows)
            {
                    cbx_marca.Items.Add(rows["Nombre"]);
            }
            cbx_marca.Text = v_caracteristica;
        }
        private void mtd_caracteristicas()
        {
            v_dt = cls_Producto.mtd_consultar_caracteristicas_producto();
            errorProvider.Clear();
            cbx_unidad_medida.Items.Clear();
            cbx_estado.Items.Clear();
            cbx_categoria.Items.Clear();
            cbx_marca.Items.Clear();
            cbx_ubicacion.Items.Clear();
            cbx_salida_para.Items.Clear();
            foreach (DataRow rows in v_dt.Rows)
            {
                //cargar Unidadmedida
                if (rows["Tabla"].ToString() == "UnidadMedida")
                {
                    cbx_unidad_medida.Items.Add(rows["Nombre"]);
                }
                //cargar Estado
                if (rows["Tabla"].ToString() == "Estado")
                {
                    cbx_estado.Items.Add(rows["Nombre"]);
                }
                //cargar Categoria
                if (rows["Tabla"].ToString() == "Categoria")
                {
                    cbx_categoria.Items.Add(rows["Nombre"]);
                }
                //cargar Marca
                if (rows["Tabla"].ToString() == "Marca")
                {
                    cbx_marca.Items.Add(rows["Nombre"]);
                }
                //cargar Ubicacion
                if (rows["Tabla"].ToString() == "Ubicacion")
                {
                    cbx_ubicacion.Items.Add(rows["Nombre"]);
                }
                //cargar Salida_para
                if (rows["Tabla"].ToString() == "SalidaPara")
                {
                    cbx_salida_para.Items.Add(rows["Nombre"]);
                }
            }
            cbx_unidad_medida.Text = "N/A";
            cbx_estado.Text = "Activo";
            cbx_categoria.Text = "N/A";
            cbx_marca.Text = "N/A";
            cbx_ubicacion.Text = "N/A";
            cbx_salida_para.Text = "N/A";
        }
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void mtd_llenarCampos(string CampoBusqueda)
        {
            switch (CampoBusqueda)
            {
                case "txt_item":
                    cls_Producto.v_tipo_busqueda = "txt_item";
                    cls_Producto.Item = txt_item.Text;
                    cls_Producto.Referencia = "";
                    cls_Producto.CodigoBarras = "";
                    v_dt = cls_Producto.mtd_consultar_producto();
                    break;
                case "txt_referencia":
                    cls_Producto.v_tipo_busqueda = "txt_referencia";
                    cls_Producto.Item = "";
                    cls_Producto.Referencia = txt_referencia.Text;
                    cls_Producto.CodigoBarras = "";
                    v_dt = cls_Producto.mtd_consultar_producto();
                    break;
                case "txt_codigo_barras":
                    cls_Producto.v_tipo_busqueda = "txt_codigo_barras";
                    cls_Producto.Item = "";
                    cls_Producto.Referencia = "";
                    cls_Producto.CodigoBarras = txt_codigo_barras.Text;
                    v_dt = cls_Producto.mtd_consultar_producto();
                    break;
            }
                   
            if (v_dt.Rows.Count > 0)
            {
                foreach (DataRow rows in v_dt.Rows)
                {
                    switch (CampoBusqueda)
                    {
                        case "txt_item":
                            txt_referencia.Text = rows["Referencia"].ToString();
                            txt_codigo_barras.Text = rows["CodigoBarras"].ToString();
                            break;
                        case "txt_referencia":
                            txt_codigo_barras.Text = rows["Item"].ToString();
                            txt_codigo_barras.Text = rows["CodigoBarras"].ToString();
                            break;
                        case "txt_codigo_barras":
                            txt_codigo_barras.Text = rows["Item"].ToString();
                            txt_referencia.Text = rows["Referencia"].ToString();
                            break;
                    }
                    
                    txt_nombre.Text = rows["Nombre"].ToString();
                    txt_iva.Text = rows["IVA"].ToString();
                    v_codigo_unidad_medida = Convert.ToInt32(rows["UnidadMedida"]);
                    cbx_unidad_medida.Text = rows["Nombre_Unidad_medida"].ToString();
                    txt_medida.Text = rows["Medida"].ToString();
                    v_codigo_estado = Convert.ToInt32(rows["Estado"]);
                    cbx_estado.Text = rows["Nombre_Estado"].ToString();
                    v_codigo_categoria = Convert.ToInt32(rows["Categoria"]);
                    cbx_categoria.Text = rows["Nombre_Categoria"].ToString();
                    v_codigo_marca = Convert.ToInt32(rows["Marca"]);
                    cbx_marca.Text = rows["Nombre_Marca"].ToString();
                    txt_proveedor.Text = rows["Proveedor"].ToString();
                    cbx_modo_venta.Text = rows["ModoVenta"].ToString();
                    txt_cantidad.Text = "";
                    rd_entrada.Checked = true;
                    txt_costo.Text = rows["Costo"].ToString();
                    txt_precio_venta.Text = rows["PrecioVenta"].ToString();
                    txt_subcantidad.Text = rows["SubCantidad"].ToString();
                    txt_valor_subcantidad.Text = rows["ValorSubcantidad"].ToString();
                    txt_sobres.Text = rows["Sobres"].ToString();
                    txt_valor_sobres.Text = rows["ValorSobre"].ToString();
                    byte[] imagen = (byte[])rows["Foto"];
                    Foto = byteArrayToImage(imagen);
                    pbx_foto.Image = Foto;
                    double v_stock_actual = Convert.ToDouble(rows["Stock_actual"]);
                    lbl_stock_actual.Text = v_stock_actual.ToString("N");
                    txt_stock_minimo.Text = rows["Stock_minimo"].ToString();
                    txt_stock_maximo.Text = rows["Stock_maximo"].ToString();
                    cbx_ubicacion.Text = rows["Nombre_ubicacion"].ToString();
                    cbx_salida_para.Text = rows["Nombre_Salida_para"].ToString();
                }
            }
            else
            {
                txt_item.Text = "";
                txt_referencia.Text = "";
                txt_nombre.Text = "";
                txt_iva.Text = "0";
                cbx_unidad_medida.Text = "N/A";
                txt_medida.Text = "0";
                cbx_estado.Text = "Activo";
                cbx_categoria.Text = "N/A";
                cbx_marca.Text = "N/A";
                txt_proveedor.Text = "0";
                txt_nom_proveedor.Text = "";
                cbx_modo_venta.Text = "Unidad";
                txt_cantidad.Text = "";
                txt_costo.Text = "";
                txt_precio_venta.Text = "";
                txt_codigo_barras.Text = "";
                txt_subcantidad.Text = "0";
                txt_valor_subcantidad.Text = "0";
                txt_sobres.Text = "0";
                txt_valor_sobres.Text = "0";
                lbl_stock_actual.Text = "0";
                txt_stock_minimo.Text = "0";
                txt_stock_maximo.Text = "0";
                cbx_ubicacion.Text = "N/A";
                cbx_salida_para.Text = "N/A";
            }
        }
        private void mtd_validar_integridad_guardar_producto()
        {
            //1.validar integridad de referencia
            cls_Producto.v_tipo_busqueda = "Validar_referencia";
            cls_Producto.Referencia = txt_referencia.Text;
            v_dt = cls_Producto.mtd_consultar_producto();
            if (v_dt.Rows.Count > 0)
            {
                v_row = v_dt.Rows[0];
                if (v_row["Referencia"].ToString() != "")
                { 
                    errorProvider.SetError(txt_referencia, "Referencia ya existe");
                    v_validado++;
                }         
            }
            //2.Validar integridad codigo de barras
            cls_Producto.v_tipo_busqueda = "Validar_codigo_barras";
            cls_Producto.CodigoBarras = txt_codigo_barras.Text;
            v_dt = cls_Producto.mtd_consultar_producto();
            if (v_dt.Rows.Count > 0)
            {
                v_row = v_dt.Rows[0];
                if (v_row["CodigoBarras"].ToString() != "")
                {
                    errorProvider.SetError(txt_codigo_barras, "Codigo de barras ya existe");
                    v_validado++;
                }        
            }
            //3.Validar integridad de item
            cls_Producto.v_tipo_busqueda = "Validar_Item";
            cls_Producto.Item = txt_item.Text;
            v_dt = cls_Producto.mtd_consultar_producto();
            if (v_dt.Rows.Count > 0)
            {
                errorProvider.SetError(txt_item, "Item ya existe");
                v_validado++;
            }
        }
        private void mtd_validar_integridad_editar_producto()
        {
            //1.validar integridad de referencia
            if (txt_referencia.Text.Trim() != "")
            {
                cls_Producto.v_tipo_busqueda = "Validar_referencia";
                cls_Producto.Referencia = txt_referencia.Text.Trim();
                v_dt = cls_Producto.mtd_consultar_producto();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    if (v_row["Item"].ToString() != v_item_producto)
                    {
                        errorProvider.SetError(txt_referencia, "Referencia ya existe");
                        v_validado++;
                    }
                }
            }

            //2.validar integridad codigo de barras
            if (txt_codigo_barras.Text.Trim() != "")
            {
                cls_Producto.v_tipo_busqueda = "Validar_codigo_barras";
                cls_Producto.CodigoBarras = txt_codigo_barras.Text.Trim();
                v_dt = cls_Producto.mtd_consultar_producto();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    if (v_row["Item"].ToString() != v_item_producto)
                    {
                        errorProvider.SetError(txt_codigo_barras, "Codigo de barras ya existe");
                        v_validado++;
                    }
                }
            }     
        }
        private void mtd_guardar()
        {
            mtd_validar_integridad_guardar_producto();
            if (v_validado == 0)
            {
                //consultar codigo de caracteristicas producto
                v_dt = cls_Producto.mtd_consultar_caracteristicas_producto();
                foreach (DataRow rows in v_dt.Rows)
                {
                    //cargar Unidadmedida
                    if (rows["Tabla"].ToString() == "UnidadMedida")
                    {
                        if (cbx_unidad_medida.Text == rows["Nombre"].ToString())
                        {
                            cls_Producto.UnidadMedida = Convert.ToInt32(rows["Codigo"]);
                        }
                    }
                    //cargar Estado
                    if (rows["Tabla"].ToString() == "Estado")
                    {
                        if (cbx_estado.Text == rows["Nombre"].ToString())
                        {
                            cls_Producto.Estado = Convert.ToInt32(rows["Codigo"]);
                        }
                    }
                    //cargar Categoria
                    if (rows["Tabla"].ToString() == "Categoria")
                    {
                        if (cbx_categoria.Text == rows["Nombre"].ToString())
                        {
                            cls_Producto.Categoria = Convert.ToInt32(rows["Codigo"]);
                        }
                    }
                    //cargar Marca
                    if (rows["Tabla"].ToString() == "Marca")
                    {
                        if (cbx_marca.Text == rows["Nombre"].ToString())
                        {
                            cls_Producto.Marca = Convert.ToInt32(rows["Codigo"]);
                        }
                    }
                    //cargar Ubicacion
                    if (rows["Tabla"].ToString() == "Ubicacion")
                    {
                        if (cbx_ubicacion.Text == rows["Nombre"].ToString())
                        {
                            cls_Producto.Ubicacion = Convert.ToInt32(rows["Codigo"]);
                        }
                    }
                    //cargar Salida_para
                    if (rows["Tabla"].ToString() == "SalidaPara")
                    {
                        if (cbx_salida_para.Text == rows["Nombre"].ToString())
                        {
                            cls_Producto.SalidaPara = Convert.ToInt32(rows["Codigo"]);
                        }
                    }
                }

                cls_Producto.Nombre = txt_nombre.Text;
                cls_Producto.Descripcion = txt_descripcion.Text;
                cls_Producto.Item = txt_item.Text;
                cls_Producto.Referencia = txt_referencia.Text;
                cls_Producto.CodigoBarras = txt_codigo_barras.Text;
                cls_Producto.IVA = float.Parse(txt_iva.Text);              
                cls_Producto.Medida = float.Parse(txt_medida.Text);               
                cls_Producto.Proveedor = txt_proveedor.Text;
                cls_Producto.ModoVenta = cbx_modo_venta.Text;
                cls_Producto.Costo = Convert.ToDouble(txt_costo.Text);
                cls_Producto.Costo_productoCalculado = Convert.ToDouble(txt_c_d_iva.Text);                
                cls_Producto.PrecioVenta = Convert.ToDouble(txt_precio_venta.Text);
                cls_Producto.StockMinimo = Convert.ToInt32(txt_stock_minimo.Text);
                cls_Producto.StockMaximo = Convert.ToInt32(txt_stock_maximo.Text);
                cls_Producto.Cantidad = Convert.ToDouble(txt_cantidad.Text);
                if (rd_entrada.Checked == true)
                {
                    cls_Producto.movimiento = rd_entrada.Text;
                }
                else
                {
                    cls_Producto.movimiento = rd_salida.Text;
                }    
                cls_Producto.SubCantidad = float.Parse(txt_subcantidad.Text);
                cls_Producto.ValorSubcantidad = Convert.ToDouble(txt_valor_subcantidad.Text);
                cls_Producto.Sobres = Convert.ToInt32(txt_sobres.Text);
                cls_Producto.ValorSobres = Convert.ToDouble(txt_valor_sobres.Text);
                cls_Producto.Foto = pbx_foto.Image;
                cls_Producto.descuento_proveedor = txt_desc.Text;
                cls_Producto.FechaVencimiento = txt_fecha_vence.Text;
                cls_Producto.Usuario = Convert.ToInt32(Usuario);
                cls_Producto.Nota = txt_nota.Text;

                v_ok = cls_Producto.mtd_registrar();

                frm_msg frm_Msg = new frm_msg();
                if (v_ok == true)
                {
                    frm_Msg.txt_mensaje.Text = "Producto registrado correctamente";
                    frm_Msg.ShowDialog();
                    mtd_limpiar();
                    txt_nombre.Focus();
                }
            }
        }
        private void mtd_editar()
        {
            mtd_validar_integridad_editar_producto();
            if (v_validado == 0)
            {
                frm_confirmacion frm_Confirmacion = new frm_confirmacion();
                frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea editar el producto?";
                frm_Confirmacion.ShowDialog();
                if (v_confirmacion == true)
                { 
                    //consultar codigo de caracteristicas producto
                    v_dt = cls_Producto.mtd_consultar_caracteristicas_producto();
                    foreach (DataRow rows in v_dt.Rows)
                    {
                        //cargar Unidadmedida
                        if (rows["Tabla"].ToString() == "UnidadMedida")
                        {
                            if (cbx_unidad_medida.Text == rows["Nombre"].ToString())
                            {
                                cls_Producto.UnidadMedida = Convert.ToInt32(rows["Codigo"]);
                            }
                        }
                        //cargar Estado
                        if (rows["Tabla"].ToString() == "Estado")
                        {
                            if (cbx_estado.Text == rows["Nombre"].ToString())
                            {
                                cls_Producto.Estado = Convert.ToInt32(rows["Codigo"]);
                            }
                        }
                        //cargar Categoria
                        if (rows["Tabla"].ToString() == "Categoria")
                        {
                            if (cbx_categoria.Text == rows["Nombre"].ToString())
                            {
                                cls_Producto.Categoria = Convert.ToInt32(rows["Codigo"]);
                            }
                        }
                        //cargar Marca
                        if (rows["Tabla"].ToString() == "Marca")
                        {
                            if (cbx_marca.Text == rows["Nombre"].ToString())
                            {
                                cls_Producto.Marca = Convert.ToInt32(rows["Codigo"]);
                            }
                        }
                        //cargar Ubicacion
                        if (rows["Tabla"].ToString() == "Ubicacion")
                        {
                            if (cbx_ubicacion.Text == rows["Nombre"].ToString())
                            {
                                cls_Producto.Ubicacion = Convert.ToInt32(rows["Codigo"]);
                            }
                        }
                        //cargar Salida_para
                        if (rows["Tabla"].ToString() == "SalidaPara")
                        {
                            if (cbx_salida_para.Text == rows["Nombre"].ToString())
                            {
                                cls_Producto.SalidaPara = Convert.ToInt32(rows["Codigo"]);
                            }
                        }
                    }

                    cls_Producto.Nombre = txt_nombre.Text;
                    cls_Producto.Descripcion = txt_descripcion.Text;
                    cls_Producto.Item = txt_item.Text;
                    cls_Producto.Referencia = txt_referencia.Text;
                    cls_Producto.CodigoBarras = txt_codigo_barras.Text;
                    cls_Producto.IVA = float.Parse(txt_iva.Text);
                    cls_Producto.Medida = float.Parse(txt_medida.Text);
                    cls_Producto.Proveedor = txt_proveedor.Text;
                    cls_Producto.ModoVenta = cbx_modo_venta.Text;
                    cls_Producto.Costo = Convert.ToDouble(txt_costo.Text);
                    cls_Producto.Costo_productoCalculado = Convert.ToDouble(txt_c_d_iva.Text);
                    cls_Producto.PrecioVenta = Convert.ToDouble(txt_precio_venta.Text);
                    cls_Producto.StockMinimo = Convert.ToInt32(txt_stock_minimo.Text);
                    cls_Producto.StockMaximo = Convert.ToInt32(txt_stock_maximo.Text);
                    cls_Producto.Cantidad = Convert.ToDouble(txt_cantidad.Text);
                    if (rd_entrada.Checked == true)
                    {
                        cls_Producto.movimiento = rd_entrada.Text;
                    }
                    else
                    {
                        cls_Producto.movimiento = rd_salida.Text;
                    }
                    cls_Producto.SubCantidad = float.Parse(txt_subcantidad.Text);
                    cls_Producto.ValorSubcantidad = Convert.ToDouble(txt_valor_subcantidad.Text);
                    cls_Producto.Sobres = Convert.ToInt32(txt_sobres.Text);
                    cls_Producto.ValorSobres = Convert.ToDouble(txt_valor_sobres.Text);
                    cls_Producto.Foto = pbx_foto.Image;
                    cls_Producto.descuento_proveedor = txt_desc.Text;
                    cls_Producto.FechaVencimiento = txt_fecha_vence.Text;
                    cls_Producto.Usuario = Convert.ToInt32(Usuario);
                    cls_Producto.Nota = txt_nota.Text;

                    v_ok = cls_Producto.mtd_Editar();

                    frm_msg frm_Msg = new frm_msg();
                    if (v_ok == true)
                    {
                        frm_Msg.txt_mensaje.Text = "Producto Editado correctamente";
                        frm_Msg.ShowDialog();
                        mtd_limpiar();
                        txt_nombre.Focus();
                    }
                }
            }
        }
        private void mtd_cargar_ubicacion()
        {
            cls_Ubicacion.v_tipo_busqueda = "Normal";
            v_dt = cls_Ubicacion.mtd_consultar_ubicacion();
            errorProvider.Clear();
            v_caracteristica = cbx_ubicacion.Text;
            cbx_ubicacion.Items.Clear();
            foreach (DataRow rows in v_dt.Rows)
            {
                cbx_ubicacion.Items.Add(rows["Nombre"]);
            }
            cbx_ubicacion.Text = v_caracteristica;
        }
        private void mtd_cargar_salida_para()
        {
            cls_salida_para.v_tipo_busqueda = "Normal";
            v_dt = cls_salida_para.mtd_consultar_salida_para();
            errorProvider.Clear();
            v_caracteristica = cbx_salida_para.Text;
            cbx_salida_para.Items.Clear();
            foreach (DataRow rows in v_dt.Rows)
            {
                cbx_salida_para.Items.Add(rows["Nombre"]);
            }
            cbx_salida_para.Text = v_caracteristica;
        }
        private void mtd_cargar_consecutivo_item()
        {
                cls_Producto.v_tipo_busqueda = "Buscar_consecutivo_item";
                cls_Producto.Item = "0";
                v_dt = cls_Producto.mtd_consultar_producto();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    txt_item.Text = string.Format("{0:0000}",v_row["item"]);
                }
        }
        public void mtd_dato_venta(string info)
        {
            //mtd_limpiar();
            //cls_Producto.v_tipo_busqueda = "Buscar_data_producto_exacto_item";
            int Item = Convert.ToInt32(info);
            //cls_Producto.Item = Item.ToString();
            //v_dt = cls_Producto.mtd_consultar_producto();

            cls_Producto.Item = Item.ToString();
            v_dt = cls_Producto.mtd_consultar_dato_inventario();
            int contador = 0;
            if (v_dt.Rows.Count > 0) 
            {
                foreach (DataRow item in v_dt.Rows)
                {
                    if (contador == 0)
                    {
                        cbx_modo_venta.Text = item["ModoVenta"].ToString();
                        txt_nombre.Text = item["Nombre"].ToString();
                        txt_descripcion.Text = item["Descripcion"].ToString();
                        v_item_producto = item["item"].ToString();
                        txt_item.Text = string.Format("{0:0000}", item["item"]);
                        txt_referencia.Text = item["Referencia"].ToString();
                        txt_codigo_barras.Text = item["CodigoBarras"].ToString();
                        txt_iva.Text = item["IVA"].ToString();
                        cbx_unidad_medida.Text = item["Nombre_Unidad_medida"].ToString();
                        txt_medida.Text = item["Medida"].ToString();
                        cbx_estado.Text = item["Nombre_Estado"].ToString();
                        cbx_categoria.Text = item["Nombre_Categoria"].ToString();
                        cbx_marca.Text = item["Nombre_Marca"].ToString();
                        txt_subcantidad.Text = item["SubCantidad"].ToString();
                        v_valores = Convert.ToDouble(item["ValorSubcantidad"]);
                        txt_valor_subcantidad.Text = v_valores.ToString("N");
                        txt_sobres.Text = item["Sobres"].ToString();
                        v_valores = Convert.ToDouble(item["ValorSobre"]);
                        txt_valor_sobres.Text = v_valores.ToString("N");
                        txt_proveedor.Text = item["Proveedor"].ToString();
                        v_valores = Convert.ToDouble(item["Costo"]);
                        txt_costo.Text = v_valores.ToString("N");
                        v_valores = Convert.ToDouble(item["PrecioVenta"]);
                        txt_precio_venta.Text = v_valores.ToString("N");
                        cbx_ubicacion.Text = item["Nombre_ubicacion"].ToString();
                        cbx_salida_para.Text = item["Nombre_Salida_para"].ToString();
                        txt_stock_minimo.Text = item["Stock_minimo"].ToString();
                        txt_stock_maximo.Text = item["Stock_maximo"].ToString();
                        txt_cantidad.Text = "0";
                        string ft = item["Foto"].ToString();
                        //if (ft != "System.Byte[]")
                        //{
                        //    byte[] imagen = (byte[])v_row["Foto"];
                        //    pbx_foto.Image = byteArrayToImage(imagen);
                        //}
                        byte[] imagen = (byte[])item["Foto"];
                        pbx_foto.Image = byteArrayToImage(imagen);
                        txt_nom_proveedor.Text = item["Nom_proveedor"].ToString();
                        txt_desc.Text = item["DescuentoProveedor"].ToString();
                        txt_fecha_vence.Text = item["FechaVencimiento"].ToString();
                        txt_nota.Text = item["Nota"].ToString();
                        //calcular Costo - descuento + iva
                        mtd_calculo_costo();
                        //calculiar margen
                        mtd_calcular_margen();
                        //
                        btn_add_fecha_vence.Enabled = true;
                    }
                    else
                    {
                        lbl_stock_actual.Text = item["Stock"].ToString();
                        lbl_sub.Text = item["Stock und"].ToString();
                        lbl_sob.Text = item["Stock Sub"].ToString();
                    }
                    contador++;
                }
            }
            //------------------------------------------------------
            //    if (v_dt.Rows.Count > 0)
            //{ 
            //    v_row = v_dt.Rows[0];
            //    cbx_modo_venta.Text = v_row["ModoVenta"].ToString();
            //    txt_nombre.Text = v_row["Nombre"].ToString();
            //    txt_descripcion.Text = v_row["Descripcion"].ToString();
            //    v_item_producto = v_row["item"].ToString();
            //    txt_item.Text = string.Format("{0:0000}", v_row["item"]);
            //    txt_referencia.Text = v_row["Referencia"].ToString();
            //    txt_codigo_barras.Text = v_row["CodigoBarras"].ToString();
            //    txt_iva.Text = v_row["IVA"].ToString();
            //    cbx_unidad_medida.Text = v_row["Nombre_Unidad_medida"].ToString();
            //    txt_medida.Text = v_row["Medida"].ToString();
            //    cbx_estado.Text = v_row["Nombre_Estado"].ToString();
            //    cbx_categoria.Text = v_row["Nombre_Categoria"].ToString();
            //    cbx_marca.Text = v_row["Nombre_Marca"].ToString();
            //    txt_subcantidad.Text = v_row["SubCantidad"].ToString();
            //    v_valores = Convert.ToDouble(v_row["ValorSubcantidad"]);
            //    txt_valor_subcantidad.Text = v_valores.ToString("N");
            //    txt_sobres.Text = v_row["Sobres"].ToString();
            //    v_valores = Convert.ToDouble(v_row["ValorSobre"]);
            //    txt_valor_sobres.Text = v_valores.ToString("N");
            //    txt_proveedor.Text = v_row["Proveedor"].ToString();              
            //    v_valores = Convert.ToDouble(v_row["Costo"]);
            //    txt_costo.Text = v_valores.ToString("N");
            //    v_valores = Convert.ToDouble(v_row["PrecioVenta"]);
            //    txt_precio_venta.Text = v_valores.ToString("N");
            //    cbx_ubicacion.Text = v_row["Nombre_ubicacion"].ToString();
            //    cbx_salida_para.Text = v_row["Nombre_Salida_para"].ToString();
            //    txt_stock_minimo.Text = v_row["Stock_minimo"].ToString();
            //    txt_stock_maximo.Text = v_row["Stock_maximo"].ToString();
            //    txt_cantidad.Text = "0";
            //    string ft = v_row["Foto"].ToString();
            //    if (ft != "System.Byte[]")
            //    {
            //        byte[] imagen = (byte[])v_row["Foto"];
            //        pbx_foto.Image = byteArrayToImage(imagen);
            //    }
            //    txt_nom_proveedor.Text = v_row["Nom_proveedor"].ToString(); 
            //    txt_desc.Text = v_row["DescuentoProveedor"].ToString();
            //    txt_fecha_vence.Text = v_row["FechaVencimiento"].ToString();
            //    txt_nota.Text = v_row["Nota"].ToString();
            //    //calcular Costo - descuento + iva
            //    mtd_calculo_costo();
            //    //calculiar margen
            //    mtd_calcular_margen();
            //    //
            //    btn_add_fecha_vence.Enabled = true;
            //}
            //cls_Producto.v_tipo_busqueda = "";
            //cls_Producto.v_buscar = info;
            //v_dt = cls_Producto.mtd_consultar_producto_kardex();
            //if (v_dt.Rows.Count > 0)
            //{
            //    v_row = v_dt.Rows[0];
            //    double Stock = Convert.ToDouble(v_row["Stock"]);
            //    lbl_stock_actual.Text = Math.Round(Stock, 2).ToString();
            //    double StockSubCantidad = Convert.ToDouble(v_row["Stock und"]);
            //    lbl_sub.Text = Math.Round(StockSubCantidad, 2).ToString();
            //    double StockSobres = Convert.ToDouble(v_row["Stock Sub"]);
            //    lbl_sob.Text = Math.Round(StockSobres, 2).ToString();
            //}

            txt_item.Enabled = false;
            cbx_modo_venta.Enabled = false;
            txt_subcantidad.Enabled = false;
            txt_sobres.Enabled = false;
           
            mtd_validar();
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        private void mtd_Validar_proveedor()
        {
            cls_proveedor cls_Proveedor = new cls_proveedor();
            if (txt_proveedor.Text.Trim() != "")
            {
                cls_Proveedor.v_buscar = txt_proveedor.Text;
                cls_Proveedor.v_tipo_busqueda = "validacion";
                v_dt = cls_Proveedor.mtd_consultar_proveedor();
                if (v_dt.Rows.Count == 0)
                {
                    errorProvider.SetError(txt_proveedor, "Proveedor No existe");
                    v_validado++;
                }
            }
        }
        private void mtd_dato_proveedor(string info, string info2, string info3)
        {
            txt_proveedor.Text = info;
            txt_nom_proveedor.Text = info2;
        }
        private void mtd_calculo_costo()
        {
           
            double valorDescuento = 0;
            double ValortotalCosto = 0;
            double valorIva = 0;
            vl = 0;
            if (txt_iva.Text == "")
            {
                vl++;
                errorProvider.SetError(txt_iva,"Ingrese IVA");
            }
            if (txt_costo.Text == "")
            {
                vl++;
                errorProvider.SetError(txt_costo, "Ingrese Costo");
            }
            if (txt_desc.Text == "")
            {
                vl++;
                errorProvider.SetError(txt_desc, "Ingrese Descuento");
            }

            if (vl == 0)
            {
                if (!cls_Global.IsNumericDouble(txt_iva.Text))
                {
                    vl++;
                    errorProvider.SetError(txt_iva, "Ingrese valores numericos");
                }
                if (!cls_Global.IsNumericDouble(txt_costo.Text))
                {
                    vl++;
                    errorProvider.SetError(txt_costo, "Ingrese valores numericos");
                }
                if (!cls_Global.IsNumericDouble(txt_desc.Text))
                {
                    vl++;
                    errorProvider.SetError(txt_desc, "Ingrese valores numericos");
                }

                if (vl == 0)
                {
                    //aplicar descuentos
                    valorDescuento = Convert.ToDouble(txt_costo.Text) * (Convert.ToDouble(txt_desc.Text) / 100);
                    ValortotalCosto = Convert.ToDouble(txt_costo.Text) - valorDescuento;
                    //aplicar iva
                    valorIva = ValortotalCosto * (Convert.ToDouble(txt_iva.Text)/100);
                    ValortotalCosto = ValortotalCosto + valorIva;
                    txt_c_d_iva.Text = ValortotalCosto.ToString("N2");
                }
            }

            if (vl != 0)
            {
                txt_c_d_iva.Text = "";
                txt_precio_venta.Text = "";
                txt_margen.Text = "";
            }
            
        }

        private void mtd_calcular_precio_venta()
        {         
            //    double preVenta = 0;
            //vl = 0;
            //if (txt_c_d_iva.Text == "")
            //{
            //    vl++;
            //    errorProvider.SetError(txt_c_d_iva, "Falta valor costo");
            //}
            //if (txt_margen.Text == "")
            //{
            //    vl++;
            //    errorProvider.SetError(txt_margen, "Ingrese margen");
            //}
          
            //if (vl == 0)
            //{
            //    if (cls_Global.IsNumericDouble(txt_margen.Text))
            //    {
            //        if (Convert.ToDouble(txt_margen.Text) == 100)
            //        {
            //            double margen = Convert.ToDouble(txt_margen.Text) - 1;
            //            txt_margen.Text = margen.ToString();
            //        }
            //        preVenta = Convert.ToDouble(txt_c_d_iva.Text) / (1-(Convert.ToDouble(txt_margen.Text)/100));
            //        txt_precio_venta.Text = preVenta.ToString("N0");
            //    }
            //    else
            //    {
            //        errorProvider.SetError(txt_margen,"Ingrese valores numericos");
            //    }
            //}
            //else
            //{
            //    txt_precio_venta.Text = "";
            //}
            
        }
        private void mtd_calcular_margen()
        {
          
                double Margen = 0;
                vl = 0;
                if (txt_c_d_iva.Text == "")
                {
                    vl++;
                    errorProvider.SetError(txt_c_d_iva, "Falta valor costo");
                }
                if (txt_precio_venta.Text == "")
                {
                    vl++;
                    errorProvider.SetError(txt_precio_venta, "Ingrese Precio venta");
                }

                if (vl == 0)
                {
                    if (cls_Global.IsNumericDouble(txt_precio_venta.Text))
                    {
                        Margen = (Convert.ToDouble(txt_precio_venta.Text) - Convert.ToDouble(txt_c_d_iva.Text));
                        Margen = Margen / Convert.ToDouble(txt_precio_venta.Text);
                        Margen = Margen * 100;
                        txt_margen.Text = Margen.ToString();
                    }
                    else
                    {
                        errorProvider.SetError(txt_precio_venta, "Ingrese valores numericos");
                    }
                }
                else
                {
                    txt_margen.Text = "";
                }
            
        }

        //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            mtd_limpiar();
        }
        private void txt_item_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_iva_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbx_modo_venta.Text != "Queso")
            {
                cls_Global.ValidaNumeros(e);
            }
        }
        private void txt_sobres_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            mtd_validar();
            if (v_validado == 0)
            {      
            //mtd_calculo_costo();
            //if (vl == 0)
            //{
            //    mtd_calcular_precio_venta();
            //    if (vl == 0)
            //    {
            //        mtd_calcular_margen();
            //        if (vl == 0)
            //        {
            //            mtd_validar();
            //            //validar que sea una entrada al guardar
            //            if (cbx_modo_venta.Enabled == true)
            //            {
            //                if (rd_entrada.Checked == false)
            //                {
            //                    errorProvider.SetError(rd_entrada, "Seleccione Entrada");
            //                    v_validado++;
            //                }
            //            }

            //            if (v_validado == 0)
            //            {
            //                if (cbx_modo_venta.Enabled == true)
            //                {
            //                    mtd_guardar();
            //                }
            //                else
            //                {
            //                    mtd_editar();
            //                }
            //            }
            //        }
            //        else
            //        {
            //            txt_margen.Text = "";
            //        }
            //    }
            //    else
            //    {
            //        txt_precio_venta.Text = "";
            //    }           
            //}
            //else
            //{
            //    txt_c_d_iva.Text = "";
            //    txt_precio_venta.Text = "";
            //    txt_margen.Text = "";
            //}
                //
                if (cbx_modo_venta.Enabled == true)
                {
                    mtd_guardar();
                }
                else
                {
                    mtd_editar();
                }
            }
        }
        private void cbx_modo_venta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_modo_venta.Text)
            {
                case "Unidad":
                    lbl_subcantidad.Visible = false;
                    txt_subcantidad.Text = "0";
                    txt_subcantidad.Visible = false;
                    lbl_valor_subcantidad.Visible = false;
                    txt_valor_subcantidad.Text = "0";
                    txt_valor_subcantidad.Visible = false;
                    lbl_sobres.Visible = false;
                    txt_sobres.Text = "0";
                    txt_sobres.Visible = false;
                    lbl_valor_sobre.Visible = false;
                    txt_valor_sobres.Text = "0";
                    txt_valor_sobres.Visible = false;
                    label24.Visible = false;
                    lbl_sub.Visible = false;
                    label25.Visible = false;
                    lbl_sob.Visible = false;
                    break;
                case "Pesaje":
                    lbl_subcantidad.Visible = true;
                    txt_subcantidad.Text = "";
                    txt_subcantidad.Visible = true;
                    lbl_valor_subcantidad.Visible = true;
                    txt_valor_subcantidad.Text = "";
                    txt_valor_subcantidad.Visible = true;
                    lbl_sobres.Visible = false;
                    txt_sobres.Text = "0";
                    txt_sobres.Visible = false;
                    lbl_valor_sobre.Visible = false;
                    txt_valor_sobres.Text = "0";
                    txt_valor_sobres.Visible = false;
                    label24.Visible = true;
                    lbl_sub.Visible = true;
                   
                    break;
                case "Multi":
                    lbl_subcantidad.Visible = true;
                    txt_subcantidad.Text = "";
                    txt_subcantidad.Visible = true;
                    lbl_valor_subcantidad.Visible = true;
                    txt_valor_subcantidad.Text = "";
                    txt_valor_subcantidad.Visible = true;
                    lbl_sobres.Visible = true;
                    txt_sobres.Text = "";
                    txt_sobres.Visible = true;
                    lbl_valor_sobre.Visible = true;
                    txt_valor_sobres.Text = "";
                    txt_valor_sobres.Visible = true;
                    label24.Visible = true;
                    lbl_sub.Visible = true;
                    label25.Visible = true;
                    lbl_sob.Visible = true;
                    break;
                case "Desechable":
                    lbl_subcantidad.Visible = true;
                    txt_subcantidad.Text = "";
                    txt_subcantidad.Visible = true;
                    lbl_valor_subcantidad.Visible = true;
                    txt_valor_subcantidad.Text = "";
                    txt_valor_subcantidad.Visible = true;
                    lbl_sobres.Visible = false;
                    txt_sobres.Text = "0";
                    txt_sobres.Visible = false;
                    lbl_valor_sobre.Visible = false;
                    txt_valor_sobres.Text = "0";
                    txt_valor_sobres.Visible = false;
                    label24.Visible = true;
                    lbl_sub.Visible = true;

                    break;
                case "Queso":
                    lbl_subcantidad.Visible = false;
                    txt_subcantidad.Text = "0";
                    txt_subcantidad.Visible = false;
                    lbl_valor_subcantidad.Visible = false;
                    txt_valor_subcantidad.Text = "0";
                    txt_valor_subcantidad.Visible = false;
                    lbl_sobres.Visible = false;
                    txt_sobres.Text = "0";
                    txt_sobres.Visible = false;
                    lbl_valor_sobre.Visible = false;
                    txt_valor_sobres.Text = "0";
                    txt_valor_sobres.Visible = false;
                    label24.Visible = false;
                    lbl_sub.Visible = false;
                    label25.Visible = false;
                    lbl_sob.Visible = false;
                    break;
            }
            if (v_validar == true)
            {
                mtd_validar();
            }
            v_validar = true;        
        }
        private void btn_foto_Click(object sender, EventArgs e)
        {
            mtd_cargar_foto();
        }
        private void txt_item_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_referencia_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            dtg_busca_nombre.Rows.Clear();
            pnl_nombres.Visible = false;
        }
        private void txt_iva_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_medida_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_proveedor_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_costo_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_precio_venta_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_codigo_barras_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_subcantidad_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_valor_subcantidad_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_sobres_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_valor_sobres_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        //Control de teclas F
        private void frm_producto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                mtd_validar();
            }
            if (e.KeyCode == Keys.F2)
            {
                mtd_limpiar();
            }
            if (e.KeyCode == Keys.F3)
            {
                MessageBox.Show("Consultas");
            }
        }
        //fin control de teclas F
        private void cbx_unidad_medida_Click(object sender, EventArgs e)
        {
            mtd_cargar_unidad_medida();
        }
        private void cbx_estado_Click(object sender, EventArgs e)
        {
            mtd_cargar_estado();
        }
        private void cbx_categoria_Click(object sender, EventArgs e)
        {
            mtd_cargar_categoria();
        }
        private void cbx_marca_Click(object sender, EventArgs e)
        {
            mtd_cargar_marca();
        }
        frm_caracteristicas frm_Caracteristicas;
        private void btn_caracteristicas_Click(object sender, EventArgs e)
        {
            if (frm_Caracteristicas == null || frm_Caracteristicas.IsDisposed)
            {
                frm_Caracteristicas = new frm_caracteristicas();
                frm_Caracteristicas.Show();
            }
            else
            {
                frm_Caracteristicas.BringToFront();
                frm_Caracteristicas.WindowState = FormWindowState.Normal;
            }       
        }
        private void pnl_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lbl_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        frm_proveedor frm_Proveedor;
        private void btn_agregar_proveedor_Click(object sender, EventArgs e)
        {
            if (frm_Proveedor == null || frm_Proveedor.IsDisposed)
            {
                frm_Proveedor = new frm_proveedor(true);
                frm_Proveedor.v_dt_Permi = this.v_dt_Permi;
                frm_Proveedor.Show();
            }
            else
            {
                frm_Proveedor.BringToFront();
                frm_Proveedor.WindowState = FormWindowState.Normal;
            }
        }
        frm_ayuda frm_Ayuda;
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (frm_Ayuda == null || frm_Ayuda.IsDisposed)
            {
                frm_Ayuda = new frm_ayuda("Buscar proveedor");
                frm_Ayuda.Enviainfo2 += new frm_ayuda.EnviarInfo2(mtd_dato_proveedor);
                frm_Ayuda.Show();
            }
            else
            {
                frm_Ayuda.BringToFront();
                frm_Ayuda.WindowState = FormWindowState.Normal;
            }
        }
        private void txt_stock_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_stock_maximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void cbx_ubicacion_Click(object sender, EventArgs e)
        {
            mtd_cargar_ubicacion();
        }
        private void cbx_salida_para_Click(object sender, EventArgs e)
        {
            mtd_cargar_salida_para();
        }
        private void txt_stock_minimo_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void txt_stock_maximo_Leave(object sender, EventArgs e)
        {
            mtd_validar();
        }
        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            if (frm_Ayuda == null || frm_Ayuda.IsDisposed)
            {
                frm_Ayuda = new frm_ayuda("Buscar producto");
                frm_Ayuda.Enviainfo += new frm_ayuda.EnviarInfo(mtd_dato_venta);
                frm_Ayuda.Show();
            }
            else
            {
                frm_Ayuda.BringToFront();
                frm_Ayuda.WindowState = FormWindowState.Normal;
            }
        }
        frm_movimientos frm_Movimientos;
        private void btn_consultas_Click(object sender, EventArgs e)
        {
            if (frm_Movimientos == null || frm_Movimientos.IsDisposed)
            {
                frm_Movimientos = new frm_movimientos();
                frm_Movimientos.Show();
            }
            else
            {
                frm_Movimientos.BringToFront();
                frm_Movimientos.WindowState = FormWindowState.Normal;
            }
        }
        private void lbl_cerrar_b_n_Click(object sender, EventArgs e)
        {
            dtg_busca_nombre.Rows.Clear();
            pnl_nombres.Visible = false;
        }
        private void txt_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_nombre.Text != "")
            {           
                pnl_nombres.Visible = true;
                       
                cls_Producto.v_tipo_busqueda = "Buscar_nombre";
                cls_Producto.v_buscar = txt_nombre.Text;
                v_dt = cls_Producto.mtd_consultar_producto();
                dtg_busca_nombre.Rows.Clear();
                if (v_dt.Rows.Count > 0)
                {
                    v_contador = 0;
                    v_filas = v_dt.Rows.Count;
                    dtg_busca_nombre.Rows.Add(v_filas);
                    foreach (DataRow rows in v_dt.Rows)
                    {
                        dtg_busca_nombre.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"];
                        v_contador++;
                    }
                }
            }
            else
            {
                dtg_busca_nombre.Rows.Clear();
                pnl_nombres.Visible = false;
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void txt_proveedor_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_Validar_proveedor();
        }
        private void Txt_iva_KeyUp(object sender, KeyEventArgs e)
        {
            //mtd_calculo_costo();
        }
        private void Txt_costo_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_calculo_costo();
        }
        private void Txt_desc_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_calculo_costo();
        }
        private void Txt_margen_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_calcular_precio_venta();
        }
        private void Txt_precio_venta_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_calcular_margen();
        }

        private void Btn_add_fecha_vence_Click(object sender, EventArgs e)
        {
            if (txt_item.Text != "")
            {
                frm_fechas_vencimiento frm_fecha_vence = new frm_fechas_vencimiento();
                frm_fecha_vence.Item = txt_item.Text;
                frm_fecha_vence.ShowDialog();
            }
        }
    }
}
