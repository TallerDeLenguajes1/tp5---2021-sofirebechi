using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero a invertir mayor que 0:");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero > 0)
            {
                int inverso = 0, resto;
                while(numero > 0)
                {
                    resto = numero % 10;
                    numero = numero / 10;
                    inverso = inverso * 10 + resto;
                }
                Console.WriteLine("El inverso del numero ingresado es: " + inverso);
            }
            else
            {
                Console.WriteLine("No es posible invertir el numero ingresado.");
            }
        }
    }
}
