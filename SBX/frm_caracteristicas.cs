using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBX.MODEL;

namespace SBX
{
    public partial class frm_caracteristicas : Form
    {
        //instancias
        cls_categoria cls_Categoria = new cls_categoria();
        cls_unidad_medida cls_Unidad_medida = new cls_unidad_medida();
        cls_marca cls_Marca = new cls_marca();
        cls_ubicacion cls_Ubicacion = new cls_ubicacion();
        cls_salida_para cls_Salida_para = new cls_salida_para();
       
        //variables
        DataTable v_dt;
        int v_validado = 0;
        int v_fila;
        int v_contador = 0;
        bool v_ok;
        bool v_confirmacion;
        int Eliminados;
        int Error;

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Inicio formulario
        public frm_caracteristicas()
        {
            InitializeComponent();
            mtd_mensajeInformativoBotones();
        }
        private void frm_caracteristicas_Load(object sender, EventArgs e)
        {
            mtd_consultar();
        }

        //Metodos
        public void mtd_mensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_guardar, "Guardar");
            Botones.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void mtd_guardar()
        {
            v_validado = 0;
            DataRow rows;
            errorProvider.Clear();

            switch (tab_Caracteristicas.SelectedTab.Text)
            {
                case "Unidad medida":
                    if (txt_nombre_unidad_medida.Text.Trim() != "")
                    { 
                        cls_Unidad_medida.v_tipo_busqueda = "";
                        cls_Unidad_medida.Nombre = txt_nombre_unidad_medida.Text;
                        v_dt = cls_Unidad_medida.mtd_consultar_unidad_medida();
                        if (v_dt.Rows.Count > 0)
                        {
                            rows = v_dt.Rows[0];
                            if (txt_nombre_unidad_medida.Text == rows["Nombre"].ToString())
                            {
                                errorProvider.SetError(txt_nombre_unidad_medida, "Unidad de medida ya existe");
                                v_validado++;
                            }
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txt_nombre_unidad_medida, "Ingrese Unidad de medida");
                        v_validado++;
                    }
                   
                    break;
                case "Categoria":
                    if (txt_nombre_categoria.Text.Trim() != "")
                    {
                        cls_Categoria.v_tipo_busqueda = "";
                        cls_Categoria.Nombre = txt_nombre_categoria.Text;
                        v_dt = cls_Categoria.mtd_consultar_categoria();
                        if (v_dt.Rows.Count > 0)
                        {
                            rows = v_dt.Rows[0];
                            if (txt_nombre_categoria.Text == rows["Nombre"].ToString())
                            {
                                errorProvider.SetError(txt_nombre_categoria, "Categoria ya existe");
                                v_validado++;
                            }
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txt_nombre_categoria, "Ingrese Categoria");
                        v_validado++;
                    }
                   
                    break;
                case "Marca":
                    if (txt_nombre_marca.Text.Trim() != "")
                    {
                        cls_Marca.v_tipo_busqueda = "";
                        cls_Marca.Nombre = txt_nombre_marca.Text;
                        v_dt = cls_Marca.mtd_consultar_marca();
                        if (v_dt.Rows.Count > 0)
                        {
                            rows = v_dt.Rows[0];
                            if (txt_nombre_marca.Text == rows["Nombre"].ToString())
                            {
                                errorProvider.SetError(txt_nombre_marca, "Marca ya existe");
                                v_validado++;
                            }
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txt_nombre_marca, "Ingrese Marca");
                        v_validado++;
                    }
                   
                    break;
                case "Ubicacion":
                    if (txt_nombre_ubicacion.Text.Trim() != "")
                    {
                        cls_Ubicacion.v_tipo_busqueda = "";
                        cls_Ubicacion.Nombre = txt_nombre_ubicacion.Text;
                        v_dt = cls_Ubicacion.mtd_consultar_ubicacion();
                        if (v_dt.Rows.Count > 0)
                        {
                            rows = v_dt.Rows[0];
                            if (txt_nombre_ubicacion.Text == rows["Nombre"].ToString())
                            {
                                errorProvider.SetError(txt_nombre_ubicacion, "Ubicacion ya existe");
                                v_validado++;
                            }
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txt_nombre_ubicacion, "Ingrese Ubicacion");
                        v_validado++;
                    }
                    
                    break;
                case "Salida para":
                    if (txt_nombre_salida_para.Text.Trim() != "")
                    {
                        cls_Salida_para.v_tipo_busqueda = "";
                        cls_Salida_para.Nombre = txt_nombre_salida_para.Text;
                        v_dt = cls_Salida_para.mtd_consultar_salida_para();
                        if (v_dt.Rows.Count > 0)
                        {
                            rows = v_dt.Rows[0];
                            if (txt_nombre_salida_para.Text == rows["Nombre"].ToString())
                            {
                                errorProvider.SetError(txt_nombre_salida_para, "Salida para ya existe");
                                v_validado++;
                            }
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txt_nombre_salida_para, "Ingrese Salida para");
                        v_validado++;
                    }
                    
                    break;
            }

            if (v_validado == 0)
            {
                frm_msg frm_Msg = new frm_msg();
                switch (tab_Caracteristicas.SelectedTab.Text)
                {
                    case "Unidad medida":
                        cls_Unidad_medida.Nombre = txt_nombre_unidad_medida.Text;
                        v_ok = cls_Unidad_medida.mtd_registrar();
                        if (v_ok == true)
                        {
                            frm_Msg.txt_mensaje.Text = "Unidad de medida registrada";
                            frm_Msg.ShowDialog();
                        }
                        break;
                    case "Categoria":
                        cls_Categoria.Nombre = txt_nombre_categoria.Text;
                        v_ok = cls_Categoria.mtd_registrar();
                        if (v_ok == true)
                        {
                            frm_Msg.txt_mensaje.Text = "Categoria registrada";
                            frm_Msg.ShowDialog();
                        }
                        break;
                    case "Marca":
                        cls_Marca.Nombre = txt_nombre_marca.Text;
                        v_ok = cls_Marca.mtd_registrar();
                        if (v_ok == true)
                        {
                            frm_Msg.txt_mensaje.Text = "Marca registrada";
                            frm_Msg.ShowDialog();
                        }
                        break;
                    case "Ubicacion":
                        cls_Ubicacion.Nombre = txt_nombre_ubicacion.Text;
                        v_ok = cls_Ubicacion.mtd_registrar();
                        if (v_ok == true)
                        {
                            frm_Msg.txt_mensaje.Text = "Ubicacion registrada";
                            frm_Msg.ShowDialog();
                        }
                        break;
                    case "Salida para":
                        cls_Salida_para.Nombre = txt_nombre_salida_para.Text;
                        v_ok = cls_Salida_para.mtd_registrar();
                        if (v_ok == true)
                        {
                            frm_Msg.txt_mensaje.Text = "Salida para registrada";
                            frm_Msg.ShowDialog();
                        }
                        break;
                }
            }
        }
        private void mtd_consultar()
        {
            switch (tab_Caracteristicas.SelectedTab.Text)
            {
                case "Unidad medida":
                    if (txt_buscar_unidad_medida.Text == "Nombre")
                    {
                        cls_Unidad_medida.Nombre = "";
                    }
                    else {
                        cls_Unidad_medida.Nombre = txt_buscar_unidad_medida.Text;
                    }
                        cls_Unidad_medida.v_tipo_busqueda = "Contiene";                    
                        v_dt = cls_Unidad_medida.mtd_consultar_unidad_medida();
                        dtg_unidad_medida.Rows.Clear();
                        if (v_dt.Rows.Count > 0)
                        {
                            v_contador = 0;
                            v_fila = v_dt.Rows.Count;
                            dtg_unidad_medida.Rows.Add(v_fila);
                            foreach (DataRow rows in v_dt.Rows)
                            {     
                                dtg_unidad_medida.Rows[v_contador].Cells["cl_cod_unidad_medida"].Value = rows["Codigo"];
                                dtg_unidad_medida.Rows[v_contador].Cells["cl_unidad_medida"].Value = rows["Nombre"];
                           
                            v_contador++;
                            }
                        }
                   
                    break;
                case "Categoria":
                    if (txt_buscar_categoria.Text == "Nombre")
                    {
                        cls_Categoria.Nombre = "";
                    }
                    else
                    {
                        cls_Categoria.Nombre = txt_buscar_categoria.Text;
                    }
                    cls_Categoria.v_tipo_busqueda = "Contiene";
                    v_dt = cls_Categoria.mtd_consultar_categoria();
                    dtg_categoria.Rows.Clear();
                    if (v_dt.Rows.Count > 0)
                        {
                            v_contador = 0;
                            v_fila = v_dt.Rows.Count;
                        dtg_categoria.Rows.Add(v_fila);
                            foreach (DataRow rows in v_dt.Rows)
                        {
                            dtg_categoria.Rows[v_contador].Cells["cl_cod_categoria"].Value = rows["Codigo"];
                            dtg_categoria.Rows[v_contador].Cells["cl_categoria"].Value = rows["Nombre"];
                            
                                v_contador++;
                            }
                        }
                  
                    break;
                case "Marca":
                    if (txt_buscar_marca.Text == "Nombre")
                    {
                        cls_Marca.Nombre = "";
                    }
                    else
                    {
                        cls_Marca.Nombre = txt_buscar_marca.Text;
                    }
                    cls_Marca.v_tipo_busqueda = "Contiene";
                    v_dt = cls_Marca.mtd_consultar_marca();
                    dtg_marca.Rows.Clear();
                    if (v_dt.Rows.Count > 0)
                    {
                        v_contador = 0;
                        v_fila = v_dt.Rows.Count;
                        dtg_marca.Rows.Add(v_fila);
                        foreach (DataRow rows in v_dt.Rows)
                        {
                            dtg_marca.Rows[v_contador].Cells["cl_cod_marca"].Value = rows["Codigo"];
                            dtg_marca.Rows[v_contador].Cells["cl_marca"].Value = rows["Nombre"];
                            
                            v_contador++;
                        }
                    }

                    break;
                case "Ubicacion":
                    if (txt_buscar_ubicacion.Text == "Nombre")
                    {
                        cls_Ubicacion.Nombre = "";
                    }
                    else
                    {
                        cls_Ubicacion.Nombre = txt_buscar_ubicacion.Text;
                    }
                    cls_Ubicacion.v_tipo_busqueda = "Contiene";
                    v_dt = cls_Ubicacion.mtd_consultar_ubicacion();
                    dtg_ubicacion.Rows.Clear();
                    if (v_dt.Rows.Count > 0)
                    {
                        v_contador = 0;
                        v_fila = v_dt.Rows.Count;
                        dtg_ubicacion.Rows.Add(v_fila);
                        foreach (DataRow rows in v_dt.Rows)
                        {
                            dtg_ubicacion.Rows[v_contador].Cells["cl_cod_ubicacion"].Value = rows["Codigo"];
                            dtg_ubicacion.Rows[v_contador].Cells["cl_ubicacion"].Value = rows["Nombre"];
                          
                            v_contador++;
                        }
                    }

                    break;
                case "Salida para":
                    if (txt_buscar_salida_para.Text == "Nombre")
                    {
                        cls_Salida_para.Nombre = "";
                    }
                    else
                    {
                        cls_Salida_para.Nombre = txt_buscar_salida_para.Text;
                    }
                    cls_Salida_para.v_tipo_busqueda = "Contiene";
                    v_dt = cls_Salida_para.mtd_consultar_salida_para();
                    dtg_salida_para.Rows.Clear();
                    if (v_dt.Rows.Count > 0)
                    {
                        v_contador = 0;
                        v_fila = v_dt.Rows.Count;
                        dtg_salida_para.Rows.Add(v_fila);
                        foreach (DataRow rows in v_dt.Rows)
                        {
                            dtg_salida_para.Rows[v_contador].Cells["cl_cod_salida_para"].Value = rows["Codigo"];
                            dtg_salida_para.Rows[v_contador].Cells["cl_salida_para"].Value = rows["Nombre"];
                           
                            v_contador++;
                        }
                    }

                    break;
            }
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        private void mtd_eliminar()
        {
            Eliminados = 0;
            Error = 0;

            frm_confirmacion frm_Confirmacion = new frm_confirmacion();
            switch (tab_Caracteristicas.SelectedTab.Text)
            {
                case "Unidad medida":
                    if (dtg_unidad_medida.Rows.Count > 0)
                    {
                        if (dtg_unidad_medida.SelectedRows.Count > 0)
                        {
                            frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                            v_contador = dtg_unidad_medida.SelectedRows.Count;
                            frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + "  Unidades de medida?";
                            frm_Confirmacion.ShowDialog();
                            if (v_confirmacion == true)
                            {
                                foreach (DataGridViewRow rows in dtg_unidad_medida.SelectedRows)
                                {
                                    cls_Unidad_medida.Codigo = Convert.ToInt32(rows.Cells["cl_cod_unidad_medida"].Value);
                                    v_ok = cls_Unidad_medida.mtd_eliminar();
                                    if (v_ok)
                                    {
                                        Eliminados++;
                                    }
                                    else
                                    {
                                        Error++;
                                    }
                                }
                                frm_msg frm_Msg = new frm_msg();
                                frm_Msg.pnl_arriba.BackColor = Color.DimGray;
                                frm_Msg.lbl_titulo.Text = "Eliminar";
                                frm_Msg.txt_mensaje.Text = "Eliminados: " + Eliminados + ", Errores: " + Error;
                                frm_Msg.ShowDialog();
                            }
                        }
                    }
                    break;
                case "Categoria":
                    if (dtg_categoria.Rows.Count > 0)
                    {
                        if (dtg_categoria.SelectedRows.Count > 0)
                        { 
                            frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                            v_contador = dtg_categoria.SelectedRows.Count;
                            frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + " Categorias?";
                            frm_Confirmacion.ShowDialog();
                            if (v_confirmacion == true)
                            {
                                foreach (DataGridViewRow rows in dtg_categoria.SelectedRows)
                                {
                                    cls_Categoria.Codigo = Convert.ToInt32(rows.Cells["cl_cod_categoria"].Value);
                                    v_ok = cls_Categoria.mtd_eliminar();
                                    if (v_ok)
                                    {
                                        Eliminados++;
                                    }
                                    else
                                    {
                                        Error++;
                                    }
                                }
                                frm_msg frm_Msg = new frm_msg();
                                frm_Msg.pnl_arriba.BackColor = Color.DimGray;
                                frm_Msg.lbl_titulo.Text = "Eliminar";
                                frm_Msg.txt_mensaje.Text = "Eliminados: " + Eliminados + ", Errores: " + Error;
                                frm_Msg.ShowDialog();
                            }
                        }                     
                    }          
                    break;
                case "Marca":
                    if (dtg_marca.Rows.Count > 0)
                    {
                        if (dtg_marca.SelectedRows.Count > 0)
                        { 
                            frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                            v_contador = dtg_marca.SelectedRows.Count;
                            frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + " Marcas?";
                            frm_Confirmacion.ShowDialog();
                            if (v_confirmacion == true)
                            {
                                foreach (DataGridViewRow rows in dtg_marca.SelectedRows)
                                {
                                    cls_Marca.Codigo = Convert.ToInt32(rows.Cells["cl_cod_marca"].Value);
                                    v_ok = cls_Marca.mtd_eliminar();
                                    if (v_ok)
                                    {
                                        Eliminados++;
                                    }
                                    else
                                    {
                                        Error++;
                                    }
                                }
                                frm_msg frm_Msg = new frm_msg();
                                frm_Msg.pnl_arriba.BackColor = Color.DimGray;
                                frm_Msg.lbl_titulo.Text = "Eliminar";
                                frm_Msg.txt_mensaje.Text = "Eliminados: " + Eliminados + ", Errores: " + Error;
                                frm_Msg.ShowDialog();
                            }
                        }
                    }
                    break;
                case "Ubicacion":
                    if (dtg_ubicacion.Rows.Count > 0)
                    {
                        if (dtg_ubicacion.SelectedRows.Count > 0)
                        {
                            frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                            v_contador = dtg_ubicacion.SelectedRows.Count;
                            frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + " Ubicacion?";
                            frm_Confirmacion.ShowDialog();
                            if (v_confirmacion == true)
                            {
                                foreach (DataGridViewRow rows in dtg_ubicacion.SelectedRows)
                                {
                                    cls_Ubicacion.Codigo = Convert.ToInt32(rows.Cells["cl_cod_ubicacion"].Value);
                                    v_ok = cls_Ubicacion.mtd_eliminar();
                                    if (v_ok)
                                    {
                                        Eliminados++;
                                    }
                                    else
                                    {
                                        Error++;
                                    }
                                }
                                frm_msg frm_Msg = new frm_msg();
                                frm_Msg.pnl_arriba.BackColor = Color.DimGray;
                                frm_Msg.lbl_titulo.Text = "Eliminar";
                                frm_Msg.txt_mensaje.Text = "Eliminados: " + Eliminados + ", Errores: " + Error;
                                frm_Msg.ShowDialog();
                            }
                        }
                    }
                    break;
                case "Salida para":
                    if (dtg_salida_para.Rows.Count > 0)
                    {
                        if (dtg_salida_para.SelectedRows.Count > 0)
                        { 
                            frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                            v_contador = dtg_salida_para.SelectedRows.Count;
                            frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + " salida para?";
                            frm_Confirmacion.ShowDialog();
                            if (v_confirmacion == true)
                            {
                                foreach (DataGridViewRow rows in dtg_salida_para.SelectedRows)
                                {
                                    cls_Salida_para.Codigo = Convert.ToInt32(rows.Cells["cl_cod_salida_para"].Value);
                                    v_ok = cls_Salida_para.mtd_eliminar();
                                    if (v_ok)
                                    {
                                        Eliminados++;
                                    }
                                    else
                                    {
                                        Error++;
                                    }
                                }
                                frm_msg frm_Msg = new frm_msg();
                                frm_Msg.pnl_arriba.BackColor = Color.DimGray;
                                frm_Msg.lbl_titulo.Text = "Eliminar";
                                frm_Msg.txt_mensaje.Text = "Eliminados: " + Eliminados + ", Errores: " + Error;
                                frm_Msg.ShowDialog();
                            }
                        }                       
                    }                 
                    break;
            }
        }

        //Eventos
        private void lbl_minimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void pnl_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void txt_buscar_unidad_medida_Enter(object sender, EventArgs e)
        {
            if (txt_buscar_unidad_medida.Text == "Nombre")
            {
                txt_buscar_unidad_medida.Text = "";
                txt_buscar_unidad_medida.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_unidad_medida_Leave(object sender, EventArgs e)
        {
            if (txt_buscar_unidad_medida.Text == "")
            {
                txt_buscar_unidad_medida.Text = "Nombre";
                txt_buscar_unidad_medida.ForeColor = Color.Silver;
            }
        }
        private void txt_buscar_categoria_Enter(object sender, EventArgs e)
        {
            if (txt_buscar_categoria.Text == "Nombre")
            {
                txt_buscar_categoria.Text = "";
                txt_buscar_categoria.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_categoria_Leave(object sender, EventArgs e)
        {
            if (txt_buscar_categoria.Text == "")
            {
                txt_buscar_categoria.Text = "Nombre";
                txt_buscar_categoria.ForeColor = Color.Silver;
            }
        }
        private void txt_buscar_marca_Enter(object sender, EventArgs e)
        {
            if (txt_buscar_marca.Text == "Nombre")
            {
                txt_buscar_marca.Text = "";
                txt_buscar_marca.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_marca_Leave(object sender, EventArgs e)
        {
            if (txt_buscar_marca.Text == "")
            {
                txt_buscar_marca.Text = "Nombre";
                txt_buscar_marca.ForeColor = Color.Silver;
            }
        }
        private void txt_buscar_ubicacion_Enter(object sender, EventArgs e)
        {
            if (txt_buscar_ubicacion.Text == "Nombre")
            {
                txt_buscar_ubicacion.Text = "";
                txt_buscar_ubicacion.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_ubicacion_Leave(object sender, EventArgs e)
        {
            if (txt_buscar_ubicacion.Text == "")
            {
                txt_buscar_ubicacion.Text = "Nombre";
                txt_buscar_ubicacion.ForeColor = Color.Silver;
            }
        }
        private void txt_buscar_salida_para_Enter(object sender, EventArgs e)
        {
            if (txt_buscar_salida_para.Text == "Nombre")
            {
                txt_buscar_salida_para.Text = "";
                txt_buscar_salida_para.ForeColor = Color.Black;
            }
        }
        private void txt_buscar_salida_para_Leave(object sender, EventArgs e)
        {
            if (txt_buscar_salida_para.Text == "")
            {
                txt_buscar_salida_para.Text = "Nombre";
                txt_buscar_salida_para.ForeColor = Color.Silver;
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            mtd_guardar();
            mtd_consultar();
        }
        private void txt_buscar_unidad_medida_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_consultar();
        }
        private void btn_buscar_unidad_medida_Click(object sender, EventArgs e)
        {
            mtd_consultar();
        }
        private void txt_buscar_categoria_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_consultar();
        }
        private void btn_buscar_categoria_Click(object sender, EventArgs e)
        {
            mtd_consultar();
        }
        private void txt_buscar_marca_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_consultar();
        }
        private void btn_buscar_marca_Click(object sender, EventArgs e)
        {
            mtd_consultar();
        }
        private void txt_buscar_ubicacion_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_consultar();
        }
        private void btn_buscar_ubicacion_Click(object sender, EventArgs e)
        {
            mtd_consultar();
        }
        private void txt_buscar_salida_para_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_consultar();
        }
        private void btn_buscar_salida_para_Click(object sender, EventArgs e)
        {
            mtd_consultar();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            mtd_eliminar();
            mtd_consultar();
        }
        private void tab_Caracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtd_consultar();
        }
    }
}
