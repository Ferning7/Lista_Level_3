
using System;

namespace Lista_Level_3
{
	
	public class ex2
	{
		public static void Main()
		{
			/*2. Escreva um programa em C# para ler um número n de valores em um
			array e exibi-lo na ordem inversa.*/
			
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
