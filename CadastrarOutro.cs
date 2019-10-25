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

      

        internal void Show(int v)
        {
            throw new NotImplementedException();
        }

        private void Button_simC_Click(object sender, EventArgs e)
        {
            CadastroVeiculoConsignado cadastroVeiculoConsignado = new CadastroVeiculoConsignado();

            cadastroVeiculoConsignado.Show();
                this.Hide();
        }
    }
    }

