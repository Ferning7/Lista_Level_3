
using System;

namespace Lista_Level_3
{
	
	public class ex16
	{
		public static void Main()
		{
			/*16. Escreva um programa em C# para deletar um elemento na posição
			desejada de um array.*/
			
			int[] array = {1, 2, 3, 4, 5, 6};

			for (int i = 0; i < array.Length; i++) {
				Console.WriteLine("{0} ", array[i]);
			}
			
			Console.WriteLine("Digite a posição que deseja remover: ");
			
			int posicaoRemov = int.Parse(Console.ReadLine());
			
			if (posicaoRemov >= 0 && posicaoRemov < array.Length) {
				int[] arrayNovo = new int[array.Length - 1];
				
				for (int i = 0; i < posicaoRemov; i++) {
					arrayNovo[i] = array[i];
					
				}
				
				for (int i = posicaoRemov + 1; i < array.Length; i++) {
					arrayNovo[i - 1] = array[i];
				}
				
				Console.WriteLine("Array com a posição removida: ");
				for (int i = 0; i < arrayNovo.Length; i++) {
					Console.Write("{0} ", arrayNovo[i]);
					
				}
				Console.WriteLine();
				
			} else {
				Console.WriteLine("Posição inválida.");
			}
			
			Console.ReadKey();
		}
	}
}