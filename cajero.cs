using System;

class Program
{


    static void Main(string[] args)
    {
        // saldo inicial del cajero 
        decimal saldoDisponible = 1000.00m; 

        // ccreamos menu inicial
        while (true)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Opciones disponibles:");
            Console.WriteLine("1. Ver saldo disponible");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("0. Salir del programa");
            Console.WriteLine("-----------------------");

            // 
            Console.WriteLine("Ingrese la opción deseada: ");
            int opcion = int.Parse(Console.ReadLine());

            // si el usuario ingresa un 0 salimos del programa
            if (opcion == 0)
            {
                break;
            }

            // Opciones de uso 
            switch (opcion)
            {
                case 1:
                    // Mostrar el saldo disponible
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Saldo disponible: " + saldoDisponible.ToString("C2"));
                    Console.WriteLine("-----------------------");
                    break;

                case 2:
                    // Depositar dinero
                    Console.WriteLine("Ingrese la cantidad a depositar: ");
                    decimal deposito = decimal.Parse(Console.ReadLine());

                    saldoDisponible += deposito;

                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Depósito realizado con éxito!");
                    Console.WriteLine("Saldo disponible: " + saldoDisponible.ToString("C2"));
                    Console.WriteLine("-----------------------");
                    break;

                case 3:
                    // Retirar dinero
                    Console.WriteLine("Ingrese la cantidad a retirar: ");
                    decimal retiro = decimal.Parse(Console.ReadLine());

                    if (retiro > saldoDisponible)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Saldo insuficiente para realizar el retiro.");
                        Console.WriteLine("Saldo disponible: " + saldoDisponible.ToString("C2"));
                        Console.WriteLine("-----------------------");
                    }
                    else
                    {
                        saldoDisponible -= retiro;

                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Retiro realizado con éxito!");
                        Console.WriteLine("Saldo disponible: " + saldoDisponible.ToString("C2"));
                        Console.WriteLine("-----------------------");
                    }
                    break;

                default:
                    // si la opciones no son calidas mandar mensajes de error 
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}
