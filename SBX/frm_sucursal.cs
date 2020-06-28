using SBX.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX
{
    public partial class frm_sucursal : Form
    {
        //Instancias
        cls_global cls_Global = new cls_global();
        cls_sucursal cls_Sucursal = new cls_sucursal();


        //Delegado
        public delegate void EnviarInfo();
        public event EnviarInfo Enviainfo;

        int v_validado = 0;
        bool v_registro = true;
        DataTable v_dt;
        bool v_ok = true;
        public frm_sucursal()
        {
            InitializeComponent();
        }
        public frm_sucursal(string Codigo)
        {
            InitializeComponent();
            v_registro = false;
           
            cls_Sucursal.Codigo = Convert.ToInt32(Codigo);
            v_dt = new DataTable();
            v_dt = cls_Sucursal.mtd_consultar_sucursal_exacta();
            if (v_dt.Rows.Count > 0)
            {
                foreach (DataRow rows in v_dt.Rows)
                {
                    txt_ciudad.Text = rows["Ciudad"].ToString();
                    txt_direccion.Text = rows["Direccion"].ToString();
                    txt_telefono.Text = rows["Telefono"].ToString();
                    txt_celular.Text = rows["Celular"].ToString();
                    txt_email.Text = rows["Email"].ToString();
                    txt_sitio_web.Text = rows["SitioWeb"].ToString();
                }
            }
        }
        private void frm_sucursal_Load(object sender, EventArgs e)
        {

        }
        private void btn_aceptar_Click(object sender, EventArgs e)
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

        private void Validar()
        {
            v_validado = 0;
            errorProvider.Clear();
         
            if (txt_nombre.Text.Trim() == "") { errorProvider.SetError(txt_nombre, "Ingrese nombre"); v_validado++; }
            if (txt_celular.Text.Trim() == "") { errorProvider.SetError(txt_celular, "Ingrese numero de celular"); v_validado++; }
            if (txt_email.Text.Trim() != "")
            {
                if (!cls_Global.validarEmail(txt_email.Text))
                {
                    errorProvider.SetError(txt_email, "Formato Email incorrecto");
                    v_validado++;
                }
            }
        }
        private void mtd_guardar()
        {                            
            if (v_validado == 0)
            {
                cls_Sucursal.Nombre = txt_nombre.Text;
                cls_Sucursal.Ciudad = txt_ciudad.Text;
                cls_Sucursal.Direccion = txt_direccion.Text;
                cls_Sucursal.Telefono = txt_telefono.Text;
                cls_Sucursal.Celular = txt_celular.Text;
                cls_Sucursal.Email = txt_email.Text;
                cls_Sucursal.Sitioweb = txt_sitio_web.Text;
                cls_Sucursal.CodigoCliente = lbl_codigo.Text;
                v_ok = cls_Sucursal.mtd_registrar();

                frm_msg frm_Msg = new frm_msg();
                if (v_ok == true)
                {
                    frm_Msg.txt_mensaje.Text = "Sucursal registrada correctamente";
                    frm_Msg.ShowDialog();
                    mtd_limpiar();
                    v_registro = true;
                }

            }
        }
        private void mtd_editar()
        {

            cls_Sucursal.v_buscar = txt_codigo.Text;
            cls_Sucursal.v_tipo_busqueda = "";
                v_dt = cls_Sucursal.mtd_consultar_sucursal();
                if (v_dt.Rows.Count > 0)
                {
                    DataRow row = v_dt.Rows[0];
                    if (row["Codigo"].ToString() != txt_codigo.Text)
                    {
                        errorProvider.SetError(txt_codigo, "Codigo ya existe");
                        v_validado++;
                    }
                }         

            if (v_validado == 0)
            {
                cls_Sucursal.Codigo = Convert.ToInt32(txt_codigo.Text);
                cls_Sucursal.Nombre = txt_nombre.Text;
                cls_Sucursal.Ciudad = txt_ciudad.Text;
                cls_Sucursal.Direccion = txt_direccion.Text;
                cls_Sucursal.Telefono = txt_telefono.Text;
                cls_Sucursal.Celular = txt_celular.Text;
                cls_Sucursal.Email = txt_email.Text;
                cls_Sucursal.Sitioweb = txt_sitio_web.Text;
                cls_Sucursal.CodigoCliente = txt_codigo.Text;
                v_ok = cls_Sucursal.mtd_Editar();

                frm_msg frm_Msg = new frm_msg();
                if (v_ok == true)
                {
                    frm_Msg.txt_mensaje.Text = "Sucursal Editado correctamente";
                    frm_Msg.ShowDialog();
                    mtd_limpiar();
                    lbl_codigo.Text = "";
                    v_registro = true;
                    Enviainfo();
                    this.Close();
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            mtd_limpiar();
        }
        private void mtd_limpiar()
        {
            errorProvider.Clear();
            txt_nombre.Text = "";
            txt_ciudad.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_celular.Text = "";
            txt_email.Text = "";
            txt_sitio_web.Text = "";
            v_registro = true;
        }
      
    }
}
