using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AluraNtricao
{
	public partial class CadastroDeRefeicao : ContentPage
	{
		public CadastroDeRefeicao(RefeicaoDao dao)
		{
			CadastroDeRefeicaoViewModel vm = new CadastroDeRefeicaoViewModel(dao, this);
			BindingContext = vm;
			InitializeComponent();
		}
	}
}

