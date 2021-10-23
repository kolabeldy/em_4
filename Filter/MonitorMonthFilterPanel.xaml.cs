using System.Windows.Controls;

namespace em.Filter
{
    public partial class MonitorMonthFilterPanel : UserControl, IFilterPanelContent
    {
        private MonitorMonthFilterPanelViewModel model;

        private static MonitorMonthFilterPanel instance;
        public static MonitorMonthFilterPanel GetInstance(MonitorMonthFilterPanelViewModel model)
        {
            if (instance == null)
            {
                instance = new MonitorMonthFilterPanel(model);
            }
            return instance;
        }
        private MonitorMonthFilterPanel(MonitorMonthFilterPanelViewModel model)
        {
            this.model = model;
            InitializeComponent();
            DataContext = model;
        }
    }
}
