using Operaciones;
using System;

namespace NamespacesYUsing
{
    enum EstatusOperacion
    {
        Exitoso = 1,
        ClienteNoEncontrado = 2,
        ErrorDeSistema = 5
    }

    class Program
    {
        static void Main(string[] args)
        {
            // números mágicos
            int estatusOperacion = 5;
            //if (estatusOperacion == 1)
            if (estatusOperacion == (int)EstatusOperacion.Exitoso)
            {
                Console.WriteLine(estatusOperacion);
            }
            //else if (estatusOperacion == 2)
            else if (estatusOperacion == (int)EstatusOperacion.ClienteNoEncontrado)
            {
                Console.WriteLine(estatusOperacion);
            }
            //else if (estatusOperacion == 5)
            else if (estatusOperacion == (int)EstatusOperacion.ErrorDeSistema)
            {
                Console.WriteLine(estatusOperacion);
            }

            // strings mágicos
            string stringEstatusOperacion = "K15";
            //if (stringEstatusOperacion == "K120")
            if (stringEstatusOperacion == StringEstatusOperacion._exitoso)
            {
                Console.WriteLine(stringEstatusOperacion);
            }
            //else if (stringEstatusOperacion == "P4")
            else if (stringEstatusOperacion == StringEstatusOperacion._clienteNoEncontrado)
            {
                Console.WriteLine(stringEstatusOperacion);
            }
            //else if (stringEstatusOperacion == "K15")
            else if (stringEstatusOperacion == StringEstatusOperacion._errorDelSistema)
            {
                Console.WriteLine(stringEstatusOperacion);
            }

            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}