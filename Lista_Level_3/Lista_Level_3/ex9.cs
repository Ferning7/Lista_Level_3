
using System;

namespace Lista_Level_3
{
	
	public class ex9
	{
		public static void Main()
		{
			/*9. Escreva um programa em C# para imprimir todos os elementos únicos
			em um array.*/
			
			int[] array = { 1, 2, 3, 2, 4, 5, 6, 3, 3, 7, 8, 8 };

			Console.WriteLine("Elementos únicos no array:");
			
			for (int i = 0; i < array.Length; i++)
			{
				

				int count = 0;
				for (int j = 0; j < array.Length; j++)
				{
					if (array[i] == array[j])
					{
						count++;
					}
				}
				
				if (count == 1)
				{
					Console.WriteLine(array[i]);
				}
				
				
			}
			Console.ReadKey(true);
		}
	}
}

