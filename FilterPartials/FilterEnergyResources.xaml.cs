using System.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace em.FilterPartials
{
    public partial class FilterEnergyResources : UserControl
    {
        public FilterEnergyResources()
        {
            InitializeComponent();
        }
        private void MainComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainComboBox.SelectedIndex > 0)
            {
                OtherComboBox.SelectedIndex = -1;
            }
        }
        private void MainClear_Click(object sender, RoutedEventArgs e)
        {
            MainComboBox.SelectedIndex = -1;
        }
        private void OtherComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OtherComboBox.SelectedIndex > 0)
            {
                MainComboBox.SelectedIndex = -1;
            }
        }
        private void OtherClear_Click(object sender, RoutedEventArgs e)
        {
            OtherComboBox.SelectedIndex = -1;
        }
    }
}
