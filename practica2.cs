using System;

namespace mde
{
	class Program
	{
		public static void Main(string[] args)
		{
			int edad = 0;

     		Console.WriteLine("ingresa tu edad");
			edad = int.Parse(Console.ReadLine());

			if (edad >= 18)
		{
		    Console.WriteLine("eres mayor de edad\n");
		}
			else
		{
		    Console.WriteLine("eres menor de edad\n");
		}
			
			int tot = 0;
            double descuento = 0;
			double totfin= 0;

			Console.WriteLine("ingrese su monto total");
			tot = int.Parse(Console.ReadLine());

			if (tot > 1000)
			{
  			  descuento = tot * 0.10;
  			  totfin = tot - descuento;

  			  Console.WriteLine("descuento: " + descuento);
  			  Console.WriteLine("total con descuento: " + totfin);
  			  Console.WriteLine("gracias por su compra\n");
			}
				else
			{
 			   Console.WriteLine("No aplica descuento\n");
			}
				
				Console.WriteLine("ingrese un numero entero");
				int num = int.Parse(Console.ReadLine());
				if (num<0) {
					num=num*-1;
					Console.WriteLine("su numero es negativo");
					Console.WriteLine("su valor absoluto es: \n"+num);
				} 
				else
				{
					Console.WriteLine("su numero es positivo\n");
				}
				
				Console.WriteLine("ingrese un numero entero");
				int num2 = int.Parse(Console.ReadLine());
				if (num2%2==0) {
					Console.WriteLine("su numero es par\n");
				}
				else
				{
					Console.WriteLine("su numero es impar\n");
				}
				
				Console.WriteLine("ingrese su calificacion");
				int calif = int.Parse(Console.ReadLine());
				if (calif>=6) {
						Console.WriteLine("aprobado\n");
				}
				else
				{
						Console.WriteLine("reprobado\n");
				}
				
				string pass="evergene1510";
				Console.WriteLine("ingrese la contraseña");
				string intento = Console.ReadLine();
				if (intento == pass) {
					Console.WriteLine("acceso concedido");
				
				}
				else
				{
					Console.WriteLine("acceso denegado");
				}
			
		
				
			Console.ReadKey(true);
		}
	}
}
