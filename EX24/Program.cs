using System;

namespace EX24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nome = new int[15];
            int test = 1;
            for (int i = 0; i < 15; i++)
            {
                Console.Write($"{test} - Digite um numero: ");
                nome[i] = int.Parse(Console.ReadLine());
                test++;
            }

            Console.WriteLine("Mostrando a ordem inversa:");
            for (var i = 14; i >= 0; i--)
            {
                Console.WriteLine(nome[i]);
            }
        }
    }
}
