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
using System.Globalization;

namespace ProjetoCarro
{
    public partial class CadastrarVeiculoLoja : Form
    {
        public CadastrarVeiculoLoja()
        {
            InitializeComponent();
        }

        private void CadastrarVeiculoLoja_Load(object sender, EventArgs e)
        {
            cmbAnoVeiculo.Items.Add("2006");
            cmbAnoVeiculo.Items.Add("2007");
            cmbAnoVeiculo.Items.Add("2008");
            cmbAnoVeiculo.Items.Add("2009");
            cmbAnoVeiculo.Items.Add("2010");
            cmbAnoVeiculo.Items.Add("2011");
            cmbAnoVeiculo.Items.Add("2012");
            cmbAnoVeiculo.Items.Add("2013");
            cmbAnoVeiculo.Items.Add("2014");
            cmbAnoVeiculo.Items.Add("2015");
            cmbAnoVeiculo.Items.Add("2016");
            cmbAnoVeiculo.Items.Add("2017");
            cmbAnoVeiculo.Items.Add("2018");
            cmbAnoVeiculo.Items.Add("2019");
            cmbAnoVeiculo.Items.Add("2020");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Telainicial telainicial = new Telainicial();
            telainicial.Show();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                
                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("INSERT INTO veiculos (`Nome`, `Placa`, `Cor`, `Preco` , `Ano`) VALUES( ?, ?, ?, ?,?)", objcon);

                objCmd.Parameters.Add("@nome_veiculo", MySqlDbType.VarChar, 60).Value = nomeVeiculo.Text;
                objCmd.Parameters.Add("@placa_veiculo", MySqlDbType.VarChar, 60).Value = placaVeiculo.Text;
                objCmd.Parameters.Add("@cor_veiculo", MySqlDbType.VarChar, 60).Value = corVeiculo.Text;
                objCmd.Parameters.Add("@preco_veiculo", MySqlDbType.Double).Value = precoVeiculo.Text;
                objCmd.Parameters.Add("@ano_veiculo", MySqlDbType.Int32).Value = cmbAnoVeiculo.Text;

                

                


                objCmd.ExecuteNonQuery();
                MessageBox.Show("Gravado no banco de dados com sucesso!!");
                objcon.Close();

                CadastrarOutroVeiculo cadastrarOutroVeiculo = new CadastrarOutroVeiculo();
                this.Hide();
                cadastrarOutroVeiculo.Show();

            }
            catch
            {
                Console.WriteLine("Erro ao abrir o banco de dados");
            }
        }

        private void CorVeiculo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
