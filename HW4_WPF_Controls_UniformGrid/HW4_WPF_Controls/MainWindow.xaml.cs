using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW4_WPF_Controls
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            resultTextBox.Focus();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text += plusButton.Content.ToString();
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result();
            }
            catch (Exception ex)
            {
                resultTextBox.Text = "Error!";
            }
        }

        private void Result()
        {
            String op;
            int indexOp = 0;
            if (resultTextBox.Text.Contains("+"))
                indexOp = resultTextBox.Text.IndexOf("+");

            else if (resultTextBox.Text.Contains("-"))
                indexOp = resultTextBox.Text.IndexOf("-");

            else if (resultTextBox.Text.Contains("*"))
                indexOp = resultTextBox.Text.IndexOf("*");

            else if (resultTextBox.Text.Contains("/"))
                indexOp = resultTextBox.Text.IndexOf("/");

            op = resultTextBox.Text.Substring(indexOp, 1);
            double a = Convert.ToDouble(resultTextBox.Text.Substring(0, indexOp));
            double b = Convert.ToDouble(resultTextBox.Text.Substring(indexOp + 1, resultTextBox.Text.Length - indexOp - 1));

            if (op == "+")
                resultTextBox.Text += "=" + (a + b);

            else if (op == "-")
                resultTextBox.Text += "=" + (a - b);

            else if (op == "*")
                resultTextBox.Text += "=" + (a * b);

            else
                resultTextBox.Text += "=" + (a / b);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultTextBox.Text.Length > 0)
                resultTextBox.Text = resultTextBox.Text.Substring(0, resultTextBox.Text.Length - 1);
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = "0";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (resultTextBox.Text != "0")
                resultTextBox.Text += button7.Content.ToString();
            else
            {
                resultTextBox.Text = "";
                resultTextBox.Text += button7.Content.ToString();
            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (resultTextBox.Text != "0")
                resultTextBox.Text += button8.Content.ToString();
            else
            {
                resultTextBox.Text = "";
                resultTextBox.Text += button8.Content.ToString();
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (resultTextBox.Text != "0")
                resultTextBox.Text += button9.Content.ToString();
            else
            {
                resultTextBox.Text = "";
                resultTextBox.Text += button9.Content.ToString();
            }
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text += divideButton.Content.ToString();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (resultTextBox.Text != "0")
                resultTextBox.Text += button4.Content.ToString();
            else
            {
                resultTextBox.Text = "";
                resultTextBox.Text += button4.Content.ToString();
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (resultTextBox.Text != "0")
                resultTextBox.Text += button5.Content.ToString();
            else
            {
                resultTextBox.Text = "";
                resultTextBox.Text += button5.Content.ToString();
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (resultTextBox.Text != "0")
                resultTextBox.Text += button6.Content.ToString();
            else
            {
                resultTextBox.Text = "";
                resultTextBox.Text += button6.Content.ToString();
            }
        }

        private void MultiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text += multiplicationButton.Content.ToString();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (resultTextBox.Text != "0")
                resultTextBox.Text += button1.Content.ToString();
            else
            {
                resultTextBox.Text = "";
                resultTextBox.Text += button1.Content.ToString();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (resultTextBox.Text != "0")
                resultTextBox.Text += button2.Content.ToString();
            else
            {
                resultTextBox.Text = "";
                resultTextBox.Text += button2.Content.ToString();
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (resultTextBox.Text != "0")
                resultTextBox.Text += button3.Content.ToString();
            else
            {
                resultTextBox.Text = "";
                resultTextBox.Text += button3.Content.ToString();
            }
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text += minusButton.Content.ToString();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (resultTextBox.Text != "0")
                resultTextBox.Text += button0.Content.ToString();
            else
            {
                resultTextBox.Text = "";
                resultTextBox.Text += button0.Content.ToString();
            }
        }

        private void SqrtButton_Click(object sender, RoutedEventArgs e)
        {
            var isDouble = double.TryParse(resultTextBox.Text, out double number);
            if (isDouble)
            {
                resultTextBox.Text = string.Format
                (
                    "{0}{1} = {2}",
                    "\u221A",
                    resultTextBox.Text,
                    Math.Round(Math.Sqrt(number), 2)
                );
            }
            else resultTextBox.Text = "Error!";
        }

        private void OneDivideNumButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(resultTextBox.Text))
            {
                double res = 1 / Convert.ToDouble(resultTextBox.Text);
                resultTextBox.Text = string.Format
                (
                    "{0}/{1} = {2}",
                    "1",
                    resultTextBox.Text,
                    res
                );
            }
        }

        private void BackspaceToolBar_Click(object sender, RoutedEventArgs e)
        {
            BackButton_Click(sender, e);
        }

        private void PlusToolBar_Click(object sender, RoutedEventArgs e)
        {
            PlusButton_Click(sender, e);
        }

        private void MinusToolBar_Click(object sender, RoutedEventArgs e)
        {
            MinusButton_Click(sender, e);
        }

        private void MultiplyToolBar_Click(object sender, RoutedEventArgs e)
        {
            MultiplicationButton_Click(sender, e);
        }

        private void DivideToolBar_Click(object sender, RoutedEventArgs e)
        {
            DivideButton_Click(sender, e);
        }

        private void SqrtToolBar_Click(object sender, RoutedEventArgs e)
        {
            SqrtButton_Click(sender, e);
        }

        private void EqualToolBar_Click(object sender, RoutedEventArgs e)
        {
            EqualButton_Click(sender, e);
        }
    }
}
