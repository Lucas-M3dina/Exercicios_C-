programa
{
	inteiro anoNasc, anoAtual, idade, semana
	
	funcao inicio()
	{

		escreva("Digite o ano que você nasceu: ")
		leia(anoNasc)

		escreva ("Digite o ano atual: ")
		leia(anoAtual)

		idade = anoAtual - anoNasc
		semana = idade * 52

		escreva ("Você tem ",idade," anos \n")
		escreva ("Você tem ",semana," semanas de vida")
		
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 287; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */