using System;
using SQLite;

namespace AluraNtricao
{
	public interface ISqlite
	{
		SQLiteConnection GetConnection();
	}
}

