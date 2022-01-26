using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задание23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FactAsync(n);
            Console.ReadKey();
        }

        static void Fact(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
                Thread.Sleep(10);
            }
            Console.WriteLine(f);
        }
        static async void FactAsync(int n)
        {
            await Task.Run(()=>Fact(n));
        }
    }
}
