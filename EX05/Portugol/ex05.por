programa
{
	inteiro idade
	
	funcao inicio()
	{
		escreva ("Digite sua idade: ")
		leia (idade)

		se (idade >= 5 e idade <= 7)
		{
			escreva ("Você esta na categoria Infantil A")
		}
		senao se (idade >= 8 e idade <= 10)
		{
			escreva ("Você esta na categoria Infantil B")
		}
		senao se (idade >= 11 e idade <= 13)
		{
			escreva ("Você esta na categoria Juvenil A")
		}
		senao se (idade >= 14 e idade <= 17)
		{
			escreva ("Você esta na categoria Juvenil B")
		}
		senao
		{
			escreva ("Essa idade não é permitida")	
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 523; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */