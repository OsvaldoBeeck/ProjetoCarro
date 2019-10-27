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
using MySql.Data.Types;
using MySql.Data.Common;

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

            double valor = 0; 

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
                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM veiculos WHERE preco <= ? and Status = 'DISPONIVEL'", conn);
                cmd.Parameters.Add("@valor", MySqlDbType.Double).Value = valor;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("veiculos");
                da.Fill(table);

          
                ListViewItem iItem;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].DataGridView.Columns.Clear();
                }

                foreach (DataRow row in table.Rows)
                {
                    iItem = new ListViewItem();
                    
                    foreach (DataColumn c in table.Columns)
                    {
                       
                    }

                    dataGridView1.DataSource = table;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].ReadOnly = true;
                    }

                }
                if (dataGridView1.RowCount == 0 && score > 100)
                    MessageBox.Show("NÃO HÁ CARROS COM O PREÇO ACESSIVEL AO SEU SCORE!");
            
            if (dataGridView1.RowCount == 0 && score <= 100)
                    MessageBox.Show("SCORE MUITO BAIXO PARA FINANCIAMENTO!");
            }


            button_Simulacao.Enabled = false;
         
           
            
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

            button_Simulacao.Enabled = true;

            dataGridView1.DataSource = "";
        }

        private void List_simular_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
