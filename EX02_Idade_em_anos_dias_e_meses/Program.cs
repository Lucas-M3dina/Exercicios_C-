using System;

namespace EX02_Idade_em_anos_dias_e_meses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Anos você tem???");
            int anos = int.Parse(Console.ReadLine());
            
            int meses = anos * 12;
            int dias = anos * 365;
            int horas = dias * 24;
            int min = horas * 60;

            Console.WriteLine("Você tem " + anos + " anos, " + meses + " meses, " + dias + " dias, " + horas + " horas e " + min + " minutos de vida" );
        }
    }
}
