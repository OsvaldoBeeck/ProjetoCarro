namespace ProjetoCarro
{
    partial class HistoricoLoja
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
            this.dataGrid_Loja = new System.Windows.Forms.DataGridView();
            this.button_Voltar = new System.Windows.Forms.Button();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button_listar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Loja)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Loja
            // 
            this.dataGrid_Loja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Loja.Location = new System.Drawing.Point(29, 84);
            this.dataGrid_Loja.Name = "dataGrid_Loja";
            this.dataGrid_Loja.RowHeadersWidth = 62;
            this.dataGrid_Loja.RowTemplate.Height = 28;
            this.dataGrid_Loja.Size = new System.Drawing.Size(724, 316);
            this.dataGrid_Loja.TabIndex = 5;
            // 
            // button_Voltar
            // 
            this.button_Voltar.Location = new System.Drawing.Point(637, 424);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(125, 51);
            this.button_Voltar.TabIndex = 4;
            this.button_Voltar.Text = "VOLTAR";
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(404, 12);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(125, 51);
            this.button_Buscar.TabIndex = 2;
            this.button_Buscar.Text = "BUSCAR";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // button_listar
            // 
            this.button_listar.Location = new System.Drawing.Point(556, 12);
            this.button_listar.Name = "button_listar";
            this.button_listar.Size = new System.Drawing.Size(125, 51);
            this.button_listar.TabIndex = 3;
            this.button_listar.Text = "LISTAR";
            this.button_listar.UseVisualStyleBackColor = true;
            this.button_listar.Click += new System.EventHandler(this.button_listar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(186, 24);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(200, 26);
            this.txt_Buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOME:";
            // 
            // HistoricoLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.button_listar);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.dataGrid_Loja);
            this.Name = "HistoricoLoja";
            this.Text = "HistoricoLoja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Loja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Loja;
        private System.Windows.Forms.Button button_Voltar;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button_listar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label label1;
    }
}