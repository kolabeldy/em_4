using System.Windows.Controls;
using em.ViewModels;
using em.Views;

namespace em.Vievs
{
    public partial class MonthMonitor : UserControl, IMainFrameContent
    {
        private MonthMonitorViewModel model;

        private static MonthMonitor instance;
        public static MonthMonitor GetInstance(MonthMonitorViewModel model)
        {
            if (instance == null)
            {
                instance = new MonthMonitor(model);
            }
            return instance;
        }
        private MonthMonitor(MonthMonitorViewModel model)
        {
            this.model = model;
            DataContext = model;
            InitializeComponent();
        }

    }
}
