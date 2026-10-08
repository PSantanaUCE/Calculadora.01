
using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("===== CALCULADORA =====");

        double numero1 = LeerNumero("Ingrese el primer número: ");
        double numero2 = LeerNumero("Ingrese el segundo número: ");


        Console.WriteLine("Suma: " + Sumar(numero1, numero2));
        Console.WriteLine("Resta: " + Restar(numero1, numero2));
        Console.WriteLine("Multiplicación: " + Multiplicar(numero1, numero2));

        double resultadoDivision = Dividir(numero1, numero2);

        if (!double.IsNaN(resultadoDivision))
        {
            Console.WriteLine("División: " + resultadoDivision);
        }


        Console.WriteLine("Potencia: " + Potencia(numero1, numero2));
    }


    static double Sumar(double numero1, double numero2)
    {
        return numero1 + numero2;
    }

    static double Restar(double numero1, double numero2)
    {
        return numero1 - numero2;
    }

    static double Multiplicar(double numero1, double numero2)
    {
        return numero1 * numero2;
    }

    static double Dividir(double numero1, double numero2)
    {
        if (numero2 == 0)
        {
            Console.WriteLine("División: Error: no se puede dividir entre cero");
            return double.NaN;
        }

        return numero1 / numero2;
    }


    static double LeerNumero(string mensaje)
    {
        Console.Write(mensaje);
        double numero = Convert.ToDouble(Console.ReadLine());
        return numero;
    }


    static double Potencia(double numero1, double numero2)
    {
        return Math.Pow(numero1, numero2);
    }


}
