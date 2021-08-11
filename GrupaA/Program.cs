using System;

namespace GrupaA
{
	class Program
	{
		static void Main(string[] args)
		{
			//1 - napraviti da se defense heroja isto proverava pre napada
			//2 - napriviti da se za svaki napad prvo smanjuje defense
			//pa tek kada se on izgubi padaju helti :)
			int hero_hp = 100;
			int hero_attack = 20;
			int hero_defense = 50;

			int goblin_hp = 50;
			int goblin_attack = 5;
			int goblin_defense = 100;

			while (hero_hp > 0 && goblin_hp > 0)
			{
				if (goblin_defense < hero_attack)
				{
					goblin_hp = goblin_hp - hero_attack;
					Console.WriteLine($"Heroj udara za {hero_attack}, goblin sada ima {goblin_hp}.");
				} else
                {
					Console.WriteLine("Napad nije dovoljno jak :/");
                }
				hero_hp = hero_hp - goblin_attack;
				Console.WriteLine($"Goblin udara za {goblin_attack}, goblin sada ima {hero_hp}.");
			}
		}
	}
}
