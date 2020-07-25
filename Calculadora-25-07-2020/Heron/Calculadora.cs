using System;

namespace _25_07_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1º valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a operação: ");
            string operação = Console.ReadLine();

            Console.Write("Digite o 2º valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());


            double resultado = 0;

            switch (operação)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    break;
                default:
                    Console.WriteLine("Operação Inválida");
                    break;
            }

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
