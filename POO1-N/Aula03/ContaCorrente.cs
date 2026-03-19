using Financeiro;

namespace Aula03;

public class ContaCorrente : ContaBancaria, IConta
{
    private float _taxaManutencao;
    private bool _podePedirEmprestimo;

    public float TaxaManutencao
    {
        get => _taxaManutencao;
        set => _taxaManutencao = value;
    }

    public bool PodePedirEmprestimo
    {
        get => _podePedirEmprestimo;
        set => _podePedirEmprestimo = value;
    }

    public ContaCorrente(float taxaManutencao, bool podePedirEmprestimo)
    {
        _taxaManutencao = taxaManutencao;
        _podePedirEmprestimo = podePedirEmprestimo;
    }
    public ContaCorrente()
    {
        
    }
    public float Sacar(float valor)
    {
        if (valor > Saldo )
        {
            throw new SaldoInsuficienteException("Saldo insuficiente, seu saldo é : ",saldoInsuficiente:Saldo);
        }
        
        Saldo -= valor;
        
        return Saldo;
    }

    public float Depositar(float valor)
    {
        if (valor <= 0)
        {
             throw new SaldoInsuficienteException("Deposite um Valor maior que 0 ",saldoInsuficiente:Saldo);
        }
        
        Saldo += valor;
        return Saldo;
    }
    
}