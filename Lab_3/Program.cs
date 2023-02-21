using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Time
        {
            Morning,
            Midday,
            Evening,
            Night
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру от 1 до 7, чтобы выбрать день недели");
            int dayOfTheWeek = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Введите число от 0 до 23, чтобы выбрать который час");
            int daytime = Convert.ToInt32(Console.ReadLine());
            if(daytime >= 7 && daytime <= 12)
            {
                daytime = 0;
            }
            else if (daytime >= 13 && daytime <= 18)
            {
                daytime = 1;
            }
            else if (daytime >= 19 && daytime <= 23)
            {
                daytime = 2;
            }
            else if(daytime >= 0 && daytime <= 6)
            {
                daytime = 3;
            }
            Day day = (Day)(Enum.GetValues(typeof(Day)).GetValue(dayOfTheWeek));
            Time time = (Time)(Enum.GetValues(typeof(Time)).GetValue(daytime));
            Console.WriteLine($"Сейчас {day}, {time}");
        }
    }
}
