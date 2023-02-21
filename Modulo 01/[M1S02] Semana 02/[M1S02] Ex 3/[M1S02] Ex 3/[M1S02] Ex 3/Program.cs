using Exercicios03ao06;
using Exercicios03ao06.Classes.Enum;

ContaBancaria conta = new ContaBancaria();

conta.numero = 2222;
conta.agencia = 1234;
conta.nomeDoTitular = "Soraia Cunha";
conta.tipoConta = TipoContaEnum.POUPANCA;

// testando metodo depositar
conta.Depositar(200);

// testando metodo sacar 
conta.Sacar(50);

// testando método exibir saldo
conta.ExibirSaldo();