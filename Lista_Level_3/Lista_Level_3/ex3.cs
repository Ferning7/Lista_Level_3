
using System;

namespace Lista_Level_3
{
	
	public class ex3
	{
		public static void Main()
		{
			/*3. Escreva o programa C # para contar o número total de elementos
			negativos no array.*/
			
			Random rand = new Random();
			
			Console.WriteLine("Insira o tamanho do array: ");
			int arraySize = int.Parse(Console.ReadLine());
			
			int[] array = new int[arraySize];
			
			
			Console.WriteLine("Total de números negativos no array: ");
			
			for (int i = 0; i < arraySize; i++) {
				array[i] = rand.Next(-10, 10);
				
				if (array[i] < 0) {
					Console.Write("{0} ", array[i]);
				}
			}
			
			Console.ReadKey(true);
		}
	}
}
