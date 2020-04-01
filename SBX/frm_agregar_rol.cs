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
    public partial class frm_agregar_rol : Form
    {
        cls_rol cls_Rol = new cls_rol();
        public bool registro { get; set; }
        DataTable v_dt;
        bool existe = false;
        int maxCodigo = 0;
        bool v_ok = true;
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public frm_agregar_rol()
        {
            InitializeComponent();
        }
        private void frm_agregar_rol_Load(object sender, EventArgs e)
        {
            if (registro == false)
            {
                txt_nombre.Text = Nombre;
                txt_desc_rol.Text = Descripcion;
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
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (registro == true)
            {
                existe = false;
                if (txt_nombre.Text.Trim() != "")
                {
                    v_dt = cls_Rol.mtd_consultar_Rol_todos();
                    if (v_dt.Rows.Count > 0)
                    {
                        foreach (DataRow rows in v_dt.Rows)
                        {
                            maxCodigo = Convert.ToInt32(rows["Codigomax"]);
                            if (txt_nombre.Text == rows["Nombre"].ToString())
                            {
                                existe = true;
                            }
                        }

                        if (existe == true)
                        {
                            errorProvider.SetError(txt_nombre, "Rol ya existe");
                        }
                        else
                        {
                            cls_Rol.Codigo = maxCodigo;
                            cls_Rol.Nombre = txt_nombre.Text;
                            cls_Rol.DescripcionRol = txt_desc_rol.Text;
                            v_ok = cls_Rol.mtd_registrar();
                            if (v_ok == true)
                            {
                                frm_msg frm_Msg = new frm_msg();
                                frm_Msg.txt_mensaje.Text = "Rol registrado correctamente";
                                frm_Msg.ShowDialog();
                                this.Dispose();
                            }
                        }
                    }
                }
                else
                {
                    errorProvider.SetError(txt_nombre, "Ingrese Rol");
                }
            }
            else
            {
                existe = false;
                if (txt_nombre.Text.Trim() != "")
                {
                    if (txt_nombre.Text != Nombre)
                    {
                        v_dt = cls_Rol.mtd_consultar_Rol_todos();
                        if (v_dt.Rows.Count > 0)
                        {
                            foreach (DataRow rows in v_dt.Rows)
                            {
                                if (txt_nombre.Text == rows["Nombre"].ToString())
                                {
                                    existe = true;
                                }
                            }

                            if (existe == true)
                            {
                                errorProvider.SetError(txt_nombre, "Rol ya existe");
                            }
                            else
                            {
                                cls_Rol.Codigo = Convert.ToInt32(Codigo);
                                cls_Rol.Nombre = txt_nombre.Text;
                                cls_Rol.DescripcionRol = txt_desc_rol.Text;
                                v_ok = cls_Rol.mtd_editar();
                                if (v_ok == true)
                                {
                                    frm_msg frm_Msg = new frm_msg();
                                    frm_Msg.txt_mensaje.Text = "Rol modificado correctamente";
                                    frm_Msg.ShowDialog();
                                    this.Dispose();
                                }
                            }
                        }
                    }
                    else
                    {
                        cls_Rol.Codigo = Convert.ToInt32(Codigo);
                        cls_Rol.Nombre = txt_nombre.Text;
                        cls_Rol.DescripcionRol = txt_desc_rol.Text;
                        v_ok = cls_Rol.mtd_editar();
                        if (v_ok == true)
                        {
                            frm_msg frm_Msg = new frm_msg();
                            frm_Msg.txt_mensaje.Text = "Rol modificado correctamente";
                            frm_Msg.ShowDialog();
                            this.Dispose();
                        }
                    }
                }
                else
                {
                    errorProvider.SetError(txt_nombre, "Ingrese Rol");
                }
            }
        }
    }
}
