using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intermediateCSharp.UtilityClasses
{
    public class DatabaseUtility
    {
        public static int ExecuteStoredProcedureNonQuery(string storedProcedureName,params SqlParameter[] parameters)
        {
            // a class that runs a ExecuteNonQuery
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Helper.ConnectionString;
            SqlCommand command = new SqlCommand(storedProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters);
            connection.Open();
            int counter = command.ExecuteNonQuery();
            connection.Close();

            return counter;
        }

        public static SqlDataReader ExecuteStoredProcedureReader(string storedProcedureName, params SqlParameter[] parameters)
        {
            // get all employees ids
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Helper.ConnectionString;
            SqlCommand command = new SqlCommand(storedProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters);
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);

            return dataReader;
        }

        // stored procedure with a return value
        public static object ExcecuteStoredProcedureScalar(string storedProcedureName, params SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Helper.ConnectionString;
            SqlCommand command = new SqlCommand(storedProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters);
            connection.Open();
            object n = command.ExecuteScalar();
            connection.Close();

            return n;
        }
    }
}
