using em.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace em.ViewModels
{
    internal class MonthMonitorViewModel: ViewModelBase
    {
        public override void Execute(object? parameter) { }
        public string Param { get; set; } = "Строка";

    }
}
