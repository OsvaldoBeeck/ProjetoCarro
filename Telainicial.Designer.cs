namespace ProjetoCarro
{
    partial class Telainicial
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
            this.btnCadastrarVeiculoLoja = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarVeiculoLoja
            // 
            this.btnCadastrarVeiculoLoja.Location = new System.Drawing.Point(42, 42);
            this.btnCadastrarVeiculoLoja.Name = "btnCadastrarVeiculoLoja";
            this.btnCadastrarVeiculoLoja.Size = new System.Drawing.Size(212, 65);
            this.btnCadastrarVeiculoLoja.TabIndex = 0;
            this.btnCadastrarVeiculoLoja.Text = "Cadastrar veículo loja";
            this.btnCadastrarVeiculoLoja.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculoLoja.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Vender veículo loja";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(576, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "Apresentar veículos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(42, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 65);
            this.button6.TabIndex = 5;
            this.button6.Text = "Cadastrar veículo consignado";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(576, 345);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(212, 65);
            this.button7.TabIndex = 6;
            this.button7.Text = "Histórico de vendas consignado";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(576, 274);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(212, 65);
            this.button8.TabIndex = 7;
            this.button8.Text = "Histórico de vendas loja";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(312, 133);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(212, 65);
            this.button9.TabIndex = 8;
            this.button9.Text = "Simulação";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(576, 42);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(212, 65);
            this.button10.TabIndex = 9;
            this.button10.Text = "Vender veículo consignado";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(312, 42);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(212, 65);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar veículo";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // Telainicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCadastrarVeiculoLoja);
            this.Name = "Telainicial";
            this.Text = "Página inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarVeiculoLoja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnPesquisar;
    }
}