using ByteBank;

ContaCorrente ContadoAndre = new ContaCorrente();

ContadoAndre.titular = "André Silva";
ContadoAndre.num_agencia = 15;
ContadoAndre.conta = "1010-X";
ContadoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André: R$ " + ContadoAndre.saldo);

ContaCorrente ContadoJose = new ContaCorrente();

ContadoJose.titular = "José Gomes";
ContadoJose.num_agencia = 16;
ContadoJose.conta = "8594-6";
ContadoJose.saldo = 503;

Console.WriteLine("Saldo da conta do José: R$ " + ContadoJose.saldo);

ContaCorrente ContadaMaria = new ContaCorrente();

ContadaMaria.titular = "Maria Souza";
ContadaMaria.num_agencia = 17;
ContadaMaria.conta = "1018-5";
ContadaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria: R$ " + ContadaMaria.saldo);