using System;
using System.Collections.Generic;
using System.Text;

namespace Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perimetro 2.0
            /* Area= (a*p)/2
             perimetro= numero de lados * long lados */

            int numLados = 0;
            float apotema = 1.0f;
            float lonLados = 1.0f;
            float perimetro = 1.0f;
            float area = 1.0f;
            int opcion = 0;


            Console.WriteLine("Que desea calcular");
            Console.WriteLine("1- Perimetro");
            Console.WriteLine("2- Area");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Dame el numero de lados del poligono");
                numLados = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dame la longitud de los lados del poligono");
                lonLados = Convert.ToSingle(Console.ReadLine());

                perimetro = numLados * lonLados;

                Console.WriteLine("El perimetro del poligono es {0}", perimetro);
            
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Dame el valor de la apotema");
                apotema = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Dame el valor del perimetro");
                perimetro = Convert.ToSingle(Console.ReadLine());

                area = (apotema * perimetro)/2;

                Console.WriteLine("El Area del poligono es {0}", area);
            }

            Console.ReadKey();


        }
    }
}
