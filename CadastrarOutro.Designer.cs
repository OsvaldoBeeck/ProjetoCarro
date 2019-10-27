namespace ProjetoCarro
{
    partial class CadastrarOutroVeiculo
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
            this.txtSim = new System.Windows.Forms.Button();
            this.txtNao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deseja cadastrar outro veiculo?";
            // 
            // txtSim
            // 
            this.txtSim.Location = new System.Drawing.Point(103, 125);
            this.txtSim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSim.Name = "txtSim";
            this.txtSim.Size = new System.Drawing.Size(202, 72);
            this.txtSim.TabIndex = 1;
            this.txtSim.Text = "SIM";
            this.txtSim.UseVisualStyleBackColor = true;
            this.txtSim.Click += new System.EventHandler(this.TxtSim_Click);
            // 
            // txtNao
            // 
            this.txtNao.Location = new System.Drawing.Point(342, 125);
            this.txtNao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNao.Name = "txtNao";
            this.txtNao.Size = new System.Drawing.Size(202, 72);
            this.txtNao.TabIndex = 2;
            this.txtNao.Text = "NÃO";
            this.txtNao.UseVisualStyleBackColor = true;
            this.txtNao.Click += new System.EventHandler(this.TxtNao_Click);
            // 
            // CadastrarOutroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 287);
            this.Controls.Add(this.txtNao);
            this.Controls.Add(this.txtSim);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CadastrarOutroVeiculo";
            this.Text = "Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtSim;
        private System.Windows.Forms.Button txtNao;
    }
}