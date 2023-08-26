using System;
using System.Collections.Generic;
using System.Text;

namespace Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLados = 0;
            float lonLados = 1.0f;
            float perimetro = 1.0f;

            Console.WriteLine("Dame el numero de lados del poligono");
            numLados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame la longitud de los lados del poligono");
            lonLados = Convert.ToSingle(Console.ReadLine());

            perimetro = numLados * lonLados;

            Console.WriteLine("El perimetro del poligono es {0}", perimetro);

            Console.ReadKey();


        }
    }
}
