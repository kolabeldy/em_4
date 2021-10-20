using System.Windows.Controls;

namespace em.FilterPartials
{
    public partial class FilterEnergyResources : UserControl
    {
        private FilterEnergyResourcesViewModel viewModel = new();
        public FilterEnergyResources()
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
