using System;

namespace EX15
{
    class Program
    {
        static void Main(string[] args)
        {

            // Faça um programa que receba a quantidade de embalagens de pão de queijo em uma prateleira, a quantidade de pães de queijo em cada embalagem e mostre a lista para o usuário.
            Console.WriteLine("Quantas embalagens de pão de queijo estão na pratileira?");
            int pratileira = int.Parse(Console.ReadLine());

            int[] embalagem = new int[pratileira];
            int laco = pratileira - 1;


            for (var i = 0; i <= laco; i++)
            {
                Console.WriteLine("Quantos pães de queijo tem na embalagem " + (i + 1));
                embalagem[i] = int.Parse(Console.ReadLine()) ;
            }
                
            int ne = 1;
            
            foreach (var itens in embalagem)
            {
                Console.WriteLine($"A embalagem {ne} tem {itens} pães de queijo");
                ne++;
            }
        }
    }
}
