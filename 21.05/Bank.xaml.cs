using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _21._05
{
    public partial class Bank : Window
    {
        class Accounts
        {
            public Accounts(int Id, decimal balans, string types)
            {
                id = Id;
                Balans = balans;
                Types = types;
            }
            public int id { get; set; }
            public decimal Balans { get; set; }
            public string Types { get; set; }
        }

        public Bank()
        {
            InitializeComponent();
        }

        public int Id = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Id++;
                Accounts accounts = new Accounts(Id, Int32.Parse(balance_box.Text), type_box.Text);
                string h = "Номер: "+ accounts.id +"\nБаланс: " +accounts.Balans +"\nТип: "+ accounts.Types;
                MessageBox.Show(h);
            }
            catch
            {
                MessageBox.Show("Некорректно введённые данные");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            Close();
        }
    }
}
