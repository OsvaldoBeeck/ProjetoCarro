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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lucro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LucroLoja = new System.Windows.Forms.TextBox();
            this.txt_LucroConsignado = new System.Windows.Forms.TextBox();
            this.txt_lucroTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AtualizarLucros = new System.Windows.Forms.Button();
            this.button_Voltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.label1.Location = new System.Drawing.Point(77, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUCRO DE VEICULOS DA LOJA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "LUCRO DE VEICULOS CONSIGNADOS:";
            // 
            // txt_LucroLoja
            // 
            this.txt_LucroLoja.Enabled = false;
            this.txt_LucroLoja.Location = new System.Drawing.Point(405, 127);
            this.txt_LucroLoja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LucroLoja.Name = "txt_LucroLoja";
            this.txt_LucroLoja.Size = new System.Drawing.Size(189, 22);
            this.txt_LucroLoja.TabIndex = 2;
            // 
            // txt_LucroConsignado
            // 
            this.txt_LucroConsignado.Enabled = false;
            this.txt_LucroConsignado.Location = new System.Drawing.Point(405, 171);
            this.txt_LucroConsignado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LucroConsignado.Name = "txt_LucroConsignado";
            this.txt_LucroConsignado.Size = new System.Drawing.Size(189, 22);
            this.txt_LucroConsignado.TabIndex = 3;
            // 
            // txt_lucroTotal
            // 
            this.txt_lucroTotal.Enabled = false;
            this.txt_lucroTotal.Location = new System.Drawing.Point(405, 215);
            this.txt_lucroTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_lucroTotal.Name = "txt_lucroTotal";
            this.txt_lucroTotal.Size = new System.Drawing.Size(189, 22);
            this.txt_lucroTotal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "LUCRO TOTAL:";
            // 
            // button_AtualizarLucros
            // 
            this.button_AtualizarLucros.Location = new System.Drawing.Point(392, 268);
            this.button_AtualizarLucros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AtualizarLucros.Name = "button_AtualizarLucros";
            this.button_AtualizarLucros.Size = new System.Drawing.Size(117, 37);
            this.button_AtualizarLucros.TabIndex = 1;
            this.button_AtualizarLucros.Text = "ATUALIZAR";
            this.button_AtualizarLucros.UseVisualStyleBackColor = true;
            this.button_AtualizarLucros.Click += new System.EventHandler(this.button_AtualizarLucros_Click);
            // 
            // button_Voltar
            // 
            this.button_Voltar.Location = new System.Drawing.Point(223, 268);
            this.button_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(117, 38);
            this.button_Voltar.TabIndex = 2;
            this.button_Voltar.Text = "VOLTAR";
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureMinimize);
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 78);
            this.panel1.TabIndex = 6;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(668, 0);
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
            this.pictureClose.Location = new System.Drawing.Point(704, 0);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(4);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(39, 35);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 11;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lucro";
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
            // Lucro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 327);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.button_AtualizarLucros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_lucroTotal);
            this.Controls.Add(this.txt_LucroConsignado);
            this.Controls.Add(this.txt_LucroLoja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lucro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucro";
            this.Load += new System.EventHandler(this.Lucro_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LucroLoja;
        private System.Windows.Forms.TextBox txt_LucroConsignado;
        private System.Windows.Forms.TextBox txt_lucroTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AtualizarLucros;
        private System.Windows.Forms.Button button_Voltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureMinimize;
    }
}