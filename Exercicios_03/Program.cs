

using System.Linq.Expressions;
string valor = null;
try
{
    Console.WriteLine("Informe um valor do tipo string: ");
    valor = Console.ReadLine();
    
    if(valor == null)
    {
        throw new ArgumentNullException("A entrada não pode ser nula.");
    }
    else if (string.IsNullOrWhiteSpace(valor))
    {
        throw new ArgumentException("A entrada não pode estar vazia.");
    }
    else
    {
        Console.WriteLine("Entrada: " + valor); // Exibe a entrada 
    }
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Erro : {ex.Message}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro : { ex.Message}");
}
finally
{
    Console.WriteLine($"Fim do programa");
}
