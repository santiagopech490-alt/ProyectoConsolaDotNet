using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Evaluador de Números (Tarea 3) ---");
        
        // Solicitar los números
        Console.Write("Número 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Número 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Número 3: ");
        int c = int.Parse(Console.ReadLine());

        // Lógica: Encontrar el menor
        int menor = a;
        if (b < menor) menor = b;
        if (c < menor) menor = c;

        Console.WriteLine($"\nEl número menor es: {menor}");

        // Lógica: ¿Es primo?
        bool esPrimo = true;
        if (menor <= 1) esPrimo = false;
        for (int i = 2; i < menor; i++) {
            if (menor % i == 0) {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo) Console.WriteLine($"{menor} es PRIMO.");
        else Console.WriteLine($"{menor} NO es primo.");
    }
}