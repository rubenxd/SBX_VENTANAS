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
using System.IO;

namespace SBX
{
    public partial class frm_empresa : Form
    {
        cls_global cls_Global = new cls_global();
        cls_empresa cls_Empresa = new cls_empresa();

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Variables globales
        int v_contador = 0;
        DataTable v_dt;
        int v_validado = 0;
        bool v_ok = true;
        bool v_registro = false;
        bool v_confirmacion;
        public DataTable v_dt_Permi { get; set; }

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_empresa));

        public frm_empresa()
        {
            InitializeComponent();
            mtd_mensajeInformativoBotones();
        }
        private void frm_empresa_Load(object sender, EventArgs e)
        {
            mtd_Cargar_empresa();
            foreach (DataRow rows in v_dt_Permi.Rows)
            {
                if (rows["Modulo"].ToString() == "EMPRESA")
                {
                    switch (rows["Permiso"].ToString())
                    {
                        case "guardar":
                            btn_guardar.Enabled = true;
                            break;
                        case "limpiar":
                            btn_limpiar.Enabled = true;
                            break;
                    }
                }
            }
        }

        //Metodos
        public void mtd_mensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_guardar, "Guardar");
            Botones.SetToolTip(btn_limpiar, "Limpiar");
            Botones.SetToolTip(btn_foto, "Agregar foto");
        }
        private void mtd_cargar_foto()
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pbx_foto.Image = Image.FromFile(dialog.FileName);
            }
        }
        private void mtd_limpiar()
        {
            errorProvider.Clear();
            txt_dni.Text = "";
            txt_digito_verificacion.Text = "";
            txt_nombre.Text = "";
            txt_ciudad.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_celular.Text = "";
            txt_email.Text = "";
            txt_sitio_web.Text = "";
            v_registro = false;
            txt_licencia.Text = "";
            txt_impresora.Text = "";
            txt_conInicial.Text = "";
            txt_conFinal.Text = "";
            txt_detalle.Text = "";
            txt_alerta.Text = "";
            pbx_foto.Image = ((System.Drawing.Image)(resources.GetObject("pbx_foto.Image")));
            txt_nom_doc.Text = "";
            txt_tamano_papel.Text = "";
        }
        private void Validar()
        {
            v_validado = 0;
            errorProvider.Clear();

            if (txt_dni.Text == "")
            {
                errorProvider.SetError(txt_dni, "Ingrese DNI");
                v_validado++;
            }
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
            if (txt_nom_doc.Text == "")
            {
                errorProvider.SetError(txt_nom_doc, "Ingrese Nombre documento");
                v_validado++;
            }
            if (!cls_Global.IsNumericDouble(txt_conInicial.Text))
            {
                errorProvider.SetError(txt_conInicial, "Ingrese Ingrese consecutivo inicial");
                v_validado++;
            }
            if (!cls_Global.IsNumericDouble(txt_conFinal.Text))
            {
                errorProvider.SetError(txt_conFinal, "Ingrese Ingrese consecutivo Final");
                v_validado++;
            }
            if (txt_Nom_Doc_ctz.Text == "")
            {
                errorProvider.SetError(txt_Nom_Doc_ctz, "Ingrese Nombre documento Cotizacion");
                v_validado++;
            }
            if (txt_Nom_Doc_ords.Text == "")
            {
                errorProvider.SetError(txt_Nom_Doc_ords, "Ingrese Nombre documento Orden servicio");
                v_validado++;
            }
        }
        public string CalcularDigitoVerificacion(string Nit)
        {
            string Temp;
            int Contador;
            int Residuo;
            int Acumulador;
            int[] Vector = new int[15];

            Vector[0] = 3;
            Vector[1] = 7;
            Vector[2] = 13;
            Vector[3] = 17;
            Vector[4] = 19;
            Vector[5] = 23;
            Vector[6] = 29;
            Vector[7] = 37;
            Vector[8] = 41;
            Vector[9] = 43;
            Vector[10] = 47;
            Vector[11] = 53;
            Vector[12] = 59;
            Vector[13] = 67;
            Vector[14] = 71;

            Acumulador = 0;

            Residuo = 0;

            for (Contador = 0; Contador < Nit.Length; Contador++)
            {
                Temp = Nit[(Nit.Length - 1) - Contador].ToString();
                Acumulador = Acumulador + (Convert.ToInt32(Temp) * Vector[Contador]);
            }

            Residuo = Acumulador % 11;

            if (Residuo > 1)
                return Convert.ToString(11 - Residuo);

            return Residuo.ToString();
        }
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void mtd_Cargar_empresa()
        {
            v_dt = cls_Empresa.mtd_consultar_Empresa();
            if (v_dt.Rows.Count > 0)
            {
                foreach (DataRow rows in v_dt.Rows)
                {
                    lbl_codigo.Text = rows["Codigo"].ToString();
                    txt_dni.Text = rows["DNI"].ToString();
                    txt_nombre.Text = rows["Nombre"].ToString();
                    txt_ciudad.Text = rows["ciudad"].ToString();
                    txt_direccion.Text = rows["Direccion"].ToString();
                    txt_telefono.Text = rows["Telefono"].ToString();
                    txt_celular.Text = rows["Celular"].ToString();
                    txt_email.Text = rows["Email"].ToString();
                    txt_sitio_web.Text = rows["SitioWeb"].ToString();
                    txt_licencia.Text = rows["Licencia"].ToString();
                    txt_impresora.Text = rows["Impresora"].ToString();
                    txt_conInicial.Text = rows["ConsecutivoInicial"].ToString();
                    txt_conFinal.Text = rows["ConsecutivoFinal"].ToString();
                    txt_detalle.Text = rows["Detalle"].ToString();
                    txt_alerta.Text = rows["Alerta"].ToString();
                    txt_consecutivo_actual.Text = rows["ConsecutivoActual"].ToString();
                    txt_cons_Actual_ctz.Text = rows["ConsecutivoActualCTZ"].ToString();
                    txt_cons_Actual_ords.Text = rows["ConsecutivoActualOrds"].ToString();
                    txt_nom_doc.Text = rows["NomDoc"].ToString();
                    txt_Nom_Doc_ctz.Text = rows["NomDocCtz"].ToString();
                    txt_Nom_Doc_ords.Text = rows["NomDocOrds"].ToString();
                    if (!string.IsNullOrEmpty(rows["Foto"].ToString()))
                    {
                        if (rows["Foto"].ToString() != "System.Byte[]")
                        {
                            byte[] imagen = (byte[])rows["Foto"];
                            pbx_foto.Image = byteArrayToImage(imagen);
                        }  
                    }
                   txt_tamano_papel.Text = rows["tamano_papel"].ToString(); 
                    v_contador++;
                }
                txt_digito_verificacion.Text = CalcularDigitoVerificacion(txt_dni.Text);
            }
            v_registro = false;
        }
        private void mtd_guardar()
        {
            if (txt_dni.Text.Trim() == "0")
            {
                errorProvider.SetError(txt_dni, "DNI ya existe");
                v_validado++;
            }
            else
            {
                v_dt = cls_Empresa.mtd_consultar_Empresa();
                if (v_dt.Rows.Count > 0)
                {
                    errorProvider.SetError(txt_dni, "DNI ya existe");
                    v_validado++;
                }
            }

            if (v_validado == 0)
            {
                cls_Empresa.DNI = txt_dni.Text;
                cls_Empresa.Nombre = txt_nombre.Text;
                cls_Empresa.Ciudad = txt_ciudad.Text;
                cls_Empresa.Direccion = txt_direccion.Text;
                cls_Empresa.Telefono = txt_telefono.Text;
                cls_Empresa.Celular = txt_celular.Text;
                cls_Empresa.Email = txt_email.Text;
                cls_Empresa.Sitioweb = txt_sitio_web.Text;
                cls_Empresa.Licencia = txt_licencia.Text;
                cls_Empresa.Impresora = txt_impresora.Text;
                if (txt_conInicial.Text.Trim() == "")
                {
                    txt_conInicial.Text = "0";
                }
                cls_Empresa.ConInicial = float.Parse(txt_conInicial.Text);
                if (txt_conFinal.Text.Trim() == "")
                {
                    txt_conFinal.Text = "0";
                }
                cls_Empresa.ConFinal = float.Parse(txt_conFinal.Text);
                cls_Empresa.Detalle = txt_detalle.Text;
                if (txt_alerta.Text.Trim() == "")
                {
                    txt_alerta.Text = "0";
                }
                cls_Empresa.Alerta = Convert.ToInt32(txt_alerta.Text);
                cls_Empresa.Foto = pbx_foto.Image;
                cls_Empresa.NomDoc = txt_nom_doc.Text;
                cls_Empresa.tamano_papel = txt_tamano_papel.Text;
                cls_Empresa.NomDocCtz = txt_Nom_Doc_ctz.Text;
                cls_Empresa.NomDocOrds = txt_Nom_Doc_ords.Text;
                v_ok = cls_Empresa.mtd_registrar();

                frm_msg frm_Msg = new frm_msg();
                if (v_ok == true)
                {
                    frm_Msg.txt_mensaje.Text = "Empresa registrada correctamente";
                    frm_Msg.ShowDialog();
                    mtd_Cargar_empresa();
                    v_registro = false;
                    lbl_codigo.Text = "";
                    txt_dni.Focus();
                }
            }
        }
        private void mtd_editar()
        {
                cls_Empresa.Codigo = Convert.ToInt32(lbl_codigo.Text);
                cls_Empresa.DNI = txt_dni.Text;
                cls_Empresa.Nombre = txt_nombre.Text;
                cls_Empresa.Ciudad = txt_ciudad.Text;
                cls_Empresa.Direccion = txt_direccion.Text;
                cls_Empresa.Telefono = txt_telefono.Text;
                cls_Empresa.Celular = txt_celular.Text;
                cls_Empresa.Email = txt_email.Text;
                cls_Empresa.Sitioweb = txt_sitio_web.Text;
                cls_Empresa.Licencia = txt_licencia.Text;
                cls_Empresa.Impresora = txt_impresora.Text;
                if (txt_conInicial.Text.Trim() == "")
                {
                    txt_conInicial.Text = "0";
                }
                cls_Empresa.ConInicial = float.Parse(txt_conInicial.Text);
                if (txt_conFinal.Text.Trim() == "")
                {
                    txt_conFinal.Text = "0";
                }
                cls_Empresa.ConFinal = float.Parse(txt_conFinal.Text);
                cls_Empresa.Detalle = txt_detalle.Text;
                if (txt_alerta.Text.Trim() == "")
                {
                    txt_alerta.Text = "0";
                }
                cls_Empresa.Alerta = Convert.ToInt32(txt_alerta.Text);
                cls_Empresa.Foto = pbx_foto.Image;
            cls_Empresa.NomDoc = txt_nom_doc.Text;
            cls_Empresa.NomDocCtz = txt_Nom_Doc_ctz.Text;
            cls_Empresa.tamano_papel = txt_tamano_papel.Text;
            cls_Empresa.NomDocOrds = txt_Nom_Doc_ords.Text;
            v_ok = cls_Empresa.mtd_Editar();
               
                frm_msg frm_Msg = new frm_msg();
                if (v_ok == true)
                {
                    frm_Msg.txt_mensaje.Text = "Empresa Editada correctamente";
                    frm_Msg.ShowDialog();
                    mtd_Cargar_empresa();
                    v_registro = false;
                    txt_dni.Focus();
                }
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }

        //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void lbl_minimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void btn_foto_Click(object sender, EventArgs e)
        {
            mtd_cargar_foto();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            mtd_limpiar();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
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
        private void txt_conInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_conFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_Global.ValidaNumeros(e);
        }
        private void txt_dni_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_dni.Text != "")
            {
                CalcularDigitoVerificacion(txt_dni.Text);
                txt_digito_verificacion.Text = CalcularDigitoVerificacion(txt_dni.Text);
            }
            else
            {
                txt_digito_verificacion.Text = "";
            }
        }
    }
}
