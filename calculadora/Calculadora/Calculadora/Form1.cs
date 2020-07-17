using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operador;
        double num1, num2 ,resultado;
        Boolean ban_btn = true, ban_num = true, ban_ope = true;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(ban_num == true)
            {
                pantalla.Clear();
                pantalla.Text = "0";
                ban_num = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "0";
            }
            ban_btn = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                pantalla.Clear();
                pantalla.Text = "1";
                ban_num = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "1";
            }
            ban_btn = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                pantalla.Clear();
                pantalla.Text = "2";
                ban_num = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "2";
            }
            ban_btn = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                pantalla.Clear();
                pantalla.Text = "3";
                ban_num = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "3";
            }
            ban_btn = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                pantalla.Clear();
                pantalla.Text = "4";
                ban_num = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "4";
            }
            ban_btn = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                pantalla.Clear();
                pantalla.Text = "5";
                ban_num = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "5";
            }
            ban_btn = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                pantalla.Clear();
                pantalla.Text = "6";
                ban_num = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "6";
            }
            ban_btn = false;
        }

        private void brn7_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                pantalla.Clear();
                pantalla.Text = "7";
                ban_num = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "7";
            }
            ban_btn = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                pantalla.Clear();
                pantalla.Text = "8";
                ban_num = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "8";
            }
            ban_btn = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                pantalla.Clear();
                pantalla.Text = "9";
                ban_num = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "9";
            }
            ban_btn = false;
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
            ban_num = true;
            ban_ope = true;
            ban_btn = true;
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (pantalla.TextLength > 1)
            {
                pantalla.Text = pantalla.Text.Remove(pantalla.Text.Length - 1, 1);
            }
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            operador = "-";
            ban_num = true;

            if (ban_ope)
            {
                num1 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    num2 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                    f_switch(operador);
                    num1 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                    ban_num = true;
                    ban_btn = true;
                }
            }
        }

        private void btn_por_Click(object sender, EventArgs e)
        {
            operador = "*";
            ban_num = true;

            if (ban_ope)
            {
                num1 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    num2 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                    f_switch(operador);
                    num1 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                    ban_num = true;
                    ban_btn = true;
                }
            }
        }

        private void btn_entre_Click(object sender, EventArgs e)
        {
            operador = "/";
            ban_num = true;

            if (ban_ope)
            {
                num1 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    num2 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                    f_switch(operador);
                    num1 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                    ban_num = true;
                    ban_btn = true;
                }
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if(ban_btn == false)
            {
                if (ban_ope == false)
                {
                    num2 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                    f_switch(operador);
                    ban_num = true;
                    ban_btn = true;
                    ban_ope = true;
                }
            }
            
        }

        private void btn_suna_Click(object sender, EventArgs e)
        {
            operador = "+";
            ban_num = true;

            if (ban_ope)
            {
                num1 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    num2 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                    f_switch(operador);
                    num1 = Double.Parse(pantalla.Text); //convierte un texto a numero (Decimal o Double)
                    ban_num = true;
                    ban_btn = true;
                }
            }
            
        }

        private Double f_switch(string operacion)
        {
            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }

            pantalla.Text = resultado.ToString();
            return resultado;
        }
    }
}
