using System;
using Android.Net;
using Xamarin.Forms;
using NativeAPIs.Droid;

[assembly: Dependency(typeof(NetworkService_Android))]

namespace NativeAPIs.Droid
{
	public class NetworkService_Android : INetworkService
	{
		public NetworkService_Android ()
		{
		}

		#region INetworkService implementation

		public bool IsConnected ()
		{
			var connectivityManager = 
				(ConnectivityManager)Forms.Context.GetSystemService (Android.App.Application.ConnectivityService);

			var activeConnection = connectivityManager.ActiveNetworkInfo;
			if ((activeConnection != null) && activeConnection.IsConnected) {
				return true;
			} else {
				return false;
			}
		}

		#endregion
	}
}

