using System;

namespace EX21
{
    class Program
    {
        static void Main(string[] args)
        {
                //             Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
          // menor valor lido.
            
            int[] valor = new int[11];
            int test = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o numero {test}: ");
                valor[i] = int.Parse(Console.ReadLine());
                test++;
            }

            Array.Sort(valor);

            Console.WriteLine($"O menor valor é {valor[1]}");
            Console.WriteLine($"O maior valor é {valor[10]}");
        }

    }
}
