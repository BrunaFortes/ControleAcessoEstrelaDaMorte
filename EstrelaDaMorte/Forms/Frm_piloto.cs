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

namespace EstrelaDaMorte
{
    public partial class Frm_piloto : Form
    {
        public Frm_piloto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pilotosBindingSource.AddNew();
        }
        private bool valida()
        {
            while (txt_id.Text.Trim() == string.Empty || txt_ano.Text.Trim() == string.Empty || txt_nome.Text.Trim() == string.Empty)
            {
                if (txt_id.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Código é obrigatório!");
                    txt_id.Focus();

                }
                else if (txt_ano.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Ano de Nascimento é obrigatório");
                    txt_ano.Focus();
                }
                else if (txt_nome.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Nome é obrigatório!");
                }
                return false;
            }
            return true;
        }

        private void Frm_piloto_Load(object sender, EventArgs e)
        {
            pilotosBindingSource.DataSource = DataContextFactory.DataContext.Pilotos;
            planetasBindingSource.DataSource = DataContextFactory.DataContext.Planetas;
        }

        private void pilotosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pilotosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Planetas)e.Value).Nome;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                pilotosBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                pilotosDataGridView.Refresh();
                MessageBox.Show("Piloto cadastrado com sucesso!");
            }
        }

       

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            pilotosBindingSource.CancelEdit();
        }
    }
}
