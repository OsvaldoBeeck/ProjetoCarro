using MySql.Data.MySqlClient;
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
    public partial class PesquisaPlaca : Form
    {
        public PesquisaPlaca()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
            objcon.Open();

            MySqlCommand objCmd = new MySqlCommand("SELECT `Nome`, `Placa`, `Cor`, `Preco` , `Ano`  FROM `veiculos` WHERE Placa = ?", objcon);

            objCmd.Parameters.Clear();

            objCmd.Parameters.Add("@Placa", MySqlDbType.VarChar, 8).Value = txtPlaca.Text;
            objCmd.CommandType = CommandType.Text;

            //recebe o conteudo que vem do banco
            MySqlDataReader dr;
            dr = objCmd.ExecuteReader();
            dr.Read();

            txt_VeiculoPesquisa.Text = dr.GetString(0);
            txt_CorPesquisa.Text = dr.GetString(2);
            txt_PrecoPesquisa.Text = dr.GetString(3);
            txt_AnoPesquisa.Text = dr.GetString(4);

            objcon.Close();


        }

        private void Button_EditarCadastro_Click(object sender, EventArgs e)
        {
            txt_VeiculoPesquisa.Enabled = true;
            txt_CorPesquisa.Enabled = true;
            txt_PrecoPesquisa.Enabled = true;
            txt_AnoPesquisa.Enabled = true;

            Button_SalvarPlaca.Visible = true;

        }

        private void Button_SalvarPlaca_Click(object sender, EventArgs e)
        {
            //passa a string de conexão
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
            //abre o banco de dados
            objcon.Open();

            MySqlCommand objCmd = new MySqlCommand("UPDATE veiculos SET nome=?,cor=?,preco=?, ano=? WHERE placa =?", objcon);
            objCmd.Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = txt_VeiculoPesquisa.Text;
            objCmd.Parameters.Add("@cor", MySqlDbType.VarChar, 60).Value = txt_CorPesquisa.Text;
            objCmd.Parameters.Add("@preco", MySqlDbType.VarChar, 20).Value = txt_PrecoPesquisa.Text;
            objCmd.Parameters.Add("@ano", MySqlDbType.VarChar, 20).Value = txt_AnoPesquisa.Text;
            //objCmd.Parameters.Add("@ds_Endereço", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            objCmd.Parameters.Add("@placa", MySqlDbType.VarChar, 20).Value = txtPlaca.Text;

            objCmd.CommandType = CommandType.Text;
            objCmd.ExecuteNonQuery();

            objcon.Close();

            MessageBox.Show("Atualização concluída com sucesso!");






            txt_VeiculoPesquisa.Enabled = false;
            txt_CorPesquisa.Enabled = false;
            txt_PrecoPesquisa.Enabled = false;
            txt_AnoPesquisa.Enabled = false;

            Button_SalvarPlaca.Visible = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Telainicial telaInicio = new Telainicial();
            this.Hide();
            telaInicio.Show();
        }
    }
}
