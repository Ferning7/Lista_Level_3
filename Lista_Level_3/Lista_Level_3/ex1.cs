
using System;

namespace Lista_Level_3
{
	
	public class ex1
	{
		public static void Main (){
			/*1. Escreva um programa em C# para armazenar elementos em um array e
			imprimi-lo.*/
			
			int[] arrays = new int[5];
			
			Console.WriteLine("Insira elementos em um Array: ");
			
			for (int i = 0; i < arrays.Length; i++) {
				Console.Write("{0}° Elemento: ", i);
				arrays[i] = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine();
			Console.WriteLine("Elementos inseridos no array: ");
			for (int i = 0; i < arrays.Length; i++) {
				Console.Write("\n{0}° elemento: {1}", i, arrays[i]);
			}
			Console.ReadKey(true);
		}
		
	}
}
