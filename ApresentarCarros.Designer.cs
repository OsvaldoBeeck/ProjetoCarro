namespace ProjetoCarro
{
    partial class ApresentarCarros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApresentarCarros));
            this.dataGrid_Apresentar = new System.Windows.Forms.DataGridView();
            this.button_Apresentar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Voltar = new System.Windows.Forms.Button();
            this.button_LISTAR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Apresentar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Apresentar
            // 
            this.dataGrid_Apresentar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Apresentar.Location = new System.Drawing.Point(47, 238);
            this.dataGrid_Apresentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGrid_Apresentar.Name = "dataGrid_Apresentar";
            this.dataGrid_Apresentar.RowHeadersWidth = 62;
            this.dataGrid_Apresentar.RowTemplate.Height = 28;
            this.dataGrid_Apresentar.Size = new System.Drawing.Size(970, 392);
            this.dataGrid_Apresentar.TabIndex = 5;
            this.dataGrid_Apresentar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_Apresentar
            // 
            this.button_Apresentar.Location = new System.Drawing.Point(668, 159);
            this.button_Apresentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Apresentar.Name = "button_Apresentar";
            this.button_Apresentar.Size = new System.Drawing.Size(101, 54);
            this.button_Apresentar.TabIndex = 2;
            this.button_Apresentar.Text = "BUSCAR";
            this.button_Apresentar.UseVisualStyleBackColor = true;
            this.button_Apresentar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(393, 174);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(243, 26);
            this.txt_Buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "VEICULO:";
            // 
            // button_Voltar
            // 
            this.button_Voltar.Location = new System.Drawing.Point(957, 641);
            this.button_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(97, 54);
            this.button_Voltar.TabIndex = 4;
            this.button_Voltar.Text = "VOLTAR";
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // button_LISTAR
            // 
            this.button_LISTAR.Location = new System.Drawing.Point(776, 159);
            this.button_LISTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_LISTAR.Name = "button_LISTAR";
            this.button_LISTAR.Size = new System.Drawing.Size(101, 54);
            this.button_LISTAR.TabIndex = 3;
            this.button_LISTAR.Text = "LISTAR";
            this.button_LISTAR.UseVisualStyleBackColor = true;
            this.button_LISTAR.Click += new System.EventHandler(this.button_LISTAR_Click);
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
            this.panel1.Size = new System.Drawing.Size(1079, 98);
            this.panel1.TabIndex = 6;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(993, 0);
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
            this.pictureClose.Location = new System.Drawing.Point(1035, 0);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(44, 44);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 9;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apresentar veículos";
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
            // ApresentarCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_LISTAR);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.button_Apresentar);
            this.Controls.Add(this.dataGrid_Apresentar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ApresentarCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApresentarCarros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Apresentar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Apresentar;
        private System.Windows.Forms.Button button_Apresentar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Voltar;
        private System.Windows.Forms.Button button_LISTAR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureMinimize;
    }
}