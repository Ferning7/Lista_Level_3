
using System;

namespace Lista_Level_3
{
	
	using System;

	class Program
	{
		public static void Main()
		{
			/*15. Escreva um programa em C# para classificar os elementos do array em
			ordem decrescente.*/
			
			// Array de exemplo
			int[] arr = { 5, 3, 8, 4, 2 };

			// Exibe o array original
			Console.WriteLine("Array original:");
			foreach (int item in arr)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();

			// Ordenação do array em ordem decrescente usando o Bubble Sort
			int temp;
			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = 0; j < arr.Length - i - 1; j++)
				{
					if (arr[j] < arr[j + 1]) // Modificado para ordem decrescente
					{
						// Troca os elementos
						temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}

			// Exibe o array ordenado
			Console.WriteLine("Array ordenado em ordem decrescente:");
			foreach (int item in arr)
			{
				Console.Write(item + " ");
			}
		}
	}

}
