using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ariginal = File.ReadAllLines("words.txt");
            string[] briginal = File.ReadAllLines("scrambled.txt");
            string[] a = File.ReadAllLines("words.txt");
            string[] b = File.ReadAllLines("scrambled.txt");
            for (int s = 0; s < b.Length; s++)
            {
                b[s] = string.Concat(briginal[s].OrderBy(c => c));
               // Console.WriteLine("Concat");
            }
            for (int k = 0; k < a.Length; k++)
            {
                a[k] = string.Concat(ariginal[k].OrderBy(c => c));
                //Console.WriteLine("Concat");
            }
            for (int z = 0; z < b.Length; z++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == b[z])
                    {
                        Console.Write(ariginal[i] + ",");
                    }
                }

            }
          //  Array.ForEach(ariginal, Console.WriteLine);

            Console.ReadLine();
        }
    }
}
