using System;

namespace W5Day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string populationStr1;
            int population1;
            string populationStr2;
            int population2;
            string populationStr3;
            int population3;
            string name1;
            string name2;
            string name3;




            
            do
            {
                Console.WriteLine("Enter City: ");
                name1 = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name1));
            
            do
            {
                Console.WriteLine("Enter Population: ");
                populationStr1 = Console.ReadLine();
            } while (!int.TryParse(populationStr1, out population1));

            
            do
            {
                Console.WriteLine("Enter City: ");
                name2 = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name2));
            
            
            do
            {
                Console.WriteLine("Enter Population: ");
                populationStr2 = Console.ReadLine();
            } while (!int.TryParse(populationStr2, out population2));

            do
            {
                Console.WriteLine("Enter City: ");
                name3 = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name3));
            
            
            do
            {
                Console.WriteLine("Enter Population: ");
                populationStr3 = Console.ReadLine();
            } while (!int.TryParse(populationStr3, out population3));



            ChinaCity chinaCity1 = new ChinaCity(name1, population1);

            
            ChinaCity chinaCity2 = new ChinaCity(name2, population2);

            
            ChinaCity chinaCity3 = new ChinaCity(name3, population3);

            ChinaCity[] Arr = { chinaCity1, chinaCity2, chinaCity3 };

            Console.WriteLine(FindAveragePopulation(Arr));

        }

        static double FindAveragePopulation(ChinaCity[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i].Population;
            }
            return total / arr.Length;
        }
    }
}
