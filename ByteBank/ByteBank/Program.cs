using ByteBank.Contas;
using ByteBank.Titular;

/*ContaCorrente ContadoAndre = new ContaCorrente();

ContadoAndre.titular = "André Silva";
ContadoAndre.num_agencia = 15;
ContadoAndre.conta = "1010-X";
ContadoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André: R$ " + ContadoAndre.saldo);

/* Valores de referência: compara o endereço da memória, não os valores das variáveis
ContaCorrente ContadoAndre2 = new ContaCorrente();

ContadoAndre2.titular = "André Silva";
ContadoAndre2.num_agencia = 15;
ContadoAndre2.conta = "1010-X";
ContadoAndre2.saldo = 100;

Console.WriteLine("Saldo da conta do André: R$ " + ContadoAndre2.saldo);

ContadoAndre = ContadoAndre2;
Console.WriteLine(ContadoAndre==ContadoAndre2);
*/

/*//depositando R$100 na conta do André
ContadoAndre.Depositar(100);
Console.WriteLine("Saldo da conta do André pós depósito: R$ " + ContadoAndre.saldo);

//sacando R$100 na conta do André
if (ContadoAndre.Sacar(100)==true)
{
Console.WriteLine("Saldo da conta do André pós saque: R$ " + ContadoAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para saque!");
}

ContaCorrente ContadoJose = new ContaCorrente();

ContadoJose.titular = "José Gomes";
ContadoJose.num_agencia = 16;
ContadoJose.conta = "8594-6";
ContadoJose.saldo = 503;

Console.WriteLine();
Console.WriteLine("Saldo da conta do José: R$ " + ContadoJose.saldo);

ContaCorrente ContadaMaria = new ContaCorrente();

ContadaMaria.titular = "Maria Souza";
ContadaMaria.num_agencia = 17;
ContadaMaria.conta = "1018-5";
ContadaMaria.saldo = 350;

Console.WriteLine();
Console.WriteLine("Saldo da conta da Maria: R$ " + ContadaMaria.saldo);

//transferindo da conta do André para a conta da Maria
ContadoAndre.Transferir(50, ContadaMaria);

Console.WriteLine("Saldo do André: R$ "+ContadoAndre.saldo);
Console.WriteLine("Saldo da Maria: R$ " + ContadaMaria.saldo);

ContaCorrente ContadoPedro = new ContaCorrente();

ContadoPedro.titular = "Pedro";

Console.WriteLine(ContadoPedro.titular);
Console.WriteLine(ContadoPedro.saldo);
Console.WriteLine(ContadoPedro.num_agencia);
Console.WriteLine(ContadoPedro.conta);

/* valores padrão:
 * para TIPOS NUMÉRICOS o valor padrão é 0
 * para STRING o valor padrão é Nulo
 * para BOOLEANO o valor padrão é False
 */

Cliente cliente = new Cliente();
cliente.nome = "André Silva";
cliente.cpf = "1235465484";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-X";
conta.num_agencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular: "+ conta.titular.nome);
Console.WriteLine("CPF: " + conta.titular.cpf);
Console.WriteLine("Profissão: " + conta.titular.profissao);
Console.WriteLine("Nº Conta: " + conta.conta);
Console.WriteLine("Nº Agência: " + conta.num_agencia);
Console.WriteLine("Saldo: " + conta.saldo);

//criando nova conta corrente e novo cliente, em ambas as classes
ContaCorrente conta2 = new ContaCorrente();
conta2.titular = new Cliente();
conta2.titular.nome = "José Silva";
conta2.titular.profissao = "Tester";
conta2.titular.cpf = "12345678911";
conta2.conta = "9999-x";
conta2.num_agencia = 18;
conta2.saldo = 500;

Console.WriteLine(conta2.titular.nome);
