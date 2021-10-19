using System.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace em.FilterPartials
{
    public partial class FilterCostCenters : UserControl
    {
        public FilterCostCenters()
        {
            InitializeComponent();
        }
        private void MainComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainComboBox.SelectedIndex > 0)
            {
                SlaveComboBox.SelectedIndex = -1;
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
                SlaveComboBox.SelectedIndex = -1;
                MainComboBox.SelectedIndex = -1;
            }
        }
        private void OtherClear_Click(object sender, RoutedEventArgs e)
        {
            OtherComboBox.SelectedIndex = -1;
        }
         private void SlaveComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SlaveComboBox.SelectedIndex > 0)
            {
                OtherComboBox.SelectedIndex = -1;
                MainComboBox.SelectedIndex = -1;
            }
        }
       private void SlaveClear_Click(object sender, RoutedEventArgs e)
        {
            SlaveComboBox.SelectedIndex = -1;
        }
    }
}
