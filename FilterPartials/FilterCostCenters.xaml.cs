using System.Windows.Controls;

namespace em.FilterPartials
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
