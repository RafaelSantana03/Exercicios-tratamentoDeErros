
using System.ComponentModel.Design;

try
{
    int saldo = 200;
    int valorSaque = 100;
    if (valorSaque > saldo)
    {
        throw new SaldoInsuficienteException("O saldo é insuficiente para este saque.");
    }
    saldo -= valorSaque;
    Console.WriteLine("Saque efetuado com sucesso. Novo saldo: " + saldo);
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine("Erro: " + e.Message);
}

Console.ReadKey();
public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() : base()
    {
    }

    public SaldoInsuficienteException(string mensagem) : base(mensagem)
    {
    }

    public SaldoInsuficienteException(string mensagem, Exception innerException) : base(mensagem, innerException) { }

}