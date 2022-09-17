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
    public partial class frm_ganancias_y_perdidas : Form
    {
        cls_ganancias_perdidas cls_Ganancias_Perdidas = new cls_ganancias_perdidas();
        DataTable dt = new DataTable();
        double cantidad = 0;
        double tCosto = 0;
        double tPrecioVenta = 0;
        double Resultado = 0;
        public frm_ganancias_y_perdidas()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            cls_Ganancias_Perdidas.FechaIni = dtp_fecha_inicio.Value;
            cls_Ganancias_Perdidas.FechaFin = dtp_fecha_fin.Value;
            cls_Ganancias_Perdidas.Buscar = txt_buscar.Text;
            dt = cls_Ganancias_Perdidas.mtd_consultar_ganancias_y_perdidas();
            dtg_informe.DataSource = dt;
            cantidad = 0;
            tCosto = 0;
            tPrecioVenta = 0;
            Resultado = 0;
            foreach (DataRow item in dt.Rows)
            {
                cantidad += Convert.ToDouble(item["cantidad"]);
                tCosto += Convert.ToDouble(item["Tcosto"]);
                tPrecioVenta += Convert.ToDouble(item["TPrecioVenta"]);
                Resultado += Convert.ToDouble(item["Resultado"]);
            }
            txt_cantidad.Text = cantidad.ToString();
            txt_costo.Text = tCosto.ToString("N0");
            txt_venta.Text = tPrecioVenta.ToString("N0");
            txt_resultado.Text = Resultado.ToString("N0");
        }

        private void frm_ganancias_y_perdidas_Load(object sender, EventArgs e)
        {

        }
    }
}
