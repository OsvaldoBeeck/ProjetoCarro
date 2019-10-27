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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulacao));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF:";
            // 
            // txt_Simulacao
            // 
            this.txt_Simulacao.Location = new System.Drawing.Point(276, 115);
            this.txt_Simulacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Simulacao.Name = "txt_Simulacao";
            this.txt_Simulacao.Size = new System.Drawing.Size(171, 22);
            this.txt_Simulacao.TabIndex = 1;
            // 
            // button_Simulacao
            // 
            this.button_Simulacao.Location = new System.Drawing.Point(470, 99);
            this.button_Simulacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Simulacao.Name = "button_Simulacao";
            this.button_Simulacao.Size = new System.Drawing.Size(92, 57);
            this.button_Simulacao.TabIndex = 2;
            this.button_Simulacao.Text = "SIMULAR";
            this.button_Simulacao.UseVisualStyleBackColor = true;
            this.button_Simulacao.Click += new System.EventHandler(this.Button_Simulacao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(598, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "PREÇO MÁXIMO LIBERADO PARA FINANCIAMENTO";
            // 
            // txt_ResultSimulacao
            // 
            this.txt_ResultSimulacao.Enabled = false;
            this.txt_ResultSimulacao.Location = new System.Drawing.Point(351, 276);
            this.txt_ResultSimulacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ResultSimulacao.Name = "txt_ResultSimulacao";
            this.txt_ResultSimulacao.Size = new System.Drawing.Size(171, 22);
            this.txt_ResultSimulacao.TabIndex = 6;
            // 
            // button_VoltarSimulacao
            // 
            this.button_VoltarSimulacao.Location = new System.Drawing.Point(746, 509);
            this.button_VoltarSimulacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_VoltarSimulacao.Name = "button_VoltarSimulacao";
            this.button_VoltarSimulacao.Size = new System.Drawing.Size(83, 46);
            this.button_VoltarSimulacao.TabIndex = 4;
            this.button_VoltarSimulacao.Text = "VOLTAR";
            this.button_VoltarSimulacao.UseVisualStyleBackColor = true;
            this.button_VoltarSimulacao.Click += new System.EventHandler(this.Button_VoltarSimulacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "SCORE ATUAL:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(453, 168);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(82, 21);
            this.label_score.TabIndex = 9;
            this.label_score.Text = "------------";
            // 
            // button_limparSimulacao
            // 
            this.button_limparSimulacao.Location = new System.Drawing.Point(590, 110);
            this.button_limparSimulacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_limparSimulacao.Name = "button_limparSimulacao";
            this.button_limparSimulacao.Size = new System.Drawing.Size(85, 38);
            this.button_limparSimulacao.TabIndex = 3;
            this.button_limparSimulacao.Text = "LIMPAR";
            this.button_limparSimulacao.UseVisualStyleBackColor = true;
            this.button_limparSimulacao.Click += new System.EventHandler(this.Button_limparSimulacao_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 319);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(805, 185);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(458, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "|";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "V";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(424, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "|";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureMinimize);
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 78);
            this.panel1.TabIndex = 18;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(774, 0);
            this.pictureMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(39, 35);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimize.TabIndex = 26;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.PictureMinimize_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(811, 0);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(4);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(39, 35);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 19;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 37);
            this.label10.TabIndex = 19;
            this.label10.Text = "Simulação";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Simulacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 574);
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Simulacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulacao";
            this.Load += new System.EventHandler(this.Simulacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureMinimize;
    }
}