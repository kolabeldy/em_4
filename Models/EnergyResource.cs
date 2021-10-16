using em.db;
using em.Models.Base;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

namespace em.Models
{
    internal class EnergyResource : IdName, IDBModel
    {
        public int IdGroup { get; set; }
        public string? ShortName { get; set; }
        public int IdUnit { get; set; }
        public bool IsMain { get; set; }
        public bool IsActual { get; set; }
        public bool IsPrime { get; set; }

        public SelectChoise SelectedActual { get; set; } = SelectChoise.True;
        public SelectChoise SelectedMain { get; set; } = SelectChoise.All;
        public SelectChoise SelectedPrime { get; set; } = SelectChoise.All;

        public List<T> Get<T>()
        {
            List<T> result = new();
            List<EnergyResource> list = new();

            string isActualStr = SelectedActual == SelectChoise.All ? "" : SelectedActual == SelectChoise.True ? " AND IsActual = 1" : " AND IsActual = 0";
            string isMainStr = SelectedMain == SelectChoise.All ? "" : SelectedMain == SelectChoise.True ? " AND IsMain = 1" : " AND IsMain = 0"; ;
            string isPrimeStr = SelectedPrime == SelectChoise.All ? "" : SelectedPrime == SelectChoise.True ? " AND IsPrime = 1" : " AND IsPrime = 0";
            string whereStr = "WHERE True" + isActualStr + isMainStr + isPrimeStr;
            string sql = "SELECT Id, IdGroup, Name, ShortName, IdUnit, IsMain, IsActual, IsPrime FROM EnergyResources " + whereStr + " ORDER BY Id";

            DataTable dt = new DataTable();
            dt = Sqlite.Select(sql);
            list = (from DataRow dr in dt.Rows
                    select new EnergyResource()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        IdGroup = Convert.ToInt32(dr["IdGroup"]),
                        Name = dr["Name"].ToString(),
                        ShortName = dr["ShortName"].ToString(),
                        IdUnit = Convert.ToInt32(dr["IdUnit"]),
                        IsActual = Convert.ToBoolean(dr["IsActual"]),
                        IsMain = Convert.ToBoolean(dr["IsMain"]),
                        IsPrime = Convert.ToBoolean(dr["IsPrime"]),
                    }).ToList();
            result.AddRange((IEnumerable<T>)list);
            return result;
        }
        public int Add(object rec)
        {
            if (rec == null) return -1;
            EnergyResource record = rec as EnergyResource;
            string sql = "INSERT INTO EnergyResources (Id, IdGroup, Name, ShortName, IdUnit, IsMain, IsActual, IsPrime) VALUES ("
                            + record.Id.ToString() + ", " + record.IdGroup.ToString() + ", '" + record.Name + "'" + ", '" 
                            + record.ShortName + "'" + ", " + record.IdUnit.ToString() + ", " + record.IsMain.ToString() + ", " 
                            + record.IsActual.ToString() + ", " + record.IsPrime.ToString() + ")";
            return Sqlite.ExecNonQuery(sql);
        }
        public int Delete(string where)
        {
            string sql = "Delete FROM EnergyResources WHERE " + where;
            return Sqlite.ExecNonQuery(sql);
        }
        public int Update(object rec)
        {
            if (rec == null) return -1;
            EnergyResource record = rec as EnergyResource;
            string sql = "UPDATE EnergyResources SET (IdGroup, Name, ShortName, IdUnit, IsMain, IsActual, IsPrime) = ( "
                            + record.IdGroup.ToString() + "'" + record.Name + "'" + ", '" + record.ShortName + "'" + ", " 
                            + record.IdUnit.ToString() + ", " + record.IsMain.ToString() + ", "
                            + record.IsActual.ToString() + ", " + record.IsPrime.ToString() + ")"
                            + "WHERE Id = " + record.Id.ToString();

            return Sqlite.ExecNonQuery(sql);
        }
    }
}
