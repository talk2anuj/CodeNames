using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codenames.Models;

namespace Codenames.Controllers
{
	public class HomeController : Controller
	{
		private static Random random = new Random();
		private const int GridSize = 25;

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult NewGame()
		{
			ViewBag.Words = CreateWordsGrid();

			var spymasterGrid = GetSpymasterGrid();

			ViewBag.GridColor = spymasterGrid.gridColor;
			ViewBag.GridNumber = spymasterGrid.gridNumber;
			ViewBag.Colors = CreateColorGrid(spymasterGrid.colors);

			return View();
		}

		
		private IEnumerable<string> CreateColorGrid(string[] gridColors)
		{
			var colors = new List<string>();
			for (int i = 0; i < GridSize; i++)
			{
				colors.Add(GetColor(gridColors[i]));
			}

			return colors;
		}

		private string GetColor(string color)
		{
			switch (color)
			{
				case "B": return "Blue";
				case "Y": return "Yellow";
				case "R": return "Red";
				case "X": return "Black";
				default: throw new ArgumentException("Unrecognized color");
			}
		}

		private SpymasterGrid GetSpymasterGrid()
		{
			var index = random.Next(1, Constants.spymasterGrids.Count());
			return Constants.spymasterGrids[index];
		}

		private IEnumerable<string> CreateWordsGrid()
		{
			var Words = new List<string>();
			var numOfWords = Constants.wordList.Count();

			var numbers = new List<int>();
			for (var i = 0; i < GridSize; i++)
			{
				var num = random.Next(1, numOfWords);
				while (numbers.Contains(num))
				{
					num = random.Next(1, numOfWords);
				}
				numbers.Add(num);
				Words.Add(Constants.wordList[num]);
			}

			return Words;
		}
	}
}