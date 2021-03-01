using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите номер месяца");
            string numMonth = Console.ReadLine();
            int numMonth2 = Convert.ToInt32(numMonth); // вводим номер месяца и преобразуем его в число
            
            if (numMonth2 >= 1 && numMonth2 <= 12) // ставим предохранитель на границы числа
            {
                DateTime n = new DateTime(2011, numMonth2, 10); // перегоняем номер месяца в формат даты и выводим на экран
                Console.WriteLine($"Это месяц {n.ToString("MMMM")}");
                
                
            }
            else
            {
                Console.WriteLine("Номер месяца должен быть числом между 1 и 12, попробуйте еще раз"); //если номер месяца не между 1 и 12 выводим сообщение об ошибке
            }
        }
    }
}
