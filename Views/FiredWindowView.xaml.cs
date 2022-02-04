using Kadry.ViewModels;
using MahApps.Metro.Controls;


namespace Kadry.Views
{
    /// <summary>
    /// Logika interakcji dla klasy FiredWindow.xaml
    /// </summary>
    public partial class FiredWindowView : MetroWindow
    {
        public FiredWindowView(int id)
        {
            InitializeComponent();
            DataContext = new FiredWindowViewModel(id );
        }
    }
}
