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
    public partial class frm_domicilios : Form
    {
        cls_domicilio cls_Domicilio = new cls_domicilio();

        //Variables
        DataTable v_dt;
        int v_fila = 0;
        int v_contador = 0;
        bool v_confirmacion;
        bool v_ok;
        int Eliminados;
        int Error;
        public DataTable v_dt_Permi { get; set; }

        public frm_domicilios()
        {
            InitializeComponent();
            cbx_tipo_busqueda.SelectedIndex = 0;
            MensajeInformativoBotones();
        }

        private void frm_domicilios_Load(object sender, EventArgs e)
        {
            foreach (DataRow rows in v_dt_Permi.Rows)
            {
                if (rows["Modulo"].ToString() == "DOMICILIO")
                {
                    switch (rows["Permiso"].ToString())
                    {
                        case "exportar_excel":
                            btn_exportar_excel.Enabled = true;
                            break;
                        case "eliminar":
                            btn_eliminar.Enabled = true;
                            break;
                        case "guardar":
                            btn_pago_domicilio.Enabled = true;
                            break;
                        case "agregar_mensajero":
                            btn_mensajero.Enabled = true;
                            break;
                    }
                }
            }
        }

        //metodos
        private void mtd_cargar_domicilios()
        {
            cls_Domicilio.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            if (txt_buscar.Text == "Num-Celular-DNI-Mensajero-Producto")
            {
                cls_Domicilio.v_buscar = "";
            }
            else
            {
                cls_Domicilio.v_buscar = txt_buscar.Text;
            }
            cls_Domicilio.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            cls_Domicilio.Fecha_inicio = dtp_fecha_inicio.Value;
            cls_Domicilio.Fecha_fin = dtp_fecha_fin.Value;
            v_dt = cls_Domicilio.mtd_consultar_domicilio();
            dtg_domicilio.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                v_fila = v_dt.Rows.Count;
                dtg_domicilio.Rows.Add(v_fila);
                v_contador = 0;
                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_domicilio.Rows[v_contador].Cells["cl_numero"].Value = rows["Domicilio"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_fecha"].Value = rows["Fecha"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_estado"].Value = rows["Estado"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_celular"].Value = rows["Celular"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_dni"].Value = rows["DNI"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_nombre"].Value = rows["Nombre"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_direccion"].Value = rows["Direccion"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_mensajero"].Value = rows["Mensajero"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_factura"].Value = rows["Factura"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_item"].Value = string.Format("{0:0000}", rows["Item"]);
                    dtg_domicilio.Rows[v_contador].Cells["cl_referencia"].Value = rows["Referencia"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_codigo_barras"].Value = rows["CodigoBarras"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_nombre_producto"].Value = rows["NombreProducto"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_cantidad"].Value = rows["Cantidad"];
                    dtg_domicilio.Rows[v_contador].Cells["cl_um"].Value = rows["UM"];
                    double precio = Convert.ToDouble(rows["PrecioVenta"]);
                    dtg_domicilio.Rows[v_contador].Cells["cl_precio"].Value = precio.ToString("N0");
                    dtg_domicilio.Rows[v_contador].Cells["cl_descuento"].Value = rows["descuento"];
                    double ValorDescuento = Convert.ToDouble(rows["ValorDescuento"]);
                    dtg_domicilio.Rows[v_contador].Cells["cl_valor_descuento"].Value = ValorDescuento.ToString("N0");
                    double ValorDomicilio = Convert.ToDouble(rows["ValorDomicilio"]);
                    dtg_domicilio.Rows[v_contador].Cells["cl_valor_domicilio"].Value = ValorDomicilio.ToString("N0");
                    double Total = Convert.ToDouble(rows["Total"]);
                    dtg_domicilio.Rows[v_contador].Cells["cl_total"].Value = Total.ToString("N0");
                    v_contador++;
                }
            }
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        private void mtd_eliminar()
        {
            frm_confirmacion frm_Confirmacion = new frm_confirmacion();
            if (dtg_domicilio.Rows.Count > 0)
            {
                if (dtg_domicilio.SelectedRows.Count > 0)
                {
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    v_contador = dtg_domicilio.SelectedRows.Count;
                    frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + "  Domicilios?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    {
                        Eliminados = 0;
                        Error = 0;
                        foreach (DataGridViewRow rows in dtg_domicilio.SelectedRows)
                        {
                            int num = Convert.ToInt32(rows.Cells["cl_numero"].Value);
                            cls_Domicilio.Codigo = num;
                            v_ok = cls_Domicilio.mtd_eliminar();
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
                    Excel.Cells[IndiceFila + 1, IndiceColumna] = Row[Columna.ColumnName];

                }
            }
            frm_Exportando_excel.mtd_progreso(100);
            frm_Exportando_excel.Hide();

            Excel.Visible = true;
        }
        public void MensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar");
            Botones.SetToolTip(btn_exportar_excel, "Exportar a excel");
            Botones.SetToolTip(btn_eliminar, "Eliminar");
            Botones.SetToolTip(btn_pago_domicilio, "Pagar domicilio");
            Botones.SetToolTip(btn_mensajero, "Agregar Mensajero");
        }

        frm_mensajero frm_Mensajero;
        private void btn_mensajero_Click(object sender, EventArgs e)
        {
            if (frm_Mensajero == null || frm_Mensajero.IsDisposed)
            {
                frm_Mensajero = new frm_mensajero();
                frm_Mensajero.Show();
            }
            else
            {
                frm_Mensajero.BringToFront();
                frm_Mensajero.WindowState = FormWindowState.Normal;
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_cargar_domicilios();
        }
        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            cls_Domicilio.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            if (txt_buscar.Text == "Num-Celular-DNI-Mensajero-Producto")
            {
                cls_Domicilio.v_buscar = "";
            }
            else
            {
                cls_Domicilio.v_buscar = txt_buscar.Text;
            }
            cls_Domicilio.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            cls_Domicilio.Fecha_inicio = dtp_fecha_inicio.Value;
            cls_Domicilio.Fecha_fin = dtp_fecha_fin.Value;
            v_dt = cls_Domicilio.mtd_consultar_domicilio();
            mtd_exporta_excel();
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_cargar_domicilios();
        }
        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "Num-Celular-DNI-Mensajero-Producto")
            {
                txt_buscar.Text = "";
                txt_buscar.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "Num-Celular-DNI-Mensajero-Producto";
                txt_buscar.ForeColor = Color.Silver;
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            mtd_eliminar();
            mtd_cargar_domicilios();
        }
        private void btn_pago_domicilio_Click(object sender, EventArgs e)
        {
            frm_confirmacion frm_Confirmacion = new frm_confirmacion();
            if (dtg_domicilio.Rows.Count > 0)
            {
                if (dtg_domicilio.SelectedRows.Count > 0)
                {
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    v_contador = dtg_domicilio.SelectedRows.Count;
                    frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Agregar " + v_contador + "  Domicilios?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    {
                        Eliminados = 0;
                        Error = 0;
                        foreach (DataGridViewRow rows in dtg_domicilio.SelectedRows)
                        {
                            int num = Convert.ToInt32(rows.Cells["cl_numero"].Value);
                            cls_Domicilio.Codigo = num;
                            v_ok = cls_Domicilio.mtd_Editar();
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
                        frm_Msg.lbl_titulo.Text = "Agregar domicilios";
                        frm_Msg.txt_mensaje.Text = "Agregados: " + Eliminados + ", Errores: " + Error;
                        frm_Msg.ShowDialog();
                        mtd_cargar_domicilios();
                    }
                }
            }
        }
    }
}
