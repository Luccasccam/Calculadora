
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
            this.textResultado = new System.Windows.Forms.TextBox();
            this.labelOperacao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSubtracao = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.buttonMultiplicacao = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDivisao = new System.Windows.Forms.Button();
            this.buttonPonto = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(2, 12);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(198, 20);
            this.textResultado.TabIndex = 0;
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelOperacao
            // 
            this.labelOperacao.AutoSize = true;
            this.labelOperacao.BackColor = System.Drawing.SystemColors.Window;
            this.labelOperacao.Location = new System.Drawing.Point(12, 15);
            this.labelOperacao.Name = "labelOperacao";
            this.labelOperacao.Size = new System.Drawing.Size(0, 13);
            this.labelOperacao.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSoma
            // 
            this.buttonSoma.Location = new System.Drawing.Point(156, 92);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(45, 104);
            this.buttonSoma.TabIndex = 5;
            this.buttonSoma.Text = "+";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(3, 38);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(45, 49);
            this.buttonLimpar.TabIndex = 11;
            this.buttonLimpar.Text = "C";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSubtracao
            // 
            this.buttonSubtracao.Location = new System.Drawing.Point(156, 38);
            this.buttonSubtracao.Name = "buttonSubtracao";
            this.buttonSubtracao.Size = new System.Drawing.Size(45, 49);
            this.buttonSubtracao.TabIndex = 10;
            this.buttonSubtracao.Text = "-";
            this.buttonSubtracao.UseVisualStyleBackColor = true;
            this.buttonSubtracao.Click += new System.EventHandler(this.buttonSubtracao_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(105, 148);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 49);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(54, 148);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 49);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 49);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonResultado
            // 
            this.buttonResultado.Location = new System.Drawing.Point(156, 202);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(45, 104);
            this.buttonResultado.TabIndex = 16;
            this.buttonResultado.Text = "=";
            this.buttonResultado.UseVisualStyleBackColor = true;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // buttonMultiplicacao
            // 
            this.buttonMultiplicacao.Location = new System.Drawing.Point(105, 38);
            this.buttonMultiplicacao.Name = "buttonMultiplicacao";
            this.buttonMultiplicacao.Size = new System.Drawing.Size(45, 49);
            this.buttonMultiplicacao.TabIndex = 15;
            this.buttonMultiplicacao.Text = "X";
            this.buttonMultiplicacao.UseVisualStyleBackColor = true;
            this.buttonMultiplicacao.Click += new System.EventHandler(this.buttonMultiplicacao_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(105, 93);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 49);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button13_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(54, 93);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 49);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button14_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 49);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button15_Click);
            // 
            // buttonDivisao
            // 
            this.buttonDivisao.Location = new System.Drawing.Point(54, 38);
            this.buttonDivisao.Name = "buttonDivisao";
            this.buttonDivisao.Size = new System.Drawing.Size(45, 49);
            this.buttonDivisao.TabIndex = 20;
            this.buttonDivisao.Text = "/";
            this.buttonDivisao.UseVisualStyleBackColor = true;
            this.buttonDivisao.Click += new System.EventHandler(this.buttonDivisao_Click);
            // 
            // buttonPonto
            // 
            this.buttonPonto.Location = new System.Drawing.Point(105, 258);
            this.buttonPonto.Name = "buttonPonto";
            this.buttonPonto.Size = new System.Drawing.Size(45, 49);
            this.buttonPonto.TabIndex = 19;
            this.buttonPonto.Text = ".";
            this.buttonPonto.UseVisualStyleBackColor = true;
            this.buttonPonto.Click += new System.EventHandler(this.buttonPonto_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(3, 258);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(96, 48);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 309);
            this.Controls.Add(this.buttonDivisao);
            this.Controls.Add(this.buttonPonto);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.buttonMultiplicacao);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSubtracao);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOperacao);
            this.Controls.Add(this.textResultado);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label labelOperacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSubtracao;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonResultado;
        private System.Windows.Forms.Button buttonMultiplicacao;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonDivisao;
        private System.Windows.Forms.Button buttonPonto;
        private System.Windows.Forms.Button button0;
    }
}

