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
    public partial class LossesMonitor : UserControl, IMainFrameContent
    {
        private static LossesMonitor instance;
        public static LossesMonitor GetInstance()
        {
            if (instance == null)
                instance = new LossesMonitor();
            return instance;
        }
        private LossesMonitor()
        {
            InitializeComponent();
        }

    }
}
