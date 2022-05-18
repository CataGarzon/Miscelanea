using System;

namespace Micelanea
{
    class Program //catalina lozano
    {
        
        public static void Main()
        {
            int operacion = 0;
            int IF = 0;
            int ciclos = 0;
            int menú = 0;

            try
            {
                MENU.MenuPrincipal();

                menú = Convert.ToInt32(Console.ReadLine());
                switch (menú)


                {

                    case 1:
                        MENU.MenuOperadores();
                        operacion = Convert.ToInt32(Console.ReadLine());
                        switch (operacion)
                        {

                            case 1:
                                Operadores.AreaTriangulo();
                                MENU.Volver();
                                break;

                            case 2:
                                Operadores.Suma(); 
                                MENU.Volver();
                                break;
                            case 3:
                                Operadores.Cuadrado();
                                MENU.Volver();
                                break;
                            case 4:
                                Operadores.EuroADolares();
                                MENU.Volver();
                                break;
                            case 5:
                                Operadores.AreaYPerimetroCuadrado();
                                MENU.Volver();
                                break;
                            case 6:
                                Operadores.AreaYVolumenCilindro();
                                MENU.Volver();
                                break;
                            case 7:
                                Operadores.LongitudYAreaCircunferencia();
                                MENU.Volver();
                                break;
                            case 8:
                                Operadores.PromedioDeTresNumero();
                                MENU.Volver();
                                break;
                            case 9:
                                Console.WriteLine("----------------------");
                                Console.WriteLine("Salir");
                                break;

                            default:
                                {
                                    Console.WriteLine("Dato invalido");
                                    break;
                                }

                        }
                        break;



                    case 2:

                        MENU.MenuCondicionales();
                        IF = Convert.ToInt32(Console.ReadLine());


                        switch (IF)
                        {

                            case 1:

                                Condicionales.numeropositivoynegativo();
                                MENU.Volver();
                                break;

                            case 2:


                                Condicionales.numeromayornumeromenor();
                                MENU.Volver();

                                break;


                            case 3:
                                Condicionales.tresnumerosmayorymenor();
                                MENU.Volver();

                                break;


                            case 4:
                                Condicionales.dados2numerossumarlossiunoesmenorqueelotro();
                                MENU.Volver();

                                break;

                            case 5:
                                Condicionales.Dadosdosnúmerosencontrarelcocienteentreellos();
                                MENU.Volver();

                                break;

                            case 6:

                                Condicionales.dadodosnumerossumarlossialmenosunodeellosesnegativoysiesalcontrariomultiplicarlo();
                                MENU.Volver();

                                break;

                            case 7:
                                Condicionales.caalcularañobisiesto();
                                MENU.Volver();
                                break;


                            case 8:
                                Console.WriteLine("*****************************");
                                Console.WriteLine("Salir");
                                break;

                            default:
                                {
                                    Console.WriteLine("Dato invalido");
                                }
                                break;

                        }



                        break;




                    case 3:
                        MENU.MenuCiclos();
                        ciclos = Convert.ToInt32(Console.ReadLine());
                        switch (ciclos)
                        {
                            case 1:
                                ciclos1.multiplos3a100();
                                MENU.Volver();
                                break;

                            case 2:

                                ciclos1.numerosimparesde0al00();
                                MENU.Volver();
                                break;

                            case 3:
                                ciclos1.numerosparesde1al100();
                                MENU.Volver();
                                break;

                            case 4:
                                ciclos1.loscuadradosde30primeros();
                                MENU.Volver();

                                break;

                            case 5:
                                ciclos1.loscuadradosdelos100primerosnumeros();
                                MENU.Volver();
                                break;

                            case 6:

                                ciclos1.dadodosnumerosnaturales();
                                MENU.Volver();
                                break;

                            case 7:
                                ciclos1.sumartodoslosnumeros();
                                MENU.Volver();

                                break;


                            case 8:
                                Console.WriteLine("*******************");
                                Console.WriteLine("Salir");
                                break;
                        }

                        break;


                    case 9:
                        Console.WriteLine("Salir");
                        break;
                    default:
                        {
                            Console.WriteLine("Dato invalido.");
                            break;
                        }
                }

            }
            catch
            {

                Console.WriteLine("Dato invalido.");
            }

        }

    }

}

