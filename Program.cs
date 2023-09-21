using System;
using System.Collections.Generic;
using System.Text;

namespace Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perimetro 3.0
            /* Area= (a*p)/2
             perimetro= numero de lados * long lados */

            int numLados = 0;
            float apotema = 1.0f;
            float lonLados = 1.0f;
            float resul = 1.0f;
            float area = 1.0f;
            float perim = 1.0f;
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

                resul = Perimetro(numLados, lonLados);
                
                Console.WriteLine("El perimetro del poligono es {0}", resul);
            
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Dame el valor de la apotema");
                apotema = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Dame el valor del perimetro");
                perim = Convert.ToSingle(Console.ReadLine());

                resul = Area(apotema, perim);

                Console.WriteLine("El Area del poligono es {0}", resul);
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }

            Console.ReadKey();


        }
        static float Perimetro(int n1, float n2)
        {
            float r = 0.0f;

            r = n1 * n2;

            return r;
        }

        static float Area(float a1, float a2)
        {
            float r = 0.0f;

            r = (a1 * a2)/2;

            return r;
        }
    }
}
