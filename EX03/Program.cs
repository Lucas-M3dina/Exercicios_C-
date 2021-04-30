using System;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano que você nasceu: ");
            int anoNasc = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNasc;
            int semana = idade * 52;
            
            Console.WriteLine("Você tem " + idade + " anos");
            Console.WriteLine("Você tem " + semana + " semanas de vida");
        }
    }
}
