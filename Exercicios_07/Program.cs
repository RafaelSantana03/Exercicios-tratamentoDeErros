﻿MeuMetodo(-5);

static void MeuMetodo(int valor)
{
    try
    {
        if (valor < 0)
        {
            throw new MinhaException("Valor negativo não permitido.");
        }
        else if (valor > 100)
        {
            throw new ArgumentException("O valor não pode ser maior que 100.");
        }
        Console.WriteLine("O valor é válido.");
    }
    catch (MinhaException e) when (valor < 0)
    {
        Console.WriteLine("Erro: " + e.Message);
    }
    catch (ArgumentException e) when (valor > 100)
    {
        Console.WriteLine("Erro: " + e.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine("Erro genérico: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Método concluído.");
    }
}

public class MinhaException : Exception
{
    public MinhaException() { }
    public MinhaException(string message) : base(message) { }
}