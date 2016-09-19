using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AluraNtricao
{
	public partial class ListaRefeicoes : ContentPage
	{
		public ObservableCollection<Refeicao> Refeicoes { get; set; }
		private RefeicaoDao dao;

		public ListaRefeicoes(RefeicaoDao dao)
		{
			this.dao = dao;
			Refeicoes = dao.Lista;
			BindingContext = this;
			InitializeComponent();
		}

		public async void AcaoItem(Object sender, ItemTappedEventArgs e)
		{
			Refeicao refeicao = e.Item as Refeicao;
			var resposta = await DisplayAlert("Remover item", "Você tem certeza que deseja remover "+refeicao.Descricao, "Sim", "Não");
			if (resposta)
			{

				if (dao.Remove(refeicao))
					await DisplayAlert("Sucesso!",refeicao.Descricao +" removido com o sucesso","OK");
				else
					await DisplayAlert("Falha!", "Falha ao remover " + refeicao.Descricao, "OK");
			}
		}
	}
}

