namespace Futebol_Exercicio.Classes
{
    public class MeioCampo:Jogador
    {
        public override int calcularAposentadoria(){
            int aposentado = 38 - idade;

            if (aposentado < 0)
            {
                aposentado = 0;
            }
            
            return aposentado;
        }
    }
}