using System;
using System.Linq.Expressions;

namespace programa_2 
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int numero1 = 0;
				int numero2 = 0;
				int numero3 = 0;
				int numero4 = 0;

                Console.WriteLine("Este programa debes ingresar 4 numeros,\nte devolvera la suma de los 2 primeros numeros \ny el producto de los 2 ultimos, \nacontinuacion ingrese el primer numero: ");
				numero1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ingrese el segundo numero: ");
				numero2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ingrese el tercer numero: ");
				numero3 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ingrese el cuarto numero: ");
				numero4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"la suma de {numero1} y {numero2} es {numero1 + numero2}.");
				Console.WriteLine($"el producto de {numero3} y {numero4} es {numero3 * numero4}.");

			}
            catch(Exception ex)
			{
                Console.WriteLine($"a ocurrido un error: {ex.Message}");
            }

			
		}
	}
}