using System;
using System.Windows.Forms;

namespace _1
{
    public interface IOperation
    {
        void Execute();
    }

    public partial class Form1 : Form
    {
        private int memoryValue;
        string res;
        private Calculator calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator(textBox, label1);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //textBox.Clear();
            textBox.Text = textBox.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 9;
        }
        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Поле TextBox пустое. Введите значение."); return;
            }
            calculator.SetOperator(1);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Поле TextBox пустое. Введите значение."); return;
            }
            calculator.SetOperator(2);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Поле TextBox пустое. Введите значение."); return;
            }
            calculator.SetOperator(3);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Поле TextBox пустое. Введите значение."); return;
            }
            calculator.SetOperator(4);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox.Text = "";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Поле TextBox пустое. Введите значение."); return;
            }
            calculator.SetOperator(5);
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Поле TextBox пустое. Введите значение."); return;
            }

            calculator.SetOperator(6);
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Поле TextBox пустое. Введите значение."); return;
            }
            try
            {
                calculator.Execute();
                label1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении операции: " + ex.Message);
            }
        }

        private void buttonMs_Click(object sender, EventArgs e)
        {
            try
            {
                memoryValue = int.Parse(textBox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка при сохранении числа в память: некорректный формат числа. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении числа в память: " + ex.Message);
            }
        }

        private void buttonMr_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text += memoryValue.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка при извлечении числа из памяти: некорректный формат числа.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при извлечении числа из памяти: " + ex.Message);
            }
        }
    }

    public class Calculator : IOperation
    {
        private int a;
        private string res;
        private double b;
        private int currentOperator;
        private TextBox textBox;
        private Label label1;

        public Calculator(TextBox textBox, Label label1)
        {
            this.textBox = textBox;
            this.label1 = label1;
        }

        public void Execute()
        {
            try
            {
                switch (currentOperator)
                {
                    case 1:
                        var secondNumber = textBox.Text.Split('+')[1];
                        b = int.Parse(res) + int.Parse(secondNumber);
                        textBox.Text = b.ToString();
                        break;
                    case 2:
                        secondNumber = textBox.Text.Split('-')[1];
                        b = int.Parse(res) - int.Parse(secondNumber);
                        textBox.Text = b.ToString();
                        break;
                    case 3:
                        secondNumber = textBox.Text.Split('/')[1];
                        b = int.Parse(res) / double.Parse(secondNumber);
                        textBox.Text = b.ToString();
                        break;
                    case 4:
                        secondNumber = textBox.Text.Split('*')[1];
                        b = a * int.Parse(secondNumber);
                        textBox.Text = b.ToString();
                        break;
                    case 5:
                        secondNumber = textBox.Text.Split('/')[1];
                        b = a / int.Parse(secondNumber);
                        textBox.Text = b.ToString();
                        break;
                    case 6:
                        secondNumber = textBox.Text.Split('%')[1];
                        b = a % int.Parse(secondNumber);
                        textBox.Text = b.ToString();
                        break;

                    default:
                        break;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка при выполнении операции: некорректный формат числа. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении операции: " + ex.Message);
            }
        }
        public void SetOperator(int operatorCode)
        {
            a = int.Parse(textBox.Text);
            textBox.Clear();
            currentOperator = operatorCode;

            switch (operatorCode)
            {
                case 1:
                    textBox.Text  = a +  "+";
                    break;
                case 2:
                    textBox.Text = a + "-";
                    break;
                case 3:
                    textBox.Text = a + "/";
                    break;
                case 4:
                    textBox.Text = a + "*";
                    break;
                case 5:
                    textBox.Text = a + "/";
                    break;
                case 6:
                    textBox.Text = a + "%";
                    break;
                default:
                    break;
            }

            res = textBox.Text;
            res = res.Remove(res.Length - 1, 1);          
          
           
        }

    }
}