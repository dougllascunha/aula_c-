namespace Aula03;

public class SaldoInsuficienteException : Exception
{
    private float _saldoInsuficiente;

    public float SaldoInsuficiente { get => _saldoInsuficiente; }

    public SaldoInsuficienteException(string? message, float saldoInsuficiente) : base(message)
    {
        this._saldoInsuficiente =  saldoInsuficiente;
    }
    
}

