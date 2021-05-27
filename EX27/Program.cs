using System;

namespace EX27
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string adversario;
            Random numAleatorio = new Random();

            Personagem personagem1 = new Personagem();
            Personagem personagem2 = new Personagem();

            
            personagem1.nome = "Homem de Ferro";
            personagem1.armadura = "Mark LXXXV";
            personagem1.idade = 53;
            personagem1.pontosVida = 100;
            personagem1.ataque = numAleatorio.Next(26,40);

            personagem2.nome = "Homem Aranha";
            personagem2.armadura = "Iron Spider";
            personagem2.idade = 50;
            personagem2.pontosVida = 100;
            personagem2.ataque = numAleatorio.Next(18,35);

            Console.Write($@"
Escolha seu personagem:

[1]  Homem de Ferro    
[2]  Homem Aranha

Resposta: ");     
            int cond = int.Parse(Console.ReadLine());
            if(cond == 1){
                nome1 = personagem1.nome;
                adversario = personagem2.nome;
            } 
            else{
                nome1 = personagem2.nome;
                adversario = personagem1.nome;
            }

            while (personagem1.pontosVida > 0 || personagem2.pontosVida > 0)
            {
                Console.Write($@"

               {nome1}

[1] Atacar                 [2] Regeneração

Resposta: ");
                int opcao = int.Parse(Console.ReadLine());

                int opcao2 = numAleatorio.Next(1,2);
                

                if (opcao == 1 && opcao2 == 1 ){
                    personagem1.pontosVida = personagem1.pontosVida - personagem2.ataque;
                    personagem2.pontosVida = personagem2.pontosVida - personagem1.ataque;

                    Console.WriteLine(@$"


Vida do Homem Aranha: {personagem2.pontosVida}
Vida do Homem de Ferro: {personagem1.pontosVida}


");
                }
                else if(opcao == 2 && opcao2 == 1){
                    personagem1.pontosVida = personagem1.pontosVida + 50;
                    personagem1.pontosVida = personagem1.pontosVida - personagem2.ataque;
Console.WriteLine(@$"


Vida do Homem Aranha: {personagem2.pontosVida}
Vida do Homem de Ferro: {personagem1.pontosVida}


");
                }
                else if(opcao == 2 && opcao2 == 1){
                    personagem2.pontosVida = personagem2.pontosVida + 50;
                    personagem2.pontosVida = personagem2.pontosVida - personagem1.ataque;

Console.WriteLine(@$"


Vida do Homem Aranha: {personagem2.pontosVida}
Vida do Homem de Ferro: {personagem1.pontosVida}


");
                }
                else if (opcao == 1 && opcao2 == 1 ){
                    personagem1.pontosVida = personagem1.pontosVida + 50;
                    personagem2.pontosVida = personagem2.pontosVida + 50;
Console.WriteLine(@$"


Vida do Homem Aranha: {personagem2.pontosVida}
Vida do Homem de Ferro: {personagem1.pontosVida}


");
                 }
            } 
            
            

            
        


        }
    }
}
