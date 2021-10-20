using System.Windows.Controls;

namespace em.FilterPartials
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
