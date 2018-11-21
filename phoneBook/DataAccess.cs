using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace phoneBook
{
	class DataAccess
	{
		private static SqlConnection con = null;
		private static SqlCommand cmd = null;
		private static SqlDataAdapter da = null;
		private static DataTable dt = null;
		private static void Connection()
		{
			con = new SqlConnection(@"Data Source=DESKTOP-V11AV1Q\SQLEXPRESS;Initial Catalog=PHONEBOOK;Integrated Security=True");
			con.Open();
		}

		public static DataTable Execute(string query)
		{
			if (con == null)
			{
				Connection();
			}
			dt = new DataTable();
			cmd = new SqlCommand(query,con);
			da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			return dt;
		}
		public static int ExecuteNonQuery(string query)
		{
			if (con == null)
			{
				Connection();
			}
			cmd = new SqlCommand(query, con);
			int effect = cmd.ExecuteNonQuery();
			return effect;
		}
	}
}
