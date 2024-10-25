using System;
using System.Collections.Generic;

namespace JogarDados{
    class JogarDados{
        static void Main()
        {
            List<string> Jogador1 = NomeJogador("Digite o nome do primeiro Jogador: ");
            imprimeJogador(Jogador1);
            List<string> Jogador2 = NomeJogador("Digite o nome do segundo Jogador: ");
            imprimeJogador(Jogador2);
            
            /*
            Jogador1.Add(Dados(Jogador1[0]));
            Jogador2.Add(Dados(Jogador2[0]));

            Console.WriteLine();

            Jogador1.Add(Dados(Jogador1[0]));
            Jogador2.Add(Dados(Jogador2[0]));

            Console.WriteLine();

            Jogador1.Add(Dados(Jogador1[0]));
            Jogador2.Add(Dados(Jogador2[0]));

            Console.WriteLine();
            */

            for(int i=0;i<3;i++)
            {
                Jogador1.Add(Dados(Jogador1[0]));
                Jogador2.Add(Dados(Jogador2[0]));
                Console.WriteLine();
            }

            Console.WriteLine();

            List<int>Disputas = Disputa(Jogador1,Jogador2);
            if(Disputas[0]>Disputas[1])
            {
                Console.WriteLine($"Jogador {Jogador1[0]} ganhou a Disputa!!!");
            }
            else if(Disputas[1]>Disputas[0])
            {
                Console.WriteLine($"Jogador {Jogador2[0]} ganhou a Disputa!!!");
            }
            else
            {
                Console.WriteLine("Empate ):");
            }
        }


        public static List<string> NomeJogador(string mensagem)
        {
            Console.WriteLine(mensagem);
            List<string> nome = new List<string>();
            nome.Add(Console.ReadLine());
            return nome;
        }

        
        public static string Dados(string Jogador)
        {
            Random random = new Random();
            int dado = random.Next(1,7);
            string dadoString = dado.ToString();
            Console.WriteLine($"Jogador {Jogador} tirou: {dado}");
            return dadoString;
        }



        public static List<int>Disputa(List<string>Jogador1, List<string>Jogador2)
        {
            List<int>disputa = new List<int>{0,0};
            int dado1, dado2;
            for(int i=1;i<4;i++)
            {
                dado1 = int.Parse(Jogador1[i]);
                dado2 = int.Parse(Jogador2[i]);

                if(dado1 > dado2)
                {
                    Console.WriteLine($"O jogador {Jogador1[0]} ganhou a {i}º rodada!");
                    disputa[0]+=1;
                }
                else if(dado2>dado1)
                {
                    Console.WriteLine($"O jogador {Jogador2[0]} ganhou a {i}º rodada!");
                    disputa[1]+=1;
                }
                else
                {
                    Console.WriteLine("Empate!");
                }
            }
            return disputa;
        }
        

        //MÉTODOS SECUNDÁRIOS
        public static void imprimeJogador(List<string>Nomes)
        {
            /*
            foreach(string nome in Nomes)
            {
                Console.WriteLine($"Nome do Jogador: {nome}\n");
            }
            */

            /*
            for (int i=0; i<1;i++)
            {
                Console.WriteLine($"{Nomes[i]}");
            }
            */

            int i=0;
            Console.WriteLine($"Nome do jogador: {Nomes[i]}\n");
        }
    }
}