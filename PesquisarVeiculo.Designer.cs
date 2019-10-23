namespace ProjetoCarro
{
    partial class PesquisarVeiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaca = new System.Windows.Forms.Button();
            this.btnAno = new System.Windows.Forms.Button();
            this.btnCor = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar veículo";
            // 
            // btnPlaca
            // 
            this.btnPlaca.Location = new System.Drawing.Point(45, 112);
            this.btnPlaca.Name = "btnPlaca";
            this.btnPlaca.Size = new System.Drawing.Size(144, 47);
            this.btnPlaca.TabIndex = 1;
            this.btnPlaca.Text = "Placa";
            this.btnPlaca.UseVisualStyleBackColor = true;
            this.btnPlaca.Click += new System.EventHandler(this.BtnPlaca_Click);
            // 
            // btnAno
            // 
            this.btnAno.Location = new System.Drawing.Point(45, 204);
            this.btnAno.Name = "btnAno";
            this.btnAno.Size = new System.Drawing.Size(144, 47);
            this.btnAno.TabIndex = 2;
            this.btnAno.Text = "Ano";
            this.btnAno.UseVisualStyleBackColor = true;
            // 
            // btnCor
            // 
            this.btnCor.Location = new System.Drawing.Point(45, 297);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(144, 47);
            this.btnCor.TabIndex = 3;
            this.btnCor.Text = "Cor";
            this.btnCor.UseVisualStyleBackColor = true;
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(295, 112);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(144, 47);
            this.btnMarca.TabIndex = 4;
            this.btnMarca.Text = "Marca";
            this.btnMarca.UseVisualStyleBackColor = true;
            // 
            // PesquisarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.btnCor);
            this.Controls.Add(this.btnAno);
            this.Controls.Add(this.btnPlaca);
            this.Controls.Add(this.label1);
            this.Name = "PesquisarVeiculo";
            this.Text = "PesquisarVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaca;
        private System.Windows.Forms.Button btnAno;
        private System.Windows.Forms.Button btnCor;
        private System.Windows.Forms.Button btnMarca;
    }
}