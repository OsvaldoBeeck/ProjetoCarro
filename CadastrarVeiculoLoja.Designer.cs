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
            this.radioButton_LOJA = new System.Windows.Forms.RadioButton();
            this.radioButton_Consignado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Proprietario = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Taxa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(554, 511);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(206, 57);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(270, 511);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(183, 57);
            this.btnVoltar.TabIndex = 11;
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
            this.lblAno.Location = new System.Drawing.Point(600, 184);
            this.lblAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(80, 36);
            this.lblAno.TabIndex = 14;
            this.lblAno.Text = "Ano:";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.BackColor = System.Drawing.Color.Transparent;
            this.lblKm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.ForeColor = System.Drawing.Color.Black;
            this.lblKm.Location = new System.Drawing.Point(608, 303);
            this.lblKm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(65, 36);
            this.lblKm.TabIndex = 15;
            this.lblKm.Text = "km:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.Black;
            this.lblPreco.Location = new System.Drawing.Point(86, 304);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(105, 36);
            this.lblPreco.TabIndex = 16;
            this.lblPreco.Text = "Preço:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.Transparent;
            this.lblCor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.ForeColor = System.Drawing.Color.Black;
            this.lblCor.Location = new System.Drawing.Point(600, 241);
            this.lblCor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(74, 36);
            this.lblCor.TabIndex = 17;
            this.lblCor.Text = "Cor:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.Black;
            this.lblPlaca.Location = new System.Drawing.Point(88, 243);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(104, 36);
            this.lblPlaca.TabIndex = 18;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(86, 183);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(109, 36);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 98);
            this.panel1.TabIndex = 20;
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(842, 5);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(54, 54);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 2;
            this.pictureClose.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nomeVeiculo
            // 
            this.nomeVeiculo.BackColor = System.Drawing.Color.White;
            this.nomeVeiculo.Depth = 0;
            this.nomeVeiculo.Hint = "";
            this.nomeVeiculo.Location = new System.Drawing.Point(212, 184);
            this.nomeVeiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomeVeiculo.MaxLength = 32767;
            this.nomeVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomeVeiculo.Name = "nomeVeiculo";
            this.nomeVeiculo.PasswordChar = '\0';
            this.nomeVeiculo.SelectedText = "";
            this.nomeVeiculo.SelectionLength = 0;
            this.nomeVeiculo.SelectionStart = 0;
            this.nomeVeiculo.Size = new System.Drawing.Size(281, 32);
            this.nomeVeiculo.TabIndex = 1;
            this.nomeVeiculo.TabStop = false;
            this.nomeVeiculo.UseSystemPasswordChar = false;
            // 
            // kmVeiculo
            // 
            this.kmVeiculo.BackColor = System.Drawing.Color.White;
            this.kmVeiculo.Depth = 0;
            this.kmVeiculo.Hint = "";
            this.kmVeiculo.Location = new System.Drawing.Point(690, 303);
            this.kmVeiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kmVeiculo.MaxLength = 32767;
            this.kmVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.kmVeiculo.Name = "kmVeiculo";
            this.kmVeiculo.PasswordChar = '\0';
            this.kmVeiculo.SelectedText = "";
            this.kmVeiculo.SelectionLength = 0;
            this.kmVeiculo.SelectionStart = 0;
            this.kmVeiculo.Size = new System.Drawing.Size(160, 32);
            this.kmVeiculo.TabIndex = 6;
            this.kmVeiculo.TabStop = false;
            this.kmVeiculo.UseSystemPasswordChar = false;
            // 
            // precoVeiculo
            // 
            this.precoVeiculo.BackColor = System.Drawing.Color.White;
            this.precoVeiculo.Depth = 0;
            this.precoVeiculo.Hint = "";
            this.precoVeiculo.Location = new System.Drawing.Point(212, 303);
            this.precoVeiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.precoVeiculo.MaxLength = 32767;
            this.precoVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.precoVeiculo.Name = "precoVeiculo";
            this.precoVeiculo.PasswordChar = '\0';
            this.precoVeiculo.SelectedText = "";
            this.precoVeiculo.SelectionLength = 0;
            this.precoVeiculo.SelectionStart = 0;
            this.precoVeiculo.Size = new System.Drawing.Size(160, 32);
            this.precoVeiculo.TabIndex = 3;
            this.precoVeiculo.TabStop = false;
            this.precoVeiculo.UseSystemPasswordChar = false;
            // 
            // corVeiculo
            // 
            this.corVeiculo.BackColor = System.Drawing.Color.White;
            this.corVeiculo.Depth = 0;
            this.corVeiculo.Hint = "";
            this.corVeiculo.Location = new System.Drawing.Point(691, 243);
            this.corVeiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.corVeiculo.MaxLength = 32767;
            this.corVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.corVeiculo.Name = "corVeiculo";
            this.corVeiculo.PasswordChar = '\0';
            this.corVeiculo.SelectedText = "";
            this.corVeiculo.SelectionLength = 0;
            this.corVeiculo.SelectionStart = 0;
            this.corVeiculo.Size = new System.Drawing.Size(160, 32);
            this.corVeiculo.TabIndex = 5;
            this.corVeiculo.TabStop = false;
            this.corVeiculo.UseSystemPasswordChar = false;
            // 
            // placaVeiculo
            // 
            this.placaVeiculo.BackColor = System.Drawing.Color.White;
            this.placaVeiculo.Depth = 0;
            this.placaVeiculo.Hint = "";
            this.placaVeiculo.Location = new System.Drawing.Point(212, 243);
            this.placaVeiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placaVeiculo.MaxLength = 32767;
            this.placaVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.placaVeiculo.Name = "placaVeiculo";
            this.placaVeiculo.PasswordChar = '\0';
            this.placaVeiculo.SelectedText = "";
            this.placaVeiculo.SelectionLength = 0;
            this.placaVeiculo.SelectionStart = 0;
            this.placaVeiculo.Size = new System.Drawing.Size(160, 32);
            this.placaVeiculo.TabIndex = 2;
            this.placaVeiculo.TabStop = false;
            this.placaVeiculo.UseSystemPasswordChar = false;
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.White;
            this.txtAno.Depth = 0;
            this.txtAno.Hint = "";
            this.txtAno.Location = new System.Drawing.Point(691, 185);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAno.MaxLength = 32767;
            this.txtAno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAno.Name = "txtAno";
            this.txtAno.PasswordChar = '\0';
            this.txtAno.SelectedText = "";
            this.txtAno.SelectionLength = 0;
            this.txtAno.SelectionStart = 0;
            this.txtAno.Size = new System.Drawing.Size(160, 32);
            this.txtAno.TabIndex = 4;
            this.txtAno.TabStop = false;
            this.txtAno.UseSystemPasswordChar = false;
            // 
            // radioButton_LOJA
            // 
            this.radioButton_LOJA.AutoSize = true;
            this.radioButton_LOJA.Checked = true;
            this.radioButton_LOJA.Location = new System.Drawing.Point(379, 123);
            this.radioButton_LOJA.Name = "radioButton_LOJA";
            this.radioButton_LOJA.Size = new System.Drawing.Size(74, 24);
            this.radioButton_LOJA.TabIndex = 27;
            this.radioButton_LOJA.TabStop = true;
            this.radioButton_LOJA.Text = "LOJA";
            this.radioButton_LOJA.UseVisualStyleBackColor = true;
            this.radioButton_LOJA.CheckedChanged += new System.EventHandler(this.radioButton_LOJA_CheckedChanged);
            // 
            // radioButton_Consignado
            // 
            this.radioButton_Consignado.AutoSize = true;
            this.radioButton_Consignado.Location = new System.Drawing.Point(537, 123);
            this.radioButton_Consignado.Name = "radioButton_Consignado";
            this.radioButton_Consignado.Size = new System.Drawing.Size(143, 24);
            this.radioButton_Consignado.TabIndex = 28;
            this.radioButton_Consignado.Text = "CONSIGNADO";
            this.radioButton_Consignado.UseVisualStyleBackColor = true;
            this.radioButton_Consignado.CheckedChanged += new System.EventHandler(this.radioButton_Consignado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(596, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = "Proprietário:";
            // 
            // txt_Proprietario
            // 
            this.txt_Proprietario.Enabled = false;
            this.txt_Proprietario.Location = new System.Drawing.Point(212, 365);
            this.txt_Proprietario.Name = "txt_Proprietario";
            this.txt_Proprietario.Size = new System.Drawing.Size(355, 26);
            this.txt_Proprietario.TabIndex = 7;
            // 
            // txt_CPF
            // 
            this.txt_CPF.Enabled = false;
            this.txt_CPF.Location = new System.Drawing.Point(690, 366);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(160, 26);
            this.txt_CPF.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(578, 416);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 36);
            this.label2.TabIndex = 34;
            this.label2.Text = "TAXA:";
            // 
            // txt_Taxa
            // 
            this.txt_Taxa.Enabled = false;
            this.txt_Taxa.Location = new System.Drawing.Point(690, 426);
            this.txt_Taxa.Name = "txt_Taxa";
            this.txt_Taxa.Size = new System.Drawing.Size(160, 26);
            this.txt_Taxa.TabIndex = 9;
            // 
            // CadastrarVeiculoLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 646);
            this.Controls.Add(this.txt_Taxa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.txt_Proprietario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_Consignado);
            this.Controls.Add(this.radioButton_LOJA);
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
        private System.Windows.Forms.RadioButton radioButton_LOJA;
        private System.Windows.Forms.RadioButton radioButton_Consignado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Proprietario;
        private System.Windows.Forms.TextBox txt_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Taxa;
    }
}