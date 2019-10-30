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
    public partial class HistoricoLoja : Form
    {
        public HistoricoLoja()
        {
            InitializeComponent();
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            Telainicial telainicial = new Telainicial();
            this.Hide();
            telainicial.Show();
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM vendas WHERE Tipo = 'LOJA' ", conn);


            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("vendas");
            da.Fill(table);


            ListViewItem iItem;

            for (int i = 0; i < dataGrid_Loja.RowCount; i++)
            {
                dataGrid_Loja.Rows[i].DataGridView.Columns.Clear();
            }


            foreach (DataRow row in table.Rows)
            {
                iItem = new ListViewItem();

                foreach (DataColumn c in table.Columns)
                {

                }

                dataGrid_Loja.DataSource = table;
                
                for (int i = 0; i < dataGrid_Loja.RowCount; i++)
                {
                    dataGrid_Loja.Rows[i].ReadOnly = true;
                }
                
            }
            if (dataGrid_Loja.RowCount == 0)
                MessageBox.Show("NÃO HOUVE VENDAS!");
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "")
                MessageBox.Show("INFORME O NOME DO CLIENTE QUE DESEJA BUSCAR A VENDA");
            else
            {


                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM vendas WHERE Cliente LIKE '%' @Nome '%' and Tipo = 'LOJA'", conn);
                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 60).Value = txt_Buscar.Text;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("vendas");
                da.Fill(table);


                ListViewItem iItem;

                for (int i = 0; i < dataGrid_Loja.RowCount; i++)
                {
                    dataGrid_Loja.Rows[i].DataGridView.Columns.Clear();
                }


                foreach (DataRow row in table.Rows)
                {
                    iItem = new ListViewItem();

                    foreach (DataColumn c in table.Columns)
                    {

                    }

                    dataGrid_Loja.DataSource = table;
                    for (int i = 0; i < dataGrid_Loja.RowCount; i++)
                    {
                        dataGrid_Loja.Rows[i].ReadOnly = true;
                    }

                }
                if (dataGrid_Loja.RowCount == 0)
                    MessageBox.Show("NÃO EXISTE ESSE VEICULO NO BANCO DE DADOS!");
            }
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
