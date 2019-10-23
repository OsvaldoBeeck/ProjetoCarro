using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Button1_Click(object sender, EventArgs e)
        {


            listView1.Items.Add("Veículo",0);
            listView1.Items.Add("Preço", 1);
            listView1.Items.Add("Valor", 2);
            listView1.Items.Add("Ano", 3);
        }
    }
}
