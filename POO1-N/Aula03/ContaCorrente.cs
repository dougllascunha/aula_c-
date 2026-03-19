using Financeiro;

namespace Aula03;

public class ContaCorrente : ContaBancaria, IConta
{
    private float _taxaManutencao;
    private bool _podePedirEmprestimo;

    public ContaCorrente(float taxaManutencao, bool podePedirEmprestimo, string titular, string numero, float saldo, string banco, string agencia, bool estaAtiva): base(titular, numero, saldo,banco,agencia,true)
    {
        _taxaManutencao = taxaManutencao;
        _podePedirEmprestimo = podePedirEmprestimo;
    }
    

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

    public float Sacar(float valor)
    {
        if (valor > Saldo || valor <= 0 )
        {
            throw new SaldoInsuficienteExeption("Saldo insuficiente",saldoInsuficiente: Saldo);
        }
        
        Saldo -= valor;
        
        return Saldo;
    }

    public float Depositar(float valor)
    {
        if (valor <= 0)
        {
            //Lançar Exceção
        }
        
        Saldo += valor;
        return Saldo;
    }
    
}