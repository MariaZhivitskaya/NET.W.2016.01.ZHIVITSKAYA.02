using System;
using ClassLibraryTask1;

namespace ConsoleApplicationTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            var city1 = new City("Minsk", 307.9f);
            var city2 = new City("London", 1572.0f);

            Console.WriteLine(city1.ToString());
            Console.WriteLine(city2.ToString());

            Console.ReadKey();
        }
    }
}
