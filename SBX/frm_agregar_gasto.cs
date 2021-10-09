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
    public partial class frm_agregar_gasto : Form
    {
        cls_global cls_Global = new cls_global();
        cls_gastos cls_Gastos = new cls_gastos();
        cls_gastos_m cls_Gm = new cls_gastos_m();

        DataTable v_dt;
        DataRow v_rows;
        int v_validado = 0;
        bool v_ok;
        int Codigo = 0;
        public string usuario { get; set; }

        public frm_agregar_gasto()
        {
            InitializeComponent();
        }
        private void frm_agregar_gasto_Load(object sender, EventArgs e)
        {
            listarGastos();
        }

        //metodos
        private void listarGastos()
        {
            v_dt = cls_Gastos.mtd_consultar_gastos();
            cbx_Gasto.Items.Clear();
            if (v_dt.Rows.Count > 0)
            {
                foreach (DataRow rows in v_dt.Rows)
                {
                    cbx_Gasto.Items.Add(rows["Nombre"]);
                }
                cbx_Gasto.SelectedIndex = 0;
            }
        }
        // Eventos
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (txt_valor.Text.Trim() != "" && txt_valor_iva.Text.Trim() != "")
            {
                if (cls_Global.IsNumericDouble(txt_valor.Text) && cls_Global.IsNumericDouble(txt_valor_iva.Text))
                {
                    v_dt = cls_Gastos.mtd_consultar_gastos();
                    if (v_dt.Rows.Count > 0)
                    {
                        foreach (DataRow rows in v_dt.Rows)
                        {
                            if (rows["Nombre"].ToString() == cbx_Gasto.Text)
                            {
                                Codigo = Convert.ToInt32(rows["Codigo"]);
                            }
                        }

                        if (Codigo != 0)
                        {
                            cls_Gm.proveedor = txt_proveedor.Text;
                            cls_Gm.Gasto = Codigo;
                            cls_Gm.Valor = Convert.ToDouble(txt_valor.Text);
                            cls_Gm.Valor_iva = txt_valor_iva.Text;
                            cls_Gm.usuario = this.usuario;
                            v_ok = cls_Gm.mtd_registrar();
                            if (v_ok == true)
                            {
                                frm_msg msg = new frm_msg();
                                msg.txt_mensaje.Text = "Gasto registrado correctamente";
                                msg.ShowDialog();
                                this.Dispose();
                            }
                        }
                    }
                }
                else
                {
                    errorProvider.SetError(txt_valor, "Ingrese valores numericos");
                    errorProvider.SetError(txt_valor_iva, "Ingrese valores numericos");
                }
            }
            else
            {
                errorProvider.SetError(txt_valor,"Ingrese valor Gasto");
                errorProvider.SetError(txt_valor_iva, "Ingrese valores numericos");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        frm_ayuda frm_Ayuda;
        private void btn_buscar_proveedor_Click(object sender, EventArgs e)
        {
            if (frm_Ayuda == null || frm_Ayuda.IsDisposed)
            {
                frm_Ayuda = new frm_ayuda("Buscar proveedor");
                frm_Ayuda.Enviainfo2 += new frm_ayuda.EnviarInfo2(mtd_dato_proveedor);
                frm_Ayuda.Show();
            }
            else
            {
                frm_Ayuda.BringToFront();
                frm_Ayuda.WindowState = FormWindowState.Normal;
            }
        }
        private void mtd_dato_proveedor(string info, string info2, string info3)
        {
            txt_proveedor.Text = info;
            txt_nom_proveedor.Text = info2;
        }
    }
}
