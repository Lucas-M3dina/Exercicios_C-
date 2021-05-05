using System;

namespace EX07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um algarismo romano de I a V:");
            string nome = Console.ReadLine().ToLower();

            switch (nome){
                case "i":
                    Console.WriteLine("1 ");
                    break;
                case "ii":
                    Console.WriteLine("2");
                    break;

                case "iii":
                    Console.WriteLine("3");
                    break;

                case "iv":
                    Console.WriteLine("4");
                    break;

                case "v":
                    Console.WriteLine("5");
                    break;

                default:
                    Console.WriteLine("Só vai até o V ;-;");
                    break;
            }
        }
    }
}
