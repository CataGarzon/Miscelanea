using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micelanea
{
    class Operadores
    {
        static double n1, n2, n3, n4;
        public static void AreaTriangulo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Área del triangulo");
            Console.WriteLine("Ingrese un numero para la base del triangulo: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para la altura del triangulo: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("el area del triangulo es : " + (n1 * n2) / 2);
        }
        public static void Suma()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Suma de dos numeros");
            Console.WriteLine("Ingrese un numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("el resultado de la suma es : " + (n1 + n2));
        }
        public static void Cuadrado()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Numero elevado al cuadrado");
            Console.WriteLine("Ingrese un numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("el resultado del numero al cuadrado es : " + Math.Pow(n3, 2));
        }
        public static void EuroADolares()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Convertir euros a dolares");
            Console.WriteLine("Ingrese un monto: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(n1 + " euros a dolares es : " + (n1 * 1.06 + " USD"));
        }
        public static void AreaYPerimetroCuadrado()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Area y perimetro de un cuadrado");
            Console.WriteLine("Ingrese un numero para el lado del cuadrado: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("el resultado del area del cuadrado es : " + (n1 * 2) + " y el perimetro es: " + (n1 + n1 + n1 + n1));
        }
        public static void AreaYVolumenCilindro()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Area y volumen de un cilindro");
            Console.WriteLine("Ingrese un numero para la altura del cilindro: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para la base del cilindro: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = (n2 / 2);
            n4 = (2 * 3.1416 * n3 * n1) + (2 * 3.1416 * Math.Pow(n3, 2));
            Console.WriteLine("el resultado del area del cilindro es : " + n4 + " y el volumen es: " + ((3.1416 * Math.Pow(n3, 2)) * n1));
        }
        public static void LongitudYAreaCircunferencia()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Longitud y area de una circunferencia");
            Console.WriteLine("Ingrese un numero para el radio de la circunferencia: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("la longitud de la circunferencia es : " + (2 * 3.1416) * n1 + " y el area es: " + (3.1416 * Math.Pow(n1, 2)));
        }
        public static void PromedioDeTresNumero()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Promedio de tres numeros");
            Console.WriteLine("Ingrese un numero : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero : ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("el promedio de los 3 numeros es : " + (n1 + n2 + n3));
        }
    }
}
