using System;
using System.Collections.Generic;

namespace SomaMedia{
    class SomaMedia{
        static void Main()
        {
            int tamanhoVetor = TamanhoVetor("Quantos números deseja informar? ");
            Console.WriteLine($"Valor retornado: {tamanhoVetor}\n");
            List<double> Numeros = AddNumeros(tamanhoVetor);
            Numeros.ForEach(numero => Console.WriteLine(numero));
        }

        public static int TamanhoVetor(string mensagem)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                string valorDigitado = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(valorDigitado, out int numero))
                {
                    if (numero>2 && numero<11)
                    {
                        return numero; //Caso Valor Válido
                    }
                    else
                    {
                        Console.WriteLine("Declare um número entre 3 e 10!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Declare um número inteiro!\n");
                }
            }
        }

        public static double ConferirNumero(string mensagem)
        {
            Console.WriteLine(mensagem);
            string valorDigitado = Console.ReadLine();
            Console.WriteLine();
            while(true){
                if (double.TryParse(valorDigitado, out double numero))
                {
                    return numero; //Caso Valor Válido
                }
                else
                {
                    Console.WriteLine("Valor Inválido!\n");
                }
            }
            
        }

        public static List<double> AddNumeros(int quant)
        {
            
            List<double> Numeros = new List<double>();

            for (int i=0;i<quant;i++){
                double numero = ConferirNumero($"Adicione o número {i}º: ");
                Numeros.Add(numero);
            }
            return Numeros;
        }
    }
}
