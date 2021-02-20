using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 5, -10, 5, 1555, -951, 888 };

            List<int> resultado = numeros.Where(num => num > 0).ToList();

            Console.ReadKey();
        }
    }
}
