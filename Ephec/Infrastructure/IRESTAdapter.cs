using Ephec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Ephec.Infrastructure
{
    public interface IRESTAdapter
    {
		Task<(HttpStatusCode, List<Animal>)> GetGPS(string id);

		Task<(HttpStatusCode, List<Animal>)> GetHumidity();

		Task<(HttpStatusCode, List<Device>)> GetDevices();


	}
}
