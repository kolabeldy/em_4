using em.ViewModels.Base;

namespace em.ViewModels
{
    public class MonthMonitorViewModel: ViewModelBase, IFrameViewModel
    {
        public override void Execute(object? parameter) { }


        private static MonthMonitorViewModel instance;
        public static MonthMonitorViewModel GetInstance()
        {
            if (instance == null)
                instance = new MonthMonitorViewModel();
            return instance;
        }

        private string _NewFilterData = "Data";
        public string NewFilterData { get => _NewFilterData; set => Set(ref _NewFilterData, value); }
        private MonthMonitorViewModel()
        {
        }



    }
}
