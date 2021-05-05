programa
{
	cadeia validar1, validar2, validar3, validar4, nome, civil
	inteiro idade
	real salario
	
	funcao inicio()
	{
		faca
		{
			escreva ("Digite seu nome: ")
			leia (nome)

			escreva ("Digite sua idade: ")
			leia (idade)

			escreva ("Digite seu salario: R$")
			leia (salario)

			escreva ("Digite seu estado civil ( 's' solteiro(a), 'c' casado(a), 'v' viuvo(a), 'd' divorciado(a) ): ")
			leia (civil)

			se (nome != "")
			{
				validar1 = "valido"
			}
			senao
			{
				escreva ("\n Nome Invalido")
				validar1 = "invalido"
			}


			se (idade <= 100)
			{
				validar2 = "valido"
			}
			senao
			{
				escreva ("\n Idade Invalida")
				validar2 = "invalido"
			}


			se (salario > 0)
			{
				validar3 = "valido"
			}
			senao
			{
				escreva ("\n salario Invalido")
				validar3 = "invalido"
			}


			se (civil == "s" ou civil == "c" ou civil == "v" ou civil == "d")
			{
				validar4 = "valido"
			}
			senao
			{
				escreva ("\n Estado Civil  Invalido")
				validar4 = "invalido"
			}


			se (validar1 == "invalido" ou validar2 == "invalido" ou validar3 == "invalido" ou validar4 == "invalido")
			{
				escreva ("\n Existem itens invalidos, por favor digite os dados novamente!!! \n")
			}
			senao
			{
				escreva ("Seus dados foram validos obrigado :)   \n")
			}
			
		}enquanto(validar1 == "invalido" ou validar2 == "invalido" ou validar3 == "invalido" ou validar4 == "invalido")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 709; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */