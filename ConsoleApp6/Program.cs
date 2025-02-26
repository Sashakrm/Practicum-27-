using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[5];
            Randomed(mas);
            Array.Sort(mas);
            Output(mas);
            Console.Read();
        }
        static void Randomed(int [] mas)
        {
            Random random = new Random();
            for(int i=0;i<4;i++)
            {
                int d = random.Next(1, 999);
                mas[i] = d;
            }
        }
        static void Output(int [] mas)
        {
            for(int i=0;i<4;i++)
            {
                Console.WriteLine($"mas[{i}]={mas[i]}");
            }
        }
    }
}
