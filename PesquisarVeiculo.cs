using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoCarro
{
    public partial class PesquisarVeiculo : Form
    {
        public PesquisarVeiculo()
        {
            InitializeComponent();
        }

        private void BtnPlaca_Click(object sender, EventArgs e)
        {
            PesquisaPlaca pesquisaPlaca = new PesquisaPlaca();
            this.Hide();
            pesquisaPlaca.Show();
        }
    }
}
