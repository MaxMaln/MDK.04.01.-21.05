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

namespace _21._05
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Metod1_Click(object sender, RoutedEventArgs e)
        {
            Metod1();
        }
        private void Metod2_Click(object sender, RoutedEventArgs e)
        {
            Metod2();
        }
        public void Metod1()
        {
            try
            {
                int a = Int32.Parse(onezizlo_textbox.Text);
                int b = Int32.Parse(twozizlo_textbox.Text);
                if (a > b)
                {
                    MessageBox.Show("Больше " + a);
                }
                else if (a == b)
                {
                    MessageBox.Show("Они равны");
                }
                else
                {
                    MessageBox.Show("Больше " + b);
                }
            }
            catch
            {
                MessageBox.Show("Некорректно введённые данные");
            }
        }
        public void Metod2()
        {
            string a = text1.Text;
            string b = text2.Text;
            text1.Text = b;
            text2.Text = a;
        }
        private void Metod3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Metod3().ToString());
        }
        public bool Metod3()
        {
            try
            {
                int a = Int32.Parse(factorial_textbox.Text);
                int o = 1;
                checked
                {
                    for (int i = 1; i <= a; i++)
                    {
                        o = o * i;
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                checked
                {
                    return n * Factorial(n - 1);
                }
            }
        }

        private void Metod4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(Factorial(Int32.Parse(factorial_textbox.Text)).ToString());
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bank a = new Bank();
            a.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int[,] temperature = new int[12, 30];
            string temp = "";
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    int y = r.Next(-40, 40);
                    temperature[i, j] = y;
                    temp = temp + temperature[i, j] + "   ";
                    if(j == 29)
                    {
                        temp = temp + "\n";
                    }
                }
            }
            MessageBox.Show(temp);
        }
    }
}
