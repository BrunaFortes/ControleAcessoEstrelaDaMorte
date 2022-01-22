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
    public partial class Frm_planeta : Form
    {
        public Frm_planeta()
        {
            InitializeComponent();
        }

        private void Planeta_Load(object sender, EventArgs e)
        {
            planetasBindingSource.DataSource = DataContextFactory.DataContext.Planetas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            planetasBindingSource.AddNew();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            planetasBindingSource.CancelEdit();
        }
        private bool Valida()
        {
            while (txt_clima.Text.Trim() == string.Empty ||
               txt_codigo.Text.Trim() == string.Empty || txt_diametro.Text.Trim() == string.Empty ||
               txt_nome.Text.Trim() == string.Empty || txt_orbita.Text.Trim() == string.Empty
               || txt_populao.Text.Trim() == string.Empty || txt_rotacao.Text.Trim() == string.Empty)
            {
                if (txt_clima.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Clima é obrigatório!");
                    txt_clima.Focus();

                }
                else if (txt_codigo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Código é obrigatório");
                    txt_codigo.Focus();
                }
                else if (txt_nome.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Nome é obrigatório!");
                    txt_nome.Focus();
                }
                else if (txt_diametro.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Diâmetro é obrigatório!");
                    txt_diametro.Focus();
                }
                else if (txt_orbita.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Modelo obrigatório!");
                    txt_orbita.Focus();

                }
                else if (txt_populao.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Passageiros é obrigatório!");
                    txt_populao.Focus();
                }
                else if (txt_rotacao.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo Passageiros é obrigatório!");
                    txt_rotacao.Focus();
                }
                return false;
            }
            return true;
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                planetasBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                planetasDataGridView.Refresh();
                MessageBox.Show("Planeta inserido com sucesso!");
            }
        }
    }
}

