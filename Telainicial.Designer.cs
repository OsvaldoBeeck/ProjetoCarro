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
            this.btnPesquisarVeiculo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSimulacao = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVenderVeiculoLoja = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnApresentarVeiculos = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHistoricoDeVendasDaLoja = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHistoricoDeVendasConsignado = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSair = new MaterialSkin.Controls.MaterialFlatButton();
            this.xuiObjectAnimator1 = new XanderUI.XUIObjectAnimator();
            this.button_Lucro = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 98);
            this.panel1.TabIndex = 12;
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(1180, 5);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(54, 54);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 1;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 98);
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
            this.btnCadastrarVeiculoLoja.Location = new System.Drawing.Point(60, 178);
            this.btnCadastrarVeiculoLoja.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnCadastrarVeiculoLoja.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrarVeiculoLoja.Name = "btnCadastrarVeiculoLoja";
            this.btnCadastrarVeiculoLoja.Primary = false;
            this.btnCadastrarVeiculoLoja.Size = new System.Drawing.Size(230, 36);
            this.btnCadastrarVeiculoLoja.TabIndex = 1;
            this.btnCadastrarVeiculoLoja.Text = "CADASTRAR VEÍCULO";
            this.btnCadastrarVeiculoLoja.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculoLoja.Click += new System.EventHandler(this.btnCadastrarVeiculoLoja_Click);
            // 
            // btnPesquisarVeiculo
            // 
            this.btnPesquisarVeiculo.AutoSize = true;
            this.btnPesquisarVeiculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPesquisarVeiculo.Depth = 0;
            this.btnPesquisarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarVeiculo.Icon = null;
            this.btnPesquisarVeiculo.Location = new System.Drawing.Point(60, 388);
            this.btnPesquisarVeiculo.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnPesquisarVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPesquisarVeiculo.Name = "btnPesquisarVeiculo";
            this.btnPesquisarVeiculo.Primary = false;
            this.btnPesquisarVeiculo.Size = new System.Drawing.Size(221, 36);
            this.btnPesquisarVeiculo.TabIndex = 4;
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
            this.btnSimulacao.Location = new System.Drawing.Point(809, 165);
            this.btnSimulacao.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnSimulacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSimulacao.Name = "btnSimulacao";
            this.btnSimulacao.Primary = false;
            this.btnSimulacao.Size = new System.Drawing.Size(139, 36);
            this.btnSimulacao.TabIndex = 5;
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
            this.btnVenderVeiculoLoja.Location = new System.Drawing.Point(60, 318);
            this.btnVenderVeiculoLoja.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnVenderVeiculoLoja.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVenderVeiculoLoja.Name = "btnVenderVeiculoLoja";
            this.btnVenderVeiculoLoja.Primary = false;
            this.btnVenderVeiculoLoja.Size = new System.Drawing.Size(189, 36);
            this.btnVenderVeiculoLoja.TabIndex = 3;
            this.btnVenderVeiculoLoja.Text = "VENDER VEÍCULO";
            this.btnVenderVeiculoLoja.UseVisualStyleBackColor = true;
            this.btnVenderVeiculoLoja.Click += new System.EventHandler(this.btnVenderVeiculoLoja_Click);
            // 
            // btnApresentarVeiculos
            // 
            this.btnApresentarVeiculos.AutoSize = true;
            this.btnApresentarVeiculos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApresentarVeiculos.Depth = 0;
            this.btnApresentarVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApresentarVeiculos.Icon = null;
            this.btnApresentarVeiculos.Location = new System.Drawing.Point(60, 245);
            this.btnApresentarVeiculos.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnApresentarVeiculos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApresentarVeiculos.Name = "btnApresentarVeiculos";
            this.btnApresentarVeiculos.Primary = false;
            this.btnApresentarVeiculos.Size = new System.Drawing.Size(253, 36);
            this.btnApresentarVeiculos.TabIndex = 2;
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
            this.btnHistoricoDeVendasDaLoja.Location = new System.Drawing.Point(616, 245);
            this.btnHistoricoDeVendasDaLoja.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnHistoricoDeVendasDaLoja.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHistoricoDeVendasDaLoja.Name = "btnHistoricoDeVendasDaLoja";
            this.btnHistoricoDeVendasDaLoja.Primary = false;
            this.btnHistoricoDeVendasDaLoja.Size = new System.Drawing.Size(332, 36);
            this.btnHistoricoDeVendasDaLoja.TabIndex = 6;
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
            this.btnHistoricoDeVendasConsignado.Location = new System.Drawing.Point(569, 318);
            this.btnHistoricoDeVendasConsignado.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnHistoricoDeVendasConsignado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHistoricoDeVendasConsignado.Name = "btnHistoricoDeVendasConsignado";
            this.btnHistoricoDeVendasConsignado.Primary = false;
            this.btnHistoricoDeVendasConsignado.Size = new System.Drawing.Size(379, 36);
            this.btnHistoricoDeVendasConsignado.TabIndex = 7;
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
            this.btnSair.Location = new System.Drawing.Point(431, 444);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.Primary = false;
            this.btnSair.Size = new System.Drawing.Size(68, 36);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // button_Lucro
            // 
            this.button_Lucro.AutoSize = true;
            this.button_Lucro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Lucro.Depth = 0;
            this.button_Lucro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Lucro.Icon = null;
            this.button_Lucro.Location = new System.Drawing.Point(847, 388);
            this.button_Lucro.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.button_Lucro.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_Lucro.Name = "button_Lucro";
            this.button_Lucro.Primary = false;
            this.button_Lucro.Size = new System.Drawing.Size(101, 36);
            this.button_Lucro.TabIndex = 8;
            this.button_Lucro.Text = "LUCROS";
            this.button_Lucro.UseVisualStyleBackColor = true;
            this.button_Lucro.Click += new System.EventHandler(this.button_Lucro_Click);
            // 
            // Telainicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 697);
            this.Controls.Add(this.button_Lucro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHistoricoDeVendasConsignado);
            this.Controls.Add(this.btnHistoricoDeVendasDaLoja);
            this.Controls.Add(this.btnApresentarVeiculos);
            this.Controls.Add(this.btnVenderVeiculoLoja);
            this.Controls.Add(this.btnSimulacao);
            this.Controls.Add(this.btnPesquisarVeiculo);
            this.Controls.Add(this.btnCadastrarVeiculoLoja);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private MaterialSkin.Controls.MaterialFlatButton btnPesquisarVeiculo;
        private MaterialSkin.Controls.MaterialFlatButton btnSimulacao;
        private MaterialSkin.Controls.MaterialFlatButton btnVenderVeiculoLoja;
        private MaterialSkin.Controls.MaterialFlatButton btnApresentarVeiculos;
        private MaterialSkin.Controls.MaterialFlatButton btnHistoricoDeVendasDaLoja;
        private MaterialSkin.Controls.MaterialFlatButton btnHistoricoDeVendasConsignado;
        private MaterialSkin.Controls.MaterialFlatButton btnSair;
        private XanderUI.XUIObjectAnimator xuiObjectAnimator1;
        private MaterialSkin.Controls.MaterialFlatButton button_Lucro;
    }
}