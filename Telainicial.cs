using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCarro 
{
    public partial class Telainicial : Form
    {
        public Telainicial()
        { 
            InitializeComponent();
        }

        public void btnCadastrarVeiculoLoja_Click(object sender, EventArgs e)
        {
            xuiObjectAnimator1.FormAnimate(this, XanderUI.XUIObjectAnimator.FormAnimation.FadeOut, 20);
            CadastrarVeiculoLoja cadastrarVeiculoLoja = new CadastrarVeiculoLoja();
            this.Hide();
            cadastrarVeiculoLoja.Show();
        }

        private void btnVenderVeiculoLoja_Click(object sender, EventArgs e)
        {
            VenderVeiculos venderVeiculo = new VenderVeiculos();
            this.Hide();
            venderVeiculo.Show();
        }

        private void btnPesquisarVeiculo_Click(object sender, EventArgs e)
        {
            PesquisaPlaca pesquisaPlaca = new PesquisaPlaca();
            this.Hide();
            pesquisaPlaca.Show();
        }

        private void btnSimulacao_Click(object sender, EventArgs e)
        {
            Simulacao simulacao = new Simulacao();
            this.Hide();
            simulacao.Show(); 
        }

        private void btnCadastrarVeiculoConsignado_Click(object sender, EventArgs e)
        {
            CadastroVeiculoConsignado cadastroVeiculoConsignado = new CadastroVeiculoConsignado();
            this.Hide();
            cadastroVeiculoConsignado.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureClose_Click(object sender, EventArgs e)
        {
            BtnSair_Click(this,e);
        }

        private void btnVenderVeiculoConsignado_Click(object sender, EventArgs e)
        {

        }

        private void BtnApresentarVeiculos_Click(object sender, EventArgs e)
        {

        }

        private void BtnHistoricoDeVendasConsignado_Click(object sender, EventArgs e)
        {

        }

        private void BtnHistoricoDeVendasDaLoja_Click(object sender, EventArgs e)
        {

        }
    }
}
