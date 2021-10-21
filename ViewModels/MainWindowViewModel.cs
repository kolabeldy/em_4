using em.FilterPartials;
using em.ViewModels.Base;

namespace em.ViewModels
{
    public class MainWindowViewModel:ViewModelBase
    {
        public override void Execute(object? parameter) { }

        private MonitorMonthFilterPanel _FilterPanelContent;
        public MonitorMonthFilterPanel FilterPanelContent
        {
            get => _FilterPanelContent;
            set
            {
                Set(ref _FilterPanelContent, value);
            }
        }
        private bool _IsFilterEnabled = false;
        public bool IsFilterEnabled
        {
            get => _IsFilterEnabled;
            set
            {
                Set(ref _IsFilterEnabled, value);
            }
        }

        public MainWindowViewModel()
        {

        }
    }
}
