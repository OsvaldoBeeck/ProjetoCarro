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

                MySqlCommand objCmd = new MySqlCommand("INSERT INTO veiculos (`Nome`, `Placa`, `Cor`, `Preco` , `Ano`, `Cpf_Propietario` ,`Propietario`,`Tipo`,`Taxa`,`Status` ) VALUES(?,?,?, ?,?, ?, ?,?,?,?)", objcon);

                string tipo =  "------";
                double taxa = 0;
                string proprietario = "------";
                string cpf = "------";

              

                if (radioButton_LOJA.Checked == true)
                {
                    tipo = "LOJA";
                }
               else
                {
                    tipo = "CONSIGNADO";
                    taxa = Double.Parse(txt_Taxa.Text);
                    proprietario = txt_Proprietario.Text;
                    cpf = txt_CPF.Text;
                }
               


                objCmd.Parameters.Add("@nome_veiculo", MySqlDbType.VarChar, 60).Value = nomeVeiculo.Text;
                objCmd.Parameters.Add("@placa_veiculo", MySqlDbType.VarChar, 60).Value = placaVeiculo.Text;
                objCmd.Parameters.Add("@cor_veiculo", MySqlDbType.VarChar, 60).Value = corVeiculo.Text;
                double auxiliar;
                auxiliar = Double.Parse(txt_Taxa.Text) + Double.Parse(precoVeiculo.Text);
                objCmd.Parameters.Add("@preco_veiculo", MySqlDbType.Double).Value = auxiliar;
                objCmd.Parameters.Add("@ano_veiculo", MySqlDbType.Int32).Value = txtAno.Text;
                objCmd.Parameters.Add("@Cpf_Propietario", MySqlDbType.VarChar, 12).Value = cpf;
                objCmd.Parameters.Add("@Propietario", MySqlDbType.VarChar, 50).Value = proprietario;
                objCmd.Parameters.Add("@Tipo", MySqlDbType.VarChar, 12).Value = tipo;
                objCmd.Parameters.Add("@Taxa", MySqlDbType.Double).Value = taxa;
                objCmd.Parameters.Add("@Status", MySqlDbType.VarChar, 12).Value = "DISPONIVEL";





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

        private void radioButton_Consignado_CheckedChanged(object sender, EventArgs e)
        {
            
                txt_Proprietario.Enabled = true;
                txt_CPF.Enabled = true;
                txt_Taxa.Enabled = true;
                txt_Proprietario.Text = " ";
                txt_CPF.Text = " ";
                txt_Taxa.Text = " ";

        }

        private void radioButton_LOJA_CheckedChanged(object sender, EventArgs e)
        {

            txt_Proprietario.Enabled = false;
            txt_CPF.Enabled = false;
            txt_Taxa.Enabled = false;
            txt_Proprietario.Text = "------";
            txt_CPF.Text = "------";
            txt_Taxa.Text = "0";
        }

        private void PictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
