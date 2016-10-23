using System;
using Animal;

class Program
{
	static void Main()
	{
		DomesticAnimal domestic = new DomesticAnimal();
		domestic.InfoDomesticAnimal();

		Cat cat = new Cat();
		cat.InfoCat();

		WildAnimal wild = new WildAnimal();
		wild.InfoWildAnimal();

		Wolf wolf = new Wolf();
		wolf.InfoWolf();

		Console.ReadLine();
	}
}