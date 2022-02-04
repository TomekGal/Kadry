using Kadry.Models;
using Kadry.Models.Domains;
using Kadry.Models.Wrappers;
using Kadry.ViewModels;
using MahApps.Metro.Controls;
using System;


namespace Kadry.Views
{
    /// <summary>
    /// Logika interakcji dla klasy AddEditEmployeeView.xaml
    /// </summary>
    public partial class AddEditEmployeeView : MetroWindow
    {
        public AddEditEmployeeView( EmployeeWrapper employee=null)
        {
            InitializeComponent();
            DataContext = new AddEditEmployeeViewModel(employee);
        }

        
    }
}
