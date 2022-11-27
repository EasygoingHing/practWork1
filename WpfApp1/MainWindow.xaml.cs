using Microsoft.Win32;
using System.Windows;
using System;
using Lib_1;
using System.IO;

namespace WpfApp1
{    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int[] ints;

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int limit = Convert.ToInt32(textBoxlimit.Text);
                string temp = MathString.SumLimit(ints, limit, out int sum, out int kol);
                textBoxresults.Text = "Сумма: " + sum.ToString() + "\nКол-во: " + kol.ToString()
                    + "\nЧисла: " + temp;
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели некорректное значение, либо не указали предел.");
                return;
            }
        } 

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая 1, Крутолапов Валерий ИCП-31\n" +
                           "Задание: cгенерировать массив заполненный случайными целыми числами, " +
                           "распределенных в диапазоне от 2 до 10.Вычислить сумму чисел массива, " +
                           "пока она не станет больше некоторого числа - Limit.");
                
        }                             

        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int length = Convert.ToInt32(textBoxLength.Text);
                ints = MathString.CreateArr(length);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели некорректное значение.");
                return;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }                
    }  
}