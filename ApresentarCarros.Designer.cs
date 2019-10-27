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
            this.dataGrid_Apresentar = new System.Windows.Forms.DataGridView();
            this.button_Apresentar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Voltar = new System.Windows.Forms.Button();
            this.button_LISTAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Apresentar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Apresentar
            // 
            this.dataGrid_Apresentar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Apresentar.Location = new System.Drawing.Point(37, 96);
            this.dataGrid_Apresentar.Name = "dataGrid_Apresentar";
            this.dataGrid_Apresentar.RowHeadersWidth = 62;
            this.dataGrid_Apresentar.RowTemplate.Height = 28;
            this.dataGrid_Apresentar.Size = new System.Drawing.Size(970, 392);
            this.dataGrid_Apresentar.TabIndex = 5;
            this.dataGrid_Apresentar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_Apresentar
            // 
            this.button_Apresentar.Location = new System.Drawing.Point(668, 18);
            this.button_Apresentar.Name = "button_Apresentar";
            this.button_Apresentar.Size = new System.Drawing.Size(101, 54);
            this.button_Apresentar.TabIndex = 2;
            this.button_Apresentar.Text = "BUSCAR";
            this.button_Apresentar.UseVisualStyleBackColor = true;
            this.button_Apresentar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(374, 32);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(251, 26);
            this.txt_Buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "VEICULO:";
            // 
            // button_Voltar
            // 
            this.button_Voltar.Location = new System.Drawing.Point(947, 500);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(97, 54);
            this.button_Voltar.TabIndex = 4;
            this.button_Voltar.Text = "VOLTAR";
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // button_LISTAR
            // 
            this.button_LISTAR.Location = new System.Drawing.Point(859, 18);
            this.button_LISTAR.Name = "button_LISTAR";
            this.button_LISTAR.Size = new System.Drawing.Size(101, 54);
            this.button_LISTAR.TabIndex = 3;
            this.button_LISTAR.Text = "LISTAR";
            this.button_LISTAR.UseVisualStyleBackColor = true;
            this.button_LISTAR.Click += new System.EventHandler(this.button_LISTAR_Click);
            // 
            // ApresentarCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 566);
            this.Controls.Add(this.button_LISTAR);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.button_Apresentar);
            this.Controls.Add(this.dataGrid_Apresentar);
            this.Name = "ApresentarCarros";
            this.Text = "ApresentarCarros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Apresentar)).EndInit();
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
    }
}