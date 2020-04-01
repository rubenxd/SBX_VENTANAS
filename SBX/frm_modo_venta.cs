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
    public partial class frm_modo_venta : Form
    {
        //Delegado
        public delegate void EnviarInfo(string um);
        public event EnviarInfo Enviainfo;

        public string v_modo_venta { get; set; }
        public string UM { get; set; }

        public frm_modo_venta()
        {
            InitializeComponent();
        }

        //Metodos
        private void mtd_cargar_modo_venta()
        {
            switch (v_modo_venta)
            {
                case "Pesaje":
                    cbx_modo_venta.Items.Add(UM);
                    cbx_modo_venta.Items.Add("Bulto");
                    cbx_modo_venta.Text = UM;
                    break;
                case "Multi":
                    cbx_modo_venta.Items.Add("UND P");
                    cbx_modo_venta.Items.Add("Sobre");
                    cbx_modo_venta.Items.Add("Caja");
                    cbx_modo_venta.Text = "UND P";
                    break;
                case "Desechable":
                    cbx_modo_venta.Items.Add("UND D");
                    cbx_modo_venta.Items.Add("Bolsa");
                    cbx_modo_venta.Text = "UND D";
                    break;
            }
        }

       //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Enviainfo("");
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Enviainfo(cbx_modo_venta.Text);
            this.Dispose();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Enviainfo("");
        }
        private void frm_modo_venta_Load(object sender, EventArgs e)
        {
            mtd_cargar_modo_venta();
        }
    }
}
