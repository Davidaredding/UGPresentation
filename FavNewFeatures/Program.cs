

using System.Collections.Generic;
using System.Linq;

namespace FavNewFeatures
{
    class Program
    {
		static void Main()
		{
			var menu1 = DataStore.NamedHotdogs.Select(
				d => new Hotdog(d.Toppings) {Name = d.Name }
			);
			var menu2 = new List<Hotdog>
			{
				(Hotdog)(DataStore.NamedHotdogs[1].Name,DataStore.NamedHotdogs[1].Toppings)
			};

			var stands = DataStore.Stands.Select(s=>new HotdogStand(
					menu1,
					s.Name,
					s.BaseCost
				));

		}


    }
}
