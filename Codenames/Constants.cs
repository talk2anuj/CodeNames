using Codenames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codenames
{
	public static class Constants
	{
		public static string[] wordList = { "Hollywood", "Well", "Foot", "New York", "Spring", "Court", "Tube", "Point", "Tablet",
			"Slip", "Date", "Drill", "Lemon", "Bell", "Screen", "Fair", "Torch", "State", "Match", "Iron", "Block", "France",
			"Australia", "Limousine", "Stream", "Glove", "Nurse", "Leprechaun", "Play", "Tooth", "Arm", "Bermuda", "Diamond",
			"Whale", "Comic", "Mammoth", "Green", "Pass", "Missile", "Paste", "Drop", "Pheonix", "Marble", "Staff", "Figure",
			"Park", "Centaur", "Shadow", "Fish", "Cotton", "Egypt", "Theater", "Scale", "Fall", "Track", "Force", "Dinosaur",
			"Bill", "Mine", "Turkey", "March", "Contract", "Bridge", "Robin", "Line", "Plate", "Band", "Fire", "Bank", "Boom",
			"Cat", "Shot", "Suit", "Chocolate", "Roulette", "Mercury", "Moon", "Net", "Lawyer", "Satellite", "Angel", "Spider",
			"Germany", "Fork", "Pitch", "King", "Crane", "Trip", "Dog", "Conductor", "Part", "Bugle", "Witch", "Ketchup", "Press",
			"Spine", "Worm", "Alps", "Bond", "Pan", "Beijing", "Racket", "Cross", "Seal", "Aztec", "Maple", "Parachute", "Hotel",
			"Berry", "Soldier", "Ray", "Post", "Greece", "Square", "Mass", "Bat", "Wave", "Car", "Smuggler", "England", "Crash",
			"Tail", "Card", "Horn", "Capital", "Fence", "Deck", "Buffalo", "Microscope", "Jet", "Duck", "Ring", "Train", "Field",
			"Gold", "Tick", "Check", "Queen", "Strike", "Kangaroo", "Spike", "Scientist", "Engine", "Shakespeare", "Wind", "Kid",
			"Embassy", "Robot", "Note", "Ground", "Draft", "Ham", "War", "Mouse", "Center", "Chick", "China", "Bolt", "Spot",
			"Piano", "Pupil", "Plot", "Lion", "Police", "Head", "Litter", "Concert", "Mug", "Vacuum", "Atlantis", "Straw", "Switch",
			"Skyscraper", "Laser", "Scuba Diver", "Africa", "Plastic", "Dwarf", "Lap", "Life", "Honey", "Horseshoe", "Unicorn",
			"Spy", "Pants", "Wall", "Paper", "Sound", "Ice", "Tag", "Web", "Fan", "Orange", "Temple", "Canada", "Scorpion",
			"Undertaker", "Mail", "Europe", "Soul", "Apple", "Pole", "Tap", "Mouth", "Ambulance", "Dress", "Ice Cream", "Rabbit",
			"Buck", "Agent", "Sock", "Nut", "Boot", "Ghost", "Oil", "Superhero", "Code", "Kiwi", "Hospital", "Saturn", "Film",
			"Button", "Snowman", "Helicopter", "Loch Ness", "Log", "Princess", "Time", "Cook", "Revolution", "Shoe", "Mole", "Spell",
			"Grass", "Washer", "Game", "Beat", "Hole", "Horse", "Pirate", "Link", "Dance", "Fly", "Pit", "Server", "School", "Lock",
			"Brush", "Pool", "Star", "Jam", "Organ", "Berlin", "Face", "Luck", "Amazon", "Cast", "Gas", "Club", "Sink", "Water",
			"Chair", "Shark", "Jupiter", "Copper", "Jack", "Platypus", "Stick", "Olive", "Grace", "Bear", "Glass", "Row", "Pistol",
			"London", "Rock", "Van", "Vet", "Beach", "Charge", "Port", "Disease", "Palm", "Moscow", "Pin", "Washington", "Pyramid",
			"Opera", "Casino", "Pilot", "String", "Night", "Chest", "Yard", "Teacher", "Pumpkin", "Thief", "Bark", "Bug", "Mint",
			"Cycle", "Telescope", "Calf", "Air", "Box", "Mount", "Thumb", "Antactica", "Trunk", "Snow", "Penguin", "Root", "Bar",
			"File", "Hawk", "Battery", "Compound", "Slug", "Octopus", "Whip", "America", "Ivory", "Pound", "Sub", "Cliff", "Lab",
			"Eagle", "Genious", "Ship", "Dice", "Hood", "Heart", "Novel", "Pipe", "Himalayas", "Crown", "Round", "India", "Needle",
			"Shop", "Watch", "Lead", "Tie", "Table", "Cell", "Cover", "Czech", "Back", "Bomb", "Ruler", "Forest", "Bottle", "Space",
			"Hook", "Doctor", "Ball", "Bow", "Degree", "Rome", "Plane", "Giant", "Nail", "Dragon", "Stadium", "Flute", "Carrot",
			"Wake", "Fighter", "Model", "Tokyo", "Eye", "Mexico", "Hand", "Swing", "Key", "Alien", "Tower", "Poison", "Cricket",
			"Cold", "Knife", "Church", "Board", "Cloak", "Ninja", "Olympus", "Belt", "Light", "Death", "Stock", "Millionarie",
			"Day", "Knight", "Pie", "Bed", "Circle", "Rose", "Change", "Cap", "Triangle" };

		public static SpymasterGrid[] spymasterGrids = {
			new SpymasterGrid {
				gridColor = "Red",
				gridNumber = 1,
				colors = new[]{"R","B","Y","B","B","Y","B","R","R","R","B","B","X","R","Y","R","R","Y","Y","R","B","Y","R","B","Y"}
			},
			new SpymasterGrid {
				gridColor = "Red",
				gridNumber = 2,
				colors = new[]{"R","Y","B","R","R","R","B","Y","B","B","Y","X","B","R","Y","Y","Y","B","Y","B","B","R","R","R","R"}
			},
			new SpymasterGrid {
				gridColor = "Red",
				gridNumber = 3,
				colors = new[]{ "B","Y","B","R","Y","B","B","Y","R","Y","R","B","R","R","R","R","B","Y","B","B","Y","R","Y","X","R"}
			},
			new SpymasterGrid {
				gridColor = "Red",
				gridNumber = 4,
				colors = new[]{"B","Y","Y","Y","B","R","R","B","R","Y","R","Y","Y","R","R","B","R","B","R","B","Y","R","X","B","B"}
			},
			new SpymasterGrid {
				gridColor = "Red",
				gridNumber = 5,
				colors = new[]{"B","Y","Y","B","B","R","Y","R","Y","Y","B","R","B","B","R","B","R","X","R","R","B","Y","Y","R","R"}
			},
			new SpymasterGrid {
				gridColor = "Blue",
				gridNumber = 6,
				colors = new[]{"Y","B","R","B","B","R","Y","Y","X","R","R","Y","B","B","Y","R","R","B","Y","R","B","B","Y","R","B"}
			},
			new SpymasterGrid {
				gridColor = "Blue",
				gridNumber = 7,
				colors = new[]{"B","Y","B","Y","R","R","B","R","B","B","Y","Y","X","R","Y","R","B","R","R","B","R","B","Y","B","Y"}
			},
			new SpymasterGrid {
				gridColor = "Blue",
				gridNumber = 8,
				colors = new[]{"Y","R","Y","Y","R","B","Y","R","B","B","B","B","R","R","R","R","Y","X","Y","B","B","B","B","R","Y"}
			},
			new SpymasterGrid {
				gridColor = "Blue",
				gridNumber = 9,
				colors = new[]{"B","Y","R","R","R","R","B","Y","R","Y","Y","B","B","B","B","B","X","Y","Y","R","R","Y","B","R","B"}
			},
			new SpymasterGrid {
				gridColor = "Blue",
				gridNumber = 10,
				colors = new[]{"B","Y","Y","R","R","B","Y","B","B","B","R","X","Y","R","B","R","B","R","B","Y","R","Y","Y","B","R"}
			}
		};
	}
}