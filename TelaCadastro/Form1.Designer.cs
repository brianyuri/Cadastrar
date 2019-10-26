namespace TelaCadastro
{
    partial class Form1
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
            this.txbnome = new System.Windows.Forms.TextBox();
            this.txbtelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncadastra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(88, 28);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(108, 20);
            this.txbnome.TabIndex = 0;
            // 
            // txbtelefone
            // 
            this.txbtelefone.Location = new System.Drawing.Point(88, 74);
            this.txbtelefone.Name = "txbtelefone";
            this.txbtelefone.Size = new System.Drawing.Size(100, 20);
            this.txbtelefone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // btncadastra
            // 
            this.btncadastra.Location = new System.Drawing.Point(88, 130);
            this.btncadastra.Name = "btncadastra";
            this.btncadastra.Size = new System.Drawing.Size(75, 23);
            this.btncadastra.TabIndex = 4;
            this.btncadastra.Text = "Cadastrar";
            this.btncadastra.UseVisualStyleBackColor = true;
            this.btncadastra.Click += new System.EventHandler(this.Btncadastra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 317);
            this.Controls.Add(this.btncadastra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbtelefone);
            this.Controls.Add(this.txbnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.TextBox txbtelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncadastra;
    }
}

