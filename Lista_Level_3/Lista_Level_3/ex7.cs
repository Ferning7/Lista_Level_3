
using System;

namespace Lista_Level_3
{
	
	public class ex7
	{
		public static void Main()
		{
			/*7. Escreva um programa em C# para copiar os elementos de um array em
			outro array.*/
			
			int i = 0;
			
			Console.WriteLine("Defina o tamanho do array: ");
			int arraySize = int.Parse(Console.ReadLine());
			
			int[] array = new int[arraySize];
			
			Console.WriteLine("Insira {0} elementos no array original: ", arraySize);
			
			for (i = 0; i < arraySize; i++) {
				array[i] = int.Parse(Console.ReadLine());
			}
			
			
			int[] arrayCopy = array;
			
			
			Console.WriteLine("Array original: ");
			for (i = 0; i < arraySize; i++) {
				Console.Write("{0} ", array[i]);
			}
			
			
			Console.WriteLine("\nCópia do array: ");
			for (i = 0; i < arraySize; i++) {
				Console.Write("{0} ", arrayCopy[i]);
			}
			Console.ReadKey();
		}
	}
}
