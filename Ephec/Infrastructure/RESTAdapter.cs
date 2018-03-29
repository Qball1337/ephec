using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ephec.Infrastructure
{
	public class RESTAdapter : IRESTAdapter
	{
		public async Task GetStream(string deviceID, string streamID)
		{
			using (var client = new HttpClient())
			{
					client.SetBearerToken(Secrets.GetToken());
					var responseMessageHandler = await client.GetAsync(RESTConfig.getStream(deviceID, streamID));
					responseMessageHandler.EnsureSuccessStatusCode();
					var response = await responseMessageHandler.Content.ReadAsStringAsync();
			}
		}

		public async Task GetLatest(string deviceID, string sensorName)
		{
			using (var client = new HttpClient())
			{
				client.SetBearerToken(Secrets.GetToken());
				var responseMessageHandler = await client.GetAsync(RESTConfig.getLatest(deviceID, sensorName));
				responseMessageHandler.EnsureSuccessStatusCode();
				var response = await responseMessageHandler.Content.ReadAsStringAsync();
			}
		}

		public async Task GetStreamID(string deviceID)
		{
			using (var client = new HttpClient())
			{
				client.SetBearerToken(Secrets.GetToken());
				var responseMessageHandler = await client.GetAsync(RESTConfig.getStreamID(deviceID));
				responseMessageHandler.EnsureSuccessStatusCode();
				var response = await responseMessageHandler.Content.ReadAsStringAsync();

			}
		}
	}
}
