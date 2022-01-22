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
    public partial class Frm_Nave : Form
    {
        public Frm_Nave()
        {
            InitializeComponent();
        }

        private void modeloTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modeloLabel_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Nave_Load(object sender, EventArgs e)
        {
            navesBindingSource.DataSource = DataContextFactory.DataContext.Naves;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navesBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            navesBindingSource.CancelEdit();
        }
        private bool valida()
        {
            while (txt_id.Text.Trim() == string.Empty || 
                txt_nome.Text.Trim() == string.Empty || txt_modelo.Text.Trim() == string.Empty || 
                txt_passageiros.Text.Trim() == string.Empty || txt_carga.Text.Trim() == string.Empty)
            {
                if (txt_id.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Código é obrigatório!");
                    txt_id.Focus();

                }
                else if (txt_carga.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Carga é obrigatório");
                    txt_carga.Focus();
                }
                else if (txt_nome.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Nome é obrigatório!");
                }
                else if (txt_classe.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Classe é obrigatório!");
                }
                else if (txt_modelo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Modelo obrigatório!");
                }
                else if (txt_passageiros.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Passageiros é obrigatório!");
                }
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                navesBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                navesDataGridView.Refresh();
                MessageBox.Show("Nave inserida com sucesso!");
            }
        }

        private void cargaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
