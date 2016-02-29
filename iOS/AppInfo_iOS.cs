using System;
using ToDO.iOS;

[assembly:Xamarin.Forms.Dependency(typeof(AppInfo_iOS))]
namespace ToDO.iOS
{
	public class AppInfo_iOS: IAppInfo
	{
		public AppInfo_iOS ()
		{
		}

		public String GetName() 
		{
			return "My iOS App";
		}
	}
}

