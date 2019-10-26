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
using System.Globalization;

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
            txt_VeiculoPesquisa.Text = "";
            txt_CorPesquisa.Text = "";
            txt_PrecoPesquisa.Text = "";
            txt_AnoPesquisa.Text = "";
            try
            {


                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("SELECT `Nome`, `Placa`, `Cor`, `Preco` , `Ano`  FROM `veiculos` WHERE Placa = ?", objcon);

                objCmd.Parameters.Clear();

                objCmd.Parameters.Add("@Placa", MySqlDbType.VarChar, 8).Value = txtPlaca.Text;
                objCmd.CommandType = CommandType.Text;

                
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();

                
               

                radioButton_Loja.Checked = true;
                radioButton_Consig.Enabled = false;
                radioButton_Consig.Checked = false;
                txt_VeiculoPesquisa.Text = dr.GetString(0);
                txt_CorPesquisa.Text = dr.GetString(2);
                txt_PrecoPesquisa.Text = dr.GetDouble(3).ToString("C", CultureInfo.CurrentCulture);
                txt_AnoPesquisa.Text = dr.GetString(4);
                

            }
            catch(Exception erro)
            {
                MessageBox.Show("Carro não encontrado na Loja!");
            }

                

                if (txt_VeiculoPesquisa.Text == "")
                {

                try
                {
                    radioButton_Consig.Checked = true;
                    radioButton_Loja.Enabled = false;
                    radioButton_Loja.Checked = false;
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                    objcon.Open();

                    MySqlCommand objCmd2 = new MySqlCommand("SELECT `Nome`, `Placa`, `Cor`, `Preco` , `Ano` ,`Proprietario` FROM `consignado` WHERE Placa = ?", objcon);
                    MySqlDataReader dr2;

                    objCmd2.Parameters.Clear();

                    objCmd2.Parameters.Add("@Placa", MySqlDbType.VarChar, 8).Value = txtPlaca.Text;
                    objCmd2.CommandType = CommandType.Text;

                    //recebe o conteudo que vem do banco

                    dr2 = objCmd2.ExecuteReader();
                    dr2.Read();

                    txt_VeiculoPesquisa.Text = dr2.GetString(0);
                    txt_CorPesquisa.Text = dr2.GetString(2);
                    txt_PrecoPesquisa.Text = dr2.GetDouble(3).ToString("C", CultureInfo.CurrentCulture);
                    txt_AnoPesquisa.Text = dr2.GetString(4);
                    txt_proprietarioPesq.Text = dr2.GetString(5);


                    objcon.Close();
                }

                catch (Exception erro)
                {
                    MessageBox.Show("CARRO NÃO ENCONTRADO NOS CONSIGNADOS!");
                    txtPlaca.Text = "";
                    txtPlaca.Focus();
                }
                
            }

            


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
