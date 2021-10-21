﻿using em.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data;
using em.ViewModels;
using em.Views;

namespace em.Vievs
{
    public partial class MonthMonitor : UserControl, IMainFrameContent
    {
        internal MonthMonitor(MonthMonitorViewModel model)
        {
            DataContext = model;
            InitializeComponent();
        }

    }
}
