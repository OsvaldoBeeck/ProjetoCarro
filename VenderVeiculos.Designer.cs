namespace ProjetoCarro
{
    partial class VenderVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenderVeiculos));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PlacaVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_VeiculoVenda = new System.Windows.Forms.TextBox();
            this.btnBuscaVender = new System.Windows.Forms.Button();
            this.txt_CorVenda = new System.Windows.Forms.TextBox();
            this.txt_PrecoVenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AnoVenda = new System.Windows.Forms.Label();
            this.txt_AnoVenda = new System.Windows.Forms.TextBox();
            this.Button_VoltarVenda = new System.Windows.Forms.Button();
            this.Button_Vender = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ClienteVenda = new System.Windows.Forms.TextBox();
            this.txt_TelefoneVenda = new System.Windows.Forms.TextBox();
            this.txt_EnderecoVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Date_Venda = new System.Windows.Forms.DateTimePicker();
            this.radioButton_LOJA = new System.Windows.Forms.RadioButton();
            this.radioButton_CONSIGNADO = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLACA:";
            // 
            // txt_PlacaVenda
            // 
            this.txt_PlacaVenda.Location = new System.Drawing.Point(182, 131);
            this.txt_PlacaVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PlacaVenda.Name = "txt_PlacaVenda";
            this.txt_PlacaVenda.Size = new System.Drawing.Size(133, 26);
            this.txt_PlacaVenda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "VEÍCULO:";
            // 
            // txt_VeiculoVenda
            // 
            this.txt_VeiculoVenda.Enabled = false;
            this.txt_VeiculoVenda.Location = new System.Drawing.Point(182, 269);
            this.txt_VeiculoVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_VeiculoVenda.Name = "txt_VeiculoVenda";
            this.txt_VeiculoVenda.Size = new System.Drawing.Size(230, 26);
            this.txt_VeiculoVenda.TabIndex = 3;
            // 
            // btnBuscaVender
            // 
            this.btnBuscaVender.AllowDrop = true;
            this.btnBuscaVender.AutoEllipsis = true;
            this.btnBuscaVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscaVender.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaVender.Image")));
            this.btnBuscaVender.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscaVender.Location = new System.Drawing.Point(323, 126);
            this.btnBuscaVender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscaVender.Name = "btnBuscaVender";
            this.btnBuscaVender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBuscaVender.Size = new System.Drawing.Size(92, 39);
            this.btnBuscaVender.TabIndex = 4;
            this.btnBuscaVender.Text = "BUSCAR";
            this.btnBuscaVender.UseVisualStyleBackColor = true;
            this.btnBuscaVender.Click += new System.EventHandler(this.BtnBuscaVender_Click);
            // 
            // txt_CorVenda
            // 
            this.txt_CorVenda.Enabled = false;
            this.txt_CorVenda.Location = new System.Drawing.Point(558, 269);
            this.txt_CorVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CorVenda.Name = "txt_CorVenda";
            this.txt_CorVenda.Size = new System.Drawing.Size(175, 26);
            this.txt_CorVenda.TabIndex = 5;
            // 
            // txt_PrecoVenda
            // 
            this.txt_PrecoVenda.Enabled = false;
            this.txt_PrecoVenda.Location = new System.Drawing.Point(182, 328);
            this.txt_PrecoVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PrecoVenda.Name = "txt_PrecoVenda";
            this.txt_PrecoVenda.Size = new System.Drawing.Size(133, 26);
            this.txt_PrecoVenda.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "COR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "PREÇO:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // AnoVenda
            // 
            this.AnoVenda.AutoSize = true;
            this.AnoVenda.BackColor = System.Drawing.Color.Transparent;
            this.AnoVenda.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnoVenda.Location = new System.Drawing.Point(740, 259);
            this.AnoVenda.Name = "AnoVenda";
            this.AnoVenda.Size = new System.Drawing.Size(88, 34);
            this.AnoVenda.TabIndex = 9;
            this.AnoVenda.Text = "ANO:";
            // 
            // txt_AnoVenda
            // 
            this.txt_AnoVenda.Enabled = false;
            this.txt_AnoVenda.Location = new System.Drawing.Point(832, 269);
            this.txt_AnoVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AnoVenda.Name = "txt_AnoVenda";
            this.txt_AnoVenda.Size = new System.Drawing.Size(133, 26);
            this.txt_AnoVenda.TabIndex = 10;
            // 
            // Button_VoltarVenda
            // 
            this.Button_VoltarVenda.Location = new System.Drawing.Point(405, 515);
            this.Button_VoltarVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_VoltarVenda.Name = "Button_VoltarVenda";
            this.Button_VoltarVenda.Size = new System.Drawing.Size(102, 60);
            this.Button_VoltarVenda.TabIndex = 19;
            this.Button_VoltarVenda.Text = "VOLTAR";
            this.Button_VoltarVenda.UseVisualStyleBackColor = true;
            this.Button_VoltarVenda.Click += new System.EventHandler(this.Button_VoltarVenda_Click);
            // 
            // Button_Vender
            // 
            this.Button_Vender.Location = new System.Drawing.Point(601, 515);
            this.Button_Vender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Vender.Name = "Button_Vender";
            this.Button_Vender.Size = new System.Drawing.Size(102, 60);
            this.Button_Vender.TabIndex = 18;
            this.Button_Vender.Text = "VENDER";
            this.Button_Vender.UseVisualStyleBackColor = true;
            this.Button_Vender.Click += new System.EventHandler(this.Button_Vender_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "CLIENTE:";
            // 
            // txt_ClienteVenda
            // 
            this.txt_ClienteVenda.Location = new System.Drawing.Point(558, 325);
            this.txt_ClienteVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ClienteVenda.Name = "txt_ClienteVenda";
            this.txt_ClienteVenda.Size = new System.Drawing.Size(427, 26);
            this.txt_ClienteVenda.TabIndex = 14;
            // 
            // txt_TelefoneVenda
            // 
            this.txt_TelefoneVenda.Location = new System.Drawing.Point(182, 386);
            this.txt_TelefoneVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TelefoneVenda.Name = "txt_TelefoneVenda";
            this.txt_TelefoneVenda.Size = new System.Drawing.Size(159, 26);
            this.txt_TelefoneVenda.TabIndex = 15;
            // 
            // txt_EnderecoVenda
            // 
            this.txt_EnderecoVenda.Location = new System.Drawing.Point(558, 381);
            this.txt_EnderecoVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_EnderecoVenda.Name = "txt_EnderecoVenda";
            this.txt_EnderecoVenda.Size = new System.Drawing.Size(427, 26);
            this.txt_EnderecoVenda.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 34);
            this.label6.TabIndex = 17;
            this.label6.Text = "TELEFONE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 34);
            this.label7.TabIndex = 18;
            this.label7.Text = "ENDEREÇO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 34);
            this.label8.TabIndex = 19;
            this.label8.Text = "DATA:";
            // 
            // Date_Venda
            // 
            this.Date_Venda.Location = new System.Drawing.Point(182, 445);
            this.Date_Venda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Date_Venda.Name = "Date_Venda";
            this.Date_Venda.Size = new System.Drawing.Size(325, 26);
            this.Date_Venda.TabIndex = 17;
            // 
            // radioButton_LOJA
            // 
            this.radioButton_LOJA.AutoSize = true;
            this.radioButton_LOJA.Enabled = false;
            this.radioButton_LOJA.Location = new System.Drawing.Point(735, 171);
            this.radioButton_LOJA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_LOJA.Name = "radioButton_LOJA";
            this.radioButton_LOJA.Size = new System.Drawing.Size(74, 24);
            this.radioButton_LOJA.TabIndex = 21;
            this.radioButton_LOJA.TabStop = true;
            this.radioButton_LOJA.Text = "LOJA";
            this.radioButton_LOJA.UseVisualStyleBackColor = true;
            // 
            // radioButton_CONSIGNADO
            // 
            this.radioButton_CONSIGNADO.AutoSize = true;
            this.radioButton_CONSIGNADO.Enabled = false;
            this.radioButton_CONSIGNADO.Location = new System.Drawing.Point(848, 171);
            this.radioButton_CONSIGNADO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_CONSIGNADO.Name = "radioButton_CONSIGNADO";
            this.radioButton_CONSIGNADO.Size = new System.Drawing.Size(143, 24);
            this.radioButton_CONSIGNADO.TabIndex = 22;
            this.radioButton_CONSIGNADO.TabStop = true;
            this.radioButton_CONSIGNADO.Text = "CONSIGNADO";
            this.radioButton_CONSIGNADO.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureMinimize);
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 98);
            this.panel1.TabIndex = 23;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(979, 0);
            this.pictureMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(44, 44);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimize.TabIndex = 25;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.PictureMinimize_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(1020, 0);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(44, 44);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 24;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(397, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(287, 43);
            this.label9.TabIndex = 24;
            this.label9.Text = "Vender veículo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // VenderVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton_CONSIGNADO);
            this.Controls.Add(this.radioButton_LOJA);
            this.Controls.Add(this.Date_Venda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_EnderecoVenda);
            this.Controls.Add(this.txt_TelefoneVenda);
            this.Controls.Add(this.txt_ClienteVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_Vender);
            this.Controls.Add(this.Button_VoltarVenda);
            this.Controls.Add(this.txt_AnoVenda);
            this.Controls.Add(this.AnoVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PrecoVenda);
            this.Controls.Add(this.txt_CorVenda);
            this.Controls.Add(this.btnBuscaVender);
            this.Controls.Add(this.txt_VeiculoVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PlacaVenda);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VenderVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VenderVeiculos";
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
        private System.Windows.Forms.TextBox txt_PlacaVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_VeiculoVenda;
        private System.Windows.Forms.Button btnBuscaVender;
        private System.Windows.Forms.TextBox txt_CorVenda;
        private System.Windows.Forms.TextBox txt_PrecoVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AnoVenda;
        private System.Windows.Forms.TextBox txt_AnoVenda;
        private System.Windows.Forms.Button Button_VoltarVenda;
        private System.Windows.Forms.Button Button_Vender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ClienteVenda;
        private System.Windows.Forms.TextBox txt_TelefoneVenda;
        private System.Windows.Forms.TextBox txt_EnderecoVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Date_Venda;
        private System.Windows.Forms.RadioButton radioButton_LOJA;
        private System.Windows.Forms.RadioButton radioButton_CONSIGNADO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureMinimize;
    }
}