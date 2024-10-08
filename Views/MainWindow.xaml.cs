﻿using LittleUserManager.ViewModels;
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

namespace LittleUserManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel mainViewModel = new MainWindowViewModel();
            DataContext = mainViewModel;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataListView.Items.Filter = CustomFilter;
        }

        private bool CustomFilter(object obj)
        {
            var user = (UserViewModel)obj;
            return user.Name.ToLower().Contains(FilterInput.Text.ToLower());
        }
    }
}
