using System;
using System.Collections.ObjectModel;
using SQLite;

namespace AluraNtricao
{
	public class RefeicaoDao
	{
		private SQLiteConnection conexao;

		private ObservableCollection<Refeicao> lista;

		public ObservableCollection<Refeicao> Lista
		{
			get
			{
				if (lista == null)
					lista = getAll();
				return lista;
			}
			private set
			{
				lista = value;
			}
		}
		public RefeicaoDao(SQLiteConnection con)
		{
			conexao = con;
			conexao.CreateTable<Refeicao>();
		}

		public void Salvar(Refeicao refeicao)
		{
			conexao.Insert(refeicao);
			lista.Add(refeicao);
		}

		public ObservableCollection<Refeicao> getAll()
		{
			return new ObservableCollection<Refeicao>(conexao.Table<Refeicao>());
		}

		public bool Remove(Refeicao refeicao)
		{
			bool resposta = conexao.Delete<Refeicao>(refeicao.ID) > 0;
			lista.Remove(refeicao);
			return resposta;

		}
	}
}

