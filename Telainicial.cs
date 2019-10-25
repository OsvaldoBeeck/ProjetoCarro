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

        public void Button1_Click(object sender, EventArgs e)
        {
            CadastrarVeiculoLoja cadastrarVeiculoLoja = new CadastrarVeiculoLoja();
            this.Hide();
            cadastrarVeiculoLoja.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            VenderVeiculos venderVeiculo = new VenderVeiculos();
            this.Hide();
            venderVeiculo.Show();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaPlaca pesquisaPlaca = new PesquisaPlaca();
            this.Hide();
            pesquisaPlaca.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Simulacao simulacao = new Simulacao();
            this.Hide();
            simulacao.Show();

            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            CadastroVeiculoConsignado cadastroVeiculoConsignado = new CadastroVeiculoConsignado();

            this.Hide();

            cadastroVeiculoConsignado.Show();
        }
    }
}
