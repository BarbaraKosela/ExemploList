using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuGuardaRoupa
{
    public partial class ListaDePeca : Form
    {
        public ListaDePeca()
        {
            InitializeComponent();
        }

        private void ListaDePeca_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dgvListaPeca.Rows.Clear();
            for (int i = 0; i < Program.pecas.Count; i++)
            {
                string busca = txtBusca.Text.ToLower();
                Peca peca = Program.pecas[i];
                if (peca.Ativo == true && peca.Nome.Contains(busca) || (peca.Marca.Contains(busca)))
                {
                dgvListaPeca.Rows.Add(new object[]{
                    peca.Nome, peca.Cor, peca.Marca, peca.Valor
                });

                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new CadastroPeca().ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
         
            if (dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Não há peças selecionadas");
                return;
            }

            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            Peca peca = Program.pecas[linhaSelecionada];
            new CadastroPeca(peca, linhaSelecionada).ShowDialog();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Não há peças selecionadas");
                return;
            }

            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            Peca peca = Program.pecas[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja mesmo apagar o " + peca.Nome + " registro?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.pecas.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com sucesso");
            }
            else
            {
                MessageBox.Show("Seu registro está salvo");
            }
            
        }

        private void ListaDePeca_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }

        private void txtBusca_Leave(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
