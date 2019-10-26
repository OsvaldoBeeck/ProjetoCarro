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
            imageLogo.Show();
       
        }

        public void BtnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "fors";
            string senhaofc = "admin";

            if (String.Equals(usuario, txtUser.Text) && String.Equals(senhaofc, txtPassword.Text))
            {               
                xuiObjectAnimator1.FormAnimate(this, XanderUI.XUIObjectAnimator.FormAnimation.FadeOut, 10);
                Telainicial telainicial = new Telainicial();
                this.Hide();
                telainicial.Show();        }
            else
            {   
                MessageBox.Show("Usuário e/ou senha incorretos!!!");
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
            }



        }

        private void PictureFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
