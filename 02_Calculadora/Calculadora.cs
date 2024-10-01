// See https://aka.ms/new-console-template for more information
using System;
namespace Calculadora{
    class Calculadora{
        static void Main(){
            Programa();
        }
        static void Programa(){
            Console.WriteLine("Digite o número correspondente com a operação que deseja realizar");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            Console.WriteLine("0-Sair \n ");

            Console.WriteLine("Digite o número:");
           

            while (true)
            {
                string entradaOperacao = Console.ReadLine();

                if (entradaOperacao=="1")//Soma
                {
                    Console.WriteLine("Operação: Somar\n");
                }
                else if (entradaOperacao=="2")//Subtração
                {
                    Console.WriteLine("Operação: Subtrair\n");
                }
                else if (entradaOperacao=="3")//Multiplicação
                {
                    Console.WriteLine("Operação: Multiplicar\n");
                }
                else if (entradaOperacao=="4")//Divisão
                {
                    Console.WriteLine("Operação: Dividir\n");
                }
                else if (entradaOperacao=="0")//Sair
                {
                    Console.WriteLine("Operação: Sair");
                    break;
                }
                else
                {
                    Console.WriteLine("Valor digitado inválido, coloque novamente: ");
                }
            }
        }
    }
}
