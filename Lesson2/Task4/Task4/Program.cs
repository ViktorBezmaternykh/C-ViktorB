using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert bame of Shop");
            string name = Console.ReadLine();

            Console.WriteLine("Insert number of position, that you bought");
            string n = Console.ReadLine();
            int num = Convert.ToInt32(n);

            //Console.WriteLine("Insert date of shopping in format minute, hour, dd, mm ,yy");
            //Console.Read()
            //DateTime date = new DateTime();

            Console.WriteLine("Сколько позиций вы купили?");
            string colPoz = Console.ReadLine();
            int colPoz2 = Convert.ToInt32(colPoz);

            for (int i=0; i<=colPoz2; i++)
            {
                Console.WriteLine("ВВедите наименование товара, количество и стоимость каждого товара");
                string nameTov = Console.ReadLine();
                string col = Console.ReadLine();
                int col2 = Convert.ToInt32(col);
                string stoimost = Console.ReadLine();
                float stoimost2 = float.Parse(stoimost);
                //float total = total + (stoimost2*col2); 
            }
        }
    }
}
