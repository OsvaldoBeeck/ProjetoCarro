using System;
using System.Windows.Forms;

namespace ProjetoCarro
{
    public partial class CadastrarOutroVeiculo : Form
    {
        public CadastrarOutroVeiculo()
        {
            InitializeComponent();
        }

        private void TxtNao_Click(object sender, EventArgs e)
        {
            Telainicial telainicial = new Telainicial();
            this.Hide();
            telainicial.Show();
        }

        private void TxtSim_Click(object sender, EventArgs e)
        {
            CadastrarVeiculoLoja cadastrarVeiculoLoja = new CadastrarVeiculoLoja();
            cadastrarVeiculoLoja.Show();
            this.Hide();
        }
    }
}
