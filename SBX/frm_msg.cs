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
    public partial class frm_msg : Form
    {
        //inicio formulario
        public frm_msg()
        {
            InitializeComponent();
        }
        private void frm_msg_Load(object sender, EventArgs e)
        {
          
        }

        //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
