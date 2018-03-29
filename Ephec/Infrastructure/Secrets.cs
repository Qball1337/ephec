using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ephec.Infrastructure
{
    public static class Secrets
    {
		public static string GetToken()
		{
			return "9a62616196a89a6d41ade05ed379f28e";
		}

		public static string GetDeviceID()
		{
			return "1C8779C00000024B";
		}
    }
}
