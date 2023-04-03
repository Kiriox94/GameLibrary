using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Collections.Specialized;

namespace GameLibrary
{
    class SQLHelper
    {
        private string _DBPath;
        public string DBPath { get => _DBPath; }
        private SQLiteConnection conn;

        public SQLHelper(string DBpath)
        {
            conn = new SQLiteConnection("Data Source=" + DBpath);
            _DBPath = DBpath;
        }

        public int InvokeUpdate(string query, ListDictionary parameters = null)
        {
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;

            if (parameters != null)
            {
                foreach (var key in parameters.Keys)
                {
                    cmd.Parameters.AddWithValue(key.ToString(), parameters[key]);
                }
            }
            int ret = cmd.ExecuteNonQuery();

            conn.Close();

            return ret;
        }

        public object InvokeScalar(string query, ListDictionary parameters = null)
        {
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;

            if (parameters != null)
            {
                foreach (var key in parameters.Keys)
                {
                    cmd.Parameters.AddWithValue(key.ToString(), parameters[key]);
                }
            }
            object ret = cmd.ExecuteScalar();

            conn.Close();

            return ret;
        }

        public DataTable InvokeQuery(string query)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            adapter.Dispose();

            return ds.Tables[0];
        }
    }
}
