using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp2TiposTela.TiposPaginas.Navigation;

namespace XamarinApp2TiposTela.TiposPaginas.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage

	{
        public Master ()
		{
			InitializeComponent ();
        }

	    private void ChamarConteudo(object sender, EventArgs args)
	    {
	        Detail = new NavigationPage(new Conteudo())
	        {
	            BarBackgroundColor = Color.SlateBlue,
	            BarTextColor = Color.White
            };
	        IsPresented = false;
	    }

        private void ChamarPagina1(object sender, EventArgs args)
	    {
            Detail = new NavigationPage(new Pagina1())
            {
                BarBackgroundColor = Color.SlateBlue,
                BarTextColor = Color.White
            };
	        IsPresented = false;
        }

	    private void ChamarPagina2(object sender, EventArgs args)
	    {
            Detail = new NavigationPage(new Pagina2())
            {
                BarBackgroundColor = Color.SlateBlue,
                BarTextColor = Color.White
            };
	        IsPresented = false;
        }

	    private void ChamarPagina3(object sender, EventArgs args)
	    {
            Detail = new NavigationPage(new Pagina3())
            {
                BarBackgroundColor = Color.SlateBlue,
                BarTextColor = Color.White
            };
	        IsPresented = false;
        }
    }
}