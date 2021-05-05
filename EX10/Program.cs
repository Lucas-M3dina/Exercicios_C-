using System;

namespace EX10
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            string condicao = "";
            do
            {
                Console.WriteLine("Qual a idade do Neymar? ");
                idade = int.Parse(Console.ReadLine());
                if (idade != 29){
                    Console.WriteLine("Você errou!!!! ");
                    Console.WriteLine("Você quer tentar novamente? y/n");
                    condicao = Console.ReadLine().ToString(); 
                }else
                {
                    Console.WriteLine("Você Acertouu!!!! ");
                }
                
            } while (condicao == "y");
        }
    }
}
