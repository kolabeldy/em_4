using System.Windows.Controls;

namespace em.FilterPartials
{
    public partial class MonitorMonthFilterPanel : UserControl
    {
        private MonitorMonthFilterPanelViewModel viewModel = new MonitorMonthFilterPanelViewModel();
        public MonitorMonthFilterPanel()
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
