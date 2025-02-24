
using System;

namespace Lista_Level_3
{
	
	public class ex12
	{
		public static void Main()
		{
			Random rand = new Random();
			
			Console.WriteLine("Defina o tamanho do array: ");
			int arraySize = int.Parse(Console.ReadLine());
			
			
			int[] array = new int[arraySize];
			
			for (int i = 0; i < arraySize; i++) {
				array[i] = rand.Next(0 ,101);
				Console.Write("{0} ", array[i]);
			}
			
			Console.WriteLine();
			
			int max = array[0];
			int min = array[0];

			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] > max)
					max = array[i];
				if (array[i] < min)
					min = array[i];
			}

			Console.WriteLine("Máximo: {0}", max);
			Console.WriteLine("Mínimo: {0}", min);
			
			Console.ReadKey();
		}
	}
}
