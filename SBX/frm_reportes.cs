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
    public partial class frm_reportes : Form
    {
        public frm_reportes()
        {
            InitializeComponent();
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_reportes_Load(object sender, EventArgs e)
        {
            cbx_reporte.SelectedIndex = 0;
        }
    }
}
