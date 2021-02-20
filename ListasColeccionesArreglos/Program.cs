using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasColeccionesArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            // listas
            List<string> nombres = new List<string>();
            nombres.Add("Nombre01");
            nombres.Add("Nombre02");
            nombres.Add("Nombre03");

            Console.WriteLine(nombres[0]);


            // diccionario
            Dictionary<string, int> nombreYEdad = new Dictionary<string, int>();
            nombreYEdad.Add("Nombre01", 15);
            nombreYEdad.Add("Nombre02", 30);
            nombreYEdad.Add("Nombre03", 40);
            nombreYEdad.Add("Nombre04", 65);









            Console.ReadKey();
        }
    } 
}
