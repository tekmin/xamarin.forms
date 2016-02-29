using System;
using ToDO.Droid;

[assembly:Xamarin.Forms.Dependency(typeof(AppInfo_Droid))]
namespace ToDO.Droid
{
	public class AppInfo_Droid : IAppInfo
	{
		public AppInfo_Droid ()
		{
		}

		public String GetName() 
		{
			return "My Android App";
		}
	}
}

