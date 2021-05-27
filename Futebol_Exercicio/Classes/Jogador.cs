using System;
namespace Futebol_Exercicio.Classes
{
    public abstract class Jogador
    {
// .Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. 
// Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar.
//  Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos,
//   os jogadores de meio-campo aos 38 e os atacantes aos 35.

        public string nome{get; set;}
        public int diaNasc{get; set;}
        public int mesNasc{get; set;}
        public int anoNasc{get; set;}
        public string nacionalidade{get; set;}
        public float altura{get; set;}
        public float peso{get; set;}
        public int aposentado{get; set;}
        public int idade{get; set;}

        public void questionario(){
            Console.Write("Digite o nome do jogador: ");
            nome = Console.ReadLine();

            Console.Write("Digite o dia de nascimento do jogador: ");
             diaNasc = int.Parse(Console.ReadLine());

            Console.Write("Digite o mês de nascimento do jogador: ");
            mesNasc = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano de nascimento do jogador: ");
            anoNasc = int.Parse(Console.ReadLine());

            Console.Write("Digite a nacionalidade do jogador: ");
            nacionalidade = Console.ReadLine();

            Console.Write("Digite a altura do jogador: ");
            altura = float.Parse(Console.ReadLine());

            Console.Write("Digite o peso do jogador: ");
            peso = float.Parse(Console.ReadLine());
        }
        public void mostrarDados(){
            Console.WriteLine($@"
            Dados preenchidos pelo jogador {nome}:

            Data de nascimento: {diaNasc}/{mesNasc}/{anoNasc}
            Nacionalidade: {nacionalidade}
            Altura: {altura}m
            Peso: {peso}kg
            Idade: {idade} anos
            Tempo restante para aposentadoria: {aposentado} anos
            ");
            
        }

        public int calcularIdade(){
            idade = DateTime.Now.Year - anoNasc;
            return idade;
        }

        public virtual int calcularAposentadoria(){
            return 0;
        }
    }
}
    
