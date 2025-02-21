
using System;

namespace Lista_Level_3
{
	
	public class ex2
	{
		public static void Main()
		{
			Random rand = new Random();
			
			Console.WriteLine("Defina o tamanho do array: ");
			int arraySize = int.Parse(Console.ReadLine());
			
			int[] array = new int[arraySize];
			
			
			Console.WriteLine("Vetor na ordem normal:");
			for (int i = 0; i < arraySize; i++) {
				array[i] = rand.Next(1, 10);
				Console.Write("{0} ", array[i]);
				
				
			}
			
			Console.WriteLine("\n\nVetor na ordem inversa: ");
			for (int i = arraySize - 1; i >= 0; i--) {
				
				Console.Write("{0} ", array[i]);
			} 
			Console.ReadKey(true);
		}
	}
}
