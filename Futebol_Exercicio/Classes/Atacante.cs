
namespace Futebol_Exercicio.Classes
{
    public class Atacante:Jogador
    {
        public override int calcularAposentadoria(){
            aposentado = 35 - idade;

            if (aposentado < 0)
            {
                aposentado = 0;
            }
            
            return aposentado;
        }
    }
}