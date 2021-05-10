using System;

namespace EX18
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Qual eh o ano atual?");
            int anoatual = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual ano vc nasceu? ");
            int anoNasc = int.Parse(Console.ReadLine());

            int idade = anoatual - anoNasc;

            if (idade < 16)
            {
                Console.WriteLine("Vc ainda não pode votar");
            }
            else
            {
                Console.WriteLine("Vc ja pode votar!!!");
            }
        }
    }
}
