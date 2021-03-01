using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер квадратной матрицы"); //ввели размер матрицы, из которой необходимо вывести элементы
            string s = Console.ReadLine();
            int i = Convert.ToInt32(s);

            int[,] nums = new int[i, i];

            for (int j = 0; j < i; ++j) // j - номер строки
            {

                for (int k = 0; k < i; ++k) // k - номер столбца
                {
                    Console.WriteLine($"введите элемент {j} строки, {k} столбца"); // ввод элементов матрицы
                    string n = Console.ReadLine();
                    int m = Convert.ToInt32(n);
                    nums[j, k] = m;
                }


            }
            for (int j = 0; j < i; j++) // j - номер строки
            {
                for (int k = 0; k < i; k++) // k - номер столбца
                {
                    if (j == k)
                    { Console.Write($" {nums[j, k]} "); } //выводим диагональ
                }
                
            }

        }
    }
}

