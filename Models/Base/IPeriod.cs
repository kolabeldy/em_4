using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace em.Models.Base
{
    public interface IPeriod
    {
        int Id { get; set; }
        string Name { get; set; }
        string NameFull { get; set; }
        int Year { get; set; }
        int Month { get; set; }
        string MonthName { get; set; }
        DateTime SelectedStartDate { get; set; }
        DateTime SelectedEndDate { get; set; }
        int SelectedStartPeriod { get; set; }
        int SelectedEndPeriod { get; set; }
        static int MinPeriod { get; set; }
        static int MaxPeriod { get; set; }
        static int MinYear { get; set; }
        static int MaxYear { get; set; }
        static int MinMonth { get; set; }
        static int MaxMonth { get; set; }
        int MinSelectedPeriod { get; set; }
        int MaxSelectedPeriod { get; set; }
        int MinDynamicSelectedPeriod { get; set; }
        int MaxDynamicSelectedPeriod { get; set; }
        List<Period> Periods { get; set; }
        void SetDynamicPeriods();


        //static int GetYear(int period) => period / 100;
        //static int GetMonth(int period) => period - GetYear(period) * 100;
        //static string GetMonthName(int month) => monthArray[month - 1];
        //static void PeriodInit();
        //static int DateTimeToInt(DateTime date);
        //static string GetPeriodName(int period, MonthOutputStyle monthStyle = MonthOutputStyle.AsNumeric);
        //static int PeriodMonthAdd(DateTime period, int month);
        //static int DifferenceBetweenDatesInMonth(DateTime datestart, DateTime dateend);
        //static int DifferenceBetweenDatesInMonth(int datestart, int dateend);
    }
}
