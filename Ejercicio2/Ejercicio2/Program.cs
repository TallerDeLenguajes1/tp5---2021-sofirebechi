using System;

namespace Ejercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcion = 1;
            float num1, num2, aux;

         

             while (opcion == 1)
             {
                Console.WriteLine("* * * * CALCULADORA * * * *");
                Console.WriteLine("Seleccione la opcion deseada \n");
                Console.WriteLine("1-SUMA \n");
                Console.WriteLine("2-RESTA \n");
                Console.WriteLine("3-MULTIPLICACION \n");
                Console.WriteLine("4-DIVIDIR \n");

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion > 4)
                {
                    Console.WriteLine("## ERROR ## OPCION INVALIDA!");
                    Console.WriteLine("¿Desea realizar otra operaciòn? /n");
                    Console.WriteLine("1- SI /n");
                    Console.WriteLine("2- NO /n");
                    opcion = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Ingrese el primer numero:");


                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero:");


                    num2 = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {


                        case 1:

                            aux = num1 + num2;
                            Console.WriteLine("El resultado de la operacion es : " + aux);
                            Console.WriteLine("¿Desea realizar otra operaciòn? /n");
                            Console.WriteLine("1- SI /n");
                            Console.WriteLine("2- NO /n");

                            opcion = Convert.ToInt32(Console.ReadLine());
                            break;


                        case 2:

                            aux = num1 - num2;
                            Console.WriteLine("El resultado de la operacion es : " + aux);
                            Console.WriteLine("¿Desea realizar otra operaciòn? /n");
                            Console.WriteLine("1- SI /n");
                            Console.WriteLine("2- NO /n");

                            opcion = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 3:

                            aux = num1 * num2;
                            Console.WriteLine("El resultado de la operacion es : " + aux);
                            Console.WriteLine("¿Desea realizar otra operaciòn? /n");
                            Console.WriteLine("1- SI /n");
                            Console.WriteLine("2- NO /n");

                            opcion = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 4:

                            aux = num1 / num2;
                            Console.WriteLine("El resultado de la operacion es : " + aux);
                            Console.WriteLine("¿Desea realizar otra operaciòn? /n");
                            Console.WriteLine("1- SI /n");
                            Console.WriteLine("2- NO /n");

                            opcion = Convert.ToInt32(Console.ReadLine());
                            break;

                    }
                }
                }

        }

        }
    }


    

