
using System;

namespace Lista_Level_3
{
	
	public class ex10
	{
		public static void Main()
		{
			Random rand = new Random();
			
			int i = 0, j = 0, k = 0;
			Console.WriteLine("Qual tamanho ce quer ze?: ");
			int tamanhoArray = int.Parse(Console.ReadLine());
			
			int[] array1 = new int[tamanhoArray];
			int[] array2 = new int[tamanhoArray];
			
			for ( i = 0; i < tamanhoArray; i++) {
				array1[i] = rand.Next(1, 50);
				array2[i] = rand.Next(1,50);
			}
			
			Console.WriteLine("Vetor 1:");
			for (i = 0; i < tamanhoArray; i++) {
				Console.Write("{0} ", array1[i]);
			}
			
			Console.WriteLine("\nVetor 2:");
			for (i = 0; i < tamanhoArray; i++) {
				Console.Write("{0} ", array2[i]);
			}
			
			int tamanhoFinal = tamanhoArray + tamanhoArray;
			
			int[] vetorFinal = new int[tamanhoFinal];
			
			for (i = 0; i < tamanhoArray; i++) {
				vetorFinal[i] = array1[i];
			}
			
			
			for (j = i; j < tamanhoArray; i++) {
				vetorFinal[i] = array2[j];
				i++;
			}
			
			
			
			for (i = 0; i < tamanhoFinal; i++) {
				for (k = 0; k < tamanhoFinal - 1; k++) {
					if (vetorFinal[k] >= vetorFinal[k + 1]) {
						j = vetorFinal[k + 1];
						vetorFinal[k + 1] = vetorFinal[k];
						vetorFinal[k] = j;
					}
				}
			}
			
			Console.WriteLine("\nVetor em ordem crescente: ");
			for (i = 0; i < tamanhoFinal; i++) {
				Console.Write("{0} ", vetorFinal[i]);
			}
			
			Console.ReadKey(true);
		}
	}
}
