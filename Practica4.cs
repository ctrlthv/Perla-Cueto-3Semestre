
namespace Practica4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("====NUMERO MAYOR A 100=== ");
			Console.WriteLine("INGRESE UN NUMERO ENTERO: ");
			int num = int.Parse(Console.ReadLine());
			
			if (num>100) {
				Console.WriteLine("el numero es mayor que 100\n");
			}
			else{
				Console.WriteLine("el numero es menor o igual a 100\n");
			}
			Console.WriteLine("====ENVIO GRATIS=== ");
			
			Console.WriteLine("ingrese el monto de su compra: ");
			int monto = int.Parse(Console.ReadLine());
			
			if (monto>=500) {
				Console.WriteLine("tienes envio gratis, total de su compra:"+monto+"\n");
			}
			else{
				Console.WriteLine("total a pagar: "+monto+"\n");
			}
			
			Console.WriteLine("====MULTIPLO DE 5=== ");
			Console.WriteLine("ingrese un numero entero ");
			int num1= int.Parse(Console.ReadLine());
			
			if (num1 % 5 ==0) {
				Console.WriteLine("el numero es multiplo de 5");
			}
			else{
				Console.WriteLine("");
			}
			 
			Console.WriteLine("====MAYOR DE DOS NUMEROS=== ");
			
			Console.WriteLine("ingrese primer numero");
			int num2= int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese segundo numero");
			int num3= int.Parse(Console.ReadLine());
			if (num2>num3) {
				Console.WriteLine("el numero "+num2+"es mayor que: "+num3+"\n");
			}
			else{
				Console.WriteLine("el numero "+num3+"es mayor que: "+num2+"\n");
			}
			
			Console.WriteLine("===POSITIVO O NEGATIVO=== ");
			Console.WriteLine("ingrese un numero ");
			int num4= int.Parse(Console.ReadLine());
			
			if (num4>=0) {
				Console.WriteLine("el nnumero es positivo o 0");
			}
			else{
				Console.WriteLine("el numero es negativo");
			}
			
			
			Console.WriteLine("===SALDO SUFICIENTE=== ");
			Console.WriteLine("ingrese saldo en su tarjeta");
			int num5= int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese total a pagar");
			int num6= int.Parse(Console.ReadLine());
			decimal total=0;
			if (num5>=num6) {
				total=num5-num6;
				Console.WriteLine("compra realizada! saldo restante:"+total+"\n");
			}
			else{
				Console.WriteLine("saldo insuficiente\n");
			}
			
			Console.ReadKey(true);
		}
	}
}
