using System;

namespace ex5
{
	
	public class ex5
	{
		public static void Main()
		{
			/*5. Escreva o programa C # para inserir um elemento no array.*/
			
			Console.WriteLine("Insira o tamanho do array:");
			int size = int.Parse(Console.ReadLine());
			
			int[] vetor = new int[size];
			
			Console.WriteLine("Insira os números para armazenar no array");
			for (int i = 0; i < size; i++)
			{
				Console.Write("{0}° elemento: ", i);
				vetor[i] = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("\nArray inserido: ");
			for (int i = 0; i < size; i++) {
				Console.Write("{0} ", vetor[i]);
			}
			
			Console.Write("\n\nDigite o elemento a ser inserido: ");
			int elemento = int.Parse(Console.ReadLine());
			
			Console.Write("\nDigite a posição onde deseja inserir: ");
			int posicao = int.Parse(Console.ReadLine());
			
			
			if (posicao >= 0 && posicao < vetor.Length) {
				vetor[posicao] = elemento;
				
			} else{
				Console.WriteLine("Posição inválida.");
			}
			
			for (int i = 0; i < vetor.Length; i++) {
				Console.Write("{0} ", vetor[i]);
			}
			Console.ReadKey();
		}
	}
}