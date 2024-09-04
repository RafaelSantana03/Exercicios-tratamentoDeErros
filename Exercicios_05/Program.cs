
using System;

int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"{i} - {numeros[i]}");
}
try
{
    Console.WriteLine("\nInforme o valor de um índice: ");
    int indice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(numeros[indice]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"ERRO: {ex.Message}");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"ERRO: {ex.Message}");
}

Console.ReadKey();