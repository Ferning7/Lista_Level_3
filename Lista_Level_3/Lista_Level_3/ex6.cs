
using System;

namespace Lista_Level_3
{
	
	public class ex6
	{
		public static void Main()
		{
			Random rand = new Random();
			
			
			Console.WriteLine("Defina o tamanho do array: ");
			int arraySize = int.Parse(Console.ReadLine());
			
			
			int[] array = new int[arraySize];
			
			int soma = 0;
			
			Console.WriteLine("Array da vez: ");
			for (int i = 0; i < arraySize; i++) {
				array[i] = rand.Next(1, 20);
				soma += array[i];
				Console.Write("{0} ", array[i]);
			}
			
			Console.WriteLine("\nA soma de todos elementos será: {0}", soma);
			Console.ReadKey(true);
		}
	}
}
