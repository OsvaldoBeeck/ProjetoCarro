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
    public partial class telaInicio : Form
    {
        public telaInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        public void BtnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "fors";
            string senhaofc = "admin";

            if (String.Equals(usuario, txtUser.Text) && String.Equals(senhaofc, txtPassword.Text))
            {
                
                this.Hide();
                Telainicial telainicial = new Telainicial();
                telainicial.Show();

            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos!!!");
            }
        }
    }
}
