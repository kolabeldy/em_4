using em.Vievs;
using em.ViewModels;
using em.ViewModels.Base;
using System;
using System.Windows.Controls;

namespace em.FilterPartials
{
    internal class MonitorMonthFilterPanelViewModel : ViewModelBase
    {
        private static MonitorMonthFilterPanelViewModel instance;
        public static MonitorMonthFilterPanelViewModel GetInstance(UserControl frame)
        {
            if (instance == null)
            {
                instance = new MonitorMonthFilterPanelViewModel();
                instance.monitorModel = new MonthMonitorViewModel();
                instance.monitor = new MonthMonitor(instance.monitorModel);
                instance.frame = frame;

            }
            return instance;
        }

        private MonthMonitor monitor;
        private MonthMonitorViewModel monitorModel;
        private UserControl frame;
        public FilterPeriod FilterPeriodPanelContent { get; set; }
        public FilterCostCenters FilterCostCentersPanelContent { get; set; }
        public FilterEnergyResources FilterEnergyResourcesPanelContent { get; set; }
        public FilterNormTypes FilterNormTypesPanelContent { get; set; }

        private DateTime _SelectedStartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        public DateTime SelectedStartDate
        { 
            get => _SelectedStartDate;
            set
            {
                Set(ref _SelectedStartDate, value);
            }
        }
        private DateTime _SelectedEndDate = DateTime.Now;
        public DateTime SelectedEndDate
        {
            get => _SelectedEndDate;
            set
            {
                Set(ref _SelectedEndDate, value);
            }
        }
        public override void Execute(object? parameter) { }
        private MonitorMonthFilterPanelViewModel()
        {
            FilterPeriodPanelContent = new FilterPeriod();
            FilterCostCentersPanelContent = new FilterCostCenters();
            FilterEnergyResourcesPanelContent = new FilterEnergyResources();
            FilterNormTypesPanelContent = new FilterNormTypes();
        }

        public void PanelShow()
        {
            monitor = new MonthMonitor(monitorModel);
            frame.Content = null;
            frame.Content = instance.monitor;
        }
        public void FilterShow()
        {
            MonitorMonthFilterPanel.GetInstance(this);

        }
    }
}
