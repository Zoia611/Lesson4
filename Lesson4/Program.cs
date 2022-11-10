using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int N= 0;  
            for (int i = 1; i <=n; i++)
            {
                N+= 2*i-1;
            }
            Console.WriteLine(N);
            Console.ReadKey();

        }
    }
}
