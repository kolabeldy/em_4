using em.Commands;
using em.Filter.Partials;
using em.ViewModels.Base;
using System;
using System.Windows.Input;

namespace em.Filter
{
    public delegate void IsFilterChanged();
    public class MonitorMonthFilterPanelViewModel : ViewModelBase, IFilterPanelViewModel
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

        public event IsClosed OnClosed;
        public FilterPeriod FilterPeriodPanelContent { get; set; }
        public FilterPeriodViewModel FilterPeriodViewModel { get; set; }
        public FilterCostCenters FilterCostCentersPanelContent { get; set; }
        public FilterEnergyResources FilterEnergyResourcesPanelContent { get; set; }
        public FilterNormTypes FilterNormTypesPanelContent { get; set; }

        private string _NewFilterData;

        private bool _IsChanged;
        public bool IsChanged
        {
            get => _IsChanged;
            set
            {
                Set(ref _IsChanged, value);
            }
        }
        public string NewFilterData { get => _NewFilterData; set => Set(ref _NewFilterData, value); }

        public ICommand FilterPanelClose_Command { get; }
        public override bool CanExecute(object? parameter) => true;
        public override void Execute(object? parameter) => FilterPanelClose();
        private void FilterPanelClose()
        {
            if (FilterPeriodViewModel.IsChanged) Refresh();
            OnClosed();
        }
        private void Refresh()
        {
            int startPeriod = FilterPeriodViewModel.PeriodModel.SelectedStartPeriod;
            int endPeriod = FilterPeriodViewModel.PeriodModel.SelectedEndPeriod;
            FilterPeriodViewModel.IsChanged = false;
        }
        private MonitorMonthFilterPanelViewModel()
        {
            FilterPanelClose_Command = new LambdaCommand(Execute, CanExecute);

            FilterPeriodViewModel = new FilterPeriodViewModel();
            FilterPeriodPanelContent = new FilterPeriod(FilterPeriodViewModel);
            FilterCostCentersPanelContent = new FilterCostCenters();
            FilterEnergyResourcesPanelContent = new FilterEnergyResources();
            FilterNormTypesPanelContent = new FilterNormTypes();
        }

    }
}
