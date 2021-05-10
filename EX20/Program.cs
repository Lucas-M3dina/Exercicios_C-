using System;

namespace EX20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitario do produto: ");
            double preco = double.Parse(Console.ReadLine());

            double total = quantidade * preco;

            if (quantidade <= 5)
            {
               double desconto = total / 100 * 2;
               double pagar = total - desconto;
               Console.WriteLine(@$"
               Nome: {nome}
               Quantidade: {quantidade}
               Preço Unitario: R${preco}
               Desconto: R${desconto.ToString("F")}
               Total a pagar: R${pagar.ToString("F")}
               ");
            }
            else if (quantidade > 5 && quantidade <= 10)
            {
                double desconto = total / 100 * 3;
                double pagar = total - desconto;
                Console.WriteLine(@$"
                Nome: {nome}
                Quantidade: {quantidade}
                Preço Unitario: R${preco}
                Desconto: R${desconto.ToString("F")}
                Total a pagar: R${pagar.ToString("F")}
                ");
            }
            else if (quantidade > 10)
            {
                double desconto = total / 100 * 5;
                double pagar = total - desconto;
                Console.WriteLine(@$"
                Nome: {nome}
                Quantidade: {quantidade}
                Preço Unitario: R${preco}
                Desconto: R${desconto.ToString("F")}
                Total a pagar: R${pagar.ToString("F")}
                ");
            }

        }
    }
}
