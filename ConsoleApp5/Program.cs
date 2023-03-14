using System;
using System;
using System.Collections;
namespace ConsoleApp5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList cityPopulations = new SortedList();
            // Добавление городов с численностью населения в SortedList
            cityPopulations.Add("Москва", 12380664);
            cityPopulations.Add("Санкт-Петербург", 5383968);
            cityPopulations.Add("Новосибирск", 1625631);
            cityPopulations.Add("Екатеринбург", 1493749);
            cityPopulations.Add("Нижний Новгород", 1246465);
            // Вывод названий городов и их численности
            foreach (DictionaryEntry cityPopulation in cityPopulations)
            {
                Console.WriteLine(cityPopulation.Key + ": " + cityPopulation.Value);
            }
 
        }
    }
}
