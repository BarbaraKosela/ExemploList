using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDePoneisOrientacaoObjetos
{
    public partial class Form1 : Form
    {





        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Ponei ponei = new Ponei();
            ponei.Apelido = txtApelido.Text;
            ponei.CorDaCrista = cbCorCrista.SelectedItem.ToString();
            ponei.Dancarino = cbDancarino.Checked;
            ponei.Localidade = cbLocalidade.SelectedItem.ToString();
            ponei.NivelFofura = tbNivelFofura.Value;
            ponei.VendaVivo = rbVivo.Checked;
            ponei.Descricao = rtbDescricao.Text;
            ponei.Raca = cbRaca.SelectedItem.ToString();



        }
    }
}
