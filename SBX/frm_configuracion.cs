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
    public partial class frm_configuracion : Form
    {
        cls_usuario cls_Usuario = new cls_usuario();
        cls_rol cls_Rol = new cls_rol();
        cls_rol_modulo_permiso cls_Rol_modulo_permiso = new cls_rol_modulo_permiso();

        public string Codigo { get; set; }
        DataTable v_dt;
        int contador = 0;
        int v_fila = 0;
        int v_contador = 0;
        bool v_confirmacion;
        bool v_ok;

        public frm_configuracion()
        {
            InitializeComponent();
            cbx_tipo_busqueda.SelectedIndex = 0;
        }
        private void frm_configuracion_Load(object sender, EventArgs e)
        {
            MensajeInformativoBotones();
            cbx_t_b.SelectedIndex = 0;
        }

        //Metodos
        public void MensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar");
            Botones.SetToolTip(btn_editar, "Editar");
            Botones.SetToolTip(btn_eliminar, "Eliminar");
            Botones.SetToolTip(btn_agregar, "Agregar");
            Botones.SetToolTip(btn_guardar, "Guardar");
            Botones.SetToolTip(btn_buscar_rol, "Buscar");
            Botones.SetToolTip(btn_editar_rol, "Editar");
            Botones.SetToolTip(btn_eliminar_rol, "Eliminar");
            Botones.SetToolTip(btn_agrega_rol, "Agregar");
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        private void mtd_cargar_usuarios()
        {
            cls_Usuario.v_tipo_busqueda = cbx_tipo_busqueda.Text;
            if (txt_buscar.Text == "Usuario")
            {
                cls_Usuario.Buscar = "";
            }
            else
            {
                cls_Usuario.Buscar = txt_buscar.Text;
            }
          
            v_dt = cls_Usuario.mtd_consultar_usuario();
            dtg_usuario.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                contador = 0;
                v_fila = v_dt.Rows.Count;
                dtg_usuario.Rows.Add(v_fila);
                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_usuario.Rows[contador].Cells["cl_codigo"].Value = rows["Codigo"];
                    dtg_usuario.Rows[contador].Cells["cl_DNI"].Value = rows["DNI"];
                    dtg_usuario.Rows[contador].Cells["cl_Nombres"].Value = rows["Nombres"];
                    dtg_usuario.Rows[contador].Cells["cl_Apellido"].Value = rows["Apellidos"];
                    dtg_usuario.Rows[contador].Cells["cl_Celular"].Value = rows["Celular"];
                    dtg_usuario.Rows[contador].Cells["cl_telefono"].Value = rows["Telefono"];
                    dtg_usuario.Rows[contador].Cells["cl_email"].Value = rows["Email"];
                    dtg_usuario.Rows[contador].Cells["cl_fecha_nacimiento"].Value = rows["FechaNacimiento"];
                    dtg_usuario.Rows[contador].Cells["cl_Usuario"].Value = rows["NombreUsuario"];           
                    dtg_usuario.Rows[contador].Cells["cl_contrasena"].Value = rows["dContrasena"];
                    dtg_usuario.Rows[contador].Cells["cl_estado"].Value = rows["Estado"];
                    dtg_usuario.Rows[contador].Cells["cl_Rol"].Value = rows["Rol"];
                    dtg_usuario.Rows[contador].Cells["cl_N_Rol"].Value = rows["Nrol"];
                    contador++;
                }
            }
        }
        private void mtd_cargar_rol()
        {
            cls_Rol.v_tipo_busqueda = cbx_t_b.Text;
            if (txt_busc.Text == "Rol")
            {
                cls_Rol.buscar = "";
            }
            else
            {
                cls_Rol.buscar = txt_busc.Text;
            }

            v_dt = cls_Rol.mtd_consultar_Rol();
            dtg_rol.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                contador = 0;
                v_fila = v_dt.Rows.Count;
                dtg_rol.Rows.Add(v_fila);
                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_rol.Rows[contador].Cells["cl_co"].Value = rows["Codigo"];
                    dtg_rol.Rows[contador].Cells["cl_nombre"].Value = rows["Nombre"];
                    dtg_rol.Rows[contador].Cells["cl_Descripcion_rol"].Value = rows["DescripcionRol"];
                    contador++;
                }
            }
        }
        private void mtd_dato_rol_permiso(string rol,string nombre,string Descripcion)
        {
            txt_cod_rol.Text = rol;
            txt_nom_rol.Text = nombre;
            txt_descrip_rol.Text = Descripcion;

            cls_Rol_modulo_permiso.Rol = rol;
            v_dt = cls_Rol_modulo_permiso.mtd_consultar_Rol_Modulo_permiso();
            dtg_rol_permiso.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                v_contador = 0;
                v_fila = v_dt.Rows.Count;
                dtg_rol_permiso.Rows.Add(v_fila);
                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_rol_permiso.Rows[v_contador].Cells["cl_cmp"].Value = rows["Codigo"].ToString();
                    dtg_rol_permiso.Rows[v_contador].Cells["cl_cod_modulo"].Value = rows["co_modulo"].ToString();
                    dtg_rol_permiso.Rows[v_contador].Cells["cl_modulo"].Value = rows["Modulo"].ToString();
                    dtg_rol_permiso.Rows[v_contador].Cells["cl_cod_per"].Value = rows["cod_permiso"].ToString();
                    dtg_rol_permiso.Rows[v_contador].Cells["cl_permiso"].Value = rows["Permiso"].ToString();
                    v_contador++;
                }

                cls_Rol_modulo_permiso.Rol = rol;
                v_dt = cls_Rol_modulo_permiso.mtd_Rol_Modulo_permiso();
                if (v_dt.Rows.Count > 0)
                {
                    foreach (DataGridViewRow rowsd in dtg_rol_permiso.Rows)
                    {
                        foreach (DataRow rows in v_dt.Rows)
                        {
                            if (rowsd.Cells["cl_cmp"].Value.ToString() == rows["Modulo_permiso"].ToString())
                            {
                                rowsd.Cells["cl_add_per"].Value = true;
                            }
                        }
                    }
                }
            }
        }

        //Eventos
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            frm_agregar_usuario frm_Agregar_usuario = new frm_agregar_usuario();
            frm_Agregar_usuario.registro = true;
            frm_Agregar_usuario.ShowDialog();
            mtd_cargar_usuarios();
        }
        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "Usuario")
            {
                txt_buscar.Text = "";
                txt_buscar.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "Usuario";
                txt_buscar.ForeColor = Color.Silver;
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_cargar_usuarios();
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_cargar_usuarios();
        }
        private void dtg_usuario_DoubleClick(object sender, EventArgs e)
        {
            if (dtg_usuario.Rows.Count > 0)
            {
                frm_agregar_usuario frm_Agregar_usuario = new frm_agregar_usuario();
                frm_Agregar_usuario.registro = false;
                foreach (DataGridViewRow rows in dtg_usuario.SelectedRows)
                { 
                    frm_Agregar_usuario.Codigo = rows.Cells["cl_codigo"].Value.ToString();
                    frm_Agregar_usuario.DNI = rows.Cells["cl_DNI"].Value.ToString();
                    frm_Agregar_usuario.Nombre = rows.Cells["cl_nombres"].Value.ToString();
                    frm_Agregar_usuario.Apellido = rows.Cells["cl_apellido"].Value.ToString();
                    frm_Agregar_usuario.Celular = rows.Cells["cl_Celular"].Value.ToString();
                    frm_Agregar_usuario.Telefono = rows.Cells["cl_telefono"].Value.ToString();
                    frm_Agregar_usuario.Emial = rows.Cells["cl_email"].Value.ToString();
                    frm_Agregar_usuario.Fecha = rows.Cells["cl_fecha_nacimiento"].Value.ToString();
                    frm_Agregar_usuario.Usuairo = rows.Cells["cl_Usuario"].Value.ToString();
                    frm_Agregar_usuario.Contrasena = rows.Cells["cl_contrasena"].Value.ToString();
                    frm_Agregar_usuario.Estado = rows.Cells["cl_estado"].Value.ToString();
                    frm_Agregar_usuario.NomRol = rows.Cells["cl_N_Rol"].Value.ToString();
                    frm_Agregar_usuario.Rol = rows.Cells["cl_Rol"].Value.ToString();
                }
                frm_Agregar_usuario.ShowDialog();
                mtd_cargar_usuarios();
            }          
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dtg_usuario.Rows.Count > 0)
            {
                frm_agregar_usuario frm_Agregar_usuario = new frm_agregar_usuario();
                frm_Agregar_usuario.registro = false;
                foreach (DataGridViewRow rows in dtg_usuario.SelectedRows)
                {
                    frm_Agregar_usuario.Codigo = rows.Cells["cl_codigo"].Value.ToString();
                    frm_Agregar_usuario.DNI = rows.Cells["cl_DNI"].Value.ToString();
                    frm_Agregar_usuario.Nombre = rows.Cells["cl_nombres"].Value.ToString();
                    frm_Agregar_usuario.Apellido = rows.Cells["cl_apellido"].Value.ToString();
                    frm_Agregar_usuario.Celular = rows.Cells["cl_Celular"].Value.ToString();
                    frm_Agregar_usuario.Telefono = rows.Cells["cl_telefono"].Value.ToString();
                    frm_Agregar_usuario.Emial = rows.Cells["cl_email"].Value.ToString();
                    frm_Agregar_usuario.Fecha = rows.Cells["cl_fecha_nacimiento"].Value.ToString();
                    frm_Agregar_usuario.Usuairo = rows.Cells["cl_Usuario"].Value.ToString();
                    frm_Agregar_usuario.Contrasena = rows.Cells["cl_contrasena"].Value.ToString();
                    frm_Agregar_usuario.Estado = rows.Cells["cl_estado"].Value.ToString();
                    frm_Agregar_usuario.NomRol = rows.Cells["cl_N_Rol"].Value.ToString();
                    frm_Agregar_usuario.Rol = rows.Cells["cl_Rol"].Value.ToString();
                }
                frm_Agregar_usuario.ShowDialog();
                mtd_cargar_usuarios();
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dtg_usuario.Rows.Count > 0)
            {
                frm_confirmacion frm_Confirmacion = new frm_confirmacion();

                frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                v_contador = dtg_usuario.SelectedRows.Count;
                frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + "  Usuarios?";
                frm_Confirmacion.ShowDialog();
                if (v_confirmacion == true)
                { 
                    foreach (DataGridViewRow rows in dtg_usuario.SelectedRows)
                    {
                        cls_Usuario.Codigo = Convert.ToInt32(rows.Cells["cl_codigo"].Value);
                        cls_Usuario.mtd_eliminar();
                    }
                }
                mtd_cargar_usuarios();
            }
        }
        private void txt_busc_Enter(object sender, EventArgs e)
        {
            if (txt_busc.Text == "Rol")
            {
                txt_busc.Text = "";
                txt_busc.ForeColor = Color.Black;
            }
        }
        private void txt_busc_Leave(object sender, EventArgs e)
        {
            if (txt_busc.Text == "")
            {
                txt_busc.Text = "Rol";
                txt_busc.ForeColor = Color.Silver;
            }
        }
        private void btn_bus_Click(object sender, EventArgs e)
        {
            mtd_cargar_rol();
        }
        private void txt_busc_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_cargar_rol();
        }
        private void btn_agrega_rol_Click(object sender, EventArgs e)
        {
            frm_agregar_rol frm_Agregar_rol = new frm_agregar_rol();
            frm_Agregar_rol.registro = true;
            frm_Agregar_rol.ShowDialog();
            mtd_cargar_rol();
        }
        private void dtg_rol_DoubleClick(object sender, EventArgs e)
        {
            frm_agregar_rol frm_Agregar_rol = new frm_agregar_rol();
            frm_Agregar_rol.registro = false;
            foreach (DataGridViewRow rows in dtg_rol.SelectedRows)
            {
                frm_Agregar_rol.Codigo = rows.Cells["cl_co"].Value.ToString();
                frm_Agregar_rol.Nombre = rows.Cells["cl_nombre"].Value.ToString();
                frm_Agregar_rol.Descripcion = rows.Cells["cl_Descripcion_rol"].Value.ToString();
                frm_Agregar_rol.ShowDialog();
            }
            mtd_cargar_usuarios();
        }
        private void btn_eliminar_rol_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dtg_rol.SelectedRows)
            {
                frm_confirmacion frm_Confirmacion = new frm_confirmacion();

                frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                v_contador = dtg_rol.SelectedRows.Count;
                frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + "  Rol?";
                frm_Confirmacion.ShowDialog();
                if (v_confirmacion == true)
                {
                    cls_Rol.Codigo = Convert.ToInt32(rows.Cells["cl_co"].Value);
                    v_ok = cls_Rol.mtd_eliminar();
                    if (v_ok == true)
                    {
                        frm_msg frm_Msg = new frm_msg();
                        frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                        frm_Msg.txt_mensaje.Text = "Rol Eliminado correctamente";
                        frm_Msg.ShowDialog();
                    }
                }
            }
            mtd_cargar_rol();
        }
        private void btn_editar_rol_Click(object sender, EventArgs e)
        {
            if (dtg_rol.Rows.Count > 0)
            {
                frm_agregar_rol frm_Agregar_rol = new frm_agregar_rol();
                frm_Agregar_rol.registro = false;
                frm_Agregar_rol.btn_guardar.Text = "Editar";
                foreach (DataGridViewRow rows in dtg_rol.SelectedRows)
                {
                    frm_Agregar_rol.Codigo = rows.Cells["cl_co"].Value.ToString();
                    frm_Agregar_rol.Nombre = rows.Cells["cl_nombre"].Value.ToString();
                    frm_Agregar_rol.Descripcion = rows.Cells["cl_Descripcion_rol"].Value.ToString();
                }
                frm_Agregar_rol.ShowDialog();

                mtd_cargar_rol();
            }
        }
        frm_ayuda frm_Ayuda;
        private void btn_buscar_rol_Click(object sender, EventArgs e)
        {
            frm_Ayuda = new frm_ayuda("Buscar Rol_permiso");
            frm_Ayuda.Enviainfo2 += new frm_ayuda.EnviarInfo2(mtd_dato_rol_permiso);
            frm_Ayuda.Show();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (txt_cod_rol.Text != "")
            {
                if (dtg_rol_permiso.Rows.Count > 0)
                {
                    cls_Rol_modulo_permiso.Rol = txt_cod_rol.Text;
                    v_ok = cls_Rol_modulo_permiso.mtd_eliminar();
                    if (v_ok == true)
                    {
                        foreach (DataGridViewRow rowss in dtg_rol_permiso.Rows)
                        {
                            cls_Rol_modulo_permiso.Rol = txt_cod_rol.Text;
                            cls_Rol_modulo_permiso.Modulo_Permiso = rowss.Cells["cl_cmp"].Value.ToString();
                            if (Convert.ToBoolean(rowss.Cells["cl_add_per"].Value) != false)
                            {
                                cls_Rol_modulo_permiso.mtd_registrar();
                            }
                           
                        }

                        frm_msg msg = new frm_msg();
                        msg.txt_mensaje.Text = "Proceso terminado";
                        msg.ShowDialog();
                    }
                }
            }
            else
            {
                errorProvider.SetError(txt_cod_rol,"Ingrese Rol");
            }
        }

        private void btn_guardar_parametros_Click(object sender, EventArgs e)
        {
            string buscaAuto = "NO";
            string paginado = "NO";
            string PreguntaImpri = "NO";
            string ValidaStock = "NO";
            if (chk_ba.Checked == true)
            {
                buscaAuto = "SI";
            }
            if (chk_dp.Checked == true)
            {
                paginado = "SI";
            }
            if (chkBoxPreuntaImprimir.Checked)
            {
                PreguntaImpri = "SI";
            }
            if (checkBoxValidaStock.Checked)
            {
                ValidaStock = "SI";
            }

            cls_parametros cls_Parametros = new cls_parametros();
            cls_Parametros.Buscar_automaticamente = buscaAuto;
            cls_Parametros.Datos_paginados = paginado;
            cls_Parametros.Ruta_backup_db = txt_ruta_backup_db.Text;
            cls_Parametros.PreuntaImprimir = PreguntaImpri;
            cls_Parametros.ValidaStockEnCero = ValidaStock;
            v_ok = cls_Parametros.mtd_Editar();
          
            if (v_ok == true)
            {
                frm_msg frm_Msg = new frm_msg();
                frm_Msg.txt_mensaje.Text = "Registrado correctamente";
                frm_Msg.ShowDialog();
            }
            else
            {
                frm_msg frm_Msg = new frm_msg();
                frm_Msg.pnl_centro.BackColor = Color.White;
                frm_Msg.lbl_titulo.Text = "ERROR";
                frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                frm_Msg.txt_mensaje.Text = "Error al intentar registrar";
                frm_Msg.ShowDialog();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_parametros cls_Parametros = new cls_parametros();
            v_dt = cls_Parametros.mtd_consultar_parametros();
            foreach (DataRow item in v_dt.Rows)
            {
                if (item["Buscar_automaticamente"].ToString() == "SI")
                {
                    chk_ba.Checked = true;
                }
                if (item["Datos_paginados"].ToString() == "SI")
                {
                    chk_dp.Checked = true;
                }
                if (item["PreuntaImprimir"].ToString() == "SI")
                {
                    chkBoxPreuntaImprimir.Checked = true;
                }
                if (item["Validar_stock"].ToString() == "SI")
                {
                    checkBoxValidaStock.Checked = true;
                }

                txt_ruta_backup_db.Text = item["rutaBackupDB"].ToString();
            }
        }
    }
}
