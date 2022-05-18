using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micelanea
{
    class Condicionales //catalina lozano
    {
        static double n1, n2, n3, n4, nA, nB, divindiendo, divisor;

        public static void numeropositivoynegativo()

        {
            Console.WriteLine("Ingresar un numero positivo o negativo");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 > 0)
            {
                Console.WriteLine("El numero es positivo");

            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }
            
        }
        public static void numeromayornumeromenor()
        {

            Console.WriteLine("Ingresar un numero");
             n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar un segundo numero");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n2 > n3)
            {
                Console.WriteLine("El numero mayor es" + n2);
            }
            else if (n2 == n3)
            {
                Console.WriteLine("estos numeros son iguales");

            }
            else
            {
                Console.WriteLine("el numero mayor es" + n3);
            }
            Console.ReadKey();
        }
        public static void tresnumerosmayorymenor()
        {
            Console.WriteLine("ingresa el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            n3 = int.Parse(Console.ReadLine());


            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("\n El numero mayor es: " + n1);
            }
            if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("\n el mayor es: " + n2);

            }
            if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("\n el numero mayor es: " + n3);

            }
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("\n El numero menor es: " + n1);
            }
            if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine("\n el menor es: " + n2);

            }
            if (n3 < n1 && n3 < n2)
            {
                Console.WriteLine("\n el menor es: " + n3);

            }
            if (n1 == n2)
            {
                Console.WriteLine("los numeros son iguales");
            }

            if (n1 == n3)
            {
                Console.WriteLine("los numeros son iguales");
            }
            if (n2 == n3)
            {
                Console.WriteLine("los numeros son iguales");
            }
            Console.ReadKey();

        }
        public static void dados2numerossumarlossiunoesmenorqueelotro()
        {
            Console.WriteLine("Ingresar el primer numero");
             nA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo numero");
            nB = Convert.ToInt32(Console.ReadLine());

            if (nA == nB)
            {
                Console.WriteLine("El numero mayor es: " + nA);
            }
            else if (nA < nB)
            {
                Console.WriteLine("suma de el mayor: " + (nA + nB));

            }
            else
            {
                Console.WriteLine("se resta: " + (nA - nB));
            }

            Console.ReadKey();
        }
        public static void Dadosdosnúmerosencontrarelcocienteentreellos()
        {
            
            Console.WriteLine("porfavor ingrese el dividiendo");
            divindiendo = double.Parse(Console.ReadLine());

            Console.WriteLine("porfavor ingrese el divisor");
            n2= double.Parse(Console.ReadLine());
            if (n2 == 0)

            {
                Console.WriteLine("no se puede dividir entre cero");

            }
            else
            {
                divisor = divindiendo / n2;
                Console.WriteLine("la division es " + divisor);
            }

            Console.WriteLine("el cociente de la division es:" + (divindiendo / n2) +
                "y el residuo de la division es: " + (divindiendo % n2));


            Console.ReadKey();
        }
        public static void dadodosnumerossumarlossialmenosunodeellosesnegativoysiesalcontrariomultiplicarlo()
        {
            
            Console.WriteLine("Ingresar un numero positivo o negativo");
            nA = int.Parse(Console.ReadLine());
            Console.WriteLine(" ingrese otro numero postivo o negativo");
            nB = int.Parse(Console.ReadLine());


            if (nA > 0 || (nB < 0))
            {
                Console.WriteLine("se realiza la suma ");
                Console.WriteLine("el resultado de la suma de a y b es:" + (nA + nB));

            }

            else
            {
                Console.WriteLine("se realiza la multiplicaacion de los numeros");
                Console.WriteLine("el numero negativo se suma: " + (nA + nB));
            }

            Console.ReadKey();

            
        }
        public static void caalcularañobisiesto()
        {

            Console.WriteLine("ingrese el año: ");
            int n1;
            n1 = int.Parse(Console.ReadLine());

            if (n1 / 4 == 0)
            {
                if (n1 / 100 == 0)
                {
                    if (n1 / 400 == 0)
                    {
                        Console.WriteLine("el año es" + n1 + "bisiesto");

                    }
                    else
                    {
                        Console.WriteLine("el año " + n1 + "no es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("el año es" + n1 + "bisiesto");
                }

            }
            else
            {
                Console.WriteLine("el año " + n1 + "no es bisiesto");
            }
        }

    }
}
