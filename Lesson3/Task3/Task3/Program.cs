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
            Console.WriteLine("ВВедите слово");
            string  Word = Console.ReadLine();
            int len = Word.Length;

            //char[] chars = new char[len];
            char[] backChar = new char[len];

            for (int i = 0; i < len; i++)
            {
                //chars[i] = Word[i];
                backChar[len - i-1] = Word[i];
            }
            Console.WriteLine();
            for (int i = 0; i < len; i++)
                {
                Console.Write(backChar[i]);
                }
        }
    }
}
