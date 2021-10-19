using System.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace em.FilterPartials
{
    public partial class FilterNormTypes : UserControl
    {
        public FilterNormTypes()
        {
            InitializeComponent();
        }
        private void MainComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainComboBox.SelectedIndex > 0)
            {
            }
        }
        private void MainClear_Click(object sender, RoutedEventArgs e)
        {
            MainComboBox.SelectedIndex = -1;
        }
    }
}
