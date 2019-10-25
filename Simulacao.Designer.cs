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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF:";
            // 
            // txt_Simulacao
            // 
            this.txt_Simulacao.Location = new System.Drawing.Point(145, 46);
            this.txt_Simulacao.Name = "txt_Simulacao";
            this.txt_Simulacao.Size = new System.Drawing.Size(171, 22);
            this.txt_Simulacao.TabIndex = 3;
            // 
            // button_Simulacao
            // 
            this.button_Simulacao.Location = new System.Drawing.Point(340, 29);
            this.button_Simulacao.Name = "button_Simulacao";
            this.button_Simulacao.Size = new System.Drawing.Size(92, 56);
            this.button_Simulacao.TabIndex = 4;
            this.button_Simulacao.Text = "SIMULAR";
            this.button_Simulacao.UseVisualStyleBackColor = true;
            this.button_Simulacao.Click += new System.EventHandler(this.Button_Simulacao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço Maximo liberado para financiamento";
            // 
            // txt_ResultSimulacao
            // 
            this.txt_ResultSimulacao.Enabled = false;
            this.txt_ResultSimulacao.Location = new System.Drawing.Point(193, 184);
            this.txt_ResultSimulacao.Name = "txt_ResultSimulacao";
            this.txt_ResultSimulacao.Size = new System.Drawing.Size(171, 22);
            this.txt_ResultSimulacao.TabIndex = 6;
            // 
            // button_VoltarSimulacao
            // 
            this.button_VoltarSimulacao.Location = new System.Drawing.Point(456, 197);
            this.button_VoltarSimulacao.Name = "button_VoltarSimulacao";
            this.button_VoltarSimulacao.Size = new System.Drawing.Size(83, 45);
            this.button_VoltarSimulacao.TabIndex = 7;
            this.button_VoltarSimulacao.Text = "VOLTAR";
            this.button_VoltarSimulacao.UseVisualStyleBackColor = true;
            this.button_VoltarSimulacao.Click += new System.EventHandler(this.Button_VoltarSimulacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "SCORE ATUAL:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(296, 96);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(68, 17);
            this.label_score.TabIndex = 9;
            this.label_score.Text = "------------";
            // 
            // button_limparSimulacao
            // 
            this.button_limparSimulacao.Location = new System.Drawing.Point(471, 37);
            this.button_limparSimulacao.Name = "button_limparSimulacao";
            this.button_limparSimulacao.Size = new System.Drawing.Size(81, 40);
            this.button_limparSimulacao.TabIndex = 10;
            this.button_limparSimulacao.Text = "LIMPAR";
            this.button_limparSimulacao.UseVisualStyleBackColor = true;
            this.button_limparSimulacao.Click += new System.EventHandler(this.Button_limparSimulacao_Click);
            // 
            // Simulacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 254);
            this.Controls.Add(this.button_limparSimulacao);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_VoltarSimulacao);
            this.Controls.Add(this.txt_ResultSimulacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Simulacao);
            this.Controls.Add(this.txt_Simulacao);
            this.Controls.Add(this.label1);
            this.Name = "Simulacao";
            this.Text = "Simulacao";
            this.Load += new System.EventHandler(this.Simulacao_Load);
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
    }
}