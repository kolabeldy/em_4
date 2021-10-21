using System.Windows.Controls;

namespace em.FilterPartials
{
    public partial class MonitorMonthFilterPanel : UserControl, IFilterPanelContent
    {
        private static MonitorMonthFilterPanel instance;
        internal static MonitorMonthFilterPanel GetInstance(MonitorMonthFilterPanelViewModel model)
        {
            if (instance == null)
            {
                instance = new MonitorMonthFilterPanel(model);
            }
            return instance;
        }
        private MonitorMonthFilterPanel(MonitorMonthFilterPanelViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
