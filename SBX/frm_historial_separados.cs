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
using System.Runtime.InteropServices;

namespace SBX
{
    public partial class frm_historial_separados : Form
    {
        cls_sistema_separado cls_Sistema_separado = new cls_sistema_separado();

        //Variables
        DataTable v_dt;
        int v_fila = 0;
        int v_contador = 0;

        //Codigo para mover venta
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        public frm_historial_separados()
        {
            InitializeComponent();
        }
        private void frm_historial_separados_Load(object sender, EventArgs e)
        {
            mtd_cargar_pagos();
        }

        //Metodos
        private void mtd_cargar_pagos()
        {
            cls_Sistema_separado.Codigo = Convert.ToInt32(lbl_num_separado.Text);
            v_dt = cls_Sistema_separado.mtd_consultar_pagos();
            dtg_pagos.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                v_fila = v_dt.Rows.Count;
                dtg_pagos.Rows.Add(v_fila);
                v_contador = 0;
                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_pagos.Rows[v_contador].Cells["cl_num_separado"].Value = rows["SistemaSeparado"];
                    dtg_pagos.Rows[v_contador].Cells["cl_Fecha"].Value = rows["Fecha"];
                    double ValorAbono = Convert.ToDouble(rows["ValorAbono"]);
                    dtg_pagos.Rows[v_contador].Cells["cl_valor_abono"].Value = ValorAbono.ToString("N0");
                    
                    v_contador++;
                }
            }
        }

        //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            Dispose();
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
    }
}
