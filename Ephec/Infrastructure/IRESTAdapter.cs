using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ephec.Infrastructure
{
    public interface IRESTAdapter
    {
		Task GetStream(string deviceID, string streamID);

		Task GetLatest(string deviceID, string sensorName);

		Task GetStreamID(string deviceID);
	}
}
