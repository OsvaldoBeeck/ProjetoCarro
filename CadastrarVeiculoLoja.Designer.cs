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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarVeiculoLoja));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomeVeiculo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.kmVeiculo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.precoVeiculo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.corVeiculo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.placaVeiculo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(320, 270);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(137, 37);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(145, 270);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(122, 37);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.Transparent;
            this.lblAno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.Color.Black;
            this.lblAno.Location = new System.Drawing.Point(377, 83);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(54, 22);
            this.lblAno.TabIndex = 14;
            this.lblAno.Text = "Ano:";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.BackColor = System.Drawing.Color.Transparent;
            this.lblKm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.ForeColor = System.Drawing.Color.Black;
            this.lblKm.Location = new System.Drawing.Point(383, 170);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(42, 22);
            this.lblKm.TabIndex = 15;
            this.lblKm.Text = "km:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.Black;
            this.lblPreco.Location = new System.Drawing.Point(35, 171);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(68, 22);
            this.lblPreco.TabIndex = 16;
            this.lblPreco.Text = "Preço:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.Transparent;
            this.lblCor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.ForeColor = System.Drawing.Color.Black;
            this.lblCor.Location = new System.Drawing.Point(377, 130);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(48, 22);
            this.lblCor.TabIndex = 17;
            this.lblCor.Text = "Cor:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.Black;
            this.lblPlaca.Location = new System.Drawing.Point(36, 130);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(67, 22);
            this.lblPlaca.TabIndex = 18;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(35, 83);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 22);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 64);
            this.panel1.TabIndex = 20;
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(561, 3);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(36, 35);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 2;
            this.pictureClose.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nomeVeiculo
            // 
            this.nomeVeiculo.BackColor = System.Drawing.Color.White;
            this.nomeVeiculo.Depth = 0;
            this.nomeVeiculo.Hint = "";
            this.nomeVeiculo.Location = new System.Drawing.Point(119, 84);
            this.nomeVeiculo.MaxLength = 32767;
            this.nomeVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomeVeiculo.Name = "nomeVeiculo";
            this.nomeVeiculo.PasswordChar = '\0';
            this.nomeVeiculo.SelectedText = "";
            this.nomeVeiculo.SelectionLength = 0;
            this.nomeVeiculo.SelectionStart = 0;
            this.nomeVeiculo.Size = new System.Drawing.Size(230, 23);
            this.nomeVeiculo.TabIndex = 21;
            this.nomeVeiculo.TabStop = false;
            this.nomeVeiculo.UseSystemPasswordChar = false;
            // 
            // kmVeiculo
            // 
            this.kmVeiculo.BackColor = System.Drawing.Color.White;
            this.kmVeiculo.Depth = 0;
            this.kmVeiculo.Hint = "";
            this.kmVeiculo.Location = new System.Drawing.Point(437, 170);
            this.kmVeiculo.MaxLength = 32767;
            this.kmVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.kmVeiculo.Name = "kmVeiculo";
            this.kmVeiculo.PasswordChar = '\0';
            this.kmVeiculo.SelectedText = "";
            this.kmVeiculo.SelectionLength = 0;
            this.kmVeiculo.SelectionStart = 0;
            this.kmVeiculo.Size = new System.Drawing.Size(107, 23);
            this.kmVeiculo.TabIndex = 22;
            this.kmVeiculo.TabStop = false;
            this.kmVeiculo.UseSystemPasswordChar = false;
            // 
            // precoVeiculo
            // 
            this.precoVeiculo.BackColor = System.Drawing.Color.White;
            this.precoVeiculo.Depth = 0;
            this.precoVeiculo.Hint = "";
            this.precoVeiculo.Location = new System.Drawing.Point(119, 170);
            this.precoVeiculo.MaxLength = 32767;
            this.precoVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.precoVeiculo.Name = "precoVeiculo";
            this.precoVeiculo.PasswordChar = '\0';
            this.precoVeiculo.SelectedText = "";
            this.precoVeiculo.SelectionLength = 0;
            this.precoVeiculo.SelectionStart = 0;
            this.precoVeiculo.Size = new System.Drawing.Size(107, 23);
            this.precoVeiculo.TabIndex = 23;
            this.precoVeiculo.TabStop = false;
            this.precoVeiculo.UseSystemPasswordChar = false;
            // 
            // corVeiculo
            // 
            this.corVeiculo.BackColor = System.Drawing.Color.White;
            this.corVeiculo.Depth = 0;
            this.corVeiculo.Hint = "";
            this.corVeiculo.Location = new System.Drawing.Point(438, 131);
            this.corVeiculo.MaxLength = 32767;
            this.corVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.corVeiculo.Name = "corVeiculo";
            this.corVeiculo.PasswordChar = '\0';
            this.corVeiculo.SelectedText = "";
            this.corVeiculo.SelectionLength = 0;
            this.corVeiculo.SelectionStart = 0;
            this.corVeiculo.Size = new System.Drawing.Size(107, 23);
            this.corVeiculo.TabIndex = 24;
            this.corVeiculo.TabStop = false;
            this.corVeiculo.UseSystemPasswordChar = false;
            // 
            // placaVeiculo
            // 
            this.placaVeiculo.BackColor = System.Drawing.Color.White;
            this.placaVeiculo.Depth = 0;
            this.placaVeiculo.Hint = "";
            this.placaVeiculo.Location = new System.Drawing.Point(119, 130);
            this.placaVeiculo.MaxLength = 32767;
            this.placaVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.placaVeiculo.Name = "placaVeiculo";
            this.placaVeiculo.PasswordChar = '\0';
            this.placaVeiculo.SelectedText = "";
            this.placaVeiculo.SelectionLength = 0;
            this.placaVeiculo.SelectionStart = 0;
            this.placaVeiculo.Size = new System.Drawing.Size(107, 23);
            this.placaVeiculo.TabIndex = 25;
            this.placaVeiculo.TabStop = false;
            this.placaVeiculo.UseSystemPasswordChar = false;
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.White;
            this.txtAno.Depth = 0;
            this.txtAno.Hint = "";
            this.txtAno.Location = new System.Drawing.Point(438, 84);
            this.txtAno.MaxLength = 32767;
            this.txtAno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAno.Name = "txtAno";
            this.txtAno.PasswordChar = '\0';
            this.txtAno.SelectedText = "";
            this.txtAno.SelectionLength = 0;
            this.txtAno.SelectionStart = 0;
            this.txtAno.Size = new System.Drawing.Size(107, 23);
            this.txtAno.TabIndex = 26;
            this.txtAno.TabStop = false;
            this.txtAno.UseSystemPasswordChar = false;
            // 
            // CadastrarVeiculoLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.placaVeiculo);
            this.Controls.Add(this.corVeiculo);
            this.Controls.Add(this.precoVeiculo);
            this.Controls.Add(this.kmVeiculo);
            this.Controls.Add(this.nomeVeiculo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastrarVeiculoLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar veiculo da loja";
            this.Load += new System.EventHandler(this.CadastrarVeiculoLoja_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureClose;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomeVeiculo;
        private MaterialSkin.Controls.MaterialSingleLineTextField kmVeiculo;
        private MaterialSkin.Controls.MaterialSingleLineTextField precoVeiculo;
        private MaterialSkin.Controls.MaterialSingleLineTextField corVeiculo;
        private MaterialSkin.Controls.MaterialSingleLineTextField placaVeiculo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAno;
    }
}