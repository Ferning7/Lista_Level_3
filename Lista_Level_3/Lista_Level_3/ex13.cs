using System;

namespace Lista_Level_3
{
	class Ex13
	{
		public static void Main(string[] args)
		{
			/*
			13. Escreva um programa em C# para separar inteiros ímpares e pares em
				arrays separados.
			 */
			
			Random randao = new Random();
			
			Console.WriteLine("Digite o tamanho do array original:");
			int tOriginal = int.Parse(Console.ReadLine());
			
			int[] vetOriginal = new int[tOriginal];
			int[] vetPar = new int[tOriginal/2];
			int[] vetImpar = new int[tOriginal/2];
			
			//Atribuição de valores
			for(int i = 0; i < tOriginal; i++) {
				Console.WriteLine("Digite o valor numerico inteiro:");
				vetOriginal[i] = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("O vetOriginal preenchido é:");
			
			//Mostrando para o Usuario
			for(int i = 0; i < tOriginal;i++) {
				Console.Write("{0} ",vetOriginal[i]);
			}
			
			int j = 0, k = 0;
			
			//Separar os impares dos pares
			for(int i = 0; i< tOriginal; i++) {
				
				//Par
				if (vetOriginal[i] % 2 == 0) {
					vetPar[k] = vetOriginal[i];
					k++;
				}
				
				//Impar
				else {
					vetImpar[j] = vetOriginal[i];
					j++;
				}
			}
			
			Console.WriteLine("\n");
			//Pares
			for (k = 0; k < tOriginal/2; k++)
			{
				Console.Write("{0} ",vetPar[k]);
				
			}
			Console.WriteLine("\n");
			
			//Impares
			for (j = 0; j < tOriginal/2; j++)
			{
				Console.Write("{0} ",vetImpar[j]);
				
			}
			
			Console.ReadKey();
		}
	}
}
