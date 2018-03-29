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
			return "https://api.enco.io/seaas/0.0.1/";
		}

		public static string getStream(string identifierDevice, string identifierStream)
		{
			return GetAPIEndpoint() + "device/" + identifierDevice + "/stream/" + identifierStream + "/values";
		}


		public static string getAllDeviceAssets(string identifierDevice)
		{
			return GetAPIEndpoint() + "device/" + identifierDevice + "assets";
		}

		public static string getLatest(string identifierDevice, string sensorName)
		{
			return GetAPIEndpoint() + "devices/" + identifierDevice + "/sensors/" + sensorName + "/values/latest" ;
		}

		public static string getAllDevices()
		{
			return GetAPIEndpoint() + "device/list";
		}

		public static string getStreamID(string identifierDevice)
		{
			return GetAPIEndpoint() + "device/" + identifierDevice + "/stream";
		}
	}
}
