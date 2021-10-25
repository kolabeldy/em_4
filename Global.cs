using em.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace em
{
    public enum SelectChoise { All, True, False }
    public static class Global
    {
        public static string dbpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db\\emdb.db");
        public static List<CostCenter> CostCenterSourceList= new List<CostCenter>();
        public static List<Unit> UnitSourceList = new List<Unit>();
        public static int DynamicPeriodMonthCount = 12;

    }
}
