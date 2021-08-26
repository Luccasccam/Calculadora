using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textResultado.Text += '0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResultado.Text += '3';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResultado.Text += '4';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textResultado.Text += '5';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResultado.Text += '6';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResultado.Text += '7';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResultado.Text += '8';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textResultado.Text += '9';
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                textResultado.Text += '.';
            }
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                if (operacao == "SOMA")
                {
                    textResultado.Text = Convert.ToString(valor1 + valor2);
                }
                if (operacao == "SUBTRAÇÃO")
                {
                    textResultado.Text = Convert.ToString(valor1 - valor2);
                }
                if (operacao == "MULTIPLICAÇÃO")
                {
                    textResultado.Text = Convert.ToString(valor1 * valor2);
                }
                if (operacao == "DIVISÃO")
                {
                    textResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

                textResultado.Text = "";
                operacao = "SUBTRAÇÃO";
                labelOperacao.Text = "-";
            }
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

                textResultado.Text = "";
                operacao = "MULTIPLICAÇÃO";
                labelOperacao.Text = "x";
            }
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

                textResultado.Text = "";
                operacao = "DIVISÃO";
                labelOperacao.Text = "/";
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacao.Text = "";
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            { 
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "SOMA";
                labelOperacao.Text = "+";
            }
        }
    }
}
