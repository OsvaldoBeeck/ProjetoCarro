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
    public partial class CadastroVeiculoConsignado : Form
    {
        public CadastroVeiculoConsignado()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Telainicial telainicial = new Telainicial();
            telainicial.Show();
        }

        private void Button_CadastrarVeiculoC_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");

                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("INSERT INTO consignado (`Nome`, `Placa`, `Cor`, `Preco` , `Ano`, `Proprietario`, `Taxa`, `Observacoes`) VALUES( ?, ?, ?, ?,?,?,?,?)", objcon);

                objCmd.Parameters.Add("@nome_veiculo", MySqlDbType.VarChar, 60).Value = txt_NomeVeiculoC.Text;
                objCmd.Parameters.Add("@placa_veiculo", MySqlDbType.VarChar, 60).Value = txt_placaVeiculoC.Text;
                objCmd.Parameters.Add("@cor_veiculo", MySqlDbType.VarChar, 60).Value = txt_corVeiculoC.Text;
                objCmd.Parameters.Add("@preco_veiculo", MySqlDbType.Double).Value = txt_precoVeiculoC.Text;
                objCmd.Parameters.Add("@ano_veiculo", MySqlDbType.Int32).Value = cmbAnoVeiculoC.Text;
                objCmd.Parameters.Add("@proprietario", MySqlDbType.VarChar, 50).Value = txt_ProprietarioVeiculoC.Text;
                objCmd.Parameters.Add("@taxa", MySqlDbType.Double).Value = txt_taxaVeiculoC.Text;
                objCmd.Parameters.Add("@observacoes", MySqlDbType.VarChar, 500).Value = txt_ObsVeiculoC.Text;






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
    }
}
