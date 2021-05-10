using System;

namespace EX23
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] nomes = new string[10];
            int test = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o nome {test}: ");
                nomes[i] = Console.ReadLine().ToLower();
                test++;
            }

            Console.Write("Digite o nome que deseja buscar: ");
            string busca = Console.ReadLine();

            string conclusao = "Nome NÃO encontrado!!!";

            for (int i = 0; i < nomes.Length; i++)
            {
                if (busca == nomes[i])
                {
                    conclusao = "Nome encontrado!!!";
                } 
            }

            Console.WriteLine(conclusao);

        }
    }
}
