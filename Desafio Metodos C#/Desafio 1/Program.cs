using System;

public class Program
{
    public static void Main(string[] args)
    {
        PedirIngresosYMostrarMensaje();
    }

    public static void PedirIngresosYMostrarMensaje()
    {
        Console.WriteLine("Ingrese su nombre:");
        string nombreUsuario = Console.ReadLine();

        Console.WriteLine("Ingrese sus ingresos del primer mes:");
        double ingresosMes1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese sus ingresos del segundo mes:");
        double ingresosMes2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese sus ingresos del tercer mes:");
        double ingresosMes3 = Convert.ToDouble(Console.ReadLine());

        double sumaIngresos = ingresosMes1 + ingresosMes2 + ingresosMes3;
        double promedioIngresos = sumaIngresos / 3;

        Console.WriteLine($"Hola {nombreUsuario}, en total ganaste {sumaIngresos} y promediaste {promedioIngresos}");
    }
}