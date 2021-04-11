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
    public partial class frm_separado : Form
    {
        //Delegado
        public delegate void EnviarInfo(string cliente,string valor,string Abono_inicial,
            string periodo_pago,string suministrar,string num_cuotas,string valor_cuotas,string f_primer_pago,string f_vence);
        public event EnviarInfo Enviainfo;

        cls_global cls_Global = new cls_global();
        cls_cliente cls_Cliente = new cls_cliente();

        int v_validado = 0;
        DataTable v_dt;
        DataRow v_row;
        string cliente = "1";
        double v_total = 0;
        double periodo = 0;
        double v_valor_cuota = 0;
        double v_num_cuotas = 0;
        public int Credito { get; set; }
        public string Modulo { get; set; }
        public DataTable v_dt_Permi { get; set; }
        public string Usuario { get; set; }

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public frm_separado()
        {
            InitializeComponent();
        }
      
        private void frm_separado_Load(object sender, EventArgs e)
        {
            cbx_periodo_pago.SelectedIndex = 0;
            cbx_suministrar.SelectedIndex = 0;
            MensajeInformativoBotones();
        }

        //Metodos
        private void mtd_carga_cliente(string dni,string dato2,string dato3)
        {
            txt_dni.Text = dni;

            if (txt_dni.Text.Trim() != "" && txt_dni.Text.Trim() != "0")
            {
                cls_Cliente.v_tipo_busqueda = "validacion";
                cls_Cliente.v_buscar = txt_dni.Text;
                v_dt = cls_Cliente.mtd_consultar_cliente();
                if (v_dt.Rows.Count > 0)
                {
                    v_row = v_dt.Rows[0];
                    cliente = v_row["Codigo"].ToString();
                    lbl_nombre.Text = v_row["Nombre"].ToString();
                }
                else
                {
                    lbl_nombre.Text = "--";
                    errorProvider.SetError(txt_dni, "Cliente no existe");
                    v_validado++;
                }
            }
            else
            {
                if (txt_dni.Text == "")
                {
                    lbl_nombre.Text = "--";
                    errorProvider.SetError(txt_dni, "Ingrese Cliente");
                    v_validado++;
                } else if (txt_dni.Text == "0")
                {
                    lbl_nombre.Text = "--";
                    errorProvider.SetError(txt_dni, "Cliente No existe");
                    v_validado++;
                }
            }
        }
        private void Validar_calcular()
        {
            v_validado = 0;
            errorProvider.Clear();
            //calcular total
            if (!cls_Global.IsNumericDouble(txt_abono_unicial.Text))
            {
                errorProvider.SetError(txt_abono_unicial,"Ingrese abono inicial");
                v_validado++;
            }

            if (v_validado == 0)
            {
                //total
                v_total = Convert.ToDouble(txt_valor.Text) - Convert.ToDouble(txt_abono_unicial.Text);
                txt_total.Text = v_total.ToString("N0");

                switch (cbx_periodo_pago.Text)
                {
                    case "Mensual":
                        periodo = 30;
                        break;
                    case "Quincenal":
                        periodo = 15;
                        break;
                    case "Semanal":
                        periodo = 7;
                        break;
                    case "Diario":
                        periodo = 1;
                        break;
                }

                if (cbx_suministrar.Text == "Numero Cuotas")
                {
                    if (!cls_Global.IsNumericDouble(txt_num_cuotas.Text))
                    {
                        errorProvider.SetError(txt_num_cuotas, "Ingrese numero de cuotas");
                        v_validado++;
                    }

                    if (v_validado == 0)
                    {
                        v_valor_cuota = Convert.ToDouble(txt_total.Text) / Convert.ToDouble(txt_num_cuotas.Text);
                        txt_valor_cuotas.Text = v_valor_cuota.ToString("N0");
                    }
                    else
                    {
                        txt_valor_cuotas.Text = "";
                        dtp_fecha_inicio.Value = DateTime.Today;
                        dtpk_fecha_vence.Value = DateTime.Today;
                    }
                }
                else
                {
                    if (!cls_Global.IsNumericDouble(txt_valor_cuotas.Text))
                    {
                        errorProvider.SetError(txt_valor_cuotas, "Ingrese valor cuotas");
                        v_validado++;
                    }

                    if (v_validado == 0)
                    {
                        v_num_cuotas = Convert.ToDouble(txt_total.Text) / Convert.ToDouble(txt_valor_cuotas.Text);
                        txt_num_cuotas.Text = v_num_cuotas.ToString("N0");
                    }
                    else
                    {
                        txt_num_cuotas.Text = "";
                        dtp_fecha_inicio.Value = DateTime.Today;
                        dtpk_fecha_vence.Value = DateTime.Today;
                    }
                }

                if (v_validado == 0)
                {
                    dtpk_fecha_vence.Value = dtp_fecha_inicio.Value;
                    periodo = periodo * Convert.ToDouble(txt_num_cuotas.Text);
                    dtpk_fecha_vence.Value = dtpk_fecha_vence.Value.AddDays(periodo);
                }
                else
                {
                    dtp_fecha_inicio.Value = DateTime.Today;
                    dtpk_fecha_vence.Value = DateTime.Today;
                }
            }
            else
            {
                txt_total.Text = txt_valor.Text;
                cbx_periodo_pago.Text = "Mensual";
                cbx_suministrar.Text = "Numero Cuotas";
                txt_num_cuotas.Text = "";
                txt_valor_cuotas.Text = "";
                dtp_fecha_inicio.Value = DateTime.Today;
                dtpk_fecha_vence.Value = DateTime.Today;
            }        
        }
        public void MensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar cliente");
            Botones.SetToolTip(btn_cliente, "Agregar cliente");
        }

        //Eventos
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
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        private void txt_abono_unicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_num_cuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_valor_cuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void cbx_suministrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (cbx_suministrar.Text == "Numero Cuotas")
            {
                txt_valor_cuotas.Text = "";
                txt_num_cuotas.Enabled = true;
                txt_valor_cuotas.Enabled = false;
            }
            else
            {
                txt_num_cuotas.Text = "";
                txt_valor_cuotas.Enabled = true;
                txt_num_cuotas.Enabled = false;
            }
            Validar_calcular();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Validar_calcular();
            mtd_carga_cliente(txt_dni.Text,"","");
            if (v_validado == 0)
            {
                Enviainfo(cliente,txt_valor.Text,txt_abono_unicial.Text,cbx_periodo_pago.Text,cbx_suministrar.Text,
                    txt_num_cuotas.Text,txt_valor_cuotas.Text,dtp_fecha_inicio.Text,dtpk_fecha_vence.Text);
                Dispose();
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
        private void txt_abono_unicial_KeyUp(object sender, KeyEventArgs e)
        {
            Validar_calcular();
        }
        private void txt_num_cuotas_KeyUp(object sender, KeyEventArgs e)
        {
            Validar_calcular();
        }
        private void txt_valor_cuotas_KeyUp(object sender, KeyEventArgs e)
        {
            Validar_calcular();
        }
        private void dtp_fecha_inicio_CloseUp(object sender, EventArgs e)
        {
            Validar_calcular();
        }
        private void cbx_periodo_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar_calcular();
        }
        private void txt_dni_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_carga_cliente(txt_dni.Text,"","");
        }
    }
}
