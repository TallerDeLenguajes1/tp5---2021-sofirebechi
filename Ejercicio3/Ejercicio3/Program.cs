using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, num1, vabs, cuad, raiz, sen, cos, ent, max, min;

            Console.WriteLine("* * * CALCULADORA AVANZADA * * * \n");
            Console.WriteLine("Ingrese un numero: \n");
            num = Convert.ToDouble(Console.ReadLine());

            vabs = Math.Abs(num);
            Console.WriteLine("El valor absoluto del numero ingresado es: \n" + vabs);
            cuad = (int)Math.Pow(num, 2);
            Console.WriteLine("El cuadrado del numero ingresado es: \n" + cuad);
            raiz = (int)Math.Sqrt(num);
            Console.WriteLine("La raiz cuadrada del numero ingresado es: \n" + raiz);
            sen = (int)Math.Sin(num);
            Console.WriteLine("El seno del numero ingresado es: \n" + sen);
            cos = (int)Math.Cos(num);
            Console.WriteLine("El coseno del numero ingresado es: \n" + cos);
            ent = (int)Math.Truncate(num);
            Console.WriteLine("La parte entera del numero ingresado es: \n" + ent);

            Console.WriteLine("Ingrese un numero: \n");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo numero para comparar: \n");
            num1 = Convert.ToDouble(Console.ReadLine());

            max = Math.Max(num, num1);
            Console.WriteLine("El mayor de los numeros ingresados es :  \n" + max);

            min = Math.Min(num, num1);
            Console.WriteLine("El menor de los numeros ingresados es :  \n" + min);





        }
    }
}
