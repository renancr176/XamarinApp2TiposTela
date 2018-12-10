using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp2TiposTela.TiposPaginas.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina2 : ContentPage
	{
		public Pagina2 ()
		{
			InitializeComponent ();
		}

	    private void ProximaPagina(object sender, EventArgs args)
	    {
	        Navigation.PushAsync(new Pagina3());
	    }

    }
}