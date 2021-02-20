using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosYContextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa1 = new Empresa();
            Empresa empresa2 = new Empresa();

            empresa1.NombreLegal = "Nombre Legal Empresa 1";
            empresa1.Direccion = "Dirección Empresa 1";

            empresa2.NombreLegal = "Nombre Legal Empresa 2";
            empresa1.Direccion = "Dirección Empresa 2";



        }
    }
}
