using ISpan2022_Sql_Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_MaintainUsers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Insert();
			//Update();
			//Delete();
			//Select();
		}

		static public void Insert()
		{
			SqlHelper helper = new SqlHelper("default");

			string sql = @"insert into Users(Name, Account, Password, DateOfBirth, Height)
							values(@Name, @Account, @Password, @DateOfBirth, @Height)";

			var parameters = new SqlParameterBuilder()
									.AddNVarChar("@Name", 50, "Maru")
									.AddNVarChar("Account", 50, "12345678")
									.AddNVarChar("Password", 50, "87654321")
									.AddDateTime("DateOfBirth", new DateTime(1898, 8, 8))
									.AddInt("Height", 180)
									.Build();
			try
			{
				helper.ExecuteNonQuery(sql, parameters);

				Console.WriteLine("Data Updated!");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		static public void Update()
		{
			SqlHelper helper = new SqlHelper("default");

			string sql = @"update users set Name = @Name, Account = @Account, Password = @Password, DateOfBirth = @DateOfBirth, Height = @Height where Id > @Id";

			var parameters = new SqlParameterBuilder()
									.AddInt("Id", 0)
									.AddNVarChar("@Name", 50, "Haru")
									.AddNVarChar("Account", 50, "012345678")
									.AddNVarChar("Password", 50, "876543210")
									.AddDateTime("DateOfBirth", new DateTime(1998, 8, 8, 23, 59, 59))
									.AddInt("Height", 187)
									.Build();
			try
			{
				helper.ExecuteNonQuery(sql, parameters);

				Console.WriteLine("Data Updated!");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		static public void Delete()
		{
			SqlHelper helper = new SqlHelper("default");

			string sql = @"delete from users where DateOfBirth < @DateOfBirth";

			var parameters = new SqlParameterBuilder()
									.AddDateTime("DateOfBirth", new DateTime(1900,1,1))
									.Build();

			try
			{
				helper.ExecuteNonQuery(sql, parameters);

				Console.WriteLine("Data Updated!");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		static public void Select()
		{
			SqlHelper helper = new SqlHelper("default");

			string sql = @"Select * from users where Id > @Id";

			var parameters = new SqlParameterBuilder()
									.AddInt("Id", 0)
									.Build();

			try
			{
				DataTable dt = helper.Select(sql, parameters);

				foreach(DataRow row in dt.Rows)
				{
					Console.WriteLine($@"Id={row.Field<int>("id")}, Name={row.Field<string>("name")}, Account={row.Field<string>("account")}, Password={row.Field<string>("password")}, DateOfBirth={row.Field<DateTime>("dateofbirth")}, Height={row.Field<int>("height")}");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
