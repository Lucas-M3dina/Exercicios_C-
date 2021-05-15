using System;

namespace EX25
{
    class Program
    {
        static void Main(string[] args)
        {


//Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair


// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).



            Console.WriteLine("\nBem vindo ao nosso sistema de registro de passagens aéreas!!!\n");
            string senha = "";
            string[] nomes = new string[6];
            string[] origem = new string[6];
            string[] destino = new string[6];
            string[] data = new string[6];
            string voltar = "";
            int menu;
            int quantidade = 1;
            int confir;
            int b = 0;
            string cond = "";

            do
            {
                Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();
                if (senha != "123456")
                {
                    Console.WriteLine("\nSenha errada!!!!!\n");
                }
            } while(senha != "123456");

            do
            {
                Console.Write(@$"
                MENU:

                1- Cadastrar passagem
                2- Listar Passagens
                0- Sair            
                
                R: ");

                menu = int.Parse(Console.ReadLine());

            
                switch (menu)
                {
                    case 0:
                        break;

                    case 1:
                        
                        do
                        {
                                                        
                            Console.Write($"{b + 1} - Digite o nome do passageiro: ");
                            nomes[b] = Console.ReadLine();

                            Console.Write($"{b + 1} - Digite a origem do passageiro: ");
                             origem[b] = Console.ReadLine();

                            Console.Write($"{b + 1} - Digite o destino do passageiro: ");
                            destino[b] = Console.ReadLine();

                            do
                            {
                                Console.Write($"{b + 1} - Digite a data do voo do passageiro: ");
                                data[b] = Console.ReadLine();
                                int verificando1 = data[b].Length;
                                int total = data[b].Split(new char[] { '/' }).Length - 1;

                                 if (verificando1 == 8 )
                                {
                                    int datanum = int.Parse(data[b]);
                                    data[b] = String.Format(@"{0:00\/00\/0000}", datanum);
                                    confir = 1;
                                }
                                else if(verificando1 == 10 && total == 2)
                                {
                                    confir = 1;
                                }
                                else{
                                    Console.WriteLine("Formato de data não compativel com o sistema, tente seguir estes exemplos: ex= 26/01/1995 ex2=26011995 ");
                                    confir = 0;
                                }
                                    
                            } while (confir == 0);

                            Console.Write($"Passageiro {nomes[b]} cadastrado\n");

                            Console.WriteLine("Deseja cadastrar mais passagens? y/n");
                            cond = Console.ReadLine();
                            b++;
                            quantidade++;
                            

                        } while (cond == "y");
                        
                        break;
                        
                    case 2:
                        if (quantidade == 0)
                        {
                            Console.WriteLine("\n Você não possui passagens registradas \n");
                        }
                        for (var i = 0; i < b; i++)
                        {
                            Console.WriteLine($@"
                             ===================================================================
                            |  Passageiro {i + 1}:                                              
                            |                                                                   
                            |   Nome do passageiro: {nomes[i]}                                  
                            |   Origem: {origem[i]}                                             
                            |   Destino: {destino[i]}                                           
                            |   Data do voo:  {data[i]}                                         
                            |                                                                   
                             ===================================================================
                            ");

                        }
                        break;

                    default:
                        break;
                }

                if (menu != 0){
                    Console.Write("Você deseja voltar ao menu??? y/n \nR:");
                    voltar = Console.ReadLine().ToLower();
                }
                else
                {
                    voltar = "n";
                }
                

            } while (voltar == "y");
            
            
        }
    }
}
