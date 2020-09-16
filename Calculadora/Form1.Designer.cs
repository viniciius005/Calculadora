namespace Calculadora
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
            this.Soma = new System.Windows.Forms.Button();
            this.Subtrcao = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.Button();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Valor1 = new System.Windows.Forms.Label();
            this.Valor2 = new System.Windows.Forms.Label();
            this.Mult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Soma
            // 
            this.Soma.Location = new System.Drawing.Point(164, 38);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(75, 23);
            this.Soma.TabIndex = 0;
            this.Soma.Text = "+";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // Subtrcao
            // 
            this.Subtrcao.Location = new System.Drawing.Point(164, 67);
            this.Subtrcao.Name = "Subtrcao";
            this.Subtrcao.Size = new System.Drawing.Size(75, 23);
            this.Subtrcao.TabIndex = 1;
            this.Subtrcao.Text = "-";
            this.Subtrcao.UseVisualStyleBackColor = true;
            this.Subtrcao.Click += new System.EventHandler(this.Subtrcao_Click);
            // 
            // Divisao
            // 
            this.Divisao.Location = new System.Drawing.Point(164, 96);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(75, 23);
            this.Divisao.TabIndex = 2;
            this.Divisao.Text = "/";
            this.Divisao.UseVisualStyleBackColor = true;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(35, 120);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 6;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(35, 56);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 7;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(62, 165);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 8;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Valor1
            // 
            this.Valor1.AutoSize = true;
            this.Valor1.Location = new System.Drawing.Point(32, 37);
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(37, 13);
            this.Valor1.TabIndex = 9;
            this.Valor1.Text = "Valor1";
            // 
            // Valor2
            // 
            this.Valor2.AutoSize = true;
            this.Valor2.Location = new System.Drawing.Point(32, 101);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(37, 13);
            this.Valor2.TabIndex = 10;
            this.Valor2.Text = "Valor2";
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(164, 125);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(75, 23);
            this.Mult.TabIndex = 11;
            this.Mult.Text = "X";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Resultado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Valor1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.Subtrcao);
            this.Controls.Add(this.Soma);
            this.Name = "Form1";
            this.Text = "Calculadora V 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Subtrcao;
        private System.Windows.Forms.Button Divisao;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Valor1;
        private System.Windows.Forms.Label Valor2;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Label label1;
    }
}

