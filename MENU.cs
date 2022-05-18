using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micelanea
{
    class MENU//catalina lozano
    {
            
            public static void MenuPrincipal()
            {


                Console.WriteLine("MENU");
                Console.WriteLine("Elija a opcion que desea: \n1 Operadores. \n2 Condicionales. \n3 Ciclos. \n4 Salir.");
            }
            public static void MenuOperadores()
            {
                Console.WriteLine("***************************");
                Console.WriteLine("         OPERADORES        ");
                Console.WriteLine("Elija a opcion que desea: \n1 Área del triangulo. \n2 Suma de dos numeros. \n3 Numero elevado al cuadrado. \n4 Convertir euros a dolares. \n5 Area y perimetro de un cuadrado. \n6 Area y volumen de un cilindro. \n7 Longitud y area de una circunferencia.\n8 Promedio de tres numeros. \n9 Salir.");
            }
            public static void MenuCondicionales()
            {
                Console.WriteLine("***************************");
                Console.WriteLine("             condicionales           ");
                Console.WriteLine("Elija a opcion que desea: \n1 positovos y negativos. \n2 numero mayor y numero menor. \n3 tres numeros menor y mayor. \n4 dados 2 numeros sumarlos si uno es menor que el otro . \n5 Dados dos números encontrar el cociente entre ellos. \n6 dado dos numeros sumarlos si al menos uno de ellos es negativo y si es al contrario multiplicarlo.\n7 Calcular que año es bisiesto .\n5 Salir ");
            }
            public static void MenuCiclos()
            {
                Console.WriteLine("***************************");
                Console.WriteLine("Elija a opcion que desea:" +

                    "\n1. Imprimir todos los múltiplos de 3 que hay entre 1 y 100. ." +
                    "\n2. Imprimir los números impares entre 0 y 100." +
                    "\n3. Imprimir los números pares del 1 al 100. " +
                    "\n4. Escribir un programa que imprima por pantalla los cuadrados de los números del 1 al 30." +
                    "\n5  programa que sume los cuadrados de los cien primeros números naturales." +
                    "\n6. Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos en secuencia ascendente." +
                    "\n7.  Sumar todos los números que se digitan por teclado mientras no sea cero. ." +
                    "\n8. Salir.");
            }
            public static void Volver()
            {

                String RespuestaContinuar = null;
                do
                {
                    // COMANDO para regresar al MENU
                    Console.WriteLine("\n¿Desea continuar usando el programa y volver al menu? SI/NO)");
                    RespuestaContinuar = Console.ReadLine();
                    if ((RespuestaContinuar == "SI") || (RespuestaContinuar == "si"))
                    {
                        Console.Clear();
                        Program.Main();
                    }

                    else if ((RespuestaContinuar == "NO") || (RespuestaContinuar == "no"))
                    {
                        Console.Clear();
                        Console.WriteLine("Salió del programa.");
                        Environment.Exit(1);
                    }
                } while ((RespuestaContinuar != "SI") && (RespuestaContinuar != "NO"));
            }

    }   
}
