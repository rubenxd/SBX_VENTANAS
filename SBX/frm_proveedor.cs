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
using System.Runtime.InteropServices;

namespace SBX
{
    public partial class frm_proveedor : Form
    {
        //Instancias
        cls_global cls_Global = new cls_global();
        cls_proveedor cls_Proveedor = new cls_proveedor();

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
        public DataTable v_dt_Permi { get; set; }

        //public System.Windows.Forms.FormWindowState WindowState { get; set; }

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //inicio formulario
        public frm_proveedor()
        {
            InitializeComponent();
        }
        public frm_proveedor(bool f_producto)
        {
            InitializeComponent();
            pnl_arriba.Height = 32;
        }
        private void frm_proveedor_Load(object sender, EventArgs e)
        {
            cbx_tipo_busqueda.SelectedIndex = 0;
            mtd_mensajeInformativoBotones();

            foreach (DataRow rows in v_dt_Permi.Rows)
            {
                if (rows["Modulo"].ToString() == "PROVEEDOR")
                {
                    switch (rows["Permiso"].ToString())
                    {
                        case "guardar":
                            btn_guardar.Enabled = true;
                            break;
                        case "limpiar":
                            btn_limpiar.Enabled = true;
                            break;
                        case "editar":
                            btn_editar.Enabled = true;
                            break;
                        case "eliminar":
                            btn_eliminar.Enabled = true;
                            break;
                        case "exportar_excel":
                            btn_exportar_excel.Enabled = true;
                            break;
                    }
                }
            }
        }

        //Metodos
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
                    errorProvider.SetError(txt_email,"Formato Email incorrecto");
                    v_validado++;
                }
            }       
        }
        private void mtd_limpiar()
        {
            errorProvider.Clear();
            txt_dni.Text = "";
            txt_digito_verificacion.Text = "";
            txt_nombre.Text = "";
            txt_ciudad.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_celular.Text = "";
            txt_email.Text = "";
            txt_sitio_web.Text = "";
            v_registro = true;
            lbl_codigo.Text = "";
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
        private void mtd_Cargar_proveedor() {
            if (txt_buscar.Text == "DNI-Nombre")
            {
                cls_Proveedor.v_buscar = "";
            }
            else
            {
                cls_Proveedor.v_buscar = txt_buscar.Text;
            }
            cls_Proveedor.v_tipo_busqueda = cbx_tipo_busqueda.Text;

            v_dt = cls_Proveedor.mtd_consultar_proveedor();
            dtg_proveedor.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                v_contador = 0;
                v_filas = v_dt.Rows.Count;
                dtg_proveedor.Rows.Add(v_filas);
                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_proveedor.Rows[v_contador].Cells["cl_codigo"].Value = rows["Codigo"];
                    dtg_proveedor.Rows[v_contador].Cells["cl_dni"].Value = rows["DNI"];
                    dtg_proveedor.Rows[v_contador].Cells["cl_Nombre"].Value = rows["Nombre"];
                    dtg_proveedor.Rows[v_contador].Cells["cl_Ciudad"].Value = rows["ciudad"];
                    dtg_proveedor.Rows[v_contador].Cells["cl_direccion"].Value = rows["Direccion"];
                    dtg_proveedor.Rows[v_contador].Cells["cl_telefono"].Value = rows["Telefono"];
                    dtg_proveedor.Rows[v_contador].Cells["cl_celular"].Value = rows["Celular"];
                    dtg_proveedor.Rows[v_contador].Cells["cl_email"].Value = rows["Email"];
                    dtg_proveedor.Rows[v_contador].Cells["cl_sitio_web"].Value = rows["SitioWeb"];
                    v_contador++;
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
                cls_Proveedor.v_buscar = txt_dni.Text;
                cls_Proveedor.v_tipo_busqueda = "";
                v_dt = cls_Proveedor.mtd_consultar_proveedor();
                if (v_dt.Rows.Count > 0)
                {
                    errorProvider.SetError(txt_dni, "DNI ya existe");
                    v_validado++;
                }
            }

            if (v_validado == 0)
            {
                cls_Proveedor.DNI = txt_dni.Text;
                cls_Proveedor.Nombre = txt_nombre.Text;
                cls_Proveedor.Ciudad = txt_ciudad.Text;
                cls_Proveedor.Direccion = txt_direccion.Text;
                cls_Proveedor.Telefono = txt_telefono.Text;
                cls_Proveedor.Celular = txt_celular.Text;
                cls_Proveedor.Email = txt_email.Text;
                cls_Proveedor.Sitioweb = txt_sitio_web.Text;
                v_ok = cls_Proveedor.mtd_registrar();

                frm_msg frm_Msg = new frm_msg();
                if (v_ok == true)
                {
                    frm_Msg.txt_mensaje.Text = "Proveedor registrado correctamente";
                    frm_Msg.ShowDialog();
                    mtd_limpiar();
                    mtd_Cargar_proveedor();
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
                cls_Proveedor.v_buscar = txt_dni.Text;
                cls_Proveedor.v_tipo_busqueda = "";
                v_dt = cls_Proveedor.mtd_consultar_proveedor();
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
                cls_Proveedor.Codigo = Convert.ToInt32(lbl_codigo.Text);
                cls_Proveedor.DNI = txt_dni.Text;
                cls_Proveedor.Nombre = txt_nombre.Text;
                cls_Proveedor.Ciudad = txt_ciudad.Text;
                cls_Proveedor.Direccion = txt_direccion.Text;
                cls_Proveedor.Telefono = txt_telefono.Text;
                cls_Proveedor.Celular = txt_celular.Text;
                cls_Proveedor.Email = txt_email.Text;
                cls_Proveedor.Sitioweb = txt_sitio_web.Text;
                v_ok = cls_Proveedor.mtd_Editar();

                frm_msg frm_Msg = new frm_msg();
                if (v_ok == true)
                {
                    frm_Msg.txt_mensaje.Text = "Proveedor Editado correctamente";
                    frm_Msg.ShowDialog();
                    mtd_limpiar();
                    mtd_Cargar_proveedor();
                    lbl_codigo.Text = "";
                    v_registro = true;
                    txt_dni.Focus();
                }
            }
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        private void mtd_eliminar()
        {
            if (dtg_proveedor.Rows.Count > 0)
            {
                if (dtg_proveedor.SelectedRows.Count > 0)
                {
                    Eliminados = 0;
                    Error = 0;
                    frm_confirmacion frm_Confirmacion = new frm_confirmacion();
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    v_contador = dtg_proveedor.SelectedRows.Count;
                    frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + "  Proveedor?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    {
                        foreach (DataGridViewRow rows in dtg_proveedor.SelectedRows)
                        {
                            cls_Proveedor.Codigo = Convert.ToInt32(rows.Cells["cl_codigo"].Value);
                            v_ok = cls_Proveedor.mtd_eliminar();
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
                        mtd_Cargar_proveedor();
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

        //Eventos
        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void lbl_minimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            mtd_limpiar();
        }
        private void txt_dni_Leave(object sender, EventArgs e)
        {
            Validar();
        }
        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            Validar();
        }
        private void txt_ciudad_Leave(object sender, EventArgs e)
        {
            Validar();
        }
        private void txt_direccion_Leave(object sender, EventArgs e)
        {
            Validar();
        }
        private void txt_telefono_Leave(object sender, EventArgs e)
        {
            Validar();
        }
        private void txt_celular_Leave(object sender, EventArgs e)
        {
            Validar();
        }
        private void txt_email_Leave(object sender, EventArgs e)
        {
            Validar();
        }
        private void txt_sitio_web_Leave(object sender, EventArgs e)
        {
            Validar();
        }
        private void txt_dni_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_dni.Text != "")
            {
                CalcularDigitoVerificacion(txt_dni.Text);
                txt_digito_verificacion.Text = CalcularDigitoVerificacion(txt_dni.Text);
            }
            else
            {
                txt_digito_verificacion.Text = "";
            }
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
        private void dtg_proveedor_DoubleClick(object sender, EventArgs e)
        {
            if (dtg_proveedor.Rows.Count > 0)
            {
                if (btn_editar.Enabled == true)
                {
                    if (dtg_proveedor.SelectedRows.Count > 0)
                    {
                        errorProvider.Clear();
                        v_registro = false;
                        foreach (DataGridViewRow row in dtg_proveedor.SelectedRows)
                        {
                            lbl_codigo.Text = row.Cells["cl_codigo"].Value.ToString();
                            txt_dni.Text = row.Cells["cl_dni"].Value.ToString();
                            txt_nombre.Text = row.Cells["cl_Nombre"].Value.ToString();
                            txt_ciudad.Text = row.Cells["cl_Ciudad"].Value.ToString();
                            txt_direccion.Text = row.Cells["cl_direccion"].Value.ToString();
                            txt_telefono.Text = row.Cells["cl_telefono"].Value.ToString();
                            txt_celular.Text = row.Cells["cl_celular"].Value.ToString();
                            txt_email.Text = row.Cells["cl_email"].Value.ToString();
                            txt_sitio_web.Text = row.Cells["cl_sitio_web"].Value.ToString();
                        }
                        if (txt_dni.Text != "")
                        {
                            CalcularDigitoVerificacion(txt_dni.Text);
                            txt_digito_verificacion.Text = CalcularDigitoVerificacion(txt_dni.Text);
                        }
                        else
                        {
                            txt_digito_verificacion.Text = "";
                        }
                    }
                }
            }
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dtg_proveedor.Rows.Count > 0)
            {
                if (dtg_proveedor.SelectedRows.Count > 0)
                {
                    errorProvider.Clear();
                    v_registro = false;
                    foreach (DataGridViewRow row in dtg_proveedor.SelectedRows)
                    {
                        lbl_codigo.Text = row.Cells["cl_codigo"].Value.ToString();
                        txt_dni.Text = row.Cells["cl_dni"].Value.ToString();
                        txt_nombre.Text = row.Cells["cl_Nombre"].Value.ToString();
                        txt_ciudad.Text = row.Cells["cl_Ciudad"].Value.ToString();
                        txt_direccion.Text = row.Cells["cl_direccion"].Value.ToString();
                        txt_telefono.Text = row.Cells["cl_telefono"].Value.ToString();
                        txt_celular.Text = row.Cells["cl_celular"].Value.ToString();
                        txt_email.Text = row.Cells["cl_email"].Value.ToString();
                        txt_sitio_web.Text = row.Cells["cl_sitio_web"].Value.ToString();
                    }
                    if (txt_dni.Text != "")
                    {
                        CalcularDigitoVerificacion(txt_dni.Text);
                        txt_digito_verificacion.Text = CalcularDigitoVerificacion(txt_dni.Text);
                    }
                    else
                    {
                        txt_digito_verificacion.Text = "";
                    }
                }
            }
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
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_Cargar_proveedor();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_Cargar_proveedor();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            mtd_eliminar();
        }
        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            mtd_exporta_excel();
        }
    }
}
