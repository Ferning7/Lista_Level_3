
using System;

namespace Lista_Level_3
{

	public class ex4
	{
		public static void Main()
		{
			/*4. Escreva um programa C # para contar elementos pares e ímpares em um
			array.*/
			
			Random rand = new Random();
			
			Console.WriteLine("Insira o tamanho do array: ");
			int arraySize = int.Parse(Console.ReadLine());
			
			int[] array = new int[arraySize];
			
			int i = 0;
			int Pares = 0;
			int impares = 0;
			
			
			for (i = 0; i < arraySize; i++) {
				array[i] = rand.Next(1, 20);
			}
			
			Console.WriteLine("Elementos pares: ");
			
			for (i = 0; i < arraySize; i++) {
				
				if (array[i] % 2 == 0) {
					Pares++;
					Console.Write("{0} ", array[i]);
				}
			}
			
			Console.WriteLine("\nElementos ímpares: ");
			for ( i = 0; i < arraySize; i++) {
				
				if (array[i] % 2 == 1) {
					impares++;
					Console.Write("{0} ", array[i]);
				}
			}
			
			Console.WriteLine("\nTotal de números pares: {0}", Pares);
			Console.WriteLine("Total de números pares: {0}", impares);
			Console.ReadKey(true);
		}
	}
}
