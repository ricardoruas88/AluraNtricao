﻿using System;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Nutricao.Droid;
using AluraNtricao;

[assembly: Dependency(typeof(SQLite_android))]
namespace Nutricao.Droid
{
	public class SQLite_android : ISqlite
	{
		public SQLite_android()
		{
		}

		public SQLiteConnection GetConnection()
		{
			var filename = "Refeicoes.db3";

			string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var path = Path.Combine(folder, filename);
			var connection = new SQLiteConnection(path);

			return connection;
		}

	}
}
