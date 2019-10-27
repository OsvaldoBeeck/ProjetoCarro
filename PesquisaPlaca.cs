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
            txt_proprietarioPesq.Text = "";
            try
            {


                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("SELECT `Nome`, `Placa`, `Cor`, `Preco` , `Ano`, `Propietario` ,`Tipo`  FROM `veiculos` WHERE Placa =? and Status = 'DISPONIVEL'", objcon);

                objCmd.Parameters.Clear();

                objCmd.Parameters.Add("@Placa", MySqlDbType.VarChar, 8).Value = txtPlaca.Text;
                objCmd.CommandType = CommandType.Text;

                
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();


                string tipo;
                txt_VeiculoPesquisa.Text = dr.GetString(0);
                txt_CorPesquisa.Text = dr.GetString(2);
                txt_PrecoPesquisa.Text = dr.GetString(3);
                txt_AnoPesquisa.Text = dr.GetString(4);
                txt_proprietarioPesq.Text = dr.GetString(5);
                tipo = dr.GetString(6);

                if (tipo == "LOJA")
                {
                    radioButton_Loja.Checked = true;
                    radioButton_Consig.Checked = false;
                }

                else
                {
                    radioButton_Consig.Checked = true;
                    radioButton_Loja.Checked = false;
                }
                    


                

            }
            catch(Exception erro)
            {
                MessageBox.Show("CARRO NÃO ENCONTRADO!");
                txtPlaca.Text = "";
                txtPlaca.Focus();
            }

                
      


        }

        private void Button_EditarCadastro_Click(object sender, EventArgs e)
        {
            txt_VeiculoPesquisa.Enabled = true;
            txt_CorPesquisa.Enabled = true;
            txt_PrecoPesquisa.Enabled = true;
            txt_AnoPesquisa.Enabled = true;
            if (radioButton_Consig.Checked == true)
                txt_proprietarioPesq.Enabled = true;
            else
                txt_proprietarioPesq.Enabled = false;

            Button_SalvarPlaca.Visible = true;

        }

        private void Button_SalvarPlaca_Click(object sender, EventArgs e)
        {
            
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
            
            objcon.Open();

            MySqlCommand objCmd = new MySqlCommand("UPDATE veiculos SET Nome=?,Cor=?,Preco=?, Ano=?, Propietario=? WHERE Placa =? ", objcon);
            objCmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 60).Value = txt_VeiculoPesquisa.Text;
            objCmd.Parameters.Add("@Cor", MySqlDbType.VarChar, 60).Value = txt_CorPesquisa.Text;
            objCmd.Parameters.Add("@Preco", MySqlDbType.VarChar, 20).Value = txt_PrecoPesquisa.Text;
            objCmd.Parameters.Add("@Ano", MySqlDbType.VarChar, 20).Value = txt_AnoPesquisa.Text;
            objCmd.Parameters.Add("@Propietario", MySqlDbType.VarChar, 60).Value = txt_proprietarioPesq.Text;
            objCmd.Parameters.Add("@Placa", MySqlDbType.VarChar, 20).Value = txtPlaca.Text;
            

            objCmd.CommandType = CommandType.Text;
            objCmd.ExecuteNonQuery();

            objcon.Close();

            MessageBox.Show("Atualização concluída com sucesso!");


            txt_VeiculoPesquisa.Enabled = false;
            txt_CorPesquisa.Enabled = false;
            txt_PrecoPesquisa.Enabled = false;
            txt_AnoPesquisa.Enabled = false;
            txt_proprietarioPesq.Enabled = false;

            Button_SalvarPlaca.Visible = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Telainicial telaInicio = new Telainicial();
            this.Hide();
            telaInicio.Show();
            radioButton_Consig.Checked = false;
            radioButton_Loja.Checked = false;
        }

        private void txt_CorPesquisa_TextChanged(object sender, EventArgs e)
        {

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
