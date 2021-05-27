namespace Futebol_Exercicio.Classes
{
    public class Defensor: Jogador
    {
        public override int calcularAposentadoria(){
            int aposentado = 40 - idade;

            if (aposentado < 0)
            {
                aposentado = 0;
            }

            return aposentado;
        }
    }
}