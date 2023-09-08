using System;
using System.Linq;
using System.IO;
using System.Text;

namespace testirz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] list = s.Split(' ');
            Console.WriteLine($"Параметров: {list.Length}");
            for (int i=0; i<list.Length;i++)
            {
                Console.WriteLine("\t{0,2}[{1,2}]", i, list[i].Length);
            }            
        }
    }
}
