using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2022_Sql_Utility
{
	public class SqlParameterBuilder
	{
		List<SqlParameter> parameters = new List<SqlParameter>();

		public SqlParameterBuilder AddInt(string name, int value)
		{
			parameters.Add(new SqlParameter(name, SqlDbType.Int) { Value = value});

			return this;
		}

		public SqlParameterBuilder AddNVarChar(string name, int length, string value)
		{
			parameters.Add(new SqlParameter(name, SqlDbType.NVarChar, length) { Value = value });

			return this;
		}

		public SqlParameterBuilder AddDateTime(string name, DateTime value)
		{
			parameters.Add(new SqlParameter(name, SqlDbType.DateTime) { Value = value });

			return this;
		}

		public SqlParameter[] Build()
		{
			return parameters.ToArray();
		}
	}
}
