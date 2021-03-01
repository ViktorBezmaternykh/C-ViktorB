using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Nnumber"); // ввод числа и преобразование в число из строки
            string num = Console.ReadLine();
            int num2 = Convert.ToInt32(num);
            
            int ost = (num2 % 2); // вычисление остатка от деления на 2. 0 - четное, 1 - не четное
            if (ost == 0)
            {
                Console.WriteLine("It's an even number");
            }
            else
            {
                Console.WriteLine("It's an odd number");
            }

        }
    }
}
