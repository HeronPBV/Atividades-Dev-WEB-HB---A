using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
             //simples calculadora

            float A, P, imc;

              Console.Write("Digite o seu peso: ex 90");
            P = float.Parse(Console.ReadLine());


            Console.Write("Digite o seu altura, EX 1,70:");
            A =  float.Parse(Console.ReadLine());

            imc = (P / (A * A));

            if (imc < 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                Console.WriteLine("Peso normal");
            }
            else  if ((imc >= 25) && (imc < 30))
            {
                Console.WriteLine("Sobre o Peso");
            }
            else if ((imc > 30))
            {
                Console.WriteLine("Cara Voce esta obeso");
            }
            //sou foda

            }
        }
    }
