using System;

namespace Practica5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("===calificaciones===\n");
			Console.WriteLine("ingrese su calificacion final\n");
			
			int calif=int.Parse(Console.ReadLine());
			if (calif>=90 && calif<=100) {
				Console.WriteLine("A\n");
			}
			else if (calif>=80 && calif<=89) {
				Console.WriteLine("B\n");
			}
			else if (calif>=70 && calif<=79) {
				Console.WriteLine("C\n");
			}
			else if (calif>=60 && calif<=69) {
				Console.WriteLine("D\n");
			}
			else if (calif>=0 && calif <=59) {
				Console.WriteLine("F\n");
			}else
			{
				Console.WriteLine("calificacion no valida\n");
			}
			
			
			Console.WriteLine("===dias de la semana===\n");
			Console.WriteLine("ingrese un numero del 1 al 7\n");
			
			int dia=int.Parse(Console.ReadLine());
			if (dia==1) {
				Console.WriteLine("lunes\n");
			}
			else if (dia==2) {
				Console.WriteLine("martes\n");
			}
			else if (dia==3) {
				Console.WriteLine("miercoles\n");
			}
			else if (dia==4) {
				Console.WriteLine("jueves\n");
			}
			else if (dia==5) {
				Console.WriteLine("viernes\n");
			}
			else if (dia==6) {
				Console.WriteLine("sabado\n");
			}
			else if (dia==7) {
				Console.WriteLine("domingo\n");
			}
			else
				
			{
				Console.WriteLine("numero no valido\n");
			}
			
			
			Console.WriteLine("===clasificacion por temperatura===\n");
			Console.WriteLine("ingrese la temperatura\n");
			
			int temp=int.Parse(Console.ReadLine());
			if (temp<0) {
				Console.WriteLine("congelante");
			}
			else if (temp>=0 && temp <=14) {
				Console.WriteLine("frio");
			}
			else if (temp>=15 && temp <=24) {
				Console.WriteLine("templado");
			}
			else if (temp>=25 && temp <=34) {
				Console.WriteLine("caluroso");
			}
			else
			{
				Console.WriteLine("muy caluroso");
			}
			
			
			Console.ReadKey(true);
		}
	}
}
