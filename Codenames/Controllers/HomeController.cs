using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Codenames.Controllers
{
	public class HomeController : Controller
	{
		private static Random random = new Random();

		

		public ActionResult Index()
		{
			ViewBag.Words = new string[25];
			ViewBag.Colors = new string[25];
			
			var numbers = new List<int>();
			for (var i = 0; i < 25; i++)
			{
				var num = random.Next(1, 500);
				while (numbers.Contains(num))
				{
					num = random.Next(1, 500);
				}
				numbers.Add(num);
				ViewBag.Words[i] = num.ToString();

				if (i % 2 == 0)
					ViewBag.Colors[i] = "Red";
				else
					ViewBag.Colors[i] = "lightblue";
			}
			
			return View();
		}
	}
}