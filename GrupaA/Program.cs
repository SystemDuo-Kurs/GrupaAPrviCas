using System;

namespace GrupaA
{
	class Program
	{
		static void Main(string[] args)
		{
			int hero_hp = 100;
			int hero_attack = 20;

			int goblin_hp = 50;
			int goblin_attack = 20;

			while (hero_hp > 0 && goblin_hp > 0)
			{
				goblin_hp = goblin_hp - hero_attack;
				Console.WriteLine($"Heroj udara za {hero_attack}, goblin sada ima {goblin_hp}.");
				hero_hp = hero_hp - goblin_attack;
				Console.WriteLine($"Goblin udara za {goblin_attack}, goblin sada ima {hero_hp}.");
			}
		}
	}
}
