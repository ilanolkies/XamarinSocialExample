using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinSocial.iOS;

[assembly: Dependency(typeof(SocialService))]
namespace XamarinSocial.iOS
{
	public class SocialService : ISocial
	{
		public void Share(string content)
		{
			var activityViewController = new UIActivityViewController(new NSString[] { new NSString(content) }, null);

			UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(activityViewController, true, null);
		}
	}
}
