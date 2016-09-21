using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AluraNtricao
{
public class CadastroDeRefeicaoViewModel : INotifyPropertyChanged 
	{
		private string descricao;
		private double calorias;



		private RefeicaoDao dao;
        private ContentPage page;

		public ICommand SalvaRefeicao { get; protected set; }
		public event PropertyChangedEventHandler PropertyChanged;

		public string Descricao
		{
			get { return descricao; }
			set { if (value != descricao) { descricao = value; OnPropertyChanged("Descricao"); } }
		}

		public double Calorias
		{
			get { return calorias; }
			set { if (calorias != value) { calorias = value; OnPropertyChanged("Calorias"); } }
		}

		public CadastroDeRefeicaoViewModel(RefeicaoDao dao, ContentPage page)
		{
			this.dao = dao;
			this.page = page;

			this.SalvaRefeicao = new Command(() =>
			{
				string descricao = Descricao;
				int calorias = int.Parse(Calorias.ToString());

				Refeicao refeicao = new Refeicao(descricao, calorias);

				string msg = "A refeição " + descricao + " de " + calorias.ToString() + " calorias foi salva com sucesso";

				dao.Salvar(refeicao);

				page.DisplayAlert("Cadastro de refeição", msg, "Ok");
			});
		}

		public void OnPropertyChanged(string nome)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(nome));
			}
		}
	}
}
