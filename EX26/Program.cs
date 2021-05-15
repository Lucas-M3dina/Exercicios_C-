using System;

namespace EX26
{
    class Program
    {
        static int menu;
        static float[] preco = new float[10];
        static string[] nomes = new string[10];
        static bool[] promocao = new bool[10];
        static int test = -1;
        static string cond = "";
        static string test2 = "";

        static void Main(string[] args)
        {

      
            // Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:
            // Os produtos terão os seguintes atributos:

            // string Nome
            // float Preco
            // bool Promocao (se está em promoção ou não)

            // O sistema deverá ter as seguintes funçoes:

            // // CadastrarProduto
            // // ListarProdutos
            // // MostrarMenu

            // // float[] preco = new float[10];
            // // string[] nomes = new string[10];
            // // bool[] promocao = new bool[10];
            // int test = 0;
            // string cond = "";

            Console.WriteLine("\n Projeto para gerenciamento de 10 produtos \n");

            Senha();

            do
            {  
                MostrarMenu();
                
                switch (menu)
                {
                    case 1:
                        CadastrarProduto();
                        break;

                    case 2:
                        ListarProdutos();
                        break;

                    default:
                        break;
                }
                
            } while (menu != 3);
            
        }

        static void Senha(){

            string senha = "";
            do
            {
                Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();

                if (senha != "123456")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Senha Incorreta!!! Tente novamente\n");
                    Console.ResetColor();
                }
            } while (senha != "123456");

        }

        static int MostrarMenu(){

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(@$"
------------------------------
|           Menu             |
|----------------------------|
|                            |
|  [1] Cadastrar Produto     |
|  [2] Mostrar produto       |
|  [3] Sair                  |
|                            |
------------------------------
R: ");
            Console.ResetColor();
            menu = int.Parse(Console.ReadLine());
            return menu;
        }

        static void CadastrarProduto(){

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nAviso: Esse programa suporta o cadastro de apenas 10 produtos\n");
            Console.ResetColor();

            do
            {
                test++;
                Console.Write($"{test + 1} - Digite o nome do produto: ");
                nomes[test] = Console.ReadLine();

                Console.Write($"{test + 1} - Digite o preço do produto: ");
                preco[test] = float.Parse(Console.ReadLine());

                Console.Write($"{test + 1} - O produto esta em promoção?? S/N: ");
                string TempPromocao = Console.ReadLine().ToLower();
                if (TempPromocao == "sim" || TempPromocao == "s")
                {
                    promocao[test] = true;
                }
                else if (TempPromocao == "nao" || TempPromocao == "n"|| TempPromocao == "não")
                {
                    promocao[test] = false;
                }

                Console.WriteLine("Produto cadastrado!!!!! \n");

                Console.Write("Você deseja cadastrar outro produto?? S/N: ");
                cond = Console.ReadLine().ToLower();
                
            } while (cond == "s");

        }

        static void ListarProdutos(){
            for (var i = 0; i <= test; i++)
            {
                // test2 = (promocao[i] == true) ? "Esta em promoção":"Não esta em promoção";

                Console.WriteLine(@$"
Produto: {nomes[i]}
Preço: {preco[i]}
Promoção: {(promocao[i] == true ? "Esta em promoção":"Não esta em promoção")}
                           
            ");
            }

        }
    }
}
