using em.Filter.Partials;
using em.Vievs;
using em.ViewModels;
using em.ViewModels.Base;
using System;
using System.Windows.Controls;

namespace em.Filter
{
    internal class MonitorMonthFilterPanelViewModel : ViewModelBase, IFilterPanelViewModel
    {
        private static MonitorMonthFilterPanelViewModel instance;
        public static MonitorMonthFilterPanelViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MonitorMonthFilterPanelViewModel();
            }
            return instance;
        }

        public FilterPeriod FilterPeriodPanelContent { get; set; }
        public FilterCostCenters FilterCostCentersPanelContent { get; set; }
        public FilterEnergyResources FilterEnergyResourcesPanelContent { get; set; }
        public FilterNormTypes FilterNormTypesPanelContent { get; set; }

        private string _NewFilterData;
        public string NewFilterData { get => _NewFilterData; set => Set(ref _NewFilterData, value); }

        public override void Execute(object? parameter) { }
        private MonitorMonthFilterPanelViewModel()
        {
            NewFilterData = "First Data";
            FilterPeriodPanelContent = new FilterPeriod();
            FilterCostCentersPanelContent = new FilterCostCenters();
            FilterEnergyResourcesPanelContent = new FilterEnergyResources();
            FilterNormTypesPanelContent = new FilterNormTypes();
        }

    }
}
