using System;
using Exercicio_Dia_26.Classes;

namespace Exercicio_Dia_26
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int opcao1;
            int opcao2;
            bool validando;
            do{
                Console.Write($@"
    Qual Elevador você deseja pegar???

    [1] Elevador Social
    [2] Elevador de Serviço

    R: ");      
                opcao1 = int.Parse(Console.ReadLine());

                switch (opcao1)
                {
                    case 1:
                        ElevadorSocial social = new ElevadorSocial();
                        validando = true;
                        do
                        {
                            opcao2 = mnu();

                            switch (opcao2)
                            {
                                case 1:
                                    social.entrar();
                                    break;

                                case 2:
                                    social.sair();
                                    break;

                                case 3:
                                    social.subir();
                                    break;

                                case 4:
                                    social.descer();
                                    break;
                                    
                                case 5:
                                    break;

                                default:
                                    Console.WriteLine("Opção invalida!!!");
                                    break;
                            }
                            
                            
                        } while (opcao2 != 5);
                        break;

                    case 2:
                        ElevadorServico servico = new ElevadorServico();
                        validando = true;
                        do
                        {
                            opcao2 = mnu();

                            switch (opcao2)
                            {
                                case 1:
                                    servico.entrar();
                                    break;

                                case 2:
                                    servico.sair();
                                    break;

                                case 3:
                                    servico.subir();
                                    break;

                                case 4:
                                    servico.descer();
                                    break;
                                    
                                case 5:
                                    break;

                                default:
                                    Console.WriteLine("Opção invalida!!!");
                                    break;
                            }
                            
                            
                        } while (opcao2 != 5);
                        break;

                    default:
                        Console.WriteLine("Opção invalida!!!");
                        validando = false;
                        break;
                }
            }while (validando == false);
            
            
        }

        private static int mnu(){
        Console.Write($@"
        Escolha oq deseja fazer:

[1] Entrar 1 pessoa
[2] Sair 1 pessoa
[3] Subir ao proximo andar
[4] Descer ao andar anterior
[5] Sair do Elevador
        
R: ");
        int opcao2 = int.Parse(Console.ReadLine());
        return opcao2;
        }
    }
}
