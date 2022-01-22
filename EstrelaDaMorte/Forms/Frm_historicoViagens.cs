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
    public partial class Frm_historicoViagens : Form
    {
        public Frm_historicoViagens()
        {
            InitializeComponent();
        }

        private void historicoViagensDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //    if (e.Value != null && e.ColumnIndex == 0)
            //        e.Value = ((Naves)e.Value).Nome;
            //    if (e.Value != null && e.ColumnIndex == 1)
            //        e.Value = ((Pilotos)e.Value).Nome;
            //
        }

        private void Frm_historicoViagens_Load(object sender, EventArgs e)
        {
            historicoViagensBindingSource.DataSource = DataContextFactory.DataContext.HistoricoViagens;
            pilotosBindingSource.DataSource = DataContextFactory.DataContext.Pilotos;
            navesBindingSource.DataSource = DataContextFactory.DataContext.Naves;
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            historicoViagensBindingSource.AddNew();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            historicoViagensBindingSource.CancelEdit();
        }
        private bool Valida()
        {
            while (cbb_nave.Text.Trim() == string.Empty || cbb_piloto.Text.Trim() == string.Empty || dt_saida.Text.Trim() == String.Empty)
            {
                if (cbb_nave.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Nave é obrigatório!");
                    cbb_nave.Focus();

                }
                else if (cbb_piloto.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Piloto é obrigatório");
                    cbb_piloto.Focus();
                }
                else if (dt_saida.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("A Data de Saída é obrigatório!");
                }
                return false;
            }
            return true;
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                historicoViagensBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                historicoViagensDataGridView.Refresh();
                MessageBox.Show("Viagem cadastrada com sucesso!");
            }
        }
    }
}
