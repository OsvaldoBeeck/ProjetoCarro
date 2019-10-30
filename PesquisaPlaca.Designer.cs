namespace ProjetoCarro
{
    partial class PesquisaPlaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaPlaca));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_AnoPesquisa = new System.Windows.Forms.TextBox();
            this.txt_CorPesquisa = new System.Windows.Forms.TextBox();
            this.txt_PrecoPesquisa = new System.Windows.Forms.TextBox();
            this.txt_VeiculoPesquisa = new System.Windows.Forms.TextBox();
            this.Button_EditarCadastro = new System.Windows.Forms.Button();
            this.Button_SalvarPlaca = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_Consig = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_proprietarioPesq = new System.Windows.Forms.TextBox();
            this.radioButton_Loja = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Taxa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Vendido = new System.Windows.Forms.RadioButton();
            this.radioButton_Disponivel = new System.Windows.Forms.RadioButton();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.panel_excluirVeiculo = new System.Windows.Forms.Panel();
            this.button_Nao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_individual = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_excluirVeiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa por Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaca.Location = new System.Drawing.Point(220, 79);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(75, 20);
            this.txtPlaca.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Location = new System.Drawing.Point(298, 71);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 32);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "VEICULO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "COR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "PREÇO TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "ANO:";
            // 
            // txt_AnoPesquisa
            // 
            this.txt_AnoPesquisa.Enabled = false;
            this.txt_AnoPesquisa.Location = new System.Drawing.Point(127, 203);
            this.txt_AnoPesquisa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_AnoPesquisa.Name = "txt_AnoPesquisa";
            this.txt_AnoPesquisa.Size = new System.Drawing.Size(87, 20);
            this.txt_AnoPesquisa.TabIndex = 5;
            // 
            // txt_CorPesquisa
            // 
            this.txt_CorPesquisa.Enabled = false;
            this.txt_CorPesquisa.Location = new System.Drawing.Point(127, 172);
            this.txt_CorPesquisa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_CorPesquisa.Name = "txt_CorPesquisa";
            this.txt_CorPesquisa.Size = new System.Drawing.Size(167, 20);
            this.txt_CorPesquisa.TabIndex = 4;
            this.txt_CorPesquisa.TextChanged += new System.EventHandler(this.txt_CorPesquisa_TextChanged);
            // 
            // txt_PrecoPesquisa
            // 
            this.txt_PrecoPesquisa.Enabled = false;
            this.txt_PrecoPesquisa.Location = new System.Drawing.Point(127, 233);
            this.txt_PrecoPesquisa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_PrecoPesquisa.Name = "txt_PrecoPesquisa";
            this.txt_PrecoPesquisa.Size = new System.Drawing.Size(87, 20);
            this.txt_PrecoPesquisa.TabIndex = 6;
            // 
            // txt_VeiculoPesquisa
            // 
            this.txt_VeiculoPesquisa.Enabled = false;
            this.txt_VeiculoPesquisa.Location = new System.Drawing.Point(127, 137);
            this.txt_VeiculoPesquisa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_VeiculoPesquisa.Name = "txt_VeiculoPesquisa";
            this.txt_VeiculoPesquisa.Size = new System.Drawing.Size(167, 20);
            this.txt_VeiculoPesquisa.TabIndex = 3;
            // 
            // Button_EditarCadastro
            // 
            this.Button_EditarCadastro.Location = new System.Drawing.Point(359, 291);
            this.Button_EditarCadastro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Button_EditarCadastro.Name = "Button_EditarCadastro";
            this.Button_EditarCadastro.Size = new System.Drawing.Size(65, 36);
            this.Button_EditarCadastro.TabIndex = 11;
            this.Button_EditarCadastro.Text = "EDITAR";
            this.Button_EditarCadastro.UseVisualStyleBackColor = true;
            this.Button_EditarCadastro.Visible = false;
            this.Button_EditarCadastro.Click += new System.EventHandler(this.Button_EditarCadastro_Click);
            // 
            // Button_SalvarPlaca
            // 
            this.Button_SalvarPlaca.Location = new System.Drawing.Point(283, 290);
            this.Button_SalvarPlaca.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Button_SalvarPlaca.Name = "Button_SalvarPlaca";
            this.Button_SalvarPlaca.Size = new System.Drawing.Size(65, 38);
            this.Button_SalvarPlaca.TabIndex = 12;
            this.Button_SalvarPlaca.Text = "SALVAR";
            this.Button_SalvarPlaca.UseVisualStyleBackColor = true;
            this.Button_SalvarPlaca.Visible = false;
            this.Button_SalvarPlaca.Click += new System.EventHandler(this.Button_SalvarPlaca_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(435, 291);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(65, 36);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "PLACA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 19;
            // 
            // radioButton_Consig
            // 
            this.radioButton_Consig.AutoSize = true;
            this.radioButton_Consig.Enabled = false;
            this.radioButton_Consig.Location = new System.Drawing.Point(4, 38);
            this.radioButton_Consig.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton_Consig.Name = "radioButton_Consig";
            this.radioButton_Consig.Size = new System.Drawing.Size(97, 17);
            this.radioButton_Consig.TabIndex = 20;
            this.radioButton_Consig.TabStop = true;
            this.radioButton_Consig.Text = "CONSIGNADO";
            this.radioButton_Consig.UseVisualStyleBackColor = true;
            this.radioButton_Consig.CheckedChanged += new System.EventHandler(this.radioButton_Consig_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 257);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "PROPRIETARIO:";
            // 
            // txt_proprietarioPesq
            // 
            this.txt_proprietarioPesq.Enabled = false;
            this.txt_proprietarioPesq.Location = new System.Drawing.Point(127, 261);
            this.txt_proprietarioPesq.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_proprietarioPesq.Name = "txt_proprietarioPesq";
            this.txt_proprietarioPesq.Size = new System.Drawing.Size(211, 20);
            this.txt_proprietarioPesq.TabIndex = 8;
            // 
            // radioButton_Loja
            // 
            this.radioButton_Loja.AutoSize = true;
            this.radioButton_Loja.Enabled = false;
            this.radioButton_Loja.Location = new System.Drawing.Point(4, 17);
            this.radioButton_Loja.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton_Loja.Name = "radioButton_Loja";
            this.radioButton_Loja.Size = new System.Drawing.Size(51, 17);
            this.radioButton_Loja.TabIndex = 23;
            this.radioButton_Loja.TabStop = true;
            this.radioButton_Loja.Text = "LOJA";
            this.radioButton_Loja.UseVisualStyleBackColor = true;
            this.radioButton_Loja.CheckedChanged += new System.EventHandler(this.RadioButton_Loja_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureMinimize);
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 64);
            this.panel1.TabIndex = 24;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(451, 0);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(29, 29);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimize.TabIndex = 26;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.PictureMinimize_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(479, 0);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(29, 29);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 25;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 291);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "TAXA:";
            // 
            // txt_Taxa
            // 
            this.txt_Taxa.Enabled = false;
            this.txt_Taxa.Location = new System.Drawing.Point(127, 291);
            this.txt_Taxa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Taxa.Name = "txt_Taxa";
            this.txt_Taxa.Size = new System.Drawing.Size(76, 20);
            this.txt_Taxa.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Consig);
            this.groupBox1.Controls.Add(this.radioButton_Loja);
            this.groupBox1.Location = new System.Drawing.Point(388, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(116, 58);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Vendido);
            this.groupBox2.Controls.Add(this.radioButton_Disponivel);
            this.groupBox2.Location = new System.Drawing.Point(388, 209);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(116, 60);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STATUS";
            // 
            // radioButton_Vendido
            // 
            this.radioButton_Vendido.AutoSize = true;
            this.radioButton_Vendido.Enabled = false;
            this.radioButton_Vendido.Location = new System.Drawing.Point(4, 36);
            this.radioButton_Vendido.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Vendido.Name = "radioButton_Vendido";
            this.radioButton_Vendido.Size = new System.Drawing.Size(74, 17);
            this.radioButton_Vendido.TabIndex = 1;
            this.radioButton_Vendido.TabStop = true;
            this.radioButton_Vendido.Text = "VENDIDO";
            this.radioButton_Vendido.UseVisualStyleBackColor = true;
            // 
            // radioButton_Disponivel
            // 
            this.radioButton_Disponivel.AutoSize = true;
            this.radioButton_Disponivel.Enabled = false;
            this.radioButton_Disponivel.Location = new System.Drawing.Point(5, 17);
            this.radioButton_Disponivel.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Disponivel.Name = "radioButton_Disponivel";
            this.radioButton_Disponivel.Size = new System.Drawing.Size(89, 17);
            this.radioButton_Disponivel.TabIndex = 0;
            this.radioButton_Disponivel.TabStop = true;
            this.radioButton_Disponivel.Text = "DISPONIVEL";
            this.radioButton_Disponivel.UseVisualStyleBackColor = true;
            // 
            // button_Excluir
            // 
            this.button_Excluir.Location = new System.Drawing.Point(205, 290);
            this.button_Excluir.Margin = new System.Windows.Forms.Padding(2);
            this.button_Excluir.Name = "button_Excluir";
            this.button_Excluir.Size = new System.Drawing.Size(65, 38);
            this.button_Excluir.TabIndex = 13;
            this.button_Excluir.Text = "EXCLUIR";
            this.button_Excluir.UseVisualStyleBackColor = true;
            this.button_Excluir.Visible = false;
            this.button_Excluir.Click += new System.EventHandler(this.button_Excluir_Click);
            // 
            // panel_excluirVeiculo
            // 
            this.panel_excluirVeiculo.Controls.Add(this.button_Nao);
            this.panel_excluirVeiculo.Controls.Add(this.button1);
            this.panel_excluirVeiculo.Controls.Add(this.label10);
            this.panel_excluirVeiculo.Location = new System.Drawing.Point(90, 131);
            this.panel_excluirVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.panel_excluirVeiculo.Name = "panel_excluirVeiculo";
            this.panel_excluirVeiculo.Size = new System.Drawing.Size(353, 126);
            this.panel_excluirVeiculo.TabIndex = 30;
            this.panel_excluirVeiculo.Visible = false;
            // 
            // button_Nao
            // 
            this.button_Nao.Location = new System.Drawing.Point(187, 66);
            this.button_Nao.Margin = new System.Windows.Forms.Padding(2);
            this.button_Nao.Name = "button_Nao";
            this.button_Nao.Size = new System.Drawing.Size(66, 36);
            this.button_Nao.TabIndex = 10;
            this.button_Nao.Text = "NÃO";
            this.button_Nao.UseVisualStyleBackColor = true;
            this.button_Nao.Click += new System.EventHandler(this.button_Nao_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "SIM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "DESEJA EXCLUIR ESSE VEICULO?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(217, 231);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 21);
            this.label11.TabIndex = 31;
            this.label11.Text = "IND:";
            // 
            // txt_individual
            // 
            this.txt_individual.Enabled = false;
            this.txt_individual.Location = new System.Drawing.Point(256, 233);
            this.txt_individual.Margin = new System.Windows.Forms.Padding(2);
            this.txt_individual.Name = "txt_individual";
            this.txt_individual.Size = new System.Drawing.Size(87, 20);
            this.txt_individual.TabIndex = 7;
            // 
            // PesquisaPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 341);
            this.Controls.Add(this.txt_individual);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel_excluirVeiculo);
            this.Controls.Add(this.button_Excluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Taxa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_proprietarioPesq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.Button_SalvarPlaca);
            this.Controls.Add(this.Button_EditarCadastro);
            this.Controls.Add(this.txt_VeiculoPesquisa);
            this.Controls.Add(this.txt_PrecoPesquisa);
            this.Controls.Add(this.txt_CorPesquisa);
            this.Controls.Add(this.txt_AnoPesquisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PesquisaPlaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisaPlaca";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_excluirVeiculo.ResumeLayout(false);
            this.panel_excluirVeiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_AnoPesquisa;
        private System.Windows.Forms.TextBox txt_CorPesquisa;
        private System.Windows.Forms.TextBox txt_PrecoPesquisa;
        private System.Windows.Forms.TextBox txt_VeiculoPesquisa;
        private System.Windows.Forms.Button Button_EditarCadastro;
        private System.Windows.Forms.Button Button_SalvarPlaca;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton_Consig;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_proprietarioPesq;
        private System.Windows.Forms.RadioButton radioButton_Loja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureMinimize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Taxa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Vendido;
        private System.Windows.Forms.RadioButton radioButton_Disponivel;
        private System.Windows.Forms.Button button_Excluir;
        private System.Windows.Forms.Panel panel_excluirVeiculo;
        private System.Windows.Forms.Button button_Nao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_individual;
    }
}