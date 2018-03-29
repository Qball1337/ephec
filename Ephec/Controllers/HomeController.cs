using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ephec.Models;
using Ephec.Infrastructure;

namespace Ephec.Controllers
{
    public class HomeController : Controller
    {

		private readonly IRESTAdapter _restAdapter;

		public HomeController(IRESTAdapter restAdapter)
		{
			_restAdapter = restAdapter;
		}

		public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

		public IActionResult Test()
		{
			//_restAdapter.GetStreamID(Secrets.GetDeviceID());
			//_restAdapter.GetStream(Secrets.GetDeviceID(), "9");
			_restAdapter.GetLatest(Secrets.GetDeviceID(), "HumiditySensor");
			return View();
		}

	}
}
