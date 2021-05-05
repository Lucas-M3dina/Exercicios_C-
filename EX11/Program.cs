using System;

namespace EX11
{
    class Program
    {
        static void Main(string[] args)
        {
            string condicao = "";
            do
            {
                Console.Write("Digite um numero entre 0 e 10: ");
                int num = int.Parse(Console.ReadLine());

                if (num < 0 || num > 10){
                    Console.WriteLine("Numero invalido !!!");
                    Console.WriteLine("Deseja tentar novamente? y/n");
                    condicao = Console.ReadLine();
                }
                else{
                    Console.WriteLine("O numero digitado foi " + num);
                    condicao = "";
                }
                

                
            } while (condicao == "y");
            
        }
    }
}
