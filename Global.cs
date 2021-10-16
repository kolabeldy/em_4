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
        internal static List<CostCenter> CostCenterSourceList= new List<CostCenter>();
        internal static List<Unit> UnitSourceList = new List<Unit>();

    }
}
