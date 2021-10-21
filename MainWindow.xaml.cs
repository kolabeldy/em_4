using System.Windows;
using em.ViewModels;

namespace em
{
    public partial class MainWindow : Window
    {
        public MainWindowViewModel model = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = model;
        }
    }
}
