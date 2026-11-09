using System;

namespace Proyectoequipo
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("=== SISTEMA DE CAJA ===");
            
			 
            Console.Write("¿Cuántas ventas se van a registrar?: ");
            int totalVentas = int.Parse(Console.ReadLine());

            if (totalVentas <= 0)
            {	
            	//Si las ventas que registramos son menores a cero, si es asi el programa se termina y empezamos de nuevo
                Console.WriteLine("La cantidad debe ser mayor a cero.");
            }
            else
            {
                int ventasRealizadas = 0;
                int ventasCanceladas = 0;
                int totalProductosVendidos = 0;
                decimal totalVendidoDia = 0;
                decimal ventaMasAlta = 0;
                int numVentaMasAlta = 0;
                decimal sumaVentas = 0;
                int ventasConDescuento = 0;
                int pagoEfectivo = 0;
                int pagoTarjeta = 0;
                int pagoTransferencia = 0;
//pide al usuario ingresar los datos de las ventas
                for (int i = 1; i <= totalVentas; i++)
                {
                    Console.WriteLine("\n--- Venta " + i + " ---");
                    
                    //Va registrando la cantidad de productos que tiene ciertas ventas
                    Console.Write("¿Cuántos productos tiene la venta?: ");
                    int cantProductos = int.Parse(Console.ReadLine());

                    decimal subtotal = 0;
                    bool ventaValida = true;

                    if (cantProductos <= 0)
                    {
                    	//Si va lenta es menor a 0, la venta se pasa y sigue con la otra
                        Console.WriteLine("Cantidad inválida. Venta cancelada.");
                        ventasCanceladas++;
                        ventaValida = false;
                    }
                    else
                    {
                    	//Aqui se van registrando los datos de los productos
                        for (int j = 1; j <= cantProductos; j++)
                        {
                            Console.WriteLine("   Producto " + j + ":");
                            Console.Write("Nombre: ");
                            string nombre = Console.ReadLine();

                            Console.Write("Precio unitario: ");
                            decimal precio = decimal.Parse(Console.ReadLine());

                            Console.Write("Cantidad de piezas: ");
                            int piezas = int.Parse(Console.ReadLine());

                            if (precio <= 0 || piezas <= 0)
                            {
                                Console.WriteLine("Precio o piezas inválidos.");
                                ventaValida = false;
                            }
                            else
                            {
                                decimal importe = precio * piezas;
                                subtotal = subtotal + importe;
                                totalProductosVendidos = totalProductosVendidos + piezas;
                                
                                Console.WriteLine("Importe: $" + importe);
                            }
                        }

                        if (!ventaValida)
                        {
                            Console.WriteLine("Venta cancelada por datos incorrectos en uno o más productos.");
                            ventasCanceladas++;
                        }
                    }
                    if (ventaValida)
                    {
                        decimal iva = subtotal * 0.16m;
                        decimal total = subtotal + iva;
						 
                        decimal descuento = 0;
                        if (total > 1000)
                        {
                        	//Aqui se aplica un descuento del 10% si es mayor a 1000 la venta
                            descuento = total * 0.10m;
                            ventasConDescuento++;
                        }
						
                        //Aqui elegimos la opcion de pago que deseamos
                        decimal totalPagar = total - descuento;
                        Console.WriteLine("Forma de pago (1. Efectivo, 2. Tarjeta, 3. Transferencia): ");
                        string formaPago = Console.ReadLine();

                        if (formaPago == "1")
                        {
                            pagoEfectivo++;
                        }
                        else if (formaPago == "2")
                        {
                            pagoTarjeta++;
                        }
                        else if (formaPago == "3")
                        {
                            pagoTransferencia++;
                        }
                        else
                        {
                        	//Si la opcion que empleamos no es valida, Se asigna por defecto el pago en efectivo
                            Console.WriteLine("Opción no válida. Se asigna Efectivo por defecto.");
                            pagoEfectivo++;
                        }              
                        ventasRealizadas++;
                        totalVendidoDia = totalVendidoDia + totalPagar;
                        sumaVentas = sumaVentas + totalPagar;

                        if (totalPagar > ventaMasAlta)
                        {
                            ventaMasAlta = totalPagar;
                            numVentaMasAlta = i;
                        }
                        Console.WriteLine("\n--- TICKET DE VENTA ---");
                        Console.WriteLine("Subtotal: $" + subtotal);
                        Console.WriteLine("IVA (16%): $" + iva);
                        Console.WriteLine("Total: $" + total);
                        Console.WriteLine("Descuento: $" + descuento);
                        Console.WriteLine("Total a pagar: $" + totalPagar);
                        Console.WriteLine("-----------------------\n");
                    }
                }
                Console.WriteLine("\n****************************************");
                Console.WriteLine("            RESUMEN DEL DÍA            ");
                Console.WriteLine("****************************************");
                Console.WriteLine("Ventas realizadas: " + ventasRealizadas);
                Console.WriteLine("Ventas canceladas: " + ventasCanceladas);
                Console.WriteLine("Total de piezas vendidas: " + totalProductosVendidos);
                Console.WriteLine("Total vendido en el día: $" + totalVendidoDia);
                
                if (ventasRealizadas > 0)
                {
                    Console.WriteLine("Venta más alta: $" + ventaMasAlta + " (Venta " + numVentaMasAlta + ")");
                    Console.WriteLine("Promedio por venta: $" + (sumaVentas / ventasRealizadas));
                }
                else
                {
                    Console.WriteLine("Venta más alta: $");|
                    Console.WriteLine("Promedio por venta: $");
                }

                Console.WriteLine("Ventas con descuento: " + ventasConDescuento);
                Console.WriteLine("Pagos en Efectivo: " + pagoEfectivo);
                Console.WriteLine("Pagos con Tarjeta: " + pagoTarjeta);
                Console.WriteLine("Pagos por Transferencia: " + pagoTransferencia);
                Console.WriteLine("********************************************");
            }

            Console.WriteLine("Fin del programa.");
            Console.ReadKey(true);
        }
    }
}
