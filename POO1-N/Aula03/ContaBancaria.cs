using System.Transactions;

namespace Financeiro;

public class ContaBancaria
{
    //variáveis
    private string _titular;
    private string _numero;
    private float _saldo = (float)0.0;
    private string _banco;
    private string _agencia;
    private bool _estaAtiva;

    public ContaBancaria(string titular, string numero, float saldo, string banco, string agencia, bool estaAtiva)
    {
        _titular = titular;
        _numero = numero;
        _saldo = saldo;
        _banco = banco;
        _agencia = agencia;
        _estaAtiva = estaAtiva;
    }
    public ContaBancaria()
    {
        
    }

    public string Titular
    {
        get => _titular;
        set => _titular = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Numero
    {
        get => _numero;
        set => _numero = value ?? throw new ArgumentNullException(nameof(value));
    }

    public float Saldo
    {
        get => _saldo;
        set => _saldo = value;
    }

    public string Banco
    {
        get => _banco;
        set => _banco = value;
    }

    public string Agencia
    {
        get => _agencia;
        set => _agencia = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool EstaAtiva
    {
        get => _estaAtiva;
        set => _estaAtiva = value;
    }

    public float Sacar(float saque)
    {
        if (this._saldo >= saque)
        {
            this._saldo -= saque;
            return this._saldo;
        }
        else
        {
            return this._saldo;
        }
    }

    public float Depositar(float saque)
    {
        this._saldo += saque;
        return this._saldo;
    }


    
    
    
    
    
}
/*
 * Fortemente tipada
 * Númericos: int, long, float, doble, decimal, complex
 *                       ,32bits,64bits,128bits
 * bool
 * char,strig
 */