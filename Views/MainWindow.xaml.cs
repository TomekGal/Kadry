using Kadry.ViewModels;
using MahApps.Metro.Controls;


namespace Kadry.Views
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            
        }
                       
    }
}
