programa
{
	cadeia condicao
	inteiro num
	
	funcao inicio()
	{
		
		faca
		{
		    escreva ("Digite um numero entre 0 e 10 \n")
		    leia(num)
		
		    se(num < 0 ou num > 10)
		    {
		        escreva ("Numero invalido!!!")
		        escreva ("Deseja tentar novamente?  y/n \n")
		        leia (condicao)
		    }
		    senao
		    {
		        escreva ("O numero digitado foi ", num)
		        condicao = ""
		    }
		}enquanto (condicao == "y")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 62; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */