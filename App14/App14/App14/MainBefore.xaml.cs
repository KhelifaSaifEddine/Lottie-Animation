using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lottie.Forms;
namespace App14
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainBefore : ContentPage
	{
		public MainBefore ()
		{
			InitializeComponent ();
		}

   async   private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(),false);
          
        }
    }
}