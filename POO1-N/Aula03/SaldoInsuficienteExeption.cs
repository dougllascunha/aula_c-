namespace Aula03;

public class SaldoInsuficienteExeption : Exception
{
    private float _saldoInsuficiente;

    public float SaldoInsuficiente { get => _saldoInsuficiente; }

    public SaldoInsuficienteExeption(string? message, float saldoInsuficiente) : base(message)
    {
        this._saldoInsuficiente =  SaldoInsuficiente;
    }
    
}

