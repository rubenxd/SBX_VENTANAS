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
using System.Runtime.InteropServices;

namespace SBX
{
    public partial class frm_aplicar_domicilio : Form
    {
        //Delegado
        public delegate void EnviarInfo(string dni,string celular,string nombre,
                                        string direccion,string telefono,string mensajero,string valor_domicilio,string codigoSu);
        public event EnviarInfo Enviainfo;

        //instancias
        cls_global cls_Global = new cls_global();
        cls_cliente cls_Cliente = new cls_cliente();
        cls_mensajero cls_Mensajero = new cls_mensajero();
        cls_domicilio cls_Domicilio = new cls_domicilio();

        int v_validado = 0;
        DataTable v_dt;
        DataRow v_row;
        string cliente = "1";
        string mesajero = "0";
        public DataTable v_dt_Permi { get; set; }

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public frm_aplicar_domicilio()
        {
            InitializeComponent();
            MensajeInformativoBotones();
        }

        //metodos
        private void mtd_limpiar()
        {
            mtd_activa();
            txt_dni.Text = "";
            txt_celular.Text = "";
            txt_nombre.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_mensajero.Text = "";
            txt_valor_domicilio.Text = "";
        }
        public void MensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar cliente");
            Botones.SetToolTip(btn_cliente, "Agregar nuevo cliente");
            Botones.SetToolTip(btn_add_mensajero, "Agregar nuevo Mensajero");
            Botones.SetToolTip(btn_buscar_mensajero, "Buscar mesajero");
        }
        private void mtd_activa()
        {
            txt_celular.Enabled = true;
            txt_nombre.Enabled = true;
            txt_direccion.Enabled = true;
            txt_telefono.Enabled = true;
        }
        private void mtd_desactiva()
        {
            txt_celular.Enabled = false;
            txt_nombre.Enabled = false;
            txt_direccion.Enabled = false;
            txt_telefono.Enabled = false;
        }
        private void mtd_carga_cliente(string dni, string Codsu, string Nomsu)
        {
            txt_dni.Text = dni;
         
            if (txt_dni.Text.Trim() != "" && txt_dni.Text.Trim() != "0")
            {
                cls_Cliente.v_tipo_busqueda = "validacion";
                cls_Cliente.v_buscar = txt_dni.Text;
                v_dt = cls_Cliente.mtd_consultar_cliente();
                if (v_dt.Rows.Count > 0)
                {
                    mtd_desactiva();
                    v_row = v_dt.Rows[0];
                    cliente = v_row["Codigo"].ToString();
                    txt_nombre.Text = v_row["Nombre"].ToString();
                    lbl_codigo.Text = Codsu;
                    lbl_nomSuc.Text = Nomsu;
                    if (Codsu == "")
                    {
                        txt_celular.Text = v_row["Celular"].ToString();
                        txt_direccion.Text = v_row["Direccion"].ToString();
                        txt_telefono.Text = v_row["Telefono"].ToString();
                    }
                    else
                    {
                        txt_celular.Text = v_row["CelularS"].ToString();
                        txt_direccion.Text = v_row["DireccionS"].ToString();
                        txt_telefono.Text = v_row["TelefonoS"].ToString();
                    }
                  
                }
                else
                {
                    mtd_activa();
                    txt_celular.Text = "";
                    txt_nombre.Text = "";
                    lbl_codigo.Text = "";
                    lbl_nomSuc.Text = "";
                    txt_direccion.Text = "";
                    txt_telefono.Text = "";
                    errorProvider.SetError(txt_dni, "Cliente no existe");
                    v_validado++;
                }
            }
            else
            {
                mtd_activa();
            }
        }
        private void mtd_carga_cliente_por_celular(string celular)
        {
            txt_celular.Text = celular;
            errorProvider.Clear();
            if (txt_celular.Text.Trim() != "")
            {
                cls_Domicilio.v_tipo_busqueda = "validacion_celular";
                cls_Domicilio.v_buscar = txt_celular.Text;
                v_dt = cls_Domicilio.mtd_consultar_domicilio();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    txt_nombre.Text = v_row["Nombre"].ToString();
                    txt_direccion.Text = v_row["Direccion"].ToString();
                    txt_telefono.Text = v_row["Telefono"].ToString();
                }
                else
                {
                    txt_nombre.Text = "";
                    txt_direccion.Text = "";
                    txt_telefono.Text = "";
                    errorProvider.SetError(txt_celular, "Celular no existe");
                    v_validado++;
                }
            }
            else
            {
                txt_nombre.Text = "";
                txt_direccion.Text = "";
                txt_telefono.Text = "";
            }
        }
        private void mtd_validacion()
        {
            errorProvider.Clear();
            v_validado = 0;

            mtd_carga_cliente(txt_dni.Text,lbl_codigo.Text,lbl_nomSuc.Text);
            mtd_carga_mensajero(txt_mensajero.Text);
            if (v_validado == 0)
            {
                if (txt_celular.Text.Trim() == "")
                {
                    errorProvider.SetError(txt_celular, "Ingrese celular");
                    v_validado++;
                }
                if (txt_direccion.Text.Trim() == "")
                {
                    errorProvider.SetError(txt_direccion, "Ingrese direccion");
                    v_validado++;
                }
                if (txt_valor_domicilio.Text.Trim() == "")
                {
                    errorProvider.SetError(txt_valor_domicilio, "Ingrese valor domicilio");
                    v_validado++;
                }
                if (txt_mensajero.Text.Trim() == "")
                {
                    mesajero = "0";
                }
                else
                {
                    mesajero = txt_mensajero.Text;
                }
                if (txt_dni.Text.Trim() == "")
                {
                    cliente = "1";
                }
            }         
        }
        private void mtd_carga_mensajero(string dni)
        {
            txt_mensajero.Text = dni;

            if (txt_mensajero.Text.Trim() != "" && txt_mensajero.Text.Trim() != "0")
            {
                cls_Mensajero.v_tipo_busqueda = "validacion";
                cls_Mensajero.v_buscar = txt_mensajero.Text;
                v_dt = cls_Mensajero.mtd_consultar_mensajero();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    lbl_nombre_mensajero.Text = v_row["Nombre"].ToString();
                }
                else
                {
                    lbl_nombre_mensajero.Text = "--";
                    errorProvider.SetError(txt_mensajero, "Mensajero no existe");
                    v_validado++;
                }
            }
            else
            {
                lbl_nombre_mensajero.Text = "--";
            }
        }

        //Eventos
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            mtd_limpiar();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_valor_domicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_mensajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        frm_ayuda frm_Ayuda;
        private void btn_buscar_Click(object sender, EventArgs e)
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
        private void txt_dni_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_carga_cliente(txt_dni.Text,"","");
        }
        private void txt_celular_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_carga_cliente_por_celular(txt_celular.Text);
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
                mtd_validacion();
                if (v_validado == 0)
                {
                    Enviainfo(cliente, txt_celular.Text, txt_nombre.Text, txt_direccion.Text, txt_telefono.Text,
                              mesajero, txt_valor_domicilio.Text,lbl_codigo.Text);
                    this.Dispose();
                }
        }
        frm_mensajero frm_Mensajero;
        private void btn_add_mensajero_Click(object sender, EventArgs e)
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
        private void btn_buscar_mensajero_Click(object sender, EventArgs e)
        {
            if (frm_Ayuda == null || frm_Ayuda.IsDisposed)
            {
                frm_Ayuda = new frm_ayuda("Buscar Mensajero");
                frm_Ayuda.Enviainfo += new frm_ayuda.EnviarInfo(mtd_carga_mensajero);
                frm_Ayuda.Show();
            }
            else
            {
                frm_Ayuda.BringToFront();
                frm_Ayuda.WindowState = FormWindowState.Normal;
            }
        }
        private void txt_mensajero_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_carga_mensajero(txt_mensajero.Text);
        }
        private void pnl_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
