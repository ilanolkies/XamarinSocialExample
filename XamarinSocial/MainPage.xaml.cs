using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace XamarinSocial
{
	public partial class MainPage : ContentPage
    {
        public MainPage()
        {
			InitializeComponent();

			On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			string content = "Following 'Xamarin Social Example' by @ilanolkies https://ilanolkies.github.io";
			DependencyService.Get<ISocial>().Share(content);
		}
    }
}
