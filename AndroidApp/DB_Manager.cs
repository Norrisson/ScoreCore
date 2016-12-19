using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.SQLite;

using MySql.Data;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidApp
{
	class DB_Manager
	{
		MySql.Data.MySqlClient.MySqlConnection connection;

	public DB_Manager()
		{
			//SqliteConnection conn = new SqliteConnection("");
			
			MySql.Data.MySqlClient.MySqlConnectionStringBuilder strBuilder = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder();
			strBuilder.Database = "ch_warn_adm";
			strBuilder.Port = 3306;
			strBuilder.Server = "78.46.160.25";
			strBuilder.UserID = "ch_warn_adm";
			strBuilder.Password = "R4TYDEbo8WDZ0su2";

			connection = new MySql.Data.MySqlClient.MySqlConnection(strBuilder.GetConnectionString(false));
			
		}
		

	}
}