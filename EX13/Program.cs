using System;

namespace EX13
{
    class Program
    {
        static void Main(string[] args)
        {

        string validar1 = "";
        string validar2 = "";
        string validar3 = "";
        string validar4 = "";
        do
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite seu salario: R$");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Digite seu estado civil ( 's' solteiro(a), 'c' casado(a), 'v' viuvo(a), 'd' divorciado(a) ): ");
            string civil = Console.ReadLine().ToLower();


            if (nome != ""){
                validar1 = "valido";
            }
            else{
                Console.WriteLine("Nome invalido");
                validar1 = "invalido";
            }

            if (idade <= 100){
                validar2 = "valido";
            }
            else{
                Console.WriteLine("Idade Invalida");
                validar2 = "invalido";
            }

            if (salario > 0){
                validar3 = "valido";
            }
            else{
                Console.WriteLine("Salario Invalido");
                validar3 = "invalido";
            }

            if(civil == "s" || civil == "c" || civil == "v" || civil == "d"){
                validar4 = "valido";
            }
            else{
                Console.WriteLine("Estado Civil Invalido");
                validar4 = "invalido";
            }

            if (validar1 == "invalido" || validar2 == "invalido" || validar3 == "invalido" || validar4 == "invalido"){
                Console.WriteLine("Existem itens invalidos, por favor digite os dados novamente!!! ");
            }
            else{
                Console.WriteLine("Seus dados foram validos obrigado :) ");
            }

        } while (validar1 == "invalido" || validar2 == "invalido" || validar3 == "invalido" || validar4 == "invalido");
        }
    }
}
