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
    public partial class frm_caja : Form
    {
        cls_caja cls_Caja = new cls_caja();
        DataTable v_dt;
        int Contador = 0;
        int Fila = 0;
        public string Codigo { get; set; }
        DataRow rows;
        bool v_confirmacion;
        public DataTable v_dt_Permi { get; set; }

        public frm_caja()
        {
            InitializeComponent();
        }
        private void frm_caja_Load(object sender, EventArgs e)
        {
            MensajeInformativoBotones();
            cbx_tipo_busqueda.SelectedIndex = 0;
        }

        //Metodos
        private void mtd_Cargar()
        {
            if (txt_buscar.Text == "Usuario")
            {
                cls_Caja.Usuario = "";
            }
            else
            {
                cls_Caja.Usuario = txt_buscar.Text;
            }
            cls_Caja.FechaInicio = dtp_fecha_inicio.Value;
            cls_Caja.FechaFin = dtp_fecha_fin.Value;
            cls_Caja.ModoBusqueda = cbx_tipo_busqueda.Text;
            v_dt = cls_Caja.mtd_consultar_todo_caja();
            dtg_caja.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                Contador = 0;
                Fila = v_dt.Rows.Count;
                dtg_caja.Rows.Add(Fila);
                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_caja.Rows[Contador].Cells["cl_codigo_Caja"].Value = rows["CodigoCaja"];
                    dtg_caja.Rows[Contador].Cells["cl_usuario"].Value = rows["NombreUsuario"];
                    dtg_caja.Rows[Contador].Cells["cl_fecha"].Value = rows["FechaRegistro"];
                    dtg_caja.Rows[Contador].Cells["cl_operacion"].Value = rows["TipoOperacion"];
                    double valor = Convert.ToDouble(rows["Valor"]);
                    dtg_caja.Rows[Contador].Cells["cl_valor"].Value = valor.ToString("N0");
                    dtg_caja.Rows[Contador].Cells["cl_codigo_operacion"].Value = rows["Codigo"];
                    Contador++;
                }
            }
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }
        public void MensajeInformativoBotones()
        {
            ToolTip Botones = new ToolTip();

            Botones.SetToolTip(btn_buscar, "Buscar");
            Botones.SetToolTip(btn_cierre_caja, "Cierre caja");
            Botones.SetToolTip(btn_apertura_caja, "Apertura caja");
            Botones.SetToolTip(btn_imprimir, "Imprimir"); 
        }

        //eventos
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
            mtd_Cargar();
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_Cargar();
        }
        private void btn_apertura_caja_Click(object sender, EventArgs e)
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
                else
                {
                    frm_msg frm_Msg = new frm_msg();
                    frm_Msg.txt_mensaje.Text = "Se debe Cerrar caja primero";
                    frm_Msg.lbl_titulo.Text = "ERROR";
                    frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                    frm_Msg.ShowDialog();
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
        private void btn_cierre_caja_Click(object sender, EventArgs e)
        {           
            frm_confirmacion frm_Confirmacion;
            cls_caja cls_Caja = new cls_caja();
            v_confirmacion = true;

            //Verificar domicilios Pendientes
            v_dt = cls_Caja.mtd_conteo_domicilios_pendientes();
            rows = v_dt.Rows[0];
            if (Convert.ToDouble(rows["Conteo"]) > 0)
            {
                frm_msg frm_Msg = new frm_msg();
                frm_Msg.txt_mensaje.Text = "Hay " + rows["Conteo"] + " domicilios Pendientes";
                frm_Msg.lbl_titulo.Text = "ERROR";
                frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                frm_Msg.ShowDialog();
                v_confirmacion = false;
            }
            if (v_confirmacion == true)
            {
                cls_Caja.Usuario = Codigo;
                v_dt = cls_Caja.mtd_consultar_caja();
                if (v_dt.Rows.Count > 0)
                {
                    rows = v_dt.Rows[0];
                    if (rows["TipoOperacion"].ToString() == "APERTURA")
                    {
                        frm_Confirmacion = new frm_confirmacion();
                        frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                        frm_Confirmacion.txt_mensaje.Text = "¿Desea realizar Cierre de caja?";
                        frm_Confirmacion.ShowDialog();
                        if (v_confirmacion == true)
                        {
                            frm_cierre_caja frm_Cierre_caja = new frm_cierre_caja();
                            frm_Cierre_caja.Usuario = Codigo;
                            frm_Cierre_caja.ShowDialog();
                        }
                    }
                    else
                    {
                        frm_msg frm_Msg = new frm_msg();
                        frm_Msg.txt_mensaje.Text = "Se debe abrir caja primero";
                        frm_Msg.lbl_titulo.Text = "ERROR";
                        frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                        frm_Msg.ShowDialog();
                    }
                }
                else
                {
                    frm_msg frm_Msg = new frm_msg();
                    frm_Msg.txt_mensaje.Text = "Se debe abrir caja primero";
                    frm_Msg.lbl_titulo.Text = "ERROR";
                    frm_Msg.pnl_arriba.BackColor = Color.OrangeRed;
                    frm_Msg.ShowDialog();
                }
            }                         
        }

        private void mtd_imprimir()
        {
            int CodigoCierre = 0;
            int Imprime = 0;
            if (dtg_caja.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtg_caja.SelectedRows)
                {
                    if (row.Cells["cl_operacion"].Value.ToString() == "CIERRE")
                    {
                        CodigoCierre = Convert.ToInt32(row.Cells["cl_codigo_operacion"].Value);
                        Imprime = 1;
                    }
                }

                if (Imprime == 1)
                {
                    cls_Caja.Codigo = CodigoCierre;
                    v_dt = cls_Caja.mtd_consultar_Cierre_caja();
                    if (v_dt.Rows.Count > 0)
                    {
                        rows = v_dt.Rows[0];

                        //CrearTicket ticket = new CrearTicket();
                        //cls_empresa Empres = new cls_empresa();

                        double TConteoDinero = 0;
                        TConteoDinero = Convert.ToDouble(rows["ConteoDinero"]);
                        //Armar informe cierre de caja

                        //DataRow row;
                        //DataTable DTEmpresa;
                        //DTEmpresa = Empres.mtd_consultar_Empresa();
                        //row = DTEmpresa.Rows[0];
                        //string NombreImpresora = row["Impresora"].ToString();
                        //string NumerosCelular = row["Celular"].ToString();
                        ////Datos de la cabecera del Ticket.
                        //ticket.TextoCentro(row["Nombre"].ToString());
                        //ticket.TextoCentro("NIT:" + row["DNI"]);
                        //ticket.TextoIzquierda("DIREC: " + row["Direccion"] + "");
                        //ticket.TextoIzquierda("TELEF: " + row["Telefono"] + "");
                        //ticket.TextoIzquierda("CELUL: " + row["Celular"] + "");
                        //ticket.TextoIzquierda("EMAIL: " + row["Email"] + "");
                        //ticket.TextoIzquierda("WEB: " + row["SitioWeb"] + "");
                        //ticket.TextoIzquierda("FECHA: " + DateTime.Now.ToShortDateString() + "");
                        //ticket.TextoIzquierda("HORA: " + DateTime.Now.ToShortTimeString());
                        //ticket.TextoIzquierda("");

                        //Informe cierre de caja
                        //ticket.TextoIzquierda("T.Billetes: " + TBilletes.ToString("N2") + "");
                        //ticket.TextoIzquierda("T.Monedas: " + TMonedas.ToString("N2") + "");
                        //ticket.TextoIzquierda("T.Baucher: " + TBaucher.ToString("N2") + "");
                        //ticket.TextoIzquierda("T.Caja: " + TCaja.ToString("N2") + "");
                        //ticket.TextoIzquierda("");

                        double TotalBaseCaja = Convert.ToDouble(rows["BaseCaja"]);
                        double Ingresos = Convert.ToDouble(rows["Ingresos"]);
                        double Gastos = Convert.ToDouble(rows["Gastos"]);
                        double CierreCaja = Convert.ToDouble(rows["CierreCaja"]);
                        double ConteoDinero = Convert.ToDouble(rows["ConteoDinero"]);
                        double TotalDiferencia = Convert.ToDouble(rows["TotalDiferencia"]);

                        //ticket.TextoIzquierda("Base: " + TotalBaseCaja.ToString("N2") + "");
                        //ticket.TextoIzquierda("T.Ventas: " + TotalVentas.ToString("N2") + "");
                        //ticket.TextoIzquierda("");
                        //ticket.TextoIzquierda("Diferencia: " + TotalDiferencia.ToString("N2") + "");

                        //Informacion cierre.
                        //ticket.lineasAsteriscos();
                        //ticket.TextoIzquierda("APERTURA CAJA:");
                        //ticket.TextoIzquierda("" + TotalBaseCaja.ToString("N2") + "");
                        //ticket.lineasAsteriscos();
                        //ticket.TextoIzquierda("");
                        //ticket.lineasAsteriscos();
                        //ticket.TextoIzquierda("INGRESOS:");
                        //ticket.TextoIzquierda("" + Ingresos.ToString("N2") + "");
                        //ticket.lineasAsteriscos();
                        //ticket.TextoIzquierda("");
                        //ticket.lineasAsteriscos();
                        //ticket.TextoIzquierda("GASTOS:");
                        //ticket.TextoIzquierda("" + Gastos.ToString("N2") + "");
                        //ticket.lineasAsteriscos();
                        //ticket.TextoIzquierda("");
                        //ticket.lineasAsteriscos();
                        //ticket.TextoIzquierda("CIERRE CAJA:");
                        //ticket.TextoIzquierda("" + CierreCaja.ToString("N2") + "");
                        //ticket.lineasAsteriscos();
                        //ticket.TextoIzquierda("");
                        //ticket.lineasAsteriscos();
                        //ticket.TextoIzquierda("CONTEO DINERO:");
                        //ticket.TextoIzquierda("" + ConteoDinero.ToString("N2") + "");
                        //ticket.lineasAsteriscos();
                        //ticket.TextoIzquierda("");
                        //ticket.lineasAsteriscos();
                        //ticket.TextoIzquierda("DIFERENCIA:");
                        //ticket.TextoIzquierda("" + TotalDiferencia.ToString("N2") + "");
                        //ticket.lineasAsteriscos();
                       
                        //ticket.CortaTicket();

                        //ticket.ImprimirTicketCaja(NombreImpresora);//Nombre de la impresora ticketera

                        //mostrar informacion de cierre de caja
                        frm_informe_cierre cierreCaja = new frm_informe_cierre();
                        cierreCaja.txt_apertura.Text = TotalBaseCaja.ToString("N0");
                        cierreCaja.txt_ingresos.Text = Ingresos.ToString("N0");
                        cierreCaja.txt_gastos.Text = Gastos.ToString("N0");
                        cierreCaja.txt_cierre_caja.Text = CierreCaja.ToString("N0");
                        cierreCaja.txt_conteo_dinero.Text = ConteoDinero.ToString("N0");
                        cierreCaja.txt_diferencia.Text = TotalDiferencia.ToString("N0");
                        cierreCaja.Impresion = false;
                        cierreCaja.ShowDialog();
                    }
                }
                else
                {
                    frm_msg msg = new frm_msg();
                    msg.lbl_titulo.Text = "ERROR";
                    msg.pnl_arriba.BackColor = Color.OrangeRed;
                    msg.txt_mensaje.Text = "Operacion debe ser CIERRE";
                    msg.ShowDialog();
                }
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            mtd_imprimir();
        }
    }
}

