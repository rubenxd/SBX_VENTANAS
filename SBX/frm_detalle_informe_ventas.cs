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
    public partial class frm_detalle_informe_ventas : Form
    {
        public DataTable v_dt_detalle { get; set; }
        int Contador = 0;
        int Filas = 0;
        public frm_detalle_informe_ventas()
        {
            InitializeComponent();
        }

        private void frm_detalle_informe_ventas_Load(object sender, EventArgs e)
        {
            //Cargar detalles
            dtg_informe.Rows.Clear();
            Filas = v_dt_detalle.Rows.Count;
            if (v_dt_detalle.Rows.Count > 0)
            {
                dtg_informe.Rows.Add(Filas);
                foreach (DataRow rows in v_dt_detalle.Rows)
                {
                    if (rows["Estado_sistema_separado"].ToString() != "Pendiente" && rows["Estado_Domicilio"].ToString() != "Pendiente")
                    {
                        dtg_informe.Rows[Contador].Cells["cl_factura"].Value = rows["Factura"];
                        dtg_informe.Rows[Contador].Cells["cl_usuario"].Value = rows["NombreUsuario"];
                        dtg_informe.Rows[Contador].Cells["cl_item"].Value = rows["Item"];
                        dtg_informe.Rows[Contador].Cells["cl_codigo_barras"].Value = rows["CodigoBarras"];
                        dtg_informe.Rows[Contador].Cells["cl_referencia"].Value = rows["Referencia"];
                        dtg_informe.Rows[Contador].Cells["cl_nombre"].Value = rows["Nombre"];

                        dtg_informe.Rows[Contador].Cells["cl_cantidad"].Value = rows["Cantidad"];
                        double CantidadExacta = Convert.ToDouble(rows["Cantidad_exacta"]);
                        if (CantidadExacta < 1)
                        {
                            dtg_informe.Rows[Contador].Cells["cl_cantidad_exacta"].Value = Math.Round(CantidadExacta, 2);
                        }
                        else
                        {
                            dtg_informe.Rows[Contador].Cells["cl_cantidad_exacta"].Value = Math.Round(CantidadExacta);
                        }

                        dtg_informe.Rows[Contador].Cells["cl_um"].Value = rows["UM"];
                        double costo = Convert.ToDouble(rows["Costo"]);
                        dtg_informe.Rows[Contador].Cells["cl_costos"].Value = costo.ToString("N2");
                        double PrecioVenta = Convert.ToDouble(rows["PrecioVenta"]);
                        dtg_informe.Rows[Contador].Cells["cl_precio_venta"].Value = PrecioVenta.ToString("N2");
                        double ValorDescuento = Convert.ToDouble(rows["ValorDescuento"]);
                        dtg_informe.Rows[Contador].Cells["cl_Descuentos"].Value = ValorDescuento.ToString("N2");
                        double Total = PrecioVenta - ValorDescuento;
                        dtg_informe.Rows[Contador].Cells["cl_total"].Value = Total.ToString("N2");
                        double Resultados = Total - costo;
                        dtg_informe.Rows[Contador].Cells["cl_resultado"].Value = Resultados.ToString("N2");

                        dtg_informe.Rows[Contador].Cells["v_modulo"].Value = "V. Directa";
                        dtg_informe.Rows[Contador].Cells["cl_domicilio"].Value = rows["Domicilio"];
                        dtg_informe.Rows[Contador].Cells["cl_separado"].Value = rows["SistemaSeparado"];
                        Contador++;
                    }
                    else
                    {
                        //Cuando sea domicio o separado y esten estado pendiente se agrega en blanco
                        dtg_informe.Rows[Contador].Cells["cl_factura"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_usuario"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_item"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_codigo_barras"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_referencia"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_nombre"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_cantidad"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_cantidad_exacta"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_um"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_costos"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_precio_venta"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_Descuentos"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_total"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_resultado"].Value = "";
                        dtg_informe.Rows[Contador].Cells["v_modulo"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_domicilio"].Value = "";
                        dtg_informe.Rows[Contador].Cells["cl_separado"].Value = "";
                        Contador++;
                        //dtg_informe.Rows.Add(-1);
                    }
                }
            }
            foreach (DataGridViewRow rows in dtg_informe.Rows)
            {
                if (rows.Cells["cl_item"].Value.ToString() == "")
                {
                    dtg_informe.Rows.RemoveAt(rows.Index);
                }
            }

            // Repaso de tabla
            foreach (DataGridViewRow rows in dtg_informe.Rows)
            {
                if (rows.Cells["cl_item"].Value.ToString() == "")
                {
                    dtg_informe.Rows.RemoveAt(rows.Index);
                }
            }
        }
    }
}
