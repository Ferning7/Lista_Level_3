
using System;

namespace Lista_Level_3
{
	
	public class ex5
	{
		public static void Main()
		{
			/*5. Escreva o programa C # para inserir um elemento no array.*/
			
			Console.WriteLine("Insira o tamanho do array: ");
			int arraySize = int.Parse(Console.ReadLine());
			
			int[] array = new int[arraySize];
			
			
			
			Console.WriteLine("\nInsira {0} elementos no array: ", arraySize);
			
			for (int i = 0; i < arraySize; i++) {
				Console.Write("{0}º elemento: ", i);
				array[i] = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("\nElementos no array: ");
			for (int i = 0; i < arraySize; i++) {
				Console.Write("{0} ", array[i]);
			}
			Console.ReadKey(true);
		}
	}
}
