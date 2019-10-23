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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLACA:";
            // 
            // txt_PlacaVenda
            // 
            this.txt_PlacaVenda.Location = new System.Drawing.Point(101, 28);
            this.txt_PlacaVenda.Name = "txt_PlacaVenda";
            this.txt_PlacaVenda.Size = new System.Drawing.Size(119, 22);
            this.txt_PlacaVenda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "VEÍCULO:";
            // 
            // txt_VeiculoVenda
            // 
            this.txt_VeiculoVenda.Enabled = false;
            this.txt_VeiculoVenda.Location = new System.Drawing.Point(101, 81);
            this.txt_VeiculoVenda.Name = "txt_VeiculoVenda";
            this.txt_VeiculoVenda.Size = new System.Drawing.Size(205, 22);
            this.txt_VeiculoVenda.TabIndex = 3;
            // 
            // btnBuscaVender
            // 
            this.btnBuscaVender.AllowDrop = true;
            this.btnBuscaVender.AutoEllipsis = true;
            this.btnBuscaVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscaVender.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaVender.Image")));
            this.btnBuscaVender.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscaVender.Location = new System.Drawing.Point(238, 19);
            this.btnBuscaVender.Name = "btnBuscaVender";
            this.btnBuscaVender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBuscaVender.Size = new System.Drawing.Size(82, 31);
            this.btnBuscaVender.TabIndex = 4;
            this.btnBuscaVender.Text = "BUSCAR";
            this.btnBuscaVender.UseVisualStyleBackColor = true;
            this.btnBuscaVender.Click += new System.EventHandler(this.BtnBuscaVender_Click);
            // 
            // txt_CorVenda
            // 
            this.txt_CorVenda.Enabled = false;
            this.txt_CorVenda.Location = new System.Drawing.Point(371, 76);
            this.txt_CorVenda.Name = "txt_CorVenda";
            this.txt_CorVenda.Size = new System.Drawing.Size(156, 22);
            this.txt_CorVenda.TabIndex = 5;
            // 
            // txt_PrecoVenda
            // 
            this.txt_PrecoVenda.Enabled = false;
            this.txt_PrecoVenda.Location = new System.Drawing.Point(101, 134);
            this.txt_PrecoVenda.Name = "txt_PrecoVenda";
            this.txt_PrecoVenda.Size = new System.Drawing.Size(119, 22);
            this.txt_PrecoVenda.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "COR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "PREÇO:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // AnoVenda
            // 
            this.AnoVenda.AutoSize = true;
            this.AnoVenda.Location = new System.Drawing.Point(569, 83);
            this.AnoVenda.Name = "AnoVenda";
            this.AnoVenda.Size = new System.Drawing.Size(42, 17);
            this.AnoVenda.TabIndex = 9;
            this.AnoVenda.Text = "ANO:";
            // 
            // txt_AnoVenda
            // 
            this.txt_AnoVenda.Enabled = false;
            this.txt_AnoVenda.Location = new System.Drawing.Point(632, 78);
            this.txt_AnoVenda.Name = "txt_AnoVenda";
            this.txt_AnoVenda.Size = new System.Drawing.Size(119, 22);
            this.txt_AnoVenda.TabIndex = 10;
            // 
            // Button_VoltarVenda
            // 
            this.Button_VoltarVenda.Location = new System.Drawing.Point(262, 281);
            this.Button_VoltarVenda.Name = "Button_VoltarVenda";
            this.Button_VoltarVenda.Size = new System.Drawing.Size(91, 48);
            this.Button_VoltarVenda.TabIndex = 11;
            this.Button_VoltarVenda.Text = "VOLTAR";
            this.Button_VoltarVenda.UseVisualStyleBackColor = true;
            this.Button_VoltarVenda.Click += new System.EventHandler(this.Button_VoltarVenda_Click);
            // 
            // Button_Vender
            // 
            this.Button_Vender.Location = new System.Drawing.Point(436, 281);
            this.Button_Vender.Name = "Button_Vender";
            this.Button_Vender.Size = new System.Drawing.Size(91, 48);
            this.Button_Vender.TabIndex = 12;
            this.Button_Vender.Text = "VENDER";
            this.Button_Vender.UseVisualStyleBackColor = true;
            this.Button_Vender.Click += new System.EventHandler(this.Button_Vender_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "CLIENTE:";
            // 
            // txt_ClienteVenda
            // 
            this.txt_ClienteVenda.Location = new System.Drawing.Point(371, 132);
            this.txt_ClienteVenda.Name = "txt_ClienteVenda";
            this.txt_ClienteVenda.Size = new System.Drawing.Size(380, 22);
            this.txt_ClienteVenda.TabIndex = 14;
            // 
            // txt_TelefoneVenda
            // 
            this.txt_TelefoneVenda.Location = new System.Drawing.Point(101, 183);
            this.txt_TelefoneVenda.Name = "txt_TelefoneVenda";
            this.txt_TelefoneVenda.Size = new System.Drawing.Size(142, 22);
            this.txt_TelefoneVenda.TabIndex = 15;
            // 
            // txt_EnderecoVenda
            // 
            this.txt_EnderecoVenda.Location = new System.Drawing.Point(371, 185);
            this.txt_EnderecoVenda.Name = "txt_EnderecoVenda";
            this.txt_EnderecoVenda.Size = new System.Drawing.Size(380, 22);
            this.txt_EnderecoVenda.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "TELEFONE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "ENDEREÇO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "DATA:";
            // 
            // Date_Venda
            // 
            this.Date_Venda.Location = new System.Drawing.Point(101, 227);
            this.Date_Venda.Name = "Date_Venda";
            this.Date_Venda.Size = new System.Drawing.Size(289, 22);
            this.Date_Venda.TabIndex = 20;
            // 
            // VenderVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 361);
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
            this.Name = "VenderVeiculos";
            this.Text = "VenderVeiculos";
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
    }
}