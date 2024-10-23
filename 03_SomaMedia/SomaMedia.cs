using System;
namespace SomaMedia{
    class SomaMedia{
        static void Main()
        {
            int valor = TamanhoVetor();
            Console.WriteLine($"Valor retornado: {valor}");
        }

        public static int TamanhoVetor()
        {
            while(true)
            {
                int quant = ConferirNumero("Quantos números deseja informar? ");
                return quant;
            }
        }
        public static int ConferirNumero(string mensagem)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                string valorDigitado = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(valorDigitado, out int numero))
                {
                    if (numero>0 && numero<11)
                    {
                        return numero; //Caso Valor Válido
                    }
                    else
                    {
                        Console.WriteLine("Valor Inválido!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Valor Inválido!\n");
                }
            }
        }
    }
}
