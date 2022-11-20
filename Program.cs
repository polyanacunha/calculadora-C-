using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string operador;
            int resultado;

            Console.WriteLine("Insira o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o operador desejado ( + , - , * , / ): ");
            operador = Console.ReadLine();

            if (operador == "+")
            {
                resultado = num1 + num2;
                Console.WriteLine(" Resultado: " + resultado);
                Console.ReadLine();
            }
            else if (operador == "-")
            {
                resultado = num1 - num2;
                Console.WriteLine(" Resultado: " + resultado);
                Console.ReadLine();
            }
            else if (operador == "*")
            {
                resultado = num1 * num2;
                Console.WriteLine(" Resultado: " + resultado);
                Console.ReadLine();
            }
            else if (operador == "/")
            {
                resultado = num1 / num2;
                Console.WriteLine(" Resultado: " + resultado);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Insira um valor válido!");
            }
        }
    }
}