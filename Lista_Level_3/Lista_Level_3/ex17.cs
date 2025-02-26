
using System;

namespace Lista_Level_3
{
	
	public class ex17
	{
		public static void Main()
		{
			/*17. Escreva um programa em C# para encontrar o segundo maior elemento
			em um array.*/
			
			Random rand = new Random();
			
			Console.Write("Defina o tamanho do array: ");
			int tamanho = int.Parse(Console.ReadLine());
			
			int[] array = new int[tamanho];
			
			
			for (int i = 0; i < tamanho; i++) {
				array[i] = rand.Next(1, 80);
				Console.Write("{0} ", array[i]);
			}
			
			int maior = int.MinValue;
			int segundoMaior = int.MinValue;
			
			foreach (int num in array) {
				if (num > maior) {
					segundoMaior = maior;
					maior = num;
				}
				else if (num > segundoMaior && num < maior) {
					segundoMaior = num;
				}
				
			}
			
			Console.WriteLine("\nO segundo maior é: {0}", segundoMaior);
			
			Console.ReadKey();
		}
	}
}
