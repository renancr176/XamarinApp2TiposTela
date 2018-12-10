using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp2TiposTela.TiposPaginas.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}

	    private void ProximaPagina(object sender, EventArgs args)
	    {
            App.Current.MainPage = new NavigationPage(new Navigation.Pagina1())
            {
                BarBackgroundColor = Color.SlateBlue,
                BarTextColor = Color.White
            };
	    }

    }
}