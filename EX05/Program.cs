using System;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if ( idade >= 5 && idade <= 7){
                Console.WriteLine("Você esta na categoria Infantil A");
            }

            else if ( idade >= 8 && idade <= 10){
                Console.WriteLine("Você esta na categoria Infantil B");
            }

            else if ( idade >= 11 && idade <= 13){
                Console.WriteLine("Você esta na categoria Juvenil A");
            }

            else if ( idade >= 14 && idade <= 17){
                Console.WriteLine("Você esta na categoria Juvenil B");
            }

            else if ( idade >= 18 ){
                Console.WriteLine("Você esta na categoria Sênior");
            }

            else{
                Console.WriteLine("Essa idade não é permitida");
            }

        }
    }
}
