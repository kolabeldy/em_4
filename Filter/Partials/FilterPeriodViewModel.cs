using em.ViewModels.Base;
using System;

namespace em.Filter.Partials
{
    public class FilterPeriodViewModel : ViewModelBase
    {
        private static int initCount = 0;

        private bool _IsChanged;
        public bool IsChanged
        {
            get => _IsChanged;
            set
            {
                Set(ref _IsChanged, value);
            }
        }

        private DateTime _SelectedStartDate;
        public DateTime SelectedStartDate
        {
            get => _SelectedStartDate;
            set
            {
                if (Set(ref _SelectedStartDate, value))
                    IsChanged = true;
            }
        }
        private DateTime _SelectedEndDate = DateTime.Now;
        public DateTime SelectedEndDate
        {
            get => _SelectedEndDate;
            set
            {
                if (Set(ref _SelectedEndDate, value))
                    IsChanged = true;
            }
        }
        public override void Execute(object? parameter) { }
        public FilterPeriodViewModel()
        {
            initCount++;
            DateTime currDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(-1);
            SelectedStartDate = currDate;
            SelectedEndDate = new DateTime(currDate.Year, currDate.Month, DateTime.DaysInMonth(currDate.Year, currDate.Month));
        }
    }
}
