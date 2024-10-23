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
        }
        public static List<string> NomeJogador(string mensagem)
        {
            Console.WriteLine(mensagem);
            List<string> nome = new List<string>();
            nome.Add(Console.ReadLine());
            return nome;
        }

        public static void imprimeJogador(List<string>Nomes)
        {
            foreach(string nome in Nomes)
            {
                Console.WriteLine($"Nome do Jogador: {nome}\n");
            }
        } 
    }
}