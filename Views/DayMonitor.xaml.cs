using em.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data;
using em.Views;

namespace em.Vievs
{
    public partial class DayMonitor : UserControl, IMainFrameContent
    {
        private static DayMonitor instance;
        public static DayMonitor GetInstance()
        {
            if (instance == null)
                instance = new DayMonitor();
            return instance;
        }
        private DayMonitor()
        {
            InitializeComponent();
        }

    }
}
