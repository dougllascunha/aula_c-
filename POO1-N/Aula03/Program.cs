using Aula03;

ContaCorrente c1 = new ContaCorrente();

c1.Saldo = 100;

try
{
    c1.Sacar(1500);
}
catch (SaldoInsuficienteExeption e)
{
    Console.WriteLine($"{e.Message}: {e.SaldoInsuficiente}");

}








// using Aula03;
// using Financeiro;
//
// int opcao;
// do
// {
//     Console.WriteLine("BEM-VINDO AO SISTEMA DE GERENCIAMENTO DE CLIENTES");
//     Console.WriteLine("Selecione uma das opções abaixo: ");
//     Console.WriteLine("Para Criar Conta Tecle (1). ");
//     Console.WriteLine("Para Sacar Tecle       (2). ");
//     Console.WriteLine("Para Depositos Tecle   (3). ");
//     Console.WriteLine("Para Consultar Salto   (4). ");
//     Console.WriteLine("Para Sair Tecle        (0). ");
//     
//     opcao = Convert.ToInt32(Console.ReadLine());
//     ContaCorrente conta = new ContaCorrente((float)2.2,true,"Douglas",007,1000,007-7,true); 
//     switch (opcao)
//     {
//         case 1: 
//             
//             Console.Write("Digite o Nome do Titular: ");
//             conta.Titular = Console.ReadLine();
//
//             Console.Write("Digite o Número da Agência: ");
//             conta.Numero = Console.ReadLine();
//
//             Console.Write("Digite o Número do Banco: ");
//             conta.Banco = Console.ReadLine();
//             
//             Console.WriteLine("CONTA CRIADA COM SUCESSO !!! ");
//             
//             break;
//         
//         case 2:
//             
//             Console.Write("Digite Quando Deseja Sacar:  ");
//             conta.Sacar(Convert.ToInt32(Console.ReadLine()));
//             Console.WriteLine("SAQUE COM SUCESSO !!! ");
//             break;
//         
//         case 3:
//             Console.Write("Digite O Valor do Deposito:  ");
//             conta.Depositar(Convert.ToInt32(Console.ReadLine()));
//             Console.WriteLine("DEPOSITO COM SUCESSO !!! ");
//             break;
//             
//     }
//         
//     
//
// } while (opcao != 0 );
//
//
//
//
//
//
//
//
//
//

// conta.Saldo = 0;
// conta.Banco = 10;
// conta.Agencia = "0001-7";
//
//
//
//
// Console.WriteLine(" Titular__________: "+conta.Titular);
// Console.WriteLine(" Número da Conta__: "+conta.Numero);
// Console.WriteLine(" Saldo da Conta___: "+conta.Saldo);
// Console.WriteLine(" Número do Banco__: "+conta.Banco);
// Console.WriteLine(" Número da Agência: "+conta.Agencia);
// Console.WriteLine("########################################");
// Console.WriteLine("   ");
//
// Console.WriteLine("Faça um depósito para abertura de conta. \n O valor dever ser maior que zero: ");
// float deposito = (float)Convert.ToDouble(Console.ReadLine());
// conta.Depositar((float)deposito);
//
// Console.WriteLine("O Novo Saldo da conta é : " + conta.Saldo);
//
// //Console.WriteLine(" Status da Conta__: "+conta.EstaAtiva);
