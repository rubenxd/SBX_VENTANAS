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
        public DataTable v_dt_Permi { get; set; }

        public frm_gastos()
        {
            InitializeComponent();
        }
        private void frm_gastos_Load(object sender, EventArgs e)
        {
            MensajeInformativoBotones();
            mtd_consultar();

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
            v_dt = cl_gm.mtd_consultar_gastos();
            TotalGastos = 0;
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
                    Contador++;
                }
            }

            txt_total.Text = TotalGastos.ToString("N0");
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
                Frm_Agregar_gasto.ShowDialog();
                mtd_consultar();
            }     
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_consultar();
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_consultar();
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
    }
}
