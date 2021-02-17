using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            try
            {
                int resultado = a / b;
                Console.WriteLine(a + " dividido " + b + " es " + resultado);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("DivideByZeroException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("No se puede dividir " + a + " por " + b);
            }

            Console.ReadKey();
        }
    }
}
