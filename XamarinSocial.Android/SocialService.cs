using Android.Content;
using Xamarin.Forms;
using XamarinSocial.Droid;

[assembly: Dependency(typeof(SocialService))]
namespace XamarinSocial.Droid
{
	public class SocialService : ISocial
    {      
		public void Share(string content)
		{         
			Intent share = new Intent(Intent.ActionSend)
				.SetType("text/plain")
				.AddFlags(ActivityFlags.ClearWhenTaskReset)
				.PutExtra(Intent.ExtraText, content);

			Android.App.Application.Context.StartActivity(Intent.CreateChooser(share, "Compartir!"));
		}
	}
}
