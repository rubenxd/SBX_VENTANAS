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
    public partial class frm_confirmacion : Form
    {
        //Delegado
        public delegate void Confirmacion(bool dato);
        public event Confirmacion Confirma;

        //Inicio formulario
        public frm_confirmacion()
        {
            InitializeComponent();
        }
        private void frm_confirmacion_Load(object sender, EventArgs e)
        {
            btn_aceptar.Focus();
        }

        //Eventos
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Confirma(false);
            this.Dispose();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Confirma(true);
            this.Dispose();
        }
    }
}
