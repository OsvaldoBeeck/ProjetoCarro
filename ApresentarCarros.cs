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
    public partial class ApresentarCarros : Form
    {
        public ApresentarCarros()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_Buscar.Text == "")
                MessageBox.Show("INFORME QUAL VEICULO DESEJA BUSCAR!");
            else
            {


                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM veiculos WHERE Nome = ? and Status = 'DISPONIVEL'", conn);
                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 60).Value = txt_Buscar.Text;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("veiculos");
                da.Fill(table);


                ListViewItem iItem;

                for (int i = 0; i < dataGrid_Apresentar.RowCount; i++)
                {
                    dataGrid_Apresentar.Rows[i].DataGridView.Columns.Clear();
                }


                foreach (DataRow row in table.Rows)
                {
                    iItem = new ListViewItem();

                    foreach (DataColumn c in table.Columns)
                    {

                    }

                    dataGrid_Apresentar.DataSource = table;
                    for (int i = 0; i < dataGrid_Apresentar.RowCount; i++)
                    {
                        dataGrid_Apresentar.Rows[i].ReadOnly = true;
                    }

                }
                if (dataGrid_Apresentar.RowCount == 0)
                    MessageBox.Show("NÃO EXISTE ESSE VEICULO NO BANCO DE DADOS!");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Telainicial telainicial = new Telainicial();
            telainicial.Show();
        }

        private void button_LISTAR_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM veiculos WHERE Status = 'DISPONIVEL'" , conn);
            

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("veiculos");
            da.Fill(table);


            ListViewItem iItem;

            for (int i = 0; i < dataGrid_Apresentar.RowCount; i++)
            {
                dataGrid_Apresentar.Rows[i].DataGridView.Columns.Clear();
            }


            foreach (DataRow row in table.Rows)
            {
                iItem = new ListViewItem();

                foreach (DataColumn c in table.Columns)
                {

                }

                dataGrid_Apresentar.DataSource = table;
                for (int i = 0; i < dataGrid_Apresentar.RowCount; i++)
                {
                    dataGrid_Apresentar.Rows[i].ReadOnly = true;
                }
               

            }
            if (dataGrid_Apresentar.RowCount == 0)
                MessageBox.Show("NÃO HÁ CARROS DISPONIVEIS CADASTRADOS!");
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
