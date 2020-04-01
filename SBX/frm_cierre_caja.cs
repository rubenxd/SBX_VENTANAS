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
    public partial class frm_cierre_caja : Form
    {
        cls_global cls_Global = new cls_global();
        cls_caja cls_Caja = new cls_caja();
        cls_venta cls_Venta = new cls_venta();
        bool v_ok = true;
        DataTable V_DT;
        public string Usuario { get; set; }
        string Fini;
        string Ffin;
        string CodigoUltimoCierre;

        public frm_cierre_caja()
        {
            InitializeComponent();
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_valor.Text.Trim() != "")
            {
                if (cls_Global.IsNumericDouble(txt_valor.Text))
                {
                    cls_Caja.Usuario = Usuario;
                    cls_Caja.Valor = Convert.ToDouble(txt_valor.Text);
                    cls_Caja.TipoOperacion = "CIERRE";
                    V_DT = cls_Caja.mtd_consultar_caja_cierre();
                    if (V_DT.Rows.Count > 0)
                    {
                        DataRow rows = V_DT.Rows[0];
                        cls_Caja.Codigo_Ultimo_Cierre =  rows["Codigo"].ToString();
                        Fini = rows["Codigo"].ToString();
                    }
                    else
                    {
                        cls_Caja.Codigo_Ultimo_Cierre = "0";
                        Fini = "0";
                    }
                    cls_Venta.Usuario = Usuario;
                    V_DT = cls_Venta.mtd_consultar_Venta_Ultima_venta();
                    if (V_DT.Rows.Count > 0)
                    {
                        DataRow rows = V_DT.Rows[0];
                        cls_Caja.Codigo_Ultima_venta = rows["Codigo"].ToString();
                        Ffin = rows["Codigo"].ToString();             
                    }
                    else
                    {
                        cls_Caja.Codigo_Ultima_venta = "0";
                        Ffin = "0";
                    }

                    v_ok = cls_Caja.mtd_registrar();
                    if (v_ok == true)
                    {
                        frm_msg frm_Msg = new frm_msg();
                        frm_Msg.txt_mensaje.Text = "Cierre de caja Correcto";
                        frm_Msg.ShowDialog();
                        this.Close();

                        //Consultar codigo ultimo cierre
                        cls_Caja.Usuario = Usuario;
                        V_DT = cls_Caja.mtd_consultar_caja_cierre();
                        if (V_DT.Rows.Count > 0)
                        {
                            DataRow rows = V_DT.Rows[0];
                            CodigoUltimoCierre = rows["Codigo"].ToString();
                        }

                        frm_informe_cierre frm_InfoCaja = new frm_informe_cierre();
                        frm_InfoCaja.Valor_cierre = txt_valor.Text;
                        frm_InfoCaja.CodigoultimoCierre = Fini;
                        frm_InfoCaja.CodigoUltimaVenta = Ffin;
                        frm_InfoCaja.Usuario = this.Usuario;
                        frm_InfoCaja.CodigoUlCierre = CodigoUltimoCierre;
                        frm_InfoCaja.Impresion = true;
                        frm_InfoCaja.ShowDialog();
                    }
                }
                else
                {
                    errorProvider.SetError(txt_valor, "Ingrese valores numericos");
                }
            }
            else
            {
                errorProvider.SetError(txt_valor, "Ingrese valor cierre");
            }
        }
    }
}
