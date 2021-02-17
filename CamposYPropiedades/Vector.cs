using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposYPropiedades
{
    class Vector
    {
        //private List<int> ListaValores;

        public List<int> MyProperty { get; set; }

        public Vector()
        {
            Console.WriteLine("Constructor del vector");
        }
        public Vector(List<int> lists)
        {
            Console.WriteLine("Constructor del vector - listas");
        }
    }
}
