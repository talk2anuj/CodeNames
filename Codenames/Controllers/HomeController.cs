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
		private static Random Random = new Random();
		private const int GridSize = 25;
		private static List<int> Numbers = new List<int>();
		private static IEnumerable<string> WordsGrid;
		private static SpymasterGrid SpymasterGrid;
		private static IEnumerable<string> Colors;

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult NewGame()
		{
			WordsGrid = CreateWordsGrid();
			SpymasterGrid = GetSpymasterGrid();
			Colors = CreateColorGrid(SpymasterGrid.colors);

			ViewBag.Words = WordsGrid;
			ViewBag.GridColor = SpymasterGrid.gridColor;
			ViewBag.GridNumber = SpymasterGrid.gridNumber;
			ViewBag.Colors = Colors;

			return View();
		}

		public ActionResult JoinAsSpymaster()
		{
			if(SpymasterGrid == null)
			{
				return View("Index");
			}

			ViewBag.Words = WordsGrid;
			ViewBag.GridColor = SpymasterGrid.gridColor;
			ViewBag.GridNumber = SpymasterGrid.gridNumber;
			ViewBag.Colors = Colors;

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
				case "B": return "deepskyblue";
				case "Y": return "yellow";
				case "R": return "indianred";
				case "X": return "darkgrey";
				default: throw new ArgumentException("Unrecognized color");
			}
		}

		private SpymasterGrid GetSpymasterGrid()
		{
			var index = Random.Next(1, Constants.spymasterGrids.Count());
			return Constants.spymasterGrids[index];
		}

		private IEnumerable<string> CreateWordsGrid()
		{
			var Words = new List<string>();
			var numOfWords = Constants.wordList.Count();
			if(numOfWords - Numbers.Count() < 25)
			{
				Numbers = new List<int>();
			}

			for (var i = 0; i < GridSize; i++)
			{
				var num = Random.Next(1, numOfWords);
				while (Numbers.Contains(num))
				{
					num = Random.Next(1, numOfWords);
				}
				Numbers.Add(num);
				Words.Add(Constants.wordList[num]);
			}

			return Words;
		}
	}
}