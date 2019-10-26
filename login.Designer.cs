﻿namespace ProjetoCarro
{
    partial class telaInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInicio));
            this.WorkingArea = new System.Windows.Forms.Panel();
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.panelLateralEsquerdo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDireita = new System.Windows.Forms.Panel();
            this.btnEntrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiObjectAnimator1 = new XanderUI.XUIObjectAnimator();
            this.pictureFechar = new XanderUI.XUICustomPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.panelLateralEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkingArea
            // 
            this.WorkingArea.BackColor = System.Drawing.Color.Transparent;
            this.WorkingArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WorkingArea.BackgroundImage")));
            this.WorkingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkingArea.Location = new System.Drawing.Point(0, 74);
            this.WorkingArea.Name = "WorkingArea";
            this.WorkingArea.Size = new System.Drawing.Size(764, 341);
            this.WorkingArea.TabIndex = 0;
            // 
            // imageLogo
            // 
            this.imageLogo.Image = ((System.Drawing.Image)(resources.GetObject("imageLogo.Image")));
            this.imageLogo.Location = new System.Drawing.Point(11, 3);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(90, 56);
            this.imageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLogo.TabIndex = 3;
            this.imageLogo.TabStop = false;
            // 
            // panelLateralEsquerdo
            // 
            this.panelLateralEsquerdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLateralEsquerdo.BackgroundImage")));
            this.panelLateralEsquerdo.Controls.Add(this.pictureBox1);
            this.panelLateralEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.panelLateralEsquerdo.Name = "panelLateralEsquerdo";
            this.panelLateralEsquerdo.Size = new System.Drawing.Size(244, 425);
            this.panelLateralEsquerdo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDireita
            // 
            this.panelDireita.Controls.Add(this.pictureFechar);
            this.panelDireita.Controls.Add(this.btnEntrar);
            this.panelDireita.Controls.Add(this.txtPassword);
            this.panelDireita.Controls.Add(this.txtUser);
            this.panelDireita.Controls.Add(this.label2);
            this.panelDireita.Controls.Add(this.label1);
            this.panelDireita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDireita.Location = new System.Drawing.Point(244, 0);
            this.panelDireita.Name = "panelDireita";
            this.panelDireita.Size = new System.Drawing.Size(437, 425);
            this.panelDireita.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.AutoSize = true;
            this.btnEntrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Depth = 0;
            this.btnEntrar.Icon = null;
            this.btnEntrar.Location = new System.Drawing.Point(188, 273);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Primary = false;
            this.btnEntrar.Size = new System.Drawing.Size(73, 36);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "Senha";
            this.txtPassword.Location = new System.Drawing.Point(148, 218);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(230, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // txtUser
            // 
            this.txtUser.Depth = 0;
            this.txtUser.Hint = "Usuário";
            this.txtUser.Location = new System.Drawing.Point(148, 171);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(230, 23);
            this.txtUser.TabIndex = 3;
            this.txtUser.TabStop = false;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(161)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(69, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(161)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(78, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // pictureFechar
            // 
            this.pictureFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureFechar.BackgroundImage")));
            this.pictureFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureFechar.Color1 = System.Drawing.Color.DodgerBlue;
            this.pictureFechar.Color2 = System.Drawing.Color.DodgerBlue;
            this.pictureFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureFechar.FilterAlpha = 200;
            this.pictureFechar.FilterEnabled = true;
            this.pictureFechar.Image = null;
            this.pictureFechar.IsElipse = false;
            this.pictureFechar.IsParallax = false;
            this.pictureFechar.Location = new System.Drawing.Point(399, 12);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(26, 25);
            this.pictureFechar.TabIndex = 7;
            this.pictureFechar.Text = "pictureFechar";
            this.pictureFechar.Click += new System.EventHandler(this.PictureFechar_Click);
            // 
            // telaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 425);
            this.Controls.Add(this.panelDireita);
            this.Controls.Add(this.panelLateralEsquerdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "telaInicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.panelLateralEsquerdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDireita.ResumeLayout(false);
            this.panelDireita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imageLogo;
        private System.Windows.Forms.Panel WorkingArea;
        private System.Windows.Forms.Panel panelLateralEsquerdo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDireita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton btnEntrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
        private XanderUI.XUIObjectAnimator xuiObjectAnimator1;
        private XanderUI.XUICustomPictureBox pictureFechar;
    }
}

