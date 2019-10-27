namespace ProjetoCarro
{
    partial class Lucro
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
            this.txt_LucroLoja = new System.Windows.Forms.TextBox();
            this.txt_LucroConsignado = new System.Windows.Forms.TextBox();
            this.txt_lucroTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AtualizarLucros = new System.Windows.Forms.Button();
            this.button_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUCRO DE VEICULOS DA LOJA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LUCRO DE VEICULOS CONSIGNADOS:";
            // 
            // txt_LucroLoja
            // 
            this.txt_LucroLoja.Enabled = false;
            this.txt_LucroLoja.Location = new System.Drawing.Point(341, 12);
            this.txt_LucroLoja.Name = "txt_LucroLoja";
            this.txt_LucroLoja.Size = new System.Drawing.Size(212, 26);
            this.txt_LucroLoja.TabIndex = 2;
            // 
            // txt_LucroConsignado
            // 
            this.txt_LucroConsignado.Enabled = false;
            this.txt_LucroConsignado.Location = new System.Drawing.Point(341, 66);
            this.txt_LucroConsignado.Name = "txt_LucroConsignado";
            this.txt_LucroConsignado.Size = new System.Drawing.Size(212, 26);
            this.txt_LucroConsignado.TabIndex = 3;
            // 
            // txt_lucroTotal
            // 
            this.txt_lucroTotal.Enabled = false;
            this.txt_lucroTotal.Location = new System.Drawing.Point(341, 121);
            this.txt_lucroTotal.Name = "txt_lucroTotal";
            this.txt_lucroTotal.Size = new System.Drawing.Size(212, 26);
            this.txt_lucroTotal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "LUCRO TOTAL:";
            // 
            // button_AtualizarLucros
            // 
            this.button_AtualizarLucros.Location = new System.Drawing.Point(604, 33);
            this.button_AtualizarLucros.Name = "button_AtualizarLucros";
            this.button_AtualizarLucros.Size = new System.Drawing.Size(132, 46);
            this.button_AtualizarLucros.TabIndex = 1;
            this.button_AtualizarLucros.Text = "ATUALIZAR";
            this.button_AtualizarLucros.UseVisualStyleBackColor = true;
            this.button_AtualizarLucros.Click += new System.EventHandler(this.button_AtualizarLucros_Click);
            // 
            // button_Voltar
            // 
            this.button_Voltar.Location = new System.Drawing.Point(604, 99);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(132, 48);
            this.button_Voltar.TabIndex = 2;
            this.button_Voltar.Text = "VOLTAR";
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // Lucro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 188);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.button_AtualizarLucros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_lucroTotal);
            this.Controls.Add(this.txt_LucroConsignado);
            this.Controls.Add(this.txt_LucroLoja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lucro";
            this.Text = "Lucro";
            this.Load += new System.EventHandler(this.Lucro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LucroLoja;
        private System.Windows.Forms.TextBox txt_LucroConsignado;
        private System.Windows.Forms.TextBox txt_lucroTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AtualizarLucros;
        private System.Windows.Forms.Button button_Voltar;
    }
}