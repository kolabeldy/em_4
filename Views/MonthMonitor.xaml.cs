using System.Windows.Controls;
using em.ViewModels;
using em.Views;

namespace em.Vievs
{
    public partial class MonthMonitor : UserControl, IMainFrameContent
    {
        public int ParamInt = 5;
        internal MonthMonitor(MonthMonitorViewModel model)
        {
            DataContext = model;
            InitializeComponent();
        }

    }
}
