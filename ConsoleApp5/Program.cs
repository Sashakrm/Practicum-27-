using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[4];
            InputData(mas);
            Array.Reverse(mas);
            OutputData(mas);
            
            Console.Read();
        }
        static void InputData(int[] mas)
        {
            int i;
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine($"mas[{i}]= ");
                mas[i] = int.Parse(Console.ReadLine());
            }
            
        }
  
        
        static void OutputData(int [] mas)
        {
            foreach(int element in mas)
            {
                Console.WriteLine($"{element}\t");
            }
        }
    }
}
