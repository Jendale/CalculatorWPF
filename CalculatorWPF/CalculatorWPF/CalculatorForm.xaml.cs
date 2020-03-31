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

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double result, num1, num2;
        string operation;
        bool isPeriodUsed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            tbxEntry.Text += "1";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            tbxEntry.Text += "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            tbxEntry.Text += "3";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            tbxEntry.Text += "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            tbxEntry.Text += "5";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            tbxEntry.Text += "6";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            tbxEntry.Text += "7";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            tbxEntry.Text += "8";
        } 

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            tbxEntry.Text += "9";
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            tbxEntry.Text += "0";
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(tbxEntry.Text);
            operation = "+";
            tbxEntry.Text = "";
            isPeriodUsed = false;
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(tbxEntry.Text);
            operation = "-";
            tbxEntry.Text = "";
            isPeriodUsed = false;
        }

        private void BtnMul_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(tbxEntry.Text);
            operation = "*";
            tbxEntry.Text = "";
            isPeriodUsed = false;
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(tbxEntry.Text);
            operation = "/";
            tbxEntry.Text = "";
            isPeriodUsed = false;
        }

        private void BtnMod_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(tbxEntry.Text);
            operation = "%";
            tbxEntry.Text = "";
            isPeriodUsed = false;
        }

        private void BtnPoint_Click(object sender, RoutedEventArgs e)
        {
            if (isPeriodUsed == true)
            {
                MessageBox.Show("Invalid Operation", "Message");
            }
            else
            {
                tbxEntry.Text += ".";
                isPeriodUsed = true;
            }
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            
            if (num1 == 0 && num2 == 0)
            {
                return;
            }

            num2 = Convert.ToDouble(tbxEntry.Text);
            tbxEntry.Text = "";

            if(operation == "+")
            {
                result = num1 + num2;
                tbxEntry.Text = Convert.ToString(result);
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                tbxEntry.Text = Convert.ToString(result);
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                tbxEntry.Text = Convert.ToString(result);
            }
            else if (operation == "/")
            {
                if (num2 == 0)
                {
                    tbxResult.Text = "Undefined";
                }
                else
                {
                    result = num1 / num2;
                    tbxEntry.Text = Convert.ToString(result);
                }
            }
            else if (operation == "%")
            {
                result = num1 % num2;
                tbxEntry.Text = Convert.ToString(result);
            }

            num1 = num2 = 0;
            operation = "";
            isPeriodUsed = false;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (tbxEntry.Text.Length > 0)
            {
                tbxEntry.Text = tbxEntry.Text.Remove(tbxEntry.Text.Length - 1);
            }   
        }

        private void BtnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            tbxEntry.Text = "";
            tbxResult.Text = "";
            isPeriodUsed = false;
        }
    }
}
