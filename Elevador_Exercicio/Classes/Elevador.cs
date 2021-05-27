using System;

namespace Exercicio_Dia_26
{
    public abstract class Elevador
    {
// 1. Crie uma classe abstrata denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:

// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
// Subir : para subir um andar (não deve subir se já estiver no último andar);
// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).
// Crie também duas subclasses: ELEVADORSOCIAL e ELEVADORSERVIÇO, o elevador de serviço deve ter um método altere o numero de caixas dentro dele.

        
        public int andarAtual = 0;
        public int quantidadeAndares = 4;
        public int capacidade = 6;
        public int quantidadePessoas = 1;

        public void entrar() {
            if(quantidadePessoas < capacidade){
                quantidadePessoas++;
                Console.WriteLine($"Entrou mais uma pessoa agora {quantidadePessoas} estão no elevador!! \n");
            }
            else
            {
                Console.WriteLine($" \nO elevador esta cheio!!!! Vai precisar subir escada kkkkkkkk\n");
            }
            
        } 

        public void sair() {
            if(quantidadePessoas > 0){
                quantidadePessoas--;
                
                Console.WriteLine($"Saiu uma pessoa agora {quantidadePessoas} estão no elevador!! \n");
            }
            else
            {
                Console.WriteLine($" O elevador esta vazio!!!!");
            }
            
        } 

        public void subir() {
            if(andarAtual < quantidadeAndares){
                andarAtual++;
                Console.WriteLine($"O elevador subiu 1 andar e agora esta no {andarAtual}");
            }
            else
            {
                Console.WriteLine($" O elevador ja esta no ultimo andar!!!!");
            }
            
        } 

        public void descer() {
            if(andarAtual > 0){
                andarAtual--;
                Console.WriteLine($"O elevador desceu 1 andar e agora esta no {andarAtual}");
            }
            else
            {
                Console.WriteLine($" O elevador ja esta no terreo!!!! ta moscando");
            }
            
        } 


        
    }
}