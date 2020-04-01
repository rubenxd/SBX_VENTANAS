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
    public partial class frm_exportar_excel : Form
    {
        public frm_exportar_excel()
        {
            InitializeComponent();
            progressBar.Increment(0);
        }

        public void mtd_progreso(int Incremento)
        {
            this.progressBar.Increment(Incremento);
        }
    }
}
