// See https://aka.ms/new-console-template for more information
using System;
namespace Calculadora{
    class Calculadora{
        static void Main(){
            Programa();
        }
        public static int ConferirNumero(string mensagem)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                string valorDigitado = Console.ReadLine();

                if (int.TryParse(valorDigitado, out int numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Digite um número inteiro!");
                }
            }
        }
        static void Programa(){
            Console.WriteLine("Digite o número correspondente com a operação que deseja realizar");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            Console.WriteLine("0-Sair \n ");

           
            string[] numerosValidos = { "1" , "2" , "3" , "4"};
            double resultado = 0;

            while (true)
            {
                Console.WriteLine("Digite o número:");
                string entradaOperacao = Console.ReadLine();
                
                if (numerosValidos.Contains(entradaOperacao))
                {
                    double valor1 = ConferirNumero("Digite o 1º Valor: ");
                    double valor2 = ConferirNumero("Digite o 2º Valor: ");
                    
                    if (entradaOperacao=="1")//Soma
                    {
                        Console.WriteLine("Operação: Somar");
                        resultado = valor1+valor2;
                    }
                    else if (entradaOperacao=="2")//Subtração
                    {
                        Console.WriteLine("Operação: Subtrair");
                        resultado = valor1-valor2;
                    }
                    else if (entradaOperacao=="3")//Multiplicação
                    {
                        Console.WriteLine("Operação: Multiplicar\n");
                        resultado = valor1 * valor2;
                    }
                    else if (entradaOperacao=="4")//Divisão
                    {
                        Console.WriteLine("Operação: Dividir\n");

                        if (valor2==0){
                            Console.WriteLine("Não é possível dividir por zero!");
                            resultado = 0;
                        }else{
                            resultado = valor1/valor2;
                        }
                    }
                    Console.WriteLine("Resultado: "+resultado.ToString("F2"));
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
