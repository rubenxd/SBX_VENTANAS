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
    public partial class frm_pago_credito : Form
    {

        //Delegado
        public delegate void EnviarInfo(string Confirmacion);
        public event EnviarInfo Enviainfo;
        public frm_pago_credito()
        {
            InitializeComponent();
        }

        private void frm_pago_credito_Load(object sender, EventArgs e)
        {

        }
    }
}
