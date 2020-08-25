using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
          double peso = 0;
          double altura = 0;
          double imc = 0;

           Console.WriteLine("Calcule o Imc");
           Console.Write("DIgite seu altura");
           altura = Convert.ToDouble(Console.ReadLine());

           Console.Write("Digite seu peso");
           peso = Convert.ToDouble(Console.ReadLine());
          
           imc = peso / (altura * altura);
           
           if (imc < 18.8){
           Console.WriteLine("voce esta com magreza leve!");
        
           }  
           else if (imc > 18.5 && imc < 24.8 ){ 
           Console.WriteLine("voce esta saudavel!");
           
           { 
           else if (imc > 25 &&  imc < 29.9){
           Console.WriteLine("voce esta com sobrepeso!");
           
           }
           else if (imc > 30 && imc < 34.9){  
           Console.WriteLine("voce esta com inicio de obesidade!" );
           
           }

           else if (imc > 35 && imc < 39.9){
           Console.WriteLine("voce esta com obesidade morbida!");

           }

             else if (imc >= 40){  
             ConsoLe.WriteLine("meu amigo vc esta muito gordo");                 
             
        

          
           

            

            
            
















          











          

        
    

