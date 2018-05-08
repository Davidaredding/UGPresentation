using System;
using System.Collections.Generic;
using System.Linq;
using static System.String;

namespace FavNewFeatures
{
	public class Hotdog
	{
		private IEnumerable<string> _toppings;
		public IEnumerable<string> Toppings
		{
			get => _toppings;
			set => _toppings =_toppings
								.Concat(
									(value ?? throw new ArgumentNullException("Toppings cannot be null"))
									.Except(_toppings)
								);
		}

		public string Name { get; set; }

		public Hotdog(IEnumerable<string> toppings)
		{
			Toppings = toppings;
		}

		public override string ToString() => $"Hotdog '{Name}' with {Join(',', Toppings)}";

		public static implicit operator Hotdog((string name, IList<string> toppings) hotDogData) =>
			new Hotdog(hotDogData.toppings) { Name = hotDogData.name};

		public static bool TryParse(object obj, out Hotdog hotdog)
		{
			hotdog = default;
			switch (obj)
			{
				case Hotdog h:
					hotdog = h;
					if (h.Toppings.Any(t => t.ToLower().Contains("pickle")))
						return false;
					return true;

				case HotdogStand stand:
					throw new InvalidCastException("Stop trying to sell the entire hotdog stand!");

				default:
					return false;
			}
		}
	}
}
