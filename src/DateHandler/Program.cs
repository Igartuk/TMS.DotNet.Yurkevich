using System;

namespace DateHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите дату и мы узнаем день недели за вас: ");

                var dateString = Console.ReadLine();

                if (dateString.Equals("end", StringComparison.InvariantCultureIgnoreCase)) break;

                var dt = DateTime.TryParse(dateString, out var result) ? result : (DateTime?)null;

                if (dt == null)
                {
                    Console.WriteLine("Неверный формат,введите еще раз");
                    continue;
                }

                Console.WriteLine(dt.Value.DayOfWeek);
                Console.WriteLine("Если вы закончили,наберите end ");
               
            }
        }
    }
}
