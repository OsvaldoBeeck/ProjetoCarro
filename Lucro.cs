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
    public partial class Lucro : Form
    {
        public Lucro()
        {
            InitializeComponent();
        }

        private void Lucro_Load(object sender, EventArgs e)
        {

        }

        private void button_AtualizarLucros_Click(object sender, EventArgs e)
        {
            try
            {


                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userid=root;database=dados_veiculos; password=");
                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("SELECT `Loja`, `Consignado`  FROM `Lucro`", objcon);

 
                objCmd.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();

                double lucroLoja;
                double lucroConsignado;
                double lucroTotal;

                lucroLoja = dr.GetDouble(0);
                lucroConsignado = dr.GetDouble(1);

                lucroLoja = lucroLoja * 0.1;

                lucroTotal = lucroLoja + lucroConsignado;

                txt_LucroLoja.Text = lucroLoja.ToString("C", CultureInfo.CurrentCulture);
                txt_LucroConsignado.Text = lucroConsignado.ToString("C", CultureInfo.CurrentCulture);
                txt_lucroTotal.Text = lucroTotal.ToString("C", CultureInfo.CurrentCulture);

            }
            catch (Exception erro)
            {
                MessageBox.Show("NÃO FOI POSSIVEL ATUALIZAR!");
            }
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            Telainicial telainicial = new Telainicial();
            this.Hide();
            telainicial.Show();
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
