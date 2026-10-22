
using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("===== CAJA REGISTRADORA =====");
        Console.WriteLine("1. Calcular cambio");
        Console.WriteLine("2. Descuento cliente");
        Console.WriteLine("3. Validar fecha");
        Console.WriteLine("4. Folio capicúa");
        Console.WriteLine("5. Redondear e inventario");
        Console.WriteLine("6. Salir");
        Console.Write("Elige una opción: ");
        
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
               
                Console.Write("Dame el precio: ");
                int precio = int.Parse(Console.ReadLine());
                Console.Write("Dame tu pago: ");
                int pago = int.Parse(Console.ReadLine());

                if (pago < precio)
                {
                    int falta = precio - pago;
                    Console.WriteLine("Pago insuficiente, faltan " + falta);
                }
                else if (pago == precio)
                {
                    Console.WriteLine("Pago exacto, no hay cambio");
                }
                else
                {
                    int cambio = pago - precio;
                    Console.WriteLine("Cambio: " + cambio);

                    int b200 = cambio / 200;
                    cambio = cambio % 200;

                    int b100 = cambio / 100;
                    cambio = cambio % 100;

                    int b50 = cambio / 50;
                    cambio = cambio % 50;

                    int b20 = cambio / 20;
                    cambio = cambio % 20;

                    int m10 = cambio / 10;
                    cambio = cambio % 10;

                    int m5 = cambio / 5;
                    cambio = cambio % 5;

                    int m2 = cambio / 2;
                    cambio = cambio % 2;

                    int m1 = cambio / 1;

                    if (b200 > 0) {
                        Console.WriteLine(b200 + " billete de 200");
                    }
                    if (b100 > 0) {
                        Console.WriteLine(b100 + " billete de 100");
                    }
                    if (b50 > 0) {
                        Console.WriteLine(b50 + " billete de 50");
                    }
                    if (b20 > 0) {
                       Console.WriteLine(b20 + " billete de 20");
                    }
                    if (m10 > 0) {
                        Console.WriteLine(m10 + " moneda de 10");
                    }
                    if (m5 > 0) {
                        Console.WriteLine(m5 + " moneda de 5");
                    }
                    if (m2 > 0) {
                        Console.WriteLine(m2 + " moneda de 2");
                    }
                    if (m1 > 0) {
                        Console.WriteLine(m1 + " moneda de 1");
                    }
                }
                break;

            case 2:
             
                Console.Write("Escribe el subtotal: ");
                double subtotal = double.Parse(Console.ReadLine());
                
                Console.Write("Tipo de cliente (E, D, G): ");
                char tipo = char.Parse(Console.ReadLine());
                
                Console.Write("¿Tiene credencial? (S/N): ");
                char respCred = char.Parse(Console.ReadLine());
                
                bool tieneCred = false;
                if (respCred == 'S' || respCred == 's')
                {
                    tieneCred = true;
                }

                double descBase = 0.0;
                bool tipoCorrecto = true;

                switch (tipo)
                {
                    case 'E':
                    case 'e':
                        descBase = 0.15;
                        break;
                    case 'D':
                    case 'd':
                        descBase = 0.10;
                        break;
                    case 'G':
                    case 'g':
                        descBase = 0.0;
                        break;
                    default:
                        tipoCorrecto = false;
                        Console.WriteLine("Tipo de cliente no válido");
                        break;
                }

                if (tipoCorrecto)
                {
                
                    if ((subtotal >= 500 && tieneCred) || (tipo == 'D' || tipo == 'd'))
                    {
                        descBase = descBase + 0.05;
                    }

                    double totalDesc = subtotal * descBase;
                    double totalPagar = subtotal - totalDesc;

                    Console.WriteLine("Subtotal: " + subtotal);
                    Console.WriteLine("Descuento total: " + totalDesc);
                    Console.WriteLine("Total a pagar: " + totalPagar);
                }
                break;

            case 3:
                
                Console.Write("Ingresa el día: ");
                int dia = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el mes: ");
                int mes = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el año: ");
                int anio = int.Parse(Console.ReadLine());

                bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
                int totalDiasMes = 0;

                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        totalDiasMes = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        totalDiasMes = 30;
                        break;
                    case 2:
                        if (esBisiesto)
                        {
                            totalDiasMes = 29;
                        }
                        else
                        {
                            totalDiasMes = 28;
                        }
                        break;
                    default:
                        totalDiasMes = 0;
                        break;
                }

                if (mes >= 1 && mes <= 12 && dia >= 1 && dia <= totalDiasMes)
                {
                    if (esBisiesto)
                    {
                        Console.WriteLine("Fecha válida, año bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("Fecha válida, año no bisiesto");
                    }
                }
                else
                {
                    if (esBisiesto)
                    {
                        Console.WriteLine("Fecha inválida, año bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("Fecha inválida, año no bisiesto");
                    }
                }
                break;

            case 4:
                
                Console.Write("Ingresa el folio (4 dígitos): ");
                int folio = int.Parse(Console.ReadLine());

                if (folio <= 1000 || folio > 9999)
                {
                    Console.WriteLine("Folio inválido");
                }
                else
                {
                    int d1 = folio / 1000;
                    int d2 = (folio / 100) % 10;
                    int d3 = (folio / 10) % 10;
                    int d4 = folio % 10;

                    bool capicua = false;
                    if (d1 == d4 && d2 == d3)
                    {
                        capicua = true;
                    }

                    int suma = d1 + d2 + d3 + d4;
                    long producto = d1 * d2 * d3 * d4;

                    string tipoSuma = "";
                    if (suma % 2 == 0)
                    {
                        tipoSuma = "par";
                    }
                    else
                    {
                        tipoSuma = "impar";
                    }

                    if (capicua)
                    {
                        Console.WriteLine("Es capicúa, suma = " + suma + " (" + tipoSuma + "), producto = " + producto);
                    }
                    else
                    {
                        Console.WriteLine("No es capicúa, suma = " + suma + " (" + tipoSuma + "), producto = " + producto);
                    }
                }
                break;

            case 5:
               
                Console.Write("Escribe un precio: ");
                double precioOriginal = double.Parse(Console.ReadLine());
                
                int precioRedondeado = (int)(precioOriginal + 0.5);
                Console.WriteLine("Precio redondeado: " + precioRedondeado);

                Console.Write("Piezas esperadas: ");
                int esperadas = int.Parse(Console.ReadLine());
                Console.Write("Piezas contadas: ");
                int contadas = int.Parse(Console.ReadLine());

                int diferencia = contadas - esperadas;
                int diferenciaAbs = 0;
                
                if (diferencia < 0)
                {
                    diferenciaAbs = -diferencia;
                }
                else
                {
                    diferenciaAbs = diferencia;
                }

                if (diferencia == 0)
                {
                    Console.WriteLine("Inventario correcto");
                }
                else if (contadas < esperadas)
                {
                    Console.WriteLine("Faltan " + diferenciaAbs + " piezas");
                }
                else
                {
                    Console.WriteLine("Sobran " + diferenciaAbs + " piezas");
                }
                break;

            case 6:
                Console.WriteLine("Gracias por usar la caja registradora");
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }
        Console.ReadKey();
        
    }
}
