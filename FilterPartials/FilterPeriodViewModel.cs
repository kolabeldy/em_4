using em.ViewModels.Base;
using System;

namespace em.FilterPartials
{
    internal class FilterPeriodViewModel: ViewModelBase
    {
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
    }
}
