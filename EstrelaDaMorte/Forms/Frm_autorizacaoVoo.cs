using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAL;

namespace EstrelaDaMorte.Forms
{
    public partial class Frm_autorizacaoVoo : Form
    {
        public Frm_autorizacaoVoo()
        {
            InitializeComponent();
        }

        private void Frm_autorizacaoVoo_Load(object sender, EventArgs e)
        {
            pilotosNavesBindingSource.DataSource = DataContextFactory.DataContext.PilotosNaves;
            pilotosBindingSource.DataSource = DataContextFactory.DataContext.Pilotos;
            navesBindingSource.DataSource = DataContextFactory.DataContext.Naves;
        }

        private void pilotosNavesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void pilotosNavesDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Pilotos)e.Value).Nome;
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Naves)e.Value).Nome;
        }
    }
}
