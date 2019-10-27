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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaPlaca));
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_Consig = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_proprietarioPesq = new System.Windows.Forms.TextBox();
            this.radioButton_Loja = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa por Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(220, 101);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(110, 26);
            this.txtPlaca.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Location = new System.Drawing.Point(353, 90);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 50);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "VEICULO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "COR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "PREÇO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ANO:";
            // 
            // txt_AnoPesquisa
            // 
            this.txt_AnoPesquisa.Enabled = false;
            this.txt_AnoPesquisa.Location = new System.Drawing.Point(154, 276);
            this.txt_AnoPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AnoPesquisa.Name = "txt_AnoPesquisa";
            this.txt_AnoPesquisa.Size = new System.Drawing.Size(129, 26);
            this.txt_AnoPesquisa.TabIndex = 4;
            // 
            // txt_CorPesquisa
            // 
            this.txt_CorPesquisa.Enabled = false;
            this.txt_CorPesquisa.Location = new System.Drawing.Point(154, 225);
            this.txt_CorPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CorPesquisa.Name = "txt_CorPesquisa";
            this.txt_CorPesquisa.Size = new System.Drawing.Size(248, 26);
            this.txt_CorPesquisa.TabIndex = 3;
            this.txt_CorPesquisa.TextChanged += new System.EventHandler(this.txt_CorPesquisa_TextChanged);
            // 
            // txt_PrecoPesquisa
            // 
            this.txt_PrecoPesquisa.Enabled = false;
            this.txt_PrecoPesquisa.Location = new System.Drawing.Point(154, 326);
            this.txt_PrecoPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PrecoPesquisa.Name = "txt_PrecoPesquisa";
            this.txt_PrecoPesquisa.Size = new System.Drawing.Size(129, 26);
            this.txt_PrecoPesquisa.TabIndex = 5;
            // 
            // txt_VeiculoPesquisa
            // 
            this.txt_VeiculoPesquisa.Enabled = false;
            this.txt_VeiculoPesquisa.Location = new System.Drawing.Point(154, 171);
            this.txt_VeiculoPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_VeiculoPesquisa.Name = "txt_VeiculoPesquisa";
            this.txt_VeiculoPesquisa.Size = new System.Drawing.Size(248, 26);
            this.txt_VeiculoPesquisa.TabIndex = 2;
            // 
            // Button_EditarCadastro
            // 
            this.Button_EditarCadastro.Location = new System.Drawing.Point(520, 431);
            this.Button_EditarCadastro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_EditarCadastro.Name = "Button_EditarCadastro";
            this.Button_EditarCadastro.Size = new System.Drawing.Size(98, 56);
            this.Button_EditarCadastro.TabIndex = 9;
            this.Button_EditarCadastro.Text = "EDITAR";
            this.Button_EditarCadastro.UseVisualStyleBackColor = true;
            this.Button_EditarCadastro.Click += new System.EventHandler(this.Button_EditarCadastro_Click);
            // 
            // Button_SalvarPlaca
            // 
            this.Button_SalvarPlaca.Location = new System.Drawing.Point(403, 429);
            this.Button_SalvarPlaca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_SalvarPlaca.Name = "Button_SalvarPlaca";
            this.Button_SalvarPlaca.Size = new System.Drawing.Size(98, 59);
            this.Button_SalvarPlaca.TabIndex = 7;
            this.Button_SalvarPlaca.Text = "SALVAR";
            this.Button_SalvarPlaca.UseVisualStyleBackColor = true;
            this.Button_SalvarPlaca.Visible = false;
            this.Button_SalvarPlaca.Click += new System.EventHandler(this.Button_SalvarPlaca_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(520, 348);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(98, 56);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "PLACA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 19;
            // 
            // radioButton_Consig
            // 
            this.radioButton_Consig.AutoSize = true;
            this.radioButton_Consig.Enabled = false;
            this.radioButton_Consig.Location = new System.Drawing.Point(332, 321);
            this.radioButton_Consig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Consig.Name = "radioButton_Consig";
            this.radioButton_Consig.Size = new System.Drawing.Size(143, 24);
            this.radioButton_Consig.TabIndex = 20;
            this.radioButton_Consig.TabStop = true;
            this.radioButton_Consig.Text = "CONSIGNADO";
            this.radioButton_Consig.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "PROPRIETARIO:";
            // 
            // txt_proprietarioPesq
            // 
            this.txt_proprietarioPesq.Enabled = false;
            this.txt_proprietarioPesq.Location = new System.Drawing.Point(154, 379);
            this.txt_proprietarioPesq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_proprietarioPesq.Name = "txt_proprietarioPesq";
            this.txt_proprietarioPesq.Size = new System.Drawing.Size(314, 26);
            this.txt_proprietarioPesq.TabIndex = 6;
            // 
            // radioButton_Loja
            // 
            this.radioButton_Loja.AutoSize = true;
            this.radioButton_Loja.Enabled = false;
            this.radioButton_Loja.Location = new System.Drawing.Point(332, 276);
            this.radioButton_Loja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Loja.Name = "radioButton_Loja";
            this.radioButton_Loja.Size = new System.Drawing.Size(74, 24);
            this.radioButton_Loja.TabIndex = 23;
            this.radioButton_Loja.TabStop = true;
            this.radioButton_Loja.Text = "LOJA";
            this.radioButton_Loja.UseVisualStyleBackColor = true;
            // 
            // PesquisaPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 502);
            this.Controls.Add(this.radioButton_Loja);
            this.Controls.Add(this.txt_proprietarioPesq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton_Consig);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton_Consig;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_proprietarioPesq;
        private System.Windows.Forms.RadioButton radioButton_Loja;
    }
}