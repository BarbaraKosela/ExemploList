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
    public partial class CadastroPeca : Form
    {
        public CadastroPeca()
        {
            InitializeComponent();
            for (int i = 8; i <= 60; i++)
            {
                cbTamanho.Items.Add(i);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter no mínimo 4 caracteres");
                txtNome.Focus();
                return;
            }

            if (cbTipo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o tipo da peça");
                cbTipo.DroppedDown = true;
                return; 
            }

            if (cbMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a marca");
                cbMarca.DroppedDown = true;
                return;
            }

            if (cbTamanho.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o tamanho");
                cbTamanho.DroppedDown = true;
                return;
            }

            if (cbCor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a cor");
                cbCor.DroppedDown = true;
                return;
            }

            if (dtpData.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("A data de compra deve ser de hoje ou de uma data anterior");
            }

            if (txtValor.Text.Length == 0)
            {
                MessageBox.Show("Valor deve ser preenchido");
                txtValor.Focus();
                return;
            }

            try
            {
                double valor = Convert.ToDouble(txtValor.Text);
            }
            catch
            {
                MessageBox.Show("Valor deve conter somente números reais");
                txtValor.Focus();
                return;
            }

            if (cbTecido.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o tecido");
                cbTecido.DroppedDown = true;
                return;
            }


            Peca peca = new Peca()
            {
                Nome = txtNome.Text,
                Cor = cbCor.SelectedItem.ToString(),
                Marca = cbMarca.SelectedItem.ToString(),
                Tamanho = cbTamanho.SelectedItem.ToString(),
                Tipo = cbTipo.SelectedItem.ToString(),
                Valor = Convert.ToDouble(txtValor.Text),
                Tecido = cbTecido.SelectedItem.ToString(),
                DataCompra = dtpData.Value

            };

            Program.pecas.Add(peca); 
        }
    }
}
