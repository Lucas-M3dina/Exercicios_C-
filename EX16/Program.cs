using System;

namespace EX16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que receba a quantidade de produtos que o usuário deseja cadastrar, os nomes dos produtos, a quantidade de cada produto, o valor de cada um e mostre na tela em formato de tabela
            Console.WriteLine("Quantos produtos você deseja cadastrar?");
            int quantidade = int.Parse(Console.ReadLine());
            int resul = quantidade - 1; 

            int[] produtos = new int[quantidade];

            float[] preco = new float[quantidade];

            string[] nomes = new string[quantidade];
            int mostrando = 1;


            for (var i = 0; i <= resul; i++)
            {
                Console.Write($"Digite o nome do produto {mostrando}: " );
                nomes[i] = Console.ReadLine();

                Console.Write($"Digite a quantidades do produto {mostrando}: ");
                produtos[i] = int.Parse(Console.ReadLine());

                Console.Write($"Digite o preço do produto {mostrando}: ");
                preco[i] = float.Parse(Console.ReadLine());

                mostrando++;
            }


            
            for (var i = 0; i <= resul; i++)
            {
                Console.WriteLine("\n======================================================================================\n");
                Console.WriteLine($"Nome do produto: {nomes[i]}");
                Console.WriteLine($"Quantidade de produtos: {produtos[i]}");
                Console.WriteLine($"Preço do produto: R${preco[i]}");
                Console.WriteLine("\n======================================================================================\n");

            }
        }
    }
}
