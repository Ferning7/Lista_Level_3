
using System;

namespace Lista_Level_3
{
	
	public class ex8
	{
		public static void Main()
		{
			Random rand = new Random();
			
			int i = 0;
			Console.WriteLine("Defina o tamanho do array: ");
			int arraySize = int.Parse(Console.ReadLine());
			
			
			int[] array = new int[arraySize];
			
			int count = 0;
			
			for (i = 0; i < arraySize; i++) {
				array[i] = rand.Next(1, 9);
			}
			
			for ( i = 0; i < arraySize; i++) {
				for (int j = 0; j < arraySize; j++) {
					
					
					if (array[i] == array[j]) {
						count++;
						break;
					}
				}
				
				Console.Write("{0} ", array[i]);
			}
			
			Console.WriteLine("\nA soma de todos elementos repetidos: {0}", count);
			Console.ReadKey(true);
		}
	}
}
