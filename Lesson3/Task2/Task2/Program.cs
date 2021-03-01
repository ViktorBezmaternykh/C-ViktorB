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
            string[,] telBook = new string[5, 2]; //создаем массив
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ВВедите ФИО человека и через энтер его номер или эмейл"); // вводим данные с клавиатуры
                string name = Console.ReadLine(); 
                telBook[i, 0] = name;
                string tel = Console.ReadLine();
                telBook[i, 1] = tel;

            }
            Console.Clear(); //чистим экран и выводим массив
            for (int i = 0; i < 5; i++)
            { Console.WriteLine($"{telBook[i, 0]} {telBook[i, 1]}"); }


        }
    }
}
