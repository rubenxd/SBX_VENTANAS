using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBX.MODEL;

namespace SBX
{
    public partial class frm_mensajero : Form
    {
        //Instancias
        cls_global cls_Global = new cls_global();
        cls_mensajero cls_mensajero = new cls_mensajero();

        //Variables globales
        int v_contador = 0;
        int v_filas = 0;
        DataTable v_dt;
        int v_validado = 0;
        bool v_ok = true;
        bool v_registro = true;
        bool v_confirmacion;
        int Eliminados;
        int Error;

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public frm_mensajero()
        {
            InitializeComponent();
        }
        private void frm_mensajero_Load(object sender, EventArgs e)
        {
            cbx_tipo_busqueda.SelectedIndex = 0;
            mtd_mensajeInformativoBotones();
        }

        //metodos
        public void mtd_mensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_guardar, "Guardar");
            Botones.SetToolTip(btn_limpiar, "Limpiar");
            Botones.SetToolTip(btn_buscar, "Buscar");
            Botones.SetToolTip(btn_exportar_excel, "Exportar a excel");
            Botones.SetToolTip(btn_eliminar, "Eliminar");
            Botones.SetToolTip(btn_editar, "Editar");
        }
        private void mtd_limpiar()
        {
            errorProvider.Clear();
            txt_dni.Text = "";
            txt_nombre.Text = "";
            txt_ciudad.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_celular.Text = "";
            txt_email.Text = "";
            v_registro = true;
            lbl_codigo.Text = "";
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        private void mtd_Cargar_mensajero()
        {
            if (txt_buscar.Text == "DNI-Nombre")
            {
                cls_mensajero.v_buscar = "";
            }
            else
            {
                cls_mensajero.v_buscar = txt_buscar.Text;
            }
            cls_mensajero.v_tipo_busqueda = cbx_tipo_busqueda.Text;

            v_dt = cls_mensajero.mtd_consultar_mensajero();
            dtg_mesajero.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                v_contador = 0;
                v_filas = v_dt.Rows.Count;
                dtg_mesajero.Rows.Add(v_filas);
                foreach (DataRow rows in v_dt.Rows)
                {
                        dtg_mesajero.Rows[v_contador].Cells["cl_codigo"].Value = rows["Codigo"];
                        dtg_mesajero.Rows[v_contador].Cells["cl_dni"].Value = rows["DNI"];
                        dtg_mesajero.Rows[v_contador].Cells["cl_Nombre"].Value = rows["Nombre"];
                        dtg_mesajero.Rows[v_contador].Cells["cl_Ciudad"].Value = rows["ciudad"];
                        dtg_mesajero.Rows[v_contador].Cells["cl_direccion"].Value = rows["Direccion"];
                        dtg_mesajero.Rows[v_contador].Cells["cl_telefono"].Value = rows["Telefono"];
                        dtg_mesajero.Rows[v_contador].Cells["cl_celular"].Value = rows["Celular"];
                        dtg_mesajero.Rows[v_contador].Cells["cl_email"].Value = rows["Email"];
                    
                    v_contador++;
                }
            }
        }
        private void mtd_eliminar()
        {
            if (dtg_mesajero.Rows.Count > 0)
            {
                if (dtg_mesajero.SelectedRows.Count > 0)
                {
                    Eliminados = 0;
                    Error = 0;
                    frm_confirmacion frm_Confirmacion = new frm_confirmacion();
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    v_contador = dtg_mesajero.SelectedRows.Count;
                    frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + "  Mensajeros?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    {
                        foreach (DataGridViewRow rows in dtg_mesajero.SelectedRows)
                        {
                            cls_mensajero.Codigo = Convert.ToInt32(rows.Cells["cl_codigo"].Value);
                            v_ok = cls_mensajero.mtd_eliminar();
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
                        mtd_Cargar_mensajero();
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
        private void Validar()
        {
            v_validado = 0;
            errorProvider.Clear();

            if (txt_dni.Text == "")
            {
                errorProvider.SetError(txt_dni, "Ingrese DNI");
                v_validado++;
            }
            if (txt_nombre.Text.Trim() == "") { errorProvider.SetError(txt_nombre, "Ingrese nombre"); v_validado++; }
            if (txt_celular.Text.Trim() == "") { errorProvider.SetError(txt_celular, "Ingrese numero de celular"); v_validado++; }
            if (txt_email.Text.Trim() != "")
            {
                if (!cls_Global.validarEmail(txt_email.Text))
                {
                    errorProvider.SetError(txt_email, "Formato Email incorrecto");
                    v_validado++;
                }
            }
        }
        private void mtd_guardar()
        {
            if (txt_dni.Text.Trim() == "0")
            {
                errorProvider.SetError(txt_dni, "DNI ya existe");
                v_validado++;
            }
            else
            {
                cls_mensajero.v_buscar = txt_dni.Text;
                cls_mensajero.v_tipo_busqueda = "";
                v_dt = cls_mensajero.mtd_consultar_mensajero();
                if (v_dt.Rows.Count > 0)
                {
                    errorProvider.SetError(txt_dni, "DNI ya existe");
                    v_validado++;
                }
            }

            if (v_validado == 0)
            {
                cls_mensajero.DNI = txt_dni.Text;
                cls_mensajero.Nombre = txt_nombre.Text;
                cls_mensajero.Ciudad = txt_ciudad.Text;
                cls_mensajero.Direccion = txt_direccion.Text;
                cls_mensajero.Telefono = txt_telefono.Text;
                cls_mensajero.Celular = txt_celular.Text;
                cls_mensajero.Email = txt_email.Text;
            
                v_ok = cls_mensajero.mtd_registrar();

                frm_msg frm_Msg = new frm_msg();
                if (v_ok == true)
                {
                    frm_Msg.txt_mensaje.Text = "Mensajero registrado correctamente";
                    frm_Msg.ShowDialog();
                    mtd_limpiar();
                    mtd_Cargar_mensajero();
                    v_registro = true;
                    lbl_codigo.Text = "";
                    txt_dni.Focus();
                }
            }
        }
        private void mtd_editar()
        {
            if (txt_dni.Text.Trim() == "0")
            {
                errorProvider.SetError(txt_dni, "DNI ya existe");
                v_validado++;
            }
            else
            {
                cls_mensajero.v_buscar = txt_dni.Text;
                cls_mensajero.v_tipo_busqueda = "";
                v_dt = cls_mensajero.mtd_consultar_mensajero();
                if (v_dt.Rows.Count > 0)
                {
                    DataRow row = v_dt.Rows[0];
                    if (row["Codigo"].ToString() != lbl_codigo.Text)
                    {
                        errorProvider.SetError(txt_dni, "DNI ya existe");
                        v_validado++;
                    }
                }
            }

            if (v_validado == 0)
            {
                cls_mensajero.Codigo = Convert.ToInt32(lbl_codigo.Text);
                cls_mensajero.DNI = txt_dni.Text;
                cls_mensajero.Nombre = txt_nombre.Text;
                cls_mensajero.Ciudad = txt_ciudad.Text;
                cls_mensajero.Direccion = txt_direccion.Text;
                cls_mensajero.Telefono = txt_telefono.Text;
                cls_mensajero.Celular = txt_celular.Text;
                cls_mensajero.Email = txt_email.Text;
              
                v_ok = cls_mensajero.mtd_Editar();

                frm_msg frm_Msg = new frm_msg();
                if (v_ok == true)
                {
                    frm_Msg.txt_mensaje.Text = "Mensajero Editado correctamente";
                    frm_Msg.ShowDialog();
                    mtd_limpiar();
                    mtd_Cargar_mensajero();
                    lbl_codigo.Text = "";
                    v_registro = true;
                    txt_dni.Focus();
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
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dtg_mesajero.Rows.Count > 0)
            {
                if (dtg_mesajero.SelectedRows.Count > 0)
                {
                    errorProvider.Clear();
                    v_registro = false;
                    foreach (DataGridViewRow row in dtg_mesajero.SelectedRows)
                    {
                        lbl_codigo.Text = row.Cells["cl_codigo"].Value.ToString();
                        txt_dni.Text = row.Cells["cl_dni"].Value.ToString();
                        txt_nombre.Text = row.Cells["cl_Nombre"].Value.ToString();
                        txt_ciudad.Text = row.Cells["cl_Ciudad"].Value.ToString();
                        txt_direccion.Text = row.Cells["cl_direccion"].Value.ToString();
                        txt_telefono.Text = row.Cells["cl_telefono"].Value.ToString();
                        txt_celular.Text = row.Cells["cl_celular"].Value.ToString();
                        txt_email.Text = row.Cells["cl_email"].Value.ToString();
                    }
                }
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            mtd_eliminar();
        }
        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            mtd_exporta_excel();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            mtd_limpiar();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_Cargar_mensajero();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Validar();
            if (v_validado == 0)
            {
                if (v_registro == true)
                {
                    mtd_guardar();
                }
                else
                {
                    mtd_editar();
                }
            }
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_Cargar_mensajero();
        }
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void pnl_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "DNI-Nombre")
            {
                txt_buscar.Text = "";
                txt_buscar.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "DNI-Nombre";
                txt_buscar.ForeColor = Color.Silver;
            }
        }
        private void dtg_mesajero_DoubleClick(object sender, EventArgs e)
        {
            if (dtg_mesajero.Rows.Count > 0)
            {
                if (dtg_mesajero.SelectedRows.Count > 0)
                {
                    errorProvider.Clear();
                    v_registro = false;
                    foreach (DataGridViewRow row in dtg_mesajero.SelectedRows)
                    {
                        lbl_codigo.Text = row.Cells["cl_codigo"].Value.ToString();
                        txt_dni.Text = row.Cells["cl_dni"].Value.ToString();
                        txt_nombre.Text = row.Cells["cl_Nombre"].Value.ToString();
                        txt_ciudad.Text = row.Cells["cl_Ciudad"].Value.ToString();
                        txt_direccion.Text = row.Cells["cl_direccion"].Value.ToString();
                        txt_telefono.Text = row.Cells["cl_telefono"].Value.ToString();
                        txt_celular.Text = row.Cells["cl_celular"].Value.ToString();
                        txt_email.Text = row.Cells["cl_email"].Value.ToString();
                    }
                }
            }     
        }
    }
}
