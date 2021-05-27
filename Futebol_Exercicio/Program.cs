using System;
using Futebol_Exercicio.Classes;

namespace Futebol_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
           
// .Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. 
// Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar.
//  Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos,
//   os jogadores de meio-campo aos 38 e os atacantes aos 35.
            int opcao;

            Console.Write($@"
Selecione a posição onde o jogador atua:

[1] Atacante
[2] Zaqueiro
[3] Meio-Campo

R:");
           opcao = int.Parse(Console.ReadLine());

           switch (opcao)
           {
                case 1:
                    Atacante ataque = new Atacante();
                    ataque.questionario();
                    ataque.calcularIdade();
                    ataque.calcularAposentadoria();
                    ataque.mostrarDados();
                    break;

                case 2:
                    Defensor defesa = new Defensor();
                    defesa.questionario();
                    defesa.calcularIdade();
                    defesa.calcularAposentadoria();
                    defesa.mostrarDados();
                    break;

                case 3:
                    MeioCampo meio_campo = new MeioCampo(); 
                    meio_campo.questionario();
                    meio_campo.calcularIdade();
                    meio_campo.calcularAposentadoria();
                    meio_campo.mostrarDados();
                    break;

               default:
                    break;
           }
           
        }
    }
}
