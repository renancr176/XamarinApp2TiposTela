using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp2TiposTela.TiposPaginas.Tabbed;

namespace XamarinApp2TiposTela.TiposPaginas.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}

	    private void ProximaPagina(object sender, EventArgs args)
	    {
	        Navigation.PushAsync(new Pagina2());
	    }

	    private void ChamarModal(object sender, EventArgs args)
	    {
	        Navigation.PushModalAsync(new Modal());
	    }

	    private void ChamarAbas(object sender, EventArgs args)
	    {
	        Navigation.PushAsync(new Abas());
	    }

	    private void ChamarMaster(object sender, EventArgs args)
	    {
	        App.Current.MainPage = new NavigationPage(new Master.Master())
	        {
                BarBackgroundColor = Color.SlateBlue,
                BarTextColor = Color.White
	        };
	    }
    }
}