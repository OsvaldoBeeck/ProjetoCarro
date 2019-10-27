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
        public double taxab;
        public VenderVeiculos()
        {
            InitializeComponent();
        }

        public void BtnBuscaVender_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("SELECT `Nome`, `Cor`, `Preco`, `Ano`,`Tipo`, `Taxa` FROM `veiculos` WHERE Placa = ?", objcon);

                objCmd.Parameters.Clear();

                objCmd.Parameters.Add("@Placa", MySqlDbType.VarChar, 8).Value = txt_PlacaVenda.Text;
                objCmd.CommandType = CommandType.Text;

                //recebe o conteudo que vem do banco
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();

                string radiob = "";
                txt_VeiculoVenda.Text = dr.GetString(0);
                txt_CorVenda.Text = dr.GetString(1);
                txt_PrecoVenda.Text = dr.GetString(2);
                txt_AnoVenda.Text = dr.GetString(3);
                radiob = dr.GetString(4);
                taxab = dr.GetDouble(5);

               
                if (radiob == "LOJA")
                    radioButton_LOJA.Checked = true;
                else
                    radioButton_CONSIGNADO.Checked = true;


                objcon.Close();

            }
            catch
            {
                MessageBox.Show("VEICULO NÃO ENCONTRADO!");
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
                    MySqlCommand objCmd2 = new MySqlCommand("INSERT INTO  vendas(`Placa`, `DataVenda`, `Cliente`, `Telefone`, `Endereço`, `NomeVeiculo`, `PrecoVenda`, `Tipo`) VALUES (?,?,?,?,?,?,?,?)", objcon);
                    objcon.Open();
                    objCmd2.Parameters.Add("@Placa", MySqlDbType.VarChar, 8).Value = txt_PlacaVenda.Text;
                    objCmd2.Parameters.Add("@DataVenda", MySqlDbType.VarChar, 50).Value = Date_Venda.Text;
                    objCmd2.Parameters.Add("@Cliente", MySqlDbType.VarChar, 50).Value = txt_ClienteVenda.Text;
                    objCmd2.Parameters.Add("@Telefone", MySqlDbType.VarChar, 11).Value = txt_TelefoneVenda.Text;
                    objCmd2.Parameters.Add("@Endereco", MySqlDbType.VarChar, 255).Value = txt_EnderecoVenda.Text;
                    objCmd2.Parameters.Add("@NomeVeiculo", MySqlDbType.VarChar, 50).Value = txt_VeiculoVenda.Text;
                    objCmd2.Parameters.Add("@PrecoVenda", MySqlDbType.Double).Value = txt_PrecoVenda.Text;
                    string radiob = "";

                    if (radioButton_LOJA.Checked == true)
                        radiob = "LOJA";
                    else
                        radiob = "CONSIGNADO";
                    objCmd2.Parameters.Add("@Tipo", MySqlDbType.VarChar, 12).Value = radiob;
                    



                  



                    objCmd2.ExecuteNonQuery();
                    MessageBox.Show("Gravado no banco de dados com sucesso!!");

                    

                    //passa a string de conexão

                    //abre o banco de dados

                    //cria o comando my sql com seus devidos parametros
                    MySqlCommand objCmd = new MySqlCommand("UPDATE veiculos SET Status=?", objcon);
                    //limpa parametros
                    objCmd.Parameters.Clear();
                    objCmd.Parameters.Add("@placa", MySqlDbType.VarChar).Value = "VENDIDO";

                    //executa o comando
                    objCmd.CommandType = CommandType.Text;
                    objCmd.ExecuteNonQuery();
                    //fecha a conexão
                    
                    MessageBox.Show("Veiculo vendido com sucesso!");


                    objcon.Close();
                    double lucroLoja;
                    double lucroConsignado;
                    MySqlConnection objcon2 = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");

                    MySqlCommand objCmd3 = new MySqlCommand("SELECT `Loja`, `Consignado` FROM `lucro`", objcon2);
                    objcon2.Open();
                    objCmd3.Parameters.Clear();

                    objCmd3.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = objCmd3.ExecuteReader();
                    dr.Read();

                    lucroLoja = dr.GetDouble(0); 
                    lucroConsignado = dr.GetDouble(1);





                    if (radioButton_LOJA.Checked == true)
                        lucroLoja += Double.Parse(txt_PrecoVenda.Text);
                    else
                        lucroConsignado += taxab;

                    MySqlConnection objcon3 = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                    MySqlCommand objCmd4 = new MySqlCommand("UPDATE Lucro SET Loja=?,Consignado=?", objcon3);
                    objcon3.Open();
                    objCmd4.Parameters.Add("@Loja", MySqlDbType.Double).Value = lucroLoja;
                    objCmd4.Parameters.Add("@Consignado", MySqlDbType.Double).Value = lucroConsignado;




                    objCmd4.CommandType = CommandType.Text;
                    objCmd4.ExecuteNonQuery();
                    objcon3.Close();

                    txt_PlacaVenda.Text = "";
                    txt_VeiculoVenda.Text = "";
                    txt_CorVenda.Text = "";
                    txt_PrecoVenda.Text = "";
                    AnoVenda.Text = "";
                    txt_ClienteVenda.Text = "";
                    txt_EnderecoVenda.Text = "";
                    txt_TelefoneVenda.Text = "";
                    objcon2.Close();
                }
                
                
                

            }
            catch (Exception erro)
            {
                MessageBox.Show("LUCRO NÃO ATRIBUIDO!" + erro);
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
