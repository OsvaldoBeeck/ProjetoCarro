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
    public partial class Simulacao : Form
    {
        public Simulacao()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Simulacao_Load(object sender, EventArgs e)
        {

        }

        

        private void Button_Simulacao_Click(object sender, EventArgs e)
        {

            Random numAleatorio = new Random();

            int score;

            score = numAleatorio.Next(0, 1000);

            double valor; 

            if (txt_Simulacao.Text.Length < 11 || txt_Simulacao.Text.Length > 11 )
            {
                MessageBox.Show("CPF INVALIDO, DIGITE NOVAMENTE!");
            }
            else
            {
                txt_Simulacao.Enabled = false;
                label_score.Text = score.ToString();
                if (score <= 100)
                {
                    valor = 0;
                    txt_ResultSimulacao.Text = valor.ToString("C", CultureInfo.CurrentCulture);
                    MessageBox.Show("SCORE MUITO BAIXO PARA FINANCIAMENTO!");
                }
                else if (score <= 300)
                {
                    valor = 7500;
                    txt_ResultSimulacao.Text = valor.ToString("C", CultureInfo.CurrentCulture);
                }
                else if (score <= 450)
                {
                    valor = 12000;
                    txt_ResultSimulacao.Text = valor.ToString("C", CultureInfo.CurrentCulture);
                }
                else if (score <= 650)
                {
                    valor = 16500;
                    txt_ResultSimulacao.Text = valor.ToString("C", CultureInfo.CurrentCulture);
                }
                else if (score <= 780)
                {
                    valor = 32700;
                    txt_ResultSimulacao.Text = valor.ToString("C", CultureInfo.CurrentCulture);
                }
                else if (score <= 900)
                {
                    valor = 55200;
                    txt_ResultSimulacao.Text = valor.ToString("C", CultureInfo.CurrentCulture);
                }
                else if (score > 800)
                {
                    valor = 10000000;
                    txt_ResultSimulacao.Text = valor.ToString("C", CultureInfo.CurrentCulture);
                    MessageBox.Show("VALOR ILIMITADO!");
                }
            }

           
           
            
        }

        private void Button_VoltarSimulacao_Click(object sender, EventArgs e)
        {
            Telainicial telainicial = new Telainicial();
            this.Hide();
            telainicial.Show();
        }

        private void Button_limparSimulacao_Click(object sender, EventArgs e)
        {
            txt_Simulacao.Text = "";
            label_score.Text = "------------";
            txt_ResultSimulacao.Text = "";
            txt_Simulacao.Enabled = true;
        }
    }
}
