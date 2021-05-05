programa
{
	cadeia usuario, senha
	funcao inicio()
	{
		faca
		{
			escreva ("Digite seu nome de usuario: ")
			leia (usuario)

			escreva ("Digite sua senha: ")
			leia (senha)

			se (senha == usuario)
			{
				escreva ("Senha Invalida, sua senha não pode ser igual ao seu usuario \n Preencha os dados novamente \n")
			}
		}enquanto (senha == usuario)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 321; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */