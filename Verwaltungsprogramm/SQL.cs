using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Verwaltungsprogramm
{
    static class SQL
    {
        public static SqlConnection connection = new SqlConnection();//con wird erstellt
        public static SqlCommand command = new SqlCommand();//command wird erstellt 

        /// <summary>
        /// SqlConnection und SqlCommand werden angepasst
        /// </summary>
        /// <param name="conString">Connection String</param>
        public static void SetConnectionString(string conString)
        {
            connection.ConnectionString = conString;
            command.Connection = connection;
        }

        /// <summary>
        /// Checks if the connection is valid
        /// </summary>
        /// <returns>true if it works, false if not</returns>
        public static bool ConWorks()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch { return false; }
            finally { connection.Close(); }
        }

        /// <summary>
        /// creates a Database if doesn't exist
        /// </summary>
        /// <param name="DatabaseName">Name of the Database you want to create</param>
        public static void CreateDatabase(string DatabaseName)
        {
            Execute("IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = '" + DatabaseName + "') " +
                "BEGIN " +
                "CREATE DATABASE[" + DatabaseName + "];" +
                "END");
        }

        /// <summary>
        /// Executes the given Command
        /// </summary>
        /// <param name="CommandText">CommandText</param>
        public static void Execute(string CommandText)
        {
            try
            {
                connection.Open();
                command.CommandText = CommandText;
                command.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
        }

        /// <summary>
        /// Gets Data as a DataTable
        /// </summary>
        /// <param name="Command"></param>
        /// <returns>DataTable with the called Content</returns>
        public static DataTable GetData(string Command)
        {
            try
            {
                connection.Open();
                command.CommandText = Command;
                //cretes an empty table, fills it with values and then returns it
                DataTable temp = new DataTable();
                temp.Load(command.ExecuteReader());
                return temp;
            }
            catch { return null; }
            finally { connection.Close(); }
        }
    }
}
