using System;

namespace decvariables
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int id = 0;
			char letter = 'a';
			string nombre = "";  
			float promedio = 0.0f;
			double wallet = 0.0;
			Console.WriteLine("edad "+id);
			id=int.Parse(Console.ReadLine());
			Console.WriteLine("letra "+letter);
			letter=char.Parse(Console.ReadLine());
Console.WriteLine("mes "+nombre);
nombre=Console.ReadLine();
Console.WriteLine("valor de pi "+promedio);
			promedio=float.Parse(Console.ReadLine());	
		Console.WriteLine("$"+wallet);
			wallet=double.Parse(Console.ReadLine());
			
			int edad=18;
			char letra='a';
			string mes="enero";
			float pi=3.1415f;
			double cartera=59.99;
			
			Console.WriteLine("edad "+edad);
			Console.ReadKey(true);
			Console.WriteLine("letra "+letra);
			Console.ReadKey(true);
Console.WriteLine("mes "+mes);
			Console.ReadKey(true);
Console.WriteLine("valor de pi "+pi);
			Console.ReadKey(true);			
		Console.WriteLine("$"+cartera);
			Console.ReadKey(true);
		}
	}
}
