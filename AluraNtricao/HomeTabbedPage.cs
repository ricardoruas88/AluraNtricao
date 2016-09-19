using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;

namespace AluraNtricao
{
	public class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage()
		{
			SQLiteConnection con = DependencyService.Get<ISqlite>().GetConnection();

			RefeicaoDao dao = new RefeicaoDao(con);

			CadastroDeRefeicao telaCadastro = new CadastroDeRefeicao(dao);
			ListaRefeicoes telaLista = new ListaRefeicoes(dao);

			this.Children.Add(telaCadastro);
			this.Children.Add(telaLista);
		}
	}
}

