using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
             //simples calculadora

            double num1, num2;//variáveis que irão conter os números digitados
            string tmp;

            Console.WriteLine("Digite um número: ");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);

            Console.WriteLine("Digite mais um número: ");
            Console.ReadLine();
            num2 = int.Parse(tmp);

            double resultado;
            Console.WriteLine("O que você gostaria de fazer? + - * /");
            string acao = Console.ReadLine();

            switch(acao){
                case "+":
                //realiza a soma e imprime no console
                resultado = num1 + num2;
                Console.WriteLine("Soma: " + resultado);
                break;
                case "-":
                //realiza a subtração e imprime no console
                resultado = num1 - num2;
                Console.WriteLine("Subtração: " + resultado);
                break;
                case "*":
                //realiza a multiplicação e imprime no console
                resultado = num1 * num2;
                Console.WriteLine("Multiplicação: " + resultado);
                break;
                case "/":
                //realiza a divisão e imprime no console
                resultado = num1 / num2;
                Console.WriteLine("Divisão: " + resultado);
                break;
                default:
                    Console.WriteLine("Desculpe não entendi :(. Por favor, tente de novo ^^");
                    break;

            }
        }
    }
}
