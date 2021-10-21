using em.ViewModels.Base;

namespace em.ViewModels
{
    internal class MonthMonitorViewModel: ViewModelBase
    {
        public override void Execute(object? parameter) { }

        private string _Param = "MonthMonitor";
        public string Param
        {
            get => _Param;
            set
            {
                Set(ref _Param, value);
            }
        }

    }
}
