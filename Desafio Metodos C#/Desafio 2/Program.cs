using System;

public class Calculadora
{
    public int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Restar(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Dividir(int num1, int num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return 0;
        }
        return num1 / num2;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculadora miCalculadora = new Calculadora();

        // Pedir los números al usuario
        Console.WriteLine("Ingrese el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Realizar las operaciones
        int suma = miCalculadora.Sumar(num1, num2);
        int resta = miCalculadora.Restar(num1, num2);
        int multiplicacion = miCalculadora.Multiplicar(num1, num2);
        int division = miCalculadora.Dividir(num1, num2);

        // Mostrar los resultados
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        Console.WriteLine($"División: {division}");
    }
}
