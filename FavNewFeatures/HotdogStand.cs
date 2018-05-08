using System.Collections.Generic;
using static System.String;

namespace FavNewFeatures
{
	public readonly struct HotdogStand
    {
		public readonly IEnumerable<Hotdog> Menu;
		public string Name { get;}
		public decimal BasePrice { get; }
		public HotdogStand(in IEnumerable<Hotdog> menu, string name, decimal basePrice)
		{
			Menu = menu;
			Name = name;
			BasePrice = basePrice;
		}

		public override string ToString() => $"{Name}'s Menu: \r\n\t {Join("\r\n\t", Menu)}";
	}
}
