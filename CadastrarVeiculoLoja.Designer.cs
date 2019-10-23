namespace ProjetoCarro
{
    partial class CadastrarVeiculoLoja
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nomeVeiculo = new System.Windows.Forms.TextBox();
            this.kmVeiculo = new System.Windows.Forms.TextBox();
            this.precoVeiculo = new System.Windows.Forms.TextBox();
            this.corVeiculo = new System.Windows.Forms.TextBox();
            this.placaVeiculo = new System.Windows.Forms.TextBox();
            this.cmbAnoVeiculo = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Km:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ano:";
            // 
            // nomeVeiculo
            // 
            this.nomeVeiculo.Location = new System.Drawing.Point(209, 58);
            this.nomeVeiculo.Name = "nomeVeiculo";
            this.nomeVeiculo.Size = new System.Drawing.Size(187, 22);
            this.nomeVeiculo.TabIndex = 1;
            // 
            // kmVeiculo
            // 
            this.kmVeiculo.Location = new System.Drawing.Point(209, 302);
            this.kmVeiculo.Name = "kmVeiculo";
            this.kmVeiculo.Size = new System.Drawing.Size(187, 22);
            this.kmVeiculo.TabIndex = 5;
            // 
            // precoVeiculo
            // 
            this.precoVeiculo.Location = new System.Drawing.Point(209, 238);
            this.precoVeiculo.Name = "precoVeiculo";
            this.precoVeiculo.Size = new System.Drawing.Size(187, 22);
            this.precoVeiculo.TabIndex = 4;
            // 
            // corVeiculo
            // 
            this.corVeiculo.Location = new System.Drawing.Point(209, 178);
            this.corVeiculo.Name = "corVeiculo";
            this.corVeiculo.Size = new System.Drawing.Size(187, 22);
            this.corVeiculo.TabIndex = 3;
            this.corVeiculo.TextChanged += new System.EventHandler(this.CorVeiculo_TextChanged);
            // 
            // placaVeiculo
            // 
            this.placaVeiculo.Location = new System.Drawing.Point(209, 122);
            this.placaVeiculo.Name = "placaVeiculo";
            this.placaVeiculo.Size = new System.Drawing.Size(187, 22);
            this.placaVeiculo.TabIndex = 2;
            // 
            // cmbAnoVeiculo
            // 
            this.cmbAnoVeiculo.FormattingEnabled = true;
            this.cmbAnoVeiculo.Location = new System.Drawing.Point(526, 59);
            this.cmbAnoVeiculo.Name = "cmbAnoVeiculo";
            this.cmbAnoVeiculo.Size = new System.Drawing.Size(121, 24);
            this.cmbAnoVeiculo.TabIndex = 6;
            this.cmbAnoVeiculo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(435, 374);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(183, 46);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(201, 374);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(162, 45);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // CadastrarVeiculoLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cmbAnoVeiculo);
            this.Controls.Add(this.placaVeiculo);
            this.Controls.Add(this.corVeiculo);
            this.Controls.Add(this.precoVeiculo);
            this.Controls.Add(this.kmVeiculo);
            this.Controls.Add(this.nomeVeiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarVeiculoLoja";
            this.Text = "Cadastrar veiculo da loja";
            this.Load += new System.EventHandler(this.CadastrarVeiculoLoja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomeVeiculo;
        private System.Windows.Forms.TextBox kmVeiculo;
        private System.Windows.Forms.TextBox precoVeiculo;
        private System.Windows.Forms.TextBox corVeiculo;
        private System.Windows.Forms.TextBox placaVeiculo;
        private System.Windows.Forms.ComboBox cmbAnoVeiculo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
    }
}