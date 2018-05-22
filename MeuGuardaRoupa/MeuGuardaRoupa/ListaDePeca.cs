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
                Peca peca = Program.pecas[i];
                dgvListaPeca.Rows.Add(new object[]{
                    peca.Nome, peca.Cor, peca.Marca, peca.Valor
                });
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new CadastroPeca().ShowDialog();
        }
    }
}
