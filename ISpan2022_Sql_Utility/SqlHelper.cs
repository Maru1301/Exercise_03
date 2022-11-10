using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2022_Sql_Utility
{
	public class SqlHelper
	{
		string connString;
		public SqlHelper(string keyOfConnString)
		{
			connString = System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConnString].ConnectionString;
		}

		public void ExecuteNonQuery(string sql, SqlParameter[] parameters)
		{

			using (SqlConnection conn = new SqlConnection(connString))
			{
				SqlCommand cmd = new SqlCommand(sql, conn);

				cmd.Parameters.AddRange(parameters);

				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		public DataTable Select(string sql, SqlParameter[] parameters)
		{

			using (SqlConnection conn = new SqlConnection(connString))
			{
				SqlCommand cmd = new SqlCommand(sql, conn);

				if(parameters != null)
				{
					cmd.Parameters.AddRange(parameters);
				}

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				DataSet ds = new DataSet();
				adapter.Fill(ds, "Users");

				return ds.Tables["Users"];
			}
		}
	}
}
