using System;

class Program
{
    static void Main()
    {
        int opcion = 0;

        while (opcion != 6)
        {
            Console.WriteLine("⋆.CAJERO AUTOMÁTICO ⋆.");
            Console.WriteLine("1. Convertir número de cuenta a binario");
            Console.WriteLine("2. Depositar billetes");
            Console.WriteLine("3. Validar NIP");
            Console.WriteLine("4. Analizar número de cuenta");
            Console.WriteLine("5. Decodificar mensaje ASCII");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opción: ");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                
                int cuenta = 0;
                while (cuenta <= 0)
                {
                    Console.Write("Ingresa el número de cuenta: ");
                    cuenta = int.Parse(Console.ReadLine());
                    if (cuenta <= 0)
                    {
                        Console.WriteLine("Número inválido, intenta de nuevo");
                    }
                }

                int tempBin = cuenta;
                string binario = "";
                while (tempBin > 0)
                {
                    int residuo = tempBin % 2;
                    binario = residuo + binario;
                    tempBin = tempBin / 2;
                }

                Console.WriteLine(cuenta + "  " + binario);
            }
            else if (opcion == 2)
            {
               
                int billete = -1;
                int cantidadBilletes = 0;
                int total = 0;

                Console.WriteLine("Ingresa las denominaciones (termina con 0):");
                while (billete != 0)
                {
                    Console.Write("Billete: ");
                    billete = int.Parse(Console.ReadLine());

                    if (billete == 0)
                    {
                        break;
                    }

                    if (billete == 20 || billete == 50 || billete == 100 || 
                        billete == 200 || billete == 500 || billete == 1000)
                    {
                        cantidadBilletes = cantidadBilletes + 1;
                        total = total + billete;
                    }
                    else
                    {
                        Console.WriteLine("Billete no válido, se rechaza");
                    }
                }

                Console.WriteLine("Billetes aceptados: " + cantidadBilletes);
                Console.WriteLine("Total depositado: $" + total);
            }
            else if (opcion == 3)
            {
               
                int intentos = 3;
                bool acceso = false;

                while (intentos > 0)
                {
                    Console.Write("Ingresa tu NIP: ");
                    int nip = int.Parse(Console.ReadLine());

                    if (nip == 1234)
                    {
                        int intentoExitoso = 4 - intentos;
                        Console.WriteLine("Acceso concedido en el intento " + intentoExitoso);
                        acceso = true;
                        break;
                    }
                    else
                    {
                        intentos = intentos - 1;
                        if (intentos > 0)
                        {
                            Console.WriteLine("NIP incorrecto, te quedan " + intentos + " intentos");
                        }
                    }
                }

                if (acceso == false)
                {
                    Console.WriteLine("Tarjeta bloqueada");
                }
            }
            else if (opcion == 4)
            {
                
                int cuentaAna = 0;
                while (cuentaAna <= 0)
                {
                    Console.Write("Ingresa un número de cuenta positivo: ");
                    cuentaAna = int.Parse(Console.ReadLine());
                    if (cuentaAna <= 0)
                    {
                        Console.WriteLine("Número inválido, intenta de nuevo");
                    }
                }

                int temp = cuentaAna;
                int digitos = 0;
                int suma = 0;
                int invertido = 0;
                int original = cuentaAna;

                while (temp > 0)
                {
                    int ultimo = temp % 10;
                    suma = suma + ultimo;
                    invertido = (invertido * 10) + ultimo;
                    digitos = digitos + 1;
                    temp = temp / 10;
                }

                Console.Write(original + " -> " + digitos + " dígitos, suma = " + suma);
                
                if (suma % 2 == 0)
                {
                    Console.Write(" (par), ");
                }
                else
                {
                    Console.Write(" (impar), ");
                }

                Console.Write("invertido = " + invertido + ", ");

                if (original == invertido)
                {
                    Console.WriteLine("es capicúa");
                }
                else
                {
                    Console.WriteLine("no es capicúa");
                }
            }
            else if (opcion == 5)
            {
               
                int codigo = -1;
                string mensaje = "";
                int aceptados = 0;
                int sumaCodigos = 0;

                Console.WriteLine("Ingresa códigos ASCII (para finalizar ingrse 0):");
                while (codigo != 0)
                {
                    Console.Write("Código ASCII: ");
                    codigo = int.Parse(Console.ReadLine());

                    if (codigo == 0)
                    {
                        break;
                    }

                    if (codigo >= 32 && codigo <= 126)
                    {
                        char caracter = (char)codigo;
                        string tipo = "";

                        if (caracter >= 'A' && caracter <= 'Z')
                        {
                            tipo = "Mayúscula";
                        }
                        else if (caracter >= 'a' && caracter <= 'z')
                        {
                            tipo = "Minúscula";
                        }
                        else if (caracter >= '0' && caracter <= '9')
                        {
                            tipo = "Dígito";
                        }
                        else
                        {
                            tipo = "Símbolo";
                        }

                        Console.WriteLine(caracter + "  " + tipo);
                        mensaje = mensaje + caracter;
                        aceptados = aceptados + 1;
                        sumaCodigos = sumaCodigos + codigo;
                    }
                    else
                    {
                        Console.WriteLine("Código no válido, se rechaza");
                    }
                }

                double promedio = 0;
                if (aceptados > 0)
                {
                    promedio = (double)sumaCodigos / aceptados;
                }

                Console.WriteLine("Mensaje decodificado: " + mensaje);
                Console.WriteLine("Caracteres aceptados: " + aceptados);
                Console.WriteLine("Promedio de códigos: " + promedio);
            }
            else if (opcion == 6)
            {
                Console.WriteLine("Gracias por usar el cajero automático");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
        Console.ReadKey();
    }
}
