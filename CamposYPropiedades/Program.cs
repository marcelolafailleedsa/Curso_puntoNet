using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposYPropiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            var vector1 = new Vector();
            Vector vector2 = new Vector(new List<int> { 1, 2, 3, 4, 5 });

         //   Console.WriteLine(vector2.MyProperty[0]);

            Persona persona1 = new Persona();
            persona1.Nombre = "Señor";
            persona1.Apellido = "Pelmazo";
            persona1.FechaNacimiento = new DateTime(2000,1,1);

            Console.WriteLine(persona1);
            Console.WriteLine(persona1.Nombre);
            Console.WriteLine(persona1.Apellido);
            Console.WriteLine(persona1.FechaNacimiento);





            Console.ReadKey();
        }
    }
}
