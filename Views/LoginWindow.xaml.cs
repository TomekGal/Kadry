﻿using Kadry.ViewModels;
using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace Kadry.Views
{
    /// <summary>
    /// Logika interakcji dla klasy LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : MetroWindow
    {
        public LoginWindow()
        {
            InitializeComponent();
            
            DataContext = new LoginWindowViewModel();
        }
    }
}
