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
    public partial class frm_descuento : Form
    {
        //Delegado  Margen de venta
        public delegate void EnviaDescuento(string item,string porcentaje_descuento, string valorDescuento);
        public event EnviaDescuento descuento;

        cls_global cls_Global = new cls_global();

        int v_validado = 0;
        double v_nuevo_precio = 0;

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public frm_descuento()
        {
            InitializeComponent();
        }

        //metodos
        private void mtd_validar_porcen_des()
        {
            errorProvider.Clear();
            v_validado = 0;

            if (txt_por_desc.Text.Trim() != "")
            {
                if (!cls_Global.IsNumericDouble(txt_por_desc.Text))
                {
                    errorProvider.SetError(txt_por_desc, "Ingrese valores numericos");
                    v_validado++;
                }
            }
            else
            {
                errorProvider.SetError(txt_por_desc,"ingrese % descuento");
                txt_valor_descuento.Text = "";
                v_validado++;
            }
        }
        private void mtd_validar_valor_des()
        {
            errorProvider.Clear();
            v_validado = 0;

            if (txt_valor_descuento.Text.Trim() != "")
            {
                if (!cls_Global.IsNumericDouble(txt_valor_descuento.Text))
                {
                    errorProvider.SetError(txt_valor_descuento, "Ingrese valores numericos");
                    v_validado++;
                }
            }
            else
            {
                errorProvider.SetError(txt_valor_descuento, "ingrese valor descuento");
                txt_por_desc.Text = "";
                v_validado++;
            }
        }
        private void mtd_calcular_porc_desc()
        {
            mtd_validar_porcen_des();
            if (v_validado == 0)
            {
                double valor = 0;
                if (txt_por_desc.Text.Trim() != "")
                {
                    valor = Convert.ToDouble(lbl_precio_venta.Text) * (Convert.ToDouble(txt_por_desc.Text) / 100);
                    txt_valor_descuento.Text = valor.ToString();
                    v_nuevo_precio = Convert.ToDouble(lbl_precio_venta.Text) - valor;
                    lbl_nuevo_precio.Text = v_nuevo_precio.ToString("N");
                }
            }
            else
            {
                lbl_nuevo_precio.Text = "--";
            }
        }
        private void mtd_calcular_valor_desc()
        {
            mtd_validar_valor_des();
            if (v_validado == 0)
            {
                double valor = 0;
                if (txt_valor_descuento.Text.Trim() != "")
                {
                    valor = (Convert.ToDouble(txt_valor_descuento.Text) / Convert.ToDouble(lbl_precio_venta.Text)) * 100;
                    txt_por_desc.Text = valor.ToString();
                    v_nuevo_precio = Convert.ToDouble(lbl_precio_venta.Text) - Convert.ToDouble(txt_valor_descuento.Text);
                    lbl_nuevo_precio.Text = v_nuevo_precio.ToString("N");
                }
            }
            else
            {
                lbl_nuevo_precio.Text = "--";
            }
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (v_validado == 0)
            {
                descuento(lbl_item.Text,txt_por_desc.Text, txt_valor_descuento.Text);
                this.Dispose();
            }
        }
        private void txt_por_desc_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_validar_porcen_des();
            mtd_calcular_porc_desc();
        }
        private void txt_valor_descuento_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_validar_valor_des();
            mtd_calcular_valor_desc();
        }
        private void txt_valor_descuento_Leave(object sender, EventArgs e)
        {
            if (txt_valor_descuento.Text.Trim() != "")
            {
                double valor_desc = Convert.ToDouble(txt_valor_descuento.Text);
                txt_valor_descuento.Text = valor_desc.ToString("N");
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
