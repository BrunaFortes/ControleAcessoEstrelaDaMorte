using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;
using EstrelaDaMorte.Forms;

namespace EstrelaDaMorte
{
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }


      

        private void Frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void pilotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_piloto frm = new Frm_piloto();
            frm.Show();
        }

        private void naveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Nave frm = new Frm_Nave();
            frm.Show();
        }

        private void planetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void planetaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_planeta frm = new Frm_planeta();
            frm.Show();
        }

        private void Btn_autorizacaoVoo_Click(object sender, EventArgs e)
        {
            Frm_autorizacaoVoo frm = new Frm_autorizacaoVoo();
            frm.Show();
        }

        private void Btn_historicoViagem_Click(object sender, EventArgs e)
        {
            Frm_historicoViagens frm = new Frm_historicoViagens();
            frm.Show();
        }
    }
}
