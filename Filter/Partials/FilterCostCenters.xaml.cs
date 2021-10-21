using System.Windows.Controls;

namespace em.Filter.Partials
{
    public partial class FilterCostCenters : UserControl
    {
        private FilterCostCentersViewModel viewModel = new();
        public FilterCostCenters()
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
