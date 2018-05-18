using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploList
{
    public partial class Exemplo01 : Form
    {
        List<Int32> numeros = new List<Int32>();
        public Exemplo01()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                numeros.Add(numero);
                cbSelecionarParaEditar.Items.Add(numero);
                txtNumero.Text = "";
                MessageBox.Show(string.Format("Número {0} cadastrado com sucesso", numero));
                txtNumero.Focus();
            }

            catch
            {
                MessageBox.Show("Número não é um valor aceitável");
            }
            
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            rtbNumeros.Clear();
            for (int i = 0; i < numeros.Count; i++)
            {
                rtbNumeros.AppendText(numeros[i] + "\n");

            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult dialogResult = MessageBox.Show("Você realmente deseja apagar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.Yes)
                {
                    int posicao = Convert.ToInt32(txtPosicaoApagar.Text);
                    numeros.RemoveAt(posicao);
                    btnProcessar.PerformClick();
                    txtPosicaoApagar.Text = "";

                    MessageBox.Show("Apagado com sucesso");
                    AtualizarComboBoxParaEditar();
                    txtNumero.Focus();

                }

                else
                {
                    MessageBox.Show("TAIX SALVO NEGO");
                }
            }
        }

        private void txtValorParaApagar_Leave(object sender, EventArgs e)
        {
            if (txtValorParaApagar.Text != "")
            {
                int valor = Convert.ToInt32(txtValorParaApagar.Text);
                numeros.Remove(valor);
                txtValorParaApagar.Text = "";
                MessageBox.Show(valor + "Valor apagado com sucesso");
                btnProcessar.PerformClick();

                while (numeros.Contains(valor))
                {
                    numeros.Remove(valor);
                }
                txtValorParaApagar.Text = "";
                MessageBox.Show(valor + " Apagado com sucesso");
                AtualizarComboBoxParaEditar();
                btnProcessar.PerformClick();
            }
        }
            private void AtualizarComboBoxParaEditar()
            
            {
                for (int i = 0; i < numeros.Count; i++)
			{
			    cbSelecionarParaEditar.Items.Add(numeros[i]);
			}
            

        }

            private void cbSelecionarParaEditar_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cbSelecionarParaEditar.SelectedIndex > -1)
                {
                    txtNumeroEditar.Enabled = true;
                    txtNumeroEditar.Focus();
                }
            }

            private void txtNumeroEditar_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int posicao = Convert.ToInt32(cbSelecionarParaEditar.SelectedIndex);
                    int valorNovo = Convert.ToInt32(txtNumeroEditar.Text);

                    numeros[posicao] = valorNovo;

                    txtNumeroEditar.Text = "";
                    txtNumeroEditar.Enabled = false;
                    cbSelecionarParaEditar.SelectedIndex = -1;
                    btnProcessar.PerformClick();
                    AtualizarComboBoxParaEditar();
                    MessageBox.Show("Número alterado com sucesso!");
                }
            }
    }
}
