using System;
using Xamarin.Forms;
using NativeAPIs.iOS;

[assembly: Dependency(typeof(NetworkService_iOS))]

namespace NativeAPIs.iOS
{
	public class NetworkService_iOS : INetworkService
	{
		public NetworkService_iOS ()
		{
		}

		#region INetworkService implementation

		public bool IsConnected ()
		{
			if (!Reachability.IsHostReachable ("www.google.com")) {
				return false;
			} else {
				return true;
			}
		}

		#endregion
	}
}

