﻿using System;
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
using System.Text.RegularExpressions;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void getresult_Click(object sender, RoutedEventArgs e)
        {
            Regex sumChecker = new Regex(@"^[0-9]*$");
            Regex nameChecker = new Regex(@"^[A-ЯЁ][а-яё]+\s[A-ЯЁ][.]+[A-ЯЁ][.]+$");

            if (String.IsNullOrEmpty(cashier.Text)
                && String.IsNullOrEmpty(sum.Text)
                && String.IsNullOrEmpty(date.Text))
            {
                MessageBox.Show("Ошибка!", "Данные некорректны", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (Convert.ToInt32(date.Text?.Substring(0, 2)) < 32 && Convert.ToInt32(date.Text?.Substring(0, 2)) > 0
                && Convert.ToInt32(date.Text?.Substring(3, 2)) < 13 && Convert.ToInt32(date.Text?.Substring(3, 2)) > 0
                && Convert.ToInt32(date.Text?.Substring(6, 4)) < 2100 && Convert.ToInt32(date.Text?.Substring(6, 4)) > 1999
                && sumChecker.IsMatch(sum.Text)
                && nameChecker.IsMatch(cashier.Text))
            {
                if (Convert.ToInt32(sum.Text) < 50000)
                {
                    if (2024 - Convert.ToInt32(date.Text?.Substring(6, 4)) > 3) 
                    {
                        result.Text = (Convert.ToDouble(sum.Text) * 1.08).ToString();
                    } 
                    else
                    {
                        result.Text = (Convert.ToDouble(sum.Text) * 1.03).ToString();
                    }
                }
                else
                {
                    if (2024 - Convert.ToInt32(date.Text?.Substring(6, 4)) > 3)
                    {
                        result.Text = (Convert.ToDouble(sum.Text) * 1.11).ToString();
                    }
                    else
                    {
                        result.Text = (Convert.ToDouble(sum.Text) * 1.06).ToString();
                    }
                }
            }
        }
    }
}
