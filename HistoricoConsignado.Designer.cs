namespace ProjetoCarro
{
    partial class HistoricoConsignado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoConsignado));
            this.GridView_Historico = new System.Windows.Forms.DataGridView();
            this.button_Voltar = new System.Windows.Forms.Button();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button_Listar = new System.Windows.Forms.Button();
            this.txt_Consignado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Historico)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView_Historico
            // 
            this.GridView_Historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Historico.Location = new System.Drawing.Point(36, 219);
            this.GridView_Historico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridView_Historico.Name = "GridView_Historico";
            this.GridView_Historico.RowHeadersWidth = 62;
            this.GridView_Historico.RowTemplate.Height = 28;
            this.GridView_Historico.Size = new System.Drawing.Size(713, 326);
            this.GridView_Historico.TabIndex = 5;
            // 
            // button_Voltar
            // 
            this.button_Voltar.Location = new System.Drawing.Point(640, 570);
            this.button_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(141, 58);
            this.button_Voltar.TabIndex = 4;
            this.button_Voltar.Text = "VOLTAR";
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(397, 144);
            this.button_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(141, 58);
            this.button_Buscar.TabIndex = 2;
            this.button_Buscar.Text = "BUSCAR";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // button_Listar
            // 
            this.button_Listar.Location = new System.Drawing.Point(544, 144);
            this.button_Listar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Listar.Name = "button_Listar";
            this.button_Listar.Size = new System.Drawing.Size(141, 58);
            this.button_Listar.TabIndex = 3;
            this.button_Listar.Text = "LISTAR";
            this.button_Listar.UseVisualStyleBackColor = true;
            this.button_Listar.Click += new System.EventHandler(this.button_Listar_Click);
            // 
            // txt_Consignado
            // 
            this.txt_Consignado.Location = new System.Drawing.Point(130, 159);
            this.txt_Consignado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Consignado.Name = "txt_Consignado";
            this.txt_Consignado.Size = new System.Drawing.Size(203, 26);
            this.txt_Consignado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOME:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureMinimize);
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 98);
            this.panel1.TabIndex = 6;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(723, 0);
            this.pictureMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(44, 44);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimize.TabIndex = 26;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.PictureMinimize_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(756, 0);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(44, 44);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 11;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "Histórico de vendas consignado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // HistoricoConsignado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Consignado);
            this.Controls.Add(this.button_Listar);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.GridView_Historico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HistoricoConsignado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoricoConsignado";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Historico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_Historico;
        private System.Windows.Forms.Button button_Voltar;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button_Listar;
        private System.Windows.Forms.TextBox txt_Consignado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureMinimize;
    }
}