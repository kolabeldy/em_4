using em.Vievs;
using em.ViewModel.MainMenu;
using em.ViewModels.Base;
using em.Views;
using System.Collections.Generic;
using MaterialDesignThemes.Wpf;
using System.Windows.Controls;
using em.Filter;
using System.Windows.Input;
using em.Commands;

namespace em.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private IFilterPanelViewModel filterPanelViewModel;
        private IFrameViewModel frameModel;
        private MonitorMonthFilterPanel monitorMonthFilterPanel;

        private IMainFrameContent _MainFrameContent;
        public IMainFrameContent MainFrameContent
        {
            get => _MainFrameContent;
            set
            {
                Set(ref _MainFrameContent, value);
            }
        }

        private IFilterPanelContent _FilterPanelContent;
        public IFilterPanelContent FilterPanelContent
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


        private StackPanel _MyMainMenu;
        public StackPanel MyMainMenu { get => _MyMainMenu; set => Set(ref _MyMainMenu, value); }

        private bool _IsFilterPopupOpen = false;
        public bool IsFilterPopupOpen
        {
            get => _IsFilterPopupOpen;
            set
            {
                if (IsClosePress)
                    Set(ref _IsFilterPopupOpen, value);
                else Set(ref _IsFilterPopupOpen, true);
            }
        }

        private bool _IsClosePress = false;
        public bool IsClosePress { get => _IsClosePress; set => Set(ref _IsClosePress, value); }

        public override void Execute(object? parameter) { }

        public MainWindowViewModel()
        {
            MainMenuInit();
        }
        private void FilterPanelClose()
        {
            IsClosePress = true;
            IsFilterPopupOpen = false;
            IsClosePress = false;
        }

        private void MainMenuInit()
        {
            MyMainMenu = new StackPanel();
            var menuMonitoring = new List<SubItem>();
            menuMonitoring.Add(new SubItem("Инфопанель", screen: null, idFunc: "DashboardShow"));
            menuMonitoring.Add(new SubItem("Месячные отчёты", null, idFunc: "MonitorMonth"));
            menuMonitoring.Add(new SubItem("Суточные данные", null, idFunc: "MonitorDay"));
            menuMonitoring.Add(new SubItem("Потери энергоресурсов", LossesMonitor.GetInstance()));
            var item1 = new ItemMenu("Мониторинг", menuMonitoring, PackIconKind.MonitorDashboard);

            var menuImportToDB = new List<SubItem>();
            menuImportToDB.Add(new SubItem("Месячные отчёты", screen: null, idFunc: "AddNewMonth"));
            menuImportToDB.Add(new SubItem("Суточные данные", screen: null, idFunc: "AddNewDay"));
            menuImportToDB.Add(new SubItem("Фыктические потери", screen: null, idFunc: "AddNewLosses"));
            menuImportToDB.Add(new SubItem("Расходные нормы", screen: null, idFunc: "AddNewNormatives"));
            var item2 = new ItemMenu("Импорт данных", menuImportToDB, PackIconKind.Import);

            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("Месячный отчёт", screen: null, idFunc: "ReportMonthShow"));
            menuReports.Add(new SubItem("Пофакторный анализ", screen: null, idFunc: "ReportFactorAnalysisShow"));
            var item3 = new ItemMenu("Отчёты", menuReports, PackIconKind.FileReport);

            var menuAdmin = new List<SubItem>();
            menuAdmin.Add(new SubItem("Синхронизация", screen: null, idFunc: "SynchronizeDB"));
            menuAdmin.Add(new SubItem("Резервирование", screen: null, idFunc: "SaveDB"));
            menuAdmin.Add(new SubItem("Восстановление", screen: null, idFunc: "RestoreDB"));
            menuAdmin.Add(new SubItem("Удалить последние", screen: null, idFunc: "DeleteLastMonthUse"));
            var item4 = new ItemMenu("Сервис БД", menuAdmin, PackIconKind.DatabaseSettings);

            var menuReferences = new List<SubItem>();
            menuReferences.Add(new SubItem("Энергоресурсы", screen: null, idFunc: "ERShow"));
            menuReferences.Add(new SubItem("Центры затрат", screen: null, idFunc: "CCShow"));
            menuReferences.Add(new SubItem("Тарифы", screen: null, idFunc: "TariffsShow"));
            menuReferences.Add(new SubItem("Нормативные потери", screen: null, idFunc: "NormLossShow"));
            var item5 = new ItemMenu("Справочники", menuReferences, PackIconKind.Book);

            var menuSettings = new List<SubItem>();
            menuSettings.Add(new SubItem("Авторизация"));
            menuSettings.Add(new SubItem("Настройки", screen: null, idFunc: "SettingShow"));
            menuSettings.Add(new SubItem("О программе", screen: null, idFunc: "About"));

            var item6 = new ItemMenu("Настройки", menuSettings, PackIconKind.Settings);


            MyMainMenu.Children.Add(new UserControlMenuItem(item1, this));
            MyMainMenu.Children.Add(new UserControlMenuItem(item2, this));
            MyMainMenu.Children.Add(new UserControlMenuItem(item3, this));
            MyMainMenu.Children.Add(new UserControlMenuItem(item4, this));
            MyMainMenu.Children.Add(new UserControlMenuItem(item5, this));
            MyMainMenu.Children.Add(new UserControlMenuItem(item6, this));
        }
        public void SwitchScreen(object sender, string idFunc = null)
        {
            bool rez;
            if (idFunc != null)
            {
                switch (idFunc)
                {
                    case "DashboardShow":
                        break;
                    case "MonitorMonth":
                        filterPanelViewModel = MonitorMonthFilterPanelViewModel.GetInstance();
                        filterPanelViewModel.OnClosed += FilterPanelClose;
                        FilterPanelContent = null;
                        monitorMonthFilterPanel = MonitorMonthFilterPanel.GetInstance(filterPanelViewModel as MonitorMonthFilterPanelViewModel);
                        FilterPanelContent = monitorMonthFilterPanel;
                        IsFilterEnabled = true;
                        MainFrameContent = null;
                        frameModel = MonthMonitorViewModel.GetInstance();
                        //frameModel.NewFilterData = filterPanelViewModel.NewFilterData;
                        MainFrameContent = MonthMonitor.GetInstance((MonthMonitorViewModel)frameModel);
                        break;
                    case "MonitorDay":
                        //var panel = MonitorMonthFilterPanelViewModel.GetInstance();
                        //FilterPanelContent = null;
                        //FilterPanelContent = MonitorMonthFilterPanel.GetInstance(panel);
                        IsFilterEnabled = false;
                        MainFrameContent = null;
                        MainFrameContent = DayMonitor.GetInstance();
                        break;

                        break;
                    case "ReportMonthShow":
                        break;
                    case "ReportFactorAnalysisShow":
                        break;

                    case "ERShow":
                        break;

                    case "CCShow":
                        break;
                    case "TariffsShow":
                        break;
                    case "NormLossShow":
                        break;

                    case "AddNewMonth":
                        break;
                    case "AddNewDay":
                        break;
                    case "AddNewNormatives":
                        break;
                    case "AddNewLosses":
                        break;
                    case "DeleteLastMonthUse":
                        break;
                    case "SaveDB":
                    case "RestoreDB":
                        break;
                    case "SynchronizeDB":
                        break;
                    case "SettingShow":
                        new Setting().ShowDialog();
                        break;
                    case "About":
                        new About().ShowDialog();
                        break;
                }

            }
            //else
            //{
            //    //var screen = ((UserControl)sender);
            //    //if (screen != null)
            //    //{
            //    //    //MainFrame.Children.Clear();
            //    //    //MainFrame.Children.Add(screen);
            //    //    model.IsFilterEnabled = false;
            //    //    FilterPanel.Content = null;
            //    //    MainFrame.Content = null;
            //    //    MainFrame.Content = screen;
            //    //}
            //}
        }

    }
}
