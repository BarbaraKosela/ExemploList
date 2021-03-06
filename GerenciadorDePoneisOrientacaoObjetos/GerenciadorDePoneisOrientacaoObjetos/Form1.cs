﻿using System;
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

        List<Ponei> poneis = new List<Ponei>();



        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbCorCrista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a cor da crista");
                return; 
            }

            if (cbLocalidade.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a localidade");
                return;
            }

            if (cbRaca.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a raça");
                return;
            }

            if (txtApelido.Text == "")
            {
                MessageBox.Show("Digite o apelido");
                return;
            }

            if (rbVivo.Checked == false && rbMorto.Checked == false)
            {
                MessageBox.Show("Informe se está vivo ou não");
            }

            



            Ponei ponei = new Ponei();
            ponei.Apelido = txtApelido.Text;
            ponei.CorDaCrista = cbCorCrista.SelectedItem.ToString();
            ponei.Dancarino = cbDancarino.Checked;
            ponei.Localidade = cbLocalidade.SelectedItem.ToString();
            ponei.NivelFofura = tbNivelFofura.Value;
            ponei.VendaVivo = rbVivo.Checked;
            ponei.Descricao = rtbDescricao.Text;
            ponei.Raca = cbRaca.SelectedItem.ToString();
            poneis.Add(ponei);
            dgvPoneis.Rows.Add(new Object[]{
            ponei.Apelido, 
            ponei.Raca});
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtApelido.Text = "";
            rtbDescricao.Text = "";
            cbCorCrista.SelectedIndex = -1;
            cbLocalidade.SelectedIndex = -1;
            cbRaca.SelectedIndex = -1;
            cbDancarino.Checked = false;
            rbVivo.Checked = false;
            rbMorto.Checked = false;
            tbNivelFofura.Value = tbNivelFofura.Minimum; 

        }
    }
}
