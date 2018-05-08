using System.Linq;
using System.Collections.Generic;


namespace FavNewFeatures
{
	public static class DataStore
	{
		public static List<(string Name, decimal Modifier)> Toppings =>
			new List<(string, decimal)>
			{
				("Ketchup", 0), //0
				("Mustard", 0),//1
				("Sliced Pickles", .25M),//2
				("Pickle Spears", .5M),//3
				("Mayo", 0),//4
				("Relish", .25M),//5
				("Coleslaw", .75M),//6
				("Kraut", .5M),//7
				("Tomato", 1M),//8
				("Onion", .25M),//9
				("Cheese", .33M),//10
				("Chili", .50M)//11
			};

		public static List<(int ID, string Name, decimal BaseCost)> Stands =>
			new List<(int, string, decimal)>
			{
				(0, "Sal", 1.25M),
				(1, "Marty", 2.99M),
				(2, "Weiner World", .75M),
				(3, "Will Wheniers", 3.50M),
				(4, "Terry's Hotdogs", .10M)
			};

		public static List<(int ID, string Name, IList<string> Toppings)> NamedHotdogs =>
			new List<(int, string, IList<string>)>
			{
				(0, "Cheese Dog", new List<string>{Toppings[10].Name}),
				(1, "Chicago-style Dog", new List<string>{
					Toppings[5].Name,
					Toppings[3].Name,
					Toppings[8].Name
				}),
				(2, "Chili Dog", new List<string>{Toppings[11].Name}),
				(3, "Everything", Toppings.Select(t=>t.Name).ToList())
			};
    }
}
