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
    public partial class frm_Creditos : Form
    {
        cls_credito cls_credito = new cls_credito();

        //Variables
        DataTable v_dt;
        int v_fila = 0;
        int v_contador = 0;
        bool v_confirmacion;
        bool v_ok;
        int Eliminados;
        int Error;
        string moduloSP = "";
        public DataTable v_dt_Permi { get; set; }
        List<int> listaSeparados;
        public string Usuario { get; set; }
        public frm_Creditos()
        {
            InitializeComponent();
            cbx_tipo_busqueda.SelectedIndex = 0;
            MensajeInformativoBotones();
        }
        public frm_Creditos(List<int> separado, string modulo)
        {
            InitializeComponent();
            listaSeparados = new List<int>();
            moduloSP = modulo;
            foreach (var item in separado)
            {
                listaSeparados.Add(item);
            }
            btn_exportar_excel.Visible = false;
            btn_eliminar.Visible = false;           
            label3.Visible = false;
            dtp_fecha_inicio.Visible = false;
            label2.Visible = false;
            dtp_fecha_fin.Visible = false;
            cbx_tipo_busqueda.Visible = false;
            txt_buscar.Visible = false;
            btn_buscar.Visible = false;
            mtd_cargar_separados();
        }

        //Metodos
        private void mtd_cargar_separados()
        {
            v_dt = new DataTable();
            if (moduloSP == "")
            {
                cls_credito.v_tipo_busqueda = cbx_tipo_busqueda.Text;
                if (txt_buscar.Text == "Num-cliente-producto")
                {
                    cls_credito.v_buscar = "";
                }
                else
                {
                    cls_credito.v_buscar = txt_buscar.Text;
                }
                cls_credito.v_tipo_busqueda = cbx_tipo_busqueda.Text;
                cls_credito.Fecha_inicio = dtp_fecha_inicio.Value;
                cls_credito.Fecha_fin = dtp_fecha_fin.Value;
                v_dt = cls_credito.mtd_consultar_credito();
            }
            else
            {
                if (listaSeparados.Count > 0)
                {
                    cls_credito.v_tipo_busqueda = cbx_tipo_busqueda.Text;
                    cls_credito.Fecha_inicio = dtp_fecha_inicio.Value;
                    cls_credito.Fecha_fin = dtp_fecha_fin.Value;
                    string buscar = "";
                    foreach (var item in listaSeparados)
                    {
                        buscar += "" + item + ",";
                    }
                    buscar = buscar.Substring(0, buscar.Length - 1);
                    cls_credito.v_buscar = buscar;
                    v_dt = cls_credito.mtd_consultar_credito_exacto();
                }         
            }
            
            dtg_sistema_separado.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                v_fila = v_dt.Rows.Count;
                dtg_sistema_separado.Rows.Add(v_fila);
                v_contador = 0;
                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_num"].Value = rows["Codigo"];
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_estado"].Value = rows["Estado"];
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_fecha"].Value = rows["Fecha"];
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_cliente"].Value = rows["Cliente"];
                    //dtg_sistema_separado.Rows[v_contador].Cells["cl_producto"].Value = rows["Producto"];
                    //dtg_sistema_separado.Rows[v_contador].Cells["cl_cantidad"].Value = rows["Cantidad"];
                    //double Costo = Convert.ToDouble(rows["Costo"]);
                    //dtg_sistema_separado.Rows[v_contador].Cells["cl_costo"].Value = Costo.ToString("N0");
                    //double PrecioVenta = Convert.ToDouble(rows["PrecioVenta"]);
                    //dtg_sistema_separado.Rows[v_contador].Cells["cl_precio_venta"].Value = PrecioVenta.ToString("N0");
                    double AbonoInicial = Convert.ToDouble(rows["AbonoInicial"]);
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_abono_inicial"].Value = AbonoInicial.ToString("N0");
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_num_cuotas"].Value = rows["NumCuotas"];
                    double ValorCuota = Convert.ToDouble(rows["ValorCuota"]);
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_valor_cuota"].Value = ValorCuota.ToString("N0");
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_periodo_pago"].Value = rows["PeriodoPago"];
                    double Valor = Convert.ToDouble(rows["Valor"]);
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_Total"].Value = Valor.ToString("N0");
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_fecha_primer_pago"].Value = rows["FechaPrimerPago"];
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_fecha_vence"].Value = rows["FechaVence"];
                    //double cl_valor_abono = Convert.ToDouble(rows["ValorAbono"]);
                    //dtg_sistema_separado.Rows[v_contador].Cells["cl_valor_abono"].Value = cl_valor_abono.ToString("N0");
                    //dtg_sistema_separado.Rows[v_contador].Cells["cl_fecha_abono"].Value = rows["FechaAbono"];
                    dtg_sistema_separado.Rows[v_contador].Cells["cl_factura"].Value = rows["Factura"];
                    
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
            if (dtg_sistema_separado.Rows.Count > 0)
            {
                if (dtg_sistema_separado.SelectedRows.Count > 0)
                { 
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    v_contador = dtg_sistema_separado.SelectedRows.Count;
                    frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + "  Separados?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    {
                        Eliminados = 0;
                        Error = 0;
                        foreach (DataGridViewRow rows in dtg_sistema_separado.SelectedRows)
                        {
                            int num = Convert.ToInt32(rows.Cells["cl_num"].Value);
                            cls_credito.Codigo = num;
                            v_ok = cls_credito.mtd_eliminar();
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
            Botones.SetToolTip(btn_abono, "Agregar Abono");
            Botones.SetToolTip(btn_historial, "Historial");
        }
        private void mtd_valor_pagado(double pago,double valor,int codigo_sep)
        {
            if (pago >= valor)
            {
                cls_credito.Codigo = codigo_sep;
                cls_credito.Estado = "Pago";
                cls_credito.mtd_Editar();
            }
            mtd_cargar_separados();
        }

        //Eventos
        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "Num-cliente-producto")
            {
                txt_buscar.Text = "";
                txt_buscar.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "Num-cliente-producto";
                txt_buscar.ForeColor = Color.Silver;
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_cargar_separados();
        }
        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            cls_credito.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            if (txt_buscar.Text == "Num-cliente-producto")
            {
                cls_credito.v_buscar = "";
            }
            else
            {
                cls_credito.v_buscar = txt_buscar.Text;
            }
            cls_credito.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            cls_credito.Fecha_inicio = dtp_fecha_inicio.Value;
            cls_credito.Fecha_fin = dtp_fecha_fin.Value;
            v_dt = cls_credito.mtd_consultar_credito();
            mtd_exporta_excel();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            mtd_eliminar();
            mtd_cargar_separados();
        }
        private void btn_abono_Click(object sender, EventArgs e)
        {
            VerificarCaja();
            if (v_confirmacion == true)
            {
                frm_agregar_abono frm_Agregar_abono = new frm_agregar_abono();
                frm_Agregar_abono.credito = 1;
                if (dtg_sistema_separado.Rows.Count > 0)
                {
                    if (dtg_sistema_separado.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow rows in dtg_sistema_separado.SelectedRows)
                        {
                            frm_Agregar_abono.lbl_num_separado.Text = rows.Cells["cl_num"].Value.ToString();
                            frm_Agregar_abono.lbl_cliente.Text = rows.Cells["cl_cliente"].Value.ToString();
                            frm_Agregar_abono.lbl_valor.Text = rows.Cells["cl_Total"].Value.ToString();
                            frm_Agregar_abono.lbl_num_cuotas.Text = rows.Cells["cl_num_cuotas"].Value.ToString();
                            frm_Agregar_abono.lbl_valor_cuota.Text = rows.Cells["cl_valor_cuota"].Value.ToString();
                            frm_Agregar_abono.lbl_saldo.Text = "0";
                            frm_Agregar_abono.lbl_cuota_num.Text = "0";
                            frm_Agregar_abono.lbl_fecha_inicio.Text = rows.Cells["cl_fecha_primer_pago"].Value.ToString();
                            frm_Agregar_abono.lbl_fecha_fin.Text = rows.Cells["cl_fecha_vence"].Value.ToString();
                            frm_Agregar_abono.lbl_estado.Text = rows.Cells["cl_estado"].Value.ToString();
                            frm_Agregar_abono.usuario = this.Usuario;
                        }
                        frm_Agregar_abono.Enviainfo += new frm_agregar_abono.EnviarInfo(mtd_valor_pagado);
                        frm_Agregar_abono.ShowDialog();
                    }
                }
            }      
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
        frm_historial_separados frm_Historial_separados;
        private void btn_historial_Click(object sender, EventArgs e)
        {
            if (dtg_sistema_separado.Rows.Count > 0)
            {
                if (dtg_sistema_separado.SelectedRows.Count > 0)
                {
                   
                    if (frm_Historial_separados == null || frm_Historial_separados.IsDisposed)
                    {
                        frm_Historial_separados = new frm_historial_separados();
                        foreach (DataGridViewRow rows in dtg_sistema_separado.SelectedRows)
                        {
                            frm_Historial_separados.lbl_num_separado.Text = rows.Cells["cl_num"].Value.ToString();
                            frm_Historial_separados.lbl_cliente.Text = rows.Cells["cl_cliente"].Value.ToString();
                        }
                        frm_Historial_separados.credito = 1;
                        frm_Historial_separados.Show();
                    }
                    else
                    {
                        frm_Historial_separados.BringToFront();
                        frm_Historial_separados.WindowState = FormWindowState.Normal;
                    }

                }
            }
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_cargar_separados();
        }
        private void dtg_sistema_separado_DoubleClick(object sender, EventArgs e)
        {
            //frm_agregar_abono frm_Agregar_abono = new frm_agregar_abono();
            //if (dtg_sistema_separado.Rows.Count > 0)
            //{
            //    if (dtg_sistema_separado.SelectedRows.Count > 0)
            //    {
            //        foreach (DataGridViewRow rows in dtg_sistema_separado.SelectedRows)
            //        {
            //            frm_Agregar_abono.lbl_num_separado.Text = rows.Cells["cl_num"].Value.ToString();
            //            frm_Agregar_abono.lbl_cliente.Text = rows.Cells["cl_cliente"].Value.ToString();
            //            frm_Agregar_abono.lbl_valor.Text = rows.Cells["cl_Total"].Value.ToString();
            //            frm_Agregar_abono.lbl_num_cuotas.Text = rows.Cells["cl_num_cuotas"].Value.ToString();
            //            frm_Agregar_abono.lbl_valor_cuota.Text = rows.Cells["cl_valor_cuota"].Value.ToString();
            //            frm_Agregar_abono.lbl_saldo.Text = "0";
            //            frm_Agregar_abono.lbl_cuota_num.Text = "0";
            //            frm_Agregar_abono.lbl_fecha_inicio.Text = rows.Cells["cl_fecha_primer_pago"].Value.ToString();
            //            frm_Agregar_abono.lbl_fecha_fin.Text = rows.Cells["cl_fecha_vence"].Value.ToString();
            //            frm_Agregar_abono.lbl_estado.Text = rows.Cells["cl_estado"].Value.ToString();
            //        }
            //        frm_Agregar_abono.Enviainfo += new frm_agregar_abono.EnviarInfo(mtd_valor_pagado);
            //        frm_Agregar_abono.ShowDialog();
            //    }              
            //}
        }

        private void frm_separados_Load(object sender, EventArgs e)
        {

        }
    }
}
