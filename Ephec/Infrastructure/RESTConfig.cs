using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ephec.Infrastructure
{
    public static class RESTConfig
    {
		private static string GetAPIEndpoint()
		{
			return "http://vps517683.ovh.net/api.php/";
		}

		public static string getGPS(string id)
		{
			return GetAPIEndpoint() + "GPS/" + id;
		}

		public static string getHumidity()
		{
			return GetAPIEndpoint() + "HUMIDITY";
		}
		public static string getDevices()
		{
			return GetAPIEndpoint() + "DEVICES";
		}
	}
}
