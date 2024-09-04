
try
{
    Console.WriteLine("Informe uma idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    if (idade < 0)
    {
        throw new ArgumentException("A idade não pode ser negativa.");
    }
    else if (idade == 0)
    {
        throw new NotImplementedException("A idade ainda não foi definida.");
    }
    Console.WriteLine("Informe um nome: ");
    string? name = Console.ReadLine();
    if (name == null || string.IsNullOrWhiteSpace(name)) 
    {
        throw new NullReferenceException("O nome não pode ser nulo nem vazio");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine($"ERRO: {ex.Message}");
}
catch (NotImplementedException ex)
{
    Console.WriteLine($"ERRO: {ex.Message}");
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"ERRO: {ex.Message}");
}

