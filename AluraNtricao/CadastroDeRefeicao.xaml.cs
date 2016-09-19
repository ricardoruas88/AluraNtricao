using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AluraNtricao
{
	public partial class CadastroDeRefeicao : ContentPage
	{
		private RefeicaoDao dao;

		public CadastroDeRefeicao(RefeicaoDao dao)
		{
			this.dao = dao;
			InitializeComponent();
		}

		public void AtualizaContator(object sender, EventArgs e)
		{
			double valor = Math.Round(sldCalorias.Value, 0);
			lblCalorias.Text = valor.ToString();
		}

		public void SalvaRefeicao(Object sender, EventArgs e)
		{
			string descricao = entDescricao.Text;
			double valor = sldCalorias.Value;

			Refeicao refeicao = new Refeicao(descricao, valor);
			dao.Salvar(refeicao);

			string msg = "A refeição " + descricao + " de " + valor + " Calorias";
			DisplayAlert("Salvar Refeição", msg, "OK");
			Clear();
		}

		void Clear()
		{
			entDescricao.Text = "";
			sldCalorias.Value = 0;
		}
}
}

