using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine(); // ввод имени лучше смотрится на новой строке
            Console.Clear(); // Очистим экран для удобства
            string nowDate = DateTime.Now.ToString("dd MMMM yyyy"); // Нам нужна только дата
            Console.WriteLine($"Привет, {name}, сегодня {nowDate}.");
        }
    }
}
 