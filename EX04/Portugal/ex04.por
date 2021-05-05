programa
{
	real salario, reajuste
	
	funcao inicio()
	{
		escreva("Digite o seu salario atual: ")
		leia(salario)

		se (salario < 500)
		{
			reajuste = salario + (salario / 100 * 30)
			escreva ("Seu salario com o reajuste é R$", reajuste)
		}
		senao
		{
			escreva ("Você não tem direito a um aumento")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 312; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */