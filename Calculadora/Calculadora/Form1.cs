using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    
    public partial class Form1 : Form
    {
        double tipo_de_conta, memoria1, memoria2, total;
        /*
         tipos de contas
            1 = soma
            2 = divisão
            3 = multiplicação
            4 = subtração
            5 = porcentagem
            6 = Potência
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtConta.Text = string.Empty;
            PcbImagens.ImageLocation = @"C:\Users\minat\Desktop\projects\Assest-Calculadora\10024-thinking-face-icon.png";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtConta.Text += 0;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtConta.Text += 1;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtConta.Text += 2;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtConta.Text += 3;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtConta.Text += 4;

        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtConta.Text += 5;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtConta.Text += 6;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtConta.Text += 7;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtConta.Text += 8;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtConta.Text += 9;
        }
        //divisão
        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            tipo_de_conta = 2;
            memoria1 = Convert.ToDouble(TxtConta.Text);
            TxtConta.Text = "";
            PcbImagens.ImageLocation = @"C:\Users\minat\Desktop\projects\Assest-Calculadora\divisão.png";
        }
        //multiplicação
        private void BtnMult_Click(object sender, EventArgs e)
        {
            tipo_de_conta = 3;
            memoria1 = Convert.ToDouble(TxtConta.Text);
            TxtConta.Text = "";
            PcbImagens.ImageLocation = @"C:\Users\minat\Desktop\projects\Assest-Calculadora\multiplicação.png";
        }
        //subtração
        private void BtnMenos_Click(object sender, EventArgs e)
        {
            tipo_de_conta = 4;
            memoria1 = Convert.ToDouble(TxtConta.Text);
            TxtConta.Text = "";
            PcbImagens.ImageLocation = @"C:\Users\minat\Desktop\projects\Assest-Calculadora\subtração.png";
        }
        //porentagem
        private void BtnPercent_Click(object sender, EventArgs e)
        {
            tipo_de_conta = 5;
            memoria1 = Convert.ToDouble(TxtConta.Text);
            TxtConta.Text = "";
            PcbImagens.ImageLocation = @"C:\Users\minat\Desktop\projects\Assest-Calculadora\porcentagem.png";
        }
        //potencia
        private void BtnElevado_Click(object sender, EventArgs e)
        {
            tipo_de_conta = 6;
            memoria1 = Convert.ToDouble(TxtConta.Text);
            TxtConta.Text = "";
            PcbImagens.ImageLocation = @"C:\Users\minat\Desktop\projects\Assest-Calculadora\potencia.png";
        }

        //calcular a raiz quadrada de um numero
        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            memoria1 = Convert.ToDouble(TxtConta.Text);
            double tot = Math.Sqrt(memoria1);
            TxtConta.Text = tot.ToString("F2");
            PcbImagens.ImageLocation = @"C:\Users\minat\Desktop\projects\Assest-Calculadora\raiz.png";
        }
        
        /*
         tipos de contas
            1 = soma
            2 = divisão
            3 = multiplicação
            4 = subtração
            5 = porcentagem
            6 = Potência
         */

        //calculo
        private void BtnIgual_Click(object sender, EventArgs e)
        {
            PcbImagens.ImageLocation = @"C:\Users\minat\Desktop\projects\Assest-Calculadora\igual.png";
            memoria2 = Convert.ToDouble(TxtConta.Text);
            switch (tipo_de_conta)
            {
                case 1:
                    total = memoria1 + memoria2;
                    TxtConta.Text = total.ToString();
                    break;
                case 2:
                    if (memoria2 == 0)
                    {
                        TxtConta.Text = "Error";
                    }
                    else
                    {
                        total = memoria1 / memoria2;
                        TxtConta.Text = total.ToString("F2");
                    }
                    break;
                case 3:
                    total = memoria1 * memoria2;
                    TxtConta.Text = total.ToString();
                    break;
                case 4:
                    total = memoria1 - memoria2;
                    TxtConta.Text = total.ToString();
                    break;
                case 5:
                    total = (memoria2/100) * memoria1;
                    TxtConta.Text= total.ToString();
                    break;
                case 6:
                    total = Math.Pow(memoria1, memoria2);
                    TxtConta.Text = total.ToString();
                    break;
            }
        }
        //colocar ponto
        private void BtnDot_Click(object sender, EventArgs e)
        {
            TxtConta.Text += ".";
        }
        //soma
        private void BtnSoma_Click(object sender, EventArgs e)
        {
            //Codigo para fazer a base da soma
            tipo_de_conta = 1;
            memoria1 = Convert.ToDouble(TxtConta.Text);
            TxtConta.Text = "";
            PcbImagens.ImageLocation = @"C:\Users\minat\Desktop\projects\Assest-Calculadora\soma.png";
        }
    }
}
