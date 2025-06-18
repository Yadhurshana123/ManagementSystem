using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace UnicomTICManagementSystem.Datas
{
    public static class DBConfig
    {
        private static string connection = "Data Source=Unicomtic.db;Version=3;";

        public static SQLiteConnection GetConnection() 
        {
            SQLiteConnection conn = new SQLiteConnection(connection);
            conn.Open();
            return conn;
        }
    }
}
