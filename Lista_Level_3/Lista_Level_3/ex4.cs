
using System;

namespace Lista_Level_3
{

	public class ex4
	{
		public static void Main()
		{
			
			Random rand = new Random();
			
			Console.WriteLine("Insira o tamanho do array: ");
			int arraySize = int.Parse(Console.ReadLine());
			
			int[] array = new int[arraySize];
			
			int i = 0;
			
			Console.WriteLine("Total de elementos pares: ");
			
			for (i = 0; i < arraySize; i++) {
				array[i] = rand.Next(1, 20);
			}
			
			for (i = 0; i < arraySize; i++) { 
				
				if (array[i] % 2 == 0) {
					Console.Write("{0} ", array[i]);
				}
			}
			
			Console.WriteLine("\nTotal de elementos ímpares: ");
			for ( i = 0; i < arraySize; i++) {
				
				if (array[i] % 2 == 1) {
					Console.Write("{0} ", array[i]);
				}
			}
			
			Console.ReadKey(true);
		}
	}
}
