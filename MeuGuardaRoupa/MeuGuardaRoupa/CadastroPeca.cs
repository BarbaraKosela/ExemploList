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
