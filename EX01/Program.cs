using System;

namespace exemplo_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o nome do aluno??");
            string nomePessoa = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            float primeiraNota = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            float segundaNota = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            float terceiraNota = float.Parse(Console.ReadLine());

            float media = (primeiraNota + segundaNota + terceiraNota) / 3;

            string test = media >= 7 ? "Aprovado" : "Reprovado";
            

            Console.WriteLine("O aluno " + nomePessoa + " teve a media " + media.ToString("N1") + " e foi " + test);
        
        
        }
    }
}
