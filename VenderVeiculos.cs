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
    public partial class VenderVeiculos : Form
    {
        public VenderVeiculos()
        {
            InitializeComponent();
        }

        private void BtnBuscaVender_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("SELECT `Nome`, `Cor`, `Preco`, `Ano` FROM `veiculos` WHERE Placa = ?", objcon);

                objCmd.Parameters.Clear();

                objCmd.Parameters.Add("@Placa", MySqlDbType.VarChar, 8).Value = txt_PlacaVenda.Text;
                objCmd.CommandType = CommandType.Text;

                //recebe o conteudo que vem do banco
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();

                
                txt_VeiculoVenda.Text = dr.GetString(0);
                txt_CorVenda.Text = dr.GetString(1);
                txt_PrecoVenda.Text = dr.GetDouble(2).ToString("C", CultureInfo.CurrentCulture);
                txt_AnoVenda.Text = dr.GetString(3);


                objcon.Close();

            }
            catch
            {
                MessageBox.Show("Venda Não incluida no banco de dados!");
            }

        }

        private void Button_Vender_Click(object sender, EventArgs e)
        {


            
            try
            {
               
                if (txt_PrecoVenda.Text == ""|| txt_ClienteVenda.Text == "" || txt_EnderecoVenda.Text == "" || txt_TelefoneVenda.Text == "")
                {
                    MessageBox.Show("TODOS CAMPOS PRECISAM SER PREENCHIDOS!");
                }
               else
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                    MySqlCommand objCmd2 = new MySqlCommand("INSERT INTO `vendas`(`Placa`, `DataVenda`, `Cliente`, `Telefone`, `Endereço`, `NomeVeiculo`, `PrecoVenda`) VALUES (?,?,?,?,?,?,?)", objcon);
                    objcon.Open();
                    objCmd2.Parameters.Add("@Placa", MySqlDbType.VarChar, 8).Value = txt_PlacaVenda.Text;
                    objCmd2.Parameters.Add("@DataVenda", MySqlDbType.VarChar, 50).Value = Date_Venda.Text;
                    objCmd2.Parameters.Add("@Cliente", MySqlDbType.VarChar, 50).Value = txt_ClienteVenda.Text;
                    objCmd2.Parameters.Add("@Telefone", MySqlDbType.VarChar, 11).Value = txt_TelefoneVenda.Text;
                    objCmd2.Parameters.Add("@Endereco", MySqlDbType.VarChar, 255).Value = txt_EnderecoVenda.Text;
                    objCmd2.Parameters.Add("@NomeVeiculo", MySqlDbType.VarChar, 50).Value = txt_VeiculoVenda.Text;
                    objCmd2.Parameters.Add("@PrecoVenda", MySqlDbType.VarChar, 10).Value = txt_PrecoVenda.Text;



                    objCmd2.ExecuteNonQuery();
                    MessageBox.Show("Gravado no banco de dados com sucesso!!");


                    //passa a string de conexão

                    //abre o banco de dados

                    //cria o comando my sql com seus devidos parametros
                    MySqlCommand objCmd = new MySqlCommand("delete from veiculos where placa = ?", objcon);
                    //limpa parametros
                    objCmd.Parameters.Clear();
                    objCmd.Parameters.Add("@placa", MySqlDbType.VarChar).Value = txt_PlacaVenda.Text;

                    //executa o comando
                    objCmd.CommandType = CommandType.Text;
                    objCmd.ExecuteNonQuery();
                    //fecha a conexão
                    objcon.Close();
                    MessageBox.Show("Veiculo vendido com sucesso!");

                    txt_PlacaVenda.Text = "";
                    txt_VeiculoVenda.Text = "";
                    txt_CorVenda.Text = "";
                    txt_PrecoVenda.Text = "";
                    AnoVenda.Text = "";
                }
                
                
                

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível deletar: " + erro);
            }
        }

        private void Button_VoltarVenda_Click(object sender, EventArgs e)
        {
            Telainicial telainicial = new Telainicial();
            this.Close();
            telainicial.Show();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
