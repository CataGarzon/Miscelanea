using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micelanea
{
   
    class ciclos1//catalina lozano
    {

        static double n1, n2, n3, n4, n5, n6, n7;
        public static void multiplos3a100()
        {

          
            Console.WriteLine("los multiplos de 3 a 100 son: ");
            for (n1 = 3; n1 <= 100; n1 += 3)
            {
                Console.WriteLine(n1);

            }


        }
        public static void numerosimparesde0al00()
        {
            Console.WriteLine("los numeros impares del 1 al 100 son: ");
            while (n2 <= 100)
            {
                Console.WriteLine(n2);
                n2 += 2;

            }

        }
        public static void numerosparesde1al100()
        {

          
            Console.WriteLine("los numeros pares de el 1 al 100 son: ");
            while (n3 <= 100)
            {

                Console.WriteLine(n3);
                n3 += 2;
            }

        }
        public static void loscuadradosde30primeros()
        {
            Console.WriteLine(" los cuadrados de los 30 primeros numeros son: ");
           
            for (n4 = 3; n4 <= 30; n4++)
            {
                Console.WriteLine("el cuadrado de " + n4 + " es " + Math.Pow(n4, 2));
            }
        }
        public static void loscuadradosdelos100primerosnumeros()
        {

            Console.WriteLine("los cuadrados de los 100 primeros numeros son: ");

            for (n5 = 0; n5 <= 100; n5++)
            {
                Console.WriteLine("el cuadrado de " + n5 + " es: " + Math.Pow(n5, 2));
                n6 = n6 + (int)(Math.Pow(n5, 2));
            }
            Console.WriteLine(" la suma de los cuadrados es: " + n6);
        }
        public static void dadodosnumerosnaturales()
        {
         
            for (n7 = 30; n7 <= 40; n7++)
            {
                Console.WriteLine("el numero comprendido es: " + n7);
            }

        }
        public static void sumartodoslosnumeros()
        {
            string linea;
            Console.WriteLine("Ingrese un valor (0 para finalizar) :");
            do
            {

                linea = Console.ReadLine();
                n2 = int.Parse(linea);
                if (n2 != 0)
                {
                    n1 = n1 + n2;
                    Console.WriteLine("El resultado de la suma es : " + n1 + "\n");
                }
                else
                {
                    Console.WriteLine("No se ingresan mas valores");
                }
            }
            while (n2 != 0);
        }

    } 
} 
