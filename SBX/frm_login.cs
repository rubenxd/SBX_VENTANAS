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
    public partial class frm_login : Form
    {
        cls_login cls_Login = new cls_login();
        frm_inicio frm_Inicio = new frm_inicio();
        cls_usuario user = new cls_usuario();

        int v_validado = 0;
        DataTable v_dt;

        public frm_login()
        {
            InitializeComponent();
        }

        //Metodos
        private void mtd_validar()
        {
            v_validado = 0;

            if (txtUsuario.Text == "" || txtUsuario.Text == "USUARIO")
            {
                errorProvider.SetError(txtUsuario,"Ingrese usuario");
                v_validado++;
            }
            if (txtContrasena.Text == "" || txtContrasena.Text == "CONTRASEÑA")
            {
                errorProvider.SetError(txtContrasena, "Ingrese Contraseña");
                v_validado++;
            }
        }
        private void mtd_ingresar()
        {
            mtd_validar();
            if (v_validado == 0)
            {
                cls_Login.NombreUsuario = txtUsuario.Text;
                cls_Login.Contrasena = txtContrasena.Text;
                v_dt = cls_Login.mtd_consultar_estado();
                if (v_dt.Rows.Count > 0)
                {
                    DataRow rows = v_dt.Rows[0];
                    if (rows["Codigo"].ToString() == "")
                    {
                        errorProvider.SetError(txtUsuario, "Usuario incorrecto");
                        errorProvider.SetError(txtContrasena, "Contraseña incorrecta");
                    }
                    else
                    {
                        frm_Inicio.NombreUsuario = rows["NombreUsuario"].ToString();
                        frm_Inicio.Nombre = rows["Nombre"].ToString();
                        frm_Inicio.Codigo = rows["Codigo"].ToString();
                        frm_Inicio.Show();
                        this.Hide();
                    }
                }
                else
                {
                    errorProvider.SetError(txtUsuario,"Usuario incorrecto");
                    errorProvider.SetError(txtContrasena, "Contraseña incorrecta");
                }
            }
        }

        //Eventos
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Silver;
            }
        }
        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.White;
            }
        }
        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.Silver;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            mtd_ingresar();
        }
    }
}
