namespace ProjetoCarro
{
    partial class Simulacao
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
            this.txt_Simulacao = new System.Windows.Forms.TextBox();
            this.button_Simulacao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ResultSimulacao = new System.Windows.Forms.TextBox();
            this.button_VoltarSimulacao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.button_limparSimulacao = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF:";
            // 
            // txt_Simulacao
            // 
            this.txt_Simulacao.Location = new System.Drawing.Point(176, 35);
            this.txt_Simulacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Simulacao.Name = "txt_Simulacao";
            this.txt_Simulacao.Size = new System.Drawing.Size(129, 20);
            this.txt_Simulacao.TabIndex = 3;
            // 
            // button_Simulacao
            // 
            this.button_Simulacao.Location = new System.Drawing.Point(322, 22);
            this.button_Simulacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Simulacao.Name = "button_Simulacao";
            this.button_Simulacao.Size = new System.Drawing.Size(69, 46);
            this.button_Simulacao.TabIndex = 4;
            this.button_Simulacao.Text = "SIMULAR";
            this.button_Simulacao.UseVisualStyleBackColor = true;
            this.button_Simulacao.Click += new System.EventHandler(this.Button_Simulacao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PREÇO MAXIMO LIBERADO PARA FINANCIAMENTO";
            // 
            // txt_ResultSimulacao
            // 
            this.txt_ResultSimulacao.Enabled = false;
            this.txt_ResultSimulacao.Location = new System.Drawing.Point(250, 160);
            this.txt_ResultSimulacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ResultSimulacao.Name = "txt_ResultSimulacao";
            this.txt_ResultSimulacao.Size = new System.Drawing.Size(129, 20);
            this.txt_ResultSimulacao.TabIndex = 6;
            // 
            // button_VoltarSimulacao
            // 
            this.button_VoltarSimulacao.Location = new System.Drawing.Point(554, 350);
            this.button_VoltarSimulacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_VoltarSimulacao.Name = "button_VoltarSimulacao";
            this.button_VoltarSimulacao.Size = new System.Drawing.Size(62, 37);
            this.button_VoltarSimulacao.TabIndex = 7;
            this.button_VoltarSimulacao.Text = "VOLTAR";
            this.button_VoltarSimulacao.UseVisualStyleBackColor = true;
            this.button_VoltarSimulacao.Click += new System.EventHandler(this.Button_VoltarSimulacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SCORE ATUAL:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(289, 76);
            this.label_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(43, 13);
            this.label_score.TabIndex = 9;
            this.label_score.Text = "------------";
            // 
            // button_limparSimulacao
            // 
            this.button_limparSimulacao.Location = new System.Drawing.Point(420, 28);
            this.button_limparSimulacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_limparSimulacao.Name = "button_limparSimulacao";
            this.button_limparSimulacao.Size = new System.Drawing.Size(61, 32);
            this.button_limparSimulacao.TabIndex = 10;
            this.button_limparSimulacao.Text = "LIMPAR";
            this.button_limparSimulacao.UseVisualStyleBackColor = true;
            this.button_limparSimulacao.Click += new System.EventHandler(this.Button_limparSimulacao_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "|";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "V";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(9, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "|";
            // 
            // Simulacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 389);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_limparSimulacao);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_VoltarSimulacao);
            this.Controls.Add(this.txt_ResultSimulacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Simulacao);
            this.Controls.Add(this.txt_Simulacao);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Simulacao";
            this.Text = "Simulacao";
            this.Load += new System.EventHandler(this.Simulacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Simulacao;
        private System.Windows.Forms.Button button_Simulacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ResultSimulacao;
        private System.Windows.Forms.Button button_VoltarSimulacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button button_limparSimulacao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}