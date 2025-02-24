using System;

namespace Lista_Level_3 {
	
	class ex11
	{
		public static void Main()
		{
			/*11. Escreva um programa em C# para contar a frequência de cada elemento
			de um array.*/
			
			
			Random rand = new Random();
			
			int[] array = new int[8];
			int i = 0;
			
			
			Console.WriteLine("Vetor:");
			for (i = 0; i < array.Length; i++) {
				array[i] = rand.Next(1, 10);
				Console.Write("{0} ", array[i]);
			}
			
			Console.WriteLine();
			for (i = 0; i < array.Length; i++)
			{
				
				int count = 1;

				
				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[i] == array[j])
					{
						count++;
						array[j] = -1;
					}
				}

				if (array[i] != -1)
				{
					Console.WriteLine("Elemento ({0}): {1} vezes", array[i], count);
				}
			}
			Console.ReadKey();
			
		}
	}
}