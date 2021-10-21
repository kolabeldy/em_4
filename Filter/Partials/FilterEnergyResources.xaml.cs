using System.Windows.Controls;

namespace em.Filter.Partials
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
