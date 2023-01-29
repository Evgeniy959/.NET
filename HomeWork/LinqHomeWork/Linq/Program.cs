using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main()
        {
            List<Country> countries = new List<Country>
            {
                new ("Russia", "Moscow", 146748590, 17098246, "Europe"),
                new ("France", "Paris", 63928608, 547030, "Europe"),
                new ("Austria", "Vienna", 8935112, 83879, "Europe"),
                new ("USA", "Washington", 332278200, 9826675, "North America"),
                new ("Japan", "Tokyo", 127000000, 377668, "Asia"),
                new ("Egypt", "Сairo", 87266562, 1001449, "Africa"),

            };
            Show.Menu();            
            var select = Console.ReadLine();
            switch (select)
            {
                case "1": // 1. Отобразить всю информацию о странах
                    Show.ShowRes(countries);
                    break;
                case "2": // 2. Отобразить название стран
                    var list = from country in countries
                        select country.Name;
                    //var list = countries.Select(item => item.Name);
                    Show.ShowRes(list);
                    break;
                case "3": // 3. Отобразить название столиц
                    var listCap = from country in countries
                        select country.Capital;
                    Show.ShowRes(listCap);
                    break;
                case "4": // 4. Отобразить название всех европейских стран
                    var listEu = from country in countries
                        where country.PartOfTheWorld == "Europe"
                        select country.Name;
                    //var listEu = countries.Where(item => item.PartOfTheWorld == "Europe").Select(item => item.Name);
                    Show.ShowRes(listEu);
                    break;
                case "5": // 5. Отобразить название стран с площадью большей конкретного числа
                    var listTer = from country in countries
                        where country.Territory > 700000
                        select country.Name;
                    Show.ShowRes(listTer);
                    break;
            }
            if (select != "1" && select != "2" && select != "3" && select != "4" && select != "5")
                Show.Error();
        }
    }
}