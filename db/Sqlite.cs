using System;
using Microsoft.Data.Sqlite;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace em.db
{
    public static class Sqlite
    {
        public static DataTable Select(string sql)
        {

            try
            {
                using (SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}"))
                {
                    db.Open();
                    SqliteCommand selectCommand = new SqliteCommand(sql, db);
                    using (SqliteDataReader q = selectCommand.ExecuteReader())
                    {
                        DataTable result = new DataTable();
                        result.Load(q);
                        return result;
                    }
                }
            }
            catch (Exception e)
            {
                _ = MessageBox.Show("Ошибка открытия или обработки базы данных.\n\n" + e, "Ошибка!");
                throw new InvalidOperationException("Ошибка открытия или обработки базы данных", e);
            }
        }

        public static int ExecNonQuery(string sql)
        {
            int result = 0;
            try
            {
                using SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}");
                db.Open();
                SqliteCommand execCommand;
                using (SqliteTransaction transaction = db.BeginTransaction())
                {
                    execCommand = db.CreateCommand();
                    execCommand.CommandText = sql;
                    result = execCommand.ExecuteNonQuery();
                    transaction.Commit();
                }
                db.Close();
            }
            catch (Exception e)
            {
                _ = MessageBox.Show("Ошибка открытия или обработки базы данных.\n\n" + e, "Ошибка!");
                throw new InvalidOperationException("Ошибка открытия или обработки базы данных", e);
            }
            return result;
        }

    }
}