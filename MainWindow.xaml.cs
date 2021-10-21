using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using em.FilterPartials;
using em.Vievs;
using em.ViewModel.MainMenu;
using em.ViewModels;
using em.Views;
using MaterialDesignThemes.Wpf;

namespace em
{
    public partial class MainWindow : Window
    {
        MainWindowViewModel model = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = model;

            var menuMonitoring = new List<SubItem>();
            menuMonitoring.Add(new SubItem("Инфопанель", screen: null, idFunc: "DashboardShow"));
            menuMonitoring.Add(new SubItem("Месячные отчёты", null, idFunc: "MonitorMonth"));
            menuMonitoring.Add(new SubItem("Суточные данные", DayMonitor.GetInstance()));
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


            Menu.Children.Add(new UserControlMenuItem(item1, this));
            Menu.Children.Add(new UserControlMenuItem(item2, this));
            Menu.Children.Add(new UserControlMenuItem(item3, this));
            Menu.Children.Add(new UserControlMenuItem(item4, this));
            Menu.Children.Add(new UserControlMenuItem(item5, this));
            Menu.Children.Add(new UserControlMenuItem(item6, this));

        }
        internal void SwitchScreen(object sender, string idFunc = null)
        {
            bool rez;
            if (idFunc != null)
            {
                switch (idFunc)
                {
                    case "DashboardShow":
                        break;
                    case "MonitorMonth":
                        var panel = MonitorMonthFilterPanelViewModel.GetInstance(this.StackPanelMain);
                        FilterPanel.Content = null;
                        FilterPanel.Content = MonitorMonthFilterPanel.GetInstance(panel);
                        model.IsFilterEnabled = true;
                        panel.PanelShow();
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
            else
            {
                var screen = ((UserControl)sender);
                if (screen != null)
                {
                    //StackPanelMain.Children.Clear();
                    //StackPanelMain.Children.Add(screen);
                    model.IsFilterEnabled = false;
                    FilterPanel.Content = null;
                    StackPanelMain.Content = null;
                    StackPanelMain.Content = screen;
                }
            }
        }

        private bool isClosePress = false;
        private void PopupBox_Closed(object sender, RoutedEventArgs e)
        {
            if (!isClosePress)
                FilterPopup.IsPopupOpen = true;
        }

        private void PopupCloseButton_Click(object sender, RoutedEventArgs e)
        {
            isClosePress = true;
            FilterPopup.IsPopupOpen = false;
            isClosePress = false;
        }
    }
}
