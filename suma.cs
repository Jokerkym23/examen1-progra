using System;

class Program
{
    static void Main(string[] args)
    {
        // creamos variables donde se ingresen los numeros 
        int suma = 0;
        int cantidadNumeros = 0;

        // creamos un bucle para crear  umero sde forma indefinida
        while (true)
        {
            // ingresamos el numero 0 para cerrar el ciclo
            Console.WriteLine("Ingrese un número (0 para terminar): ");
            int numero = int.Parse(Console.ReadLine());

            // cerramos bucle si y solo si el numero ingresado es 0
            if (numero == 0)
            {
                break;
            }

            // sumamos todos los numeros 
            suma += numero;

            
            cantidadNumeros++;
        }

        // Calculamos el promedio de los numeros
        double promedio = (double)suma / cantidadNumeros;

        // inprimimos la suma y el promedio obtenido 
        Console.WriteLine("-----------------------");
        Console.WriteLine("Suma de los números: " + suma);
        Console.WriteLine("Promedio de los números: " + promedio.ToString("F2"));
        Console.WriteLine("-----------------------");
    }
}
