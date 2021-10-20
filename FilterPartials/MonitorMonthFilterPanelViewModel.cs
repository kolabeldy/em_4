using em.ViewModels.Base;
using System;

namespace em.FilterPartials
{
    internal class MonitorMonthFilterPanelViewModel : ViewModelBase
    {
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
        public MonitorMonthFilterPanelViewModel()
        {
            FilterPeriodPanelContent = new FilterPeriod();
            FilterCostCentersPanelContent = new FilterCostCenters();
            FilterEnergyResourcesPanelContent = new FilterEnergyResources();
            FilterNormTypesPanelContent = new FilterNormTypes();
        }
    }
}
