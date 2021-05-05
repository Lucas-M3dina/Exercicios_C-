using System;

namespace EX06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine().ToLower().Substring(0, 1);

            switch (nome){
                case "a":
                    Console.WriteLine("Seu nome começa com a ");
                    break;
                case "e":
                    Console.WriteLine("Seu nome começa com e ");
                    break;

                case "i":
                    Console.WriteLine("Seu nome começa com i ");
                    break;

                case "o":
                    Console.WriteLine("Seu nome começa com o ");
                    break;

                case "u":
                    Console.WriteLine("Seu nome começa com u ");
                    break;

                default:
                    Console.WriteLine("Seu nome não começa com vogais");
                    break;
            }
        }
    }
}
