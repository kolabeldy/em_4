using em.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data;

namespace em.Vievs
{
    public partial class MonthMonitor : UserControl
    {
        private static MonthMonitor instance;
        public static MonthMonitor GetInstance()
        {
            if (instance == null)
                instance = new MonthMonitor();
            return instance;
        }
        public string ScreenName = "MonthMonitor";
        private MonthMonitor()
        {
            InitializeComponent();
        }

    }
}
