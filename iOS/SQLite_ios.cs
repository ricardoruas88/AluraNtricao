using System;
using System.IO;
using AluraNtricao.iOS;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLite_ios))]
namespace AluraNtricao.iOS
{
	public class SQLite_ios : ISqlite
	{
		public SQLite_ios()
		{
		}

		public SQLiteConnection GetConnection()
		{
			var fileName = "Refeicao.db3";
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var path = Path.Combine(documents, "..", "Library", fileName);

			return new SQLiteConnection(path);
		}
	}
}

