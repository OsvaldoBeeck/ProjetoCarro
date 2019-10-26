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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telainicial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarVeiculoLoja = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCadastrarVeiculoConsignado = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPesquisarVeiculo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSimulacao = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVenderVeiculoLoja = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVenderVeiculoConsignado = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnApresentarVeiculos = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHistoricoDeVendasDaLoja = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHistoricoDeVendasConsignado = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSair = new MaterialSkin.Controls.MaterialFlatButton();
            this.xuiObjectAnimator1 = new XanderUI.XUIObjectAnimator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 64);
            this.panel1.TabIndex = 12;
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(787, 3);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(36, 35);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 1;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarVeiculoLoja
            // 
            this.btnCadastrarVeiculoLoja.AutoSize = true;
            this.btnCadastrarVeiculoLoja.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrarVeiculoLoja.Depth = 0;
            this.btnCadastrarVeiculoLoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarVeiculoLoja.Icon = null;
            this.btnCadastrarVeiculoLoja.Location = new System.Drawing.Point(60, 130);
            this.btnCadastrarVeiculoLoja.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrarVeiculoLoja.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrarVeiculoLoja.Name = "btnCadastrarVeiculoLoja";
            this.btnCadastrarVeiculoLoja.Primary = false;
            this.btnCadastrarVeiculoLoja.Size = new System.Drawing.Size(196, 36);
            this.btnCadastrarVeiculoLoja.TabIndex = 13;
            this.btnCadastrarVeiculoLoja.Text = "Cadastrar Veículo Loja";
            this.btnCadastrarVeiculoLoja.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculoLoja.Click += new System.EventHandler(this.btnCadastrarVeiculoLoja_Click);
            // 
            // btnCadastrarVeiculoConsignado
            // 
            this.btnCadastrarVeiculoConsignado.AutoSize = true;
            this.btnCadastrarVeiculoConsignado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrarVeiculoConsignado.Depth = 0;
            this.btnCadastrarVeiculoConsignado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarVeiculoConsignado.Icon = null;
            this.btnCadastrarVeiculoConsignado.Location = new System.Drawing.Point(60, 178);
            this.btnCadastrarVeiculoConsignado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrarVeiculoConsignado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrarVeiculoConsignado.Name = "btnCadastrarVeiculoConsignado";
            this.btnCadastrarVeiculoConsignado.Primary = false;
            this.btnCadastrarVeiculoConsignado.Size = new System.Drawing.Size(249, 36);
            this.btnCadastrarVeiculoConsignado.TabIndex = 14;
            this.btnCadastrarVeiculoConsignado.Text = "Cadastrar veículo consignado";
            this.btnCadastrarVeiculoConsignado.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculoConsignado.Click += new System.EventHandler(this.btnCadastrarVeiculoConsignado_Click);
            // 
            // btnPesquisarVeiculo
            // 
            this.btnPesquisarVeiculo.AutoSize = true;
            this.btnPesquisarVeiculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPesquisarVeiculo.Depth = 0;
            this.btnPesquisarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarVeiculo.Icon = null;
            this.btnPesquisarVeiculo.Location = new System.Drawing.Point(60, 226);
            this.btnPesquisarVeiculo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPesquisarVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPesquisarVeiculo.Name = "btnPesquisarVeiculo";
            this.btnPesquisarVeiculo.Primary = false;
            this.btnPesquisarVeiculo.Size = new System.Drawing.Size(153, 36);
            this.btnPesquisarVeiculo.TabIndex = 15;
            this.btnPesquisarVeiculo.Text = "Pesquisar Veículo";
            this.btnPesquisarVeiculo.UseVisualStyleBackColor = true;
            this.btnPesquisarVeiculo.Click += new System.EventHandler(this.btnPesquisarVeiculo_Click);
            // 
            // btnSimulacao
            // 
            this.btnSimulacao.AutoSize = true;
            this.btnSimulacao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSimulacao.Depth = 0;
            this.btnSimulacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSimulacao.Icon = null;
            this.btnSimulacao.Location = new System.Drawing.Point(60, 274);
            this.btnSimulacao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSimulacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSimulacao.Name = "btnSimulacao";
            this.btnSimulacao.Primary = false;
            this.btnSimulacao.Size = new System.Drawing.Size(98, 36);
            this.btnSimulacao.TabIndex = 16;
            this.btnSimulacao.Text = "Simulação";
            this.btnSimulacao.UseVisualStyleBackColor = true;
            this.btnSimulacao.Click += new System.EventHandler(this.btnSimulacao_Click);
            // 
            // btnVenderVeiculoLoja
            // 
            this.btnVenderVeiculoLoja.AutoSize = true;
            this.btnVenderVeiculoLoja.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVenderVeiculoLoja.Depth = 0;
            this.btnVenderVeiculoLoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenderVeiculoLoja.Icon = null;
            this.btnVenderVeiculoLoja.Location = new System.Drawing.Point(60, 322);
            this.btnVenderVeiculoLoja.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVenderVeiculoLoja.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVenderVeiculoLoja.Name = "btnVenderVeiculoLoja";
            this.btnVenderVeiculoLoja.Primary = false;
            this.btnVenderVeiculoLoja.Size = new System.Drawing.Size(169, 36);
            this.btnVenderVeiculoLoja.TabIndex = 17;
            this.btnVenderVeiculoLoja.Text = "Vender Veículo loja";
            this.btnVenderVeiculoLoja.UseVisualStyleBackColor = true;
            this.btnVenderVeiculoLoja.Click += new System.EventHandler(this.btnVenderVeiculoLoja_Click);
            // 
            // btnVenderVeiculoConsignado
            // 
            this.btnVenderVeiculoConsignado.AutoSize = true;
            this.btnVenderVeiculoConsignado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVenderVeiculoConsignado.Depth = 0;
            this.btnVenderVeiculoConsignado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenderVeiculoConsignado.Icon = null;
            this.btnVenderVeiculoConsignado.Location = new System.Drawing.Point(591, 215);
            this.btnVenderVeiculoConsignado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVenderVeiculoConsignado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVenderVeiculoConsignado.Name = "btnVenderVeiculoConsignado";
            this.btnVenderVeiculoConsignado.Primary = false;
            this.btnVenderVeiculoConsignado.Size = new System.Drawing.Size(222, 36);
            this.btnVenderVeiculoConsignado.TabIndex = 18;
            this.btnVenderVeiculoConsignado.Text = "Vender Veículo Consignado";
            this.btnVenderVeiculoConsignado.UseVisualStyleBackColor = true;
            this.btnVenderVeiculoConsignado.Click += new System.EventHandler(this.btnVenderVeiculoConsignado_Click);
            // 
            // btnApresentarVeiculos
            // 
            this.btnApresentarVeiculos.AutoSize = true;
            this.btnApresentarVeiculos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApresentarVeiculos.Depth = 0;
            this.btnApresentarVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApresentarVeiculos.Icon = null;
            this.btnApresentarVeiculos.Location = new System.Drawing.Point(639, 263);
            this.btnApresentarVeiculos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApresentarVeiculos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApresentarVeiculos.Name = "btnApresentarVeiculos";
            this.btnApresentarVeiculos.Primary = false;
            this.btnApresentarVeiculos.Size = new System.Drawing.Size(174, 36);
            this.btnApresentarVeiculos.TabIndex = 19;
            this.btnApresentarVeiculos.Text = "Apresentar Veículos";
            this.btnApresentarVeiculos.UseVisualStyleBackColor = true;
            this.btnApresentarVeiculos.Click += new System.EventHandler(this.BtnApresentarVeiculos_Click);
            // 
            // btnHistoricoDeVendasDaLoja
            // 
            this.btnHistoricoDeVendasDaLoja.AutoSize = true;
            this.btnHistoricoDeVendasDaLoja.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistoricoDeVendasDaLoja.Depth = 0;
            this.btnHistoricoDeVendasDaLoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistoricoDeVendasDaLoja.Icon = null;
            this.btnHistoricoDeVendasDaLoja.Location = new System.Drawing.Point(586, 311);
            this.btnHistoricoDeVendasDaLoja.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHistoricoDeVendasDaLoja.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHistoricoDeVendasDaLoja.Name = "btnHistoricoDeVendasDaLoja";
            this.btnHistoricoDeVendasDaLoja.Primary = false;
            this.btnHistoricoDeVendasDaLoja.Size = new System.Drawing.Size(227, 36);
            this.btnHistoricoDeVendasDaLoja.TabIndex = 20;
            this.btnHistoricoDeVendasDaLoja.Text = "Histórico de vendas da loja";
            this.btnHistoricoDeVendasDaLoja.UseVisualStyleBackColor = true;
            this.btnHistoricoDeVendasDaLoja.Click += new System.EventHandler(this.BtnHistoricoDeVendasDaLoja_Click);
            // 
            // btnHistoricoDeVendasConsignado
            // 
            this.btnHistoricoDeVendasConsignado.AutoSize = true;
            this.btnHistoricoDeVendasConsignado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistoricoDeVendasConsignado.Depth = 0;
            this.btnHistoricoDeVendasConsignado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistoricoDeVendasConsignado.Icon = null;
            this.btnHistoricoDeVendasConsignado.Location = new System.Drawing.Point(555, 359);
            this.btnHistoricoDeVendasConsignado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHistoricoDeVendasConsignado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHistoricoDeVendasConsignado.Name = "btnHistoricoDeVendasConsignado";
            this.btnHistoricoDeVendasConsignado.Primary = false;
            this.btnHistoricoDeVendasConsignado.Size = new System.Drawing.Size(258, 36);
            this.btnHistoricoDeVendasConsignado.TabIndex = 21;
            this.btnHistoricoDeVendasConsignado.Text = "Histórico de vendas consignado";
            this.btnHistoricoDeVendasConsignado.UseVisualStyleBackColor = true;
            this.btnHistoricoDeVendasConsignado.Click += new System.EventHandler(this.BtnHistoricoDeVendasConsignado_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.Depth = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Icon = null;
            this.btnSair.Location = new System.Drawing.Point(437, 323);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.Primary = false;
            this.btnSair.Size = new System.Drawing.Size(51, 36);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Telainicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 453);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHistoricoDeVendasConsignado);
            this.Controls.Add(this.btnHistoricoDeVendasDaLoja);
            this.Controls.Add(this.btnApresentarVeiculos);
            this.Controls.Add(this.btnVenderVeiculoConsignado);
            this.Controls.Add(this.btnVenderVeiculoLoja);
            this.Controls.Add(this.btnSimulacao);
            this.Controls.Add(this.btnPesquisarVeiculo);
            this.Controls.Add(this.btnCadastrarVeiculoConsignado);
            this.Controls.Add(this.btnCadastrarVeiculoLoja);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Telainicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página inicial";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureClose;
        private MaterialSkin.Controls.MaterialFlatButton btnCadastrarVeiculoLoja;
        private MaterialSkin.Controls.MaterialFlatButton btnCadastrarVeiculoConsignado;
        private MaterialSkin.Controls.MaterialFlatButton btnPesquisarVeiculo;
        private MaterialSkin.Controls.MaterialFlatButton btnSimulacao;
        private MaterialSkin.Controls.MaterialFlatButton btnVenderVeiculoLoja;
        private MaterialSkin.Controls.MaterialFlatButton btnVenderVeiculoConsignado;
        private MaterialSkin.Controls.MaterialFlatButton btnApresentarVeiculos;
        private MaterialSkin.Controls.MaterialFlatButton btnHistoricoDeVendasDaLoja;
        private MaterialSkin.Controls.MaterialFlatButton btnHistoricoDeVendasConsignado;
        private MaterialSkin.Controls.MaterialFlatButton btnSair;
        private XanderUI.XUIObjectAnimator xuiObjectAnimator1;
    }
}