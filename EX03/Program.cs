using System;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano que você nasceu: ");
            int anoNasc = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            int idade = anoAtual - anoNasc;
            int semana = idade * 52;
            
            Console.WriteLine("Você tem " + idade + " anos");
            Console.WriteLine("Você tem " + semana + " semanas de vida");
        }
    }
}
