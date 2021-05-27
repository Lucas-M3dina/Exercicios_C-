using System;
using Cafe_Exercicio.Classes;

namespace Cafe_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            int gramas;
            string cond;
            MaquinaCafe cafezin = new MaquinaCafe();
            do
            {
                
                Console.Write($@"
    O que deseja?

    [1] Adicionar açucar na maquina
    [2] Fazer café            
    R: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        cafezin.adicionarAcucar();
                        break;

                    case 2:
                        Console.WriteLine("Você deseja especificar a quantidade de açucar? Y/N");
                        cond = Console.ReadLine().ToLower();
                        if (cond == "y")
                        {
                            Console.Write("Digite quantas gramas de açucar vc deseja adicionar: ");
                            gramas = int.Parse(Console.ReadLine());
                            cafezin.fazerCafe(gramas);
                        }
                        else if (cond == "n")
                        {
                            cafezin.fazerCafe();
                        }
                        
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Vc deseja pedir outro café?? Y/N");
                cond = Console.ReadLine().ToLower();
            } while (cond == "y");
            
        }
    }
}
