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
    public partial class frm_agregar_usuario : Form
    {
        cls_global cls_Global = new cls_global();
        cls_usuario cls_Usuario = new cls_usuario();
        cls_rol cls_Rol = new cls_rol();

        public bool registro { get; set; }
        public string Codigo { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Emial { get; set; }
        public string Fecha { get; set; }
        public string Usuairo { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
        public string NomRol { get; set; }
        public string Rol { get; set; }
        int v_validado = 0;
        DataTable V_DT;
        bool v_ok;

        public frm_agregar_usuario()
        {
            InitializeComponent();
            cbx_estado.Text = "Activo";
            txt_dni.Focus();
        }
        private void frm_agregar_usuario_Load(object sender, EventArgs e)
        {
            mtd_cargar_rol();
            if (registro == false)
            {
                btn_guardar.Text = "Editar";
                txt_dni.Text = DNI;
                txt_nombre.Text = Nombre;
                txt_apellido.Text = Apellido;
                txt_celular.Text = Celular;
                txt_telefono.Text = Telefono;
                txt_email.Text = Emial;
                dtp_fecha_nc.Text = Fecha;
                txt_usuario.Text = Usuairo;
                txt_contrasena.Text = Contrasena;
                cbx_estado.Text = Estado;
                cbx_rol.Text = NomRol;
            }
        }

        //metodos
        private void mtd_cargar_rol()
        {
            V_DT = cls_Rol.mtd_consultar_Rol_todos();
            cbx_rol.Items.Clear();
            if (V_DT.Rows.Count > 0)
            {
                foreach (DataRow rows in V_DT.Rows)
                {
                    cbx_rol.Items.Add(rows["Nombre"]);
                }
                cbx_rol.SelectedIndex = 0;
            }
        }
        private void mtd_Limpiar()
        {
            txt_dni.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_celular.Text = "";
            txt_telefono.Text = "";
            txt_email.Text = "";
            dtp_fecha_nc.Value = DateTime.Today;
            txt_usuario.Text = "";
            txt_contrasena.Text = "";
            cbx_estado.Text = "Activo";
            errorProvider.Clear();

        }
        private void mtd_Validar()
        {
            v_validado = 0;

            if (txt_dni.Text.Trim() == "")
            {
                errorProvider.SetError(txt_dni,"Ingrese DNI");
                v_validado++;
            }
            if (txt_nombre.Text.Trim() == "")
            {
                errorProvider.SetError(txt_nombre, "Ingrese Nombre");
                v_validado++;
            }
            if (txt_usuario.Text.Trim() == "")
            {
                errorProvider.SetError(txt_usuario, "Ingrese Usuario");
                v_validado++;
            }
            if (txt_contrasena.Text.Trim() == "")
            {
                errorProvider.SetError(txt_contrasena, "Ingrese Contrasena");
                v_validado++;
            }
            if (cbx_rol.Text.Trim() == "")
            {
                errorProvider.SetError(cbx_rol, "Seleccione Rol");
                v_validado++;
            }
        }
        private void mtd_guardar()
        {
            errorProvider.Clear();
            cls_Usuario.DNI = txt_dni.Text;
            cls_Usuario.v_tipo_busqueda = "DNI";
            cls_Usuario.Buscar = txt_dni.Text;
            V_DT = cls_Usuario.mtd_consultar_datos_usuario();
            if (V_DT.Rows.Count > 0)
            {
                errorProvider.SetError(txt_dni, "DNI ya existe");
                v_validado++;
            }
            cls_Usuario.Nombre = txt_nombre.Text;
            cls_Usuario.Apellido = txt_apellido.Text;
            cls_Usuario.Celular = txt_celular.Text;
            cls_Usuario.Telefono = txt_telefono.Text;
            cls_Usuario.Email = txt_email.Text;
            cls_Usuario.FechaNC = dtp_fecha_nc.Value;

            cls_Usuario.Usuario = txt_usuario.Text;
            cls_Usuario.v_tipo_busqueda = "NombreUsuario";
            cls_Usuario.Buscar = txt_usuario.Text;
            V_DT = cls_Usuario.mtd_consultar_datos_usuario();
            if (V_DT.Rows.Count > 0)
            {
                errorProvider.SetError(txt_usuario, "Usuario ya existe");
                v_validado++;
            }
            cls_Usuario.Contrasena = txt_contrasena.Text;
            cls_Usuario.Estado = cbx_estado.Text;
            cls_Usuario.Rol = cbx_rol.Text;

            if (v_validado == 0)
            {
                v_ok = cls_Usuario.mtd_registrar();
                if (v_ok == true)
                {
                    frm_msg msg = new frm_msg();
                    msg.txt_mensaje.Text = "Usuario registrado correctamente";
                    msg.ShowDialog();
                    this.Dispose();
                }
            }
        }
        private void mtd_modificar()
        {
            errorProvider.Clear();
            cls_Usuario.Codigo = Convert.ToInt32(Codigo);
            cls_Usuario.DNI = txt_dni.Text;

            if (txt_dni.Text != DNI )
            {
                cls_Usuario.v_tipo_busqueda = "DNI";
                cls_Usuario.Buscar = txt_dni.Text;
                V_DT = cls_Usuario.mtd_consultar_datos_usuario();
                if (V_DT.Rows.Count > 0)
                {
                    errorProvider.SetError(txt_dni, "DNI ya existe");
                    v_validado++;
                }
            }
           
            cls_Usuario.Nombre = txt_nombre.Text;
            cls_Usuario.Apellido = txt_apellido.Text;
            cls_Usuario.Celular = txt_celular.Text;
            cls_Usuario.Telefono = txt_telefono.Text;
            cls_Usuario.Email = txt_email.Text;
            cls_Usuario.FechaNC = dtp_fecha_nc.Value;

            cls_Usuario.Usuario = txt_usuario.Text;
            if (txt_usuario.Text != Usuairo)
            {
                cls_Usuario.v_tipo_busqueda = "NombreUsuario";
                cls_Usuario.Buscar = txt_usuario.Text;
                V_DT = cls_Usuario.mtd_consultar_datos_usuario();
                if (V_DT.Rows.Count > 0)
                {
                    errorProvider.SetError(txt_usuario, "Usuario ya existe");
                    v_validado++;
                }
            }

            cls_Usuario.Contrasena = txt_contrasena.Text;
            cls_Usuario.Estado = cbx_estado.Text;
            cls_Usuario.Rol = cbx_rol.Text;

            if (v_validado == 0)
            {
                v_ok = cls_Usuario.mtd_modificar();
                if (v_ok == true)
                {
                    frm_msg msg = new frm_msg();
                    msg.txt_mensaje.Text = "Usuario Editado correctamente";
                    msg.ShowDialog();
                    this.Dispose();
                }
            }
        }

        //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            mtd_Limpiar();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            mtd_Validar();
            if (v_validado == 0)
            {
                if (registro == true)
                {
                    mtd_guardar();
                }
                else
                {
                    mtd_modificar();
                }  
            }
        }
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
    }
}
