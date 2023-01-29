using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    static class Show
    {
        public static void Menu()
        {
            Console.WriteLine("Выберите пункт меню:");
            Console.WriteLine("1 - Отобразить всю информацию о странах");
            Console.WriteLine("2 - Отобразить название стран");
            Console.WriteLine("3 - Отобразить название столиц");
            Console.WriteLine("4 - Отобразить название всех европейских стран");
            Console.WriteLine("5 - Отобразить название стран с площадью большей конкретного числа");
        }
        public static void Error()
        {
            Console.WriteLine("Ошибка! Введен неправильный пункт меню.");
        }
        public static void ShowRes(IEnumerable<object> collection)
        {
            foreach (var country in collection)
            {
                if (country is Country it)
                    Console.WriteLine($"Страна: {it.Name}\nСтолица: {it.Capital}\nНаселение: {it.Population} человек\nПлощадь: {it.Territory} км^2\nЧасть света: {it.PartOfTheWorld}\n");
                    else Console.WriteLine($"{country}");
            }

        }
    }
}
