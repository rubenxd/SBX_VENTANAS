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
    public partial class frm_gastos : Form
    {
        public string Codigo { get; set; }
        cls_gastos_m cl_gm = new cls_gastos_m();
        DataTable v_dt;
        DataRow rows;
        int Fila = 0;
        int Contador = 0;
        bool v_confirmacion;
        double TotalGastos = 0;
        double TotalIva = 0;
        double aplicarPermisos = 0;
        int BuscaAutomatica = 0;
        int BuscaPaginado = 0;
        public DataTable v_dt_Permi { get; set; }

        public frm_gastos()
        {
            InitializeComponent();
            aplicarPermisos = 1;
        }
        public frm_gastos(string informe)
        {
            InitializeComponent();
            btn_eliminar.Enabled = false;
            btn_agregar.Enabled = false;
            btn_agregar_gastos.Enabled = false;
            dtp_fecha_inicio.Enabled = false;
            dtp_fecha_fin.Enabled = false;
            txt_buscar.Enabled = false;
            aplicarPermisos = 0;
            mtd_consultar();
        }
        private void frm_gastos_Load(object sender, EventArgs e)
        {
            MensajeInformativoBotones();
            mtd_consultar();
            if (aplicarPermisos == 1)
            {
                foreach (DataRow rows in v_dt_Permi.Rows)
                {
                    if (rows["Modulo"].ToString() == "GASTOS")
                    {
                        switch (rows["Permiso"].ToString())
                        {
                            case "exportar_excel":
                                btn_exportar_excel.Enabled = true;
                                break;
                            case "eliminar":
                                btn_eliminar.Enabled = true;
                                break;
                            case "NomGasto":
                                btn_agregar.Enabled = true;
                                break;
                            case "AgregaGasto":
                                btn_agregar_gastos.Enabled = true;
                                break;
                        }
                    }
                }
            }
            BuscaAutomatica = 0;
            BuscaPaginado = 0;
            //verifica Parametros
            cls_parametros cls_Parametros = new cls_parametros();
            v_dt = cls_Parametros.mtd_consultar_parametros();
            foreach (DataRow item in v_dt.Rows)
            {
                if (item["Buscar_automaticamente"].ToString() == "SI")
                {
                    BuscaAutomatica = 1;
                }
                if (item["Datos_paginados"].ToString() == "SI")
                {
                    BuscaPaginado = 1;
                }
            }
        }
        //metodos
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
            cls_Caja.Usuario = Codigo;
            v_dt = cls_Caja.mtd_consultar_caja();
            if (v_dt.Rows.Count > 0)
            {
                rows = v_dt.Rows[0];
                if (rows["TipoOperacion"].ToString() == "CIERRE")
                {
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    frm_Confirmacion.txt_mensaje.Text = "Debe realizar Apertura de caja para Gastos, ¿Desea realizar apertura de caja?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    {
                        frm_apertura_caja frm_Apertura_caja = new frm_apertura_caja();
                        frm_Apertura_caja.Usuario = Codigo;
                        frm_Apertura_caja.ShowDialog();
                    }
                }
            }
            else
            {
                frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                frm_Confirmacion.txt_mensaje.Text = "Debe realizar Apertura de caja para Gastos, ¿Desea realizar apertura de caja?";
                frm_Confirmacion.ShowDialog();
                if (v_confirmacion == true)
                {
                    frm_apertura_caja frm_Apertura_caja = new frm_apertura_caja();
                    frm_Apertura_caja.Usuario = Codigo;
                    frm_Apertura_caja.ShowDialog();
                }
            }
        }
        public void MensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar");
            Botones.SetToolTip(btn_eliminar, "Eliminar");
            Botones.SetToolTip(btn_agregar, "Nuevo Tipo de Gasto");
            Botones.SetToolTip(btn_agregar_gastos, "Agregar Gasto");
            Botones.SetToolTip(btn_exportar_excel, "Exportar a Excel");
        }
        private void mtd_consultar()
        {
            cl_gm.Buscar = txt_buscar.Text;
            cl_gm.FechaIni = dtp_fecha_inicio.Text;
            cl_gm.Fechafin = dtp_fecha_fin.Text;
            cl_gm.usuario = this.Codigo;
            v_dt = cl_gm.mtd_consultar_gastos();
            TotalGastos = 0;
            TotalIva = 0;
            dtg_gastos.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                Fila = v_dt.Rows.Count;
                dtg_gastos.Rows.Add(Fila);
                Contador = 0;

                foreach (DataRow rows in v_dt.Rows)
                { 
                    dtg_gastos.Rows[Contador].Cells["cl_id_gasto"].Value = rows["Codigo"];
                    dtg_gastos.Rows[Contador].Cells["cl_fecha"].Value = rows["FechaRegistro"];
                    dtg_gastos.Rows[Contador].Cells["cl_desc_gasto"].Value = rows["Gasto"];
                    double Valores = Convert.ToDouble(rows["Valor"]);
                    TotalGastos += Valores;
                    dtg_gastos.Rows[Contador].Cells["cl_valor"].Value = Valores.ToString("N0");
                    dtg_gastos.Rows[Contador].Cells["cl_proveedor"].Value = rows["proveedor"];
                    double ValoresIVA = Convert.ToDouble(rows["ValorIva"]);
                    TotalIva += ValoresIVA;
                    dtg_gastos.Rows[Contador].Cells["cl_valor_iva"].Value = ValoresIVA.ToString("N0");
                    Contador++;
                }
            }

            txt_total.Text = TotalGastos.ToString("N0");
            txt_total_iva.Text = TotalIva.ToString("N0");
            double total  = TotalGastos + TotalIva;
            txt_valorMasIVA.Text = total.ToString("N0");
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            frm_agregar_consecto_gasto frm_a_gasto = new frm_agregar_consecto_gasto();
            frm_a_gasto.ShowDialog();
        }
        private void btn_agregar_gastos_Click(object sender, EventArgs e)
        {
            VerificarCaja();
            if (v_confirmacion == true)
            {
                frm_agregar_gasto Frm_Agregar_gasto = new frm_agregar_gasto();
                Frm_Agregar_gasto.usuario = this.Codigo;
                Frm_Agregar_gasto.ShowDialog();
                mtd_consultar();
            }     
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            mtd_consultar();
            this.Cursor = Cursors.Default;
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (BuscaAutomatica == 1)
            {
                this.Cursor = Cursors.WaitCursor;
                mtd_consultar();
                this.Cursor = Cursors.Default;
            }        
        }
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            cls_gastos_m gm = new cls_gastos_m();
            int v_contador;
            int Eliminados;
            int Error;
            bool v_ok;
            frm_confirmacion frm_Confirmacion = new frm_confirmacion();
            if (dtg_gastos.Rows.Count > 0)
            {
                if (dtg_gastos.SelectedRows.Count > 0)
                {
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    v_contador = dtg_gastos.SelectedRows.Count;
                    frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + "  Gastos?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    {
                        Eliminados = 0;
                        Error = 0;
                        foreach (DataGridViewRow rows in dtg_gastos.SelectedRows)
                        {
                            int Gastosm = Convert.ToInt32(rows.Cells["cl_id_gasto"].Value);
                            gm.Codigo = Gastosm;
                            v_ok = gm.mtd_eliminar();
                            if (v_ok)
                            {
                                Eliminados++;
                            }
                            else
                            {
                                Error++;
                            }
                        }
                        mtd_consultar();
                    }
                }
            }
            gm.Codigo = 0;
        }

        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            cl_gm.Buscar = txt_buscar.Text;
            cl_gm.FechaIni = dtp_fecha_inicio.Text;
            cl_gm.Fechafin = dtp_fecha_fin.Text;
            v_dt = cl_gm.mtd_consultar_gastos();
            mtd_exporta_excel();
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

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Cursor = Cursors.WaitCursor;
                mtd_consultar();
                this.Cursor = Cursors.Default;
            }
        }
    }
}
