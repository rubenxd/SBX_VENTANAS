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
    public partial class frm_agregar_abono : Form
    {
        //Delegado
        public delegate void EnviarInfo(double pago,double valor,int cod_sisp);
        public event EnviarInfo Enviainfo;

        cls_sistema_separado cls_Sistema_separado = new cls_sistema_separado();
        cls_global cls_Global = new cls_global();

        //Variables
        DataTable v_dt;
        DataRow v_rows;
        bool v_ok;
        int v_fila = 0;
        int v_contador = 0;
        int v_validado = 0;

        public frm_agregar_abono()
        {
            InitializeComponent();
        }
        private void frm_agregar_abono_Load(object sender, EventArgs e)
        {
            mtd_calculos();
            if (lbl_estado.Text == "Pago")
            {
                pnl_abajo.Enabled = false;
            }
        }
        //Metodos
        private void mtd_calculos()
        {
            cls_Sistema_separado.Codigo = Convert.ToInt32(lbl_num_separado.Text);
            v_dt = cls_Sistema_separado.mtd_consultar_abono_sistema();
            if (v_dt.Rows.Count > 0)
            {
                v_rows = v_dt.Rows[0];
                double pago = Convert.ToDouble(v_rows["Pago"]);
                lbl_pagado.Text = pago.ToString("N0");
                lbl_cuota_num.Text = v_rows["Cuotas"].ToString();
                double Saldo = Convert.ToDouble(lbl_valor.Text) - pago;
                lbl_saldo.Text = Saldo.ToString("N0"); 
            }
        }

        //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            v_validado = 0;
            if (!cls_Global.IsNumericDouble(txt_abono.Text))
            {
                v_validado++;
                errorProvider.SetError(txt_abono,"Ingrese valores numericos");
            }

            if (v_validado == 0)
            {
                if (Convert.ToDouble(txt_abono.Text) > 0)
                {
                    if ((Convert.ToDouble(lbl_pagado.Text) + (Convert.ToDouble(txt_abono.Text))) > Convert.ToDouble(lbl_valor.Text))
                    {
                        errorProvider.SetError(txt_abono, "La cuota mas lo pagado supera el valor separado");
                    }
                    else
                    {
                        cls_Sistema_separado.Codigo = Convert.ToInt32(lbl_num_separado.Text);
                        cls_Sistema_separado.Valor = Convert.ToDouble(txt_abono.Text);
                        v_ok = cls_Sistema_separado.mtd_registrar_abono();
                        frm_msg frm_Msg = new frm_msg();
                        if (v_ok == true)
                        {
                            frm_Msg.txt_mensaje.Text = "Abono registrado correctamente";
                            frm_Msg.ShowDialog();
                            Enviainfo((Convert.ToDouble(lbl_pagado.Text) + (Convert.ToDouble(txt_abono.Text))), Convert.ToDouble(lbl_valor.Text), Convert.ToInt32(lbl_num_separado.Text));
                            this.Dispose();
                        }
                    }
                }
                else
                {
                    errorProvider.SetError(txt_abono, "Abono debe ser mayor a cero (0)");
                }
            }
        }
        private void btn_ver_productos_Click(object sender, EventArgs e)
        {
            if (btn_ver_productos.Text == "Ver productos")
            {
                this.Height = 516;
                dtg_productos.Height = 106;
                pnl_info.Height = 365;
                btn_ver_productos.Text = "Ocultar Productos";

                cls_Sistema_separado.Codigo = Convert.ToInt32(lbl_num_separado.Text);
                v_dt = cls_Sistema_separado.mtd_consultar_productos();
                dtg_productos.Rows.Clear();
                if (v_dt.Rows.Count > 0)
                {
                    v_contador = 0;
                    v_fila = v_dt.Rows.Count;
                    dtg_productos.Rows.Add(v_fila);
                    foreach (DataRow rows in v_dt.Rows)
                    {
                        dtg_productos.Rows[v_contador].Cells["cl_producto"].Value = rows["Producto"].ToString();
                        v_contador++;
                    }
                }
            }
            else
            {
                this.Height = 403;
                dtg_productos.Height = 0;
                pnl_info.Height = 260;
                btn_ver_productos.Text = "Ver productos";
            }
        }
    }
}
