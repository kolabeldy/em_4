using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace em.FilterPartials
{
    public partial class MonitorMonthFilterPanel : UserControl
    {
        public FilterPeriod FilterPeriodPanelContent { get; set; }
        public FilterCostCenters FilterCostCentersPanelContent { get; set; }
        public FilterEnergyResources FilterEnergyResourcesPanelContent { get; set; }
        public FilterNormTypes FilterNormTypesPanelContent { get; set; }

        public MonitorMonthFilterPanel()
        {
            FilterPeriodPanelContent = new FilterPeriod();
            FilterCostCentersPanelContent = new FilterCostCenters();
            FilterEnergyResourcesPanelContent = new FilterEnergyResources();
            FilterNormTypesPanelContent = new FilterNormTypes();
            InitializeComponent();
            DataContext = this;
        }
    }
}
