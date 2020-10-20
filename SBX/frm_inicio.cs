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
    public partial class frm_inicio : Form
    {
        //instancias
        Form formul = new Form();
        frm_venta frm_Venta;
        frm_producto frm_Producto;
        frm_inventario frm_Inventario;
        MODEL.cls_producto cl_produc = new MODEL.cls_producto();

        //Variables globales
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
      
        DataTable v_dt;
        DataTable v_dt_permisos;
        DataRow rows;
        bool v_confirmacion;
        int Contador = 0;
        int BuscaAutomatica = 0;
        int BuscaPaginado = 0;
       
        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public frm_inicio()
        {
            InitializeComponent();
            timer.Enabled = true;
            timer1.Enabled = false;
        }
        private void frm_inicio_Load(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_fondo_inicio frm_Fondo_inicio = new frm_fondo_inicio();
            ColoresBotones("btn_fondo");
            AbrirFormularioEnPanel(frm_Fondo_inicio);

            lbl_usuario.Text = NombreUsuario + " - " + Nombre;
            //VerificarCaja();
            VerificarPermisos();
           
        }

        //Metodos
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        private void ColoresBotones(string Boton)
        {
            if (Boton != "btn_venta")
            {
                btn_venta.BackColor = Color.Gray;
            }
            if (Boton != "btn_producto")
            {
                btn_producto.BackColor = Color.Gray;
            }
            if (Boton != "btn_inventario")
            {
                btn_inventario.BackColor = Color.Gray;
            }
            if (Boton != "btn_cliente")
            {
                btn_cliente.BackColor = Color.Gray;
            }
            if (Boton != "btn_proveedor")
            {
                btn_proveedor.BackColor = Color.Gray;
            }
            if (Boton != "btn_empresa")
            {
                btn_empresa.BackColor = Color.Gray;
            }
            if (Boton != "btn_domicilio")
            {
                btn_domicilio.BackColor = Color.Gray;
            }
            if (Boton != "btn_separado")
            {
                btn_separado.BackColor = Color.Gray;
            }
            if (Boton != "btn_caja")
            {
                btn_caja.BackColor = Color.Gray;
            }
            if (Boton != "btn_config")
            {
                btn_config.BackColor = Color.Gray;
            }
            if (Boton != "btn_gastos")
            {
                btn_gastos.BackColor = Color.Gray;
            }
            if (Boton != "btn_reportes")
            {
                btn_reportes.BackColor = Color.Gray;
            }
        }
        public void AbrirFormularioEnPanel(object FormularioHijo)
        {
            if (this.pnl_centro.Controls.Count > 0)
                this.pnl_centro.Controls.RemoveAt(0);
            //Form formul;  
            formul = FormularioHijo as Form;
            formul.TopLevel = false;
            formul.Dock = DockStyle.Fill;
            this.pnl_centro.Controls.Add(formul);
            this.pnl_centro.Tag = formul;
            formul.Show();
        }
        private void VerificarCaja()
        {
            frm_confirmacion frm_Confirmacion = new frm_confirmacion();
            cls_caja cls_Caja = new cls_caja();
            cls_Caja.Usuario = Codigo;
            v_dt = cls_Caja.mtd_consultar_caja();
            if (v_dt.Rows.Count > 0)
            {
                rows = v_dt.Rows[0];
                if (rows["TipoOperacion"].ToString() == "CIERRE")
                {
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    frm_Confirmacion.txt_mensaje.Text = "¿Desea realizar apertura de caja?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    {
                        frm_apertura_caja frm_Apertura_caja = new frm_apertura_caja();
                        frm_Apertura_caja.Usuario = Codigo;
                        frm_Apertura_caja.ShowDialog();
                    }
                }
            }
            else
            {
                frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                frm_Confirmacion.txt_mensaje.Text = "¿Desea realizar apertura de caja?";
                frm_Confirmacion.ShowDialog();
                if (v_confirmacion == true)
                {
                    frm_apertura_caja frm_Apertura_caja = new frm_apertura_caja();
                    frm_Apertura_caja.Usuario = Codigo;
                    frm_Apertura_caja.ShowDialog();
                }
            }
        }
        private void VerificarPermisos()
        {
            cls_usuario user = new cls_usuario();
            user.Codigo = Convert.ToInt32(Codigo);
            v_dt_permisos = user.mtd_consultar_permisos_usuario();
            foreach (DataRow rows in v_dt_permisos.Rows)
            {
                switch (rows["Modulo"].ToString())
                {
                    case "VENTA":
                        btn_venta.Visible = true;
                        break;
                    case "PRODUCTO":
                        btn_producto.Visible = true;
                        break;
                    case "INVENTARIO":
                        btn_inventario.Visible = true;
                        break;
                    case "CLIENTE":
                        btn_cliente.Visible = true;
                        break;
                    case "PROVEEDOR":
                        btn_proveedor.Visible = true;
                        break;
                    case "EMPRESA":
                        btn_empresa.Visible = true;
                        break;
                    case "DOMICILIO":
                        btn_domicilio.Visible = true;
                        break;
                    case "SEPARADO":
                        //btn_domicilio.Visible = true;
                        break;
                    case "CAJA":
                        btn_caja.Visible = true;
                        break;
                    case "GASTOS":
                        btn_gastos.Visible = true;
                        break;
                    case "REPORTES":
                        btn_reportes.Visible = true;
                        break;
                    case "AJUSTES":
                        btn_config.Visible = true;
                        break;
                }
            }
        }
      
        //Eventos 
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frm_confirmacion frm_Confirmacion = new frm_confirmacion();
            frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
            frm_Confirmacion.txt_mensaje.Text = "¿Está seguro que desea salir?";
            frm_Confirmacion.ShowDialog();
            if (v_confirmacion == true)
            {
                frm_login frm_Login = new frm_login();
                frm_Login.Show();
                this.Hide();
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
        private void btn_venta_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (frm_Venta == null || frm_Venta.IsDisposed)
            {
                frm_Venta = new frm_venta();
                frm_Venta.Usuario = Codigo;
                frm_Venta.v_dt_Permi = v_dt_permisos;
                frm_Venta.Show();
            }
            else
            {
                frm_Venta.BringToFront();
                frm_Venta.WindowState = FormWindowState.Normal;
            }
            this.Cursor = Cursors.Default;
            //formul.Dispose();
            //frm_venta frm_Venta = new frm_venta();
            //frm_Venta.Usuario = Codigo;
            //frm_Venta.v_dt_Permi = v_dt_permisos;
            //frm_Venta.Show();
            //ColoresBotones("btn_venta");
            //AbrirFormularioEnPanel(frm_Venta);
            //btn_venta.BackColor = Color.DarkSeaGreen;
        }
        private void btn_producto_Click(object sender, EventArgs e)
        {
            
            this.Cursor = Cursors.WaitCursor;
             BuscaAutomatica = 0;
             BuscaPaginado = 0;
            //verifica Parametros
            cls_parametros cls_Parametros = new cls_parametros();
            v_dt = cls_Parametros.mtd_consultar_parametros();
            foreach (DataRow item in v_dt.Rows)
            {
                if (item["Buscar_automaticamente"].ToString() == "SI")
                {
                    BuscaAutomatica = 1;
                }
                if (item["Datos_paginados"].ToString() == "SI")
                {
                    BuscaPaginado = 1;
                }
            }

            if (frm_Producto == null || frm_Producto.IsDisposed)
            {
                frm_Producto = new frm_producto();               
                frm_Producto.v_dt_Permi = v_dt_permisos;
                frm_Producto.BuscaAutomaticamente = BuscaAutomatica;
                frm_Producto.BuscaPaginados = BuscaPaginado;
                frm_Producto.Show();
            }
            else
            {
                frm_Producto.BringToFront();
                frm_Producto.WindowState = FormWindowState.Normal;
            }
            this.Cursor = Cursors.Default;
            //formul.Dispose();
            //frm_producto frm_Producto = new frm_producto();
            //frm_Producto.v_dt_Permi = v_dt_permisos;
            //ColoresBotones("btn_producto");
            //AbrirFormularioEnPanel(frm_Producto);
            //btn_producto.BackColor = Color.DarkSeaGreen;
        }
        private void btn_inventario_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (frm_Inventario == null || frm_Inventario.IsDisposed)
            {
                frm_Inventario = new frm_inventario();
                frm_Inventario.Usuario = Codigo;
                frm_Inventario.v_dt_Permi = v_dt_permisos;
                frm_Inventario.Show();
            }
            else
            {
                frm_Inventario.BringToFront();
                frm_Inventario.WindowState = FormWindowState.Normal;
            }
            this.Cursor = Cursors.Default;
            //formul.Dispose();
            //frm_inventario frm_Inventario = new frm_inventario();
            //frm_Inventario.Usuario = Codigo;
            //frm_Inventario.v_dt_Permi = v_dt_permisos;
            //ColoresBotones("btn_inventario");
            //AbrirFormularioEnPanel(frm_Inventario);
            //btn_inventario.BackColor = Color.DarkSeaGreen;
        }
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_cliente frm_Cliente = new frm_cliente();
            frm_Cliente.v_dt_Permi = v_dt_permisos;
            ColoresBotones("btn_cliente");
            AbrirFormularioEnPanel(frm_Cliente);
            btn_cliente.BackColor = Color.DarkSeaGreen;
        }
        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_proveedor frm_Proveedor = new frm_proveedor();
            frm_Proveedor.v_dt_Permi = v_dt_permisos;
            ColoresBotones("btn_proveedor");
            AbrirFormularioEnPanel(frm_Proveedor);
            btn_proveedor.BackColor = Color.DarkSeaGreen;
        }
        private void btn_empresa_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_empresa frm_Empresa = new frm_empresa();
            frm_Empresa.v_dt_Permi = v_dt_permisos;
            ColoresBotones("btn_empresa");
            AbrirFormularioEnPanel(frm_Empresa);
            btn_empresa.BackColor = Color.DarkSeaGreen;
        }
        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Restaurar.Visible = false;
            btn_Maximizar.Visible = true;
            int size = pnl_centro.Size.Width;
        }
        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Restaurar.Visible = true;
            btn_Maximizar.Visible = false;
            int size = pnl_centro.Size.Width;
        }
        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_domicilios frm_Domicilio = new frm_domicilios();
            frm_Domicilio.v_dt_Permi = v_dt_permisos;
            ColoresBotones("btn_domicilio");
            AbrirFormularioEnPanel(frm_Domicilio);
            btn_domicilio.BackColor = Color.DarkSeaGreen;
        }
        private void pnl_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btn_separado_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_separados frm_Separados = new frm_separados();
            ColoresBotones("btn_separado");
            AbrirFormularioEnPanel(frm_Separados);
            btn_separado.BackColor = Color.DarkSeaGreen;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_fondo_inicio frm_Fondo_inicio = new frm_fondo_inicio();
            ColoresBotones("btn_fondo");
            AbrirFormularioEnPanel(frm_Fondo_inicio);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_fondo_inicio frm_Fondo_inicio = new frm_fondo_inicio();
            ColoresBotones("btn_fondo");
            AbrirFormularioEnPanel(frm_Fondo_inicio);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_fecha_hora.Text = DateTime.Now.ToString();    
        }
        private void btn_config_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_configuracion frm_Configuracion = new frm_configuracion();
            frm_Configuracion.Codigo = Codigo;
            ColoresBotones("btn_config");
            AbrirFormularioEnPanel(frm_Configuracion);
            btn_config.BackColor = Color.DarkSeaGreen;
        }
        private void btn_caja_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_caja frm_Caja = new frm_caja();
            frm_Caja.v_dt_Permi = v_dt_permisos;
            frm_Caja.Codigo = Codigo;
            ColoresBotones("btn_caja");
            AbrirFormularioEnPanel(frm_Caja);
            btn_caja.BackColor = Color.DarkSeaGreen;
        }
        private void btn_gastos_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_gastos frm_gastos = new frm_gastos();
            frm_gastos.v_dt_Permi = v_dt_permisos;
            frm_gastos.Codigo = Codigo;
            ColoresBotones("btn_gastos");
            AbrirFormularioEnPanel(frm_gastos);
            btn_gastos.BackColor = Color.DarkSeaGreen;
        }
        private void btn_reportes_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_Informe frm_Informe = new frm_Informe();
            frm_Informe.v_dt_Permi = v_dt_permisos;
            frm_Informe.Codigo = Codigo;
            ColoresBotones("btn_reportes");
            AbrirFormularioEnPanel(frm_Informe);
            btn_reportes.BackColor = Color.DarkSeaGreen;
        }
        private void Btn_alarma_Click(object sender, EventArgs e)
        {
            frm_Alertas fr_aler = new frm_Alertas();
            fr_aler.Show();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Verificar alertas
            Contador = 0;
            v_dt = cl_produc.mtd_consultar_Fechas_vence();
            foreach (DataRow rows in v_dt.Rows)
            {
                if (rows["Estado"].ToString() != "")
                {
                    Contador++;
                }
            }
            v_dt = cl_produc.mtd_consultar_producto_stocks();
            foreach (DataRow rows in v_dt.Rows)
            {
                if (rows["Alerta_Stock_minimo"].ToString() != "" || rows["Alerta_Stock_Maximo"].ToString() != "" || rows["Alerta_stock_agotado"].ToString() != "")
                {
                    Contador++;
                }
            }

            lbl_noti.Text = Contador.ToString();

            if (Contador == 0)
            {
                lbl_noti.Visible = false;
            }
            else
            {
                lbl_noti.Visible = true;
            }
        }

        private void frm_inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_confirmacion frm_Confirmacion = new frm_confirmacion();
            frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
            frm_Confirmacion.txt_mensaje.Text = "¿Está seguro que desea salir?";
            frm_Confirmacion.ShowDialog();
            if (v_confirmacion == true)
            {
                frm_login frm_Login = new frm_login();
                frm_Login.Show();
                this.Hide();
            }
        }
    }
}
