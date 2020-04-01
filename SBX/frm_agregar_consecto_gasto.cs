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
    public partial class frm_agregar_consecto_gasto : Form
    {
        cls_gastos cls_Gastos = new cls_gastos();
        DataTable v_dt;
        DataRow v_rows;
        int v_validado = 0;
        bool v_ok;

        public frm_agregar_consecto_gasto()
        {
            InitializeComponent();
        }
        private void frm_agregar_consecto_gasto_Load(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            v_validado = 0;
            errorProvider.Clear();
            if (txt_nombre.Text.Trim() != "")
            {
                if (txt_descripcion.Text.Trim() != "")
                {
                    v_dt = cls_Gastos.mtd_consultar_gastos();
                    if (v_dt.Rows.Count > 0)
                    {
                        foreach (DataRow rows in v_dt.Rows)
                        {
                            if (rows["Nombre"].ToString() == txt_nombre.Text)
                            {
                                errorProvider.SetError(txt_nombre, "Gasto ya existe");
                                v_validado++;
                            }
                        }
                        if (v_validado == 0)
                        {
                            cls_Gastos.Nombre = txt_nombre.Text;
                            cls_Gastos.Descripcion = txt_descripcion.Text;
                            v_ok = cls_Gastos.mtd_registrar();
                            if (v_ok == true)
                            {
                                frm_msg msg = new frm_msg();
                                msg.txt_mensaje.Text = "Gasto registrado correctamente";
                                msg.ShowDialog();
                                this.Dispose();
                            }
                        }
                    }
                    else
                    {
                        cls_Gastos.Nombre = txt_nombre.Text;
                        cls_Gastos.Descripcion = txt_descripcion.Text;
                        v_ok = cls_Gastos.mtd_registrar();
                        if (v_ok == true)
                        {
                            frm_msg msg = new frm_msg();
                            msg.txt_mensaje.Text = "Gasto registrado correctamente";
                            msg.ShowDialog();
                            this.Dispose();
                        }
                    }
                }
                else
                {
                    errorProvider.SetError(txt_descripcion, "Ingrese descripcion");
                }
            }
            else
            {
                errorProvider.SetError(txt_nombre,"Ingrese Nombre de Gasto");
            }
        }
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
