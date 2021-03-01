using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру за сутки с точностью до десятых, через запятую");
            string maxTemp = Console.ReadLine(); // insert max temperature
            float maxTemp2 = float.Parse(maxTemp); // convert string to float
            
            Console.WriteLine("Введите минимальную температуру за сутки с точностью до десятых, через запятую");
            string minTemp = Console.ReadLine(); // insert min temperature
            float minTemp2 = float.Parse(minTemp); // convert string to float
            
            float medTemp = (maxTemp2 + minTemp2)/2; 
            Console.WriteLine($"средняя температура составляет {medTemp} градусов");
        }
    }
}
