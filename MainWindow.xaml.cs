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


        private bool isClosePress = false;
        private void PopupBox_Closed(object sender, RoutedEventArgs e)
        {
            if (!isClosePress)
                FilterPopup.IsPopupOpen = true;
        }

        private void PopupCloseButton_Click(object sender, RoutedEventArgs e)
        {
            isClosePress = true;
            FilterPopup.IsPopupOpen = false;
            isClosePress = false;
        }
    }
}
