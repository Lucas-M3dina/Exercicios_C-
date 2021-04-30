using System;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu salario atual: ");
            float salario = float.Parse(Console.ReadLine());

            if (salario < 500){
                float reajuste = salario + (salario / 100 * 30);
                Console.WriteLine("Seu salario com o reajuste é R$" + reajuste);
            }
            else{
                Console.WriteLine("Você não tem direito a um aumento");
            }
        }
    }
}
