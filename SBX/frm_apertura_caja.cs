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
    public partial class frm_apertura_caja : Form
    {
        cls_global cls_Global = new cls_global();
        cls_caja cls_Caja = new cls_caja();
        bool v_ok = true;

        public string Usuario { get; set; }

        public frm_apertura_caja()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_base.Text.Trim() != "")
            {
                if (cls_Global.IsNumericDouble(txt_base.Text))
                {
                    cls_Caja.Usuario = Usuario;
                    cls_Caja.Valor = Convert.ToDouble(txt_base.Text);
                    cls_Caja.TipoOperacion = "APERTURA";
                    cls_Caja.Codigo_Ultimo_Cierre = "0";
                    cls_Caja.Codigo_Ultima_venta = "0";
                    v_ok = cls_Caja.mtd_registrar();
                    if (v_ok == true)
                    {
                        frm_msg frm_Msg = new frm_msg();
                        frm_Msg.txt_mensaje.Text = "Apertura de caja correcta";
                        frm_Msg.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    errorProvider.SetError(txt_base, "Ingrese valores numericos");
                }
            }
            else
            {
                errorProvider.SetError(txt_base,"Ingrese base");
            }        
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
