using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace CountDown
{
    class DataFunctions
    {
        private SqlConnection Con;
        private SqlCommand Command;
        private DataTable dt;
        private string conStr;
        private SqlDataAdapter Sda;

        public DataFunctions()
        {
            conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\blert\\OneDrive\\Documents\\db_calendar.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(conStr);
            Command = new SqlCommand();
            Command.Connection = Con;
        }

        public int SetData(string Query)
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Command.CommandText = Query;
            cnt = Command.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, conStr);
            Sda.Fill(dt);
            return dt;
        }
    }
}
