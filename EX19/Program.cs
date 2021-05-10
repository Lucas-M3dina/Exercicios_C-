using System;

namespace EX19
{
    class Program
    {
        static void Main(string[] args)
        {                     
            Console.Write("\nDigite o tipo de combustivel que vc deseja:\n\n A - Alcool \t G - Gasolina \n\n R: " );
            String tipo = Console.ReadLine().ToLower();

            Console.Write("Digite a quantidade de litros que vc deseja: ");
            int litros = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case "a":
                    if (litros <= 20)
                    {
                        double desconto = 5.30 - (4.90 / 100 * 3);
                        double preco = desconto * litros;
                        Console.WriteLine("Vc tera que pagar R$" + preco.ToString("F"));
                    }
                    else
                    {
                        double desconto = 5.30 - (4.90 / 100 * 5);
                        double preco = desconto * litros;
                        Console.WriteLine("Vc tera que pagar R$" + preco.ToString("F"));
                    }
                    break;

                case "g":
                    if (litros <= 20)
                    {
                        double desconto = 5.30 - (5.30 / 100 * 4);
                        double preco = desconto * litros;
                        Console.WriteLine("Vc tera que pagar R$" + preco.ToString("F"));
                    }
                    else
                    {
                        double desconto = 5.30 - (5.30 / 100 * 6);
                        double preco = desconto * litros;
                        Console.WriteLine("Vc tera que pagar R$" + preco.ToString("F"));
                    }
                    break;

                default:

                    break;
            }
            
        }
    }
}
