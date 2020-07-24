using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite o 1 valor");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            
         

            Console.WriteLine("Digite a operação +-/*");
            string operação = Console.ReadLine();

        Console.WriteLine("Digite o 2 valor");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            
            double resultado=0;
            if (operação == "+")
                resultado = valor1+valor2;

            if (operação == "-")
                resultado = valor1-valor2;

             if (operação == "*")
                resultado = valor1*valor2;


             if (operação == "/")
                resultado = valor1/valor2; 

                Console.WriteLine(resultado);

                
        
             
        
                
            
        
            




    
        }
    }
}
