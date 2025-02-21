
using System;

namespace Lista_Level_3
{
	
	public class ex1
	{
		public static void Main (){
			
			int[] arrays = new int[5];
			
			Console.WriteLine("Insira elementos em um Array: ");
			
			for (int i = 0; i < arrays.Length; i++) {
				Console.Write("{0}° Elemento: ", i);
				arrays[i] = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine();
			for (int i = 0; i < arrays.Length; i++) {
				Console.Write("Elementos: {0} ", arrays[i]);
			}
			Console.ReadKey(true);
		}
		
	}
}
