using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ephec.Models;
using Ephec.Infrastructure;
using Ephec.ViewModel;

namespace Ephec.Controllers
{
	public class HomeController : Controller
	{

		private readonly IRESTAdapter _restAdapter;

		public HomeController(IRESTAdapter restAdapter)
		{
			_restAdapter = restAdapter;
		}
		[HttpGet]
		public IActionResult Index()
		{
			var listDevices = new List<Device>();
			listDevices = _restAdapter.GetDevices().Result.Item2;
			if (listDevices.Count <= 0)
			{
				return BadRequest();
			}
			
			return View(listDevices);
		}

		[HttpGet]
		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}
		[HttpGet]
		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}
		public JsonResult GetGPSData(string id)
		{
			var list = new List<Animal>();
			list = _restAdapter.GetGPS(id).Result.Item2;

			return Json(list);
		}
	}
}
