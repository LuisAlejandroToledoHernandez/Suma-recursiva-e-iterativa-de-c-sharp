using System;

class Program
{
    static int SumaIterativa(int n)
    {
        int suma = 0;
        while (n > 9)
        {
            suma += n % 10;
            n /= 10;
        }
        return suma + n;
    }

    static int SumaRecursiva(int n)
    {
        if (n <= 9)
            return n;
        else
            return SumaRecursiva(n / 10) + n % 10;
    }

    static void Main()
    {
        int numero;

        Console.Write("Ingresa un número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        int sumaIterativaResultado = SumaIterativa(numero);
        int sumaRecursivaResultado = SumaRecursiva(numero);

        Console.WriteLine("Suma iterativa: " + sumaIterativaResultado);
        Console.WriteLine("Suma recursiva: " + sumaRecursivaResultado);

        Console.ReadLine();
    }
}
