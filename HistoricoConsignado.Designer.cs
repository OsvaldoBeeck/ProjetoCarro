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
            this.GridView_Historico = new System.Windows.Forms.DataGridView();
            this.button_Voltar = new System.Windows.Forms.Button();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button_Listar = new System.Windows.Forms.Button();
            this.txt_Consignado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Historico)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView_Historico
            // 
            this.GridView_Historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Historico.Location = new System.Drawing.Point(43, 88);
            this.GridView_Historico.Name = "GridView_Historico";
            this.GridView_Historico.RowHeadersWidth = 62;
            this.GridView_Historico.RowTemplate.Height = 28;
            this.GridView_Historico.Size = new System.Drawing.Size(713, 326);
            this.GridView_Historico.TabIndex = 5;
            // 
            // button_Voltar
            // 
            this.button_Voltar.Location = new System.Drawing.Point(647, 439);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(141, 58);
            this.button_Voltar.TabIndex = 4;
            this.button_Voltar.Text = "VOLTAR";
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(404, 12);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(141, 58);
            this.button_Buscar.TabIndex = 2;
            this.button_Buscar.Text = "BUSCAR";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // button_Listar
            // 
            this.button_Listar.Location = new System.Drawing.Point(576, 12);
            this.button_Listar.Name = "button_Listar";
            this.button_Listar.Size = new System.Drawing.Size(141, 58);
            this.button_Listar.TabIndex = 3;
            this.button_Listar.Text = "LISTAR";
            this.button_Listar.UseVisualStyleBackColor = true;
            this.button_Listar.Click += new System.EventHandler(this.button_Listar_Click);
            // 
            // txt_Consignado
            // 
            this.txt_Consignado.Location = new System.Drawing.Point(172, 28);
            this.txt_Consignado.Name = "txt_Consignado";
            this.txt_Consignado.Size = new System.Drawing.Size(207, 26);
            this.txt_Consignado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOME:";
            // 
            // HistoricoConsignado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Consignado);
            this.Controls.Add(this.button_Listar);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.GridView_Historico);
            this.Name = "HistoricoConsignado";
            this.Text = "HistoricoConsignado";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Historico)).EndInit();
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
    }
}