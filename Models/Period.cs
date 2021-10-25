using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using em.db;
using em.Models.Base;
using System.Data;

namespace em.Models
{
    public enum MonthOutputStyle { AsNumeric, AsString };
    public class Period: INotifyPropertyChanged, IDBModel
    {
        private int _Id;
        public int Id
        {
            get => _Id;
            set
            {
                Name = GetPeriodName(value);
                NameFull = GetPeriodName(value, MonthOutputStyle.AsString);
                Year = GetYear(value);
                Month = GetMonth(value);
                MonthName = GetMonthName(Month);
                Set(ref _Id, value);
            }
        }

        private string _Name;
        public string Name { get => _Name; set => Set(ref _Name, value);  }

        private string _NameFull;
        public string NameFull { get => _NameFull; set => Set(ref _NameFull, value); }

        private int _Year;
        public int Year { get => _Year; set => Set(ref _Year, value); }

        private int _Month;
        public int Month { get => _Month; set => Set(ref _Month, value); }

        private string _MonthName;
        public string MonthName { get => _MonthName; set => Set(ref _MonthName, value); }

        private DateTime _SelectedStartDate;
        public DateTime SelectedStartDate
        {
            get => _SelectedStartDate;
            set
            {
                SelectedStartPeriod = DateTimeToInt(value);
                Set(ref _SelectedStartDate, value); 
            }
        }

        private DateTime _SelectedEndDate;
        public DateTime SelectedEndDate
        {
            get => _SelectedEndDate;
            set
            {
                SelectedEndPeriod = DateTimeToInt(value);
                Set(ref _SelectedEndDate, value);
            }
        }

        private int _SelectedStartPeriod;
        public int SelectedStartPeriod { get => _SelectedStartPeriod; set => Set(ref _SelectedStartPeriod, value); }

        private int _SelectedEndPeriod;
        public int SelectedEndPeriod { get => _SelectedEndPeriod; set => Set(ref _SelectedEndPeriod, value); }

        public static int MinPeriod {  get; set; }
        public static int MaxPeriod {  get; set; }
        public static int MinYear {  get; set; }
        public static int MaxYear {  get; set; }
        public static int MinMonth {  get; set; }
        public static int MaxMonth {  get; set; }
        public int MinSelectedPeriod {  get; set; }
        public int MaxSelectedPeriod {  get; set;}
        public List<Period> Periods {  get; set;}

        public Period()
        {
        }
        public static int GetYear(int period) => period / 100;
        public static int GetMonth(int period) => period - GetYear(period) * 100;
        public static string GetMonthName(int month) => monthArray[month - 1];

        public static void PeriodInit( )
        {
            SetMinMaxPeriod();
            MinYear = GetYear(MinPeriod);
            MaxYear = GetYear(MaxPeriod); ;
            MinMonth = GetMonth(MinPeriod);
            MaxMonth = GetMonth(MaxPeriod);
        }
        private static void SetMinMaxPeriod()
        {
            string sql = "SELECT MinPeriod, MaxPeriod FROM MinMaxPeriods";
            DataTable dt = new DataTable();
            dt = Sqlite.Select(sql);
            MinPeriod = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
            MaxPeriod = Convert.ToInt32(dt.Rows[0].ItemArray[1].ToString());
        }

        public static int DateTimeToInt(DateTime date)
        {
            return date.Year * 100 + date.Month;
        }
        public static string GetPeriodName(int period, MonthOutputStyle monthStyle = MonthOutputStyle.AsNumeric)
        {
            int year = GetYear(period);
            int month = period - year * 100;
            if (monthStyle == MonthOutputStyle.AsNumeric) 
                return year + "_" + month;
            else return year + " " + monthArray[month - 1];
        }

        private static string[] monthArray = new string[]
        { "янв", "фев", "мар", "апр", "май", "июн", "июл", "авг", "сен", "окт", "ноя", "дек" };

        #region IDBModel realisattion

        public List<T> Get<T>()
        {
            //List<T> result = new();
            //List<Period> list = new();

            //var resourceManager = Properties.Resources.ResourceManager;
            //string sql = "SELECT MIN(Period) FROM ERUsesMonth GROUP By Period";

            //DataTable dt = new DataTable();
            //dt = Sqlite.Select(sql);
            //list = (from DataRow dr in dt.Rows
            //        select new CostCenter()
            //        {
            //            Id = Convert.ToInt32(dr["Id"]),
            //            Name = dr["Name"].ToString(),
            //            IsActual = Convert.ToBoolean(dr["IsActual"]),
            //            IsMain = Convert.ToBoolean(dr["IsMain"]),
            //            IsTechnology = Convert.ToBoolean(dr["IsTechnology"]),
            //        }).ToList();
            result.AddRange((IEnumerable<T>)list);
            return result;
        }
        public int Add(object rec)
        {
            //if (rec == null) return -1;
            //CostCenter record = rec as CostCenter;
            //string sql = "INSERT INTO CostCenters (Id, Name, IsMain, IsTechnology, IsActual) VALUES ("
            //                + record.Id.ToString() + ", '" + record.Name + "'" + ", " + record.IsMain.ToString() + ", "
            //                + record.IsTechnology.ToString() + ", " + record.IsActual.ToString() + ")";
            //return Sqlite.ExecNonQuery(sql);
            return 0;
        }
        public int Delete(string whereStr)
        {
            //string sql = "Delete FROM CostCenters WHERE " + whereStr;
            //return Sqlite.ExecNonQuery(sql);
            return 0;
        }
        public int Update(object rec)
        {
            //if (rec == null) return -1;
            //CostCenter record = rec as CostCenter;
            //string sql = "UPDATE CostCenters SET (Name, IsMain, IsTechnology, IsActual) = ("
            //                + "'" + record.Name + "'" + ", " + record.IsMain.ToString()
            //                + ", " + record.IsTechnology.ToString() + ", " + record.IsActual.ToString() + ")"
            //                + "WHERE Id = " + record.Id.ToString();

            //return Sqlite.ExecNonQuery(sql);
            return 0;
        }

        #endregion

        #region INotifyProperty

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        protected bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }


        #endregion
    }
}
