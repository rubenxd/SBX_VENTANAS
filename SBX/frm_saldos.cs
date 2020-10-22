using SBX.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX
{
    public partial class frm_saldos : Form
    {
        public int BuscaAutomaticamente { get; set; }
        public int BuscaPaginados { get; set; }
        //Instancias
        cls_producto cls_Producto = new cls_producto();
        string v_buscar = "";
        string v_tipo_busqueda = "";
        string v_dato_busqueda = "";
        DataTable datosProductos;
        Paginar p;
        public frm_saldos()
        {
            InitializeComponent();
        }

        private void frm_saldos_Load(object sender, EventArgs e)
        {
            cbx_tipo_busqueda.SelectedIndex = 0;
            cbx_dato_busqueda.SelectedIndex = 0;
            if (BuscaPaginados == 0)
            {
                panel1.Visible = false;
            }
        }

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
                p = new Paginar("EXECUTE SP_CONSULTA_ESTADO_PRODUCTOS_saldos '" + v_buscar + "','" + cbx_tipo_busqueda.Text + "','" + v_dato_busqueda + "' ", "DataMember1", maximo_x_pagina);
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
                datosProductos = cls_Producto.mtd_consultar_todos_productos_saldos();
                dtg_productos.DataSource = datosProductos;
            }
            datosProductos = cls_Producto.mtd_consultar_todos_productos_saldos_totales();
            dtg_saldos.DataSource = datosProductos;
            this.Cursor = Cursors.Default;
        }

        private void actualizar()
        {
            lbl_registros.Text = p.countRow().ToString();
            lbl_paginas.Text = p.numPag().ToString();
            lbl_ultima_pagina.Text = p.countPag().ToString();
            txt_max_paginas.Text = p.limitRow().ToString();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_cargar_productos();
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (BuscaAutomaticamente == 1)
            {
                mtd_cargar_productos();
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                mtd_cargar_productos();
            }
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
