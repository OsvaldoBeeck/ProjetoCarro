namespace ProjetoCarro
{
    partial class PesquisaPlaca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_AnoPesquisa = new System.Windows.Forms.TextBox();
            this.txt_CorPesquisa = new System.Windows.Forms.TextBox();
            this.txt_PrecoPesquisa = new System.Windows.Forms.TextBox();
            this.txt_VeiculoPesquisa = new System.Windows.Forms.TextBox();
            this.Button_EditarCadastro = new System.Windows.Forms.Button();
            this.Button_SalvarPlaca = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa por Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(196, 81);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(98, 22);
            this.txtPlaca.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(321, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "VEICULO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "COR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "PREÇO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "ANO:";
            // 
            // txt_AnoPesquisa
            // 
            this.txt_AnoPesquisa.Enabled = false;
            this.txt_AnoPesquisa.Location = new System.Drawing.Point(128, 226);
            this.txt_AnoPesquisa.Name = "txt_AnoPesquisa";
            this.txt_AnoPesquisa.Size = new System.Drawing.Size(115, 22);
            this.txt_AnoPesquisa.TabIndex = 11;
            // 
            // txt_CorPesquisa
            // 
            this.txt_CorPesquisa.Enabled = false;
            this.txt_CorPesquisa.Location = new System.Drawing.Point(128, 185);
            this.txt_CorPesquisa.Name = "txt_CorPesquisa";
            this.txt_CorPesquisa.Size = new System.Drawing.Size(221, 22);
            this.txt_CorPesquisa.TabIndex = 12;
            // 
            // txt_PrecoPesquisa
            // 
            this.txt_PrecoPesquisa.Enabled = false;
            this.txt_PrecoPesquisa.Location = new System.Drawing.Point(128, 266);
            this.txt_PrecoPesquisa.Name = "txt_PrecoPesquisa";
            this.txt_PrecoPesquisa.Size = new System.Drawing.Size(115, 22);
            this.txt_PrecoPesquisa.TabIndex = 13;
            // 
            // txt_VeiculoPesquisa
            // 
            this.txt_VeiculoPesquisa.Enabled = false;
            this.txt_VeiculoPesquisa.Location = new System.Drawing.Point(128, 142);
            this.txt_VeiculoPesquisa.Name = "txt_VeiculoPesquisa";
            this.txt_VeiculoPesquisa.Size = new System.Drawing.Size(221, 22);
            this.txt_VeiculoPesquisa.TabIndex = 14;
            // 
            // Button_EditarCadastro
            // 
            this.Button_EditarCadastro.Location = new System.Drawing.Point(462, 243);
            this.Button_EditarCadastro.Name = "Button_EditarCadastro";
            this.Button_EditarCadastro.Size = new System.Drawing.Size(87, 45);
            this.Button_EditarCadastro.TabIndex = 15;
            this.Button_EditarCadastro.Text = "EDITAR";
            this.Button_EditarCadastro.UseVisualStyleBackColor = true;
            this.Button_EditarCadastro.Click += new System.EventHandler(this.Button_EditarCadastro_Click);
            // 
            // Button_SalvarPlaca
            // 
            this.Button_SalvarPlaca.Location = new System.Drawing.Point(358, 241);
            this.Button_SalvarPlaca.Name = "Button_SalvarPlaca";
            this.Button_SalvarPlaca.Size = new System.Drawing.Size(87, 47);
            this.Button_SalvarPlaca.TabIndex = 16;
            this.Button_SalvarPlaca.Text = "SALVAR";
            this.Button_SalvarPlaca.UseVisualStyleBackColor = true;
            this.Button_SalvarPlaca.Visible = false;
            this.Button_SalvarPlaca.Click += new System.EventHandler(this.Button_SalvarPlaca_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(462, 176);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 45);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // PesquisaPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 318);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.Button_SalvarPlaca);
            this.Controls.Add(this.Button_EditarCadastro);
            this.Controls.Add(this.txt_VeiculoPesquisa);
            this.Controls.Add(this.txt_PrecoPesquisa);
            this.Controls.Add(this.txt_CorPesquisa);
            this.Controls.Add(this.txt_AnoPesquisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label1);
            this.Name = "PesquisaPlaca";
            this.Text = "PesquisaPlaca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_AnoPesquisa;
        private System.Windows.Forms.TextBox txt_CorPesquisa;
        private System.Windows.Forms.TextBox txt_PrecoPesquisa;
        private System.Windows.Forms.TextBox txt_VeiculoPesquisa;
        private System.Windows.Forms.Button Button_EditarCadastro;
        private System.Windows.Forms.Button Button_SalvarPlaca;
        private System.Windows.Forms.Button btnVoltar;
    }
}