using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Ephec.Models;

namespace Ephec.Infrastructure
{
	public class RESTAdapter : IRESTAdapter
	{
		public async Task<(HttpStatusCode, List<Animal>)> GetGPS(string id)
		{
			using (var client = new HttpClient())
			{
				var responseMessageHandler = await client.GetAsync(RESTConfig.getGPS(id));
				if (responseMessageHandler.IsSuccessStatusCode)
				{
					var response = await responseMessageHandler.Content.ReadAsStringAsync();
					var s = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Animal>>(response);
					return (responseMessageHandler.StatusCode, s);
				}
				return (responseMessageHandler.StatusCode, null);
			}
		}

		public async Task<(HttpStatusCode, List<Animal>)> GetHumidity()
		{
			using (var client = new HttpClient())
			{
				var responseMessageHandler = await client.GetAsync(RESTConfig.getHumidity());
				if (responseMessageHandler.IsSuccessStatusCode)
				{
					var response = await responseMessageHandler.Content.ReadAsStringAsync();
					var s = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Animal>>(response);
					return (responseMessageHandler.StatusCode, s);
				}
				return (responseMessageHandler.StatusCode, null);
			}
		}
		public async Task<(HttpStatusCode, List<Device>)> GetDevices()
		{
			using (var client = new HttpClient())
			{
				var responseMessageHandler = await client.GetAsync(RESTConfig.getDevices());
				if (responseMessageHandler.IsSuccessStatusCode)
				{
					var response = await responseMessageHandler.Content.ReadAsStringAsync();
					var s = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Device>>(response);
					return (responseMessageHandler.StatusCode, s);
				}
				return (responseMessageHandler.StatusCode, null);
			}
		}
	}
}
