﻿using School_Bus.ViewModels;
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

namespace School_Bus.Views.Student
{
    /// <summary>
    /// Interaction logic for StudentAddView.xaml
    /// </summary>
    public partial class StudentAddView : UserControl
    {
        public StudentAddView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            StudentViewModel.inputwindow.Close();
        }
    }
}
