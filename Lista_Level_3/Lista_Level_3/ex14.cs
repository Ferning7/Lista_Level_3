using System;

namespace Lista_Level_3 {
	
	class ex14
	{
		public static void Main()
		{
			/* 14. Escreva um programa em C# para classificar os elementos do array em
			ordem crescente.*/
			
			// Array de exemplo
			int[] arr = { 5, 3, 8, 4, 2 , 9, 1};

			// Exibe o array original
			Console.WriteLine("Array original:");
			foreach (int item in arr)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();

			// Ordenação do array em ordem crescente usando o Bubble Sort
			int temp;
			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = 0; j < arr.Length - i - 1; j++)
				{
					if (arr[j] > arr[j + 1]) // Se o elemento atual for maior que o próximo
					{
						// Troca os elementos
						temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}

			// Exibe o array ordenado
			Console.WriteLine("Array ordenado em ordem crescente:");
			foreach (int item in arr)
			{
				Console.Write(item + " ");
			}
			Console.ReadKey();
		}
	}
}