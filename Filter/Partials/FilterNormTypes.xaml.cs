using System.Windows.Controls;

namespace em.Filter.Partials
{
    public partial class FilterNormTypes : UserControl
    {
        private FilterNormTypesViewModel viewModel = new();

        public FilterNormTypes()
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
