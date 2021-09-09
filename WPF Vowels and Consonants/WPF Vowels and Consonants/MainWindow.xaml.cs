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

namespace WPF_Vowels_and_Consonants
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnEnter_Click_1(object sender, RoutedEventArgs e)
        {
            lstConsonants.Items.Clear();
            lstConsonants.Items.Clear();

            string word = txtWord.Text;

            foreach (char letter in word.ToLower())
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    lstVowels.Items.Add(letter);
                }
                else
                {
                    lstConsonants.Items.Add(letter);
                }

            }

            txtWord.Clear();
        }
    }
}
