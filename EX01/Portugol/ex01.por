programa
{
	real primeiraNota, segundaNota, terceiraNota, media
	cadeia nomePessoa, test
	funcao inicio()
	{
		escreva ("Qual é o nome do aluno??")
		leia(nomePessoa)

		escreva ("Digite a primeira nota: ")
		leia(primeiraNota)

		escreva ("Digite a segunda nota: ")
		leia(segundaNota)

		escreva ("Digite a terceira nota: ")
		leia(terceiraNota)

		media = (primeiraNota + segundaNota + terceiraNota) / 3

		se (media >= 7)
		{
			test = "Aprovado"
		}
		senao
		{
			test = "Reprovado"
		}

		escreva ("O aluno ", nomePessoa, " teve a media ", media, " e foi ", test)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 576; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */