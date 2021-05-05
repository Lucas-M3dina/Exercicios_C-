using System;

namespace EX12
{
    class Program
    {
        static void Main(string[] args)
        {
//             Faça um programa que leia um nome de usuário e a sua senha e não
// aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro
// e voltando a pedir as informações.

        string usuario = "";
        string senha = "";
        do
        {
            Console.WriteLine("Digite seu nome de usuario: ");
            usuario = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();

            if (senha == usuario){
                Console.WriteLine("Senha Invalida, sua senha não pode ser igual ao seu usuario");
            }

        } while (senha == usuario);
        }
    }
}
